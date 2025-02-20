Imports Websocket

Public Class Audio_link_to_scene
    Private Sub Audio_link_to_scene_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim i As Integer
        i = 1
        Dim checkbox As CheckBox

        For Each item In Form1.ComboBox1.Items
            ComboBox1.Items.Add(item.ToString)
        Next

        For Each aitem In Form1.ComboBox2.Items
            Dim name As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name)
            checkbox.Text = aitem
            checkbox.Visible = True
            If i = Form1.ComboBox2.Items.Count Then
                GoTo Finish
            End If
            i = i + 1
        Next
Finish:
    End Sub

    Private Sub sav1_Click(sender As Object, e As EventArgs) Handles sav1.Click
        Dim checkbox As CheckBox
        Dim test As Integer
        test = Form1.ComboBox2.Items.Count
        Dim str As String

        Label3.Text = ComboBox1.SelectedItem.ToString & Environment.NewLine
        For i = 1 To test
            Dim name As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name)

            If checkbox.Checked = True Then
                str = checkbox.Text
                Label3.Text = Label3.Text & Environment.NewLine & str
            End If

        Next

        Dim TestToSplit As String = Label3.Text
        Dim Splitted() As String = TestToSplit.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        My.Settings.scenelink1.AddRange(Splitted)
        My.Settings.scenelink1.Add("END")
        My.Settings.Save()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim search As Integer = My.Settings.scenelink1.IndexOf(ComboBox1.SelectedItem)
        Dim bool As Integer
        If search = -1 Then

        Else
            Do
                Label3.Text = Label3.Text & Environment.NewLine & My.Settings.scenelink1.Item(search)
                search = search + 1
                If My.Settings.scenelink1.Item(search) = "END" Then
                    bool = 1
                End If
            Loop Until bool = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.scenelink1.Clear()
    End Sub
End Class