Public Class frmModifyGUI

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntApplyChanges.Click

        If cbHighColor.SelectedItem = "White" Then
            Form1.highColor = Color.White
        ElseIf cbHighColor.SelectedItem = "Black" Then
            Form1.highColor = Color.Black
        ElseIf cbHighColor.SelectedItem = "Red" Then
            Form1.highColor = Color.Red
        ElseIf cbHighColor.SelectedItem = "Blue" Then
            Form1.highColor = Color.Blue
        ElseIf cbHighColor.SelectedItem = "Yellow" Then
            Form1.highColor = Color.Yellow
        ElseIf cbHighColor.SelectedItem = "Green" Then
            Form1.highColor = Color.Lime
        End If

        If cbmidHighColor.SelectedItem = "White" Then
            Form1.midHighColor = Color.White
        ElseIf cbmidHighColor.SelectedItem = "Black" Then
            Form1.midHighColor = Color.Black
        ElseIf cbmidHighColor.SelectedItem = "Red" Then
            Form1.midHighColor = Color.Red
        ElseIf cbmidHighColor.SelectedItem = "Blue" Then
            Form1.midHighColor = Color.Blue
        ElseIf cbmidHighColor.SelectedItem = "Yellow" Then
            Form1.midHighColor = Color.Yellow
        ElseIf cbmidHighColor.SelectedItem = "Green" Then
            Form1.midHighColor = Color.Lime
        End If

        If cbZeroColor.SelectedItem = "White" Then
            Form1.zeroColor = Color.White
        ElseIf cbZeroColor.SelectedItem = "Black" Then
            Form1.zeroColor = Color.Black
        ElseIf cbZeroColor.SelectedItem = "Red" Then
            Form1.zeroColor = Color.Red
        ElseIf cbZeroColor.SelectedItem = "Blue" Then
            Form1.zeroColor = Color.Blue
        ElseIf cbZeroColor.SelectedItem = "Yellow" Then
            Form1.zeroColor = Color.Yellow
        ElseIf cbZeroColor.SelectedItem = "Green" Then
            Form1.zeroColor = Color.Lime
        End If

        If cbmidLowColor.SelectedItem = "White" Then
            Form1.midLowColor = Color.White
        ElseIf cbmidLowColor.SelectedItem = "Black" Then
            Form1.midLowColor = Color.Black
        ElseIf cbmidLowColor.SelectedItem = "Red" Then
            Form1.midLowColor = Color.Red
        ElseIf cbmidLowColor.SelectedItem = "Blue" Then
            Form1.midLowColor = Color.Blue
        ElseIf cbmidLowColor.SelectedItem = "Yellow" Then
            Form1.midLowColor = Color.Yellow
        ElseIf cbmidLowColor.SelectedItem = "Green" Then
            Form1.midLowColor = Color.Lime
        End If

        If cbLowColor.SelectedItem = "White" Then
            Form1.lowColor = Color.White
        ElseIf cbLowColor.SelectedItem = "Black" Then
            Form1.lowColor = Color.Black
        ElseIf cbLowColor.SelectedItem = "Red" Then
            Form1.lowColor = Color.Red
        ElseIf cbLowColor.SelectedItem = "Blue" Then
            Form1.lowColor = Color.Blue
        ElseIf cbLowColor.SelectedItem = "Yellow" Then
            Form1.lowColor = Color.Yellow
        ElseIf cbLowColor.SelectedItem = "Green" Then
            Form1.lowColor = Color.Lime
        End If

        If Convert.ToDouble(txtHighValue.Text) > Convert.ToDouble(txtmidHighValue.Text) And _
            Convert.ToDouble(txtmidHighValue.Text) > 0 And _
            0 > Convert.ToDouble(txtmidLowValue.Text) And _
            Convert.ToDouble(txtmidLowValue.Text) > Convert.ToDouble(txtLowValue.Text) Then

            Form1.highColorValue = Convert.ToDouble(txtHighValue.Text)
            Form1.midHighColorValue = Convert.ToDouble(txtmidHighValue.Text)
            Form1.midLowColorValue = Convert.ToDouble(txtmidLowValue.Text)
            Form1.lowColorValue = Convert.ToDouble(txtLowValue.Text)
        Else
            frmMessage.txtMessageToUser.Text = "Weight link GUI values are not valid." & vbCrLf & _
                                            "Valid Format: High Value > Mid-High Value > 0 > Mid-LowValue > Low Value" & vbCrLf & _
                                            "Weight Link GUI values have been reset to the original value."
            If Not frmMessage.Visible = True Then
                frmMessage.ShowDialog()
            End If
        End If

        If cbShowHoveredNeuronInfoBlock.Checked = True Then
            Form1.showHoverNeuronInfoBlock = True
        Else
            Form1.showHoverNeuronInfoBlock = False
        End If

        If cbShowCalculatedNeuronInfoBlock.Checked = True Then
            Form1.showCalculatedNeuronInfoBlock = True
        Else
            Form1.showCalculatedNeuronInfoBlock = False
        End If

        If cbShowActionHistoryBlock.Checked = True Then
            Form1.showActionHistoryBlock = True
        Else
            Form1.showActionHistoryBlock = False
        End If

        If cbShowNetworkInfoBlock.Checked = True Then
            Form1.showNetworkInfoBlock = True
        Else
            Form1.showNetworkInfoBlock = False
        End If

        If cbShowWeightLinkLegend.Checked = True Then
            Form1.showWeightLinkLegend = True
        Else
            Form1.showWeightLinkLegend = False
        End If

        Form1.ANNInfoWidth = (tbarDataWindowPercent.Value / 100) * Form1.Width

        If cbNeuronColor.SelectedItem = "White" Then
            Form1.neuronColor = Color.White
        ElseIf cbNeuronColor.SelectedItem = "Black" Then
            Form1.neuronColor = Color.Black
        ElseIf cbNeuronColor.SelectedItem = "Red" Then
            Form1.neuronColor = Color.Red
        ElseIf cbNeuronColor.SelectedItem = "Blue" Then
            Form1.neuronColor = Color.Blue
        ElseIf cbNeuronColor.SelectedItem = "Yellow" Then
            Form1.neuronColor = Color.Yellow
        ElseIf cbNeuronColor.SelectedItem = "Green" Then
            Form1.neuronColor = Color.Lime
        End If

        If cbBiasColor.SelectedItem = "White" Then
            Form1.biasNeuronColor = Color.White
        ElseIf cbBiasColor.SelectedItem = "Black" Then
            Form1.biasNeuronColor = Color.Black
        ElseIf cbBiasColor.SelectedItem = "Red" Then
            Form1.biasNeuronColor = Color.Red
        ElseIf cbBiasColor.SelectedItem = "Blue" Then
            Form1.biasNeuronColor = Color.Blue
        ElseIf cbBiasColor.SelectedItem = "Yellow" Then
            Form1.biasNeuronColor = Color.Yellow
        ElseIf cbBiasColor.SelectedItem = "Green" Then
            Form1.biasNeuronColor = Color.Lime
        End If

        If cbSelectedColor.SelectedItem = "White" Then
            Form1.selectedColor = Color.White
        ElseIf cbSelectedColor.SelectedItem = "Black" Then
            Form1.selectedColor = Color.Black
        ElseIf cbSelectedColor.SelectedItem = "Red" Then
            Form1.selectedColor = Color.Red
        ElseIf cbSelectedColor.SelectedItem = "Blue" Then
            Form1.selectedColor = Color.Blue
        ElseIf cbSelectedColor.SelectedItem = "Yellow" Then
            Form1.selectedColor = Color.Yellow
        ElseIf cbSelectedColor.SelectedItem = "Green" Then
            Form1.selectedColor = Color.Lime
        End If

        If cbCalculatedColor.SelectedItem = "White" Then
            Form1.calculatedColor = Color.White
        ElseIf cbCalculatedColor.SelectedItem = "Black" Then
            Form1.calculatedColor = Color.Black
        ElseIf cbCalculatedColor.SelectedItem = "Red" Then
            Form1.calculatedColor = Color.Red
        ElseIf cbCalculatedColor.SelectedItem = "Blue" Then
            Form1.calculatedColor = Color.Blue
        ElseIf cbCalculatedColor.SelectedItem = "Yellow" Then
            Form1.calculatedColor = Color.Yellow
        ElseIf cbCalculatedColor.SelectedItem = "Green" Then
            Form1.calculatedColor = Color.Lime
        End If

        If cbBackgroundColor.SelectedItem = "White" Then
            Form1.backgroundColor = Color.White
        ElseIf cbBackgroundColor.SelectedItem = "Black" Then
            Form1.backgroundColor = Color.Black
        ElseIf cbBackgroundColor.SelectedItem = "Red" Then
            Form1.backgroundColor = Color.Red
        ElseIf cbBackgroundColor.SelectedItem = "Blue" Then
            Form1.backgroundColor = Color.Blue
        ElseIf cbBackgroundColor.SelectedItem = "Yellow" Then
            Form1.backgroundColor = Color.Yellow
        ElseIf cbBackgroundColor.SelectedItem = "Green" Then
            Form1.backgroundColor = Color.Lime
        End If

        If cbForegroundColor.SelectedItem = "White" Then
            Form1.foregroundColor = Color.White
        ElseIf cbForegroundColor.SelectedItem = "Black" Then
            Form1.foregroundColor = Color.Black
        ElseIf cbForegroundColor.SelectedItem = "Red" Then
            Form1.foregroundColor = Color.Red
        ElseIf cbForegroundColor.SelectedItem = "Blue" Then
            Form1.foregroundColor = Color.Blue
        ElseIf cbForegroundColor.SelectedItem = "Yellow" Then
            Form1.foregroundColor = Color.Yellow
        ElseIf cbForegroundColor.SelectedItem = "Green" Then
            Form1.foregroundColor = Color.Lime
        End If

        Form1.SaveGUIValues()

        Me.Close()

    End Sub

    Private Sub frmModifyGUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopulateGUIFormValues()

    End Sub

    Public Sub PopulateGUIFormValues()
        If Form1.highColor = Color.White Then
            cbHighColor.SelectedItem = "White"
        ElseIf Form1.highColor = Color.Black Then
            cbHighColor.SelectedItem = "Black"
        ElseIf Form1.highColor = Color.Red Then
            cbHighColor.SelectedItem = "Red"
        ElseIf Form1.highColor = Color.Blue Then
            cbHighColor.SelectedItem = "Blue"
        ElseIf Form1.highColor = Color.Yellow Then
            cbHighColor.SelectedItem = "Yellow"
        ElseIf Form1.highColor = Color.Lime Then
            cbHighColor.SelectedItem = "Green"
        End If

        If Form1.midHighColor = Color.White Then
            cbmidHighColor.SelectedItem = "White"
        ElseIf Form1.midHighColor = Color.Black Then
            cbmidHighColor.SelectedItem = "Black"
        ElseIf Form1.midHighColor = Color.Red Then
            cbmidHighColor.SelectedItem = "Red"
        ElseIf Form1.midHighColor = Color.Blue Then
            cbmidHighColor.SelectedItem = "Blue"
        ElseIf Form1.midHighColor = Color.Yellow Then
            cbmidHighColor.SelectedItem = "Yellow"
        ElseIf Form1.midHighColor = Color.Lime Then
            cbmidHighColor.SelectedItem = "Green"
        End If

        If Form1.zeroColor = Color.White Then
            cbZeroColor.SelectedItem = "White"
        ElseIf Form1.zeroColor = Color.Black Then
            cbZeroColor.SelectedItem = "Black"
        ElseIf Form1.zeroColor = Color.Red Then
            cbZeroColor.SelectedItem = "Red"
        ElseIf Form1.zeroColor = Color.Blue Then
            cbZeroColor.SelectedItem = "Blue"
        ElseIf Form1.zeroColor = Color.Yellow Then
            cbZeroColor.SelectedItem = "Yellow"
        ElseIf Form1.zeroColor = Color.Lime Then
            cbZeroColor.SelectedItem = "Green"
        End If

        If Form1.midLowColor = Color.White Then
            cbmidLowColor.SelectedItem = "White"
        ElseIf Form1.midLowColor = Color.Black Then
            cbmidLowColor.SelectedItem = "Black"
        ElseIf Form1.midLowColor = Color.Red Then
            cbmidLowColor.SelectedItem = "Red"
        ElseIf Form1.midLowColor = Color.Blue Then
            cbmidLowColor.SelectedItem = "Blue"
        ElseIf Form1.midLowColor = Color.Yellow Then
            cbmidLowColor.SelectedItem = "Yellow"
        ElseIf Form1.midLowColor = Color.Lime Then
            cbmidLowColor.SelectedItem = "Green"
        End If

        If Form1.lowColor = Color.White Then
            cbLowColor.SelectedItem = "White"
        ElseIf Form1.lowColor = Color.Black Then
            cbLowColor.SelectedItem = "Black"
        ElseIf Form1.lowColor = Color.Red Then
            cbLowColor.SelectedItem = "Red"
        ElseIf Form1.lowColor = Color.Blue Then
            cbLowColor.SelectedItem = "Blue"
        ElseIf Form1.lowColor = Color.Yellow Then
            cbLowColor.SelectedItem = "Yellow"
        ElseIf Form1.lowColor = Color.Lime Then
            cbLowColor.SelectedItem = "Green"
        End If

        txtHighValue.Text = Form1.highColorValue
        txtmidHighValue.Text = Form1.midHighColorValue
        txtmidLowValue.Text = Form1.midLowColorValue
        txtLowValue.Text = Form1.lowColorValue

        tbarDataWindowPercent.Value = Convert.ToInt32(100 * (Form1.ANNInfoWidth / Form1.Width))
        lblDataWindowPercent.Text = tbarDataWindowPercent.Value.ToString

        If Form1.showHoverNeuronInfoBlock = True Then
            cbShowHoveredNeuronInfoBlock.Checked = True
        Else
            cbShowHoveredNeuronInfoBlock.Checked = False
        End If

        If Form1.showCalculatedNeuronInfoBlock = True Then
            cbShowCalculatedNeuronInfoBlock.Checked = True
        Else
            cbShowCalculatedNeuronInfoBlock.Checked = False
        End If

        If Form1.showActionHistoryBlock = True Then
            cbShowActionHistoryBlock.Checked = True
        Else
            cbShowActionHistoryBlock.Checked = False
        End If

        If Form1.showNetworkInfoBlock = True Then
            cbShowNetworkInfoBlock.Checked = True
        Else
            cbShowNetworkInfoBlock.Checked = False
        End If

        If Form1.showWeightLinkLegend = True Then
            cbShowWeightLinkLegend.Checked = True
        Else
            cbShowWeightLinkLegend.Checked = False
        End If

        If Form1.neuronColor = Color.White Then
            cbNeuronColor.SelectedItem = "White"
        ElseIf Form1.neuronColor = Color.Black Then
            cbNeuronColor.SelectedItem = "Black"
        ElseIf Form1.neuronColor = Color.Red Then
            cbNeuronColor.SelectedItem = "Red"
        ElseIf Form1.neuronColor = Color.Blue Then
            cbNeuronColor.SelectedItem = "Blue"
        ElseIf Form1.neuronColor = Color.Yellow Then
            cbNeuronColor.SelectedItem = "Yellow"
        ElseIf Form1.neuronColor = Color.Lime Then
            cbNeuronColor.SelectedItem = "Green"
        End If

        If Form1.biasNeuronColor = Color.White Then
            cbBiasColor.SelectedItem = "White"
        ElseIf Form1.biasNeuronColor = Color.Black Then
            cbBiasColor.SelectedItem = "Black"
        ElseIf Form1.biasNeuronColor = Color.Red Then
            cbBiasColor.SelectedItem = "Red"
        ElseIf Form1.biasNeuronColor = Color.Blue Then
            cbBiasColor.SelectedItem = "Blue"
        ElseIf Form1.biasNeuronColor = Color.Yellow Then
            cbBiasColor.SelectedItem = "Yellow"
        ElseIf Form1.biasNeuronColor = Color.Lime Then
            cbBiasColor.SelectedItem = "Green"
        End If

        If Form1.selectedColor = Color.White Then
            cbSelectedColor.SelectedItem = "White"
        ElseIf Form1.selectedColor = Color.Black Then
            cbSelectedColor.SelectedItem = "Black"
        ElseIf Form1.selectedColor = Color.Red Then
            cbSelectedColor.SelectedItem = "Red"
        ElseIf Form1.selectedColor = Color.Blue Then
            cbSelectedColor.SelectedItem = "Blue"
        ElseIf Form1.selectedColor = Color.Yellow Then
            cbSelectedColor.SelectedItem = "Yellow"
        ElseIf Form1.selectedColor = Color.Lime Then
            cbSelectedColor.SelectedItem = "Green"
        End If

        If Form1.calculatedColor = Color.White Then
            cbCalculatedColor.SelectedItem = "White"
        ElseIf Form1.calculatedColor = Color.Black Then
            cbCalculatedColor.SelectedItem = "Black"
        ElseIf Form1.calculatedColor = Color.Red Then
            cbCalculatedColor.SelectedItem = "Red"
        ElseIf Form1.calculatedColor = Color.Blue Then
            cbCalculatedColor.SelectedItem = "Blue"
        ElseIf Form1.calculatedColor = Color.Yellow Then
            cbCalculatedColor.SelectedItem = "Yellow"
        ElseIf Form1.calculatedColor = Color.Lime Then
            cbCalculatedColor.SelectedItem = "Green"
        End If

        If Form1.backgroundColor = Color.White Then
            cbBackgroundColor.SelectedItem = "White"
        ElseIf Form1.backgroundColor = Color.Black Then
            cbBackgroundColor.SelectedItem = "Black"
        ElseIf Form1.backgroundColor = Color.Red Then
            cbBackgroundColor.SelectedItem = "Red"
        ElseIf Form1.backgroundColor = Color.Blue Then
            cbBackgroundColor.SelectedItem = "Blue"
        ElseIf Form1.backgroundColor = Color.Yellow Then
            cbBackgroundColor.SelectedItem = "Yellow"
        ElseIf Form1.backgroundColor = Color.Lime Then
            cbBackgroundColor.SelectedItem = "Green"
        End If

        If Form1.foregroundColor = Color.White Then
            cbForegroundColor.SelectedItem = "White"
        ElseIf Form1.foregroundColor = Color.Black Then
            cbForegroundColor.SelectedItem = "Black"
        ElseIf Form1.foregroundColor = Color.Red Then
            cbForegroundColor.SelectedItem = "Red"
        ElseIf Form1.foregroundColor = Color.Blue Then
            cbForegroundColor.SelectedItem = "Blue"
        ElseIf Form1.foregroundColor = Color.Yellow Then
            cbForegroundColor.SelectedItem = "Yellow"
        ElseIf Form1.foregroundColor = Color.Lime Then
            cbForegroundColor.SelectedItem = "Green"
        End If
    End Sub


    Private Sub txtHighValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHighValue.LostFocus
        If Not IsNumeric(txtHighValue.Text) And frmMessage.Visible = False Then
            frmMessage.txtMessageToUser.Text = "Numeric Values Allowed Only in Weight Legend Values. Setting back to current value."
            frmMessage.ShowDialog()
            txtHighValue.Text = Form1.highColorValue
        End If
    End Sub

    Private Sub txtmidHighValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmidHighValue.LostFocus
        If Not IsNumeric(txtmidHighValue.Text) And frmMessage.Visible = False Then
            frmMessage.txtMessageToUser.Text = "Numeric Values Allowed Only in Weight Legend Values. Setting back to current value."
            frmMessage.ShowDialog()
            txtmidHighValue.Text = Form1.midHighColorValue
        End If
    End Sub


    Private Sub txtmidLowValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmidLowValue.LostFocus
        If Not IsNumeric(txtmidLowValue.Text) And frmMessage.Visible = False Then
            frmMessage.txtMessageToUser.Text = "Numeric Values Allowed Only in Weight Legend Values. Setting back to current value."
            frmMessage.ShowDialog()
            txtmidLowValue.Text = Form1.midLowColorValue
        End If
    End Sub


    Private Sub txtLowValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLowValue.LostFocus
        If Not IsNumeric(txtLowValue.Text) And frmMessage.Visible = False Then
            frmMessage.txtMessageToUser.Text = "Numeric Values Allowed Only in Weight Legend Values. Setting back to current value."
            frmMessage.ShowDialog()
            txtLowValue.Text = Form1.lowColorValue
        End If
    End Sub

    Private Sub tbarDataWindowPercent_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbarDataWindowPercent.Scroll
        If tbarDataWindowPercent.Value > 80 Then
            tbarDataWindowPercent.Value = 80
            lblDataWindowPercent.Text = "80"
        Else
            lblDataWindowPercent.Text = tbarDataWindowPercent.Value.ToString
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmMessage.txtMessageToUser.Text = "Weight links connect neurons of adjacent layers. To better visualize the value of a weight link, this program categorizes the weight link value by color. This program differentiates weight link values into 5 classifications; High Value, Mid-High Value, Zero, Mid-Low Value, and Low Value. This program is defaulted to the optimum weight link color setup to ensure unique color values. Although you have the ability to change the color association for each weight link value category, improper color selection may enable the same color gradient to be realized to multiple weight link values."

        If Not frmMessage.Visible = True Then
            frmMessage.ShowDialog()
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.ResetGUIValues()
        PopulateGUIFormValues()
    End Sub
End Class