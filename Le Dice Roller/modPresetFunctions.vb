Module modPresetFunctions
    Function AddPreset() 'Not to be confused with the similarly named AddPresets(). Fuck, that's confusing!
        'This sub controls the 'Add Preset' function
            If frmOptions.txtDefinePreset.Text <> "" And Not (frmOptions.lstPresets.Items.Contains(frmOptions.txtDefinePreset.Text)) Then
            If IsNumeric(frmOptions.txtDefinePreset.Text) Then
                frmOptions.lstPresets.Items.Add(frmOptions.txtDefinePreset.Text)
                My.Settings.Presets.Add(frmOptions.txtDefinePreset.Text)
            Else
                frmOptions_PresetError1.ShowDialog()
            End If
        Else
            frmOptions_PresetError1.ShowDialog()
        End If
        Return True
    End Function

    Function ModifyPreset()
        Dim CurrentSelection As String = frmOptions.lstPresets.SelectedItem.ToString()
        Dim SelectedItemIndex As String = frmOptions.lstPresets.SelectedIndex.ToString()
        'This sub controls the 'Modify Preset' function
        frmOptions.txtDefinePreset.Text = ""
        frmOptions.txtDefinePreset.Text = CurrentSelection
        frmOptions.btnAddPreset.Visible = False
        frmOptions.btnRemovePreset.Visible = False
        frmOptions.btnModifyPreset.Visible = False
        frmOptions.btnSave.Visible = True
        frmOptions.btnCancelEdit.Visible = True
        Return True
    End Function

    Function RemovePreset()
        Dim CurrentSelection As String = frmOptions.lstPresets.SelectedItem.ToString()
        If (frmOptions_RemovePreset.ShowDialog) <> Windows.Forms.DialogResult.Cancel Then
            frmOptions.lstPresets.Items.Remove(CurrentSelection)
            If My.Settings.Presets.Contains(CurrentSelection) Then
                My.Settings.Presets.Remove(CurrentSelection)
                DeletePresetComplete.ShowDialog()
            Else
                'The preset did not exist in memory, so was not deleted.
            End If
        Else
            'Nothing here, people.
        End If
        Return True
    End Function

    Function SavePreset()
        Dim CurrentSelection As String = frmOptions.lstPresets.SelectedItem.ToString()
        'This saves the preset that was modified.
        If Not frmOptions.txtDefinePreset.Text = "" Then
            'Removes the unaltered preset.
            frmOptions.lstPresets.Items.Remove(CurrentSelection)
            'Replaces the removed preset with the modified one. Defaults to bottom atm
            frmOptions.lstPresets.Items.Add(frmOptions.txtDefinePreset.Text)
            frmOptions.btnSave.Visible = False
            frmOptions.btnCancelEdit.Visible = False
            frmOptions.btnAddPreset.Visible = True
            frmOptions.btnModifyPreset.Visible = True
            frmOptions.btnRemovePreset.Visible = True
            frmOptions.txtDefinePreset.Text = ""
            Return True
        Else
            'It's always nice to show the user a dialog.
            frmOptions_PresetError2.ShowDialog()
            Return False
        End If
        Return True
    End Function
    Function CancelModification()
        'This function loads the presets and defaults (if specified)
        frmOptions.lstPresets.SelectedIndex = 0
        frmOptions.btnSave.Visible = False
        frmOptions.btnCancelEdit.Visible = False
        frmOptions.btnAddPreset.Visible = True
        frmOptions.btnModifyPreset.Visible = True
        frmOptions.btnRemovePreset.Visible = True
        frmOptions.txtDefinePreset.Text = ""
        AddPresets()
        Return True
    End Function
End Module
