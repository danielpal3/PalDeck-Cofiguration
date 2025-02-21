Public Class Disconected
    Private Sub Retry_Click(sender As Object, e As EventArgs) Handles Retry.Click
        DialogResult = 1
    End Sub

    Private Sub Closeapp_Click(sender As Object, e As EventArgs) Handles Closeapp.Click
        DialogResult = 2
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Websocket_Settings.ShowDialog()

    End Sub
End Class