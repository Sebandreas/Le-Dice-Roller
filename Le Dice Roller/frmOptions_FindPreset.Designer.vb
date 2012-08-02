<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions_FindPreset
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
        Me.btnFindIt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radExactNumber = New System.Windows.Forms.RadioButton()
        Me.radFinishWith = New System.Windows.Forms.RadioButton()
        Me.radStartsWith = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNoNumeric1 = New System.Windows.Forms.Label()
        Me.cboSearchTerms = New System.Windows.Forms.ComboBox()
        Me.lblInstruction1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFindIt
        '
        Me.btnFindIt.Location = New System.Drawing.Point(402, 96)
        Me.btnFindIt.Name = "btnFindIt"
        Me.btnFindIt.Size = New System.Drawing.Size(79, 72)
        Me.btnFindIt.TabIndex = 0
        Me.btnFindIt.Text = "Find it!"
        Me.btnFindIt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radExactNumber)
        Me.GroupBox1.Controls.Add(Me.radFinishWith)
        Me.GroupBox1.Controls.Add(Me.radStartsWith)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Options:"
        '
        'radExactNumber
        '
        Me.radExactNumber.AutoSize = True
        Me.radExactNumber.Location = New System.Drawing.Point(9, 53)
        Me.radExactNumber.Name = "radExactNumber"
        Me.radExactNumber.Size = New System.Drawing.Size(343, 17)
        Me.radExactNumber.TabIndex = 5
        Me.radExactNumber.Text = "The number I specified is the number I'm looking for, but can't find..."
        Me.radExactNumber.UseVisualStyleBackColor = True
        '
        'radFinishWith
        '
        Me.radFinishWith.AutoSize = True
        Me.radFinishWith.Location = New System.Drawing.Point(9, 36)
        Me.radFinishWith.Name = "radFinishWith"
        Me.radFinishWith.Size = New System.Drawing.Size(197, 17)
        Me.radFinishWith.TabIndex = 4
        Me.radFinishWith.Text = "Finishes with the specified number(s)"
        Me.radFinishWith.UseVisualStyleBackColor = True
        '
        'radStartsWith
        '
        Me.radStartsWith.AutoSize = True
        Me.radStartsWith.Checked = True
        Me.radStartsWith.Location = New System.Drawing.Point(9, 19)
        Me.radStartsWith.Name = "radStartsWith"
        Me.radStartsWith.Size = New System.Drawing.Size(186, 17)
        Me.radStartsWith.TabIndex = 3
        Me.radStartsWith.TabStop = True
        Me.radStartsWith.Text = "Starts with the specified number(s)"
        Me.radStartsWith.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNoNumeric1)
        Me.GroupBox2.Controls.Add(Me.cboSearchTerms)
        Me.GroupBox2.Controls.Add(Me.lblInstruction1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 78)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Terms"
        '
        'lblNoNumeric1
        '
        Me.lblNoNumeric1.AutoSize = True
        Me.lblNoNumeric1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoNumeric1.ForeColor = System.Drawing.Color.Red
        Me.lblNoNumeric1.Location = New System.Drawing.Point(6, 53)
        Me.lblNoNumeric1.Name = "lblNoNumeric1"
        Me.lblNoNumeric1.Size = New System.Drawing.Size(355, 13)
        Me.lblNoNumeric1.TabIndex = 9
        Me.lblNoNumeric1.Text = "This text doesn't contain numbers. Please only enter numbers"
        Me.lblNoNumeric1.Visible = False
        '
        'cboSearchTerms
        '
        Me.cboSearchTerms.FormattingEnabled = True
        Me.cboSearchTerms.Location = New System.Drawing.Point(9, 29)
        Me.cboSearchTerms.Name = "cboSearchTerms"
        Me.cboSearchTerms.Size = New System.Drawing.Size(454, 21)
        Me.cboSearchTerms.TabIndex = 1
        '
        'lblInstruction1
        '
        Me.lblInstruction1.AutoSize = True
        Me.lblInstruction1.Location = New System.Drawing.Point(6, 13)
        Me.lblInstruction1.Name = "lblInstruction1"
        Me.lblInstruction1.Size = New System.Drawing.Size(245, 13)
        Me.lblInstruction1.TabIndex = 0
        Me.lblInstruction1.Text = "Type in, or select a number so that we can find it..."
        '
        'frmOptions_FindPreset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 174)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFindIt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions_FindPreset"
        Me.Text = "Find a preset..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFindIt As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radExactNumber As System.Windows.Forms.RadioButton
    Friend WithEvents radFinishWith As System.Windows.Forms.RadioButton
    Friend WithEvents radStartsWith As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSearchTerms As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstruction1 As System.Windows.Forms.Label
    Friend WithEvents lblNoNumeric1 As System.Windows.Forms.Label
End Class
