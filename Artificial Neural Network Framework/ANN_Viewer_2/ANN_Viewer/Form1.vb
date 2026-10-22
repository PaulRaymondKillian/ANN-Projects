Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports System.Math
Imports System.IO

Public Class Form1
    Private device As Direct3D.Device
    Private DrawFont8 As Direct3D.Font
    Private DrawFont10 As Direct3D.Font
    Private DrawFont14 As Direct3D.Font
    Private DrawFont20 As Direct3D.Font
    Dim color As Color = Drawing.Color.Purple
    Friend backgroundColor As Color = Drawing.Color.Black
    Friend foregroundColor As Color = Drawing.Color.White
    Friend neuronColor As Color = Drawing.Color.Red
    Friend biasNeuronColor As Color = Drawing.Color.Blue
    Friend selectedColor As Color = Drawing.Color.Yellow
    Friend calculatedColor As Color = Drawing.Color.Lime
    Friend highColor As Color = Drawing.Color.White
    Friend midHighColor As Color = Drawing.Color.Lime
    Friend zeroColor As Color = Drawing.Color.Black
    Friend midLowColor As Color = Drawing.Color.Red
    Friend lowColor As Color = Drawing.Color.Blue
    Friend midHighColorValue As Double = 5
    Friend midLowColorValue As Double = -5
    Friend highColorValue As Double = 20
    Friend lowColorValue As Double = -20
    Friend ANNInfoWidth As Integer = 200
    Dim ANNTopBarHeight As Integer = 50
    Dim textOutputWindowHistory(10) As String
    Dim textRowHeightPixels As Integer = 17
    Dim highlightedNeuron As String = ""
    Friend showHoverNeuronInfoBlock As Boolean = True
    Friend showCalculatedNeuronInfoBlock As Boolean = True
    Friend showActionHistoryBlock As Boolean = True
    Friend showNetworkInfoBlock As Boolean = True
    Friend showWeightLinkLegend As Boolean = True

    'Public ANN As New ANN_Network.Network(4, 4, 4, 2)
    Public ANN As New ANN_Network.Network(5, 6, 3, 4, True, 10)

    Public Enum FontSize
        fontSize8 = 8
        fontSize10 = 10
        fontSize14 = 14
        fontSize20 = 20
    End Enum

    Public Sub Initialize()

        Dim present As PresentParameters = New PresentParameters
        present.Windowed = True 'we?ll draw on a window
        present.SwapEffect = SwapEffect.Discard 'discuss later
        device = New Direct3D.Device(0, DeviceType.Hardware, Me, CreateFlags.SoftwareVertexProcessing, present)
        DrawFont8 = New Direct3D.Font(device, New Drawing.Font("Arial", 8, FontStyle.Regular))
        DrawFont10 = New Direct3D.Font(device, New Drawing.Font("Arial", 10, FontStyle.Regular))
        DrawFont14 = New Direct3D.Font(device, New Drawing.Font("Arial", 14, FontStyle.Regular))
        DrawFont20 = New Direct3D.Font(device, New Drawing.Font("Arial", 20, FontStyle.Regular))

        'Setup the Form for setting up the input values for this ANN Network
        frmSetInputValues.SetupInputValueBoxes(ANN)
        textOutputWindowHistory(1) = "##Program Started##"
        textOutputWindowHistory(0) = "ANN Created"

    End Sub

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.Opaque, True) 'Do not draw form?s background\
        Me.Height = 600
        Me.Width = 1000
        Me.Text = "ANN Viewer"

        Initialize()
        LoadGUIValues()

    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        device.Clear(ClearFlags.Target, backgroundColor, 1.0, 0)
        device.BeginScene() 'all drawings after this line
        device.VertexFormat = CustomVertex.TransformedColored.Format


        MenuStrip1.Refresh()
        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Begin Drawing ANN Viewer
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''

        DrawText("Artificial Neural Network Viewer", Me.Width / 2 - 200, 20, 400, 30, FontSize.fontSize20, Drawing.Color.Red)
        DrawANN(ANN, 30)

        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' End Drawing ANN Viewer
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''


        device.EndScene() 'all drawings before this line

        device.Present()
        Me.Invalidate() 'redraw
    End Sub

    Public Sub DrawCircleOutline(ByVal x As Integer, ByVal y As Integer, ByVal radius As Integer, ByVal numSides As Integer)
        Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To numSides) {} 'create an array of vertices

        For i As Integer = 0 To numSides
            vertices(i).Position = New Vector4(x + (radius) * Cos((6.28 / numSides) * i), y + (radius) * Sin((6.28 / numSides) * i), 0, 1)
            vertices(i).Color = Drawing.Color.Red.ToArgb
        Next

        device.DrawUserPrimitives(PrimitiveType.LineStrip, numSides, vertices)
        'device.DrawUserPrimitives(PrimitiveType.TriangleFan, numSides, vertices)

    End Sub

    Public Function mousePosX() As Integer
        Return MousePosition.X - Me.Location.X
    End Function
    Public Function mousePosY() As Integer
        Return MousePosition.Y - Me.Location.Y - 20
    End Function

    Public Function isMouseOverPoint(ByVal x As Integer, ByVal y As Integer, ByVal radius As Integer) As Boolean
        Dim mouseOverPoint As Boolean = False
        If mousePosX() < x + (radius / 2) And mousePosX() > x - (radius / 2) And mousePosY() < y + (radius / 2) And mousePosY() > y - (radius / 2) Then
            mouseOverPoint = True
        End If
        Return mouseOverPoint
    End Function

    Public Sub DrawCircle(ByVal x As Integer, ByVal y As Integer, ByVal radius As Integer, ByVal numSides As Integer, ByVal tempColor As Color)
        Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To numSides) {} 'create an array of vertices

        For i As Integer = 0 To numSides
            vertices(i).Position = New Vector4(x + (radius) * Cos((6.28 / numSides) * i), y + (radius) * Sin((6.28 / numSides) * i), 0, 1)
            vertices(i).Color = tempColor.ToArgb
        Next

        device.DrawUserPrimitives(PrimitiveType.TriangleFan, numSides, vertices)

    End Sub

    Public Sub DrawLine(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal tempColor As Color)
        Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 1) {} 'create an array of vertices

        vertices(0).Position = New Vector4(x1, y1, 0, 0)
        vertices(0).Color = tempColor.ToArgb
        vertices(1).Position = New Vector4(x2, y2, 0, 0)
        vertices(1).Color = tempColor.ToArgb

        device.DrawUserPrimitives(PrimitiveType.LineStrip, 1, vertices)
    End Sub

    Public Sub DrawLine(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal tempColor As Color, ByVal tempColor2 As Color)
        Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 1) {} 'create an array of vertices

        vertices(0).Position = New Vector4(x1, y1, 0, 0)
        vertices(0).Color = tempColor.ToArgb
        vertices(1).Position = New Vector4(x2, y2, 0, 0)
        vertices(1).Color = tempColor2.ToArgb

        device.DrawUserPrimitives(PrimitiveType.LineStrip, 1, vertices)
    End Sub

    Public Sub DrawText(ByVal s As String, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal fontSize As FontSize, ByVal color As Drawing.Color, ByVal align As Microsoft.DirectX.Direct3D.DrawTextFormat)

        If fontSize = Form1.FontSize.fontSize8 Then
            DrawFont8.DrawText(Nothing, s, New Drawing.Rectangle(x, y, width, height), align, color)
        ElseIf fontSize = Form1.FontSize.fontSize10 Then
            DrawFont10.DrawText(Nothing, s, New Drawing.Rectangle(x, y, width, height), align, color)
        ElseIf fontSize = Form1.FontSize.fontSize14 Then
            DrawFont14.DrawText(Nothing, s, New Drawing.Rectangle(x, y, width, height), align, color)
        ElseIf fontSize = Form1.FontSize.fontSize20 Then
            DrawFont20.DrawText(Nothing, s, New Drawing.Rectangle(x, y, width, height), align, color)
        Else
            'MsgBox("Error - Class: Form1, Method: DrawText, Descr: Invalid Font Size Inputted")
            Throw New Exception("Error - Class: Form1, Method: DrawText, Descr: Invalid Font Size Inputted")
        End If
    End Sub

    Public Sub DrawText(ByVal s As String, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal fontSize As FontSize, ByVal color As Drawing.Color)
        DrawText(s, x, y, width, height, fontSize, color, DrawTextFormat.Center)
    End Sub

    Public Sub DrawSquare(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal color As Color)

        DrawLine(x, y, x + width, y, color)
        DrawLine(x, y, x, y + height, color)
        DrawLine(x + width, y, x + width, y + height, color)
        DrawLine(x, y + height, x + width, y + height, color)

    End Sub


    Public Sub DrawANN(ByVal ANN As ANN_Network.Network, ByVal maxRadius As Integer)

        Dim NP As New Network_Points(ANN, Me.Width - ANNInfoWidth, Me.Height - 50, ANNTopBarHeight, maxRadius)

        drawWeightLinks(NP, ANN)
        drawNeurons(NP, ANN, maxRadius)
        drawWeightValues(NP, ANN)
        DrawANNData(ANN, Me.Width, Me.Height)

    End Sub

    Public Sub DrawANNData(ByVal ANN As ANN_Network.Network, ByVal formWidth As Integer, ByVal formHeight As Integer)
        Dim startRow As Integer = 3

        If showHoverNeuronInfoBlock = True Then
            startRow = DrawData_HighlightedNeuronInfo(formWidth, formHeight, startRow, foregroundColor, Drawing.Color.Blue)
        End If

        If showCalculatedNeuronInfoBlock = True Then
            startRow = DrawData_PreviousNeuronCalculation(formWidth, formHeight, startRow, foregroundColor, Drawing.Color.Blue)
        End If

        If showActionHistoryBlock = True Then
            startRow = DrawData_TextOutputWindowHistory(formWidth, formHeight, startRow, foregroundColor, Drawing.Color.Red, Drawing.Color.Blue)
        End If

        If showNetworkInfoBlock = True Then
            startRow = DrawData_ANNInfo(formWidth, formHeight, startRow, foregroundColor, Drawing.Color.Blue)
        End If

        If showWeightLinkLegend = True Then
            DrawData_WeightLinkColorLegend()
        End If

    End Sub

    Public Sub DrawData_WeightLinkColorLegend()
        Dim heightBuffer As Integer = 50
        Dim lineInterval As Integer = Me.Width / 6
        Dim textHeightBuffer As Integer = 15
        DrawLine(lineInterval - (lineInterval / 2), Me.Height - heightBuffer, lineInterval, Me.Height - heightBuffer, highColor, highColor)
        DrawLine(lineInterval, Me.Height - heightBuffer, 2 * lineInterval, Me.Height - heightBuffer, highColor, midHighColor)
        DrawLine(2 * lineInterval, Me.Height - heightBuffer, 3 * lineInterval, Me.Height - heightBuffer, midHighColor, zeroColor)
        DrawLine(3 * lineInterval, Me.Height - heightBuffer, 4 * lineInterval, Me.Height - heightBuffer, zeroColor, midLowColor)
        DrawLine(4 * lineInterval, Me.Height - heightBuffer, 5 * lineInterval, Me.Height - heightBuffer, midLowColor, lowColor)
        DrawLine(5 * lineInterval, Me.Height - heightBuffer, 5 * lineInterval + (lineInterval / 2), Me.Height - heightBuffer, lowColor, lowColor)

        DrawText("Infinity", lineInterval - (lineInterval / 2) - 20, Me.Height - heightBuffer - textHeightBuffer, 40, 30, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
        DrawText(highColorValue, lineInterval, Me.Height - heightBuffer - textHeightBuffer, 20, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
        DrawText(midHighColorValue, 2 * lineInterval, Me.Height - heightBuffer - textHeightBuffer, 20, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
        DrawText("0", 3 * lineInterval, Me.Height - heightBuffer - textHeightBuffer, 20, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
        DrawText(midLowColorValue, 4 * lineInterval, Me.Height - heightBuffer - textHeightBuffer, 20, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
        DrawText(lowColorValue, 5 * lineInterval, Me.Height - heightBuffer - textHeightBuffer, 20, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
        DrawText("-Infinity", 5 * lineInterval + (lineInterval / 2) - 20, Me.Height - heightBuffer - textHeightBuffer, 40, 30, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)

    End Sub

    Public Function DrawData_PreviousNeuronCalculation(ByVal formWidth As Integer, ByVal formHeight As Integer, ByVal startRowsDown As Integer, ByVal textColor As Color, ByVal boxColor As Color) As Integer
        Dim sPrevCalcData As String = "No Calculations Performed Yet."
        Dim sPrevCalcDataRows As Integer = 2

        If Not ANN.previousCalcNeuron Is Nothing Then
            sPrevCalcData = "Calculated Neuron: " & ANN.previousCalcNeuron.ID & " = " & ANN.previousCalcNeuron.value & vbCrLf

            For i As Integer = 0 To ANN.previousCalcNeuron.belowDendrites.Count - 1
                sPrevCalcData += "(" & Math.Round(ANN.previousCalcNeuron.belowDendrites(i).value, 3) & " * " & ANN.previousCalcNeuron.belowDendrites(i).neuronBelow.value & ")"
                If (i + 1) Mod 2 = 0 Then
                    sPrevCalcData += vbCrLf
                    sPrevCalcDataRows += 1
                End If

                If i < ANN.previousCalcNeuron.belowDendrites.Count - 1 Then
                    sPrevCalcData += vbTab & " + "
                End If
            Next
        Else

        End If

        DrawText(sPrevCalcData, formWidth - ANNInfoWidth, startRowsDown * textRowHeightPixels, ANNInfoWidth - 20, formHeight, FontSize.fontSize10, textColor, DrawTextFormat.Left)
        DrawSquare(formWidth - (ANNInfoWidth + 5), startRowsDown * textRowHeightPixels - 5, ANNInfoWidth - 15, sPrevCalcDataRows * textRowHeightPixels, boxColor)

        Return startRowsDown + sPrevCalcDataRows + 1

    End Function

    Public Function DrawData_TextOutputWindowHistory(ByVal formWidth As Integer, ByVal formHeight As Integer, ByVal startRowsDown As Integer, ByVal textColor As Color, ByVal textColor2 As Color, ByVal boxColor As Color) As Integer
        Dim s1 As String = ""
        Dim s2 As String = ""
        Dim rowsDown As Integer = 0

        s1 = textOutputWindowHistory(0)
        rowsDown += 1

        For i As Integer = 1 To 9
            s2 += textOutputWindowHistory(i) & vbCrLf
            rowsDown += 1
        Next

        DrawText(s1, formWidth - ANNInfoWidth, startRowsDown * textRowHeightPixels, ANNInfoWidth - 20, formHeight, FontSize.fontSize10, textColor2, DrawTextFormat.Left)
        DrawText(s2, formWidth - ANNInfoWidth, (startRowsDown + 1) * textRowHeightPixels, ANNInfoWidth - 20, formHeight, FontSize.fontSize10, textColor, DrawTextFormat.Left)
        DrawSquare(formWidth - (ANNInfoWidth + 5), startRowsDown * textRowHeightPixels - 5, ANNInfoWidth - 15, rowsDown * textRowHeightPixels, boxColor)

        Return startRowsDown + rowsDown + 1

    End Function

    Public Sub TextOutputWindowHistory_Add(ByVal s As String)

        For i As Integer = 9 To 1 Step -1
            textOutputWindowHistory(i) = textOutputWindowHistory(i - 1)
        Next

        textOutputWindowHistory(0) = s

    End Sub

    Public Function DrawData_HighlightedNeuronInfo(ByVal formWidth As Integer, ByVal formHeight As Integer, ByVal startRowsDown As Integer, ByVal textColor As Color, ByVal boxColor As Color) As Integer


        DrawText(highlightedNeuron, formWidth - ANNInfoWidth, startRowsDown * textRowHeightPixels, ANNInfoWidth - 20, formHeight, FontSize.fontSize10, textColor, DrawTextFormat.Left)
        DrawSquare(formWidth - (ANNInfoWidth + 5), startRowsDown * textRowHeightPixels - 5, ANNInfoWidth - 15, 4 * textRowHeightPixels, boxColor)

        'This text box should always be 3 rows down
        Return startRowsDown + 4 + 1

    End Function

    Public Function DrawData_ANNInfo(ByVal formWidth As Integer, ByVal formHeight As Integer, ByVal startRowsDown As Integer, ByVal textColor As Color, ByVal boxColor As Color) As Integer
        Dim s As String = ""
        Dim rowCount As Integer = 6

        s = "Structure: " & ANN.countInputNeurons(False) & "-"
        For i As Integer = 0 To ANN.countHiddenLayers - 1
            s += ANN.countHiddenNeurons(False) & "-"
        Next
        s += ANN.countOutputNeurons & vbCrLf

        s += "Total Neurons: " & ANN.countTotalNeurons(True) & vbCrLf

        s += "Weight Total: " & ANN.getWeightTotal & vbCrLf

        s += "Max Weight: " & ANN.getMaxWeightValue & vbCrLf

        s += "Min Weight: " & ANN.getMinWeightValue & vbCrLf

        s += "# Zero Weighs: " & ANN.getCountZeroWeights(0.001)

        DrawText(s, formWidth - ANNInfoWidth, startRowsDown * textRowHeightPixels, ANNInfoWidth - 20, formHeight, FontSize.fontSize10, textColor, DrawTextFormat.Left)
        DrawSquare(formWidth - (ANNInfoWidth + 5), startRowsDown * textRowHeightPixels - 5, ANNInfoWidth - 15, rowCount * textRowHeightPixels, boxColor)

        'This text box should always be 3 rows down
        Return startRowsDown + rowCount + 1

    End Function

    Public Sub drawWeightLinks(ByVal NP As Network_Points, ByVal ANN As ANN_Network.Network)
        For i As Integer = 0 To ANN.countInputNeurons(False)
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                If isMouseOverPoint(NP.inputHiddenWeightLinks(i, k).startNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).startNeuronPoint.y, 2 * NP.neuronRadius) Or isMouseOverPoint(NP.inputHiddenWeightLinks(i, k).endNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).endNeuronPoint.y, 2 * NP.neuronRadius) Then
                    DrawLine(NP.inputHiddenWeightLinks(i, k).startNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).startNeuronPoint.y, NP.inputHiddenWeightLinks(i, k).endNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).endNeuronPoint.y, selectedColor)
                Else
                    DrawLine(NP.inputHiddenWeightLinks(i, k).startNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).startNeuronPoint.y, NP.inputHiddenWeightLinks(i, k).endNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).endNeuronPoint.y, getWeightLinkColor(NP.inputHiddenWeightLinks(i, k).weight))
                End If
            Next
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '
        '############   Hidden to Hidden not yet implemented #############
        '
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For i As Integer = 0 To ANN.countHiddenLayers - 2
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                For l As Integer = 0 To ANN.countHiddenNeurons(False)
                    If isMouseOverPoint(NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.y, 2 * NP.neuronRadius) Or isMouseOverPoint(NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.y, 2 * NP.neuronRadius) Then
                        DrawLine(NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.y, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.y, selectedColor)
                    Else
                        DrawLine(NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.y, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.y, getWeightLinkColor(NP.hiddenHiddenWeightLinks(i, k, l).weight))
                    End If
                Next
            Next
        Next

        For i As Integer = 0 To ANN.countHiddenNeurons(False)
            For k As Integer = 0 To ANN.countOutputNeurons - 1
                If isMouseOverPoint(NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.y, 2 * NP.neuronRadius) Or isMouseOverPoint(NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.y, 2 * NP.neuronRadius) Then
                    DrawLine(NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.y, NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.y, selectedColor)
                Else
                    DrawLine(NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.y, NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.y, getWeightLinkColor(NP.hiddenOutputWeightLinks(i, k).weight))
                End If
            Next
        Next

    End Sub

    Public Sub drawNeurons(ByVal NP As Network_Points, ByVal ANN As ANN_Network.Network, ByVal maxRadius As Integer)
        For i As Integer = 0 To ANN.countInputNeurons(False)
            If isMouseOverPoint(NP.inputLayer(i).x, NP.inputLayer(i).y, 2 * NP.neuronRadius) Then
                DrawCircle(NP.inputLayer(i).x, NP.inputLayer(i).y, NP.neuronRadius, 30, selectedColor)

                'BEGIN - Stuff for Highlighted Neuron Info Box
                highlightedNeuron = "Neuron ID: " & NP.inputLayer(i).id & vbCrLf & "Neuron Type: "
                If NP.inputLayer(i).type = 1 Then
                    highlightedNeuron += "Input Neuron" & vbCrLf
                ElseIf NP.inputLayer(i).type = 2 Then
                    highlightedNeuron += "Hidden Neuron" & vbCrLf
                ElseIf NP.inputLayer(i).type = 3 Then
                    highlightedNeuron += "Output Neuron" & vbCrLf
                ElseIf NP.inputLayer(i).type = 4 Then
                    highlightedNeuron += "Bias Neuron" & vbCrLf
                End If
                highlightedNeuron += "Neuron Value: " & NP.inputLayer(i).value
                'END - Stuff for Highlighted Neuron Info Box

            Else
                DrawCircle(NP.inputLayer(i).x, NP.inputLayer(i).y, NP.neuronRadius, 30, NP.inputLayer(i).color)
            End If

            DrawText(NP.inputLayer(i).value.ToString, NP.inputLayer(i).x - (NP.inputLayer(i).value.ToString.Length * 4), NP.inputLayer(i).y - 8, NP.inputLayer(i).value.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
        Next

        For i As Integer = 0 To ANN.countHiddenLayers - 1
            For k As Integer = 0 To ANN.countHiddenNeurons(False)
                If isMouseOverPoint(NP.hiddenLayer(i, k).x, NP.hiddenLayer(i, k).y, 2 * NP.neuronRadius) Then
                    DrawCircle(NP.hiddenLayer(i, k).x, NP.hiddenLayer(i, k).y, NP.neuronRadius, 30, selectedColor)

                    'BEGIN - Stuff for Highlighted Neuron Info Box
                    highlightedNeuron = "Neuron ID: " & NP.hiddenLayer(i, k).id & vbCrLf & "Neuron Type: "
                    If NP.hiddenLayer(i, k).type = 1 Then
                        highlightedNeuron += "Input Neuron" & vbCrLf
                    ElseIf NP.hiddenLayer(i, k).type = 2 Then
                        highlightedNeuron += "Hidden Neuron" & vbCrLf
                    ElseIf NP.hiddenLayer(i, k).type = 3 Then
                        highlightedNeuron += "Output Neuron" & vbCrLf
                    ElseIf NP.hiddenLayer(i, k).type = 4 Then
                        highlightedNeuron += "Bias Neuron" & vbCrLf
                    End If
                    highlightedNeuron += "Neuron Value: " & NP.hiddenLayer(i, k).value
                    'END - Stuff for Highlighted Neuron Info Box

                Else
                    DrawCircle(NP.hiddenLayer(i, k).x, NP.hiddenLayer(i, k).y, NP.neuronRadius, 30, NP.hiddenLayer(i, k).color)
                End If
                If NP.hiddenLayer(i, k).value.ToString.Length > 6 Then
                    DrawText(NP.hiddenLayer(i, k).value.ToString.Substring(0, 6), NP.hiddenLayer(i, k).x - (NP.hiddenLayer(i, k).value.ToString.Length * 4), NP.hiddenLayer(i, k).y - 8, NP.hiddenLayer(i, k).value.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                Else
                    DrawText(NP.hiddenLayer(i, k).value.ToString, NP.hiddenLayer(i, k).x - (NP.hiddenLayer(i, k).value.ToString.Length * 4), NP.hiddenLayer(i, k).y - 8, NP.hiddenLayer(i, k).value.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                End If
            Next
        Next

        For i As Integer = 0 To ANN.countOutputNeurons - 1
            If isMouseOverPoint(NP.outputLayer(i).x, NP.outputLayer(i).y, 2 * NP.neuronRadius) Then
                DrawCircle(NP.outputLayer(i).x, NP.outputLayer(i).y, NP.neuronRadius, 30, selectedColor)

                'BEGIN - Stuff for Highlighted Neuron Info Box
                highlightedNeuron = "Neuron ID: " & NP.outputLayer(i).id & vbCrLf & "Neuron Type: "
                If NP.outputLayer(i).type = 1 Then
                    highlightedNeuron += "Input Neuron" & vbCrLf
                ElseIf NP.outputLayer(i).type = 2 Then
                    highlightedNeuron += "Hidden Neuron" & vbCrLf
                ElseIf NP.outputLayer(i).type = 3 Then
                    highlightedNeuron += "Output Neuron" & vbCrLf
                ElseIf NP.outputLayer(i).type = 4 Then
                    highlightedNeuron += "Bias Neuron" & vbCrLf
                End If
                highlightedNeuron += "Neuron Value: " & NP.outputLayer(i).value
                'END - Stuff for Highlighted Neuron Info Box

            Else
                DrawCircle(NP.outputLayer(i).x, NP.outputLayer(i).y, NP.neuronRadius, 30, NP.outputLayer(i).color)
            End If
            DrawText(NP.outputLayer(i).value.ToString, NP.outputLayer(i).x - (NP.outputLayer(i).value.ToString.Length * 4), NP.outputLayer(i).y - 8, NP.outputLayer(i).value.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
        Next

    End Sub

    Public Sub drawWeightValues(ByVal NP As Network_Points, ByVal ANN As ANN_Network.Network)
        'Draw Weight Values For Hidden-Output weights
        For i As Integer = 0 To ANN.countHiddenNeurons(False)
            For k As Integer = 0 To ANN.countOutputNeurons - 1
                If isMouseOverPoint(NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).startNeuronPoint.y, 2 * NP.neuronRadius) Then
                    DrawCircle(NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countOutputNeurons + 2)) * 100).x, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countOutputNeurons + 2)) * 100).y, 5, 10, selectedColor)
                    If NP.hiddenOutputWeightLinks(i, k).weight.ToString.Length > 7 Then
                        DrawText(" " & NP.hiddenOutputWeightLinks(i, k).weight.ToString.Substring(0, 6), NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countOutputNeurons + 2)) * 100).x + 5, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countOutputNeurons + 2)) * 100).y - 8, NP.hiddenOutputWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
                    Else
                        DrawText(NP.hiddenOutputWeightLinks(i, k).weight.ToString, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countOutputNeurons + 2)) * 100).x + 5, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countOutputNeurons + 2)) * 100).y - 8, NP.hiddenOutputWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                    End If
                End If
            Next
        Next

        For i As Integer = 0 To ANN.countHiddenNeurons(False)
            For k As Integer = 0 To ANN.countOutputNeurons - 1
                If isMouseOverPoint(NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.x, NP.hiddenOutputWeightLinks(i, k).endNeuronPoint.y, 2 * NP.neuronRadius) Then
                    DrawCircle(NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y, 5, 10, selectedColor)
                    If NP.hiddenOutputWeightLinks(i, k).weight.ToString.Length > 6 Then
                        DrawText(" " & NP.hiddenOutputWeightLinks(i, k).weight.ToString.Substring(0, 6), NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.hiddenOutputWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
                    Else
                        DrawText(NP.hiddenOutputWeightLinks(i, k).weight.ToString, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.hiddenOutputWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.hiddenOutputWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                    End If
                End If
            Next
        Next


        'Draw weight values for hidden-hidden weights
        For i As Integer = 0 To ANN.countHiddenLayers - 2
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                For l As Integer = 0 To ANN.countHiddenNeurons(False)
                    If isMouseOverPoint(NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.y, 2 * NP.neuronRadius) Then
                        DrawCircle(NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((l + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((l + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y, 5, 10, selectedColor)
                        If NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Length > 6 Then
                            DrawText(" " & NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Substring(0, 6), NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((l + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((l + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
                        Else
                            DrawText(NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((l + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((l + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                        End If
                        'DrawLine(NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.y, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.y, Drawing.Color.Yellow)
                    End If
                Next
            Next
        Next

        For i As Integer = 0 To ANN.countHiddenLayers - 2
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                For l As Integer = 0 To ANN.countHiddenNeurons(False)
                    If isMouseOverPoint(NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.y, 2 * NP.neuronRadius) Then
                        DrawCircle(NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y, 5, 10, selectedColor)
                        If NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Length > 6 Then
                            DrawText(" " & NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Substring(0, 6), NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
                        Else
                            DrawText(NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.hiddenHiddenWeightLinks(i, k, l).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.hiddenHiddenWeightLinks(i, k, l).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                        End If
                        'DrawLine(NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).startNeuronPoint.y, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.x, NP.hiddenHiddenWeightLinks(i, k, l).endNeuronPoint.y, Drawing.Color.Yellow)
                    End If
                Next
            Next
        Next


        'Draw weight values for input-hidden weights
        For i As Integer = 0 To ANN.countInputNeurons(False)
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                If isMouseOverPoint(NP.inputHiddenWeightLinks(i, k).endNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).endNeuronPoint.y, 2 * NP.neuronRadius) Then
                    DrawCircle(NP.inputHiddenWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countInputNeurons(False) + 2)) * 100).x, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countInputNeurons(False) + 2)) * 100).y, 5, 10, selectedColor)
                    If NP.inputHiddenWeightLinks(i, k).weight.ToString.Length > 6 Then
                        DrawText(" " & NP.inputHiddenWeightLinks(i, k).weight.ToString.Substring(0, 6), NP.inputHiddenWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countInputNeurons(False) + 2)) * 100).x + 5, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countInputNeurons(False) + 2)) * 100).y - 8, NP.inputHiddenWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
                    Else
                        DrawText(NP.inputHiddenWeightLinks(i, k).weight.ToString, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countInputNeurons(False) + 2)) * 100).x + 5, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((i + 1) / (ANN.countInputNeurons(False) + 2)) * 100).y - 8, NP.inputHiddenWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                    End If
                End If
            Next
        Next

        For i As Integer = 0 To ANN.countInputNeurons(False)
            For k As Integer = 0 To ANN.countHiddenNeurons(False) - 1
                If isMouseOverPoint(NP.inputHiddenWeightLinks(i, k).startNeuronPoint.x, NP.inputHiddenWeightLinks(i, k).startNeuronPoint.y, 2 * NP.neuronRadius) Then
                    DrawCircle(NP.inputHiddenWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y, 5, 10, selectedColor)
                    If NP.inputHiddenWeightLinks(i, k).weight.ToString.Length > 6 Then
                        DrawText(" " & NP.inputHiddenWeightLinks(i, k).weight.ToString.Substring(0, 6), NP.inputHiddenWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.inputHiddenWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor, DrawTextFormat.Left)
                    Else
                        DrawText(NP.inputHiddenWeightLinks(i, k).weight.ToString, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).x + 5, NP.inputHiddenWeightLinks(i, k).getPointOnLine(((k + 1) / (ANN.countHiddenNeurons(False) + 2)) * 100).y - 8, NP.inputHiddenWeightLinks(i, k).weight.ToString.Length * 8, 20, FontSize.fontSize10, foregroundColor)
                    End If
                End If
            Next
        Next

    End Sub

    Public Function getWeightLinkColor(ByVal weight As Double) As Color
        Dim tempColor As Color = Drawing.Color.White

        If weight >= highColorValue Then
            tempColor = highColor
        ElseIf weight < highColorValue And weight >= midHighColorValue Then
            tempColor = calculateWeightedColorGradient(highColor, midHighColor, highColorValue, midHighColorValue, weight)
        ElseIf weight < midHighColorValue And weight > 0.0001 Then
            tempColor = calculateWeightedColorGradient(midHighColor, zeroColor, midHighColorValue, 0.0001, weight)
        ElseIf weight <= 0.0001 And weight > -0.0001 Then
            tempColor = Drawing.Color.Black
        ElseIf weight <= -0.0001 And weight > midLowColorValue Then
            tempColor = calculateWeightedColorGradient(zeroColor, midLowColor, 0.0001, midLowColorValue, weight)
        ElseIf weight <= midLowColorValue And weight > lowColorValue Then
            tempColor = calculateWeightedColorGradient(midLowColor, lowColor, midLowColorValue, lowColorValue, weight)
        ElseIf weight <= lowColorValue Then
            tempColor = lowColor
        Else
            'MsgBox("Error - Class: Form1, Method: getWeightLinkColor, Desc: Error calculating color value for weight, no color selected. Investigate If-Block logic.")
            Throw New Exception("Error - Class: Form1, Method: getWeightLinkColor, Desc: Error calculating color value for weight, no color selected. Investigate If-Block logic.")
        End If

        Return tempColor
    End Function

    Public Function calculateWeightedColorGradient(ByVal highColor As Color, ByVal lowColor As Color, ByVal highValue As Double, ByVal lowValue As Double, ByVal value As Double) As Color
        Dim rPrime1, bPrime1, gPrime1, rPrime2, bPrime2, gPrime2, q, m, n As Double
        Dim tempColor As New Color

        rPrime1 = Convert.ToInt32(highColor.R) - Convert.ToInt32(lowColor.R)
        bPrime1 = Convert.ToInt32(highColor.B) - Convert.ToInt32(lowColor.B)
        gPrime1 = Convert.ToInt32(highColor.G) - Convert.ToInt32(lowColor.G)
        q = highValue - lowValue
        m = value - lowValue
        n = m / q
        rPrime2 = n * rPrime1
        bPrime2 = n * bPrime1
        gPrime2 = n * gPrime1

        tempColor = Drawing.Color.FromArgb(lowColor.R + rPrime2, lowColor.G + gPrime2, lowColor.B + bPrime2)

        Return tempColor

    End Function

    Private Sub InputWeightsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputWeightsToolStripMenuItem.Click
        If ANN.currentCalcNeuron.Equals(ANN.Layer(1).Neuron(0)) Then
            frmSetInputValues.ShowDialog()
        Else
            frmMessage.txtMessageToUser.Text = "Cannot set/change the input neuron values while in the middle of a network calculation. Please either finish calculating your current network, or click the 'Reset Network' button to change the input neuron values"
            frmMessage.ShowDialog()
        End If
    End Sub

    Private Sub CalculateAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateAllToolStripMenuItem.Click
        If ANN.currentCalcNeuron.Equals(ANN.Layer(1).Neuron(0)) Then
            frmSetWeights.setANN(ANN)
            frmSetWeights.ShowDialog()
        Else
            frmMessage.txtMessageToUser.Text = "Cannot set/change weight values while in the middle of a network calculation. Please either finish calculating your current network, or click the 'Reset Network' button to change the input neuron values"
            frmMessage.ShowDialog()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CalculateNextNodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateNextNodeToolStripMenuItem.Click
        TextOutputWindowHistory_Add("Calculated Node: " & ANN.currentCalcNeuron.ID)
        ANN.calculateNextNeuron()

        If ANN.previousCalcNeuron Is Nothing Then
            TextOutputWindowHistory_Add("Network Calculation Complete!")
        End If
    End Sub

    Private Sub CalculateNextLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateNextLevelToolStripMenuItem.Click
        ANN.calculateNextLayer()
        TextOutputWindowHistory_Add("Calculated Neural Layer")
        If ANN.previousCalcNeuron Is Nothing Then
            TextOutputWindowHistory_Add("Network Calculation Complete!")
        End If
    End Sub

    Private Sub CalculateNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateNetworkToolStripMenuItem.Click
        ANN.calculateAll()
        TextOutputWindowHistory_Add("Calculated Neural Network")
        If ANN.previousCalcNeuron Is Nothing Then
            TextOutputWindowHistory_Add("Network Calculation Complete!")
        End If
    End Sub

    Private Sub ResetNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetNetworkToolStripMenuItem.Click
        TextOutputWindowHistory_Add("Reset Network")
        ANN.resetNetwork()
    End Sub

    Private Sub ModifyGUIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyGUIToolStripMenuItem.Click
        frmModifyGUI.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ExportWeightsToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportWeightsToFileToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveNetworkToolStripMenuItem.Click
        SaveFileDialog2.ShowDialog()
    End Sub

    Private Sub LoadNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadNetworkToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ANN = ANN.importNetworkFromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        ANN.exportWeightsToFile(SaveFileDialog1.FileName)
    End Sub

    Private Sub SaveFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk
        ANN.exportNetworkToFile(SaveFileDialog2.FileName)
    End Sub

    Private Sub CreateNetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNetworkToolStripMenuItem.Click
        frmCreateNetwork.ShowDialog()
    End Sub

    Public Sub LoadGUIValues()

        Dim sr As StreamReader
        Dim line As String

        Try
            sr = File.OpenText("ANN_Viewer.ini")

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                backgroundColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                backgroundColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                backgroundColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                backgroundColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                backgroundColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                backgroundColor = Drawing.Color.Yellow
            End If


            line = sr.ReadLine()
            If InStr(line, "Black") Then
                foregroundColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                foregroundColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                foregroundColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                foregroundColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                foregroundColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                foregroundColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                neuronColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                neuronColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                neuronColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                neuronColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                neuronColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                neuronColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                biasNeuronColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                biasNeuronColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                biasNeuronColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                biasNeuronColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                biasNeuronColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                biasNeuronColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                selectedColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                selectedColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                selectedColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                selectedColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                selectedColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                selectedColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                calculatedColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                calculatedColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                calculatedColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                calculatedColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                calculatedColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                calculatedColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                highColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                highColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                highColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                highColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                highColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                highColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                midHighColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                midHighColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                midHighColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                midHighColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                midHighColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                midHighColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                zeroColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                zeroColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                zeroColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                zeroColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                zeroColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                zeroColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                midLowColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                midLowColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                midLowColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                midLowColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                midLowColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                midLowColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine()
            If InStr(line, "Black") Then
                lowColor = Drawing.Color.Black
            ElseIf InStr(line, "White") Then
                lowColor = Drawing.Color.White
            ElseIf InStr(line, "Red") Then
                lowColor = Drawing.Color.Red
            ElseIf InStr(line, "Blue") Then
                lowColor = Drawing.Color.Blue
            ElseIf InStr(line, "Lime") Then
                lowColor = Drawing.Color.Lime
            ElseIf InStr(line, "Yellow") Then
                lowColor = Drawing.Color.Yellow
            End If

            line = sr.ReadLine
            highColorValue = Convert.ToDouble(line)

            line = sr.ReadLine()
            midHighColorValue = Convert.ToDouble(line)

            line = sr.ReadLine
            midLowColorValue = Convert.ToDouble(line)

            line = sr.ReadLine
            lowColorValue = Convert.ToDouble(line)

            line = sr.ReadLine
            ANNInfoWidth = Convert.ToDouble(line)

            line = sr.ReadLine
            If line = "True" Then
                showHoverNeuronInfoBlock = True
            Else
                showHoverNeuronInfoBlock = False
            End If

            line = sr.ReadLine
            If line = "True" Then
                showCalculatedNeuronInfoBlock = True
            Else
                showCalculatedNeuronInfoBlock = False
            End If

            line = sr.ReadLine
            If line = "True" Then
                showActionHistoryBlock = True
            Else
                showActionHistoryBlock = False
            End If

            line = sr.ReadLine
            If line = "True" Then
                showNetworkInfoBlock = True
            Else
                showNetworkInfoBlock = False
            End If

            line = sr.ReadLine
            If line = "True" Then
                showWeightLinkLegend = True
            Else
                showWeightLinkLegend = False
            End If

            sr.Close()

        Catch ex As Exception
            frmMessage.txtErrorMessage.Text = ex.Message
            frmMessage.txtMessageToUser.Text = "Error Loading Initialization Values - ANN_Viewer.ini file is corrupt or not found. Resetting values to their defaults and creating new default initialization file."


            If Not sr Is Nothing Then
                sr.Close()
            End If

            ResetGUIValues()

            If Not frmMessage.Visible = True Then
                frmMessage.ShowDialog()
            End If

        End Try

    End Sub


    Public Sub ResetGUIValues()
        backgroundColor = Drawing.Color.Black
        foregroundColor = Drawing.Color.White
        neuronColor = Drawing.Color.Red
        biasNeuronColor = Drawing.Color.Blue
        selectedColor = Drawing.Color.Yellow
        calculatedColor = Drawing.Color.Lime
        highColor = Drawing.Color.White
        midHighColor = Drawing.Color.Lime
        zeroColor = Drawing.Color.Black
        midLowColor = Drawing.Color.Red
        lowColor = Drawing.Color.Blue
        midHighColorValue = 5
        midLowColorValue = -5
        highColorValue = 20
        lowColorValue = -20
        ANNInfoWidth = 200
        showHoverNeuronInfoBlock = True
        showCalculatedNeuronInfoBlock = True
        showActionHistoryBlock = True
        showNetworkInfoBlock = True
        showWeightLinkLegend = True

        SaveGUIValues()
    End Sub

    Public Sub SaveGUIValues()
        Dim sw As StreamWriter = File.CreateText("ANN_Viewer.ini")

        sw.WriteLine(backgroundColor.ToString)
        sw.WriteLine(foregroundColor.ToString)
        sw.WriteLine(neuronColor.ToString)
        sw.WriteLine(biasNeuronColor.ToString)
        sw.WriteLine(selectedColor.ToString)
        sw.WriteLine(calculatedColor.ToString)
        sw.WriteLine(highColor.ToString)
        sw.WriteLine(midHighColor.ToString)
        sw.WriteLine(zeroColor.ToString)
        sw.WriteLine(midLowColor.ToString)
        sw.WriteLine(lowColor.ToString)
        sw.WriteLine(highColorValue.ToString)
        sw.WriteLine(midHighColorValue.ToString)
        sw.WriteLine(midLowColorValue.ToString)
        sw.WriteLine(lowColorValue.ToString)
        sw.WriteLine(ANNInfoWidth.ToString)
        sw.WriteLine(showHoverNeuronInfoBlock.ToString)
        sw.WriteLine(showCalculatedNeuronInfoBlock.ToString)
        sw.WriteLine(showActionHistoryBlock.ToString)
        sw.WriteLine(showNetworkInfoBlock.ToString)
        sw.WriteLine(showWeightLinkLegend.ToString)

        sw.Close()

    End Sub

End Class


