Public Class AboutBox

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Me.Close()
        'Close the dialog
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            picORLY.Visible = True
            CheckBox1.Text = "Okay, maybe I do like it."
        Else
            picORLY.Visible = False
            CheckBox1.Text = "I hate this application..."
        End If
    End Sub
End Class