<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyGUI
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbShowWeightLinkLegend = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtLowValue = New System.Windows.Forms.TextBox
        Me.txtmidLowValue = New System.Windows.Forms.TextBox
        Me.txtmidHighValue = New System.Windows.Forms.TextBox
        Me.txtHighValue = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbLowColor = New System.Windows.Forms.ComboBox
        Me.cbmidLowColor = New System.Windows.Forms.ComboBox
        Me.cbZeroColor = New System.Windows.Forms.ComboBox
        Me.cbmidHighColor = New System.Windows.Forms.ComboBox
        Me.cbHighColor = New System.Windows.Forms.ComboBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.bntApplyChanges = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbShowHoveredNeuronInfoBlock = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblDataWindowPercent = New System.Windows.Forms.Label
        Me.tbarDataWindowPercent = New System.Windows.Forms.TrackBar
        Me.cbShowNetworkInfoBlock = New System.Windows.Forms.CheckBox
        Me.cbShowCalculatedNeuronInfoBlock = New System.Windows.Forms.CheckBox
        Me.cbShowActionHistoryBlock = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbCalculatedColor = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbNeuronColor = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbBiasColor = New System.Windows.Forms.ComboBox
        Me.cbSelectedColor = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cbBackgroundColor = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbForegroundColor = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbarDataWindowPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbShowWeightLinkLegend)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtLowValue)
        Me.GroupBox1.Controls.Add(Me.txtmidLowValue)
        Me.GroupBox1.Controls.Add(Me.txtmidHighValue)
        Me.GroupBox1.Controls.Add(Me.txtHighValue)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbLowColor)
        Me.GroupBox1.Controls.Add(Me.cbmidLowColor)
        Me.GroupBox1.Controls.Add(Me.cbZeroColor)
        Me.GroupBox1.Controls.Add(Me.cbmidHighColor)
        Me.GroupBox1.Controls.Add(Me.cbHighColor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weight Link GUI Values"
        '
        'cbShowWeightLinkLegend
        '
        Me.cbShowWeightLinkLegend.AutoSize = True
        Me.cbShowWeightLinkLegend.Location = New System.Drawing.Point(11, 153)
        Me.cbShowWeightLinkLegend.Name = "cbShowWeightLinkLegend"
        Me.cbShowWeightLinkLegend.Size = New System.Drawing.Size(152, 17)
        Me.cbShowWeightLinkLegend.TabIndex = 21
        Me.cbShowWeightLinkLegend.Text = "Show Weight Link Legend"
        Me.cbShowWeightLinkLegend.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtLowValue
        '
        Me.txtLowValue.Location = New System.Drawing.Point(286, 127)
        Me.txtLowValue.Name = "txtLowValue"
        Me.txtLowValue.Size = New System.Drawing.Size(37, 20)
        Me.txtLowValue.TabIndex = 19
        '
        'txtmidLowValue
        '
        Me.txtmidLowValue.Location = New System.Drawing.Point(286, 100)
        Me.txtmidLowValue.Name = "txtmidLowValue"
        Me.txtmidLowValue.Size = New System.Drawing.Size(37, 20)
        Me.txtmidLowValue.TabIndex = 18
        '
        'txtmidHighValue
        '
        Me.txtmidHighValue.Location = New System.Drawing.Point(286, 46)
        Me.txtmidHighValue.Name = "txtmidHighValue"
        Me.txtmidHighValue.Size = New System.Drawing.Size(37, 20)
        Me.txtmidHighValue.TabIndex = 17
        '
        'txtHighValue
        '
        Me.txtHighValue.Location = New System.Drawing.Point(286, 20)
        Me.txtHighValue.Name = "txtHighValue"
        Me.txtHighValue.Size = New System.Drawing.Size(37, 20)
        Me.txtHighValue.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(220, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Low Value:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Mid-Low Value:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Mid-High Value:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "High Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Low Color:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mid-Low Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Zero Color:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mid-High Color:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "High Color:"
        '
        'cbLowColor
        '
        Me.cbLowColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLowColor.FormattingEnabled = True
        Me.cbLowColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbLowColor.Location = New System.Drawing.Point(91, 127)
        Me.cbLowColor.Name = "cbLowColor"
        Me.cbLowColor.Size = New System.Drawing.Size(94, 21)
        Me.cbLowColor.TabIndex = 5
        '
        'cbmidLowColor
        '
        Me.cbmidLowColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmidLowColor.FormattingEnabled = True
        Me.cbmidLowColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbmidLowColor.Location = New System.Drawing.Point(91, 100)
        Me.cbmidLowColor.Name = "cbmidLowColor"
        Me.cbmidLowColor.Size = New System.Drawing.Size(94, 21)
        Me.cbmidLowColor.TabIndex = 4
        '
        'cbZeroColor
        '
        Me.cbZeroColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZeroColor.FormattingEnabled = True
        Me.cbZeroColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbZeroColor.Location = New System.Drawing.Point(91, 73)
        Me.cbZeroColor.Name = "cbZeroColor"
        Me.cbZeroColor.Size = New System.Drawing.Size(94, 21)
        Me.cbZeroColor.TabIndex = 3
        '
        'cbmidHighColor
        '
        Me.cbmidHighColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmidHighColor.FormattingEnabled = True
        Me.cbmidHighColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbmidHighColor.Location = New System.Drawing.Point(91, 46)
        Me.cbmidHighColor.Name = "cbmidHighColor"
        Me.cbmidHighColor.Size = New System.Drawing.Size(94, 21)
        Me.cbmidHighColor.TabIndex = 2
        '
        'cbHighColor
        '
        Me.cbHighColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHighColor.FormattingEnabled = True
        Me.cbHighColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbHighColor.Location = New System.Drawing.Point(91, 19)
        Me.cbHighColor.Name = "cbHighColor"
        Me.cbHighColor.Size = New System.Drawing.Size(94, 21)
        Me.cbHighColor.TabIndex = 1
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        Me.ColorDialog1.SolidColorOnly = True
        '
        'bntApplyChanges
        '
        Me.bntApplyChanges.Location = New System.Drawing.Point(208, 288)
        Me.bntApplyChanges.Name = "bntApplyChanges"
        Me.bntApplyChanges.Size = New System.Drawing.Size(96, 24)
        Me.bntApplyChanges.TabIndex = 0
        Me.bntApplyChanges.Text = "Apply Changes"
        Me.bntApplyChanges.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbShowHoveredNeuronInfoBlock)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblDataWindowPercent)
        Me.GroupBox2.Controls.Add(Me.tbarDataWindowPercent)
        Me.GroupBox2.Controls.Add(Me.cbShowNetworkInfoBlock)
        Me.GroupBox2.Controls.Add(Me.cbShowCalculatedNeuronInfoBlock)
        Me.GroupBox2.Controls.Add(Me.cbShowActionHistoryBlock)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Network Data Values"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Network Data Column Size (Percent of Window):"
        '
        'cbShowHoveredNeuronInfoBlock
        '
        Me.cbShowHoveredNeuronInfoBlock.AutoSize = True
        Me.cbShowHoveredNeuronInfoBlock.Location = New System.Drawing.Point(9, 77)
        Me.cbShowHoveredNeuronInfoBlock.Name = "cbShowHoveredNeuronInfoBlock"
        Me.cbShowHoveredNeuronInfoBlock.Size = New System.Drawing.Size(186, 17)
        Me.cbShowHoveredNeuronInfoBlock.TabIndex = 2
        Me.cbShowHoveredNeuronInfoBlock.Text = "Show Hovered Neuron Info Block"
        Me.cbShowHoveredNeuronInfoBlock.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "%"
        '
        'lblDataWindowPercent
        '
        Me.lblDataWindowPercent.AutoSize = True
        Me.lblDataWindowPercent.Location = New System.Drawing.Point(6, 46)
        Me.lblDataWindowPercent.Name = "lblDataWindowPercent"
        Me.lblDataWindowPercent.Size = New System.Drawing.Size(19, 13)
        Me.lblDataWindowPercent.TabIndex = 5
        Me.lblDataWindowPercent.Text = "00"
        '
        'tbarDataWindowPercent
        '
        Me.tbarDataWindowPercent.Location = New System.Drawing.Point(52, 36)
        Me.tbarDataWindowPercent.Maximum = 100
        Me.tbarDataWindowPercent.Name = "tbarDataWindowPercent"
        Me.tbarDataWindowPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbarDataWindowPercent.Size = New System.Drawing.Size(213, 45)
        Me.tbarDataWindowPercent.TabIndex = 4
        Me.tbarDataWindowPercent.TickFrequency = 5
        Me.tbarDataWindowPercent.Value = 20
        '
        'cbShowNetworkInfoBlock
        '
        Me.cbShowNetworkInfoBlock.AutoSize = True
        Me.cbShowNetworkInfoBlock.Location = New System.Drawing.Point(9, 146)
        Me.cbShowNetworkInfoBlock.Name = "cbShowNetworkInfoBlock"
        Me.cbShowNetworkInfoBlock.Size = New System.Drawing.Size(147, 17)
        Me.cbShowNetworkInfoBlock.TabIndex = 3
        Me.cbShowNetworkInfoBlock.Text = "Show Network Info Block"
        Me.cbShowNetworkInfoBlock.UseVisualStyleBackColor = True
        '
        'cbShowCalculatedNeuronInfoBlock
        '
        Me.cbShowCalculatedNeuronInfoBlock.AutoSize = True
        Me.cbShowCalculatedNeuronInfoBlock.Location = New System.Drawing.Point(9, 100)
        Me.cbShowCalculatedNeuronInfoBlock.Name = "cbShowCalculatedNeuronInfoBlock"
        Me.cbShowCalculatedNeuronInfoBlock.Size = New System.Drawing.Size(195, 17)
        Me.cbShowCalculatedNeuronInfoBlock.TabIndex = 2
        Me.cbShowCalculatedNeuronInfoBlock.Text = "Show Calculated Neuron Info Block"
        Me.cbShowCalculatedNeuronInfoBlock.UseVisualStyleBackColor = True
        '
        'cbShowActionHistoryBlock
        '
        Me.cbShowActionHistoryBlock.AutoSize = True
        Me.cbShowActionHistoryBlock.Location = New System.Drawing.Point(9, 123)
        Me.cbShowActionHistoryBlock.Name = "cbShowActionHistoryBlock"
        Me.cbShowActionHistoryBlock.Size = New System.Drawing.Size(151, 17)
        Me.cbShowActionHistoryBlock.TabIndex = 1
        Me.cbShowActionHistoryBlock.Text = "Show Action History Block"
        Me.cbShowActionHistoryBlock.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cbCalculatedColor)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbNeuronColor)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbBiasColor)
        Me.GroupBox3.Controls.Add(Me.cbSelectedColor)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Network Neuron Colors"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(193, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Calculated Color:"
        '
        'cbCalculatedColor
        '
        Me.cbCalculatedColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalculatedColor.FormattingEnabled = True
        Me.cbCalculatedColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbCalculatedColor.Location = New System.Drawing.Point(286, 49)
        Me.cbCalculatedColor.Name = "cbCalculatedColor"
        Me.cbCalculatedColor.Size = New System.Drawing.Size(94, 21)
        Me.cbCalculatedColor.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Neuron Color:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(201, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Selected Color:"
        '
        'cbNeuronColor
        '
        Me.cbNeuronColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNeuronColor.FormattingEnabled = True
        Me.cbNeuronColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbNeuronColor.Location = New System.Drawing.Point(91, 22)
        Me.cbNeuronColor.Name = "cbNeuronColor"
        Me.cbNeuronColor.Size = New System.Drawing.Size(94, 21)
        Me.cbNeuronColor.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Bias Color:"
        '
        'cbBiasColor
        '
        Me.cbBiasColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBiasColor.FormattingEnabled = True
        Me.cbBiasColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbBiasColor.Location = New System.Drawing.Point(91, 49)
        Me.cbBiasColor.Name = "cbBiasColor"
        Me.cbBiasColor.Size = New System.Drawing.Size(94, 21)
        Me.cbBiasColor.TabIndex = 24
        '
        'cbSelectedColor
        '
        Me.cbSelectedColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectedColor.FormattingEnabled = True
        Me.cbSelectedColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbSelectedColor.Location = New System.Drawing.Point(286, 22)
        Me.cbSelectedColor.Name = "cbSelectedColor"
        Me.cbSelectedColor.Size = New System.Drawing.Size(94, 21)
        Me.cbSelectedColor.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cbForegroundColor)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.cbBackgroundColor)
        Me.GroupBox4.Location = New System.Drawing.Point(420, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 88)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GUI Window Colors:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Background Color:"
        '
        'cbBackgroundColor
        '
        Me.cbBackgroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBackgroundColor.FormattingEnabled = True
        Me.cbBackgroundColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbBackgroundColor.Location = New System.Drawing.Point(106, 22)
        Me.cbBackgroundColor.Name = "cbBackgroundColor"
        Me.cbBackgroundColor.Size = New System.Drawing.Size(94, 21)
        Me.cbBackgroundColor.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Foreground Color:"
        '
        'cbForegroundColor
        '
        Me.cbForegroundColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbForegroundColor.FormattingEnabled = True
        Me.cbForegroundColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Green", "Black", "White"})
        Me.cbForegroundColor.Location = New System.Drawing.Point(106, 49)
        Me.cbForegroundColor.Name = "cbForegroundColor"
        Me.cbForegroundColor.Size = New System.Drawing.Size(94, 21)
        Me.cbForegroundColor.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Reset All to Default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmModifyGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 322)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bntApplyChanges)
        Me.Name = "frmModifyGUI"
        Me.Text = "ModifyGUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbarDataWindowPercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bntApplyChanges As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Private WithEvents cbHighColor As System.Windows.Forms.ComboBox
    Private WithEvents cbmidHighColor As System.Windows.Forms.ComboBox
    Private WithEvents cbLowColor As System.Windows.Forms.ComboBox
    Private WithEvents cbmidLowColor As System.Windows.Forms.ComboBox
    Private WithEvents cbZeroColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLowValue As System.Windows.Forms.TextBox
    Friend WithEvents txtmidLowValue As System.Windows.Forms.TextBox
    Friend WithEvents txtmidHighValue As System.Windows.Forms.TextBox
    Friend WithEvents txtHighValue As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbShowNetworkInfoBlock As System.Windows.Forms.CheckBox
    Friend WithEvents cbShowCalculatedNeuronInfoBlock As System.Windows.Forms.CheckBox
    Friend WithEvents cbShowActionHistoryBlock As System.Windows.Forms.CheckBox
    Friend WithEvents lblDataWindowPercent As System.Windows.Forms.Label
    Friend WithEvents tbarDataWindowPercent As System.Windows.Forms.TrackBar
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbShowHoveredNeuronInfoBlock As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbShowWeightLinkLegend As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents cbNeuronColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents cbBiasColor As System.Windows.Forms.ComboBox
    Private WithEvents cbSelectedColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents cbCalculatedColor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents cbBackgroundColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents cbForegroundColor As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
