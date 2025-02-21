<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disconected
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
        Closeapp = New Button()
        update = New Button()
        Retry = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(455, 30)
        Label1.TabIndex = 0
        Label1.Text = "OBS websocket connection has been lost. Would you like to try and reconnect? " + vbCrLf + "If you have recently changed your websocket settings you may need to update them."
        ' 
        ' Closeapp
        ' 
        Closeapp.Location = New Point(175, 42)
        Closeapp.Name = "Closeapp"
        Closeapp.Size = New Size(75, 23)
        Closeapp.TabIndex = 1
        Closeapp.Text = "Close app"
        Closeapp.UseVisualStyleBackColor = True
        ' 
        ' update
        ' 
        update.Location = New Point(256, 42)
        update.Name = "update"
        update.Size = New Size(99, 23)
        update.TabIndex = 2
        update.Text = "Update settings"
        update.UseVisualStyleBackColor = True
        ' 
        ' Retry
        ' 
        Retry.Location = New Point(94, 42)
        Retry.Name = "Retry"
        Retry.Size = New Size(75, 23)
        Retry.TabIndex = 3
        Retry.Text = "Retry"
        Retry.UseVisualStyleBackColor = True
        ' 
        ' Disconected
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 76)
        Controls.Add(Retry)
        Controls.Add(update)
        Controls.Add(Closeapp)
        Controls.Add(Label1)
        Name = "Disconected"
        Text = "Disconected"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Closeapp As Button
    Friend WithEvents update As Button
    Friend WithEvents Retry As Button
End Class
