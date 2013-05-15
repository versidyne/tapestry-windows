Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set the title of the form.
        Dim ApplicationTitle As String

        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Me.Text = String.Format("About {0}", ApplicationTitle)

        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        DescriptionBox.Text = My.Application.Info.Description

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

End Class