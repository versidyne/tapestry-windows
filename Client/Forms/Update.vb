Public Class Update

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim APIClient As New Net.WebClient()
        Dim URL As New Uri("http://api.versidyne.com/?session=12345&update=vexis-windows")
        Dim file As String = My.Application.Info.DirectoryPath & "\Patch\update.xml"

        AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback
        AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileCallBack2

        APIClient.DownloadFileAsync(URL, file)

    End Sub



End Class