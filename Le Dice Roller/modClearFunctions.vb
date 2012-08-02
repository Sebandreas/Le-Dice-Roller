Module modClearFunctions
    Function ClearResults(ByRef RemovalType As String)
        'Function Documentation:
        'This function has the syntax as follows:
        'ClearResults(1) clears only the Results table.
        'ClearResults(2) clears everything (except the dice size by default)
        'Any other syntax will result in an error unless you code another 'RemovalType'
        'into this module.
        'Any more documentation is included below
        If RemovalType = "1" Then
            'Clears the listbox.
            If ResetWarning1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If frmMain.lstResults.Items.Count > 0 Then
                    frmMain.lstResults.Items.Clear()
                    Return True
                Else
                    'Nothing to clear, nothing to do.
                    Return False
                End If
            ElseIf Windows.Forms.DialogResult.Cancel Then
                Return False
            End If
        ElseIf RemovalType = "2" Then

            'Clears everything.
            If ResetWarning2.ShowDialog() = Windows.Forms.DialogResult.Yes Or Windows.Forms.DialogResult.OK Then
                If My.Settings.RemoveDieSizeWhenClearingForm = True Then
                    frmMain.cboDieSize.Text = ""
                End If
                frmMain.txtDice.Text = ""
                frmMain.txtRolls.Text = ""
                If frmMain.lstResults.Items.Count <> 0 Then
                    frmMain.lstResults.Items.Clear()
                End If
            End If
            Return True
        Else
            If MessageBox.Show("Incorrect syntax. The correct syntax is ClearResults(((""1 OR 2""))).", "Incorrect Syntax", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) = DialogResult.Abort Then
                End
                Return False
            Else
                Return False
                Exit Function
            End If
        End If
        Return True
    End Function

End Module
