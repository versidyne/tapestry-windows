Public Class Example_2

    Implements Versidyne.Plugins.Plugin

    Private ObjHost As Versidyne.Plugins.Host

    Public Sub Initialize(ByVal Host As Versidyne.Plugins.Host) Implements Versidyne.Plugins.Plugin.Initialize

        ObjHost = Host

    End Sub

    Public ReadOnly Property Name() As String Implements Versidyne.Plugins.Plugin.Name

        Get

            Return "Example Plugin 2"

        End Get

    End Property

    Public Function Main(ByVal Args As Array) As Integer Implements Versidyne.Plugins.Plugin.Main

        ObjHost.ShowFeedback("Main function test.")

        Return 0

    End Function

End Class
