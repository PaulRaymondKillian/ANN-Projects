Imports ANN_Network

Public Class ANN_Hebbian
    Inherits ANN_Network.Network

    Private _DendriteActiveList() As Dendrite
    Private _DendriteDormantList() As Dendrite
    Const ACTIVATEDTHRESHOLD As Double = 0.1 'This is an 'exclusive' threshold (greater than threshold)

    Public Sub New(ByVal inputNeurons As Integer, ByVal hiddenNeurons As Integer, ByVal hiddenLayers As Integer, ByVal outputNeurons As Integer)
        MyBase.New(inputNeurons, hiddenNeurons, hiddenLayers, outputNeurons, False, 0)
    End Sub

    Public Sub New(ByVal inputNeurons As Integer, ByVal hiddenNeurons As Integer, ByVal hiddenLayers As Integer, ByVal outputNeurons As Integer, ByVal randomWeights As Boolean, ByVal randomizedMaxValue As Double)
        MyBase.New(inputNeurons, hiddenNeurons, hiddenLayers, outputNeurons, randomWeights, randomizedMaxValue)
    End Sub

    Private Sub AddDendritesToLists(Optional pIncludeInputLayer As Boolean = True, Optional pIncludeOutputLayer As Boolean = False)
        For LayerIndex As Integer = 1 to Layer.Count-1
            For Each CurrentNeuron As Neuron In Layer(LayerIndex).Neuron
                If CurrentNeuron.value > ACTIVATEDTHRESHOLD
                    For Each CurrentLowerDendrite As Dendrite In CurrentNeuron.belowDendrites

                    Next
                Else

                End If
            Next
        Next
    End Sub

    Private Sub AddDendriteToActiveList(pDendrite As Dendrite)
        'Check if this is correct, probably isnt on first pass.......
        ReDim Preserve _DendriteActiveList(_DendriteActiveList.Count+1)
        _DendriteActiveList(_DendriteActiveList.Count-1) = pDendrite
    End Sub

    Private Sub AddDendriteToDormantList(pDendrite As Dendrite)
        'Check if this is correct, probably isnt on first pass.......
        ReDim Preserve _DendriteDormantList(_DendriteDormantList.Count+1)
        _DendriteDormantList(_DendriteDormantList.Count-1) = pDendrite
    End Sub


End Class
