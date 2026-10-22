Public Class Form1

    Protected Friend Network_Backprop As ANN_Backprop.ANN_Backprop

    Private Sub btnLoadTrainingData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadTrainingData.Click
        frmLoadTrainingData.ShowDialog()
    End Sub

    Private Sub rdoLearnToEpoch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLearnToEpoch.CheckedChanged
        txtLearnToEpoch.Enabled = True
        txtLearnToError.Enabled = False
    End Sub

    Private Sub rdoLearnToError_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLearnToError.CheckedChanged
        txtLearnToEpoch.Enabled = False
        txtLearnToError.Enabled = True
    End Sub

    Private Sub btnBeginLearning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeginLearning.Click
        BeginLearning()
    End Sub

    Public Sub BeginLearning()
        If Not Network_Backprop Is Nothing Then
            If rdoLearnToEpoch.Checked = True Then
                btnBeginLearning.Enabled = False
                btnExportNetwork.Enabled = False
                btnLoadTrainingData.Enabled = False
                btnRunNetwork.Enabled = False
                txtMainLog.Enabled = False

                Network_Backprop.rho = Convert.ToDouble(txtRho.Text)
                For i As Integer = 0 To Convert.ToInt32(txtLearnToEpoch.Text)
                    Network_Backprop.TrainEpoch()

                    If i Mod Convert.ToInt32(txtRowDisplayCount.Text) = 0 Then
                        'Set Data Label Values
                        lblEpoch.Text = "Epoch: " & i
                        lblError.Text = "Error: " & Network_Backprop.networkError
                        lblMaxWeight.Text = "Max Weight: " & Network_Backprop.ANN.getMaxWeightValue
                        lblMinWeight.Text = "Min Weight: " & Network_Backprop.ANN.getMinWeightValue
                        lblZeroWeights.Text = "Zero Weights: " & Network_Backprop.ANN.getCountZeroWeights(0.001)
                        lblWeightsSum.Text = "Weights Sum: " & Network_Backprop.ANN.getWeightTotal

                        txtMainLog.Text = "Executed Epoch: " & i & ", " & lblError.Text & vbCrLf & txtMainLog.Text

                        txtMainLog.Refresh()
                        lblEpoch.Refresh()
                        lblError.Refresh()
                        lblMaxWeight.Refresh()
                        lblMinWeight.Refresh()
                        lblZeroWeights.Refresh()
                        lblWeightsSum.Refresh()
                        GroupBox1.Refresh()
                    End If

                Next

                btnBeginLearning.Enabled = True
                btnExportNetwork.Enabled = True
                btnLoadTrainingData.Enabled = True
                btnRunNetwork.Enabled = True
                txtMainLog.Enabled = True

            ElseIf rdoLearnToError.Checked = True Then
                Dim i As Integer = 0
                Do
                    Network_Backprop.TrainEpoch()

                    'Set Data Label Values
                    lblEpoch.Text = "Epoch: " & i
                    lblError.Text = "Error: " & Network_Backprop.networkError
                    lblMaxWeight.Text = "Max Weight: " & Network_Backprop.ANN.getMaxWeightValue
                    lblMinWeight.Text = "Min Weight: " & Network_Backprop.ANN.getMinWeightValue
                    lblZeroWeights.Text = "Zero Weights: " & Network_Backprop.ANN.getCountZeroWeights(0.001)
                    lblWeightsSum.Text = "Weights Sum: " & Network_Backprop.ANN.getWeightTotal

                    txtMainLog.Text = "Executed Epoch: " & i & ", " & lblError.Text & vbCrLf & txtMainLog.Text

                    txtMainLog.Refresh()
                    lblEpoch.Refresh()
                    lblError.Refresh()
                    lblMaxWeight.Refresh()
                    lblMinWeight.Refresh()
                    lblZeroWeights.Refresh()
                    lblWeightsSum.Refresh()
                    GroupBox1.Refresh()


                    i += 1

                Loop Until Network_Backprop.networkError <= Math.Abs(Convert.ToDouble(txtLearnToError.Text)) And Network_Backprop.networkError >= -Math.Abs(Convert.ToDouble(txtLearnToError.Text))
            Else
                Throw New Exception("This Should Never Happen!")
            End If
        End If
    End Sub

    Private Sub btnExportNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportNetwork.Click
        SaveFileDialog1.ShowDialog()
        Network_Backprop.ANN.exportNetworkToFile(SaveFileDialog1.FileName)
    End Sub

    Private Sub btnRunNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunNetwork.Click
        Dim frmRunNetwork As New ANN_Run_Network.Form1
        frmRunNetwork.setNetwork(Network_Backprop.ANN)
        frmRunNetwork.ShowDialog()
    End Sub


    Private Sub txtRowDisplayCount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRowDisplayCount.LostFocus
        If Not IsNumeric(txtRowDisplayCount.Text) Then
            MsgBox("Value Entered is Not a Number. Setting default value")
            txtRowDisplayCount.Text = "10"
        End If
    End Sub

    Private Sub btnKillProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoadInputDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadInputDataToolStripMenuItem.Click
        frmLoadTrainingData.ShowDialog()
    End Sub

    Private Sub BeginLearningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginLearningToolStripMenuItem.Click
        BeginLearning()
    End Sub

    Private Sub RunNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunNetworkToolStripMenuItem.Click
        Dim frmRunNetwork As New ANN_Run_Network.Form1
        frmRunNetwork.setNetwork(Network_Backprop.ANN)
        frmRunNetwork.ShowDialog()
    End Sub

    Private Sub ExportNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportNetworkToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Network_Backprop.ANN.exportNetworkToFile(SaveFileDialog1.FileName)
    End Sub

    Private Sub txtRho_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRho.LostFocus
        If Not IsNumeric(txtRho.Text) Then
            MsgBox("Value Entered is Not a Number. Setting default value")
            txtRho.Text = "10"
        End If
    End Sub

End Class
