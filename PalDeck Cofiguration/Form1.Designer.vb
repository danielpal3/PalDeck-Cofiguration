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
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Custom1 = New CheckBox()
        Button8picker = New Button()
        Button7picker = New Button()
        Button6picker = New Button()
        Button5picker = New Button()
        Button4picker = New Button()
        Button3picker = New Button()
        Button2picker = New Button()
        Button1picker = New Button()
        ComboBox13 = New ComboBox()
        ComboBox14 = New ComboBox()
        ComboBox11 = New ComboBox()
        ComboBox12 = New ComboBox()
        ComboBox9 = New ComboBox()
        ComboBox10 = New ComboBox()
        ComboBox7 = New ComboBox()
        ComboBox8 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        But_1_Target = New ComboBox()
        But_1_mode = New ComboBox()
        CustomArea = New GroupBox()
        Testbut = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        CustomBut = New ComboBox()
        Configbut = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Imageselect = New OpenFileDialog()
        CType(Connectind, ComponentModel.ISupportInitialize).BeginInit()
        PreviewArea.SuspendLayout()
        CType(PreviewBox, ComponentModel.ISupportInitialize).BeginInit()
        ScreenSetupGroup.SuspendLayout()
        CustomArea.SuspendLayout()
        SuspendLayout()
        ' 
        ' Connectind
        ' 
        Connectind.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Connectind.Image = My.Resources.Resources.Connected
        Connectind.Location = New Point(852, 3)
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
        conweb.Location = New Point(852, 41)
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
        ScreenSetupGroup.Controls.Add(CheckBox7)
        ScreenSetupGroup.Controls.Add(CheckBox6)
        ScreenSetupGroup.Controls.Add(CheckBox5)
        ScreenSetupGroup.Controls.Add(CheckBox4)
        ScreenSetupGroup.Controls.Add(CheckBox3)
        ScreenSetupGroup.Controls.Add(CheckBox2)
        ScreenSetupGroup.Controls.Add(CheckBox1)
        ScreenSetupGroup.Controls.Add(Custom1)
        ScreenSetupGroup.Controls.Add(Button8picker)
        ScreenSetupGroup.Controls.Add(Button7picker)
        ScreenSetupGroup.Controls.Add(Button6picker)
        ScreenSetupGroup.Controls.Add(Button5picker)
        ScreenSetupGroup.Controls.Add(Button4picker)
        ScreenSetupGroup.Controls.Add(Button3picker)
        ScreenSetupGroup.Controls.Add(Button2picker)
        ScreenSetupGroup.Controls.Add(Button1picker)
        ScreenSetupGroup.Controls.Add(ComboBox13)
        ScreenSetupGroup.Controls.Add(ComboBox14)
        ScreenSetupGroup.Controls.Add(ComboBox11)
        ScreenSetupGroup.Controls.Add(ComboBox12)
        ScreenSetupGroup.Controls.Add(ComboBox9)
        ScreenSetupGroup.Controls.Add(ComboBox10)
        ScreenSetupGroup.Controls.Add(ComboBox7)
        ScreenSetupGroup.Controls.Add(ComboBox8)
        ScreenSetupGroup.Controls.Add(ComboBox5)
        ScreenSetupGroup.Controls.Add(ComboBox6)
        ScreenSetupGroup.Controls.Add(ComboBox3)
        ScreenSetupGroup.Controls.Add(ComboBox4)
        ScreenSetupGroup.Controls.Add(ComboBox1)
        ScreenSetupGroup.Controls.Add(ComboBox2)
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
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(422, 257)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(68, 19)
        CheckBox7.TabIndex = 77
        CheckBox7.Text = "Custom"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(422, 227)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(68, 19)
        CheckBox6.TabIndex = 76
        CheckBox6.Text = "Custom"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(422, 198)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(68, 19)
        CheckBox5.TabIndex = 75
        CheckBox5.Text = "Custom"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(422, 170)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(68, 19)
        CheckBox4.TabIndex = 72
        CheckBox4.Text = "Custom"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(422, 141)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(68, 19)
        CheckBox3.TabIndex = 74
        CheckBox3.Text = "Custom"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(422, 111)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(68, 19)
        CheckBox2.TabIndex = 73
        CheckBox2.Text = "Custom"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(422, 83)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(68, 19)
        CheckBox1.TabIndex = 72
        CheckBox1.Text = "Custom"
        CheckBox1.UseVisualStyleBackColor = True
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
        ' ComboBox13
        ' 
        ComboBox13.FormattingEnabled = True
        ComboBox13.Location = New Point(214, 254)
        ComboBox13.Name = "ComboBox13"
        ComboBox13.Size = New Size(121, 23)
        ComboBox13.TabIndex = 62
        ComboBox13.Text = "Button Target"
        ' 
        ' ComboBox14
        ' 
        ComboBox14.FormattingEnabled = True
        ComboBox14.Location = New Point(87, 253)
        ComboBox14.Name = "ComboBox14"
        ComboBox14.Size = New Size(121, 23)
        ComboBox14.TabIndex = 61
        ComboBox14.Text = "Button Mode"
        ' 
        ' ComboBox11
        ' 
        ComboBox11.FormattingEnabled = True
        ComboBox11.Location = New Point(214, 225)
        ComboBox11.Name = "ComboBox11"
        ComboBox11.Size = New Size(121, 23)
        ComboBox11.TabIndex = 60
        ComboBox11.Text = "Button Target"
        ' 
        ' ComboBox12
        ' 
        ComboBox12.FormattingEnabled = True
        ComboBox12.Location = New Point(87, 224)
        ComboBox12.Name = "ComboBox12"
        ComboBox12.Size = New Size(121, 23)
        ComboBox12.TabIndex = 59
        ComboBox12.Text = "Button Mode"
        ' 
        ' ComboBox9
        ' 
        ComboBox9.FormattingEnabled = True
        ComboBox9.Location = New Point(214, 197)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New Size(121, 23)
        ComboBox9.TabIndex = 58
        ComboBox9.Text = "Button Target"
        ' 
        ' ComboBox10
        ' 
        ComboBox10.FormattingEnabled = True
        ComboBox10.Location = New Point(87, 196)
        ComboBox10.Name = "ComboBox10"
        ComboBox10.Size = New Size(121, 23)
        ComboBox10.TabIndex = 57
        ComboBox10.Text = "Button Mode"
        ' 
        ' ComboBox7
        ' 
        ComboBox7.FormattingEnabled = True
        ComboBox7.Location = New Point(214, 167)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(121, 23)
        ComboBox7.TabIndex = 56
        ComboBox7.Text = "Button Target"
        ' 
        ' ComboBox8
        ' 
        ComboBox8.FormattingEnabled = True
        ComboBox8.Location = New Point(87, 166)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(121, 23)
        ComboBox8.TabIndex = 55
        ComboBox8.Text = "Button Mode"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(214, 139)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(121, 23)
        ComboBox5.TabIndex = 54
        ComboBox5.Text = "Button Target"
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(87, 138)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(121, 23)
        ComboBox6.TabIndex = 53
        ComboBox6.Text = "Button Mode"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(214, 110)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 52
        ComboBox3.Text = "Button Target"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(87, 109)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(121, 23)
        ComboBox4.TabIndex = 51
        ComboBox4.Text = "Button Mode"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(214, 81)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 50
        ComboBox1.Text = "Button Target"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(87, 80)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 49
        ComboBox2.Text = "Button Mode"
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
        But_1_mode.Location = New Point(87, 51)
        But_1_mode.Name = "But_1_mode"
        But_1_mode.Size = New Size(121, 23)
        But_1_mode.TabIndex = 47
        But_1_mode.Text = "Button Mode"
        ' 
        ' CustomArea
        ' 
        CustomArea.Controls.Add(Testbut)
        CustomArea.Controls.Add(TextBox1)
        CustomArea.Controls.Add(Label1)
        CustomArea.Controls.Add(CustomBut)
        CustomArea.Location = New Point(670, 70)
        CustomArea.Name = "CustomArea"
        CustomArea.Size = New Size(313, 563)
        CustomArea.TabIndex = 48
        CustomArea.TabStop = False
        CustomArea.Text = "Custom setup"
        ' 
        ' Testbut
        ' 
        Testbut.Location = New Point(107, 534)
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
        TextBox1.Size = New Size(301, 450)
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
        CustomBut.Text = "Button Config"
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
        ' Button10
        ' 
        Button10.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.Location = New Point(12, 10)
        Button10.Name = "Button10"
        Button10.Size = New Size(23, 47)
        Button10.TabIndex = 51
        Button10.Text = "+"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.Location = New Point(41, 10)
        Button11.Name = "Button11"
        Button11.Size = New Size(25, 47)
        Button11.TabIndex = 52
        Button11.Text = "-"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Imageselect
        ' 
        Imageselect.FileName = "Imageselect"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(995, 530)
        ControlBox = False
        Controls.Add(Button11)
        Controls.Add(Button10)
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
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Custom1 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CustomArea As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomBut As ComboBox
    Friend WithEvents Testbut As Button
    Friend WithEvents Configbut As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Imageselect As OpenFileDialog

End Class
