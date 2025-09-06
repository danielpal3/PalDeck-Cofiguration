Public Class SceneAutoBuildDialog
    Inherits Form

    Private ReadOnly rbAuto As New RadioButton() With {.Text = "Auto-generate from OBS scenes", .Checked = True, .AutoSize = True}
    Private ReadOnly rbManual As New RadioButton() With {.Text = "Manual (I'll add buttons myself)", .AutoSize = True}
    Private ReadOnly lvScenes As New ListView() With {.View = View.Details, .CheckBoxes = True, .FullRowSelect = True, .HeaderStyle = ColumnHeaderStyle.None, .AllowDrop = True}
    Private ReadOnly btnGenerate As New Button() With {.Text = "Generate"}
    Private ReadOnly btnCancel As New Button() With {.Text = "Cancel"}

    Private _result As AutoBuildResult = Nothing

    Public Class AutoBuildResult
        Public Property Mode As String ' "auto" or "manual"
        Public Property SelectedScenesInOrder As List(Of String)
    End Class

    Public Sub New(obsSceneNames As IEnumerable(Of String))
        Me.Text = "Scene Page Setup"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.Width = 520
        Me.Height = 520

        ' Layout
        Dim pnlTop As New FlowLayoutPanel() With {.Dock = DockStyle.Top, .Height = 60, .FlowDirection = FlowDirection.TopDown}
        pnlTop.Controls.Add(rbAuto)
        pnlTop.Controls.Add(rbManual)

        lvScenes.Columns.Add("", 450)
        lvScenes.Dock = DockStyle.Fill
        lvScenes.HideSelection = False

        For Each SName In obsSceneNames
            Dim item As New ListViewItem(Name) With {.Checked = True} ' default include all
            lvScenes.Items.Add(item)
        Next

        AddHandler lvScenes.ItemDrag, AddressOf lv_ItemDrag
        AddHandler lvScenes.DragEnter, AddressOf lv_DragEnter
        AddHandler lvScenes.DragOver, AddressOf lv_DragOver
        AddHandler lvScenes.DragDrop, AddressOf lv_DragDrop

        Dim pnlBtns As New FlowLayoutPanel() With {.Dock = DockStyle.Bottom, .Height = 48, .FlowDirection = FlowDirection.RightToLeft}
        pnlBtns.Controls.Add(btnGenerate)
        pnlBtns.Controls.Add(btnCancel)

        AddHandler rbManual.CheckedChanged, Sub()
                                                lvScenes.Enabled = Not rbManual.Checked
                                            End Sub
        AddHandler btnCancel.Click, Sub() Me.DialogResult = DialogResult.Cancel
        AddHandler btnGenerate.Click, AddressOf OnGenerate

        Controls.Add(lvScenes)
        Controls.Add(pnlBtns)
        Controls.Add(pnlTop)
    End Sub

    Private _dragItem As ListViewItem

    Private Sub lv_ItemDrag(sender As Object, e As ItemDragEventArgs)
        If rbManual.Checked Then Return
        _dragItem = CType(e.Item, ListViewItem)
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub lv_DragEnter(sender As Object, e As DragEventArgs)
        If rbManual.Checked Then Return
        If e.Data.GetDataPresent(GetType(ListViewItem)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub lv_DragOver(sender As Object, e As DragEventArgs)
        If rbManual.Checked Then Return
        e.Effect = DragDropEffects.Move
        Dim lv = CType(sender, ListView)
        Dim pt = lv.PointToClient(New Drawing.Point(e.X, e.Y))
        Dim hoverItem = lv.GetItemAt(pt.X, pt.Y)
        If hoverItem IsNot Nothing AndAlso _dragItem IsNot Nothing AndAlso hoverItem IsNot _dragItem Then
            Dim srcIndex = _dragItem.Index
            Dim dstIndex = hoverItem.Index
            lv.Items.Remove(_dragItem)
            lv.Items.Insert(dstIndex, _dragItem)
        End If
    End Sub

    Private Sub lv_DragDrop(sender As Object, e As DragEventArgs)
        ' no-op; the reinsert happened in DragOver for snappy UX
    End Sub

    Private Sub OnGenerate(sender As Object, e As EventArgs)
        If rbManual.Checked Then
            _result = New AutoBuildResult With {
                .Mode = "manual",
                .SelectedScenesInOrder = New List(Of String)()
            }
            Me.DialogResult = DialogResult.OK
            Return
        End If

        ' Auto: collect checked items in the current visual order
        Dim selected As New List(Of String)
        For Each it As ListViewItem In lvScenes.Items
            If it.Checked Then selected.Add(it.Text)
        Next

        _result = New AutoBuildResult With {
            .Mode = "auto",
            .SelectedScenesInOrder = selected
        }
        Me.DialogResult = DialogResult.OK
    End Sub

    Public Function GetResult() As AutoBuildResult
        Return _result
    End Function
End Class