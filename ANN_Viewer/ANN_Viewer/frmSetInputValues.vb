Public Class frmSetInputValues

    Private ANN As ANN_Arch.Network
    Dim MyHashTable As New Hashtable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'ANN.getNeuronFromIndex(1).value = Me.Controls.Item(txtNeuron1).text
        Dim i As Integer = 1

        Dim MyControl As Control

        Dim MyTextBox As TextBox

        For Each MyControl In Me.Controls

            If TypeOf (MyControl) Is TextBox Then

                MyTextBox = MyControl

                If Me.MyHashTable.Contains(MyTextBox.Name) Then

                    If IsNumeric(MyTextBox.Text) Then
                        Form1.ANN.getNeuronFromIndex(i).value = Convert.ToDouble(MyTextBox.Text)
                        i += 1
                    Else
                        Throw New Exception("Error - Class: frmSetInputValues, Method: Button1_Click, Desc: " & MyTextBox.Name & "=" & MyTextBox.Text & " is not a valid input value (numbers only)")
                    End If

                End If

            End If

        Next

        Me.Close()
        Form1.TextOutputWindowHistory_Add("Set Input Neurons")

    End Sub

    Public Sub SetupInputValueBoxes(ByVal tempANN As ANN_Arch.Network)
        Dim x As Integer = 20
        Dim y As Integer = 50

        ANN = tempANN

        For i As Integer = 0 To ANN.numInputNeurons - 1
            Dim MyText As New TextBox
            Dim MyLabel As New Label

            MyText.Text = ANN.getNeuronFromIndex(i + 1).value
            MyLabel.Text = "Input Neuron " & i & ":"

            MyText.Name = "txtNeuron" & i
            MyLabel.Name = "lblNeuron" & i

            MyText.Location = New Point(x + 90, y + (30 * i) - 5)
            MyLabel.Location = New Point(x, y + (30 * i))

            MyText.Size = New Size(50, 20)

            Me.Controls.Add(MyText)
            Me.Controls.Add(MyLabel)
            Me.MyHashTable.Add("txtNeuron" & i, "txtNeuron" & i)
            'Me.MyHashTable.Add("lblNeuron" & i, "lblNeuron" & i)
        Next

        'Set max height to 700 so it can all fit on the screen
        If y + (30 * Me.MyHashTable.Count) + 50 < 700 Then
            Me.Height = y + (30 * Me.MyHashTable.Count) + 50
        Else
            Me.Height = 700
        End If

    End Sub
End Class