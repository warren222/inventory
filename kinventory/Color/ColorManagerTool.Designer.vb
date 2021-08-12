<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorManagerTool
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorManagerTool))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.sourcegv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sourceArticleCbox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sourceColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sourceCostheadCbox = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cpartgv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cpartArticleCbox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cpartColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cpartCostheadCbox = New System.Windows.Forms.ComboBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colorAssignedCbox = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.colorMngrgv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.rowCbox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.specifiedColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmArticleCbox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmCostheadCbox = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TopPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.sourcegv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.cpartgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.colorMngrgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.SplitContainer1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 49)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1216, 210)
        Me.TopPanel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1216, 210)
        Me.SplitContainer1.SplitterDistance = 605
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.sourcegv)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(605, 146)
        Me.Panel4.TabIndex = 1
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
        Me.sourcegv.Location = New System.Drawing.Point(0, 0)
        Me.sourcegv.MultiSelect = False
        Me.sourcegv.Name = "sourcegv"
        Me.sourcegv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.sourcegv.ReadOnly = True
        Me.sourcegv.RowHeadersWidth = 40
        Me.sourcegv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sourcegv.Size = New System.Drawing.Size(605, 146)
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
        Me.sourcegv.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.Panel2.Size = New System.Drawing.Size(605, 64)
        Me.Panel2.TabIndex = 0
        '
        'sourceArticleCbox
        '
        Me.sourceArticleCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sourceArticleCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceArticleCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceArticleCbox.DropDownHeight = 206
        Me.sourceArticleCbox.FormattingEnabled = True
        Me.sourceArticleCbox.IntegralHeight = False
        Me.sourceArticleCbox.Location = New System.Drawing.Point(452, 10)
        Me.sourceArticleCbox.Name = "sourceArticleCbox"
        Me.sourceArticleCbox.Size = New System.Drawing.Size(150, 21)
        Me.sourceArticleCbox.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(77, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Article#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Color"
        '
        'sourceColorCbox
        '
        Me.sourceColorCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sourceColorCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceColorCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceColorCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceColorCbox.FormattingEnabled = True
        Me.sourceColorCbox.Location = New System.Drawing.Point(260, 10)
        Me.sourceColorCbox.Name = "sourceColorCbox"
        Me.sourceColorCbox.Size = New System.Drawing.Size(140, 21)
        Me.sourceColorCbox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costhead"
        '
        'sourceCostheadCbox
        '
        Me.sourceCostheadCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sourceCostheadCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceCostheadCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceCostheadCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceCostheadCbox.FormattingEnabled = True
        Me.sourceCostheadCbox.Location = New System.Drawing.Point(77, 10)
        Me.sourceCostheadCbox.Name = "sourceCostheadCbox"
        Me.sourceCostheadCbox.Size = New System.Drawing.Size(140, 21)
        Me.sourceCostheadCbox.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cpartgv)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(607, 146)
        Me.Panel5.TabIndex = 2
        '
        'cpartgv
        '
        Me.cpartgv.AllowUserToAddRows = False
        Me.cpartgv.AllowUserToDeleteRows = False
        Me.cpartgv.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cpartgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.cpartgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cpartgv.ColumnHeadersHeight = 30
        Me.cpartgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cpartgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cpartgv.Location = New System.Drawing.Point(0, 0)
        Me.cpartgv.MultiSelect = False
        Me.cpartgv.Name = "cpartgv"
        Me.cpartgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cpartgv.ReadOnly = True
        Me.cpartgv.RowHeadersWidth = 40
        Me.cpartgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cpartgv.Size = New System.Drawing.Size(607, 146)
        Me.cpartgv.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cpartgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.cpartgv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.cpartgv.StateCommon.DataCell.Border.Width = 0
        Me.cpartgv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cpartgv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Blue
        Me.cpartgv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Navy
        Me.cpartgv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.cpartgv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.cpartgv.StateCommon.HeaderColumn.Border.Width = 0
        Me.cpartgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.cpartgv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cpartgv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.cpartgv.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cpartArticleCbox)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cpartColorCbox)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cpartCostheadCbox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(607, 64)
        Me.Panel3.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(76, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 24)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(402, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Article#"
        '
        'cpartArticleCbox
        '
        Me.cpartArticleCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cpartArticleCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cpartArticleCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cpartArticleCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpartArticleCbox.FormattingEnabled = True
        Me.cpartArticleCbox.Location = New System.Drawing.Point(449, 9)
        Me.cpartArticleCbox.Name = "cpartArticleCbox"
        Me.cpartArticleCbox.Size = New System.Drawing.Size(140, 21)
        Me.cpartArticleCbox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Color"
        '
        'cpartColorCbox
        '
        Me.cpartColorCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cpartColorCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cpartColorCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cpartColorCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpartColorCbox.FormattingEnabled = True
        Me.cpartColorCbox.Location = New System.Drawing.Point(259, 9)
        Me.cpartColorCbox.Name = "cpartColorCbox"
        Me.cpartColorCbox.Size = New System.Drawing.Size(140, 21)
        Me.cpartColorCbox.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Costhead"
        '
        'cpartCostheadCbox
        '
        Me.cpartCostheadCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cpartCostheadCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cpartCostheadCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cpartCostheadCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpartCostheadCbox.FormattingEnabled = True
        Me.cpartCostheadCbox.Location = New System.Drawing.Point(76, 9)
        Me.cpartCostheadCbox.Name = "cpartCostheadCbox"
        Me.cpartCostheadCbox.Size = New System.Drawing.Size(140, 21)
        Me.cpartCostheadCbox.TabIndex = 9
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 259)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1216, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1216, 49)
        Me.Panel1.TabIndex = 2
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(540, 15)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(137, 34)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 593
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1025, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Counterpart Column"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Source Column"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(683, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Specified Color"
        '
        'colorAssignedCbox
        '
        Me.colorAssignedCbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.colorAssignedCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.colorAssignedCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.colorAssignedCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorAssignedCbox.FormattingEnabled = True
        Me.colorAssignedCbox.Location = New System.Drawing.Point(505, 6)
        Me.colorAssignedCbox.Name = "colorAssignedCbox"
        Me.colorAssignedCbox.Size = New System.Drawing.Size(172, 21)
        Me.colorAssignedCbox.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.colorMngrgv)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 262)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1216, 187)
        Me.Panel6.TabIndex = 3
        '
        'colorMngrgv
        '
        Me.colorMngrgv.AllowUserToAddRows = False
        Me.colorMngrgv.AllowUserToDeleteRows = False
        Me.colorMngrgv.AllowUserToOrderColumns = True
        Me.colorMngrgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.colorMngrgv.ColumnHeadersHeight = 30
        Me.colorMngrgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.colorMngrgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colorMngrgv.Location = New System.Drawing.Point(0, 33)
        Me.colorMngrgv.Name = "colorMngrgv"
        Me.colorMngrgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.colorMngrgv.ReadOnly = True
        Me.colorMngrgv.RowHeadersWidth = 40
        Me.colorMngrgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.colorMngrgv.Size = New System.Drawing.Size(1216, 123)
        Me.colorMngrgv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.colorMngrgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.colorMngrgv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.colorMngrgv.StateCommon.DataCell.Border.Width = 0
        Me.colorMngrgv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colorMngrgv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colorMngrgv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Black
        Me.colorMngrgv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.colorMngrgv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.colorMngrgv.StateCommon.HeaderColumn.Border.Width = 0
        Me.colorMngrgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.colorMngrgv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colorMngrgv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.colorMngrgv.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel8.Controls.Add(Me.rowCbox)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Controls.Add(Me.specifiedColorCbox)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.Button5)
        Me.Panel8.Controls.Add(Me.cmArticleCbox)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.cmColorCbox)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.cmCostheadCbox)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 156)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1216, 31)
        Me.Panel8.TabIndex = 3
        '
        'rowCbox
        '
        Me.rowCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.rowCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.rowCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rowCbox.DropDownHeight = 206
        Me.rowCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rowCbox.FormattingEnabled = True
        Me.rowCbox.IntegralHeight = False
        Me.rowCbox.Items.AddRange(New Object() {"100", "1000", "10000", "1000000", "10000000"})
        Me.rowCbox.Location = New System.Drawing.Point(885, 3)
        Me.rowCbox.Name = "rowCbox"
        Me.rowCbox.Size = New System.Drawing.Size(113, 21)
        Me.rowCbox.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(855, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "rows"
        '
        'specifiedColorCbox
        '
        Me.specifiedColorCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specifiedColorCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specifiedColorCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.specifiedColorCbox.DropDownHeight = 206
        Me.specifiedColorCbox.FormattingEnabled = True
        Me.specifiedColorCbox.IntegralHeight = False
        Me.specifiedColorCbox.Location = New System.Drawing.Point(699, 3)
        Me.specifiedColorCbox.Name = "specifiedColorCbox"
        Me.specifiedColorCbox.Size = New System.Drawing.Size(150, 21)
        Me.specifiedColorCbox.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(615, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Specified Color"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1004, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 24)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmArticleCbox
        '
        Me.cmArticleCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmArticleCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmArticleCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmArticleCbox.DropDownHeight = 206
        Me.cmArticleCbox.FormattingEnabled = True
        Me.cmArticleCbox.IntegralHeight = False
        Me.cmArticleCbox.Location = New System.Drawing.Point(452, 3)
        Me.cmArticleCbox.Name = "cmArticleCbox"
        Me.cmArticleCbox.Size = New System.Drawing.Size(150, 21)
        Me.cmArticleCbox.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(403, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Article#"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(223, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Color"
        '
        'cmColorCbox
        '
        Me.cmColorCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmColorCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmColorCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmColorCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmColorCbox.FormattingEnabled = True
        Me.cmColorCbox.Location = New System.Drawing.Point(260, 3)
        Me.cmColorCbox.Name = "cmColorCbox"
        Me.cmColorCbox.Size = New System.Drawing.Size(140, 21)
        Me.cmColorCbox.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Costhead"
        '
        'cmCostheadCbox
        '
        Me.cmCostheadCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmCostheadCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmCostheadCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmCostheadCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmCostheadCbox.FormattingEnabled = True
        Me.cmCostheadCbox.Location = New System.Drawing.Point(77, 3)
        Me.cmCostheadCbox.Name = "cmCostheadCbox"
        Me.cmCostheadCbox.Size = New System.Drawing.Size(140, 21)
        Me.cmCostheadCbox.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Button6)
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.colorAssignedCbox)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1216, 33)
        Me.Panel7.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1004, -1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(213, 34)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "copy counterparts"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(764, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 20)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ColorManagerTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 449)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ColorManagerTool"
        Me.Text = "ColorManagerTool"
        Me.TopPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.sourcegv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.cpartgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.colorMngrgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents sourceColorCbox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sourceCostheadCbox As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents colorAssignedCbox As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cpartArticleCbox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cpartColorCbox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cpartCostheadCbox As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents sourcegv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents cpartgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents colorMngrgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents sourceArticleCbox As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents cmArticleCbox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmColorCbox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmCostheadCbox As ComboBox
    Friend WithEvents specifiedColorCbox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents rowCbox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button6 As Button
End Class
