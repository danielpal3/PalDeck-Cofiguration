Imports System.Threading
Imports ICSharpCode.Decompiler.IL
Imports OBSWebsocketDotNet
Imports OBSWebsocketDotNet.Types
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.IO.Ports
Public Class Form1
    Dim Client As New OBSWebsocket
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
            Debug.WriteLine("Connectind is nothing? " & (Connectind Is Nothing))

            Connectind.Image = My.Resources.Connected
            checkconnect()
        Else
            Debug.WriteLine("Connectind is nothing? " & (Connectind Is Nothing))

            Connectind.Image = My.Resources.Disconnected
            Disconected.ShowDialog()

            If Disconected.DialogResult = 1 Then
                ConnectAsync()
            End If

            If Disconected.DialogResult = 2 Then
                Environment.Exit(0)
            End If
        End If
    End Function
    Private Function checkconnect() As Await
        'timer to loop test if we are connected to the websocket
        tryconnect.Start()
    End Function
    Private Sub tryconnect_Tick(sender As Object, e As EventArgs) Handles tryconnect.Tick
        'Test to make sure we are still connected to websocket
        If Client.IsConnected = False Then
            tryconnect.Stop()
            ConnectAsync()
        End If
    End Sub
    Private Sub conweb_Click(sender As Object, e As EventArgs) Handles conweb.Click
        Websocket_Settings.ShowDialog()
    End Sub
End Class