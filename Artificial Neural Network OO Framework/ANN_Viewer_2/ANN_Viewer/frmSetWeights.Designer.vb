<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetWeights
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtWeightsFilePath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWeightsContents = New System.Windows.Forms.TextBox
        Me.btnSetWeightsToNetwork = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcountWeightsNeeded = New System.Windows.Forms.TextBox
        Me.txtcountWeightsInputted = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Find File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtWeightsFilePath
        '
        Me.txtWeightsFilePath.Location = New System.Drawing.Point(86, 14)
        Me.txtWeightsFilePath.Name = "txtWeightsFilePath"
        Me.txtWeightsFilePath.Size = New System.Drawing.Size(309, 20)
        Me.txtWeightsFilePath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Weights File:"
        '
        'txtWeightsContents
        '
        Me.txtWeightsContents.Location = New System.Drawing.Point(12, 77)
        Me.txtWeightsContents.Multiline = True
        Me.txtWeightsContents.Name = "txtWeightsContents"
        Me.txtWeightsContents.ReadOnly = True
        Me.txtWeightsContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWeightsContents.Size = New System.Drawing.Size(464, 194)
        Me.txtWeightsContents.TabIndex = 3
        '
        'btnSetWeightsToNetwork
        '
        Me.btnSetWeightsToNetwork.Location = New System.Drawing.Point(160, 280)
        Me.btnSetWeightsToNetwork.Name = "btnSetWeightsToNetwork"
        Me.btnSetWeightsToNetwork.Size = New System.Drawing.Size(149, 23)
        Me.btnSetWeightsToNetwork.TabIndex = 4
        Me.btnSetWeightsToNetwork.Text = "Set Weights To Network"
        Me.btnSetWeightsToNetwork.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contents of Weights File:"
        '
        'txtcountWeightsNeeded
        '
        Me.txtcountWeightsNeeded.Location = New System.Drawing.Point(423, 303)
        Me.txtcountWeightsNeeded.Name = "txtcountWeightsNeeded"
        Me.txtcountWeightsNeeded.ReadOnly = True
        Me.txtcountWeightsNeeded.Size = New System.Drawing.Size(32, 20)
        Me.txtcountWeightsNeeded.TabIndex = 8
        Me.txtcountWeightsNeeded.Text = "0"
        '
        'txtcountWeightsInputted
        '
        Me.txtcountWeightsInputted.Location = New System.Drawing.Point(422, 277)
        Me.txtcountWeightsInputted.Name = "txtcountWeightsInputted"
        Me.txtcountWeightsInputted.ReadOnly = True
        Me.txtcountWeightsInputted.Size = New System.Drawing.Size(33, 20)
        Me.txtcountWeightsInputted.TabIndex = 7
        Me.txtcountWeightsInputted.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Weights Inputted:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(325, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Weights Needed"
        '
        'frmSetWeights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 331)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcountWeightsNeeded)
        Me.Controls.Add(Me.txtcountWeightsInputted)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSetWeightsToNetwork)
        Me.Controls.Add(Me.txtWeightsContents)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWeightsFilePath)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSetWeights"
        Me.Text = "SetWeights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtWeightsFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeightsContents As System.Windows.Forms.TextBox
    Friend WithEvents btnSetWeightsToNetwork As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcountWeightsNeeded As System.Windows.Forms.TextBox
    Friend WithEvents txtcountWeightsInputted As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
