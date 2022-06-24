<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checklisted
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CHECKLISTEDgridview = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.projectlabel = New System.Windows.Forms.TextBox()
        Me.allocationGridView = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.refcombo = New System.Windows.Forms.ComboBox()
        Me.refstock = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CancelAllocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KryptonGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.REFERENCE = New System.Windows.Forms.ComboBox()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.refjo = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        CType(Me.CHECKLISTEDgridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allocationGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.KryptonGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup8.Panel.SuspendLayout()
        Me.KryptonGroup8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CHECKLISTEDgridview
        '
        Me.CHECKLISTEDgridview.AllowUserToAddRows = False
        Me.CHECKLISTEDgridview.AllowUserToDeleteRows = False
        Me.CHECKLISTEDgridview.AllowUserToOrderColumns = True
        Me.CHECKLISTEDgridview.AllowUserToResizeColumns = False
        Me.CHECKLISTEDgridview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.CHECKLISTEDgridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CHECKLISTEDgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CHECKLISTEDgridview.ColumnHeadersHeight = 30
        Me.CHECKLISTEDgridview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CHECKLISTEDgridview.Dock = System.Windows.Forms.DockStyle.Left
        Me.CHECKLISTEDgridview.Location = New System.Drawing.Point(0, 0)
        Me.CHECKLISTEDgridview.Name = "CHECKLISTEDgridview"
        Me.CHECKLISTEDgridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.CHECKLISTEDgridview.ReadOnly = True
        Me.CHECKLISTEDgridview.RowHeadersVisible = False
        Me.CHECKLISTEDgridview.RowHeadersWidth = 40
        Me.CHECKLISTEDgridview.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.CHECKLISTEDgridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.CHECKLISTEDgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CHECKLISTEDgridview.Size = New System.Drawing.Size(495, 375)
        Me.CHECKLISTEDgridview.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.CHECKLISTEDgridview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.CHECKLISTEDgridview.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.CHECKLISTEDgridview.StateCommon.DataCell.Border.Width = 0
        Me.CHECKLISTEDgridview.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Border.Width = 0
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CHECKLISTEDgridview.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.CHECKLISTEDgridview.TabIndex = 468
        '
        'projectlabel
        '
        Me.projectlabel.Location = New System.Drawing.Point(11, 115)
        Me.projectlabel.Name = "projectlabel"
        Me.projectlabel.Size = New System.Drawing.Size(293, 20)
        Me.projectlabel.TabIndex = 471
        '
        'allocationGridView
        '
        Me.allocationGridView.AllowUserToAddRows = False
        Me.allocationGridView.AllowUserToDeleteRows = False
        Me.allocationGridView.AllowUserToOrderColumns = True
        Me.allocationGridView.AllowUserToResizeColumns = False
        Me.allocationGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.allocationGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.allocationGridView.ColumnHeadersHeight = 30
        Me.allocationGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.allocationGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.allocationGridView.Location = New System.Drawing.Point(495, 0)
        Me.allocationGridView.Name = "allocationGridView"
        Me.allocationGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.allocationGridView.ReadOnly = True
        Me.allocationGridView.RowHeadersVisible = False
        Me.allocationGridView.RowHeadersWidth = 40
        Me.allocationGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.allocationGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.allocationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.allocationGridView.Size = New System.Drawing.Size(746, 375)
        Me.allocationGridView.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.allocationGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.allocationGridView.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.allocationGridView.StateCommon.DataCell.Border.Width = 0
        Me.allocationGridView.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.allocationGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.allocationGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.allocationGridView.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.allocationGridView.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.allocationGridView.StateCommon.HeaderColumn.Border.Width = 0
        Me.allocationGridView.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.allocationGridView.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.allocationGridView.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.allocationGridView.TabIndex = 470
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton3.Location = New System.Drawing.Point(12, 11)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonButton3.Size = New System.Drawing.Size(87, 27)
        Me.KryptonButton3.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton3.StateCommon.Border.Rounding = 0
        Me.KryptonButton3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton3.TabIndex = 469
        Me.KryptonButton3.Values.Text = "RELOAD"
        '
        'refcombo
        '
        Me.refcombo.FormattingEnabled = True
        Me.refcombo.Location = New System.Drawing.Point(662, 116)
        Me.refcombo.Name = "refcombo"
        Me.refcombo.Size = New System.Drawing.Size(121, 21)
        Me.refcombo.TabIndex = 472
        '
        'refstock
        '
        Me.refstock.FormattingEnabled = True
        Me.refstock.Location = New System.Drawing.Point(662, 89)
        Me.refstock.Name = "refstock"
        Me.refstock.Size = New System.Drawing.Size(121, 21)
        Me.refstock.TabIndex = 473
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelAllocationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 26)
        '
        'CancelAllocationToolStripMenuItem
        '
        Me.CancelAllocationToolStripMenuItem.Name = "CancelAllocationToolStripMenuItem"
        Me.CancelAllocationToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CancelAllocationToolStripMenuItem.Text = "cancel allocation"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton1.Location = New System.Drawing.Point(1078, 11)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonButton1.Size = New System.Drawing.Size(154, 27)
        Me.KryptonButton1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.StateCommon.Border.Rounding = 0
        Me.KryptonButton1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton1.TabIndex = 474
        Me.KryptonButton1.Values.Text = "CANCEL ALLOCATION"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.refjo)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.projectlabel)
        Me.Panel1.Controls.Add(Me.refcombo)
        Me.Panel1.Controls.Add(Me.refstock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 466)
        Me.Panel1.TabIndex = 475
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Splitter1)
        Me.Panel4.Controls.Add(Me.allocationGridView)
        Me.Panel4.Controls.Add(Me.CHECKLISTEDgridview)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 91)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1241, 375)
        Me.Panel4.TabIndex = 480
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(495, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 375)
        Me.Splitter1.TabIndex = 471
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.KryptonButton3)
        Me.Panel2.Controls.Add(Me.KryptonGroup8)
        Me.Panel2.Controls.Add(Me.KryptonButton2)
        Me.Panel2.Controls.Add(Me.KryptonButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1241, 52)
        Me.Panel2.TabIndex = 479
        '
        'KryptonGroup8
        '
        Me.KryptonGroup8.Location = New System.Drawing.Point(102, 11)
        Me.KryptonGroup8.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonGroup8.Name = "KryptonGroup8"
        '
        'KryptonGroup8.Panel
        '
        Me.KryptonGroup8.Panel.Controls.Add(Me.REFERENCE)
        Me.KryptonGroup8.Size = New System.Drawing.Size(296, 30)
        Me.KryptonGroup8.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup8.StateCommon.Border.Rounding = 0
        Me.KryptonGroup8.StateCommon.Border.Width = 3
        Me.KryptonGroup8.TabIndex = 476
        '
        'REFERENCE
        '
        Me.REFERENCE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.REFERENCE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.REFERENCE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.REFERENCE.DropDownHeight = 206
        Me.REFERENCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REFERENCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFERENCE.FormattingEnabled = True
        Me.REFERENCE.IntegralHeight = False
        Me.REFERENCE.Location = New System.Drawing.Point(0, 0)
        Me.REFERENCE.Name = "REFERENCE"
        Me.REFERENCE.Size = New System.Drawing.Size(290, 24)
        Me.REFERENCE.TabIndex = 9
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton2.Location = New System.Drawing.Point(401, 11)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonButton2.Size = New System.Drawing.Size(94, 27)
        Me.KryptonButton2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton2.StateCommon.Border.Rounding = 0
        Me.KryptonButton2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton2.TabIndex = 477
        Me.KryptonButton2.Values.Text = "SEARCH"
        '
        'refjo
        '
        Me.refjo.FormattingEnabled = True
        Me.refjo.Location = New System.Drawing.Point(662, 152)
        Me.refjo.Name = "refjo"
        Me.refjo.Size = New System.Drawing.Size(121, 21)
        Me.refjo.TabIndex = 478
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Splitter2)
        Me.Panel3.Controls.Add(Me.KryptonLabel6)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1241, 39)
        Me.Panel3.TabIndex = 475
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 6)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonLabel6.Size = New System.Drawing.Size(173, 30)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 40
        Me.KryptonLabel6.Values.Text = "Checklisted Project"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1247, 472)
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Aqua
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Rounding = 0
        Me.KryptonGroup1.StateCommon.Border.Width = 3
        Me.KryptonGroup1.TabIndex = 477
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(0, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 39)
        Me.Splitter2.TabIndex = 41
        Me.Splitter2.TabStop = False
        '
        'checklisted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 472)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.Name = "checklisted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "checklisted"
        CType(Me.CHECKLISTEDgridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allocationGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.KryptonGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup8.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CHECKLISTEDgridview As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents projectlabel As TextBox
    Friend WithEvents allocationGridView As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents refcombo As ComboBox
    Friend WithEvents refstock As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CancelAllocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonGroup8 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents REFERENCE As ComboBox
    Friend WithEvents refjo As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Splitter2 As Splitter
End Class
