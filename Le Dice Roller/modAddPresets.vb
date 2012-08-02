Module modAddPresets
    Function AddPresets()
        frmOptions.lstPresets.Items.Clear()
        For Each item As String In My.Settings.Presets
            frmOptions.lstPresets.Items.Add(item)
        Next
        Return True
    End Function
    Function LoadPresets()
        Dim LoadedPresets As Integer
        LoadedPresets = 0
        frmMain.cboDieSize.Items.Clear()
        For Each item As String In My.Settings.Presets
            frmMain.cboDieSize.Items.Add(item)
            LoadedPresets = LoadedPresets + 1
        Next
        frmMain.lblLoadingIndicator.Text = "Done. Loaded " & LoadedPresets.ToString() & " presets."
        Return True
    End Function
End Module
