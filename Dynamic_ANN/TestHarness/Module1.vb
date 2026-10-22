Module Module1

    Sub Main()
        'Dim inputNodes As Integer = 100
        'Dim outputNodes As Integer = 100
        'Dim ANN As New Dynamic_ANN.ANN(4, 4)
        Dim ANN As New Dynamic_ANN.ANN(4, 4, 4, 4)

        Dim inputsArray(4) As Double
        inputsArray = New Double() {1, 2, 4, 8}

        ANN.setInputs(inputsArray)


        'Dim numWeights = ((10 * (inputNodes + 1)) + 110 + (outputNodes * 11))

        'Dim arr(ANN.numWeightsRequired - 1) As Double
        'For i As Integer = 0 To ANN.numWeightsRequired - 1
        '    arr(i) = 5
        'Next

        'ANN.setWeights(arr)

        'Console.WriteLine(ANN.debugOutputANN)
        'Console.WriteLine(ANN.debugOutputH1)
        'Console.WriteLine(ANN.debugOutputH2)
        'Console.WriteLine(ANN.debugOutputOutput)
        'Console.WriteLine(ANN.debugOutputWeights)
        'Console.WriteLine(ANN.debugOutputInputValues)
        Console.WriteLine(ANN.debugOutputPrettyANN)


        Console.WriteLine("Press Enter to Exit...")
        Dim z As String = Console.Read
    End Sub

End Module
