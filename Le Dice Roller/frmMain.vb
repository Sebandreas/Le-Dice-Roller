Public Class frmMain

#Region "Member Variables"
    'References SubclassedSystemMenu.vb so there is no 'mobjSubclassedSystemMenu is undefined' error.
    Private WithEvents mobjSubclassedSystemMenu As SubclassedSystemMenu
#End Region

    Private Sub AboutLeDiceRollerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Shows the about dialog, which is obvious.
        AboutBox.ShowDialog()
    End Sub

    Public Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Calculate()
    End Sub

    Public Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitProgram()
    End Sub

    Private Sub AboutLeDiceRollerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutLeDiceRollerToolStripMenuItem.Click
        'Explains itself.
        AboutBox.Show()
    End Sub

    Private Sub SaveToTextFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToTextFileToolStripMenuItem.Click, btnExport.Click
        SaveToTextFile()
    End Sub

    Private Sub ResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultsToolStripMenuItem.Click
        ClearResults("1")
    End Sub

    Private Sub AllTheFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllOfTheFormToolStripMenuItem.Click
        ClearResults("2")
    End Sub


    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        'Displays the help dialog.
        frmHelpDialog.ShowDialog()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        'Adds the 'about le dice roller' menu option for the titlebar/taskbar right-click menu.
        mobjSubclassedSystemMenu = New SubclassedSystemMenu(Me.Handle.ToInt32, "&About Le Dice Roller")
    End Sub

    Private Sub mobjSubclassedSystemMenu_LaunchDialog() Handles mobjSubclassedSystemMenu.LaunchDialog
        'This is the event executed by the above Sub.
        AboutBox.ShowDialog()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If My.Settings.DisableHumor = True Then
            grpButton.Text = "Step 4: Press 'calculate' to finish"
            btnCalculate.Text = "Calculate..."
            AboutBox.CheckBox1.Enabled = False
            lblLoadingIndicator.Text = "Humor disabled. Le Dice Roller is now bland and boring."
            '151, 24

        End If
        LoadPresets()
        If My.Settings.RollsDefaults <> "" Then
            txtRolls.Text = My.Settings.RollsDefaults
        End If
        If My.Settings.DiceDefaults <> "" Then
            txtDice.Text = My.Settings.DiceDefaults
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ExitProgram2()
        'I fixed the error I had with this function. I copied it and replace 'frmMain.Close()' with 'End'.
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Throw New UnauthorizedAccessException
    End Sub

    'This is triggered everytime a new character is entered or removed. I think this might be bypassable on really slow computers,
    'but I've installed systems to take care of that.
    Private Sub txtDice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDice.TextChanged
        'This Sub controls the function where the textboxes turn red when you type a non numeric number.
        'If there is no text, it stays normal. If someone enters a non-numeric string, it turns red, and a label appears, saying that it is not numeric.
        'The same principle applies to the code below for the other textboxes.
        'A last minute addition if you ask me.
        If txtDice.Text = "" Then
            'Makes it normal when empty
            lblNoNumeric1.Hide()
            txtDice.BackColor = Color.White
            txtDice.ForeColor = Color.Black
        End If
        If Not txtDice.Text = "" Then
            'Determines if text is numeric (contains number(s)) or not. If it is, nothing happens or it changes to normal.
            'If it is not numeric, then the box turns red and a label pops up saying that it isn't numeric.
            If IsNumeric(txtDice.Text) = False Then
                lblNoNumeric1.Show()
                txtDice.BackColor = Color.Red
                txtDice.ForeColor = Color.White
            ElseIf IsNumeric(txtDice.Text) = True Then
                'This just changes it back...
                lblNoNumeric1.Hide()
                txtDice.BackColor = Color.White
                txtDice.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub txtRolls_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRolls.TextChanged
        'Refer to above example. No use documenting the same thing twice.
        If txtRolls.Text = "" Then
            lblNoNumeric2.Hide()
            txtRolls.BackColor = Color.White
            txtRolls.ForeColor = Color.Black
        End If
        If Not txtRolls.Text = "" Then
            If IsNumeric(txtRolls.Text) = False Then
                lblNoNumeric2.Show()
                txtRolls.BackColor = Color.Red
                txtRolls.ForeColor = Color.White
            ElseIf IsNumeric(txtRolls.Text) = True Then
                lblNoNumeric2.Hide()
                txtRolls.BackColor = Color.White
                txtRolls.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub cboDieSize_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDieSize.TextChanged
        'Ditto as above two, but with a combobox.
        If cboDieSize.Text = "" Then
            lblNoNumeric3.Hide()
            cboDieSize.BackColor = Color.White
            cboDieSize.ForeColor = Color.Black
        End If
        If Not cboDieSize.Text = "" Then
            If IsNumeric(cboDieSize.Text) = False Then
                lblNoNumeric3.Show()
                cboDieSize.BackColor = Color.Red
                cboDieSize.ForeColor = Color.White
            ElseIf IsNumeric(cboDieSize.Text) = True Then
                lblNoNumeric3.Hide()
                cboDieSize.BackColor = Color.White
                cboDieSize.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub mnuMainStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuMainStrip.ItemClicked

    End Sub

    Private Sub OptionsToolStripMenItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionsToolStripMenItem.Click
        frmOptions.Show()
    End Sub

    Private Sub AddPresetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPresetToolStripMenuItem.Click
        ' Fail WHALE
    End Sub

    Private Sub btnHide_Click(sender As System.Object, e As System.EventArgs) Handles btnHide.Click
        Me.Width = 375
    End Sub
End Class
