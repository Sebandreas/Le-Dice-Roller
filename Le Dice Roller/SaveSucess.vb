Public Class SaveSucess

    Private Sub SaveSucess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFileName.Text = frmMain.dlgSaveAsText.FileName.ToString()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'Documented Elsewhere
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        lblFileName.Text = ""
        Me.Close()
    End Sub
End Class