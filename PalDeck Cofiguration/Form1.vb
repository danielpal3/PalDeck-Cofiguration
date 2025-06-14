Imports System.Threading
Imports ICSharpCode.Decompiler.IL
Imports OBSWebsocketDotNet
Imports OBSWebsocketDotNet.Types
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.IO.Ports
Imports Newtonsoft.Json
Public Class Form1
    Dim Client As New OBSWebsocket
    Dim ButtonFilePaths(7) As String
    Dim backgroundimagepath As String
    Dim ButtonLabels(7) As String
    ' Define a structure to hold button data, including custom command
    Public Class PaldeckButton
        Public Property Label As String
        Public Property FilePath As String
        Public Property CustomCommand As String
        Public Property ModeIndex As Integer
        Public Property TargetValue As String
        Public Property IsCustom As Boolean
    End Class

    ' Create an array to hold data for each button
    Dim ButtonData(7) As PaldeckButton
    Public Class PaldeckScreen
        Public Property ScreenName As String
        Public Property Buttons As PaldeckButton() = New PaldeckButton(7) {}
    End Class

    Dim Screens As New List(Of PaldeckScreen)
    Dim CurrentScreenIndex As Integer = -1

    ' Load project data
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

        For i As Integer = 0 To 7
            ButtonData(i) = New PaldeckButton()
            LoadProject()
        Next

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
        NavArea.View = View.List
        NavArea.FullRowSelect = True
        NavArea.HideSelection = False
        NavArea.MultiSelect = False
        LoadScreens()
        If Screens.Count = 0 Then
            AddNewScreen("Default")
        Else
            LoadScreen(0)
        End If
    End Sub

    ' When ComboBox selection changes, load custom command
    Private Sub CustomBut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomBut.SelectedIndexChanged
        Dim selectedIndex As Integer = CustomBut.SelectedIndex
        If selectedIndex >= 0 AndAlso selectedIndex < ButtonData.Length Then
            TextBox1.Text = ButtonData(selectedIndex).CustomCommand
        End If
    End Sub

    ' When user types into TextBox1, store the string in selected button data
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim selectedIndex As Integer = CustomBut.SelectedIndex
        If selectedIndex >= 0 AndAlso selectedIndex < ButtonData.Length Then
            ButtonData(selectedIndex).CustomCommand = TextBox1.Text
        End If
    End Sub
    Private Sub RemoveCurrentScreen()
        If Screens.Count <= 1 Then
            MessageBox.Show("At least one screen must remain.")
            Return
        End If
        Screens.RemoveAt(CurrentScreenIndex)
        NavArea.Items.RemoveAt(CurrentScreenIndex)
        LoadScreen(0)
    End Sub
    ' Save project to JSON
    ' Save project to JSON
    ' Save project to JSON
    Private Sub SaveProject()
        For i As Integer = 0 To 7
            If ButtonData(i) Is Nothing Then
                ButtonData(i) = New PaldeckButton()
            End If
        Next
        For i As Integer = 0 To 7
            Dim modeBox = CType(Me.Controls.Find($"But_{i + 1}_mode", True).FirstOrDefault(), ComboBox)
            Dim targetBox = Me.Controls.Find($"But_{i + 1}_Target", True).FirstOrDefault()
            Dim customCheck = CType(Me.Controls.Find($"Custom{i + 1}", True).FirstOrDefault(), CheckBox)

            If modeBox IsNot Nothing Then ButtonData(i).ModeIndex = modeBox.SelectedIndex
            If targetBox IsNot Nothing Then ButtonData(i).TargetValue = If(TypeOf targetBox Is ComboBox, CType(targetBox, ComboBox).Text, CType(targetBox, TextBox).Text)
            If customCheck IsNot Nothing Then ButtonData(i).IsCustom = customCheck.Checked
        Next

        Dim json As String = JsonConvert.SerializeObject(ButtonData, Formatting.Indented)
        File.WriteAllText("paldeck_project.json", json)
    End Sub


    ' Load project from JSON
    Private Sub LoadProject()
        Dim modeBox As ComboBox
        Dim targetBox As Control
        Dim customCheck As CheckBox

        If File.Exists("paldeck_project.json") Then
            Dim json As String = File.ReadAllText("paldeck_project.json")
            ButtonData = JsonConvert.DeserializeObject(Of PaldeckButton())(json)
        Else
            ' Initialize default ButtonData with placeholder values
            For i As Integer = 0 To 7
                ButtonData(i) = New PaldeckButton() With {
                    .Label = "Button " & (i + 1),
                    .FilePath = String.Empty,
                    .CustomCommand = String.Empty
                }
            Next
        End If

        ' Ensure all entries are non-null
        For i As Integer = 0 To 7
            If ButtonData(i) Is Nothing Then
                ButtonData(i) = New PaldeckButton()
            End If
        Next

        ' Rebuild ComboBox with any valid entries
        CustomBut.Items.Clear()
        For i As Integer = 0 To 7
            If Not String.IsNullOrEmpty(ButtonData(i).Label) OrElse Not String.IsNullOrEmpty(ButtonData(i).CustomCommand) Then
                CustomBut.Items.Add("Button " & (i + 1))
            End If
        Next

        ' Select first valid item if available
        If CustomBut.Items.Count > 0 Then
            CustomBut.SelectedIndex = 0
        End If

        ' Apply saved UI states
        For i As Integer = 0 To 7
            modeBox = CType(Me.Controls.Find($"But_{i + 1}_mode", True).FirstOrDefault(), ComboBox)
            targetBox = Me.Controls.Find($"But_{i + 1}_Target", True).FirstOrDefault()
            customCheck = CType(Me.Controls.Find($"Custom{i + 1}", True).FirstOrDefault(), CheckBox)

            If modeBox IsNot Nothing Then modeBox.SelectedIndex = ButtonData(i).ModeIndex
            If targetBox IsNot Nothing Then
                If TypeOf targetBox Is ComboBox Then
                    CType(targetBox, ComboBox).Text = If(String.IsNullOrEmpty(ButtonData(i).TargetValue), "Target", ButtonData(i).TargetValue)
                ElseIf TypeOf targetBox Is TextBox Then
                    CType(targetBox, TextBox).Text = If(String.IsNullOrEmpty(ButtonData(i).TargetValue), "Target", ButtonData(i).TargetValue)
                End If
            End If
            If customCheck IsNot Nothing Then customCheck.Checked = ButtonData(i).IsCustom
        Next

    End Sub
    Private Sub AddNewScreen(name As String)
        Dim newScreen As New PaldeckScreen With {.ScreenName = name}
        For i As Integer = 0 To 7
            newScreen.Buttons(i) = New PaldeckButton With {
                .Label = "Button " & (i + 1),
                .FilePath = String.Empty,
                .CustomCommand = String.Empty,
                .ModeIndex = 0,
                .TargetValue = "Target",
                .IsCustom = False
            }
        Next
        Screens.Add(newScreen)
        NavArea.Items.Add(name)
        NavArea.Items(NavArea.Items.Count - 1).Selected = True
    End Sub
    Private Sub LoadScreen(index As Integer)
        If index < 0 OrElse index >= Screens.Count Then Exit Sub
        CurrentScreenIndex = index
        Dim screen = Screens(index)
        For i As Integer = 0 To 7
            Dim modeBox = CType(Me.Controls.Find($"But_{i + 1}_mode", True).FirstOrDefault(), ComboBox)
            Dim targetBox = Me.Controls.Find($"But_{i + 1}_Target", True).FirstOrDefault()
            Dim customCheck = CType(Me.Controls.Find($"Custom{i + 1}", True).FirstOrDefault(), CheckBox)
            Dim filePath = screen.Buttons(i).FilePath
            Dim label = screen.Buttons(i).Label

            If modeBox IsNot Nothing Then
                If screen.Buttons(i).ModeIndex >= 0 AndAlso screen.Buttons(i).ModeIndex < modeBox.Items.Count Then
                    modeBox.SelectedIndex = screen.Buttons(i).ModeIndex
                End If
            End If

            If targetBox IsNot Nothing Then
                If TypeOf targetBox Is ComboBox Then
                    Dim cb = CType(targetBox, ComboBox)
                    cb.Text = If(String.IsNullOrWhiteSpace(screen.Buttons(i).TargetValue), "Button select", screen.Buttons(i).TargetValue)
                ElseIf TypeOf targetBox Is TextBox Then
                    CType(targetBox, TextBox).Text = screen.Buttons(i).TargetValue
                End If
            End If

            If customCheck IsNot Nothing Then customCheck.Checked = screen.Buttons(i).IsCustom
        Next
        If CustomBut.Items.Count < 1 Then
            CustomBut.Text = "Button select"
        End If
    End Sub

    Private Sub SaveScreens()
        If CurrentScreenIndex >= 0 AndAlso CurrentScreenIndex < Screens.Count Then
            Dim screen = Screens(CurrentScreenIndex)
            For i As Integer = 0 To 7
                Dim modeBox = CType(Me.Controls.Find($"But_{i + 1}_mode", True).FirstOrDefault(), ComboBox)
                Dim targetBox = Me.Controls.Find($"But_{i + 1}_Target", True).FirstOrDefault()
                Dim customCheck = CType(Me.Controls.Find($"Custom{i + 1}", True).FirstOrDefault(), CheckBox)

                If modeBox IsNot Nothing Then screen.Buttons(i).ModeIndex = modeBox.SelectedIndex
                If targetBox IsNot Nothing Then
                    If TypeOf targetBox Is ComboBox Then
                        screen.Buttons(i).TargetValue = CType(targetBox, ComboBox).Text
                    ElseIf TypeOf targetBox Is TextBox Then
                        screen.Buttons(i).TargetValue = CType(targetBox, TextBox).Text
                    End If
                End If
                If customCheck IsNot Nothing Then screen.Buttons(i).IsCustom = customCheck.Checked
            Next
        End If

        Dim path As String = "paldeck_screens.json"
        File.WriteAllText(path, JsonConvert.SerializeObject(Screens, Formatting.Indented))
    End Sub

    Private Sub LoadScreens()
        Dim path As String = "paldeck_screens.json"
        If File.Exists(path) Then
            Screens = JsonConvert.DeserializeObject(Of List(Of PaldeckScreen))(File.ReadAllText(path))
        End If
        NavArea.Items.Clear()
        For Each screen In Screens
            NavArea.Items.Add(screen.ScreenName)
        Next
    End Sub

    Private Sub NavArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NavArea.SelectedIndexChanged
        If NavArea.SelectedItems.Count > 0 Then
            Dim selectedIndex As Integer = NavArea.Items.IndexOf(NavArea.SelectedItems(0))
            SaveScreens()
            LoadScreen(selectedIndex)
        End If
    End Sub

    Private Sub AddScreenButton_Click(sender As Object, e As EventArgs) Handles AddScreenButton.Click
        Dim name = InputBox("Enter screen name:", "New Screen")
        If Not String.IsNullOrWhiteSpace(name) Then
            AddNewScreen(name)
            SaveScreens()
        End If
    End Sub

    Private Sub RemoveScreenButton_Click(sender As Object, e As EventArgs) Handles RemoveScreenButton.Click
        RemoveCurrentScreen()
        SaveScreens()
    End Sub


    Private Sub SaveCurrentScreen()
        If CurrentScreenIndex < 0 OrElse CurrentScreenIndex >= Screens.Count Then Exit Sub

        Dim screen = Screens(CurrentScreenIndex)

        For i As Integer = 0 To 7
            Dim modeBox = CType(Me.Controls.Find($"But_{i + 1}_mode", True).FirstOrDefault(), ComboBox)
            Dim targetBox = Me.Controls.Find($"But_{i + 1}_Target", True).FirstOrDefault()
            Dim customCheck = CType(Me.Controls.Find($"Custom{i + 1}", True).FirstOrDefault(), CheckBox)

            If modeBox IsNot Nothing Then screen.Buttons(i).ModeIndex = modeBox.SelectedIndex

            If targetBox IsNot Nothing Then
                If TypeOf targetBox Is ComboBox Then
                    screen.Buttons(i).TargetValue = CType(targetBox, ComboBox).Text
                ElseIf TypeOf targetBox Is TextBox Then
                    screen.Buttons(i).TargetValue = CType(targetBox, TextBox).Text
                End If
            End If

            If customCheck IsNot Nothing Then screen.Buttons(i).IsCustom = customCheck.Checked
        Next
    End Sub

    Private Sub CustomCheck_CheckedChanged(sender As Object, e As EventArgs) _
    Handles Custom1.CheckedChanged, custom2.CheckedChanged, custom3.CheckedChanged, custom4.CheckedChanged,
            custom5.CheckedChanged, custom6.CheckedChanged, custom7.CheckedChanged, custom8.CheckedChanged

        Dim chk As CheckBox = DirectCast(sender, CheckBox)
        Dim wasChecked As Boolean = chk.Checked
        Dim tagValue As String = If(chk.Tag IsNot Nothing, chk.Tag.ToString(), "0")
        Dim index As Integer = CInt(tagValue)

        ' Auto-select Toggle if checked
        Dim modeBox As ComboBox = CType(Me.Controls.Find($"But_{index + 1}_mode", True).FirstOrDefault(), ComboBox)
        If modeBox IsNot Nothing Then
            If wasChecked AndAlso Not modeBox.SelectedItem?.ToString().ToLower().Contains("toggle") Then
                modeBox.SelectedItem = "Toggle"
            End If
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

        Dim customCheck As CheckBox = CType(Me.Controls.Find($"Custom{tagIndex + 1}", True).FirstOrDefault(), CheckBox)
        If customCheck IsNot Nothing Then
            customCheck.Enabled = Not (selectedAction = "New screen")
        End If
    End Sub

    Private Sub Savebut_Click(sender As Object, e As EventArgs) Handles Savebut.Click
        SaveProject()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveCurrentScreen()
        SaveScreens()
    End Sub

End Class