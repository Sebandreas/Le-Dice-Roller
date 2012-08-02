<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions_PresetError2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions_PresetError2))
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.imgErrorOrTick = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(147, 43)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(255, 26)
        Me.lblText.TabIndex = 8
        Me.lblText.Text = "Please specify a valid number to replace/modify your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selected preset." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOkay
        '
        Me.btnOkay.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOkay.Location = New System.Drawing.Point(216, 143)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(80, 39)
        Me.btnOkay.TabIndex = 7
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'imgErrorOrTick
        '
        Me.imgErrorOrTick.Image = Global.Le_Dice_Roller.My.Resources.Resources.usual_exclamation
        Me.imgErrorOrTick.Location = New System.Drawing.Point(27, 22)
        Me.imgErrorOrTick.Name = "imgErrorOrTick"
        Me.imgErrorOrTick.Size = New System.Drawing.Size(63, 61)
        Me.imgErrorOrTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgErrorOrTick.TabIndex = 6
        Me.imgErrorOrTick.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "You cannot use this number to replace the preset :("
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 104)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmOptions_PresetError2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 194)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.imgErrorOrTick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions_PresetError2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Please specify a preset..."
        CType(Me.imgErrorOrTick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents imgErrorOrTick As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
