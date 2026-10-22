<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtMainLog = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LearningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeginLearningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RunNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateInputDatasetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadInputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.btnLoadTrainingData = New System.Windows.Forms.Button
        Me.btnBeginLearning = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblWeightsSum = New System.Windows.Forms.Label
        Me.lblEpoch = New System.Windows.Forms.Label
        Me.lblZeroWeights = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.lblMaxWeight = New System.Windows.Forms.Label
        Me.lblMinWeight = New System.Windows.Forms.Label
        Me.rdoLearnToEpoch = New System.Windows.Forms.RadioButton
        Me.rdoLearnToError = New System.Windows.Forms.RadioButton
        Me.txtLearnToEpoch = New System.Windows.Forms.TextBox
        Me.txtLearnToError = New System.Windows.Forms.TextBox
        Me.btnExportNetwork = New System.Windows.Forms.Button
        Me.btnRunNetwork = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.txtRowDisplayCount = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRho = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMainLog
        '
        Me.txtMainLog.Location = New System.Drawing.Point(12, 85)
        Me.txtMainLog.Multiline = True
        Me.txtMainLog.Name = "txtMainLog"
        Me.txtMainLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMainLog.Size = New System.Drawing.Size(324, 327)
        Me.txtMainLog.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LearningToolStripMenuItem, Me.TrainingDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(522, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'LearningToolStripMenuItem
        '
        Me.LearningToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeginLearningToolStripMenuItem, Me.ExportNetworkToolStripMenuItem, Me.RunNetworkToolStripMenuItem})
        Me.LearningToolStripMenuItem.Name = "LearningToolStripMenuItem"
        Me.LearningToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.LearningToolStripMenuItem.Text = "&Learning"
        '
        'BeginLearningToolStripMenuItem
        '
        Me.BeginLearningToolStripMenuItem.Name = "BeginLearningToolStripMenuItem"
        Me.BeginLearningToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BeginLearningToolStripMenuItem.Text = "&Begin Learning"
        '
        'ExportNetworkToolStripMenuItem
        '
        Me.ExportNetworkToolStripMenuItem.Name = "ExportNetworkToolStripMenuItem"
        Me.ExportNetworkToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExportNetworkToolStripMenuItem.Text = "&Export Network"
        '
        'RunNetworkToolStripMenuItem
        '
        Me.RunNetworkToolStripMenuItem.Name = "RunNetworkToolStripMenuItem"
        Me.RunNetworkToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RunNetworkToolStripMenuItem.Text = "&Run Network"
        '
        'TrainingDataToolStripMenuItem
        '
        Me.TrainingDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateInputDatasetToolStripMenuItem, Me.LoadInputDataToolStripMenuItem})
        Me.TrainingDataToolStripMenuItem.Name = "TrainingDataToolStripMenuItem"
        Me.TrainingDataToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.TrainingDataToolStripMenuItem.Text = "&Training Data"
        '
        'CreateInputDatasetToolStripMenuItem
        '
        Me.CreateInputDatasetToolStripMenuItem.Name = "CreateInputDatasetToolStripMenuItem"
        Me.CreateInputDatasetToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CreateInputDatasetToolStripMenuItem.Text = "&Create Input Dataset"
        '
        'LoadInputDataToolStripMenuItem
        '
        Me.LoadInputDataToolStripMenuItem.Name = "LoadInputDataToolStripMenuItem"
        Me.LoadInputDataToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LoadInputDataToolStripMenuItem.Text = "&Load Input Data"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(522, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnLoadTrainingData
        '
        Me.btnLoadTrainingData.Location = New System.Drawing.Point(12, 27)
        Me.btnLoadTrainingData.Name = "btnLoadTrainingData"
        Me.btnLoadTrainingData.Size = New System.Drawing.Size(125, 23)
        Me.btnLoadTrainingData.TabIndex = 3
        Me.btnLoadTrainingData.Text = "Load Training Data"
        Me.btnLoadTrainingData.UseVisualStyleBackColor = True
        '
        'btnBeginLearning
        '
        Me.btnBeginLearning.Enabled = False
        Me.btnBeginLearning.Location = New System.Drawing.Point(12, 56)
        Me.btnBeginLearning.Name = "btnBeginLearning"
        Me.btnBeginLearning.Size = New System.Drawing.Size(125, 23)
        Me.btnBeginLearning.TabIndex = 4
        Me.btnBeginLearning.Text = "Begin Learning"
        Me.btnBeginLearning.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblWeightsSum)
        Me.GroupBox1.Controls.Add(Me.lblEpoch)
        Me.GroupBox1.Controls.Add(Me.lblZeroWeights)
        Me.GroupBox1.Controls.Add(Me.lblError)
        Me.GroupBox1.Controls.Add(Me.lblMaxWeight)
        Me.GroupBox1.Controls.Add(Me.lblMinWeight)
        Me.GroupBox1.Location = New System.Drawing.Point(342, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backprop Learning Data"
        '
        'lblWeightsSum
        '
        Me.lblWeightsSum.AutoSize = True
        Me.lblWeightsSum.Location = New System.Drawing.Point(6, 58)
        Me.lblWeightsSum.Name = "lblWeightsSum"
        Me.lblWeightsSum.Size = New System.Drawing.Size(73, 13)
        Me.lblWeightsSum.TabIndex = 15
        Me.lblWeightsSum.Text = "Weights Sum:"
        '
        'lblEpoch
        '
        Me.lblEpoch.AutoSize = True
        Me.lblEpoch.Location = New System.Drawing.Point(6, 36)
        Me.lblEpoch.Name = "lblEpoch"
        Me.lblEpoch.Size = New System.Drawing.Size(41, 13)
        Me.lblEpoch.TabIndex = 11
        Me.lblEpoch.Text = "Epoch:"
        '
        'lblZeroWeights
        '
        Me.lblZeroWeights.AutoSize = True
        Me.lblZeroWeights.Location = New System.Drawing.Point(6, 81)
        Me.lblZeroWeights.Name = "lblZeroWeights"
        Me.lblZeroWeights.Size = New System.Drawing.Size(77, 13)
        Me.lblZeroWeights.TabIndex = 14
        Me.lblZeroWeights.Text = "Zero Weights: "
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(6, 16)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(32, 13)
        Me.lblError.TabIndex = 10
        Me.lblError.Text = "Error:"
        '
        'lblMaxWeight
        '
        Me.lblMaxWeight.AutoSize = True
        Me.lblMaxWeight.Location = New System.Drawing.Point(6, 104)
        Me.lblMaxWeight.Name = "lblMaxWeight"
        Me.lblMaxWeight.Size = New System.Drawing.Size(67, 13)
        Me.lblMaxWeight.TabIndex = 13
        Me.lblMaxWeight.Text = "Max Weight:"
        '
        'lblMinWeight
        '
        Me.lblMinWeight.AutoSize = True
        Me.lblMinWeight.Location = New System.Drawing.Point(6, 126)
        Me.lblMinWeight.Name = "lblMinWeight"
        Me.lblMinWeight.Size = New System.Drawing.Size(67, 13)
        Me.lblMinWeight.TabIndex = 12
        Me.lblMinWeight.Text = "Min  Weight:"
        '
        'rdoLearnToEpoch
        '
        Me.rdoLearnToEpoch.AutoSize = True
        Me.rdoLearnToEpoch.Checked = True
        Me.rdoLearnToEpoch.Location = New System.Drawing.Point(162, 33)
        Me.rdoLearnToEpoch.Name = "rdoLearnToEpoch"
        Me.rdoLearnToEpoch.Size = New System.Drawing.Size(105, 17)
        Me.rdoLearnToEpoch.TabIndex = 6
        Me.rdoLearnToEpoch.TabStop = True
        Me.rdoLearnToEpoch.Text = "Learn To Epoch:"
        Me.rdoLearnToEpoch.UseVisualStyleBackColor = True
        '
        'rdoLearnToError
        '
        Me.rdoLearnToError.AutoSize = True
        Me.rdoLearnToError.Location = New System.Drawing.Point(162, 59)
        Me.rdoLearnToError.Name = "rdoLearnToError"
        Me.rdoLearnToError.Size = New System.Drawing.Size(96, 17)
        Me.rdoLearnToError.TabIndex = 7
        Me.rdoLearnToError.TabStop = True
        Me.rdoLearnToError.Text = "Learn To Error:"
        Me.rdoLearnToError.UseVisualStyleBackColor = True
        '
        'txtLearnToEpoch
        '
        Me.txtLearnToEpoch.Location = New System.Drawing.Point(274, 32)
        Me.txtLearnToEpoch.Name = "txtLearnToEpoch"
        Me.txtLearnToEpoch.Size = New System.Drawing.Size(62, 20)
        Me.txtLearnToEpoch.TabIndex = 8
        Me.txtLearnToEpoch.Text = "500"
        '
        'txtLearnToError
        '
        Me.txtLearnToError.Location = New System.Drawing.Point(274, 58)
        Me.txtLearnToError.Name = "txtLearnToError"
        Me.txtLearnToError.Size = New System.Drawing.Size(62, 20)
        Me.txtLearnToError.TabIndex = 9
        Me.txtLearnToError.Text = "1"
        '
        'btnExportNetwork
        '
        Me.btnExportNetwork.Location = New System.Drawing.Point(361, 27)
        Me.btnExportNetwork.Name = "btnExportNetwork"
        Me.btnExportNetwork.Size = New System.Drawing.Size(125, 23)
        Me.btnExportNetwork.TabIndex = 10
        Me.btnExportNetwork.Text = "Export Network"
        Me.btnExportNetwork.UseVisualStyleBackColor = True
        '
        'btnRunNetwork
        '
        Me.btnRunNetwork.Location = New System.Drawing.Point(361, 56)
        Me.btnRunNetwork.Name = "btnRunNetwork"
        Me.btnRunNetwork.Size = New System.Drawing.Size(125, 23)
        Me.btnRunNetwork.TabIndex = 11
        Me.btnRunNetwork.Text = "Run Network"
        Me.btnRunNetwork.UseVisualStyleBackColor = True
        '
        'txtRowDisplayCount
        '
        Me.txtRowDisplayCount.Location = New System.Drawing.Point(453, 115)
        Me.txtRowDisplayCount.Name = "txtRowDisplayCount"
        Me.txtRowDisplayCount.Size = New System.Drawing.Size(42, 20)
        Me.txtRowDisplayCount.TabIndex = 12
        Me.txtRowDisplayCount.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Data Output Interval:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Rho:"
        '
        'txtRho
        '
        Me.txtRho.Location = New System.Drawing.Point(377, 85)
        Me.txtRho.Name = "txtRho"
        Me.txtRho.Size = New System.Drawing.Size(42, 20)
        Me.txtRho.TabIndex = 14
        Me.txtRho.Text = "0.25"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 437)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRho)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRowDisplayCount)
        Me.Controls.Add(Me.btnRunNetwork)
        Me.Controls.Add(Me.btnExportNetwork)
        Me.Controls.Add(Me.txtLearnToError)
        Me.Controls.Add(Me.txtLearnToEpoch)
        Me.Controls.Add(Me.rdoLearnToError)
        Me.Controls.Add(Me.rdoLearnToEpoch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBeginLearning)
        Me.Controls.Add(Me.btnLoadTrainingData)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtMainLog)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "ANN Backprop Learner"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMainLog As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLoadTrainingData As System.Windows.Forms.Button
    Friend WithEvents btnBeginLearning As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoLearnToEpoch As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLearnToError As System.Windows.Forms.RadioButton
    Friend WithEvents txtLearnToEpoch As System.Windows.Forms.TextBox
    Friend WithEvents txtLearnToError As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblEpoch As System.Windows.Forms.Label
    Friend WithEvents lblMinWeight As System.Windows.Forms.Label
    Friend WithEvents lblMaxWeight As System.Windows.Forms.Label
    Friend WithEvents lblZeroWeights As System.Windows.Forms.Label
    Friend WithEvents lblWeightsSum As System.Windows.Forms.Label
    Friend WithEvents btnExportNetwork As System.Windows.Forms.Button
    Friend WithEvents btnRunNetwork As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtRowDisplayCount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrainingDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateInputDatasetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadInputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LearningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeginLearningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRho As System.Windows.Forms.TextBox

End Class
