Public Class frmCreateNetwork

    Private Sub btnCreateNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNetwork.Click
        If IsNumeric(txtNumInput.Text) And IsNumeric(txtNumHidden.Text) And IsNumeric(txtNumLayers.Text) And IsNumeric(txtNumOutput.Text) Then
            If Convert.ToInt32(txtNumInput.Text) > 20 Or Convert.ToInt32(txtNumHidden.Text) > 20 Or Convert.ToInt32(txtNumLayers.Text) > 10 Or Convert.ToInt32(txtNumOutput.Text) > 20 Then
                frmMessage.txtMessageToUser.Text = "Warning! The number of neurons in your network may impede the quality of the network's visualization."
                If Not frmMessage.Visible = True Then
                    frmMessage.ShowDialog()
                End If
            End If
            Form1.ANN = New ANN_Arch.Network(Convert.ToInt32(txtNumInput.Text), Convert.ToInt32(txtNumHidden.Text), Convert.ToInt32(txtNumLayers.Text), Convert.ToInt32(txtNumOutput.Text))
            Me.Close()
        Else
            frmMessage.txtMessageToUser.Text = "Only numbers are allowed; please change input values to create a network"
            If Not frmMessage.Visible = True Then
                frmMessage.ShowDialog()
            End If
        End If
    End Sub

    Private Sub frmCreateNetwork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNumInput.Text = Form1.ANN.numInputNeurons
        txtNumHidden.Text = Form1.ANN.numHiddenNeurons
        txtNumLayers.Text = Form1.ANN.numHiddenLayers
        txtNumOutput.Text = Form1.ANN.numOutputNeurons
    End Sub
End Class