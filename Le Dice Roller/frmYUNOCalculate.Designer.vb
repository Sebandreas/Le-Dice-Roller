<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYUNOCalculate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYUNOCalculate))
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgErrorOrTick = New System.Windows.Forms.PictureBox()
        Me.chkSaveDifferentArea = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(98, 23)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(386, 39)
        Me.lblText.TabIndex = 5
        Me.lblText.Text = "There has been an error saving the file. This is because you have not calculated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the result before saving the file. However, you can calculate the result now if" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you would like to."
        '
        'btnOkay
        '
        Me.btnOkay.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOkay.Location = New System.Drawing.Point(101, 169)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(148, 34)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "&Calculate Result"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel saving"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Le_Dice_Roller.My.Resources.Resources.question_bubble
        Me.PictureBox1.Location = New System.Drawing.Point(26, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'imgErrorOrTick
        '
        Me.imgErrorOrTick.Image = Global.Le_Dice_Roller.My.Resources.Resources.critical_exclamation
        Me.imgErrorOrTick.Location = New System.Drawing.Point(26, 23)
        Me.imgErrorOrTick.Name = "imgErrorOrTick"
        Me.imgErrorOrTick.Size = New System.Drawing.Size(66, 51)
        Me.imgErrorOrTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgErrorOrTick.TabIndex = 3
        Me.imgErrorOrTick.TabStop = False
        '
        'chkSaveDifferentArea
        '
        Me.chkSaveDifferentArea.AutoSize = True
        Me.chkSaveDifferentArea.Location = New System.Drawing.Point(102, 204)
        Me.chkSaveDifferentArea.Name = "chkSaveDifferentArea"
        Me.chkSaveDifferentArea.Size = New System.Drawing.Size(137, 17)
        Me.chkSaveDifferentArea.TabIndex = 9
        Me.chkSaveDifferentArea.Text = "&Change saving location"
        Me.chkSaveDifferentArea.UseVisualStyleBackColor = True
        '
        'frmYUNOCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 229)
        Me.Controls.Add(Me.chkSaveDifferentArea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.imgErrorOrTick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmYUNOCalculate"
        Me.ShowInTaskbar = False
        Me.Text = "Error saving file."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents imgErrorOrTick As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkSaveDifferentArea As System.Windows.Forms.CheckBox
End Class
