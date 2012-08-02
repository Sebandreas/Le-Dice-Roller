<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnhandledError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnhandledError))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grpErrorInfo = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.txtErrorText = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnSendData = New System.Windows.Forms.Button()
        Me.grpErrorInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(77, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(458, 39)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'grpErrorInfo
        '
        Me.grpErrorInfo.Controls.Add(Me.btnSendData)
        Me.grpErrorInfo.Controls.Add(Me.btnCopy)
        Me.grpErrorInfo.Controls.Add(Me.txtErrorText)
        Me.grpErrorInfo.Location = New System.Drawing.Point(30, 54)
        Me.grpErrorInfo.Name = "grpErrorInfo"
        Me.grpErrorInfo.Size = New System.Drawing.Size(505, 272)
        Me.grpErrorInfo.TabIndex = 1
        Me.grpErrorInfo.TabStop = False
        Me.grpErrorInfo.Text = "Error Information and Options"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close and Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(298, 332)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(129, 29)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Restart Le Dice Roller"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'txtErrorText
        '
        Me.txtErrorText.Location = New System.Drawing.Point(6, 19)
        Me.txtErrorText.Multiline = True
        Me.txtErrorText.Name = "txtErrorText"
        Me.txtErrorText.Size = New System.Drawing.Size(493, 210)
        Me.txtErrorText.TabIndex = 0
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(6, 235)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(123, 28)
        Me.btnCopy.TabIndex = 1
        Me.btnCopy.Text = "Copy Error Data"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnSendData
        '
        Me.btnSendData.Location = New System.Drawing.Point(132, 235)
        Me.btnSendData.Name = "btnSendData"
        Me.btnSendData.Size = New System.Drawing.Size(116, 28)
        Me.btnSendData.TabIndex = 2
        Me.btnSendData.Text = "Send Error Data"
        Me.btnSendData.UseVisualStyleBackColor = True
        '
        'frmUnhandledError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 370)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpErrorInfo)
        Me.Controls.Add(Me.lblDescription)
        Me.Name = "frmUnhandledError"
        Me.Text = "Unhandled Exception in Le Dice Roller"
        Me.grpErrorInfo.ResumeLayout(False)
        Me.grpErrorInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents grpErrorInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSendData As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents txtErrorText As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
End Class
