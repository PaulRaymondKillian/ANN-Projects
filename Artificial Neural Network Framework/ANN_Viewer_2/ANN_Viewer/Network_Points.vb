Public Class Network_Points
    Private _inputLayer() As NeuronPoint
    Private _hiddenLayer(,) As NeuronPoint
    Private _outputLayer() As NeuronPoint
    Private _neuronRadius As Integer

    Private _inputHiddenWeightLinks(,) As NeuronWeightLink
    Private _hiddenHiddenWeightLinks(,,) As NeuronWeightLink
    Private _hiddenOutputWeightLinks(,) As NeuronWeightLink

    Public ReadOnly Property inputLayer(ByVal index As Integer) As NeuronPoint
        Get
            Return _inputLayer(index)
        End Get
    End Property

    Public ReadOnly Property hiddenLayer(ByVal layerIndex As Integer, ByVal index As Integer) As NeuronPoint
        Get
            Return _hiddenLayer(layerIndex, index)
        End Get
    End Property

    Public ReadOnly Property outputLayer(ByVal index As Integer)
        Get
            Return _outputLayer(index)
        End Get
    End Property

    Public ReadOnly Property neuronRadius() As Integer
        Get
            Return _neuronRadius
        End Get
    End Property

    Public ReadOnly Property inputHiddenWeightLinks(ByVal inputIndex As Integer, ByVal hiddenIndex As Integer)
        Get
            Return _inputHiddenWeightLinks(inputIndex, hiddenIndex)
        End Get
    End Property

    Public ReadOnly Property hiddenHiddenWeightLinks(ByVal hiddenLayerInterval As Integer, ByVal hiddenIndex1 As Integer, ByVal hiddenIndex2 As Integer)
        Get
            Return _hiddenHiddenWeightLinks(hiddenLayerInterval, hiddenIndex1, hiddenIndex2)
        End Get
    End Property

    Public ReadOnly Property hiddenOutputWeightLinks(ByVal hiddenIndex As Integer, ByVal outputIndex As Integer)
        Get
            Return _hiddenOutputWeightLinks(hiddenIndex, outputIndex)
        End Get
    End Property

    Public Sub New(ByVal ANN As ANN_Network.Network, ByVal formWidth As Integer, ByVal formHeight As Integer, ByVal heightSpacer As Integer, ByVal maxRadius As Integer)

        'Prep inputLayer points array
        ReDim _inputLayer(ANN.countInputNeurons(False))
        For i As Integer = 0 To _inputLayer.Length - 1
            _inputLayer(i) = New NeuronPoint
        Next

        'Prep hiddenLayer points array
        ReDim _hiddenLayer(ANN.countHiddenLayers - 1, ANN.countHiddenNeurons(False))
        For i As Integer = 0 To ANN.countHiddenLayers - 1
            For k As Integer = 0 To ANN.countHiddenNeurons(False)
                _hiddenLayer(i, k) = New NeuronPoint
            Next
        Next

        'Prep outputLayer points array
        ReDim _outputLayer(ANN.countOutputNeurons - 1)
        For i As Integer = 0 To _outputLayer.Length - 1
            _outputLayer(i) = New NeuronPoint
        Next

        'Calculate radius
        _neuronRadius = calculateRadius(formWidth, ANN.getNetworkNeuronWidth, ANN.countHiddenLayers, maxRadius)

        buildPoints(ANN, formWidth, formHeight, heightSpacer)
        buildWeightLinks(ANN)
    End Sub

    Private Sub buildPoints(ByVal ANN As ANN_Network.Network, ByVal formWidth As Integer, ByVal formHeight As Integer, ByVal heightSpacer As Integer)

        'Dim ySpacer As Integer = formHeight / (ANN.countHiddenLayers + 3) - (heightSpacer / ANN.countHiddenLayers)
        Dim ySpacer As Integer = (formHeight - heightSpacer) / (2 * (ANN.countHiddenLayers + 2))
        Dim xInputLayerSpacer As Integer = formWidth / (ANN.countInputNeurons(False) + 2)
        Dim xHiddenLayerSpacer As Integer = formWidth / (ANN.countHiddenNeurons(False) + 2)
        Dim xOutputLayerSpacer As Integer = formWidth / (ANN.countOutputNeurons + 1)
        Dim x As Integer = 0
        Dim y As Integer = formHeight - ySpacer

        'Build points for input layer
        For i As Integer = 0 To ANN.countInputNeurons(False)
            '_inputLayer(i).y = y + (ySpacer / 3)
            _inputLayer(i).y = y
            _inputLayer(i).x = (i + 1) * xInputLayerSpacer
            _inputLayer(i).value = ANN.getNeuronFromIndex(i + 1).value
            _inputLayer(i).id = ANN.getNeuronFromIndex(i + 1).ID
            _inputLayer(i).type = ANN.getNeuronFromIndex(i + 1).type

            If ANN.getNeuronFromIndex(i + 1).type = ANN_Network.Neuron.NeuronType.BiasNeuron Then
                _inputLayer(i).color = Form1.biasNeuronColor
            Else
                _inputLayer(i).color = Form1.neuronColor
            End If

        Next

        'Build points for hidden layer(s)
        For i As Integer = 0 To ANN.countHiddenLayers - 1
            For k As Integer = 0 To ANN.countHiddenNeurons(False)
                _hiddenLayer(i, k).y = y - ((2 * ySpacer) * (i + 1))
                _hiddenLayer(i, k).x = (k + 1) * xHiddenLayerSpacer
                _hiddenLayer(i, k).value = ANN.getNeuronFromIndex((ANN.countInputNeurons(False) + 1) + (i * (ANN.countHiddenNeurons(False) + 1)) + 1 + k).value
                _hiddenLayer(i, k).id = ANN.getNeuronFromIndex((ANN.countInputNeurons(False) + 1) + (i * (ANN.countHiddenNeurons(False) + 1)) + 1 + k).ID
                _hiddenLayer(i, k).type = ANN.getNeuronFromIndex((ANN.countInputNeurons(False) + 1) + (i * (ANN.countHiddenNeurons(False) + 1)) + 1 + k).type

                If ANN.getNeuronFromIndex((ANN.countInputNeurons(False) + 1) + (i * (ANN.countHiddenNeurons(False) + 1)) + 1 + k).type = ANN_Network.Neuron.NeuronType.BiasNeuron Then
                    _hiddenLayer(i, k).color = Form1.biasNeuronColor
                ElseIf ANN.getNeuronFromIndex((ANN.countInputNeurons(False) + 1) + (i * (ANN.countHiddenNeurons(False) + 1)) + 1 + k).Equals(ANN.previousCalcNeuron) Then
                    _hiddenLayer(i, k).color = Form1.calculatedColor
                Else
                    _hiddenLayer(i, k).color = Form1.neuronColor
                End If
            Next
        Next

        'Build points for output layer
        For i As Integer = 0 To ANN.countOutputNeurons - 1
            '_outputLayer(i).y = y - (ANN.countHiddenLayers * ySpacer) - ySpacer - (ySpacer / 3)
            _outputLayer(i).y = y - (((ANN.countHiddenLayers + 1) * ySpacer) * 2)
            _outputLayer(i).x = (i + 1) * xOutputLayerSpacer
            _outputLayer(i).value = ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 1 + (ANN.countHiddenLayers * (ANN.countHiddenNeurons(False) + 1)) + 1 + i).value
            _outputLayer(i).id = ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 1 + (ANN.countHiddenLayers * (ANN.countHiddenNeurons(False) + 1)) + 1 + i).ID
            _outputLayer(i).type = ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 1 + (ANN.countHiddenLayers * (ANN.countHiddenNeurons(False) + 1)) + 1 + i).type

            If ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 1 + (ANN.countHiddenLayers * (ANN.countHiddenNeurons(False) + 1)) + 1 + i).type = ANN_Network.Neuron.NeuronType.BiasNeuron Then
                _outputLayer(i).color = Form1.biasNeuronColor
            ElseIf ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 1 + (ANN.countHiddenLayers * (ANN.countHiddenNeurons(False) + 1)) + 1 + i).Equals(ANN.previousCalcNeuron) Then
                _outputLayer(i).color = Form1.calculatedColor
            Else
                _outputLayer(i).color = Form1.neuronColor
            End If

        Next

    End Sub

    Private Sub buildWeightLinks(ByVal ANN As ANN_Network.Network)

        ReDim _inputHiddenWeightLinks(ANN.countInputNeurons(False), ANN.countHiddenNeurons(False) - 1)
        For i As Integer = 0 To ANN.countHiddenNeurons(False) - 1
            For k As Integer = 0 To ANN.countInputNeurons(False)
                _inputHiddenWeightLinks(k, i) = New NeuronWeightLink(_inputLayer(k), _hiddenLayer(0, i), ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 2 + i).belowDendrites(k).value)
            Next
        Next

        ReDim _hiddenHiddenWeightLinks(ANN.countHiddenLayers - 1, ANN.countHiddenNeurons(False) - 1, ANN.countHiddenNeurons(False))
        For i As Integer = 0 To ANN.countHiddenLayers - 2
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                For l As Integer = 0 To ANN.countHiddenNeurons(False)
                    _hiddenHiddenWeightLinks(i, k, l) = New NeuronWeightLink(_hiddenLayer(i + 1, k), _hiddenLayer(i, l), ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + 1 + ((i + 1) * (ANN.countHiddenNeurons(False) + 1)) + 1 + k).belowDendrites(l).value)
                Next
            Next
        Next

        ReDim _hiddenOutputWeightLinks(ANN.countHiddenNeurons(False), ANN.countOutputNeurons - 1)
        For i As Integer = 0 To ANN.countOutputNeurons - 1
            For k As Integer = 0 To ANN.countHiddenNeurons(False)
                _hiddenOutputWeightLinks(k, i) = New NeuronWeightLink(_hiddenLayer(ANN.countHiddenLayers - 1, k), _outputLayer(i), ANN.getNeuronFromIndex(ANN.countInputNeurons(False) + (ANN.countHiddenLayers * (ANN.countHiddenNeurons(False) + 1)) + 2 + i).belowDendrites(k).value)
            Next
        Next

    End Sub

    Private Function calculateRadius(ByVal formWidth As Integer, ByVal maxNeuronWidth As Integer, ByVal countHiddenLayers As Integer, ByVal maxRadius As Integer)
        Dim radius As Double
        Dim radius1 As Double
        Dim radius2 As Double

        radius1 = (1 / 3) * (formWidth / maxNeuronWidth + 2)
        radius2 = (2 * maxRadius) / countHiddenLayers

        If radius1 < maxRadius Or radius2 < maxRadius Then
            If radius1 < radius2 Then
                radius = radius1
            ElseIf radius2 < radius1 Then
                radius = radius2
            End If
        Else
            radius = maxRadius
        End If

        Return Convert.ToInt32(radius)
    End Function

End Class

Public Class NeuronPoint
    Public x As Integer
    Public y As Integer
    Public color As Color
    Public value As Double
    Public id As String
    Public type As Integer


    Public Sub New()
        x = 0
        y = 0
        color = Form1.neuronColor
        value = 0
    End Sub

End Class

Public Class NeuronWeightLink
    Public startNeuronPoint As NeuronPoint
    Public endNeuronPoint As NeuronPoint
    Public weight As Double
    Public color As Color

    Public Sub New(ByVal startPoint As NeuronPoint, ByVal endPoint As NeuronPoint, ByVal tempWeight As Double)
        startNeuronPoint = startPoint
        endNeuronPoint = endPoint
        weight = tempWeight
        color = Form1.neuronColor

    End Sub

    Public Function getPointOnLine(ByVal percent As Integer) As Point
        Dim point As Point

        point.X = startNeuronPoint.x - (percent / 100) * (startNeuronPoint.x - endNeuronPoint.x)
        point.Y = startNeuronPoint.y - (percent / 100) * (startNeuronPoint.y - endNeuronPoint.y)

        Return point
    End Function

End Class
