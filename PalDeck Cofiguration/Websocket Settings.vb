Public Class Websocket_Settings
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        My.Settings.ip = Nothing
        My.Settings.ip = ipval.Text.ToString
        My.Settings.port = Nothing
        My.Settings.port = port.Text.ToString
        My.Settings.password = Nothing
        My.Settings.password = passval.Text.ToString
        My.Settings.Save()
        Me.Close()
    End Sub
End Class