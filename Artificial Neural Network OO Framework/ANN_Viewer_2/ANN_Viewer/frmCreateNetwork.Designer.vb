<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateNetwork
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
        Me.txtNumInput = New System.Windows.Forms.TextBox
        Me.txtNumHidden = New System.Windows.Forms.TextBox
        Me.txtNumLayers = New System.Windows.Forms.TextBox
        Me.txtNumOutput = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCreateNetwork = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumInput
        '
        Me.txtNumInput.Location = New System.Drawing.Point(139, 23)
        Me.txtNumInput.Name = "txtNumInput"
        Me.txtNumInput.Size = New System.Drawing.Size(47, 20)
        Me.txtNumInput.TabIndex = 0
        '
        'txtNumHidden
        '
        Me.txtNumHidden.Location = New System.Drawing.Point(139, 49)
        Me.txtNumHidden.Name = "txtNumHidden"
        Me.txtNumHidden.Size = New System.Drawing.Size(47, 20)
        Me.txtNumHidden.TabIndex = 1
        '
        'txtNumLayers
        '
        Me.txtNumLayers.Location = New System.Drawing.Point(139, 75)
        Me.txtNumLayers.Name = "txtNumLayers"
        Me.txtNumLayers.Size = New System.Drawing.Size(47, 20)
        Me.txtNumLayers.TabIndex = 2
        '
        'txtNumOutput
        '
        Me.txtNumOutput.Location = New System.Drawing.Point(139, 101)
        Me.txtNumOutput.Name = "txtNumOutput"
        Me.txtNumOutput.Size = New System.Drawing.Size(47, 20)
        Me.txtNumOutput.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number Input Neurons:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number Hidden Layers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number Output Neurons:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number Hidden Neurons:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNumInput)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNumHidden)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumLayers)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 140)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup Network Structure"
        '
        'btnCreateNetwork
        '
        Me.btnCreateNetwork.Location = New System.Drawing.Point(60, 158)
        Me.btnCreateNetwork.Name = "btnCreateNetwork"
        Me.btnCreateNetwork.Size = New System.Drawing.Size(110, 23)
        Me.btnCreateNetwork.TabIndex = 10
        Me.btnCreateNetwork.Text = "Create Network"
        Me.btnCreateNetwork.UseVisualStyleBackColor = True
        '
        'frmCreateNetwork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 190)
        Me.Controls.Add(Me.btnCreateNetwork)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCreateNetwork"
        Me.Text = "frmCreateNetwork"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNumInput As System.Windows.Forms.TextBox
    Friend WithEvents txtNumHidden As System.Windows.Forms.TextBox
    Friend WithEvents txtNumLayers As System.Windows.Forms.TextBox
    Friend WithEvents txtNumOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateNetwork As System.Windows.Forms.Button
End Class
