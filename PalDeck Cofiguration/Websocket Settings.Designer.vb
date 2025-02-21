<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Websocket_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Pass = New Label()
        ipval = New TextBox()
        port = New TextBox()
        passval = New TextBox()
        Save = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 15)
        Label2.TabIndex = 1
        Label2.Text = "Port"
        ' 
        ' Pass
        ' 
        Pass.AutoSize = True
        Pass.Location = New Point(12, 74)
        Pass.Name = "Pass"
        Pass.Size = New Size(57, 15)
        Pass.TabIndex = 2
        Pass.Text = "Password"
        ' 
        ' ipval
        ' 
        ipval.Location = New Point(75, 1)
        ipval.Name = "ipval"
        ipval.Size = New Size(179, 23)
        ipval.TabIndex = 3
        ipval.Text = "127.0.0.1"
        ' 
        ' port
        ' 
        port.Location = New Point(75, 30)
        port.Name = "port"
        port.Size = New Size(179, 23)
        port.TabIndex = 4
        port.Text = "4455"
        ' 
        ' passval
        ' 
        passval.Location = New Point(75, 66)
        passval.Name = "passval"
        passval.PasswordChar = "*"c
        passval.Size = New Size(179, 23)
        passval.TabIndex = 5
        ' 
        ' Save
        ' 
        Save.Location = New Point(108, 95)
        Save.Name = "Save"
        Save.Size = New Size(75, 23)
        Save.TabIndex = 6
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Websocket_Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(278, 128)
        Controls.Add(Save)
        Controls.Add(passval)
        Controls.Add(port)
        Controls.Add(ipval)
        Controls.Add(Pass)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Websocket_Settings"
        Text = "Websocket_Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pass As Label
    Friend WithEvents ipval As TextBox
    Friend WithEvents port As TextBox
    Friend WithEvents passval As TextBox
    Friend WithEvents Save As Button
End Class
