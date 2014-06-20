Public Class Example

    Implements Versidyne.Plugins.Plugin

    Private ObjHost As Versidyne.Plugins.Host

    Public Sub Initialize(ByVal Host As Versidyne.Plugins.Host) Implements Versidyne.Plugins.Plugin.Initialize

        ObjHost = Host

    End Sub

    Public ReadOnly Property Title() As String Implements Versidyne.Plugins.Plugin.Title

        Get

            Return "Example"

        End Get

    End Property

    Public Function Main(ByVal Args As Array) As Integer Implements Versidyne.Plugins.Plugin.Main

        ObjHost.ShowFeedback("Example ran successfully.")

        Return 0

    End Function

End Class
