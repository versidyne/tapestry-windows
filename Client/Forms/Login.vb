Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Cursor = Cursors.WaitCursor

        If Main.WebLogin(EmailTextBox.Text, PasswordTextBox.Text) = False Then

            MsgBox("The system was unable to log you in because the email address you entered is not registered to an account or the password is incorrect.")

            PasswordTextBox.Text = Nothing

        Else

            Me.Close()

        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EmailTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then

            PasswordTextBox.Focus()

        End If

    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then

            Button1.PerformClick()

        End If

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EmailTextBox.Focus()

    End Sub

End Class