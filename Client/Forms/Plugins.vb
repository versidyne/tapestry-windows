Public Class Plugins

    Private Plugins() As Versidyne.Plugins.Services.AvailablePlugin
    Private ObjHost As Versidyne.Plugins.Host

    Private Sub Plugins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RetreivePlugins()

    End Sub

    Private Sub RetreivePlugins()

        Plugins = Versidyne.Plugins.Services.FindPlugins(IO.Path.GetDirectoryName(Application.ExecutablePath), "Versidyne.Plugins.Plugin")

        If Plugins Is Nothing Then

            ListView1.Items.Clear()
            ListView1.Items.Add("No plugins available")

        Else

            AddDescriptions()

            ObjHost = New PluginHost

        End If

    End Sub

    Private Sub AddDescriptions()

        Dim ObjPlugin As Versidyne.Plugins.Plugin
        Dim IntIndex As Int64

        'Loop through available plugins, creating instances and adding them to listbox
        For IntIndex = 0 To Plugins.Length - 1

            ObjPlugin = DirectCast(Versidyne.Plugins.Services.CreateInstance(Plugins(IntIndex)), Versidyne.Plugins.Plugin)
            ListView1.Items.Add(ObjPlugin.Name, 0)

        Next

        'ListBox1.SelectedIndex = 0
        ListView1.SelectedItems.Clear()

    End Sub

    Private Sub Enable()

        Dim ObjPlugin As Versidyne.Plugins.Plugin
        Dim ReturnCode As Integer
        Dim Args As Array = Nothing

        'Retreive Selected Data
        Dim SelPlugins As ListView.SelectedListViewItemCollection
        Dim SelPlugin As ListViewItem

        SelPlugins = ListView1.SelectedItems

        For Each SelPlugin In SelPlugins

            'Create and initialize plugin
            ObjPlugin = DirectCast(Versidyne.Plugins.Services.CreateInstance(Plugins(SelPlugin.Index)), Versidyne.Plugins.Plugin)
            ObjPlugin.Initialize(ObjHost)

            'Begin threading here, since this is where blocking should start

            'Run calculation and return result
            Try

                ReturnCode = ObjPlugin.Main(Args)

                If ReturnCode > 0 Then

                    MessageBox.Show("Plugin received return code: " & ReturnCode, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If

            Catch

                MessageBox.Show("Plugin failed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub

            End Try

            'End threading here

        Next

    End Sub

    Private Sub Disable()

        'End particular thread

    End Sub

    Private Sub EnableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem.Click

        Enable()

    End Sub

    Private Sub DisableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem.Click

        Disable()

    End Sub

End Class