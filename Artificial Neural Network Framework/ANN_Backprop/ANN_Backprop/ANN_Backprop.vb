Imports System.IO

Public Class ANN_Backprop
    Const _ClassName As String = "ANN_Backprop"
    Public ANN As ANN_Network.Network

    Private countInputNeurons As Integer = 0
    Private countOutputNeurons As Integer = 0
    Private inputValues(,) As Double
    Private outputValues(,) As Double
    Private countExemplarRows As Integer
    Dim r As New Random(System.DateTime.Now.Millisecond)

    Public rho As Double = 0.25
    Public networkError As Double = 0

    Public ReadOnly Property averageError() As Double
        Get
            Return networkError / countExemplarRows
        End Get
    End Property



    Public Sub New(ByVal Network As ANN_Network.Network, ByVal inputFile As String)
        Const _MethodName = "New( Network, inputFile )"

        'MsgBox("Error - Not Implemented Yet")
        'THIS CODE IS NOT TESTED YET
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        If validInputFile(inputFile) Then
            importDataSet(inputFile)
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: invalid input file")
        End If


        If countInputNeurons > 0 And countOutputNeurons > 0 Then
            ANN = New ANN_Network.Network(countInputNeurons, Network.countHiddenNeurons(False), Network.countHiddenLayers, countOutputNeurons)
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: invalid input file")
        End If

        If ANN.countInputNeurons(False) = Network.countInputNeurons(False) And ANN.countOutputNeurons = Network.countOutputNeurons Then
            ANN = Network
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: invalid Network object input")
        End If


    End Sub

    Public Sub New(ByVal countInputNeurons As Integer, ByVal countHiddenNeurons As Integer, ByVal countHiddenLayers As Integer, ByVal countOutputNeurons As Integer, ByVal weightsRange As Double)
        Const _MethodName = "New( countInputNeurons,countHiddenNeurons,countHiddenLayers,countOutputNeurons)"
        If countInputNeurons > 0 And countHiddenNeurons > 0 And countHiddenLayers > 0 And countOutputNeurons > 0 Then
            ANN = New ANN_Network.Network(countInputNeurons, countHiddenNeurons, countHiddenLayers, countOutputNeurons, True, weightsRange)
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: invalid parameters passed")
        End If
    End Sub

    Public Sub New(ByVal countHiddenNeurons As Integer, ByVal countHiddenLayers As Integer, ByVal inputFile As String, ByVal weightsRange As Double)
        Const _MethodName = "New( countHiddenNeurons, countHiddenLayers, inputFile )"

        If validInputFile(inputFile) Then
            importDataSet(inputFile)
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: invalid input file")
        End If


        If countInputNeurons > 0 And countOutputNeurons > 0 Then
            ANN = New ANN_Network.Network(countInputNeurons, countHiddenNeurons, countHiddenLayers, countOutputNeurons, True, weightsRange)
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: invalid input file")
        End If

    End Sub

    Public Function validInputFile(ByVal filePath As String) As Boolean
        'For now just return true
        Return True
    End Function

    Public Sub importDataSet(ByVal filePath As String)
        Const _MethodName As String = "importDataSet(filePath)"
        Dim line As String
        Dim inputs() As String
        Dim rows As Integer = numRowsInTextFile(filePath)
        countExemplarRows = rows
        Dim sInputValues() As String
        Dim sOutputValues() As String

        Dim sr As StreamReader = File.OpenText(filePath)
        line = sr.ReadLine

        inputs = line.Split("="c)

        If inputs.Count <> 2 Then
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: Invalid contents of input file. Inputs and DesiredOutput should be delimited by a single '=' character")
            Exit Sub
        End If

        sInputValues = inputs(0).Split(","c)
        sOutputValues = inputs(1).Split(","c)

        countInputNeurons = Convert.ToInt32(sInputValues.Count)
        ReDim inputValues(rows - 1, countInputNeurons - 1)
        countOutputNeurons = Convert.ToInt32(sOutputValues.Count)
        ReDim outputValues(rows - 1, countOutputNeurons - 1)

        For i As Integer = 0 To rows - 1

            For k As Integer = 0 To countInputNeurons - 1
                inputValues(i, k) = Convert.ToDouble(sInputValues(k))
            Next

            For k As Integer = 0 To countOutputNeurons - 1
                outputValues(i, k) = Convert.ToDouble(sOutputValues(k))
            Next

            line = sr.ReadLine

            If Not line = Nothing Then
                inputs = line.Split("="c)

                If inputs.Count <> 2 Then
                    Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: XXXXXXXXXXXXXXXXXXXXXXXX")

                    Exit Sub
                End If

                sInputValues = inputs(0).Split(","c)
                sOutputValues = inputs(1).Split(","c)
            End If

        Next

        sr.Close()

    End Sub

    Public Function numRowsInTextFile(ByVal filePath As String) As Integer
        Dim sr As StreamReader = File.OpenText(filePath)
        Dim rows As Integer = 0
        Dim line As String

        Do
            line = sr.ReadLine
            rows += 1
        Loop Until sr.EndOfStream

        Return rows

    End Function


    Public Sub LearnDataSet(ByVal EpochLimit As Integer, Optional ByVal ErrorLimit As Double = -1)

    End Sub

    Public Sub TrainEpoch()
        Dim randomIndex() As Integer = randomizeIndexArray(countExemplarRows)
        Dim currentInputValues(countInputNeurons - 1) As Double
        Dim currentDesiredOutputValues(countOutputNeurons - 1) As Double
        Dim epochError As Double = 0

        For i As Integer = 0 To countExemplarRows - 1
            'Set input array values
            For j As Integer = 0 To countInputNeurons - 1
                currentInputValues(j) = inputValues(randomIndex(i), j)
            Next

            'Set desired output array values
            For j As Integer = 0 To countOutputNeurons - 1
                currentDesiredOutputValues(j) = outputValues(randomIndex(i), j)
            Next

            epochError += TrainNetwork(currentInputValues, currentDesiredOutputValues)

        Next

        networkError = epochError
        ANN.estimatedError = networkError

    End Sub

    Public Function randomizeIndexArray(ByVal countRows As Integer) As Integer()
        Dim array(countRows - 1) As Integer

        'Instantiate Array
        For i As Integer = 0 To array.Count - 1
            array(i) = i
        Next

        'Randomize Array
        ''Randomly chose 2 integers within the bounds of the array and switch the two values
        For i As Integer = 0 To array.Count - 1
            Dim rand1 As Integer = AbsVal(RandomNumber(array.Count - 1))
            Dim rand2 As Integer = AbsVal(RandomNumber(array.Count - 1))
            Dim tempNumber As Integer

            'Swap the two values in the array
            tempNumber = array(rand1)
            array(rand1) = array(rand2)
            array(rand2) = tempNumber
        Next

        Return array
    End Function

    Public Function RandomNumber(ByVal MaxNumber As Integer) As Integer
        Return r.Next(-MaxNumber, MaxNumber)
    End Function

    Public Function TrainNetwork(ByVal input() As Double, ByVal desiredOutput() As Double) As Double
        Const _MethodName As String = "TrainNetwork(input(),desiredOutput())"

        Dim outputError As Double = 0

        If input.Count = ANN.countInputNeurons(False) And desiredOutput.Count = ANN.countOutputNeurons Then
            'Set input neuron values
            For i As Integer = 0 To input.Count - 1
                ANN.Layer(0).Neuron(i).value = input(i)
            Next

            'Run the Network
            ANN.calculateAll()

            For i As Integer = 0 To countOutputNeurons - 1
                outputError += AbsVal(ANN.Layer(ANN.countHiddenLayers + 1).Neuron(i).value - desiredOutput(i))
            Next

            'Calculate Delta of Output Neurons
            Dim currentNeuron As ANN_Network.Neuron
            For i As Integer = 0 To ANN.Layer(ANN.countHiddenLayers + 1).Neuron.Count - 1
                currentNeuron = ANN.Layer(ANN.countHiddenLayers + 1).Neuron(i)
                currentNeuron.delta = calcDeltaOutput(currentNeuron, desiredOutput(i))
            Next

            'Calculate Deltas of Hidden Neurons
            For i As Integer = ANN.countHiddenLayers To 1 Step -1
                For j As Integer = 0 To ANN.Layer(i).Neuron.Count - 1
                    currentNeuron = ANN.Layer(i).Neuron(j)
                    currentNeuron.delta = calcDeltaHidden(currentNeuron)
                Next
            Next

            'Calculate New Weights
            currentNeuron = ANN.Layer(0).Neuron(0)
            Do Until currentNeuron.isOutputNeuron = True
                For i As Integer = 0 To currentNeuron.upperDendrites.Count - 1
                    currentNeuron.upperDendrites(i).value = calcNewDendrite(currentNeuron.upperDendrites(i))
                Next
                currentNeuron = ANN.getNextNeuron(currentNeuron)
                'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
                'I think the above code ignores the bias weights, which is why I think they dont change.........
            Loop

        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: number of input and/or number of output parameters does not equal what is necessary for the specific network")

        End If

        Return outputError

    End Function

    Public Function fPrime(ByVal u As Double) As Double
        Return u * (1 - u)
    End Function

    Public Function calcDeltaHidden(ByVal neuron As ANN_Network.Neuron) As Double
        Const _MethodName As String = "calcDeltaHidden(neuron,dendrite)"
        Dim sum As Double = 0
        If Not neuron.isOutputNeuron Then
            For i As Integer = 0 To neuron.upperDendrites.Count - 1
                sum += fPrime(neuron.value) * neuron.upperDendrites(i).value * neuron.upperDendrites(i).neuronAbove.delta
            Next
            Return sum
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: output neuron used as input for calcDeltaHidden, a hidden neuron is required.")
        End If
    End Function

    Public Function calcDeltaOutput(ByVal neuron As ANN_Network.Neuron, ByVal desiredOutput As Double) As Double
        Const _MethodName As String = "calcDeltaOutput(neuron,desiredOutput)"
        If neuron.isOutputNeuron Then
            Return -2 * (desiredOutput - neuron.value)
            'Return neuron.value - desiredOutput
            'Return (desiredOutput - neuron.value) * AbsVal(desiredOutput - neuron.value)
            'Return desiredOutput - neuron.value
            'Return -Math.Pow(desiredOutput - neuron.value, 2)
            'Dim x As Double = AbsVal(desiredOutput - neuron.value)
            'If x >= 0 Then
            '    Return Math.Pow(x, 2)
            'Else
            '    Return -Math.Pow(x, 2)
            'End If
        Else
            Throw New Exception("Error - Class: " & _ClassName & ", Method: " & _MethodName & _
                                        "Descr: hidden neuron used as input for calcDeltaOutput, an output neuron is required.")
        End If
    End Function

    Public Function calcNewDendrite(ByVal dendrite As ANN_Network.Dendrite) As Double
        Return dendrite.value - rho * dendrite.neuronAbove.delta * dendrite.neuronBelow.value
        'Return dendrite.value + rho * dendrite.neuronAbove.delta * dendrite.neuronBelow.value
    End Function

    Public Function AbsVal(ByVal value As Double)
        If value < 0 Then
            value = -value
        End If
        Return value
    End Function
End Class
