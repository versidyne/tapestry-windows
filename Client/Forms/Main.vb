Public Class Main

#Region "Callouts"

    'Children
    Private AboutChild As New About
    Private ChannelsChild As New Channels
    Private LoginChild As New Login
    Private PluginsChild As New Plugins

    'Controls
    Friend WithEvents NetSocket As New Versidyne.Network.NetSock
    Private Protocol As New Versidyne.Protocols.VADP
    Friend NetGet As New Versidyne.Network.Http

    'Delegates
    Private Delegate Sub SetTextCallback(ByVal Data As String)

    'Profile
    Private Username As String = "guest@versidyne.com"
    Friend Session As String = "0"
    Private NickName As String = "Guest"
    'Application
    Private Arguments As String()
    Private IsLocal As Boolean = False
    Private DisableTray = False
    'Security
    Private EncPass As String = Nothing
    Private CustomEncPass As String = Nothing
    Private Encryption As Boolean = False
    Private CustomEncryption As Boolean = False
    'Other
    Friend Conversations As New ArrayList

#End Region

    'Events

#Region "Form Events"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Check for Arguments
        Arguments = Environment.GetCommandLineArgs()

        'Handle Arguments
        If Arguments.Contains("local") Then

            IsLocal = True

        End If

        'Check for Design Mode
        'If Me.DesignMode Then
        'End If

        'Login Design Disables
        ChatToolStripMenuItem.Enabled = False
        ChannelsToolStripMenuItem.Enabled = False
        ContactsToolStripMenuItem.Enabled = False
        SecurityToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False

        'Normal Usage Disables
        OffToolStripMenuItem.Enabled = False

        'Disable Features
        EditToolStripMenuItem2.Visible = False

        'Check for debugger
        If Debugger.IsAttached Then

            'IsLocal = True
            'Connect()
            'ChatToolStripMenuItem.Enabled = True
            'LogoutToolStripMenuItem.Enabled = True

        End If

    End Sub

    Private Sub Main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then

            Me.Hide()

            TrayIcon.ShowBalloonTip(10, "", "Vexis will continue to run in the background.", ToolTipIcon.Info)

        End If

    End Sub

    Private Sub Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Me.WindowState = FormWindowState.Minimized

        If DisableTray = False Then

            e.Cancel = True

        End If

    End Sub

#End Region

#Region "NetSock Events"

    Private Sub NetSocketData(ByVal Data As Byte()) Handles NetSocket.DataArrival

        Dim DataString As String = System.Text.Encoding.UTF8.GetString(Data)
        'Dim DecodedData As String()= ProtocolHandler(DataString)

        'If Chat.ChatOutput.InvokeRequired Then

        'Dim Del As New SetTextCallback(AddressOf Chat.DisplayText)
        'Me.Invoke(Del, New String() {DecodedData(0), DecodedData(1), DecodedData(2)})
        Dim Del As New SetTextCallback(AddressOf ProtocolHandler)
        Me.Invoke(Del, New String() {DataString})


        'Else

        'Chat.DisplayText(DecodedData(0), DecodedData(1), DecodedData(2))
        'ProtocolHandler(DataString)

        'End If

    End Sub

    Private Sub NetSocketError(ByVal Data As String) Handles NetSocket.SocketError

        MsgBox("Error: " & Data)

    End Sub

    Private Sub NetSocketConnection(ByVal Data As Boolean) Handles NetSocket.Connection

        If Data = True Then

            ToolStripStatusLabel2.Text = "Connected"

            ChatToolStripMenuItem.Enabled = True
            ChannelsToolStripMenuItem.Enabled = True
            ContactsToolStripMenuItem.Enabled = True
            SecurityToolStripMenuItem.Enabled = True
            LoginToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Enabled = True

        Else

            ToolStripStatusLabel2.Text = "Disconnected"

            ChatToolStripMenuItem.Enabled = False
            ChannelsToolStripMenuItem.Enabled = False
            ContactsToolStripMenuItem.Enabled = False
            SecurityToolStripMenuItem.Enabled = False
            LoginToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Enabled = False

        End If

    End Sub

#End Region

    'Functions

#Region "NetSock Functions"

    Friend Sub SendText(ByVal ToString As String, ByVal Text As String)

        If CustomEncryption = True Then

            Dim Encrypter As New Versidyne.Security.Rijndael

            Text = Encrypter.StringEncrypt(Text, CustomEncPass)

            SendData(Protocol.Encode(ToString, NickName, "CEncText", Text))

        ElseIf Encryption = True Then

            Dim Encrypter As New Versidyne.Security.Rijndael

            Text = Encrypter.StringEncrypt(Text, EncPass)

            SendData(Protocol.Encode(ToString, NickName, "EncText", Text))

        Else

            SendData(Protocol.Encode(ToString, NickName, "Text", Text))

        End If

    End Sub

    Private Sub SendData(ByVal Data As String)

        'Encrypt here

        Dim DataBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(Data)

        NetSocket.SendData(DataBytes)

    End Sub

#End Region

