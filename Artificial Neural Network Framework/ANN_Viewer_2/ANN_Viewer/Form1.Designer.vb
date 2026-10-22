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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportWeightsToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InputWeightsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateNextNodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateNextLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InputWeightsToolStripMenuItem, Me.CalculateAllToolStripMenuItem, Me.CalculateNextNodeToolStripMenuItem, Me.CalculateNextLevelToolStripMenuItem, Me.CalculateNetworkToolStripMenuItem, Me.ResetNetworkToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNetworkToolStripMenuItem, Me.SaveNetworkToolStripMenuItem, Me.LoadNetworkToolStripMenuItem, Me.ExportWeightsToFileToolStripMenuItem, Me.ModifyGUIToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CreateNetworkToolStripMenuItem
        '
        Me.CreateNetworkToolStripMenuItem.Name = "CreateNetworkToolStripMenuItem"
        Me.CreateNetworkToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CreateNetworkToolStripMenuItem.Text = "Create Network"
        '
        'SaveNetworkToolStripMenuItem
        '
        Me.SaveNetworkToolStripMenuItem.Name = "SaveNetworkToolStripMenuItem"
        Me.SaveNetworkToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SaveNetworkToolStripMenuItem.Text = "Sa&ve Network"
        '
        'LoadNetworkToolStripMenuItem
        '
        Me.LoadNetworkToolStripMenuItem.Name = "LoadNetworkToolStripMenuItem"
        Me.LoadNetworkToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LoadNetworkToolStripMenuItem.Text = "&Load Network"
        '
        'ExportWeightsToFileToolStripMenuItem
        '
        Me.ExportWeightsToFileToolStripMenuItem.Name = "ExportWeightsToFileToolStripMenuItem"
        Me.ExportWeightsToFileToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ExportWeightsToFileToolStripMenuItem.Text = "E&xport Weights to File"
        '
        'ModifyGUIToolStripMenuItem
        '
        Me.ModifyGUIToolStripMenuItem.Name = "ModifyGUIToolStripMenuItem"
        Me.ModifyGUIToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModifyGUIToolStripMenuItem.Text = "Modify GUI"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'InputWeightsToolStripMenuItem
        '
        Me.InputWeightsToolStripMenuItem.Name = "InputWeightsToolStripMenuItem"
        Me.InputWeightsToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.InputWeightsToolStripMenuItem.Text = "Set Input Neurons"
        '
        'CalculateAllToolStripMenuItem
        '
        Me.CalculateAllToolStripMenuItem.Name = "CalculateAllToolStripMenuItem"
        Me.CalculateAllToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.CalculateAllToolStripMenuItem.Text = "Set Weights"
        '
        'CalculateNextNodeToolStripMenuItem
        '
        Me.CalculateNextNodeToolStripMenuItem.Name = "CalculateNextNodeToolStripMenuItem"
        Me.CalculateNextNodeToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.CalculateNextNodeToolStripMenuItem.Text = "Calculate Next Node"
        '
        'CalculateNextLevelToolStripMenuItem
        '
        Me.CalculateNextLevelToolStripMenuItem.Name = "CalculateNextLevelToolStripMenuItem"
        Me.CalculateNextLevelToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.CalculateNextLevelToolStripMenuItem.Text = "Calculate Next Level"
        '
        'CalculateNetworkToolStripMenuItem
        '
        Me.CalculateNetworkToolStripMenuItem.Name = "CalculateNetworkToolStripMenuItem"
        Me.CalculateNetworkToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.CalculateNetworkToolStripMenuItem.Text = "Calculate Network"
        '
        'ResetNetworkToolStripMenuItem
        '
        Me.ResetNetworkToolStripMenuItem.Name = "ResetNetworkToolStripMenuItem"
        Me.ResetNetworkToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ResetNetworkToolStripMenuItem.Text = "Reset Network"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ContactToolStripMenuItem.Text = "&Contact"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "weights.txt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 242)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(600, 200)
        Me.Name = "Form1"
        Me.Text = "Artificial Neural Network Viewer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputWeightsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateNextNodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateNextLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportWeightsToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyGUIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CreateNetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog

End Class
