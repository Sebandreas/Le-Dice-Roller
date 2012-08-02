<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceNoNumbers
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.imgErrorOrTick = New System.Windows.Forms.PictureBox()
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(102, 24)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(284, 39)
        Me.lblText.TabIndex = 5
        Me.lblText.Text = "The text you put for the number of dice is not numeric;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "it either contains chara" & _
            "cters or no numbers. Please change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the text so it is just numbers, and press 'C" & _
            "alculate' again."
        '
        'btnOkay
        '
        Me.btnOkay.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOkay.Location = New System.Drawing.Point(177, 77)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(80, 34)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'imgErrorOrTick
        '
        Me.imgErrorOrTick.Image = Global.Le_Dice_Roller.My.Resources.Resources.usual_exclamation
        Me.imgErrorOrTick.Location = New System.Drawing.Point(19, 23)
        Me.imgErrorOrTick.Name = "imgErrorOrTick"
        Me.imgErrorOrTick.Size = New System.Drawing.Size(65, 64)
        Me.imgErrorOrTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgErrorOrTick.TabIndex = 3
        Me.imgErrorOrTick.TabStop = False
        '
        'frmDiceNoNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 121)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.imgErrorOrTick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDiceNoNumbers"
        Me.ShowInTaskbar = False
        Me.Text = "Number of rolls not numeric"
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents imgErrorOrTick As System.Windows.Forms.PictureBox
End Class
