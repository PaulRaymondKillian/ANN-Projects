Public Class frmMessage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtErrorMessage.Text = ""
        txtMessageToUser.Text = ""
        Me.Close()
    End Sub
End Class