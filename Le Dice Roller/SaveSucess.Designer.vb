<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveSucess
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
        Me.lblFileName = New System.Windows.Forms.Label()
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(100, 35)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(299, 13)
        Me.lblText.TabIndex = 8
        Me.lblText.Text = "The file has been sucessfully saved. The location of the file is:"
        '
        'btnOkay
        '
        Me.btnOkay.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOkay.Location = New System.Drawing.Point(200, 80)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(80, 39)
        Me.btnOkay.TabIndex = 7
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'imgErrorOrTick
        '
        Me.imgErrorOrTick.Image = Global.Le_Dice_Roller.My.Resources.Resources.tick
        Me.imgErrorOrTick.Location = New System.Drawing.Point(22, 22)
        Me.imgErrorOrTick.Name = "imgErrorOrTick"
        Me.imgErrorOrTick.Size = New System.Drawing.Size(63, 61)
        Me.imgErrorOrTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgErrorOrTick.TabIndex = 6
        Me.imgErrorOrTick.TabStop = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(103, 53)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(61, 13)
        Me.lblFileName.TabIndex = 9
        Me.lblFileName.Text = "lblFileName"
        '
        'SaveSucess
        '
        Me.AcceptButton = Me.btnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 131)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.imgErrorOrTick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveSucess"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sucessfully saved text document"
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents imgErrorOrTick As System.Windows.Forms.PictureBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
End Class
