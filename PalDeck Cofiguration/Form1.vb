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
    Dim ButtonFilePaths(7) As String
    Dim backgroundimagepath As String
    Dim ButtonLabels(7) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        But_1_Target.Enabled = False
        But_2_Target.Enabled = False
        But_3_Target.Enabled = False
        But_4_Target.Enabled = False
        But_5_Target.Enabled = False
        But_6_Target.Enabled = False
        But_7_Target.Enabled = False
        But_8_Target.Enabled = False
        ' Assign Tag values to buttons so we can use them as an index
        Button1.Tag = 0
        Button2.Tag = 1
        Button3.Tag = 2
        Button4.Tag = 3
        Button5.Tag = 4
        Button6.Tag = 5
        Button7.Tag = 6
        Button8.Tag = 7
        Custom1.Tag = 0
        custom2.Tag = 1
        custom3.Tag = 2
        custom4.Tag = 3
        custom5.Tag = 4
        custom6.Tag = 5
        custom7.Tag = 6
        custom8.Tag = 7
        But_1_mode.Tag = 0
        But_2_mode.Tag = 1
        But_3_mode.Tag = 2
        But_4_mode.Tag = 3
        But_5_mode.Tag = 4
        But_6_mode.Tag = 5
        But_7_mode.Tag = 6
        But_8_mode.Tag = 7
        But_1_Target.Tag = 0
        But_2_Target.Tag = 1
        But_3_Target.Tag = 2
        But_4_Target.Tag = 3
        But_5_Target.Tag = 4
        But_6_Target.Tag = 5
        But_7_Target.Tag = 6
        But_8_Target.Tag = 7

        PreviewBox.Image = New Bitmap(PreviewBox.Width, PreviewBox.Height)

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
            But_2_Target.Items.Add(scene.Name.ToString)
        Next

    End Sub
    Private Sub CustomCheck_CheckedChanged(sender As Object, e As EventArgs) _
    Handles Custom1.CheckedChanged, custom2.CheckedChanged, custom3.CheckedChanged, custom4.CheckedChanged,
            custom5.CheckedChanged, custom6.CheckedChanged, custom7.CheckedChanged, custom8.CheckedChanged

        Dim chk As CheckBox = DirectCast(sender, CheckBox)
        Dim wasChecked As Boolean = chk.Checked
        Dim tagValue As String = chk.Tag.ToString()
        Dim matchedButton As Button = Controls.Find("Button" & (CInt(tagValue) + 1).ToString(), True).FirstOrDefault()
        If matchedButton IsNot Nothing Then
            Dim buttonText As String = matchedButton.Text

        End If

        PopulateCustomComboBox()
    End Sub
    Private Sub UpdateCustomComboBox()
        CustomBut.Items.Clear()

        For i As Integer = 0 To 7
            Dim checkbox As CheckBox = Controls.Find("Custom" & i, True).FirstOrDefault()
            If checkbox IsNot Nothing AndAlso checkbox.Checked Then
                Dim button As Button = Controls.Find("Button" & (i + 1).ToString(), True).FirstOrDefault()
                If button IsNot Nothing Then
                    CustomBut.Items.Add(button.Text)
                End If
            End If
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
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim index As Integer = CInt(btn.Tag)

        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                ButtonFilePaths(index) = ofd.FileName
                UpdatePreview()
            End If
        End Using
    End Sub
    Private Sub UpdatePreview()
        ' Clear preview area
        Using g As Graphics = Graphics.FromImage(PreviewBox.Image)
            g.Clear(Color.Black)

            ' Draw background if you have one set (not implemented yet)
            If File.Exists(backgroundimagepath) Then
                Using BackgroundImage As Image = Image.FromFile(backgroundimagepath)
                    g.DrawImage(BackgroundImage, 0, 0, PreviewBox.Width, PreviewBox.Height)
                End Using
            End If

            ' Draw button images if available
            Dim buttonWidth As Integer = 106
            Dim buttonHeight As Integer = 83
            Dim paddingTop As Integer = 10
            Dim paddingBottom As Integer = 10
            Dim spacing As Integer = 11.3
            Dim paddingLeft As Integer = 11.3

            For i As Integer = 0 To 3
                If File.Exists(ButtonFilePaths(i)) Then
                    Using img As Image = Image.FromFile(ButtonFilePaths(i))
                        Dim x As Integer = paddingLeft + i * (buttonWidth + spacing)
                        Dim y As Integer = paddingTop
                        g.DrawImage(img, x, y, buttonWidth, buttonHeight)
                    End Using
                End If
            Next

            For i As Integer = 4 To 7
                If File.Exists(ButtonFilePaths(i)) Then
                    Using img As Image = Image.FromFile(ButtonFilePaths(i))
                        Dim x As Integer = paddingLeft + (i - 4) * (buttonWidth + spacing)
                        Dim y As Integer = PreviewBox.Height - buttonHeight - paddingBottom
                        g.DrawImage(img, x, y, buttonWidth, buttonHeight)
                    End Using
                End If
            Next
        End Using

        PreviewBox.Invalidate()
    End Sub

    Private Sub BackgroundBut_Click(sender As Object, e As EventArgs) Handles BackgroundBut.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                backgroundimagepath = ofd.FileName
                UpdatePreview()
            End If
        End Using
    End Sub
    Private Sub PopulateCustomComboBox()
        CustomBut.Items.Clear()

        For i As Integer = 0 To 7
            Dim checkBoxName = "Custom" & (i + 1)
            Dim buttonName = "Button" & (i + 1)

            Dim cb As CheckBox = Controls.Find(checkBoxName, True).FirstOrDefault()
            Dim btn As Button = Controls.Find(buttonName, True).FirstOrDefault()

            If cb IsNot Nothing AndAlso btn IsNot Nothing AndAlso cb.Checked Then
                CustomBut.Items.Add(btn.Text)

            End If
        Next
    End Sub

    Private Sub But_Mode_Changed(sender As Object, e As EventArgs) _
    Handles But_1_mode.SelectedIndexChanged, But_2_mode.SelectedIndexChanged,
            But_3_mode.SelectedIndexChanged, But_4_mode.SelectedIndexChanged,
            But_5_mode.SelectedIndexChanged, But_6_mode.SelectedIndexChanged,
            But_7_mode.SelectedIndexChanged, But_8_mode.SelectedIndexChanged

        Dim modeBox As ComboBox = CType(sender, ComboBox)
        Dim tagIndex As Integer = CInt(modeBox.Tag)

        ' Get the selected action
        Dim selectedAction As String = modeBox.SelectedItem.ToString()

        ' Use the form’s Controls collection to find the matching Target box
        Dim targetName As String = $"But_{tagIndex + 1}_Target"
        Dim targetBox As Control = Me.Controls.Find(targetName, True).FirstOrDefault()

        If targetBox IsNot Nothing Then
            ' Enable only if mode is "New Page"
            If selectedAction = "New screen" Then
                targetBox.Enabled = True
            Else
                targetBox.Enabled = False
                If TypeOf targetBox Is TextBox Then
                    CType(targetBox, TextBox).Text = ""
                ElseIf TypeOf targetBox Is ComboBox Then
                    CType(targetBox, ComboBox).SelectedIndex = -1
                End If
            End If
        End If
    End Sub

End Class