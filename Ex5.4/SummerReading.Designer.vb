<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummerReading
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
        Me.BonusPointsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.NumberOfBooksTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.bonusLabel = New System.Windows.Forms.Label()
        Me.numLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BonusPointsRichTextBox
        '
        Me.BonusPointsRichTextBox.Location = New System.Drawing.Point(124, 182)
        Me.BonusPointsRichTextBox.Name = "BonusPointsRichTextBox"
        Me.BonusPointsRichTextBox.ReadOnly = True
        Me.BonusPointsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.BonusPointsRichTextBox.Size = New System.Drawing.Size(129, 25)
        Me.BonusPointsRichTextBox.TabIndex = 13
        Me.BonusPointsRichTextBox.TabStop = False
        Me.BonusPointsRichTextBox.Text = ""
        '
        'NumberOfBooksTextBox
        '
        Me.NumberOfBooksTextBox.Location = New System.Drawing.Point(124, 143)
        Me.NumberOfBooksTextBox.Name = "NumberOfBooksTextBox"
        Me.NumberOfBooksTextBox.Size = New System.Drawing.Size(129, 20)
        Me.NumberOfBooksTextBox.TabIndex = 12
        Me.NumberOfBooksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(124, 103)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(129, 20)
        Me.NameTextBox.TabIndex = 11
        Me.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bonusLabel
        '
        Me.bonusLabel.AutoSize = True
        Me.bonusLabel.Location = New System.Drawing.Point(26, 185)
        Me.bonusLabel.Name = "bonusLabel"
        Me.bonusLabel.Size = New System.Drawing.Size(72, 13)
        Me.bonusLabel.TabIndex = 10
        Me.bonusLabel.Text = "Bonus Points:"
        '
        'numLabel
        '
        Me.numLabel.AutoSize = True
        Me.numLabel.Location = New System.Drawing.Point(26, 146)
        Me.numLabel.Name = "numLabel"
        Me.numLabel.Size = New System.Drawing.Size(92, 13)
        Me.numLabel.TabIndex = 9
        Me.numLabel.Text = "Number of Books:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(26, 106)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(41, 13)
        Me.nameLabel.TabIndex = 8
        Me.nameLabel.Text = " Name:"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'PointsToolStripMenuItem
        '
        Me.PointsToolStripMenuItem.Name = "PointsToolStripMenuItem"
        Me.PointsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PointsToolStripMenuItem.Text = "&Points"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointsToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SummerReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BonusPointsRichTextBox)
        Me.Controls.Add(Me.NumberOfBooksTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.bonusLabel)
        Me.Controls.Add(Me.numLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "SummerReading"
        Me.Text = "Summer Reading Bonus Calc"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BonusPointsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents NumberOfBooksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bonusLabel As System.Windows.Forms.Label
    Friend WithEvents numLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
