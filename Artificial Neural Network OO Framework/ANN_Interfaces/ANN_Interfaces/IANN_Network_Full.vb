Public Interface IANN_Network_Full










    'Private _ClassName As String = "Network"
    'Public ID As String = ""
    'Public Layer() As Layer
    'Public fitness As Double
    'Public estimatedError As Double = -1
    'Public currentCalcNeuron As Neuron
    'Public previousCalcNeuron As Neuron
    'Dim r As New Random(System.DateTime.Now.Millisecond)
    Property ID() As String
    Property Layer(pLayerIndex As Integer) As Layer
    Property Fitness As Double
    Property EstimatedError As Double
    Property CurrentCalcNeuron As Neuron
    Property PreviousCalcneuron As Neuron   

    ReadOnly Property countInputNeurons(ByVal includeBiasNeurons As Boolean) As Integer
    ReadOnly Property countHiddenNeurons(ByVal includeBiasNeurons As Boolean) As Integer
    ReadOnly Property countOutputNeurons() As Integer
    ReadOnly Property countHiddenLayers() As Integer
    ReadOnly Property countTotalNeurons(ByVal includeBiasNeurons As Boolean) As Integer
    ReadOnly Property countWeights() As Integer
    ReadOnly Property getWeightTotal() As Double
    ReadOnly Property getMaxWeightValue() As Double
    ReadOnly Property getMinWeightValue() As Double
    ReadOnly Property getCountZeroWeights(ByVal range As Double) As Integer
    ReadOnly Property getNetworkNeuronWidth() As Integer
    
    'Private Sub linkLayers(ByVal aboveLayer As Layer, ByVal belowLayer As Layer, ByVal topLayers As Boolean)
    Function getNeuronFromIndex(ByVal index As Integer) As Neuron
    Function getNeuronIndex(ByVal neuron As Neuron) As Integer
    Function getNextNeuron(ByVal neuron As Neuron) As Neuron
    Sub calculateNextNeuron()
    Sub calculateNextLayer()
    Sub calculateAll()
    Sub resetNetwork()
    Sub randomizeWeights(ByVal maxValue As Double)
    Function RandomNumber(ByVal MaxNumber As Integer) As Integer
    Function importNetworkFromFile(ByVal filePath As String) As ANN_Network.Network
    Sub exportNetworkToFile(ByVal filePath As String)
    Sub importWeightsFromFile(ByVal filePath As String)
    Sub importWeightsFromArray(ByVal weights() As Double)
    Function exportWeightsToArray() As Double()
    Sub exportWeightsToFile(ByVal filePath As String)
    Sub exportWeightsToFile(ByVal filePath As String, ByVal createNewFile As Boolean)
    








End Interface