#Region "NetGet Functions"

    Friend Function WebLogin(ByVal Email As String, ByVal Password As String) As Boolean

        Dim Url As String = "http://api.versidyne.com/?login=" & Email & "&pass=" & Password

        Dim WebData As String = NetGet.Retreive(Url)

        If WebData = "0" Then

            Return False

        Else

            Session = WebData
            Username = Email
            NickName = Username

            RefreshContacts()
            RetreiveNickname()
            Connect()

            Return True

        End If

    End Function

    Private Sub RetreiveNickname()

        NickName = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=profile")

    End Sub

    Private Sub RetreiveEncryption()

        EncPass = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=encpass")

    End Sub

    Private Sub RefreshContacts()

        BuddyList.Items.Clear()

        Dim RawContacts As String = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=associates")
        Dim Contacts As Array = Split(RawContacts, "<|(row)|>")
        Dim Contact As String = Nothing
        Dim Info As String() = Nothing

        For Each Contact In Contacts

            If Contact.Contains("<|(cell)|>") Then

                Info = Split(Contact, "<|(cell)|>")

                If Info(2) = "online" Then

                    BuddyList.Items.Add(Info(1), 1)

                Else

                    BuddyList.Items.Add(Info(1), 0)

                End If

            End If

        Next

    End Sub

    Private Sub Connect()

        'Connect to server

        If IsLocal Then

            NetSocket.Connect("localhost", 7900)

        Else

            Dim ServerInfo As String = NetGet.Retreive("http://api.versidyne.com/?session=" + Session + "&info=serverlocation")
            Dim Parts As String() = Split(ServerInfo, ":")

            NetSocket.Connect(Parts(0), Parts(1))

        End If

    End Sub

#End Region

#Region "Protocol Functions"

    Private Sub ProtocolHandler(ByVal DataString As String)

        Dim DecodedData As Array = Protocol.Decode(DataString)
        'Dim ReturnData As String() = Nothing
        Dim TextFont As Font

        If DecodedData.Length = 1 Then

            'There is nothing to do because the data was either empty or unformatted.
            'Return ReturnData

        Else

            Dim Sender As String = Nothing
            Dim Data As String = Nothing

            Dim EncCheck As Boolean

            If Encryption = True Then

                EncCheck = True

            ElseIf CustomEncryption = True Then

                EncCheck = True

            Else

                EncCheck = False

            End If

            If EncCheck = True Then

                If DecodedData(4) = "Text" Then

                    Sender = DecodedData(3)
                    Data = DecodedData(5)

                ElseIf DecodedData(4) = "EncText" Then

                    Dim Encrypter As New Versidyne.Security.Rijndael

                    Sender = DecodedData(3)
                    Data = Encrypter.StringDecrypt(DecodedData(5), EncPass)

                ElseIf DecodedData(4) = "CEncText" Then

                    Dim Encrypter As New Versidyne.Security.Rijndael

                    Sender = DecodedData(3)
                    Data = Encrypter.StringDecrypt(DecodedData(5), CustomEncPass)

                Else

                    Sender = DecodedData(3)
                    Data = DecodedData(5)

                End If

            Else

                Sender = DecodedData(3)
                Data = DecodedData(5)

            End If

            If Data.Replace(" ", Nothing) = Nothing Then

                'Return ReturnData

            Else

                'ReturnData = New String() {Sender, DecodedData(2), Data}

                'Return ReturnData

                TextFont = New Font("Calibri", 9.75, FontStyle.Regular)
                TextFont = Chat.UserInput.Font

                Chat.DisplayText(Sender, DecodedData(2), Data, TextFont)

            End If

        End If

    End Sub

#End Region

    'Buttons

#Region "Menu Items"

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If NetSocket.Connected Then

            LogoutToolStripMenuItem.PerformClick()

        End If

        DisableTray = True

        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutChild = New About

        AboutChild.Show()

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click

        BuddyList.Items.Add("new@versidyne.com", 0)

    End Sub

    Private Sub ChannelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChannelsToolStripMenuItem.Click

        ChannelsChild = New Channels

        ChannelsChild.Show()

    End Sub

    Private Sub ChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChatToolStripMenuItem.Click

        Chat.Show()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

        LoginChild = New Login

        LoginChild.Show()

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click

        RefreshContacts()

    End Sub

    'Security

    Private Sub OnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnToolStripMenuItem.Click

        RetreiveEncryption()

        Encryption = True

        OnToolStripMenuItem.Enabled = False
        OffToolStripMenuItem.Enabled = True

    End Sub

    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click

        Encryption = False
        CustomEncryption = False

        EncPass = Nothing
        CustomEncPass = Nothing

        CustomToolStripMenuItem.Enabled = True
        OnToolStripMenuItem.Enabled = True
        OffToolStripMenuItem.Enabled = False

    End Sub

    Private Sub CustomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomToolStripMenuItem.Click

        Dim InputPass As String = InputBox("What would you like the password to be?", "Custom Encryption", Nothing)

        If InputPass = Nothing Then

            MsgBox("A password is required for custom encryption.")

        Else

            CustomEncPass = InputPass

            CustomEncryption = True

            CustomToolStripMenuItem.Enabled = False
            OffToolStripMenuItem.Enabled = True

        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        If NetSocket.Connected Then

            NetSocket.Disconnect()

        End If

    End Sub

    Private Sub PluginsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PluginsToolStripMenuItem.Click

        PluginsChild = New Plugins

        PluginsChild.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        ExitToolStripMenuItem.PerformClick()

    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click

        If BuddyList.SelectedItems.Count > 0 Then

            Dim Buddy As ListViewItem

            For Each Buddy In BuddyList.SelectedItems

                Buddy.Remove()

            Next

        End If

    End Sub

    Private Sub EditToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem2.Click

        If BuddyList.SelectedItems.Count > 0 Then

            Dim Buddy As ListViewItem

            For Each Buddy In BuddyList.SelectedItems

                Buddy.Text = "edited@versidyne.com"

            Next

        End If

    End Sub

#End Region

#Region "Notify Icon"

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click

        Me.Show()

        Me.WindowState = FormWindowState.Normal

    End Sub

#End Region

End Class