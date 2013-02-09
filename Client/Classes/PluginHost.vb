Public Class PluginHost

    Implements Versidyne.Plugins.Host

    Public Sub ShowFeedback(ByVal strFeedback As String) Implements Versidyne.Plugins.Host.ShowFeedback

        MessageBox.Show(strFeedback, Application.ProductName)

    End Sub

End Class
