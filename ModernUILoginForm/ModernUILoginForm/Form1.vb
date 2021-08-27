Public Class Form1

    Private _username As String = "SystemUser32"
    Private _password As String = "1234"

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = _username AndAlso txtPassword.Text = _password Then
            LoginSuccess()
        Else
            LoginFailed()
        End If

    End Sub

    Private Sub LoginSuccess()
        'MessageBox.Show("Test success")

        If Not CheckBox1.Checked Then
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If

        Dim app As App = New App()
        app.ShowDialog()

    End Sub

    Private Sub LoginFailed()
        MessageBox.Show("Login detais are incorrect")
    End Sub
End Class
