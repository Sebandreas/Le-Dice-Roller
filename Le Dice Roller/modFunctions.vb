Module modFunctions
    Function Calculate()
        Try
            If frmMain.txtDice.Text = "" Then
                'Throws an exclamation dialog box if there is no text in frmMain.txtDice. Then it quits the Sub.
                frmDiceMessage.ShowDialog()
                Return vbFalse
                Exit Function
            ElseIf frmMain.txtRolls.Text = "" Then
                'Throws an exclamation dialog box if there is no text in frmMain.txtRolls. Ditto.
                frmRollsMessage.ShowDialog()
                Return False
                Exit Function
            ElseIf frmMain.cboDieSize.Text = "1" Then
                'This makes a funny dialog box pop up to indicate that the number entered was stupid.
                frmSillyDiceNumber.ShowDialog()
                Return False
                Exit Function

            ElseIf frmMain.cboDieSize.Text = "0" Then
                'Same as before.
                frmSillyDiceNumber.ShowDialog()
                Return False
                Exit Function
            End If
            If IsNumeric(frmMain.txtDice.Text) = False Then
                'Throws an exclamation dialog box if there is text in frmMain.txtDice, but it is not 100% numbers. Ditto.
                frmDiceNoNumbers.ShowDialog()
                Return False
                Exit Function
            ElseIf IsNumeric(frmMain.txtRolls.Text) = False Then
                'Throws an exclamation dialog box if there is text in frmMain.txtDice, but it is not 100% numbers. Only thrown if the text in frmMain.txtDice is numeric, but
                'the text in frmMain.txtRolls is not. Also exits sub when dialog is dismissed.
                frmRollsNoNumbers.ShowDialog()
                Return False
                Exit Function
            Else
                frmMain.btnCalculate.Enabled = False
                If My.Settings.DisableHumor = True Then
                    frmMain.btnCalculate.Text = "Calculating..."
                Else
                    frmMain.btnCalculate.Text = "CALCULATING..."
                End If

                'frmCalculating.Show()
                'This is the code that calculates everything. This is also used by the 'calculate' button in frmYUNOCalculate.vb.
                frmMain.lstResults.Items.Clear()
                'Dims RollsNo as a string of text, then defines it as the text in frmMain.txtDice.
                Dim RollsNo As String
                RollsNo = frmMain.txtRolls.Text
                'Ditto of above, except with the number of dice..
                Dim DiceNo As String
                DiceNo = frmMain.txtDice.Text
                Dim DieSize As String
                DieSize = frmMain.cboDieSize.Text
                'Dims the result as a string of text.
                Dim TheResult As String
                'Just specifies that the term TheResult is a string. This will hold the result of the calculation.
                'Dim CalculatedNumbers As Integer

                'The 'iCounter1 for loop' will get the number from frmMain.txtRolls and will generate a random number. This will repeat until the dice has been 'rolled'
                'the specified amount of times.
                For iCounter1 = 0 To Val(RollsNo) - 1
                    'Self explanitory, I think
                    TheResult = ""
                    'The 'iCounter2 for loop' will get the number from frmMain.txtDice and will 'roll' that many 'dice'. The comment below describes how the program does it.
                    '
                    ' We put a new item into the result listbox
                    ' Each time, we put a random number between 0.0000... to [the value of cboDieSize.text].99999...
                    ' and turn it into a whole number by using the Int (Integer) function (so it becomes 0 - [whatever is in cboDieSize.Text] instead of pi for instance),
                    ' then we add 1 on top of the result so the result will remain between
                    ' 1 to [whatever is in cboDieSize.Text] which is just like a real dice/die.
                    For iCounter2 = 0 To Val(DiceNo) - 1
                        Randomize()
                        TheResult = TheResult + " " + (Int(Rnd() * DieSize) + 1).ToString
                    Next iCounter2
                    frmMain.lstResults.Items.Add(TheResult)
                    'CalculatedNumbers = CalculatedNumbers + 1
                    'frmMain.lblCalculatedRollsNo.Text = CalculatedNumbers.ToString()
                    'This places the result of the calculation in the listbox at the bottom, all ready for export!
                Next iCounter1
            End If
            'The two options below are just placeholders for a future implementation.
            'frmCalculating.Visible = False
            'frmCalculating.Close()
            'A housekeeping function that is self-explanitory...
            frmMain.btnCalculate.Enabled = True
            frmMain.Width = 752
            'This changes the text back, and determines if humor is disabled or not.
            If My.Settings.DisableHumor = True Then
                frmMain.btnCalculate.Text = "Calculate..."
            Else
                frmMain.btnCalculate.Text = "CALCULATE"
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("An unspecified error has occured. Please try again", "Unspecified Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function

    Function SaveToTextFile()
        'If the user clicks Cancel, nothing happens, and the user is returned to the form.
        'TODO: Make this a wizard. Maybe in version two.
        '
        'If the user saves the file, the items in the results listbox (frmMain.lstResults) are turned into a lot of strings of text.
        'The program then questions if the user has actually calculated the result by clicking the comically oversized button on frmMain.
        'If they have, then a report is generated, and the user is satisfied. If they have not, the form frmYUNOCalculate shows as a dialog,
        'and asks the user if they would like to calculate the result. If the user wants to calculate the result, they click the 'calculate result' button,
        'the report is generated, and the user is satisfied. If they click cancel, the report is not generated, and they are returned to the main window.
        'One more thing: Explained more in frmYUNOCalculate, the user cannot click the 'x'/close button in the YUNOCalculate dialog, as it is disabled 
        'through a nifty WIN32 API call.
        If frmMain.dlgSaveAsText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            frmMain.lstResults.Items.Count.ToString()
            'This distinguishes if the listbox has 0 items in it or not. This is usually because the user has not clicked 'Calculate'.
            If frmMain.lstResults.Items.Count = 0 Then
                'Pretty much explained above.
                frmYUNOCalculate.ShowDialog()
                Return False
            Else
                SaveFile()
                Return True
            End If
        End If
        Return True
    End Function

    Function SaveFile()
        ' This function actually writes to the file.
        '
        ' IO.StreamWriter(frmMain.dlgSaveAsText.FileName, True):
        '
        ' The IO.Streamwriter is used to write text to documents. In this program, it is used to create a generated report.
        ' frmMain.dlgSaveAsText.FileName: This is a string, which displays the location of the saved file.
        ' The ASCII art, Le Dice Roller, the SebWare trademark, and the word SebWare used in the generated report are not licensed under the NC-BY-SA license.
        ' They are trademarks of SebWare. However, everything else is licensed under the NC-BY-SA License, or is in the public domain.
        Using SW As New IO.StreamWriter(frmMain.dlgSaveAsText.FileName, True)
            SW.WriteLine(" __                  _____                       ®")
            SW.WriteLine("/\ \                /\  _ `\  __                  ")
            SW.WriteLine("\ \ \         __    \ \ \/\ \/\_\    ___    ___   ")
            SW.WriteLine(" \ \ \      /'__`\   \ \ \ \ \/\ \  /'__\  /'__`\ ")
            SW.WriteLine("  \ \ \___ /\  __/    \ \ \_\ \ \ \/\ \_/ /\  __/ ")
            SW.WriteLine("   \ \____\\ \____\    \ \____/\ \_\ \___\\ \____\")
            SW.WriteLine("    \/___/  \/____/     \/___/  \/_/\/___/ \/____/")
            SW.WriteLine("                                                  ")
            SW.WriteLine(" _____           ___    ___                       ")
            SW.WriteLine("/\  _ `\        /\_ \  /\_ \                      ")
            SW.WriteLine("\ \ \/\ \    ___\//\ \ \//\ \     ___   ____      ")
            SW.WriteLine(" \ \ ,__ \  / __`\\ \ \  \ \ \   /'__`\/\`'__\    ")
            SW.WriteLine("  \ \ \ \ \_\ \/\ \\_\ \_ \_\ \_/\  __/\ \ \/     ")
            SW.WriteLine("   \ \_\ \________//\____\/\____\ \____\\ \_\     ")
            SW.WriteLine("    \/_/\/_______/ \/____/\/____/\/____/ \/_/     ")
            SW.WriteLine("      A SEBWARE™ PROGRAM >>> WWW.SEBWARE.TK       ")
            SW.WriteLine("=========================================================================")
            SW.WriteLine("Le Dice Roller Automatically Generated Report  ")
            'SW.WriteLine( 'This adds the number of dice and their size, and the number of rolls.
            SW.WriteLine("Number of dice:       " & frmMain.txtDice.Text & ".    ")
            SW.WriteLine("Number of dice rolls: " & frmMain.txtRolls.Text & ".   ")
            SW.WriteLine("Size of dice:         " & frmMain.cboDieSize.Text & ". ")
            SW.WriteLine("Text file generated at: " & Now.ToLongTimeString & ".  ")
            SW.WriteLine("==========================================================================")
            SW.WriteLine(" ")
            SW.WriteLine("Result:")
            ''itm' stands for the numbers (items) in frmMain.lstResults. This is added to the report lastly.
            For Each item As String In frmMain.lstResults.Items
                'Writes each number down in the text document.
                SW.WriteLine(item)
            Next
            'Displays a messagebox indicating success! Yes!
            SaveSucess.lblFileName.Text = frmMain.dlgSaveAsText.FileName.ToString()
            SaveSucess.ShowDialog()
            Return True
        End Using
        'TODO: Add error handling function if the computer/drive runs out of memory, or just stuffs up.
    End Function
    Function ExportPresets()
        'Refer to above example for documentation. This uses 'EP' instead of 'SW', and instead of exporting
        'results, this exports presets (obviously :D)
        If frmOptions.dlgSavePresetsToTxt.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Using EP As New IO.StreamWriter(frmOptions.dlgSavePresetsToTxt.FileName, True)
                For Each item As String In frmOptions.lstPresets.Items
                    'Writes each number down in the text document.
                    EP.WriteLine(item)
                Next
                SaveSucess.lblFileName.Text = frmOptions.dlgSavePresetsToTxt.FileName.ToString()
                SaveSucess.ShowDialog()
            End Using
        End If
        Return True
    End Function

    'This function is incomplete, you can help by EXPANDING IT.
    Function ImportPresets()
        If frmOptions.dlgOpenPresetsFromTxt.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'Insert code here
            'something delete presets from lstpresets
            'something streamreader
        End If
        Return True
    End Function

    Function Savenquit()
        'This saves everything so we are good.
        'This first bit checks to see if humor is enabled or not. The whole non-humor setting is ironic, as
        'the setting itself is ironic.
        If frmOptions.chkDisableHumor.CheckState = CheckState.Checked Then
            My.Settings.DisableHumor = True
        ElseIf frmOptions.chkDisableHumor.CheckState = CheckState.Unchecked Then
            My.Settings.DisableHumor = False
            frmMain.grpButton.Text = "Step 4: Press this comically oversized button to calculate result "
            frmMain.btnCalculate.Text = "CALCULATE..."
            AboutBox.CheckBox1.Enabled = True
            frmMain.lblLoadingIndicator.Text = "Humor enabled again. Hooray!"
        End If

        If frmOptions.chkRemoveDiceSizeWhenClearingForm.CheckState = CheckState.Checked Then
            My.Settings.RemoveDieSizeWhenClearingForm = True
        ElseIf frmOptions.chkRemoveDiceSizeWhenClearingForm.CheckState = CheckState.Unchecked Then
            My.Settings.RemoveDieSizeWhenClearingForm = False
        End If

        If frmOptions.chkVisualEffects.Checked Then
            My.Settings.VisEffectsChecked = True
        Else
            My.Settings.VisEffectsChecked = False
        End If
        If frmOptions.txtDiceDefaults.Text <> "" Then
            My.Settings.DiceDefaults = frmOptions.txtDiceDefaults.Text
        ElseIf frmOptions.txtDiceDefaults.Text = "" Then
            My.Settings.DiceDefaults = frmOptions.txtDiceDefaults.Text
        End If
        If frmOptions.txtRollsDefaults.Text <> "" Then
            My.Settings.RollsDefaults = frmOptions.txtRollsDefaults.Text
        ElseIf frmOptions.txtRollsDefaults.Text = "" Then
            My.Settings.DiceDefaults = frmOptions.txtRollsDefaults.Text
        End If
        For Each Item In My.Settings.Presets
            frmMain.cboDieSize.Items.Add(Item)
        Next
        My.Settings.Save()
        Return True
    End Function
    Function loadSlider()
        If My.Settings.fxSpeed = 0.05 Then
            frmOptions.sldFxSpeed.Value = 0
        ElseIf My.Settings.fxSpeed = 0.1 Then
            frmOptions.sldFxSpeed.Value = 1
        ElseIf My.Settings.fxSpeed = 0.2 Then
            frmOptions.sldFxSpeed.Value = 2
        ElseIf My.Settings.fxSpeed = 0.3 Then
            frmOptions.sldFxSpeed.Value = 3
        ElseIf My.Settings.fxSpeed = 0.4 Then
            frmOptions.sldFxSpeed.Value = 4
        ElseIf My.Settings.fxSpeed = 0.45 Then
            frmOptions.sldFxSpeed.Value = 5
        ElseIf My.Settings.fxSpeed = 0.55 Then
            frmOptions.sldFxSpeed.Value = 6
        ElseIf My.Settings.fxSpeed = 0.6 Then
            frmOptions.sldFxSpeed.Value = 7
        ElseIf My.Settings.fxSpeed = 0.7 Then
            frmOptions.sldFxSpeed.Value = 8
        ElseIf My.Settings.fxSpeed = 0.85 Then
            frmOptions.sldFxSpeed.Value = 9
        End If
        frmOptions.lblSpeedNo.Text = frmOptions.sldFxSpeed.Value.ToString()
        Return True
    End Function

    Function saveSlider()
        If frmOptions.sldFxSpeed.Value = 0 Then
            My.Settings.fxSpeed = 0.05
        ElseIf frmOptions.sldFxSpeed.Value = 1 Then
            My.Settings.fxSpeed = 0.1
        ElseIf frmOptions.sldFxSpeed.Value = 2 Then
            My.Settings.fxSpeed = 0.2
        ElseIf frmOptions.sldFxSpeed.Value = 3 Then
            My.Settings.fxSpeed = 0.3
        ElseIf frmOptions.sldFxSpeed.Value = 4 Then
            My.Settings.fxSpeed = 0.4
        ElseIf frmOptions.sldFxSpeed.Value = 5 Then
            My.Settings.fxSpeed = 0.45
        ElseIf frmOptions.sldFxSpeed.Value = 6 Then
            My.Settings.fxSpeed = 0.55
        ElseIf frmOptions.sldFxSpeed.Value = 7 Then
            My.Settings.fxSpeed = 0.6
        ElseIf frmOptions.sldFxSpeed.Value = 8 Then
            My.Settings.fxSpeed = 0.7
        ElseIf frmOptions.sldFxSpeed.Value = 9 Then
            My.Settings.fxSpeed = 0.85
        End If
        Return True
    End Function
End Module
