Public Class Info

    Private Sub Info_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True

        Me.Hide()

    End Sub

End Class