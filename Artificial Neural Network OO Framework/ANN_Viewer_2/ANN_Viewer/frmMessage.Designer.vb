<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtErrorMessage = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMessageToUser = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Error Message:"
        '
        'txtErrorMessage
        '
        Me.txtErrorMessage.Location = New System.Drawing.Point(22, 103)
        Me.txtErrorMessage.Multiline = True
        Me.txtErrorMessage.Name = "txtErrorMessage"
        Me.txtErrorMessage.ReadOnly = True
        Me.txtErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrorMessage.Size = New System.Drawing.Size(471, 49)
        Me.txtErrorMessage.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message to User:"
        '
        'txtMessageToUser
        '
        Me.txtMessageToUser.Location = New System.Drawing.Point(22, 22)
        Me.txtMessageToUser.Multiline = True
        Me.txtMessageToUser.Name = "txtMessageToUser"
        Me.txtMessageToUser.ReadOnly = True
        Me.txtMessageToUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessageToUser.Size = New System.Drawing.Size(471, 62)
        Me.txtMessageToUser.TabIndex = 4
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 195)
        Me.Controls.Add(Me.txtMessageToUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtErrorMessage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMessage"
        Me.Text = "Message Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtErrorMessage As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMessageToUser As System.Windows.Forms.TextBox
End Class
