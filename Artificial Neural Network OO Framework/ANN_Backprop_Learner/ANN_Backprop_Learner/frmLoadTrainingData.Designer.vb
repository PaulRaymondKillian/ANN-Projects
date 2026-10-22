<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadTrainingData
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
        Me.txtTrainingDataFilePath = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtANNFilePath = New System.Windows.Forms.TextBox
        Me.rdoUseExistingNetwork = New System.Windows.Forms.RadioButton
        Me.rdoCreateNewNetwork = New System.Windows.Forms.RadioButton
        Me.btnBrowseNetworkFile = New System.Windows.Forms.Button
        Me.btnApply = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtHiddenNeurons = New System.Windows.Forms.TextBox
        Me.txtHiddenLayers = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBrowseTrainingDataFile = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTrainingDataFilePath
        '
        Me.txtTrainingDataFilePath.Location = New System.Drawing.Point(6, 29)
        Me.txtTrainingDataFilePath.Name = "txtTrainingDataFilePath"
        Me.txtTrainingDataFilePath.Size = New System.Drawing.Size(507, 20)
        Me.txtTrainingDataFilePath.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtHiddenLayers)
        Me.GroupBox1.Controls.Add(Me.txtHiddenNeurons)
        Me.GroupBox1.Controls.Add(Me.btnBrowseNetworkFile)
        Me.GroupBox1.Controls.Add(Me.rdoCreateNewNetwork)
        Me.GroupBox1.Controls.Add(Me.rdoUseExistingNetwork)
        Me.GroupBox1.Controls.Add(Me.txtANNFilePath)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 91)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Information"
        '
        'txtANNFilePath
        '
        Me.txtANNFilePath.Enabled = False
        Me.txtANNFilePath.Location = New System.Drawing.Point(141, 19)
        Me.txtANNFilePath.Name = "txtANNFilePath"
        Me.txtANNFilePath.Size = New System.Drawing.Size(372, 20)
        Me.txtANNFilePath.TabIndex = 2
        '
        'rdoUseExistingNetwork
        '
        Me.rdoUseExistingNetwork.AutoSize = True
        Me.rdoUseExistingNetwork.Location = New System.Drawing.Point(6, 19)
        Me.rdoUseExistingNetwork.Name = "rdoUseExistingNetwork"
        Me.rdoUseExistingNetwork.Size = New System.Drawing.Size(129, 17)
        Me.rdoUseExistingNetwork.TabIndex = 3
        Me.rdoUseExistingNetwork.Text = "Use Existing Network:"
        Me.rdoUseExistingNetwork.UseVisualStyleBackColor = True
        '
        'rdoCreateNewNetwork
        '
        Me.rdoCreateNewNetwork.AutoSize = True
        Me.rdoCreateNewNetwork.Checked = True
        Me.rdoCreateNewNetwork.Location = New System.Drawing.Point(6, 60)
        Me.rdoCreateNewNetwork.Name = "rdoCreateNewNetwork"
        Me.rdoCreateNewNetwork.Size = New System.Drawing.Size(127, 17)
        Me.rdoCreateNewNetwork.TabIndex = 4
        Me.rdoCreateNewNetwork.TabStop = True
        Me.rdoCreateNewNetwork.Text = "Create New Network:"
        Me.rdoCreateNewNetwork.UseVisualStyleBackColor = True
        '
        'btnBrowseNetworkFile
        '
        Me.btnBrowseNetworkFile.Enabled = False
        Me.btnBrowseNetworkFile.Location = New System.Drawing.Point(519, 17)
        Me.btnBrowseNetworkFile.Name = "btnBrowseNetworkFile"
        Me.btnBrowseNetworkFile.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseNetworkFile.TabIndex = 5
        Me.btnBrowseNetworkFile.Text = "Browse"
        Me.btnBrowseNetworkFile.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(227, 185)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(88, 23)
        Me.btnApply.TabIndex = 6
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(335, 185)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtHiddenNeurons
        '
        Me.txtHiddenNeurons.Location = New System.Drawing.Point(257, 59)
        Me.txtHiddenNeurons.Name = "txtHiddenNeurons"
        Me.txtHiddenNeurons.Size = New System.Drawing.Size(46, 20)
        Me.txtHiddenNeurons.TabIndex = 6
        Me.txtHiddenNeurons.Text = "6"
        '
        'txtHiddenLayers
        '
        Me.txtHiddenLayers.Location = New System.Drawing.Point(452, 59)
        Me.txtHiddenLayers.Name = "txtHiddenLayers"
        Me.txtHiddenLayers.Size = New System.Drawing.Size(46, 20)
        Me.txtHiddenLayers.TabIndex = 7
        Me.txtHiddenLayers.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "# Hidden Neurons:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "# Hidden Layers:"
        '
        'btnBrowseTrainingDataFile
        '
        Me.btnBrowseTrainingDataFile.Location = New System.Drawing.Point(519, 27)
        Me.btnBrowseTrainingDataFile.Name = "btnBrowseTrainingDataFile"
        Me.btnBrowseTrainingDataFile.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseTrainingDataFile.TabIndex = 10
        Me.btnBrowseTrainingDataFile.Text = "Browse"
        Me.btnBrowseTrainingDataFile.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTrainingDataFilePath)
        Me.GroupBox2.Controls.Add(Me.btnBrowseTrainingDataFile)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 70)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Training Data Information"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'frmLoadTrainingData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 215)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoadTrainingData"
        Me.Text = "Load Training Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTrainingDataFilePath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowseNetworkFile As System.Windows.Forms.Button
    Friend WithEvents rdoCreateNewNetwork As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUseExistingNetwork As System.Windows.Forms.RadioButton
    Friend WithEvents txtANNFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHiddenLayers As System.Windows.Forms.TextBox
    Friend WithEvents txtHiddenNeurons As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseTrainingDataFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
End Class
