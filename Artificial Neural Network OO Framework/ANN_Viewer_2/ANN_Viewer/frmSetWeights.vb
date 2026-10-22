Imports System.IO

Public Class frmSetWeights

    Dim ANN As ANN_Network.Network

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtWeightsFilePath.Text = OpenFileDialog1.FileName

        Dim sr As New StreamReader(txtWeightsFilePath.Text)
        'txtWeightsContents.Text = sr.ReadToEnd

        txtcountWeightsInputted.Text = "0"
        txtWeightsContents.Text = ""
        sr.ReadLine()
        While Not sr.EndOfStream
            If txtWeightsContents.Text = "" Then
                txtWeightsContents.Text = sr.ReadLine
            Else
                txtWeightsContents.Text = txtWeightsContents.Text & ", " & sr.ReadLine
            End If
            txtcountWeightsInputted.Text = Convert.ToInt32(txtcountWeightsInputted.Text) + 1
        End While

        If txtcountWeightsInputted.Text = txtcountWeightsNeeded.Text Then
            btnSetWeightsToNetwork.Enabled = True
        Else
            btnSetWeightsToNetwork.Enabled = False
            frmMessage.txtMessageToUser.Text = "Invalid number of weights in weights file needed for network. Amount inputted was: " & txtcountWeightsInputted.Text & ", amount needed was: " & txtcountWeightsNeeded.Text & ". Please select a different weights file with the correct number of weights."
            frmMessage.ShowDialog()
        End If


    End Sub

    Private Sub frmSetWeights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcountWeightsNeeded.Text = ANN.countWeights
        btnSetWeightsToNetwork.Enabled = False
    End Sub

    Private Sub btnSetWeightsToNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetWeightsToNetwork.Click

        Try '
            ANN.importWeightsFromFile(txtWeightsFilePath.Text)
            Form1.TextOutputWindowHistory_Add("Set Weights")
            Me.Close()
        Catch ex As Exception
            frmMessage.txtErrorMessage.Text = ex.Message
            frmMessage.txtMessageToUser.Text = "Error attempting to set weights to network from weights file selected. Please selecte different file."
            frmMessage.Show()
        Finally

        End Try

    End Sub

    Public Sub setANN(ByVal tempANN As ANN_Network.Network)
        ANN = tempANN
    End Sub

End Class