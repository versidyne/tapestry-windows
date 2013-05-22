Public Class Update

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Downloads update.xml
        Dim myClient As New Net.WebClient()
        Dim url As New Uri("http://api.versidyne.com/?session=12345&update=vexis-windows")
        Dim file As String = My.Application.Info.DirectoryPath & "\Patch\updater.xml"

        AddHandler myClient.DownloadProgressChanged, AddressOf DownloadProgressCallback

        AddHandler myClient.DownloadFileCompleted, AddressOf DownloadFileCallBack2

        myClient.DownloadFileAsync(url, file)
    End Sub

End Class