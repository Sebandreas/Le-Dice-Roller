Public Class frmOptions_PresetError2

    Private Sub frmTypePreset1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'This makes it so that the dialog cannot be closed with the 'x'/close button.
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class