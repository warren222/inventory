<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stocksReference
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stocksReference))
        Me.sourcegv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.sourceArticleCbox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sourceColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sourceCostheadCbox = New System.Windows.Forms.ComboBox()
        CType(Me.sourcegv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sourcegv
        '
        Me.sourcegv.AllowUserToAddRows = False
        Me.sourcegv.AllowUserToDeleteRows = False
        Me.sourcegv.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourcegv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.sourcegv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sourcegv.ColumnHeadersHeight = 30
        Me.sourcegv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sourcegv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sourcegv.Location = New System.Drawing.Point(0, 114)
        Me.sourcegv.Name = "sourcegv"
        Me.sourcegv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.sourcegv.ReadOnly = True
        Me.sourcegv.RowHeadersWidth = 40
        Me.sourcegv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sourcegv.Size = New System.Drawing.Size(621, 212)
        Me.sourcegv.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sourcegv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.sourcegv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.sourcegv.StateCommon.DataCell.Border.Width = 0
        Me.sourcegv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sourcegv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sourcegv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Green
        Me.sourcegv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.sourcegv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.sourcegv.StateCommon.HeaderColumn.Border.Width = 0
        Me.sourcegv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.sourcegv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sourcegv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.sourcegv.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LoadingPBOX)
        Me.Panel2.Controls.Add(Me.sourceArticleCbox)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.sourceColorCbox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.sourceCostheadCbox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 114)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 594
        Me.Label1.Text = "Select reference"
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(242, 4)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(137, 34)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 593
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'sourceArticleCbox
        '
        Me.sourceArticleCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sourceArticleCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceArticleCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceArticleCbox.DropDownHeight = 206
        Me.sourceArticleCbox.FormattingEnabled = True
        Me.sourceArticleCbox.IntegralHeight = False
        Me.sourceArticleCbox.Location = New System.Drawing.Point(442, 56)
        Me.sourceArticleCbox.Name = "sourceArticleCbox"
        Me.sourceArticleCbox.Size = New System.Drawing.Size(150, 21)
        Me.sourceArticleCbox.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(67, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(393, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Article#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Color"
        '
        'sourceColorCbox
        '
        Me.sourceColorCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sourceColorCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceColorCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceColorCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceColorCbox.FormattingEnabled = True
        Me.sourceColorCbox.Location = New System.Drawing.Point(250, 56)
        Me.sourceColorCbox.Name = "sourceColorCbox"
        Me.sourceColorCbox.Size = New System.Drawing.Size(140, 21)
        Me.sourceColorCbox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Costhead"
        '
        'sourceCostheadCbox
        '
        Me.sourceCostheadCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sourceCostheadCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceCostheadCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceCostheadCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceCostheadCbox.FormattingEnabled = True
        Me.sourceCostheadCbox.Location = New System.Drawing.Point(67, 56)
        Me.sourceCostheadCbox.Name = "sourceCostheadCbox"
        Me.sourceCostheadCbox.Size = New System.Drawing.Size(140, 21)
        Me.sourceCostheadCbox.TabIndex = 10
        '
        'stocksReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 326)
        Me.Controls.Add(Me.sourcegv)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "stocksReference"
        Me.Text = "stocksReference"
        CType(Me.sourcegv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sourcegv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents sourceArticleCbox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sourceColorCbox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sourceCostheadCbox As ComboBox
End Class
