

Public Class Chat

#Region "Events"

    Private Sub UserInput_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UserInput.KeyDown

        If e.Shift Then

            'Do Nothing

        ElseIf e.KeyCode = Keys.Enter Then

            SendInput()

            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub Chat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChatOutput.ReadOnly = True
        'TabControl.TabPages.Remove(TabPage)
        UserInput.Focus()

        Main.AllowDrop = True
        ChannelTabs.AllowDrop = True
        MainContainer.AllowDrop = True
        MainContainer.Panel2.AllowDrop = True
        UserInput.AllowDrop = True
        InputContainer.AllowDrop = True

        CreateChannelTab("Test1", "Test1")
        CreateChannelTab("Test2", "Test2")
        CreateChannelTab("Test3", "Test3")
        CreateChannelTab("Test4", "Test4")

    End Sub

    Private Function CreateChannelTab(ByVal Caption As String, ByVal TabName As String) As TabPage

        Dim NewForm As New Chat
        Dim NewTab As TabPage = NewForm.ChannelTab

        NewTab.Text = Caption
        NewTab.Name = TabName

        ChannelTabs.TabPages.Add(NewTab)

        NewForm.Dispose()

        Return NewTab

    End Function

    Private Sub Chat_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True

        Me.Hide()

    End Sub

    Private Sub ChatOutput_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles ChatOutput.LinkClicked

        System.Diagnostics.Process.Start(e.LinkText)

    End Sub

    Private Sub UserInput_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles UserInput.DragEnter

        If e.Data.GetDataPresent(DataFormats.Text) Then

            e.Effect = DragDropEffects.Copy
            MsgBox("Text attempt")

        ElseIf e.Data.GetDataPresent(DataFormats.WaveAudio) Then

            MsgBox("Music will soon be supported")

        Else

            e.Effect = DragDropEffects.None

        End If

    End Sub

    Private Sub UserInput_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) 'Handles UserInput.DragDrop

    End Sub

#End Region

#Region "Functions"

    Private Sub LoadImage()

        Dim OrgData = Clipboard.GetDataObject

        OpenFileDialog.Filter = "All files |*.*"
        OpenFileDialog.Multiselect = True

        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each Filename As String In OpenFileDialog.FileNames

                AddImage(Filename)

            Next

        End If

        Clipboard.SetDataObject(OrgData)

    End Sub

    Private Sub AddImage(ByVal ImageLocation As String)

        Dim LoadedImage As Image = Image.FromFile(ImageLocation)

        Clipboard.SetImage(LoadedImage)
        UserInput.Paste()

    End Sub

    Private Sub SendInput()

        If Main.NetSocket.Connected = True Then

            Dim UserInputString As String = UserInput.Text

            UserInput.Text = Nothing

            Main.SendText("All", UserInputString)

        End If

    End Sub

    Public Sub DisplayText(ByVal Sender As String, ByVal Receiver As String, ByVal Text As String, ByVal TextFont As Font)

        'Dim RtfFormat As TextDataFormat = TextDataFormat.Rtf

        'ChatOutput.SelectionFont = TextFont

        If ChatOutput.Text = Nothing Then

            'ChatOutput.Rtf = Text
            'ChatOutput.AppendText(vbCrLf)

        Else

            'ChatOutput.AppendText(vbCrLf)
            'Dim Temp As String = ChatOutput.Rtf
            'Temp += Text
            'MsgBox(Temp)
            'ChatOutput.Rtf = Temp
            'Dim Data As New DataObject
            'Data.SetData(DataFormats.Rtf, Text)
            'Clipboard.SetDataObject(Data)
            'ChatOutput.Paste(Data.GetData(DataFormats.Rtf))
            ChatOutput.AppendText(vbCrLf)

        End If

        ChatOutput.AppendText(Sender & ": ")
        ChatOutput.Text += Text
        ChatOutput.SelectionStart = ChatOutput.Text.Length

    End Sub

#End Region

    Private Sub Chat_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        InputContainer.SplitterDistance = 27

    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click

        Clipboard.Clear()

        'Clipboard.SetText(UserInput.SelectedRtf, TextDataFormat.Rtf)

        'UserInput.SelectedRtf = Nothing

        UserInput.Cut()

    End Sub

    Private Sub FontToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripButton.Click

        Dim SelectedFont As Font

        FontDialog1.Font = UserInput.SelectionFont
        FontDialog1.ShowDialog()
        SelectedFont = FontDialog1.Font

        UserInput.SelectionFont = SelectedFont

    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click

        Clipboard.Clear()

        'Clipboard.SetText(UserInput.SelectedRtf, TextDataFormat.Rtf)

        UserInput.Copy()

    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click

        'UserInput.SelectedRtf = Clipboard.GetText()

        UserInput.Paste()

    End Sub

End Class