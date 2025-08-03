<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Connectind = New PictureBox()
        tryconnect = New Timer(components)
        conweb = New Button()
        NavArea = New ListView()
        PreviewArea = New GroupBox()
        PreviewBox = New PictureBox()
        BackgroundBut = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        ScreenSetupGroup = New GroupBox()
        custom8 = New CheckBox()
        custom7 = New CheckBox()
        custom6 = New CheckBox()
        custom5 = New CheckBox()
        custom4 = New CheckBox()
        custom3 = New CheckBox()
        custom2 = New CheckBox()
        Custom1 = New CheckBox()
        Button8picker = New Button()
        Button7picker = New Button()
        Button6picker = New Button()
        Button5picker = New Button()
        Button4picker = New Button()
        Button3picker = New Button()
        Button2picker = New Button()
        Button1picker = New Button()
        But_8_Target = New ComboBox()
        But_8_mode = New ComboBox()
        But_7_Target = New ComboBox()
        But_7_mode = New ComboBox()
        But_6_Target = New ComboBox()
        But_6_mode = New ComboBox()
        But_5_Target = New ComboBox()
        But_5_mode = New ComboBox()
        But_4_Target = New ComboBox()
        But_4_mode = New ComboBox()
        But_3_Target = New ComboBox()
        But_3_mode = New ComboBox()
        But_2_Target = New ComboBox()
        But_2_mode = New ComboBox()
        But_1_Target = New ComboBox()
        But_1_mode = New ComboBox()
        CustomArea = New GroupBox()
        Savebut = New Button()
        Testbut = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        CustomBut = New ComboBox()
        GroupBox2 = New GroupBox()
        ButtonVES = New Button()
        ButtonVCS = New Button()
        ButtonPreviewBox = New PictureBox()
        Configbut = New Button()
        Button9 = New Button()
        AddScreenButton = New Button()
        RemoveScreenButton = New Button()
        Imageselect = New OpenFileDialog()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        timeset = New TextBox()
        Label2 = New Label()
        errorbut = New Button()
        clickedbut = New Button()
        ButSelect = New ComboBox()
        PresetBox = New ComboBox()
        SavePreset = New Button()
        CType(Connectind, ComponentModel.ISupportInitialize).BeginInit()
        PreviewArea.SuspendLayout()
        CType(PreviewBox, ComponentModel.ISupportInitialize).BeginInit()
        ScreenSetupGroup.SuspendLayout()
        CustomArea.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(ButtonPreviewBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Connectind
        ' 
        Connectind.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Connectind.Image = My.Resources.Resources.Connected
        Connectind.Location = New Point(1305, 3)
        Connectind.Name = "Connectind"
        Connectind.Size = New Size(140, 32)
        Connectind.TabIndex = 13
        Connectind.TabStop = False
        ' 
        ' tryconnect
        ' 
        tryconnect.Interval = 500
        ' 
        ' conweb
        ' 
        conweb.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        conweb.Location = New Point(1305, 41)
        conweb.Name = "conweb"
        conweb.Size = New Size(135, 23)
        conweb.TabIndex = 35
        conweb.Text = "Configure websocket"
        conweb.UseVisualStyleBackColor = True
        ' 
        ' NavArea
        ' 
        NavArea.Location = New Point(12, 63)
        NavArea.Name = "NavArea"
        NavArea.Size = New Size(146, 599)
        NavArea.TabIndex = 36
        NavArea.UseCompatibleStateImageBehavior = False
        NavArea.View = View.List
        ' 
        ' PreviewArea
        ' 
        PreviewArea.Controls.Add(PreviewBox)
        PreviewArea.Location = New Point(164, 307)
        PreviewArea.Name = "PreviewArea"
        PreviewArea.Size = New Size(500, 355)
        PreviewArea.TabIndex = 37
        PreviewArea.TabStop = False
        PreviewArea.Text = "Preview"
        ' 
        ' PreviewBox
        ' 
        PreviewBox.Location = New Point(6, 22)
        PreviewBox.Name = "PreviewBox"
        PreviewBox.Size = New Size(480, 320)
        PreviewBox.TabIndex = 0
        PreviewBox.TabStop = False
        ' 
        ' BackgroundBut
        ' 
        BackgroundBut.Location = New Point(6, 22)
        BackgroundBut.Name = "BackgroundBut"
        BackgroundBut.Size = New Size(132, 23)
        BackgroundBut.TabIndex = 38
        BackgroundBut.Text = "Change background"
        BackgroundBut.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 39
        Button1.Text = "Button 1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(6, 80)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 40
        Button2.Text = "Button 2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(6, 109)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 41
        Button3.Text = "Button 3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 138)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 42
        Button4.Text = "Button 4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(6, 167)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 43
        Button5.Text = "Button 5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(6, 196)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 44
        Button6.Text = "Button 6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(6, 225)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 45
        Button7.Text = "Button 7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(6, 254)
        Button8.Name = "Button8"
        Button8.Size = New Size(75, 23)
        Button8.TabIndex = 46
        Button8.Text = "Button 8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' ScreenSetupGroup
        ' 
        ScreenSetupGroup.Controls.Add(custom8)
        ScreenSetupGroup.Controls.Add(custom7)
        ScreenSetupGroup.Controls.Add(custom6)
        ScreenSetupGroup.Controls.Add(custom5)
        ScreenSetupGroup.Controls.Add(custom4)
        ScreenSetupGroup.Controls.Add(custom3)
        ScreenSetupGroup.Controls.Add(custom2)
        ScreenSetupGroup.Controls.Add(Custom1)
        ScreenSetupGroup.Controls.Add(Button8picker)
        ScreenSetupGroup.Controls.Add(Button7picker)
        ScreenSetupGroup.Controls.Add(Button6picker)
        ScreenSetupGroup.Controls.Add(Button5picker)
        ScreenSetupGroup.Controls.Add(Button4picker)
        ScreenSetupGroup.Controls.Add(Button3picker)
        ScreenSetupGroup.Controls.Add(Button2picker)
        ScreenSetupGroup.Controls.Add(Button1picker)
        ScreenSetupGroup.Controls.Add(But_8_Target)
        ScreenSetupGroup.Controls.Add(But_8_mode)
        ScreenSetupGroup.Controls.Add(But_7_Target)
        ScreenSetupGroup.Controls.Add(But_7_mode)
        ScreenSetupGroup.Controls.Add(But_6_Target)
        ScreenSetupGroup.Controls.Add(But_6_mode)
        ScreenSetupGroup.Controls.Add(But_5_Target)
        ScreenSetupGroup.Controls.Add(But_5_mode)
        ScreenSetupGroup.Controls.Add(But_4_Target)
        ScreenSetupGroup.Controls.Add(But_4_mode)
        ScreenSetupGroup.Controls.Add(But_3_Target)
        ScreenSetupGroup.Controls.Add(But_3_mode)
        ScreenSetupGroup.Controls.Add(But_2_Target)
        ScreenSetupGroup.Controls.Add(But_2_mode)
        ScreenSetupGroup.Controls.Add(But_1_Target)
        ScreenSetupGroup.Controls.Add(But_1_mode)
        ScreenSetupGroup.Controls.Add(BackgroundBut)
        ScreenSetupGroup.Controls.Add(Button8)
        ScreenSetupGroup.Controls.Add(Button1)
        ScreenSetupGroup.Controls.Add(Button7)
        ScreenSetupGroup.Controls.Add(Button2)
        ScreenSetupGroup.Controls.Add(Button6)
        ScreenSetupGroup.Controls.Add(Button3)
        ScreenSetupGroup.Controls.Add(Button5)
        ScreenSetupGroup.Controls.Add(Button4)
        ScreenSetupGroup.Location = New Point(164, 12)
        ScreenSetupGroup.Name = "ScreenSetupGroup"
        ScreenSetupGroup.Size = New Size(500, 289)
        ScreenSetupGroup.TabIndex = 47
        ScreenSetupGroup.TabStop = False
        ScreenSetupGroup.Text = "Screen Setup"
        ' 
        ' custom8
        ' 
        custom8.AutoSize = True
        custom8.Location = New Point(422, 257)
        custom8.Name = "custom8"
        custom8.Size = New Size(68, 19)
        custom8.TabIndex = 77
        custom8.Text = "Custom"
        custom8.UseVisualStyleBackColor = True
        ' 
        ' custom7
        ' 
        custom7.AutoSize = True
        custom7.Location = New Point(422, 227)
        custom7.Name = "custom7"
        custom7.Size = New Size(68, 19)
        custom7.TabIndex = 76
        custom7.Text = "Custom"
        custom7.UseVisualStyleBackColor = True
        ' 
        ' custom6
        ' 
        custom6.AutoSize = True
        custom6.Location = New Point(422, 198)
        custom6.Name = "custom6"
        custom6.Size = New Size(68, 19)
        custom6.TabIndex = 75
        custom6.Text = "Custom"
        custom6.UseVisualStyleBackColor = True
        ' 
        ' custom5
        ' 
        custom5.AutoSize = True
        custom5.Location = New Point(422, 170)
        custom5.Name = "custom5"
        custom5.Size = New Size(68, 19)
        custom5.TabIndex = 72
        custom5.Text = "Custom"
        custom5.UseVisualStyleBackColor = True
        ' 
        ' custom4
        ' 
        custom4.AutoSize = True
        custom4.Location = New Point(422, 141)
        custom4.Name = "custom4"
        custom4.Size = New Size(68, 19)
        custom4.TabIndex = 74
        custom4.Text = "Custom"
        custom4.UseVisualStyleBackColor = True
        ' 
        ' custom3
        ' 
        custom3.AutoSize = True
        custom3.Location = New Point(422, 111)
        custom3.Name = "custom3"
        custom3.Size = New Size(68, 19)
        custom3.TabIndex = 73
        custom3.Text = "Custom"
        custom3.UseVisualStyleBackColor = True
        ' 
        ' custom2
        ' 
        custom2.AutoSize = True
        custom2.Location = New Point(422, 83)
        custom2.Name = "custom2"
        custom2.Size = New Size(68, 19)
        custom2.TabIndex = 72
        custom2.Text = "Custom"
        custom2.UseVisualStyleBackColor = True
        ' 
        ' Custom1
        ' 
        Custom1.AutoSize = True
        Custom1.Location = New Point(422, 55)
        Custom1.Name = "Custom1"
        Custom1.Size = New Size(68, 19)
        Custom1.TabIndex = 71
        Custom1.Text = "Custom"
        Custom1.UseVisualStyleBackColor = True
        ' 
        ' Button8picker
        ' 
        Button8picker.Location = New Point(341, 254)
        Button8picker.Name = "Button8picker"
        Button8picker.Size = New Size(75, 23)
        Button8picker.TabIndex = 70
        Button8picker.Text = "Picker"
        Button8picker.UseVisualStyleBackColor = True
        ' 
        ' Button7picker
        ' 
        Button7picker.Location = New Point(341, 225)
        Button7picker.Name = "Button7picker"
        Button7picker.Size = New Size(75, 23)
        Button7picker.TabIndex = 69
        Button7picker.Text = "Picker"
        Button7picker.UseVisualStyleBackColor = True
        ' 
        ' Button6picker
        ' 
        Button6picker.Location = New Point(341, 195)
        Button6picker.Name = "Button6picker"
        Button6picker.Size = New Size(75, 23)
        Button6picker.TabIndex = 68
        Button6picker.Text = "Picker"
        Button6picker.UseVisualStyleBackColor = True
        ' 
        ' Button5picker
        ' 
        Button5picker.Location = New Point(341, 168)
        Button5picker.Name = "Button5picker"
        Button5picker.Size = New Size(75, 23)
        Button5picker.TabIndex = 67
        Button5picker.Text = "Picker"
        Button5picker.UseVisualStyleBackColor = True
        ' 
        ' Button4picker
        ' 
        Button4picker.Location = New Point(341, 139)
        Button4picker.Name = "Button4picker"
        Button4picker.Size = New Size(75, 23)
        Button4picker.TabIndex = 66
        Button4picker.Text = "Picker"
        Button4picker.UseVisualStyleBackColor = True
        ' 
        ' Button3picker
        ' 
        Button3picker.Location = New Point(341, 110)
        Button3picker.Name = "Button3picker"
        Button3picker.Size = New Size(75, 23)
        Button3picker.TabIndex = 65
        Button3picker.Text = "Picker"
        Button3picker.UseVisualStyleBackColor = True
        ' 
        ' Button2picker
        ' 
        Button2picker.Location = New Point(341, 81)
        Button2picker.Name = "Button2picker"
        Button2picker.Size = New Size(75, 23)
        Button2picker.TabIndex = 64
        Button2picker.Text = "Picker"
        Button2picker.UseVisualStyleBackColor = True
        ' 
        ' Button1picker
        ' 
        Button1picker.Location = New Point(341, 52)
        Button1picker.Name = "Button1picker"
        Button1picker.Size = New Size(75, 23)
        Button1picker.TabIndex = 63
        Button1picker.Text = "Picker"
        Button1picker.UseVisualStyleBackColor = True
        ' 
        ' But_8_Target
        ' 
        But_8_Target.FormattingEnabled = True
        But_8_Target.Location = New Point(214, 254)
        But_8_Target.Name = "But_8_Target"
        But_8_Target.Size = New Size(121, 23)
        But_8_Target.TabIndex = 62
        But_8_Target.Text = "Button Target"
        ' 
        ' But_8_mode
        ' 
        But_8_mode.FormattingEnabled = True
        But_8_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_8_mode.Location = New Point(87, 253)
        But_8_mode.Name = "But_8_mode"
        But_8_mode.Size = New Size(121, 23)
        But_8_mode.TabIndex = 61
        But_8_mode.Text = "Button Mode"
        ' 
        ' But_7_Target
        ' 
        But_7_Target.FormattingEnabled = True
        But_7_Target.Location = New Point(214, 225)
        But_7_Target.Name = "But_7_Target"
        But_7_Target.Size = New Size(121, 23)
        But_7_Target.TabIndex = 60
        But_7_Target.Text = "Button Target"
        ' 
        ' But_7_mode
        ' 
        But_7_mode.FormattingEnabled = True
        But_7_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_7_mode.Location = New Point(87, 224)
        But_7_mode.Name = "But_7_mode"
        But_7_mode.Size = New Size(121, 23)
        But_7_mode.TabIndex = 59
        But_7_mode.Text = "Button Mode"
        ' 
        ' But_6_Target
        ' 
        But_6_Target.FormattingEnabled = True
        But_6_Target.Location = New Point(214, 197)
        But_6_Target.Name = "But_6_Target"
        But_6_Target.Size = New Size(121, 23)
        But_6_Target.TabIndex = 58
        But_6_Target.Text = "Button Target"
        ' 
        ' But_6_mode
        ' 
        But_6_mode.FormattingEnabled = True
        But_6_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_6_mode.Location = New Point(87, 196)
        But_6_mode.Name = "But_6_mode"
        But_6_mode.Size = New Size(121, 23)
        But_6_mode.TabIndex = 57
        But_6_mode.Text = "Button Mode"
        ' 
        ' But_5_Target
        ' 
        But_5_Target.FormattingEnabled = True
        But_5_Target.Location = New Point(214, 167)
        But_5_Target.Name = "But_5_Target"
        But_5_Target.Size = New Size(121, 23)
        But_5_Target.TabIndex = 56
        But_5_Target.Text = "Button Target"
        ' 
        ' But_5_mode
        ' 
        But_5_mode.FormattingEnabled = True
        But_5_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_5_mode.Location = New Point(87, 166)
        But_5_mode.Name = "But_5_mode"
        But_5_mode.Size = New Size(121, 23)
        But_5_mode.TabIndex = 55
        But_5_mode.Text = "Button Mode"
        ' 
        ' But_4_Target
        ' 
        But_4_Target.FormattingEnabled = True
        But_4_Target.Location = New Point(214, 139)
        But_4_Target.Name = "But_4_Target"
        But_4_Target.Size = New Size(121, 23)
        But_4_Target.TabIndex = 54
        But_4_Target.Text = "Button Target"
        ' 
        ' But_4_mode
        ' 
        But_4_mode.FormattingEnabled = True
        But_4_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_4_mode.Location = New Point(87, 138)
        But_4_mode.Name = "But_4_mode"
        But_4_mode.Size = New Size(121, 23)
        But_4_mode.TabIndex = 53
        But_4_mode.Text = "Button Mode"
        ' 
        ' But_3_Target
        ' 
        But_3_Target.FormattingEnabled = True
        But_3_Target.Location = New Point(214, 110)
        But_3_Target.Name = "But_3_Target"
        But_3_Target.Size = New Size(121, 23)
        But_3_Target.TabIndex = 52
        But_3_Target.Text = "Button Target"
        ' 
        ' But_3_mode
        ' 
        But_3_mode.FormattingEnabled = True
        But_3_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_3_mode.Location = New Point(87, 109)
        But_3_mode.Name = "But_3_mode"
        But_3_mode.Size = New Size(121, 23)
        But_3_mode.TabIndex = 51
        But_3_mode.Text = "Button Mode"
        ' 
        ' But_2_Target
        ' 
        But_2_Target.FormattingEnabled = True
        But_2_Target.Location = New Point(214, 81)
        But_2_Target.Name = "But_2_Target"
        But_2_Target.Size = New Size(121, 23)
        But_2_Target.TabIndex = 50
        But_2_Target.Text = "Button Target"
        ' 
        ' But_2_mode
        ' 
        But_2_mode.FormattingEnabled = True
        But_2_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_2_mode.Location = New Point(87, 80)
        But_2_mode.Name = "But_2_mode"
        But_2_mode.Size = New Size(121, 23)
        But_2_mode.TabIndex = 49
        But_2_mode.Text = "Button Mode"
        ' 
        ' But_1_Target
        ' 
        But_1_Target.FormattingEnabled = True
        But_1_Target.Location = New Point(214, 52)
        But_1_Target.Name = "But_1_Target"
        But_1_Target.Size = New Size(121, 23)
        But_1_Target.TabIndex = 48
        But_1_Target.Text = "Button Target"
        ' 
        ' But_1_mode
        ' 
        But_1_mode.FormattingEnabled = True
        But_1_mode.Items.AddRange(New Object() {"New screen", "Toggle", "Toggle with error"})
        But_1_mode.Location = New Point(87, 51)
        But_1_mode.Name = "But_1_mode"
        But_1_mode.Size = New Size(121, 23)
        But_1_mode.TabIndex = 47
        But_1_mode.Text = "Button Mode"
        ' 
        ' CustomArea
        ' 
        CustomArea.Controls.Add(Savebut)
        CustomArea.Controls.Add(Testbut)
        CustomArea.Controls.Add(TextBox1)
        CustomArea.Controls.Add(Label1)
        CustomArea.Controls.Add(CustomBut)
        CustomArea.Location = New Point(670, 12)
        CustomArea.Name = "CustomArea"
        CustomArea.Size = New Size(313, 237)
        CustomArea.TabIndex = 48
        CustomArea.TabStop = False
        CustomArea.Text = "Custom setup"
        ' 
        ' Savebut
        ' 
        Savebut.Location = New Point(157, 198)
        Savebut.Name = "Savebut"
        Savebut.Size = New Size(108, 23)
        Savebut.TabIndex = 4
        Savebut.Text = "Save Command"
        Savebut.UseVisualStyleBackColor = True
        ' 
        ' Testbut
        ' 
        Testbut.Location = New Point(43, 198)
        Testbut.Name = "Testbut"
        Testbut.Size = New Size(108, 23)
        Testbut.TabIndex = 3
        Testbut.Text = "Test Command"
        Testbut.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 78)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(301, 111)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 15)
        Label1.TabIndex = 1
        Label1.Text = "Custom command / text to send"
        ' 
        ' CustomBut
        ' 
        CustomBut.FormattingEnabled = True
        CustomBut.Location = New Point(6, 24)
        CustomBut.Name = "CustomBut"
        CustomBut.Size = New Size(121, 23)
        CustomBut.TabIndex = 0
        CustomBut.Text = "Button select"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ButtonVES)
        GroupBox2.Controls.Add(ButtonVCS)
        GroupBox2.Controls.Add(ButtonPreviewBox)
        GroupBox2.Location = New Point(6, 115)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(263, 145)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Click preview"
        ' 
        ' ButtonVES
        ' 
        ButtonVES.Location = New Point(127, 22)
        ButtonVES.Name = "ButtonVES"
        ButtonVES.Size = New Size(98, 23)
        ButtonVES.TabIndex = 8
        ButtonVES.Text = "View error state"
        ButtonVES.UseVisualStyleBackColor = True
        ' 
        ' ButtonVCS
        ' 
        ButtonVCS.Location = New Point(8, 22)
        ButtonVCS.Name = "ButtonVCS"
        ButtonVCS.Size = New Size(113, 23)
        ButtonVCS.TabIndex = 7
        ButtonVCS.Text = "View clicked state"
        ButtonVCS.UseVisualStyleBackColor = True
        ' 
        ' ButtonPreviewBox
        ' 
        ButtonPreviewBox.BackColor = SystemColors.ActiveBorder
        ButtonPreviewBox.Location = New Point(86, 48)
        ButtonPreviewBox.Name = "ButtonPreviewBox"
        ButtonPreviewBox.Size = New Size(106, 83)
        ButtonPreviewBox.TabIndex = 6
        ButtonPreviewBox.TabStop = False
        ' 
        ' Configbut
        ' 
        Configbut.Location = New Point(806, 639)
        Configbut.Name = "Configbut"
        Configbut.Size = New Size(119, 23)
        Configbut.TabIndex = 49
        Configbut.Text = "Configure settings"
        Configbut.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(725, 639)
        Button9.Name = "Button9"
        Button9.Size = New Size(75, 23)
        Button9.TabIndex = 50
        Button9.Text = "Upload"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' AddScreenButton
        ' 
        AddScreenButton.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddScreenButton.Location = New Point(12, 10)
        AddScreenButton.Name = "AddScreenButton"
        AddScreenButton.Size = New Size(23, 47)
        AddScreenButton.TabIndex = 51
        AddScreenButton.Text = "+"
        AddScreenButton.UseVisualStyleBackColor = True
        ' 
        ' RemoveScreenButton
        ' 
        RemoveScreenButton.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RemoveScreenButton.Location = New Point(41, 10)
        RemoveScreenButton.Name = "RemoveScreenButton"
        RemoveScreenButton.Size = New Size(25, 47)
        RemoveScreenButton.TabIndex = 52
        RemoveScreenButton.Text = "-"
        RemoveScreenButton.UseVisualStyleBackColor = True
        ' 
        ' Imageselect
        ' 
        Imageselect.FileName = "Imageselect"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(timeset)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(errorbut)
        GroupBox1.Controls.Add(clickedbut)
        GroupBox1.Controls.Add(ButSelect)
        GroupBox1.Location = New Point(989, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(275, 563)
        GroupBox1.TabIndex = 53
        GroupBox1.TabStop = False
        GroupBox1.Text = "State setup"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(133, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 5
        Label3.Text = "seconds"
        ' 
        ' timeset
        ' 
        timeset.Location = New Point(92, 86)
        timeset.Name = "timeset"
        timeset.Size = New Size(35, 23)
        timeset.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 3
        Label2.Text = "Error timeout:"
        ' 
        ' errorbut
        ' 
        errorbut.Location = New Point(100, 47)
        errorbut.Name = "errorbut"
        errorbut.Size = New Size(88, 23)
        errorbut.TabIndex = 2
        errorbut.Text = "Error state"
        errorbut.UseVisualStyleBackColor = True
        ' 
        ' clickedbut
        ' 
        clickedbut.Location = New Point(6, 47)
        clickedbut.Name = "clickedbut"
        clickedbut.Size = New Size(88, 23)
        clickedbut.TabIndex = 1
        clickedbut.Text = "Clicked state"
        clickedbut.UseVisualStyleBackColor = True
        ' 
        ' ButSelect
        ' 
        ButSelect.FormattingEnabled = True
        ButSelect.Location = New Point(6, 18)
        ButSelect.Name = "ButSelect"
        ButSelect.Size = New Size(121, 23)
        ButSelect.TabIndex = 0
        ButSelect.Text = "Button select"
        ' 
        ' PresetBox
        ' 
        PresetBox.FormattingEnabled = True
        PresetBox.Location = New Point(1270, 72)
        PresetBox.Name = "PresetBox"
        PresetBox.Size = New Size(170, 23)
        PresetBox.TabIndex = 54
        PresetBox.Text = "Load Preset"
        ' 
        ' SavePreset
        ' 
        SavePreset.Location = New Point(1365, 639)
        SavePreset.Name = "SavePreset"
        SavePreset.Size = New Size(75, 23)
        SavePreset.TabIndex = 55
        SavePreset.Text = "Save Preset"
        SavePreset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1448, 671)
        ControlBox = False
        Controls.Add(SavePreset)
        Controls.Add(PresetBox)
        Controls.Add(GroupBox1)
        Controls.Add(RemoveScreenButton)
        Controls.Add(AddScreenButton)
        Controls.Add(Button9)
        Controls.Add(Configbut)
        Controls.Add(CustomArea)
        Controls.Add(ScreenSetupGroup)
        Controls.Add(PreviewArea)
        Controls.Add(NavArea)
        Controls.Add(conweb)
        Controls.Add(Connectind)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        ShowIcon = False
        Text = "PalDeck Config"
        WindowState = FormWindowState.Maximized
        CType(Connectind, ComponentModel.ISupportInitialize).EndInit()
        PreviewArea.ResumeLayout(False)
        CType(PreviewBox, ComponentModel.ISupportInitialize).EndInit()
        ScreenSetupGroup.ResumeLayout(False)
        ScreenSetupGroup.PerformLayout()
        CustomArea.ResumeLayout(False)
        CustomArea.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(ButtonPreviewBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Connectind As PictureBox
    Friend WithEvents tryconnect As Timer
    Friend WithEvents conweb As Button
    Friend WithEvents NavArea As ListView
    Friend WithEvents PreviewArea As GroupBox
    Friend WithEvents PreviewBox As PictureBox
    Friend WithEvents BackgroundBut As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ScreenSetupGroup As GroupBox
    Friend WithEvents But_8_Target As ComboBox
    Friend WithEvents But_8_mode As ComboBox
    Friend WithEvents But_7_Target As ComboBox
    Friend WithEvents But_7_mode As ComboBox
    Friend WithEvents But_6_Target As ComboBox
    Friend WithEvents But_6_mode As ComboBox
    Friend WithEvents But_5_Target As ComboBox
    Friend WithEvents But_5_mode As ComboBox
    Friend WithEvents But_4_Target As ComboBox
    Friend WithEvents But_4_mode As ComboBox
    Friend WithEvents But_3_Target As ComboBox
    Friend WithEvents But_3_mode As ComboBox
    Friend WithEvents But_2_Target As ComboBox
    Friend WithEvents But_2_mode As ComboBox
    Friend WithEvents But_1_Target As ComboBox
    Friend WithEvents But_1_mode As ComboBox
    Friend WithEvents Button8picker As Button
    Friend WithEvents Button7picker As Button
    Friend WithEvents Button6picker As Button
    Friend WithEvents Button5picker As Button
    Friend WithEvents Button4picker As Button
    Friend WithEvents Button3picker As Button
    Friend WithEvents Button2picker As Button
    Friend WithEvents Button1picker As Button
    Friend WithEvents custom2 As CheckBox
    Friend WithEvents Custom1 As CheckBox
    Friend WithEvents custom8 As CheckBox
    Friend WithEvents custom7 As CheckBox
    Friend WithEvents custom6 As CheckBox
    Friend WithEvents custom5 As CheckBox
    Friend WithEvents custom4 As CheckBox
    Friend WithEvents custom3 As CheckBox
    Friend WithEvents CustomArea As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomBut As ComboBox
    Friend WithEvents Testbut As Button
    Friend WithEvents Configbut As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents AddScreenButton As Button
    Friend WithEvents RemoveScreenButton As Button
    Friend WithEvents Imageselect As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButSelect As ComboBox
    Friend WithEvents Savebut As Button
    Friend WithEvents PresetBox As ComboBox
    Friend WithEvents SavePreset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents timeset As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents errorbut As Button
    Friend WithEvents clickedbut As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonPreviewBox As PictureBox
    Friend WithEvents ButtonVES As Button
    Friend WithEvents ButtonVCS As Button

End Class
