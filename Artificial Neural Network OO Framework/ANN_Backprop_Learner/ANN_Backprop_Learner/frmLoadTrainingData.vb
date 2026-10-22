Public Class frmLoadTrainingData

    Private Sub btnBrowseTrainingDataFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseTrainingDataFile.Click
        OpenFileDialog1.ShowDialog()
        txtTrainingDataFilePath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnBrowseNetworkFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseNetworkFile.Click
        OpenFileDialog2.ShowDialog()
        txtANNFilePath.Text = OpenFileDialog2.FileName
    End Sub

    Private Sub rdoUseExistingNetwork_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUseExistingNetwork.CheckedChanged
        txtANNFilePath.Enabled = True
        btnBrowseNetworkFile.Enabled = True
        txtHiddenLayers.Enabled = False
        txtHiddenNeurons.Enabled = False
    End Sub

    Private Sub rdoCreateNewNetwork_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCreateNewNetwork.CheckedChanged
        txtANNFilePath.Enabled = False
        btnBrowseNetworkFile.Enabled = False
        txtHiddenLayers.Enabled = True
        txtHiddenNeurons.Enabled = True
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Try
            If rdoUseExistingNetwork.Checked = True Then
                Dim Network As New ANN_Network.Network(1, 1, 1, 1)
                Network = Network.importNetworkFromFile(txtANNFilePath.Text)
                Dim Network_Backprop As New ANN_Backprop.ANN_Backprop(Network, txtTrainingDataFilePath.Text)
                Form1.Network_Backprop = Network_Backprop
            ElseIf rdoCreateNewNetwork.Checked = True Then
                Dim Network_Backprop As New ANN_Backprop.ANN_Backprop(Convert.ToInt32(txtHiddenNeurons.Text), Convert.ToInt32(txtHiddenLayers.Text), txtTrainingDataFilePath.Text, 10)
                Form1.Network_Backprop = Network_Backprop
            Else
                Throw New Exception("This Cannot Ever Ever Happen!")
            End If

            Form1.btnBeginLearning.Enabled = True
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class