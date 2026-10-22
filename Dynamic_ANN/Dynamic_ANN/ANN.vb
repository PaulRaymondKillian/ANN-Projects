Public Class ANN

    Private _firstInputNode As Node
    Private _firstOutputNode As Node
    Private _numInputNodes As Integer
    Private _numOutputNodes As Integer
    Private _numH1Nodes As Integer = 10
    Private _numH2Nodes As Integer = 10

    Public Sub New(ByVal numInputNodes As Double, ByVal numOutputNodes As Double)
        _numInputNodes = numInputNodes
        _numOutputNodes = numOutputNodes

        BuildANN()
    End Sub

    Public Sub New(ByVal numInputNodes As Double, ByVal numH1Nodes As Double, ByVal numH2Nodes As Double, ByVal numOutputNodes As Double)
        _numInputNodes = numInputNodes
        _numOutputNodes = numOutputNodes
        _numH1Nodes = numH1Nodes
        _numH2Nodes = numH2Nodes

        BuildANN()
    End Sub

    Public Sub BuildANN()

        Dim currentNode As Node
        Dim previousNode As Node

        'Build Input Nodes
        For i As Integer = 1 To _numInputNodes

            currentNode = New Node
            currentNode.type = "I" & i

            If i = 1 Then
                _firstInputNode = currentNode   'Set first node
            Else
                previousNode.nextNodeLink = currentNode
            End If

            previousNode = currentNode

        Next

        'Build input layer bias
        currentNode = New Node
        currentNode.type = "I-B"
        currentNode.value = 1
        previousNode.nextNodeLink = currentNode
        previousNode = currentNode


        'Build Hidden Layer Nodes
        'Build First Hidden Layer
        For i As Integer = 1 To _numH1Nodes

            currentNode = New Node
            currentNode.type = "H1-" & i

            previousNode.nextNodeLink = currentNode

            Dim tempInputNodeIndex As Node
            tempInputNodeIndex = _firstInputNode
            Dim currentWeight As weight
            Dim previousWeight As weight
            For j As Integer = 1 To _numInputNodes + 1 'The +1 is for the bias
                currentWeight = New weight

                If j = 1 Then
                    currentNode.weight = currentWeight
                    currentWeight.linkedNode = _firstInputNode
                Else
                    previousWeight.nextWeightLink = currentWeight
                    currentWeight.linkedNode = tempInputNodeIndex
                End If

                previousWeight = currentWeight
                tempInputNodeIndex = tempInputNodeIndex.nextNodeLink

            Next

            previousNode = currentNode

        Next

        'Build H1 layer bias
        currentNode = New Node
        currentNode.type = "H1-B"
        currentNode.value = 1
        previousNode.nextNodeLink = currentNode
        previousNode = currentNode


        'Build Second Hidden Layer
        For i As Integer = 1 To _numH2Nodes

            currentNode = New Node
            currentNode.type = "H2-" & i

            previousNode.nextNodeLink = currentNode

            Dim tempH1NodeIndex As Node
            Dim firstH1Node As Node
            firstH1Node = _firstInputNode
            'Traverse input nodes to get to first H-1 Node
            For k As Integer = 1 To _numInputNodes + 1 'The +1 is for the bias
                firstH1Node = firstH1Node.nextNodeLink
            Next
            tempH1NodeIndex = firstH1Node

            Dim currentWeight As weight
            Dim previousWeight As weight
            For j As Integer = 1 To _numH1Nodes + 1
                currentWeight = New weight

                If j = 1 Then
                    currentNode.weight = currentWeight
                    currentWeight.linkedNode = firstH1Node
                Else
                    previousWeight.nextWeightLink = currentWeight
                    currentWeight.linkedNode = tempH1NodeIndex
                End If

                previousWeight = currentWeight
                tempH1NodeIndex = tempH1NodeIndex.nextNodeLink

            Next

            previousNode = currentNode

        Next

        'Build H2layer bias
        currentNode = New Node
        currentNode.type = "H2-B"
        currentNode.value = 1
        previousNode.nextNodeLink = currentNode
        previousNode = currentNode


        'Build Output Layer
        For i As Integer = 1 To _numOutputNodes

            currentNode = New Node
            currentNode.type = "O-" & i

            previousNode.nextNodeLink = currentNode

            Dim tempH2NodeIndex As Node
            Dim firstH2Node As Node
            firstH2Node = _firstInputNode
            'Traverse input nodes to get to first H-1 Node
            For k As Integer = 1 To _numInputNodes + 1 'The +1 is for the bias
                firstH2Node = firstH2Node.nextNodeLink
            Next
            'Traverse H1 Nodes to get to first H-2 Node
            For k As Integer = 1 To _numH1Nodes + 1 'The +1 is for the bias
                firstH2Node = firstH2Node.nextNodeLink
            Next
            tempH2NodeIndex = firstH2Node

            Dim currentWeight As weight
            Dim previousWeight As weight
            For j As Integer = 1 To _numH2Nodes + 1 'The +1 is for the bias
                currentWeight = New weight

                If j = 1 Then
                    currentNode.weight = currentWeight
                    currentWeight.linkedNode = firstH2Node
                Else
                    previousWeight.nextWeightLink = currentWeight
                    currentWeight.linkedNode = tempH2NodeIndex
                End If

                previousWeight = currentWeight
                tempH2NodeIndex = tempH2NodeIndex.nextNodeLink

            Next

            previousNode = currentNode

        Next

    End Sub

    Public Sub setWeights(ByVal weightsArr() As Double)

        If weightsArr.Length <> ((_numH1Nodes * (_numInputNodes + 1)) + (_numH2Nodes * (_numH1Nodes + 1)) + (_numOutputNodes * (_numH2Nodes + 1))) Then
            MsgBox("Error - Class: ANN, Method: setWeights, Desc: number of weights passed not equal to number of weights needed (Need " & (_numH1Nodes * (_numInputNodes + 1)) + (_numH2Nodes * (_numH1Nodes + 1)) + (_numOutputNodes * (_numH2Nodes + 1)) & ", " & weightsArr.Length & " were passed)")
        Else
            'Set the Weights
            Dim currentNode As Node
            Dim currentWeight As weight
            currentNode = _firstInputNode
            'Traverse input nodes to get to first H-1 Node
            For k As Integer = 1 To _numInputNodes + 1 'The +1 for the bias
                currentNode = currentNode.nextNodeLink
            Next

            currentWeight = currentNode.weight
            For i As Integer = 0 To weightsArr.Length - 1
                Do
                    currentWeight.value = weightsArr(i)
                    i = i + 1
                    currentWeight = currentWeight.nextWeightLink
                Loop While (Not currentWeight Is Nothing)

                If i <> weightsArr.Length Then
                    currentNode = currentNode.nextNodeLink
                    currentWeight = currentNode.weight

                    'stupid fix to get the counter back on track
                    i = i - 1
                End If


                If currentNode.type = "H1-B" Or currentNode.type = "H2-B" Then
                    'Skip the bias nodes
                    currentNode = currentNode.nextNodeLink
                    currentWeight = currentNode.weight
                End If


            Next

        End If

    End Sub

    Public Function numWeightsRequired() As Integer
        Return ((_numH1Nodes * (_numInputNodes + 1)) + (_numH2Nodes * (_numH1Nodes + 1)) + (_numOutputNodes * (_numH2Nodes + 1)))
    End Function

    Public Sub setInputs(ByVal inputsArr() As Double)
        'Set the input values
        If inputsArr.Length <> _numInputNodes Then
            MsgBox("Error - Class: ANN, Method: setInputs, Desc: The number of input values does not equal the number of input nodes. (Needed " & _numInputNodes & ", Passed: " & inputsArr.Length & ")")
        Else
            'set the input values
            Dim currentNode As Node
            currentNode = _firstInputNode
            For i As Integer = 0 To _numInputNodes - 1
                currentNode.value = inputsArr(i)
                currentNode = currentNode.nextNodeLink
            Next
        End If
    End Sub

    Public Sub calculate()
        'perform the ANN calculations
    End Sub














    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Debugging Portion Below - Not Intended For Production Use
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '
    '
    '
    Public Function debugOutputANN() As String

        Dim s As String = ""

        Dim currentNode As Node
        currentNode = _firstInputNode

        Do While (Not currentNode Is Nothing)
            s = s & currentNode.type & ", "
            currentNode = currentNode.nextNodeLink
        Loop

        Return s

    End Function

    Public Function debugOutputH1() As String
        Dim s As String = ""

        Dim currentNode As Node
        Dim currentWeight As weight

        currentNode = _firstInputNode

        'Traverse input nodes to get to first H-1 Node
        For i As Integer = 1 To _numInputNodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        For i As Integer = 1 To _numH1Nodes
            s = s & "H1-" & i & "{"
            currentWeight = currentNode.weight
            For j As Integer = 1 To _numInputNodes + 1
                s = s & currentWeight.linkedNode.type & " "
                currentWeight = currentWeight.nextWeightLink
            Next

            s = s & "}, "

            currentNode = currentNode.nextNodeLink

        Next

        Return s

    End Function

    Public Function debugOutputH2() As String
        Dim s As String = ""

        Dim currentNode As Node
        Dim currentWeight As weight

        currentNode = _firstInputNode

        'Traverse input nodes to get to first H-1 Node
        For i As Integer = 1 To _numInputNodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        'Traverse H1 Nodes to get to first H-2 Node
        For i As Integer = 1 To _numH1Nodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        For i As Integer = 1 To _numH2Nodes
            s = s & "H2-" & i & "{"
            currentWeight = currentNode.weight
            For j As Integer = 1 To _numH1Nodes + 1
                s = s & currentWeight.linkedNode.type & " "
                currentWeight = currentWeight.nextWeightLink
            Next

            s = s & "}, "

            currentNode = currentNode.nextNodeLink

        Next

        Return s

    End Function

    Public Function debugOutputOutput() As String
        Dim s As String = ""

        Dim currentNode As Node
        Dim currentWeight As weight

        currentNode = _firstInputNode

        'Traverse input nodes to get to first H-1 Node
        For i As Integer = 1 To _numInputNodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        'Traverse H1 Nodes to get to first H-2 Node
        For i As Integer = 1 To _numH1Nodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        'Traverse H2 Nodes to get to first O Node
        For i As Integer = 1 To _numH2Nodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        For i As Integer = 1 To _numOutputNodes
            s = s & "0-" & i & "{"
            currentWeight = currentNode.weight
            For j As Integer = 1 To _numH2Nodes + 1
                s = s & currentWeight.linkedNode.type & " "
                currentWeight = currentWeight.nextWeightLink
            Next

            s = s & "}, "

            currentNode = currentNode.nextNodeLink

        Next

        Return s

    End Function

    Public Function debugOutputWeights() As String
        Dim s As String = ""

        Dim currentNode As Node
        currentNode = _firstInputNode

        'Traverse input nodes to get to first H-1 Node
        For i As Integer = 1 To _numInputNodes + 1
            currentNode = currentNode.nextNodeLink
        Next

        Do While (Not currentNode Is Nothing)

            s = s & "| " & currentNode.type & ": "

            Dim currentWeight As weight
            currentWeight = currentNode.weight

            Do While (Not currentWeight Is Nothing)
                s = s & "{" & currentWeight.linkedNode.type & "=" & currentWeight.value & "}"

                currentWeight = currentWeight.nextWeightLink
            Loop

            currentNode = currentNode.nextNodeLink

        Loop

        Return s

    End Function

    Public Function debugOutputInputValues() As String
        Dim s As String = ""

        Dim currentNode As Node
        currentNode = _firstInputNode

        For i As Integer = 0 To _numInputNodes - 1
            s = s & currentNode.type & ": " & currentNode.value & " "
            currentNode = currentNode.nextNodeLink
        Next

        Return s

    End Function

    Public Function debugOutputPrettyANN() As String
        Dim s As String = ""

        Dim currentNode As Node


        'Traverse network to get to the output nodes
        currentNode = _firstInputNode
        For i As Integer = 0 To (_numInputNodes + _numH1Nodes + _numH2Nodes) + 2    'The +2 is because there are biases to take into account
            currentNode = currentNode.nextNodeLink
        Next
        For i As Integer = 0 To _numOutputNodes - 1
            s = s & currentNode.type & ":" & currentNode.value & "     "
            If Not currentNode.nextNodeLink Is Nothing Then
                currentNode = currentNode.nextNodeLink
            End If
        Next
        s = s & vbNewLine & vbNewLine


        'Traverse network to get to the H2 nodes
        currentNode = _firstInputNode
        For i As Integer = 0 To (_numInputNodes + _numH1Nodes) + 1     'The +1 is because there are biases to take into account
            currentNode = currentNode.nextNodeLink
        Next
        For i As Integer = 0 To _numH2Nodes - 1
            s = s & currentNode.type & ":" & currentNode.value & " "
            currentNode = currentNode.nextNodeLink
        Next
        s = s & vbNewLine & vbNewLine


        'Traverse network to get to the H1 nodes
        currentNode = _firstInputNode
        For i As Integer = 0 To (_numInputNodes)     'The +2 is because there are biases to take into account
            currentNode = currentNode.nextNodeLink
        Next
        For i As Integer = 0 To _numH2Nodes - 1
            s = s & currentNode.type & ":" & currentNode.value & " "
            currentNode = currentNode.nextNodeLink
        Next
        s = s & vbNewLine & vbNewLine



        currentNode = _firstInputNode
        For i As Integer = 0 To _numInputNodes - 1
            s = s & currentNode.type & ": " & currentNode.value & "     "
            currentNode = currentNode.nextNodeLink
        Next





        Return s
    End Function

End Class
