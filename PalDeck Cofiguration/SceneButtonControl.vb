Imports System.Drawing.Drawing2D

Public Class SceneButtonControl
    Inherits UserControl

    Public Property BorderColor As Color = Color.DodgerBlue
    Public Property BorderSize As Integer = 2
    Public Property CornerRadius As Integer = 14
    Public Property TextPadding As Padding = New Padding(10, 10, 10, 10)

    Public Sub New()
        Me.DoubleBuffered = True
        Me.BackColor = Color.FromArgb(28, 28, 28)
        Me.ForeColor = Color.White
        Me.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Border
        If CornerRadius > 0 Then
            Using path = RoundedRect(rect, CornerRadius)
                Using pen As New Pen(BorderColor, BorderSize)
                    g.DrawPath(pen, path)
                End Using
            End Using
        Else
            Using pen As New Pen(BorderColor, BorderSize)
                g.DrawRectangle(pen, rect)
            End Using
        End If

        ' Text drawing within "text bound"
        Dim textArea As New Rectangle(TextPadding.Left, TextPadding.Top, Me.Width - TextPadding.Horizontal, Me.Height - TextPadding.Vertical)
        Dim fittedFont = FitFont(g, Me.Text, Me.Font, textArea.Size)
        Using sf As New StringFormat(StringFormatFlags.NoClip) With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter}
            Using b As New SolidBrush(Me.ForeColor)
                g.DrawString(Me.Text, fittedFont, b, textArea, sf)
            End Using
        End Using
        If Not fittedFont Is Me.Font Then fittedFont.Dispose()
    End Sub

    Private Function FitFont(g As Graphics, text As String, baseFont As Font, area As Size) As Font
        If String.IsNullOrEmpty(text) Then Return baseFont
        Dim size As Single = baseFont.Size
        Dim testFont As Font = Nothing

        For i = 0 To 60 ' cap attempts
            testFont = New Font(baseFont.FontFamily, size, baseFont.Style)
            Dim sz = g.MeasureString(text, testFont, area.Width)
            If sz.Height <= area.Height AndAlso sz.Width <= area.Width Then
                Return testFont
            End If
            testFont.Dispose()
            size -= 0.5F
            If size < 7.5F Then Exit For
        Next
        Return New Font(baseFont.FontFamily, Math.Max(7.5F, size), baseFont.Style)
    End Function

    Private Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d = radius * 2
        path.AddArc(r.X, r.Y, d, d, 180, 90)
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function
End Class