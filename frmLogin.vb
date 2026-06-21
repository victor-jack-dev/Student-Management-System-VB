Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "Vic" And txtPassword.Text = "1234" Then

            frmDashboard.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid username or password!")

        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

End Class