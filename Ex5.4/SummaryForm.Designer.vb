<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.AverageTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SummaryLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(97, 188)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'AverageTextBox
        '
        Me.AverageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AverageTextBox.Location = New System.Drawing.Point(115, 145)
        Me.AverageTextBox.Name = "AverageTextBox"
        Me.AverageTextBox.ReadOnly = True
        Me.AverageTextBox.Size = New System.Drawing.Size(41, 20)
        Me.AverageTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Average Number of Books"
        '
        'SummaryLabel
        '
        Me.SummaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryLabel.Location = New System.Drawing.Point(30, 49)
        Me.SummaryLabel.Name = "SummaryLabel"
        Me.SummaryLabel.Size = New System.Drawing.Size(224, 28)
        Me.SummaryLabel.TabIndex = 4
        Me.SummaryLabel.Text = "Summary"
        Me.SummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.AverageTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SummaryLabel)
        Me.Name = "SummaryForm"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents AverageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SummaryLabel As System.Windows.Forms.Label
End Class
