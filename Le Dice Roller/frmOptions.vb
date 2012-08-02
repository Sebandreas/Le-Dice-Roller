Public Class frmOptions

    Private Sub btnAddPreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPreset.Click
        AddPreset()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This function loads the presets and defaults (if specified)
        loadSlider()
        If My.Settings.DisableHumor = True Then
            chkDisableHumor.CheckState = CheckState.Checked
        ElseIf My.Settings.DisableHumor = False Then
            chkDisableHumor.CheckState = CheckState.Unchecked
        End If
        If My.Settings.DiceDefaults <> "" Then
            txtDiceDefaults.Text = My.Settings.DiceDefaults
        End If
        If My.Settings.RollsDefaults <> "" Then
            txtRollsDefaults.Text = My.Settings.RollsDefaults
        End If
        If My.Settings.VisEffectsChecked = True Then
            chkVisualEffects.CheckState = CheckState.Checked
            sldFxSpeed.Enabled = True
        ElseIf My.Settings.VisEffectsChecked = False Then
            chkVisualEffects.CheckState = CheckState.Unchecked
            sldFxSpeed.Enabled = False
        End If
        If My.Settings.RemoveDieSizeWhenClearingForm = True Then
            chkRemoveDiceSizeWhenClearingForm.CheckState = CheckState.Checked
        ElseIf My.Settings.RemoveDieSizeWhenClearingForm = False Then
            chkRemoveDiceSizeWhenClearingForm.CheckState = CheckState.Unchecked
        End If
        'Preset loader function.
        AddPresets()
        lstPresets.SelectedIndex = 0
        Dim CurrentSelection As String = lstPresets.SelectedItem.ToString()
        txtDefinePreset.Text = CurrentSelection
        lblSelectionAlreadyPreset.Visible = False
        txtDefinePreset.BackColor = Color.White
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Savenquit()
        saveSlider()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePreset.Click
        RemovePreset()
    End Sub

    Private Sub txtDiceDefaults_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiceDefaults.TextChanged
        If txtDiceDefaults.Text = "" Then
            lblNoNumeric1.Hide()
            txtDiceDefaults.BackColor = Color.White
            txtDiceDefaults.ForeColor = Color.Black
        End If
        If Not txtDiceDefaults.Text = "" Then
            If IsNumeric(txtDiceDefaults.Text) = False Then
                lblNoNumeric1.Show()
                txtDiceDefaults.BackColor = Color.Red
                txtDiceDefaults.ForeColor = Color.White
            ElseIf IsNumeric(txtDiceDefaults.Text) = True Then
                lblNoNumeric1.Hide()
                txtDiceDefaults.BackColor = Color.White
                txtDiceDefaults.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub txtRollsDefaults_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRollsDefaults.TextChanged
        If txtRollsDefaults.Text = "" Then
            lblNoNumeric2.Hide()
            txtRollsDefaults.BackColor = Color.White
            txtRollsDefaults.ForeColor = Color.Black
        End If
        If Not txtRollsDefaults.Text = "" Then
            If IsNumeric(txtRollsDefaults.Text) = False Then
                lblNoNumeric2.Show()
                txtRollsDefaults.BackColor = Color.Red
                txtRollsDefaults.ForeColor = Color.White
            ElseIf IsNumeric(txtRollsDefaults.Text) = True Then
                lblNoNumeric2.Hide()
                txtRollsDefaults.BackColor = Color.White
                txtRollsDefaults.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub txtDefinePreset_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDefinePreset.TextChanged
        If lstPresets.Items.Contains(txtDefinePreset.Text) = True Then
            If txtDefinePreset.ForeColor = Color.White Then
                txtDefinePreset.ForeColor = Color.Black
            End If
            If lblNoNumeric3.Visible = True Then
                lblNoNumeric3.Visible = False
            End If
            lblSelectionAlreadyPreset.Show()
            txtDefinePreset.BackColor = Color.Yellow
            If btnSave.Visible = True Then
                lblSelectionAlreadyPreset.Hide()
                txtDefinePreset.BackColor = Color.White
            End If
        ElseIf lstPresets.Items.Contains(txtDefinePreset.Text) = False Then
            lblSelectionAlreadyPreset.Hide()
            txtDefinePreset.BackColor = Color.White
        End If
        If txtDefinePreset.Text = "" Then
            lblNoNumeric3.Hide()
            txtDefinePreset.BackColor = Color.White
            txtDefinePreset.ForeColor = Color.Black
        End If
        If Not txtDefinePreset.Text = "" Then
            If IsNumeric(txtDefinePreset.Text) = False Then
                lblSelectionAlreadyPreset.Visible = False
                lblNoNumeric3.Show()
                txtDefinePreset.BackColor = Color.Red
                txtDefinePreset.ForeColor = Color.White
            ElseIf IsNumeric(txtRollsDefaults.Text) = True Then
                lblNoNumeric3.Hide()
                txtDefinePreset.BackColor = Color.White
                txtDefinePreset.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyPreset.Click
        ModifyPreset()
    End Sub

    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        CancelModification()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SavePreset()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo2Top.Click
        lstPresets.SelectedIndex = 0
    End Sub

    Private Sub ExportToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToFileToolStripMenuItem.Click
        'Exports the presets to a .txt file. See modFunctions for more details
        ExportPresets()
    End Sub

    Private Sub ExportOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportOptionsToolStripMenuItem.Click
    End Sub

    Private mSelectedIndex, mOtherIndex As Integer

    Private Sub btnMoveIndexUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveIndexUp.Click
        If lstPresets.SelectedIndex <> 0 Then
            'do nothing if the top item is selected.
            mSelectedIndex = lstPresets.SelectedIndex

            mOtherIndex = mSelectedIndex - 1

            lstPresets.Items.Insert(mSelectedIndex + 1, lstPresets.Items(mOtherIndex))

            lstPresets.Items.RemoveAt(mOtherIndex)
        End If

    End Sub

    Private Sub btnMoveIndexDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveIndexDown.Click
        'do nothing if the bottom item is selected.

        If lstPresets.SelectedIndex <> lstPresets.Items.Count - 1 Then

            mSelectedIndex = lstPresets.SelectedIndex

            mOtherIndex = mSelectedIndex + 1

            lstPresets.Items.Insert(mSelectedIndex, lstPresets.Items(mOtherIndex))

            lstPresets.Items.RemoveAt(mOtherIndex + 1)
        End If
    End Sub

    Private Sub lstPresets_Click(sender As Object, e As System.EventArgs) Handles lstPresets.Click
        If IsNumeric(txtDefinePreset.Text) Then
            If lstPresets.SelectedItem = True Then
                txtDefinePreset.Text = lstPresets.SelectedItem.ToString()
                If btnSave.Visible = True Then
                    lblSelectionAlreadyPreset.Visible = False
                    txtDefinePreset.BackColor = Color.White
                End If
            End If
        Else
            'Something
        End If
    End Sub

    Private Sub lstPresets_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPresets.DoubleClick
        txtDefinePreset.Text = lstPresets.SelectedItem.ToString()
        txtDefinePreset.Focus()
        If btnSave.Visible = True Then
            lblSelectionAlreadyPreset.Visible = False
            txtDefinePreset.BackColor = Color.White
        End If
    End Sub

    Private Sub AddPresetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPresetToolStripMenuItem.Click
        txtDefinePreset.Focus()
    End Sub

    Private Sub ModifyPresetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyPresetsToolStripMenuItem.Click
        ModifyPreset()
    End Sub

    Private Sub RemovePresetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovePresetToolStripMenuItem.Click
        RemovePreset()
    End Sub

    Private Sub ExitWithoutSavingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitWithoutSavingToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lstPresets_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPresets.SelectedIndexChanged
        lblSelectedPresetIndex.Text = lstPresets.SelectedIndex.ToString()
    End Sub

    Private Sub chkVisualEffects_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisualEffects.CheckedChanged
        If chkVisualEffects.CheckState = CheckState.Checked Then
            sldFxSpeed.Enabled = True
        Else
            sldFxSpeed.Enabled = False
        End If
    End Sub

    Private Sub sldFxSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldFxSpeed.Scroll
        lblSpeedNo.Text = sldFxSpeed.Value.ToString()
    End Sub

    Private Sub btnGo2Bottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo2Bottom.Click
        lstPresets.SelectedIndex = lstPresets.Items.Count - 1
    End Sub

    Private Sub btnOkay_HelpRequested(sender As System.Object, hlpevent As System.Windows.Forms.HelpEventArgs) Handles btnOkay.HelpRequested

    End Sub
End Class