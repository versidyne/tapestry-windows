Public Class Update

#Region "Callouts"

    Private APIClient As New Net.WebClient()
    Private PatchPath As String = My.Application.Info.DirectoryPath & "\Update\"

#End Region

#Region "Form Events"

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback
        AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileCallBack

    End Sub

#End Region

#Region "Download Handlers"

    Private Sub DownloadProgressCallback(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)

        ProgressBar1.Value = e.ProgressPercentage
        ToolStripStatus.Text = (e.ProgressPercentage.ToString & " Percent Downloaded")

    End Sub

    Private Sub DownloadFileCallBack(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        ProgressBar1.Maximum = 100

        Try
            Dim doc = XDocument.Load(PatchPath & "list.xml")

            Dim updates = From Apps In doc.Descendants() Select New With {.vexis = Apps.Element("vexis-windows").Value}
            Dim update = updates(0)

            CurrentVersionLabel.Text = My.Application.Info.Version.ToString
            LatestVersionLabel.Text = update.vexis

            If update.vexis = My.Application.Info.Version.ToString Then
                ToolStripStatus.Text = "Latest Version Installed!"
            Else
                ToolStripStatus.Text = "Update Required!"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

#Region "Functions"

    Private Sub DownloadFile(ByVal URL As String, ByVal Path As String, ByVal FileName As String)

        If IO.Directory.Exists(Path) = False Then
            IO.Directory.CreateDirectory(Path)
        End If

        If IO.File.Exists(Path & FileName) = False Then
            IO.File.Create(Path & FileName)
        End If

        APIClient.DownloadFileAsync(New Uri(URL), Path & FileName)

    End Sub

#End Region

#Region "Buttons"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

        DownloadFile("http://api.versidyne.com/?update=list", PatchPath, "list.xml")
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click

        DownloadFile("http://api.versidyne.com/?update=vexis-windows", PatchPath, "vexis-windows.zip")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles InstallButton.Click

        'TODO: Add Zip Class and Run Installer
        'Dim zipfile As New FastZip
        Try
            If IO.File.Exists(PatchPath & "vexis-windows.zip") Then
                ToolStripStatus.Text = " Installed!"
                IO.File.Delete(PatchPath & "vexis-windows.zip")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

End Class