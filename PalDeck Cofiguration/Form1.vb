Imports System.ComponentModel
Imports System.Threading
Imports ICSharpCode.Decompiler.IL
Imports OBSWebsocketDotNet
Public Class Form1
    Dim Client As New OBSWebsocket
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'start in full screen
        Me.WindowState = 2
        Me.FormBorderStyle = 0
        'test to see if settings have been configured for websocket (currently hard coded)
        If My.Settings.ip = "" Or My.Settings.port = "" Or My.Settings.password = "" Then
            'Open settings and get user to setup port access
        End If
        ConnectAsync()
        'array of string for audio sources

        'get scene names and populate combobox
        For Each scene In Client.ListScenes
            ComboBox1.Items.Add(scene.Name.ToString)
        Next

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

        'change connection icon to connected if succesfull and disconnected if not
        'message box appears giving the option to retry or close app, also need an option to go to settings incase of password change
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
        'timer to loop test if we are connected to the websocket
        tryconnect.Start()
    End Function
    Private Sub sel6_CheckedChanged(sender As Object, e As EventArgs) Handles sel6.CheckedChanged
        'set up button posistions and sizes when selection 6 selected
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
        'set up button posistions and sizes when selection 8 selected
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
        'Test to make sure we are still connected to websocket
        If Client.IsConnected = False Then
            tryconnect.Stop()
            ConnectAsync()
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'using trackbar value to change volume of source in OBS
        Client.SetInputVolume("Boom Mic", TrackBar1.Value / 100)
    End Sub

    Private Sub audiotoscene_Click(sender As Object, e As EventArgs) Handles audiotoscene.Click
        'opens a new form to set up the audio links to their scenes
        Audio_link_to_scene.ShowDialog()
    End Sub

End Class
