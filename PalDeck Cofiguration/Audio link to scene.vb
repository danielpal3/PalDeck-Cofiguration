Imports System.Threading
Imports OBSWebsocketDotNet
Imports ICSharpCode.Decompiler.IL
Public Class Audio_link_to_scene
    Dim Client As New OBSWebsocket
    Private Sub Audio_link_to_scene_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Settings.ip = "" Or My.Settings.port = "" Or My.Settings.password = "" Then
            'Open settings and get user to setup port access
        End If
        ConnectAsync()
        ComboBox2.Items.Clear()
        Dim kind() As String = {"wasapi_input_capture", "wasapi_process_output_capture", "monitor_capture", "browser_source"}
        Dim i As Integer
        i = 0
        Dim checkbox As CheckBox

        i = 1
        Do Until i = 17
            Dim name3 As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name3)

            checkbox.Text = Nothing
            i = i + 1
        Loop
        i = 0
        For Each item In Form1.But_2_Target.Items
            ComboBox1.Items.Add(item.ToString)
        Next
        Dim i2 As Integer
        i2 = 1

        Do
            For Each source In Client.GetInputList(inputKind:=kind(i))
                ComboBox2.Items.Add(source.InputName.ToString)
            Next
            i = i + 1
        Loop Until i = kind.Count

        i = 1

        For Each aitem In ComboBox2.Items
            Dim name As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name)
            checkbox.Text = aitem
            checkbox.Visible = True
            If i = ComboBox2.Items.Count Then
                GoTo Finish
            End If
            i = i + 1
        Next
Finish:
        i = 1
        Do Until i = 17
            Dim name2 As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name2)

            If checkbox.Text = Nothing Then
                checkbox.Visible = False
                i = i + 1
            Else
                checkbox.Visible = True
                i = i + 1
            End If

        Loop

    End Sub

    Private Function ConnectAsync() As Await
        Dim count As Integer
        count = 0

        'Attempt to connect to websocket
        Do
            Client.ConnectAsync("ws://" & My.Settings.ip & ":" + My.Settings.port, My.Settings.password)
            Thread.Sleep(500)
            count = count + 1
        Loop Until Client.IsConnected = True Or count = 5

    End Function

    Private Sub sav1_Click(sender As Object, e As EventArgs) Handles sav1.Click
        Dim checkbox As CheckBox
        Dim test As Integer
        test = ComboBox2.Items.Count
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
        For i = 1 To test
            Dim name As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name)
            checkbox.Checked = False
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim search As Integer = My.Settings.scenelink1.IndexOf(ComboBox1.SelectedItem)
        Dim bool As Integer
        Dim checkbox As CheckBox
        Dim test As Integer
        test = 17

        Label3.Text = Nothing

        For i = 1 To test
            Dim name As String = ("checkbox" & i)
            checkbox = Me.Controls.Item(name)
            checkbox.Checked = False
        Next

        If search = -1 Then

        Else
            Do
                Label3.Text = Label3.Text & Environment.NewLine & My.Settings.scenelink1.Item(search)
                search = search + 1
                If My.Settings.scenelink1.Item(search) = "END" Then
                    bool = 1
                Else
                    For i = 1 To test
                        Dim name As String = ("checkbox" & i)
                        checkbox = Me.Controls.Item(name)
                        If checkbox.Text = My.Settings.scenelink1.Item(search) Then
                            checkbox.Checked = True
                        End If
                    Next
                End If
            Loop Until bool = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.scenelink1.Clear()
    End Sub
End Class