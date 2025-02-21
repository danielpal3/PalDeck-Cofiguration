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
        BG = New PictureBox()
        But1 = New PictureBox()
        But2 = New PictureBox()
        But4 = New PictureBox()
        But3 = New PictureBox()
        But8 = New PictureBox()
        But7 = New PictureBox()
        But6 = New PictureBox()
        But5 = New PictureBox()
        changebg = New Button()
        Label1 = New Label()
        sel6 = New RadioButton()
        sel8 = New RadioButton()
        Connectind = New PictureBox()
        stob = New Button()
        ComboBox1 = New ComboBox()
        tryconnect = New Timer(components)
        TrackBar1 = New TrackBar()
        Label2 = New Label()
        audiotoscene = New Button()
        audio1 = New Label()
        audio2 = New Label()
        audio3 = New Label()
        audio4 = New Label()
        audio5 = New Label()
        TrackBar2 = New TrackBar()
        TrackBar3 = New TrackBar()
        TrackBar4 = New TrackBar()
        TrackBar5 = New TrackBar()
        TrackBar6 = New TrackBar()
        TrackBar7 = New TrackBar()
        TrackBar8 = New TrackBar()
        audio6 = New Label()
        audio7 = New Label()
        audio8 = New Label()
        conweb = New Button()
        CType(BG, ComponentModel.ISupportInitialize).BeginInit()
        CType(But1, ComponentModel.ISupportInitialize).BeginInit()
        CType(But2, ComponentModel.ISupportInitialize).BeginInit()
        CType(But4, ComponentModel.ISupportInitialize).BeginInit()
        CType(But3, ComponentModel.ISupportInitialize).BeginInit()
        CType(But8, ComponentModel.ISupportInitialize).BeginInit()
        CType(But7, ComponentModel.ISupportInitialize).BeginInit()
        CType(But6, ComponentModel.ISupportInitialize).BeginInit()
        CType(But5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Connectind, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar3, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar4, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar5, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar6, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar7, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BG
        ' 
        BG.Image = My.Resources.Resources._02
        BG.Location = New Point(245, 12)
        BG.Name = "BG"
        BG.Size = New Size(480, 320)
        BG.TabIndex = 0
        BG.TabStop = False
        ' 
        ' But1
        ' 
        But1.Location = New Point(257, 25)
        But1.Margin = New Padding(5)
        But1.Name = "But1"
        But1.Size = New Size(106, 83)
        But1.TabIndex = 1
        But1.TabStop = False
        ' 
        ' But2
        ' 
        But2.Location = New Point(373, 25)
        But2.Margin = New Padding(5)
        But2.Name = "But2"
        But2.Size = New Size(106, 83)
        But2.TabIndex = 2
        But2.TabStop = False
        ' 
        ' But4
        ' 
        But4.Location = New Point(605, 25)
        But4.Margin = New Padding(5)
        But4.Name = "But4"
        But4.Size = New Size(106, 83)
        But4.TabIndex = 3
        But4.TabStop = False
        ' 
        ' But3
        ' 
        But3.Location = New Point(489, 25)
        But3.Margin = New Padding(5)
        But3.Name = "But3"
        But3.Size = New Size(106, 83)
        But3.TabIndex = 4
        But3.TabStop = False
        ' 
        ' But8
        ' 
        But8.Location = New Point(605, 234)
        But8.Margin = New Padding(5)
        But8.Name = "But8"
        But8.Size = New Size(106, 83)
        But8.TabIndex = 5
        But8.TabStop = False
        ' 
        ' But7
        ' 
        But7.Location = New Point(489, 234)
        But7.Margin = New Padding(5)
        But7.Name = "But7"
        But7.Size = New Size(106, 83)
        But7.TabIndex = 6
        But7.TabStop = False
        ' 
        ' But6
        ' 
        But6.Location = New Point(373, 234)
        But6.Margin = New Padding(5)
        But6.Name = "But6"
        But6.Size = New Size(106, 83)
        But6.TabIndex = 7
        But6.TabStop = False
        ' 
        ' But5
        ' 
        But5.Location = New Point(257, 234)
        But5.Margin = New Padding(5)
        But5.Name = "But5"
        But5.Size = New Size(106, 83)
        But5.TabIndex = 8
        But5.TabStop = False
        ' 
        ' changebg
        ' 
        changebg.Location = New Point(12, 12)
        changebg.Name = "changebg"
        changebg.Size = New Size(136, 23)
        changebg.TabIndex = 9
        changebg.Text = "Change background"
        changebg.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 15)
        Label1.TabIndex = 10
        Label1.Text = "How many buttons do you want?"
        ' 
        ' sel6
        ' 
        sel6.AutoSize = True
        sel6.Location = New Point(12, 56)
        sel6.Name = "sel6"
        sel6.Size = New Size(31, 19)
        sel6.TabIndex = 11
        sel6.TabStop = True
        sel6.Text = "6"
        sel6.UseVisualStyleBackColor = True
        ' 
        ' sel8
        ' 
        sel8.AutoSize = True
        sel8.Location = New Point(49, 56)
        sel8.Name = "sel8"
        sel8.Size = New Size(31, 19)
        sel8.TabIndex = 12
        sel8.TabStop = True
        sel8.Text = "8"
        sel8.UseVisualStyleBackColor = True
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
        ' stob
        ' 
        stob.Location = New Point(12, 81)
        stob.Name = "stob"
        stob.Size = New Size(136, 27)
        stob.TabIndex = 14
        stob.Text = "Link scenes to buttons"
        stob.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 114)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(183, 23)
        ComboBox1.TabIndex = 15
        ' 
        ' tryconnect
        ' 
        tryconnect.Interval = 500
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(247, 338)
        TrackBar1.Maximum = 0
        TrackBar1.Minimum = -60
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(363, 45)
        TrackBar1.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 317)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 15)
        Label2.TabIndex = 17
        Label2.Text = "Audio sources for selected scene"
        ' 
        ' audiotoscene
        ' 
        audiotoscene.Location = New Point(12, 143)
        audiotoscene.Name = "audiotoscene"
        audiotoscene.Size = New Size(183, 23)
        audiotoscene.TabIndex = 19
        audiotoscene.Text = "Link audio source to scene"
        audiotoscene.UseVisualStyleBackColor = True
        ' 
        ' audio1
        ' 
        audio1.AutoSize = True
        audio1.Location = New Point(12, 338)
        audio1.Name = "audio1"
        audio1.Size = New Size(41, 15)
        audio1.TabIndex = 20
        audio1.Text = "Label3"
        ' 
        ' audio2
        ' 
        audio2.AutoSize = True
        audio2.Location = New Point(12, 382)
        audio2.Name = "audio2"
        audio2.Size = New Size(41, 15)
        audio2.TabIndex = 21
        audio2.Text = "Label4"
        ' 
        ' audio3
        ' 
        audio3.AutoSize = True
        audio3.Location = New Point(12, 424)
        audio3.Name = "audio3"
        audio3.Size = New Size(41, 15)
        audio3.TabIndex = 22
        audio3.Text = "Label5"
        ' 
        ' audio4
        ' 
        audio4.AutoSize = True
        audio4.Location = New Point(12, 467)
        audio4.Name = "audio4"
        audio4.Size = New Size(41, 15)
        audio4.TabIndex = 23
        audio4.Text = "Label6"
        ' 
        ' audio5
        ' 
        audio5.AutoSize = True
        audio5.Location = New Point(12, 510)
        audio5.Name = "audio5"
        audio5.Size = New Size(41, 15)
        audio5.TabIndex = 24
        audio5.Text = "Label7"
        ' 
        ' TrackBar2
        ' 
        TrackBar2.Location = New Point(247, 381)
        TrackBar2.Maximum = 0
        TrackBar2.Minimum = -60
        TrackBar2.Name = "TrackBar2"
        TrackBar2.Size = New Size(363, 45)
        TrackBar2.TabIndex = 25
        ' 
        ' TrackBar3
        ' 
        TrackBar3.Location = New Point(247, 424)
        TrackBar3.Maximum = 0
        TrackBar3.Minimum = -60
        TrackBar3.Name = "TrackBar3"
        TrackBar3.Size = New Size(363, 45)
        TrackBar3.TabIndex = 26
        ' 
        ' TrackBar4
        ' 
        TrackBar4.Location = New Point(247, 510)
        TrackBar4.Maximum = 0
        TrackBar4.Minimum = -60
        TrackBar4.Name = "TrackBar4"
        TrackBar4.Size = New Size(363, 45)
        TrackBar4.TabIndex = 27
        ' 
        ' TrackBar5
        ' 
        TrackBar5.Location = New Point(247, 467)
        TrackBar5.Maximum = 0
        TrackBar5.Minimum = -60
        TrackBar5.Name = "TrackBar5"
        TrackBar5.Size = New Size(363, 45)
        TrackBar5.TabIndex = 28
        ' 
        ' TrackBar6
        ' 
        TrackBar6.Location = New Point(247, 553)
        TrackBar6.Maximum = 0
        TrackBar6.Minimum = -60
        TrackBar6.Name = "TrackBar6"
        TrackBar6.Size = New Size(363, 45)
        TrackBar6.TabIndex = 29
        ' 
        ' TrackBar7
        ' 
        TrackBar7.Location = New Point(247, 596)
        TrackBar7.Maximum = 0
        TrackBar7.Minimum = -60
        TrackBar7.Name = "TrackBar7"
        TrackBar7.Size = New Size(363, 45)
        TrackBar7.TabIndex = 30
        ' 
        ' TrackBar8
        ' 
        TrackBar8.Location = New Point(247, 639)
        TrackBar8.Maximum = 0
        TrackBar8.Minimum = -60
        TrackBar8.Name = "TrackBar8"
        TrackBar8.Size = New Size(363, 45)
        TrackBar8.TabIndex = 31
        ' 
        ' audio6
        ' 
        audio6.AutoSize = True
        audio6.Location = New Point(12, 553)
        audio6.Name = "audio6"
        audio6.Size = New Size(41, 15)
        audio6.TabIndex = 32
        audio6.Text = "Label7"
        ' 
        ' audio7
        ' 
        audio7.AutoSize = True
        audio7.Location = New Point(12, 596)
        audio7.Name = "audio7"
        audio7.Size = New Size(41, 15)
        audio7.TabIndex = 33
        audio7.Text = "Label7"
        ' 
        ' audio8
        ' 
        audio8.AutoSize = True
        audio8.Location = New Point(12, 639)
        audio8.Name = "audio8"
        audio8.Size = New Size(41, 15)
        audio8.TabIndex = 34
        audio8.Text = "Label7"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(995, 674)
        ControlBox = False
        Controls.Add(conweb)
        Controls.Add(audio8)
        Controls.Add(audio7)
        Controls.Add(audio6)
        Controls.Add(TrackBar7)
        Controls.Add(TrackBar8)
        Controls.Add(TrackBar6)
        Controls.Add(TrackBar4)
        Controls.Add(TrackBar5)
        Controls.Add(TrackBar3)
        Controls.Add(TrackBar2)
        Controls.Add(TrackBar1)
        Controls.Add(audio5)
        Controls.Add(audio4)
        Controls.Add(audio3)
        Controls.Add(audio2)
        Controls.Add(audio1)
        Controls.Add(audiotoscene)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(stob)
        Controls.Add(Connectind)
        Controls.Add(sel8)
        Controls.Add(sel6)
        Controls.Add(Label1)
        Controls.Add(changebg)
        Controls.Add(But5)
        Controls.Add(But6)
        Controls.Add(But7)
        Controls.Add(But8)
        Controls.Add(But3)
        Controls.Add(But4)
        Controls.Add(But2)
        Controls.Add(But1)
        Controls.Add(BG)
        Name = "Form1"
        ShowIcon = False
        Text = "PalDeck Config"
        WindowState = FormWindowState.Maximized
        CType(BG, ComponentModel.ISupportInitialize).EndInit()
        CType(But1, ComponentModel.ISupportInitialize).EndInit()
        CType(But2, ComponentModel.ISupportInitialize).EndInit()
        CType(But4, ComponentModel.ISupportInitialize).EndInit()
        CType(But3, ComponentModel.ISupportInitialize).EndInit()
        CType(But8, ComponentModel.ISupportInitialize).EndInit()
        CType(But7, ComponentModel.ISupportInitialize).EndInit()
        CType(But6, ComponentModel.ISupportInitialize).EndInit()
        CType(But5, ComponentModel.ISupportInitialize).EndInit()
        CType(Connectind, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar3, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar4, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar5, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar6, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar7, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BG As PictureBox
    Friend WithEvents But1 As PictureBox
    Friend WithEvents But2 As PictureBox
    Friend WithEvents But4 As PictureBox
    Friend WithEvents But3 As PictureBox
    Friend WithEvents But8 As PictureBox
    Friend WithEvents But7 As PictureBox
    Friend WithEvents But6 As PictureBox
    Friend WithEvents But5 As PictureBox
    Friend WithEvents changebg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents sel6 As RadioButton
    Friend WithEvents sel8 As RadioButton
    Friend WithEvents Connectind As PictureBox
    Friend WithEvents stob As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tryconnect As Timer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents audiotoscene As Button
    Friend WithEvents audio1 As Label
    Friend WithEvents audio2 As Label
    Friend WithEvents audio3 As Label
    Friend WithEvents audio4 As Label
    Friend WithEvents audio5 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents TrackBar5 As TrackBar
    Friend WithEvents TrackBar6 As TrackBar
    Friend WithEvents TrackBar7 As TrackBar
    Friend WithEvents TrackBar8 As TrackBar
    Friend WithEvents audio6 As Label
    Friend WithEvents audio7 As Label
    Friend WithEvents audio8 As Label
    Friend WithEvents conweb As Button

End Class
