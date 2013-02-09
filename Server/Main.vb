Public Class Main

#Region "Callouts"

    Private WithEvents NetSocket As New Versidyne.Network.NetSock

    Private Delegate Sub SetTextCallback(ByVal Data As String)

    Private DisableTray = False

#End Region

#Region "Form Events"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Do nothing

    End Sub

    Private Sub Main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then

            Me.Hide()

        End If

    End Sub

    Private Sub Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Me.WindowState = FormWindowState.Minimized

        If DisableTray = False Then

            e.Cancel = True

        End If

    End Sub

#End Region

#Region "Form Functions"

    Private Sub DisplayData(ByVal InputText As String)

        If Me.Disposing = False Then

            If Info.ReceivedBox.Text = Nothing Then

                Info.ReceivedBox.Text = InputText

            Else

                Info.ReceivedBox.Text += vbCrLf & InputText

            End If

            'Info.ReceivedBox.SelectionStart = Info.ReceivedBox.Text.Length

        End If

    End Sub

    Private Sub DisplayConnection(ByVal InputText As String)

        If Me.Disposing = False Then

            Info.ConnectionBox.Items.Add(InputText)

        End If

    End Sub

    Private Sub DisplayError(ByVal InputText As String)

        If Me.Disposing = False Then

            If Info.ErrorBox.Text = Nothing Then

                Info.ErrorBox.Text = InputText

            Else

                Info.ErrorBox.Text += vbCrLf & InputText

            End If

            'Info.ErrorBox.SelectionStart = Info.ErrorBox.Text.Length

        End If

    End Sub

#End Region

#Region "NetSock Events"

    Public Sub NetSocketData(ByVal Data As Byte()) Handles NetSocket.DataArrival

        Dim DecodedData As String = System.Text.Encoding.UTF8.GetString(Data)

        If ConsoleBox.InvokeRequired Then

            Dim Del As New SetTextCallback(AddressOf DisplayData)
            Me.Invoke(Del, New String() {DecodedData})

        Else

            DisplayData(DecodedData)

        End If

    End Sub

    Public Sub NetSocketError(ByVal Data As String) Handles NetSocket.SocketError

        If ConsoleBox.InvokeRequired Then

            Dim Del As New SetTextCallback(AddressOf DisplayError)
            Me.Invoke(Del, New String() {Data})

        Else

            DisplayError(Data)

        End If

    End Sub

    Public Sub NetSocketConnection(ByVal ID As Integer, ByVal Connected As Boolean) Handles NetSocket.ConnectionRequest

        Dim Message As String = Nothing

        If Connected = True Then

            Message = "Client " & ID.ToString & " connected."

        Else

            Message = "Client " & ID.ToString & " disconnected."

        End If

        If ConsoleBox.InvokeRequired Then

            Dim Del As New SetTextCallback(AddressOf DisplayConnection)
            Me.Invoke(Del, New String() {Message})

        Else

            DisplayConnection(Message)

        End If

    End Sub

#End Region

#Region "Menu Items"

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click

        ToolStripStatusLabel2.Text = "Listening"

        NetSocket.Listen(7900)

    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click

        ToolStripStatusLabel2.Text = "Not Listening"

        NetSocket.StopListening()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        DisableTray = True

        Me.Close()

    End Sub

    Private Sub DisconnectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectAllToolStripMenuItem.Click

    End Sub

    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click

        Info.Show()

    End Sub

#End Region

#Region "Tray Items"

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click

        Me.Show()

        Me.WindowState = FormWindowState.Normal

    End Sub

#End Region

End Class
