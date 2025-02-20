Imports System.ComponentModel
Imports System.Threading
Imports ICSharpCode.Decompiler.IL
Imports OBSWebsocketDotNet
Public Class Form1
    Dim Client As New OBSWebsocket
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = 2
        Me.FormBorderStyle = 0
        If My.Settings.ip = "" Or My.Settings.port = "" Or My.Settings.password = "" Then
            'Open settings and get user to setup port access
        End If
        ConnectAsync()

        Dim kind() As String = {"wasapi_input_capture", "wasapi_process_output_capture", "monitor_capture", "browser_source"}
        Dim i As Integer
        i = 0

        For Each scene In Client.ListScenes
            ComboBox1.Items.Add(scene.Name.ToString)
        Next

        Do
            For Each source In Client.GetInputList(inputKind:=kind(i))
                ComboBox2.Items.Add(source.InputName.ToString)
            Next
            i = i + 1
        Loop Until i = kind.Count
    End Sub
    Private Function ConnectAsync() As Await
        Dim count As Integer
        count = 0

        Do
            Client.ConnectAsync("ws://" & My.Settings.ip & ":" + My.Settings.port, My.Settings.password)
            Thread.Sleep(500)
            count = count + 1
        Loop Until Client.IsConnected = True Or count = 5

        If Client.IsConnected = True Then
            Connectind.Image = My.Resources.Connected
            checkconnect()
        Else
            Connectind.Image = My.Resources.Disconnected
            If MsgBox("OBS websocket has disconnected, would you like to try and reconnect? Selecting no will close the app", vbYesNo) = vbYes Then
                ConnectAsync()
            Else
                'Close application
                Application.Exit()

            End If
        End If
    End Function

    Private Function checkconnect() As Await
        tryconnect.Start()
    End Function
    Private Sub sel6_CheckedChanged(sender As Object, e As EventArgs) Handles sel6.CheckedChanged
        If sel6.Checked = True Then
            But1.Height = 83
            But1.Width = 146.66
            But2.Height = 83
            But2.Width = 146.66
            But2.Location = New Point(410, 25)
            But3.Height = 83
            But3.Width = 146.66
            But3.Location = New Point(563, 25)
            But5.Height = 83
            But5.Width = 146.66
            But6.Height = 83
            But6.Width = 146.66
            But6.Location = New Point(410, 234)
            But7.Height = 83
            But7.Width = 146.66
            But7.Location = New Point(563, 234)

            But4.Visible = False
            But8.Visible = False
        End If
    End Sub

    Private Sub sel8_CheckedChanged(sender As Object, e As EventArgs) Handles sel8.CheckedChanged
        If sel8.Checked = True Then
            But1.Height = 83
            But1.Width = 106
            But1.Location = New Point(257, 25)
            But2.Height = 83
            But2.Width = 106
            But2.Location = New Point(373, 25)
            But3.Height = 83
            But3.Width = 106
            But3.Location = New Point(489, 25)
            But4.Height = 83
            But4.Width = 106
            But4.Location = New Point(605, 25)
            But5.Height = 83
            But5.Width = 106
            But5.Location = New Point(257, 234)
            But6.Height = 83
            But6.Width = 106
            But6.Location = New Point(373, 234)
            But7.Height = 83
            But7.Width = 106
            But7.Location = New Point(489, 234)
            But8.Height = 83
            But8.Width = 106
            But8.Location = New Point(605, 234)

            But4.Visible = True
            But8.Visible = True
        End If
    End Sub

    Private Sub tryconnect_Tick(sender As Object, e As EventArgs) Handles tryconnect.Tick

        If Client.IsConnected = False Then
            tryconnect.Stop()
            ConnectAsync()
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Client.SetInputVolume("Boom Mic", TrackBar1.Value / 100)
    End Sub

    Private Sub audiotoscene_Click(sender As Object, e As EventArgs) Handles audiotoscene.Click
        Audio_link_to_scene.ShowDialog()
    End Sub
End Class
