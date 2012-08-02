Public Class frmYUNOCalculate

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Me.Hide()
        Calculate()
        If chkSaveDifferentArea.CheckState = CheckState.Checked Then
            If frmMain.dlgSaveAsText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
                SaveFile()
                Exit Sub
            End If
        Else
            SaveFile()
        End If
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'This is the nifty Win32 API Call that disables the 'x'/close button at the top of the dialog. This is used because
        '(a) We could implement it, just like that *snaps fingers*.
        '(b) We designed the dialog so that clicking the 'x'/close button is not needed.
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmYUNOCalculate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class