<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblLoadingIndicator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMainStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllOfTheFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddPresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutLeDiceRollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDice = New System.Windows.Forms.GroupBox()
        Me.lblNoNumeric1 = New System.Windows.Forms.Label()
        Me.txtDice = New System.Windows.Forms.TextBox()
        Me.grpRolls = New System.Windows.Forms.GroupBox()
        Me.lblNoNumeric2 = New System.Windows.Forms.Label()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblXaxis = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.grpButton = New System.Windows.Forms.GroupBox()
        Me.lblCalculatedRollsNo = New System.Windows.Forms.Label()
        Me.lblRollsCalcNotice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.dlgSaveAsText = New System.Windows.Forms.SaveFileDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNoNumeric3 = New System.Windows.Forms.Label()
        Me.cboDieSize = New System.Windows.Forms.ComboBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.mnuMainStrip.SuspendLayout()
        Me.grpDice.SuspendLayout()
        Me.grpRolls.SuspendLayout()
        Me.grpResult.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpButton.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLoadingIndicator})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 391)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(369, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblLoadingIndicator
        '
        Me.lblLoadingIndicator.Name = "lblLoadingIndicator"
        Me.lblLoadingIndicator.Size = New System.Drawing.Size(59, 17)
        Me.lblLoadingIndicator.Text = "Loading..."
        '
        'mnuMainStrip
        '
        Me.mnuMainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMainStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainStrip.Name = "mnuMainStrip"
        Me.mnuMainStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuMainStrip.Size = New System.Drawing.Size(369, 24)
        Me.mnuMainStrip.TabIndex = 2
        Me.mnuMainStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToTextFileToolStripMenuItem, Me.ClearResultsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToTextFileToolStripMenuItem
        '
        Me.SaveToTextFileToolStripMenuItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.floppy_save
        Me.SaveToTextFileToolStripMenuItem.Name = "SaveToTextFileToolStripMenuItem"
        Me.SaveToTextFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-S"
        Me.SaveToTextFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToTextFileToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveToTextFileToolStripMenuItem.Text = "&Save to text file"
        '
        'ClearResultsToolStripMenuItem
        '
        Me.ClearResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultsToolStripMenuItem, Me.AllOfTheFormToolStripMenuItem})
        Me.ClearResultsToolStripMenuItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.clear
        Me.ClearResultsToolStripMenuItem.Name = "ClearResultsToolStripMenuItem"
        Me.ClearResultsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ClearResultsToolStripMenuItem.Text = "Clear..."
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'AllOfTheFormToolStripMenuItem
        '
        Me.AllOfTheFormToolStripMenuItem.Name = "AllOfTheFormToolStripMenuItem"
        Me.AllOfTheFormToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AllOfTheFormToolStripMenuItem.Text = "All of the form"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenItem, Me.ToolStripMenuItem3, Me.AddPresetToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'OptionsToolStripMenItem
        '
        Me.OptionsToolStripMenItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.Preferences
        Me.OptionsToolStripMenItem.Name = "OptionsToolStripMenItem"
        Me.OptionsToolStripMenItem.Size = New System.Drawing.Size(140, 22)
        Me.OptionsToolStripMenItem.Text = "&Options"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(137, 6)
        '
        'AddPresetToolStripMenuItem
        '
        Me.AddPresetToolStripMenuItem.Name = "AddPresetToolStripMenuItem"
        Me.AddPresetToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AddPresetToolStripMenuItem.Text = "&Add Preset..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.ToolStripMenuItem2, Me.AboutLeDiceRollerToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Image = Global.Le_Dice_Roller.My.Resources.Resources.Help
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'AboutLeDiceRollerToolStripMenuItem
        '
        Me.AboutLeDiceRollerToolStripMenuItem.Name = "AboutLeDiceRollerToolStripMenuItem"
        Me.AboutLeDiceRollerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AboutLeDiceRollerToolStripMenuItem.Text = "&About Le Dice Roller"
        '
        'grpDice
        '
        Me.grpDice.Controls.Add(Me.lblNoNumeric1)
        Me.grpDice.Controls.Add(Me.txtDice)
        Me.grpDice.Location = New System.Drawing.Point(10, 107)
        Me.grpDice.Name = "grpDice"
        Me.grpDice.Size = New System.Drawing.Size(349, 67)
        Me.grpDice.TabIndex = 3
        Me.grpDice.TabStop = False
        Me.grpDice.Text = "Step 2: Specify amount of dice"
        '
        'lblNoNumeric1
        '
        Me.lblNoNumeric1.AutoSize = True
        Me.lblNoNumeric1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric1.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric1.Location = New System.Drawing.Point(13, 41)
        Me.lblNoNumeric1.Name = "lblNoNumeric1"
        Me.lblNoNumeric1.Size = New System.Drawing.Size(295, 13)
        Me.lblNoNumeric1.TabIndex = 8
        Me.lblNoNumeric1.Text = "This text is not numeric, please only enter numbers"
        Me.lblNoNumeric1.Visible = False
        '
        'txtDice
        '
        Me.txtDice.Location = New System.Drawing.Point(12, 19)
        Me.txtDice.Name = "txtDice"
        Me.txtDice.Size = New System.Drawing.Size(331, 20)
        Me.txtDice.TabIndex = 7
        '
        'grpRolls
        '
        Me.grpRolls.Controls.Add(Me.lblNoNumeric2)
        Me.grpRolls.Controls.Add(Me.txtRolls)
        Me.grpRolls.Location = New System.Drawing.Point(10, 180)
        Me.grpRolls.Name = "grpRolls"
        Me.grpRolls.Size = New System.Drawing.Size(349, 62)
        Me.grpRolls.TabIndex = 4
        Me.grpRolls.TabStop = False
        Me.grpRolls.Text = "Step 3: Specify number of rolls"
        '
        'lblNoNumeric2
        '
        Me.lblNoNumeric2.AutoSize = True
        Me.lblNoNumeric2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric2.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric2.Location = New System.Drawing.Point(13, 41)
        Me.lblNoNumeric2.Name = "lblNoNumeric2"
        Me.lblNoNumeric2.Size = New System.Drawing.Size(295, 13)
        Me.lblNoNumeric2.TabIndex = 9
        Me.lblNoNumeric2.Text = "This text is not numeric, please only enter numbers"
        Me.lblNoNumeric2.Visible = False
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(12, 19)
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(331, 20)
        Me.txtRolls.TabIndex = 5
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.PictureBox1)
        Me.grpResult.Controls.Add(Me.lblXaxis)
        Me.grpResult.Controls.Add(Me.lstResults)
        Me.grpResult.Location = New System.Drawing.Point(378, 10)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(349, 330)
        Me.grpResult.TabIndex = 4
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Result:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Le_Dice_Roller.My.Resources.Resources.lblNoOfRolls
        Me.PictureBox1.Location = New System.Drawing.Point(7, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblXaxis
        '
        Me.lblXaxis.AutoSize = True
        Me.lblXaxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXaxis.Location = New System.Drawing.Point(24, 23)
        Me.lblXaxis.Name = "lblXaxis"
        Me.lblXaxis.Size = New System.Drawing.Size(122, 13)
        Me.lblXaxis.TabIndex = 1
        Me.lblXaxis.Text = "Number Of Dice ›››"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(27, 39)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(311, 264)
        Me.lstResults.TabIndex = 0
        '
        'grpButton
        '
        Me.grpButton.Controls.Add(Me.lblCalculatedRollsNo)
        Me.grpButton.Controls.Add(Me.lblRollsCalcNotice)
        Me.grpButton.Controls.Add(Me.btnCalculate)
        Me.grpButton.Location = New System.Drawing.Point(10, 248)
        Me.grpButton.Name = "grpButton"
        Me.grpButton.Size = New System.Drawing.Size(349, 116)
        Me.grpButton.TabIndex = 5
        Me.grpButton.TabStop = False
        Me.grpButton.Text = "Step 4: Press this comically oversized button to calculate result"
        '
        'lblCalculatedRollsNo
        '
        Me.lblCalculatedRollsNo.AutoSize = True
        Me.lblCalculatedRollsNo.Location = New System.Drawing.Point(165, 94)
        Me.lblCalculatedRollsNo.Name = "lblCalculatedRollsNo"
        Me.lblCalculatedRollsNo.Size = New System.Drawing.Size(13, 13)
        Me.lblCalculatedRollsNo.TabIndex = 2
        Me.lblCalculatedRollsNo.Text = "0"
        Me.lblCalculatedRollsNo.Visible = False
        '
        'lblRollsCalcNotice
        '
        Me.lblRollsCalcNotice.AutoSize = True
        Me.lblRollsCalcNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollsCalcNotice.Location = New System.Drawing.Point(11, 94)
        Me.lblRollsCalcNotice.Name = "lblRollsCalcNotice"
        Me.lblRollsCalcNotice.Size = New System.Drawing.Size(159, 13)
        Me.lblRollsCalcNotice.TabIndex = 1
        Me.lblRollsCalcNotice.Text = "Number of rolls calculated:"
        Me.lblRollsCalcNotice.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(9, 28)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(330, 58)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'dlgSaveAsText
        '
        Me.dlgSaveAsText.Filter = "Plaintext Files (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.dlgSaveAsText.Title = "Save Result As Text"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNoNumeric3)
        Me.GroupBox1.Controls.Add(Me.cboDieSize)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 68)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1: Choose, or type size of dice"
        '
        'lblNoNumeric3
        '
        Me.lblNoNumeric3.AutoSize = True
        Me.lblNoNumeric3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric3.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric3.Location = New System.Drawing.Point(9, 43)
        Me.lblNoNumeric3.Name = "lblNoNumeric3"
        Me.lblNoNumeric3.Size = New System.Drawing.Size(221, 13)
        Me.lblNoNumeric3.TabIndex = 9
        Me.lblNoNumeric3.Text = "Your chosen die size cannot be used."
        Me.lblNoNumeric3.Visible = False
        '
        'cboDieSize
        '
        Me.cboDieSize.FormattingEnabled = True
        Me.cboDieSize.Location = New System.Drawing.Point(9, 20)
        Me.cboDieSize.Name = "cboDieSize"
        Me.cboDieSize.Size = New System.Drawing.Size(329, 21)
        Me.cboDieSize.TabIndex = 0
        Me.cboDieSize.Text = "6"
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(385, 346)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(167, 35)
        Me.btnHide.TabIndex = 7
        Me.btnHide.Text = "<<< Hide Results..."
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Image = Global.Le_Dice_Roller.My.Resources.Resources.floppy_save
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(558, 346)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(169, 35)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Export results to text file..."
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 413)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpButton)
        Me.Controls.Add(Me.grpRolls)
        Me.Controls.Add(Me.grpDice)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuMainStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MainMenuStrip = Me.mnuMainStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Le Dice Roller"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuMainStrip.ResumeLayout(False)
        Me.mnuMainStrip.PerformLayout()
        Me.grpDice.ResumeLayout(False)
        Me.grpDice.PerformLayout()
        Me.grpRolls.ResumeLayout(False)
        Me.grpRolls.PerformLayout()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpButton.ResumeLayout(False)
        Me.grpButton.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuMainStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutLeDiceRollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpDice As System.Windows.Forms.GroupBox
    Friend WithEvents txtDice As System.Windows.Forms.TextBox
    Friend WithEvents grpRolls As System.Windows.Forms.GroupBox
    Friend WithEvents txtRolls As System.Windows.Forms.TextBox
    Friend WithEvents grpResult As System.Windows.Forms.GroupBox
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents grpButton As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents SaveToTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dlgSaveAsText As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ClearResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllOfTheFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblXaxis As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents lblNoNumeric1 As System.Windows.Forms.Label
    Friend WithEvents lblNoNumeric2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNoNumeric3 As System.Windows.Forms.Label
    Friend WithEvents lblLoadingIndicator As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cboDieSize As System.Windows.Forms.ComboBox
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddPresetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblCalculatedRollsNo As System.Windows.Forms.Label
    Friend WithEvents lblRollsCalcNotice As System.Windows.Forms.Label

End Class
