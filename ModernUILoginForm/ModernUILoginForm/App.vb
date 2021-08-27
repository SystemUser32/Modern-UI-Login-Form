Public Class App
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        MessageBox.Show("Closing the app will automatically log you out")
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class