<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.grpPresets = New System.Windows.Forms.GroupBox()
        Me.grpDefaults = New System.Windows.Forms.GroupBox()
        Me.lblNoNumeric1 = New System.Windows.Forms.Label()
        Me.lblNoNumeric2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRollsDefaults = New System.Windows.Forms.TextBox()
        Me.txtDiceDefaults = New System.Windows.Forms.TextBox()
        Me.grpFxSpeed = New System.Windows.Forms.GroupBox()
        Me.lblSpeedNo = New System.Windows.Forms.Label()
        Me.lblSelectionIndicator = New System.Windows.Forms.Label()
        Me.sldFxSpeed = New System.Windows.Forms.TrackBar()
        Me.grpTranslate = New System.Windows.Forms.GroupBox()
        Me.lblMakeTranslation = New System.Windows.Forms.LinkLabel()
        Me.lblDisclaimer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.grpMiscOptions = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkDisableHumor = New System.Windows.Forms.CheckBox()
        Me.chkRemoveDiceSizeWhenClearingForm = New System.Windows.Forms.CheckBox()
        Me.chkVisualEffects = New System.Windows.Forms.CheckBox()
        Me.btnGo2Bottom = New System.Windows.Forms.Button()
        Me.lblSelectedPresetIndex = New System.Windows.Forms.Label()
        Me.lblIndexNumIndication = New System.Windows.Forms.Label()
        Me.btnMoveIndexDown = New System.Windows.Forms.Button()
        Me.btnMoveIndexUp = New System.Windows.Forms.Button()
        Me.btnGo2Top = New System.Windows.Forms.Button()
        Me.lblSelectionAlreadyPreset = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.btnModifyPreset = New System.Windows.Forms.Button()
        Me.lblNoNumeric3 = New System.Windows.Forms.Label()
        Me.txtDefinePreset = New System.Windows.Forms.TextBox()
        Me.lstPresets = New System.Windows.Forms.ListBox()
        Me.btnRemovePreset = New System.Windows.Forms.Button()
        Me.btnAddPreset = New System.Windows.Forms.Button()
        Me.dlgSavePresetsToTxt = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpenPresetsFromTxt = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAndExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitWithoutSavingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyPresetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindPresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutLeDiceRollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpPresets.SuspendLayout()
        Me.grpDefaults.SuspendLayout()
        Me.grpFxSpeed.SuspendLayout()
        CType(Me.sldFxSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTranslate.SuspendLayout()
        Me.grpMiscOptions.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPresets
        '
        Me.grpPresets.Controls.Add(Me.grpDefaults)
        Me.grpPresets.Controls.Add(Me.grpFxSpeed)
        Me.grpPresets.Controls.Add(Me.grpTranslate)
        Me.grpPresets.Controls.Add(Me.grpMiscOptions)
        Me.grpPresets.Controls.Add(Me.btnGo2Bottom)
        Me.grpPresets.Controls.Add(Me.lblSelectedPresetIndex)
        Me.grpPresets.Controls.Add(Me.lblIndexNumIndication)
        Me.grpPresets.Controls.Add(Me.btnMoveIndexDown)
        Me.grpPresets.Controls.Add(Me.btnMoveIndexUp)
        Me.grpPresets.Controls.Add(Me.btnGo2Top)
        Me.grpPresets.Controls.Add(Me.lblSelectionAlreadyPreset)
        Me.grpPresets.Controls.Add(Me.btnSave)
        Me.grpPresets.Controls.Add(Me.btnCancelEdit)
        Me.grpPresets.Controls.Add(Me.btnModifyPreset)
        Me.grpPresets.Controls.Add(Me.lblNoNumeric3)
        Me.grpPresets.Controls.Add(Me.txtDefinePreset)
        Me.grpPresets.Controls.Add(Me.lstPresets)
        Me.grpPresets.Controls.Add(Me.btnRemovePreset)
        Me.grpPresets.Controls.Add(Me.btnAddPreset)
        Me.grpPresets.Location = New System.Drawing.Point(4, 27)
        Me.grpPresets.Name = "grpPresets"
        Me.grpPresets.Size = New System.Drawing.Size(885, 497)
        Me.grpPresets.TabIndex = 0
        Me.grpPresets.TabStop = False
        Me.grpPresets.Text = "Dice Size Presets"
        '
        'grpDefaults
        '
        Me.grpDefaults.Controls.Add(Me.lblNoNumeric1)
        Me.grpDefaults.Controls.Add(Me.lblNoNumeric2)
        Me.grpDefaults.Controls.Add(Me.Label2)
        Me.grpDefaults.Controls.Add(Me.Label1)
        Me.grpDefaults.Controls.Add(Me.txtRollsDefaults)
        Me.grpDefaults.Controls.Add(Me.txtDiceDefaults)
        Me.grpDefaults.Location = New System.Drawing.Point(557, 333)
        Me.grpDefaults.Name = "grpDefaults"
        Me.grpDefaults.Size = New System.Drawing.Size(326, 158)
        Me.grpDefaults.TabIndex = 1
        Me.grpDefaults.TabStop = False
        Me.grpDefaults.Text = "Default Options"
        '
        'lblNoNumeric1
        '
        Me.lblNoNumeric1.AutoSize = True
        Me.lblNoNumeric1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric1.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric1.Location = New System.Drawing.Point(8, 64)
        Me.lblNoNumeric1.Name = "lblNoNumeric1"
        Me.lblNoNumeric1.Size = New System.Drawing.Size(295, 13)
        Me.lblNoNumeric1.TabIndex = 10
        Me.lblNoNumeric1.Text = "This text is not numeric, please only enter numbers"
        Me.lblNoNumeric1.Visible = False
        '
        'lblNoNumeric2
        '
        Me.lblNoNumeric2.AutoSize = True
        Me.lblNoNumeric2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric2.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric2.Location = New System.Drawing.Point(8, 130)
        Me.lblNoNumeric2.Name = "lblNoNumeric2"
        Me.lblNoNumeric2.Size = New System.Drawing.Size(295, 13)
        Me.lblNoNumeric2.TabIndex = 11
        Me.lblNoNumeric2.Text = "This text is not numeric, please only enter numbers"
        Me.lblNoNumeric2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type a number for the default number of 'rolls'."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Type a number for the default number of dice."
        '
        'txtRollsDefaults
        '
        Me.txtRollsDefaults.Location = New System.Drawing.Point(9, 107)
        Me.txtRollsDefaults.Name = "txtRollsDefaults"
        Me.txtRollsDefaults.Size = New System.Drawing.Size(307, 20)
        Me.txtRollsDefaults.TabIndex = 1
        '
        'txtDiceDefaults
        '
        Me.txtDiceDefaults.Location = New System.Drawing.Point(9, 41)
        Me.txtDiceDefaults.Name = "txtDiceDefaults"
        Me.txtDiceDefaults.Size = New System.Drawing.Size(307, 20)
        Me.txtDiceDefaults.TabIndex = 0
        '
        'grpFxSpeed
        '
        Me.grpFxSpeed.Controls.Add(Me.lblSpeedNo)
        Me.grpFxSpeed.Controls.Add(Me.lblSelectionIndicator)
        Me.grpFxSpeed.Controls.Add(Me.sldFxSpeed)
        Me.grpFxSpeed.Location = New System.Drawing.Point(557, 271)
        Me.grpFxSpeed.Name = "grpFxSpeed"
        Me.grpFxSpeed.Size = New System.Drawing.Size(322, 63)
        Me.grpFxSpeed.TabIndex = 13
        Me.grpFxSpeed.TabStop = False
        Me.grpFxSpeed.Text = "Visual Effects Speed"
        '
        'lblSpeedNo
        '
        Me.lblSpeedNo.AutoSize = True
        Me.lblSpeedNo.Location = New System.Drawing.Point(101, 46)
        Me.lblSpeedNo.Name = "lblSpeedNo"
        Me.lblSpeedNo.Size = New System.Drawing.Size(25, 13)
        Me.lblSpeedNo.TabIndex = 14
        Me.lblSpeedNo.Text = "Null"
        '
        'lblSelectionIndicator
        '
        Me.lblSelectionIndicator.AutoSize = True
        Me.lblSelectionIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionIndicator.Location = New System.Drawing.Point(6, 45)
        Me.lblSelectionIndicator.Name = "lblSelectionIndicator"
        Me.lblSelectionIndicator.Size = New System.Drawing.Size(100, 13)
        Me.lblSelectionIndicator.TabIndex = 13
        Me.lblSelectionIndicator.Text = "Speed of Effect:"
        '
        'sldFxSpeed
        '
        Me.sldFxSpeed.Location = New System.Drawing.Point(4, 13)
        Me.sldFxSpeed.Maximum = 9
        Me.sldFxSpeed.Name = "sldFxSpeed"
        Me.sldFxSpeed.Size = New System.Drawing.Size(300, 45)
        Me.sldFxSpeed.TabIndex = 12
        '
        'grpTranslate
        '
        Me.grpTranslate.Controls.Add(Me.lblMakeTranslation)
        Me.grpTranslate.Controls.Add(Me.lblDisclaimer)
        Me.grpTranslate.Controls.Add(Me.Label3)
        Me.grpTranslate.Controls.Add(Me.ComboBox1)
        Me.grpTranslate.Location = New System.Drawing.Point(557, 19)
        Me.grpTranslate.Name = "grpTranslate"
        Me.grpTranslate.Size = New System.Drawing.Size(322, 151)
        Me.grpTranslate.TabIndex = 15
        Me.grpTranslate.TabStop = False
        Me.grpTranslate.Text = "Translation/Language"
        '
        'lblMakeTranslation
        '
        Me.lblMakeTranslation.AutoSize = True
        Me.lblMakeTranslation.Location = New System.Drawing.Point(8, 131)
        Me.lblMakeTranslation.Name = "lblMakeTranslation"
        Me.lblMakeTranslation.Size = New System.Drawing.Size(144, 13)
        Me.lblMakeTranslation.TabIndex = 3
        Me.lblMakeTranslation.TabStop = True
        Me.lblMakeTranslation.Text = "Create your own translation..."
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.AutoSize = True
        Me.lblDisclaimer.Location = New System.Drawing.Point(6, 64)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.Size = New System.Drawing.Size(199, 65)
        Me.lblDisclaimer.TabIndex = 2
        Me.lblDisclaimer.Text = "Disclaimer: Some translations may not be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "accurate, contain stereotypes, and/or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "are just in here for the lulz. I am not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "liable for the content of translations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "included within Le Dice Roller."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Selected Language"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(310, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'grpMiscOptions
        '
        Me.grpMiscOptions.Controls.Add(Me.CheckBox1)
        Me.grpMiscOptions.Controls.Add(Me.chkDisableHumor)
        Me.grpMiscOptions.Controls.Add(Me.chkRemoveDiceSizeWhenClearingForm)
        Me.grpMiscOptions.Controls.Add(Me.chkVisualEffects)
        Me.grpMiscOptions.Location = New System.Drawing.Point(557, 176)
        Me.grpMiscOptions.Name = "grpMiscOptions"
        Me.grpMiscOptions.Size = New System.Drawing.Size(322, 96)
        Me.grpMiscOptions.TabIndex = 4
        Me.grpMiscOptions.TabStop = False
        Me.grpMiscOptions.Text = "Miscellaneous Options"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(183, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Use real listbox index (Advanced)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkDisableHumor
        '
        Me.chkDisableHumor.AutoSize = True
        Me.chkDisableHumor.Location = New System.Drawing.Point(9, 53)
        Me.chkDisableHumor.Name = "chkDisableHumor"
        Me.chkDisableHumor.Size = New System.Drawing.Size(161, 17)
        Me.chkDisableHumor.TabIndex = 6
        Me.chkDisableHumor.Text = "Disable humor (experimental)"
        Me.chkDisableHumor.UseVisualStyleBackColor = True
        '
        'chkRemoveDiceSizeWhenClearingForm
        '
        Me.chkRemoveDiceSizeWhenClearingForm.AutoSize = True
        Me.chkRemoveDiceSizeWhenClearingForm.Location = New System.Drawing.Point(9, 35)
        Me.chkRemoveDiceSizeWhenClearingForm.Name = "chkRemoveDiceSizeWhenClearingForm"
        Me.chkRemoveDiceSizeWhenClearingForm.Size = New System.Drawing.Size(249, 17)
        Me.chkRemoveDiceSizeWhenClearingForm.TabIndex = 5
        Me.chkRemoveDiceSizeWhenClearingForm.Text = "Remove number in 'die size' when clearing form"
        Me.chkRemoveDiceSizeWhenClearingForm.UseVisualStyleBackColor = True
        '
        'chkVisualEffects
        '
        Me.chkVisualEffects.AutoSize = True
        Me.chkVisualEffects.Location = New System.Drawing.Point(9, 19)
        Me.chkVisualEffects.Name = "chkVisualEffects"
        Me.chkVisualEffects.Size = New System.Drawing.Size(126, 17)
        Me.chkVisualEffects.TabIndex = 0
        Me.chkVisualEffects.Text = "Enable Visual Effects"
        Me.chkVisualEffects.UseVisualStyleBackColor = True
        '
        'btnGo2Bottom
        '
        Me.btnGo2Bottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo2Bottom.Image = Global.Le_Dice_Roller.My.Resources.Resources.bottom
        Me.btnGo2Bottom.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGo2Bottom.Location = New System.Drawing.Point(6, 151)
        Me.btnGo2Bottom.Name = "btnGo2Bottom"
        Me.btnGo2Bottom.Size = New System.Drawing.Size(46, 38)
        Me.btnGo2Bottom.TabIndex = 22
        Me.btnGo2Bottom.UseVisualStyleBackColor = True
        '
        'lblSelectedPresetIndex
        '
        Me.lblSelectedPresetIndex.AutoSize = True
        Me.lblSelectedPresetIndex.Location = New System.Drawing.Point(5, 232)
        Me.lblSelectedPresetIndex.Name = "lblSelectedPresetIndex"
        Me.lblSelectedPresetIndex.Size = New System.Drawing.Size(25, 13)
        Me.lblSelectedPresetIndex.TabIndex = 21
        Me.lblSelectedPresetIndex.Text = "Null"
        '
        'lblIndexNumIndication
        '
        Me.lblIndexNumIndication.AutoSize = True
        Me.lblIndexNumIndication.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexNumIndication.Location = New System.Drawing.Point(3, 218)
        Me.lblIndexNumIndication.Name = "lblIndexNumIndication"
        Me.lblIndexNumIndication.Size = New System.Drawing.Size(54, 13)
        Me.lblIndexNumIndication.TabIndex = 20
        Me.lblIndexNumIndication.Text = "Index #:"
        '
        'btnMoveIndexDown
        '
        Me.btnMoveIndexDown.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMoveIndexDown.Image = Global.Le_Dice_Roller.My.Resources.Resources.downarrow
        Me.btnMoveIndexDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMoveIndexDown.Location = New System.Drawing.Point(6, 107)
        Me.btnMoveIndexDown.Name = "btnMoveIndexDown"
        Me.btnMoveIndexDown.Size = New System.Drawing.Size(46, 38)
        Me.btnMoveIndexDown.TabIndex = 19
        Me.btnMoveIndexDown.UseVisualStyleBackColor = True
        '
        'btnMoveIndexUp
        '
        Me.btnMoveIndexUp.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMoveIndexUp.Image = Global.Le_Dice_Roller.My.Resources.Resources.uparrow
        Me.btnMoveIndexUp.Location = New System.Drawing.Point(6, 63)
        Me.btnMoveIndexUp.Name = "btnMoveIndexUp"
        Me.btnMoveIndexUp.Size = New System.Drawing.Size(46, 38)
        Me.btnMoveIndexUp.TabIndex = 18
        Me.btnMoveIndexUp.UseVisualStyleBackColor = True
        '
        'btnGo2Top
        '
        Me.btnGo2Top.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo2Top.Image = Global.Le_Dice_Roller.My.Resources.Resources.top
        Me.btnGo2Top.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGo2Top.Location = New System.Drawing.Point(6, 19)
        Me.btnGo2Top.Name = "btnGo2Top"
        Me.btnGo2Top.Size = New System.Drawing.Size(46, 38)
        Me.btnGo2Top.TabIndex = 17
        Me.btnGo2Top.UseVisualStyleBackColor = True
        '
        'lblSelectionAlreadyPreset
        '
        Me.lblSelectionAlreadyPreset.AutoSize = True
        Me.lblSelectionAlreadyPreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionAlreadyPreset.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblSelectionAlreadyPreset.Location = New System.Drawing.Point(68, 401)
        Me.lblSelectionAlreadyPreset.Name = "lblSelectionAlreadyPreset"
        Me.lblSelectionAlreadyPreset.Size = New System.Drawing.Size(281, 26)
        Me.lblSelectionAlreadyPreset.TabIndex = 16
        Me.lblSelectionAlreadyPreset.Text = "You cannot use this number as a preset, as it is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "already a preset."
        Me.lblSelectionAlreadyPreset.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Le_Dice_Roller.My.Resources.Resources.floppy_save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(385, 371)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 35)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Apply Modification..."
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Image = Global.Le_Dice_Roller.My.Resources.Resources.edit
        Me.btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelEdit.Location = New System.Drawing.Point(385, 411)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(152, 35)
        Me.btnCancelEdit.TabIndex = 14
        Me.btnCancelEdit.Text = "Cancel Modification"
        Me.btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        Me.btnCancelEdit.Visible = False
        '
        'btnModifyPreset
        '
        Me.btnModifyPreset.Image = Global.Le_Dice_Roller.My.Resources.Resources.modify
        Me.btnModifyPreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModifyPreset.Location = New System.Drawing.Point(385, 411)
        Me.btnModifyPreset.Name = "btnModifyPreset"
        Me.btnModifyPreset.Size = New System.Drawing.Size(151, 36)
        Me.btnModifyPreset.TabIndex = 13
        Me.btnModifyPreset.Text = "&Modify Selected Preset"
        Me.btnModifyPreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyPreset.UseVisualStyleBackColor = True
        '
        'lblNoNumeric3
        '
        Me.lblNoNumeric3.AutoSize = True
        Me.lblNoNumeric3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric3.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric3.Location = New System.Drawing.Point(65, 401)
        Me.lblNoNumeric3.Name = "lblNoNumeric3"
        Me.lblNoNumeric3.Size = New System.Drawing.Size(295, 13)
        Me.lblNoNumeric3.TabIndex = 12
        Me.lblNoNumeric3.Text = "This text is not numeric, please only enter numbers"
        Me.lblNoNumeric3.Visible = False
        '
        'txtDefinePreset
        '
        Me.txtDefinePreset.Location = New System.Drawing.Point(71, 374)
        Me.txtDefinePreset.Name = "txtDefinePreset"
        Me.txtDefinePreset.Size = New System.Drawing.Size(289, 20)
        Me.txtDefinePreset.TabIndex = 4
        '
        'lstPresets
        '
        Me.lstPresets.FormattingEnabled = True
        Me.lstPresets.Location = New System.Drawing.Point(58, 19)
        Me.lstPresets.Name = "lstPresets"
        Me.lstPresets.Size = New System.Drawing.Size(480, 342)
        Me.lstPresets.TabIndex = 3
        '
        'btnRemovePreset
        '
        Me.btnRemovePreset.Image = Global.Le_Dice_Roller.My.Resources.Resources.remove_dash
        Me.btnRemovePreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemovePreset.Location = New System.Drawing.Point(385, 451)
        Me.btnRemovePreset.Name = "btnRemovePreset"
        Me.btnRemovePreset.Size = New System.Drawing.Size(153, 36)
        Me.btnRemovePreset.TabIndex = 2
        Me.btnRemovePreset.Text = "R&emove Preset..."
        Me.btnRemovePreset.UseVisualStyleBackColor = True
        '
        'btnAddPreset
        '
        Me.btnAddPreset.Image = Global.Le_Dice_Roller.My.Resources.Resources.plus
        Me.btnAddPreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPreset.Location = New System.Drawing.Point(385, 370)
        Me.btnAddPreset.Name = "btnAddPreset"
        Me.btnAddPreset.Size = New System.Drawing.Size(152, 37)
        Me.btnAddPreset.TabIndex = 0
        Me.btnAddPreset.Text = "&Add Preset..."
        Me.btnAddPreset.UseVisualStyleBackColor = True
        '
        'dlgSavePresetsToTxt
        '
        Me.dlgSavePresetsToTxt.DefaultExt = "txt"
        Me.dlgSavePresetsToTxt.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        Me.dlgSavePresetsToTxt.ShowHelp = True
        Me.dlgSavePresetsToTxt.SupportMultiDottedExtensions = True
        '
        'dlgOpenPresetsFromTxt
        '
        Me.dlgOpenPresetsFromTxt.FileName = "OpenFileDialog1"
        Me.dlgOpenPresetsFromTxt.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PresetsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(901, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFromFileToolStripMenuItem, Me.ExportToFileToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExportOptionsToolStripMenuItem, Me.ImportOptionsToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportFromFileToolStripMenuItem
        '
        Me.ImportFromFileToolStripMenuItem.Enabled = False
        Me.ImportFromFileToolStripMenuItem.Name = "ImportFromFileToolStripMenuItem"
        Me.ImportFromFileToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ImportFromFileToolStripMenuItem.Text = "&Import from file..."
        '
        'ExportToFileToolStripMenuItem
        '
        Me.ExportToFileToolStripMenuItem.Name = "ExportToFileToolStripMenuItem"
        Me.ExportToFileToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExportToFileToolStripMenuItem.Text = "E&xport to file"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 6)
        '
        'ExportOptionsToolStripMenuItem
        '
        Me.ExportOptionsToolStripMenuItem.Enabled = False
        Me.ExportOptionsToolStripMenuItem.Name = "ExportOptionsToolStripMenuItem"
        Me.ExportOptionsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExportOptionsToolStripMenuItem.Text = "Exp&ort options"
        '
        'ImportOptionsToolStripMenuItem
        '
        Me.ImportOptionsToolStripMenuItem.Enabled = False
        Me.ImportOptionsToolStripMenuItem.Name = "ImportOptionsToolStripMenuItem"
        Me.ImportOptionsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ImportOptionsToolStripMenuItem.Text = "Import Optio&ns"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(164, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndExitToolStripMenuItem, Me.ExitWithoutSavingToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'SaveAndExitToolStripMenuItem
        '
        Me.SaveAndExitToolStripMenuItem.Name = "SaveAndExitToolStripMenuItem"
        Me.SaveAndExitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SaveAndExitToolStripMenuItem.Text = "&Save and Exit"
        '
        'ExitWithoutSavingToolStripMenuItem
        '
        Me.ExitWithoutSavingToolStripMenuItem.Name = "ExitWithoutSavingToolStripMenuItem"
        Me.ExitWithoutSavingToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitWithoutSavingToolStripMenuItem.Text = "Ex&it without saving"
        '
        'PresetsToolStripMenuItem
        '
        Me.PresetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPresetToolStripMenuItem, Me.ModifyPresetsToolStripMenuItem, Me.RemovePresetToolStripMenuItem, Me.ToolStripMenuItem4, Me.FindPresetToolStripMenuItem})
        Me.PresetsToolStripMenuItem.Name = "PresetsToolStripMenuItem"
        Me.PresetsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PresetsToolStripMenuItem.Text = "Presets"
        '
        'AddPresetToolStripMenuItem
        '
        Me.AddPresetToolStripMenuItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.plus
        Me.AddPresetToolStripMenuItem.Name = "AddPresetToolStripMenuItem"
        Me.AddPresetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddPresetToolStripMenuItem.Text = "&Add Preset"
        '
        'ModifyPresetsToolStripMenuItem
        '
        Me.ModifyPresetsToolStripMenuItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.modify
        Me.ModifyPresetsToolStripMenuItem.Name = "ModifyPresetsToolStripMenuItem"
        Me.ModifyPresetsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModifyPresetsToolStripMenuItem.Text = "&Modify Preset"
        '
        'RemovePresetToolStripMenuItem
        '
        Me.RemovePresetToolStripMenuItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.remove_dash
        Me.RemovePresetToolStripMenuItem.Name = "RemovePresetToolStripMenuItem"
        Me.RemovePresetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemovePresetToolStripMenuItem.Text = "R&emove Preset"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 6)
        '
        'FindPresetToolStripMenuItem
        '
        Me.FindPresetToolStripMenuItem.Image = Global.Le_Dice_Roller.My.Resources.Resources.find
        Me.FindPresetToolStripMenuItem.Name = "FindPresetToolStripMenuItem"
        Me.FindPresetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FindPresetToolStripMenuItem.Text = "Find Preset..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.ToolStripMenuItem3, Me.AboutLeDiceRollerToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(178, 6)
        '
        'AboutLeDiceRollerToolStripMenuItem
        '
        Me.AboutLeDiceRollerToolStripMenuItem.Name = "AboutLeDiceRollerToolStripMenuItem"
        Me.AboutLeDiceRollerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AboutLeDiceRollerToolStripMenuItem.Text = "About Le Dice Roller"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(273, 6)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(114, 38)
        Me.btnApply.TabIndex = 14
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Le_Dice_Roller.My.Resources.Resources.edit
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(141, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 38)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Image = Global.Le_Dice_Roller.My.Resources.Resources.ok
        Me.btnOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOkay.Location = New System.Drawing.Point(9, 6)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(126, 38)
        Me.btnOkay.TabIndex = 2
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel1.Controls.Add(Me.btnOkay)
        Me.Panel1.Controls.Add(Me.btnApply)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(0, 529)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 49)
        Me.Panel1.TabIndex = 15
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 578)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpPresets)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowInTaskbar = False
        Me.Text = "Le Dice Roller - Options"
        Me.grpPresets.ResumeLayout(False)
        Me.grpPresets.PerformLayout()
        Me.grpDefaults.ResumeLayout(False)
        Me.grpDefaults.PerformLayout()
        Me.grpFxSpeed.ResumeLayout(False)
        Me.grpFxSpeed.PerformLayout()
        CType(Me.sldFxSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTranslate.ResumeLayout(False)
        Me.grpTranslate.PerformLayout()
        Me.grpMiscOptions.ResumeLayout(False)
        Me.grpMiscOptions.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPresets As System.Windows.Forms.GroupBox
    Friend WithEvents lstPresets As System.Windows.Forms.ListBox
    Friend WithEvents btnRemovePreset As System.Windows.Forms.Button
    Friend WithEvents btnAddPreset As System.Windows.Forms.Button
    Friend WithEvents grpDefaults As System.Windows.Forms.GroupBox
    Friend WithEvents txtRollsDefaults As System.Windows.Forms.TextBox
    Friend WithEvents txtDiceDefaults As System.Windows.Forms.TextBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtDefinePreset As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNoNumeric1 As System.Windows.Forms.Label
    Friend WithEvents lblNoNumeric2 As System.Windows.Forms.Label
    Friend WithEvents lblNoNumeric3 As System.Windows.Forms.Label
    Friend WithEvents grpMiscOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkVisualEffects As System.Windows.Forms.CheckBox
    Friend WithEvents chkRemoveDiceSizeWhenClearingForm As System.Windows.Forms.CheckBox
    Friend WithEvents btnModifyPreset As System.Windows.Forms.Button
    Friend WithEvents btnCancelEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSelectionAlreadyPreset As System.Windows.Forms.Label
    Friend WithEvents dlgSavePresetsToTxt As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgOpenPresetsFromTxt As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFromFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPresetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyPresetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovePresetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutLeDiceRollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAndExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitWithoutSavingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGo2Top As System.Windows.Forms.Button
    Friend WithEvents btnMoveIndexDown As System.Windows.Forms.Button
    Friend WithEvents btnMoveIndexUp As System.Windows.Forms.Button
    Friend WithEvents chkDisableHumor As System.Windows.Forms.CheckBox
    Friend WithEvents sldFxSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents grpFxSpeed As System.Windows.Forms.GroupBox
    Friend WithEvents lblSpeedNo As System.Windows.Forms.Label
    Friend WithEvents lblSelectionIndicator As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblSelectedPresetIndex As System.Windows.Forms.Label
    Friend WithEvents lblIndexNumIndication As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents grpTranslate As System.Windows.Forms.GroupBox
    Friend WithEvents lblMakeTranslation As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDisclaimer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnGo2Bottom As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindPresetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
