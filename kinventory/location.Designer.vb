<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class locationform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(locationform))
        Me.locationgridview = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.articleno = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonButton8 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.setlocation = New System.Windows.Forms.ComboBox()
        Me.KryptonButton7 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CboxHideZero = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdjustmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.LocationHistoryGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblLocationHeader = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tboxLocation = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.balance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KryptonButton5 = New System.Windows.Forms.Button()
        Me.currentqty = New System.Windows.Forms.TextBox()
        Me.KryptonButton4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.setqty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.minusr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.locationgridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.LocationHistoryGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'locationgridview
        '
        Me.locationgridview.AllowUserToAddRows = False
        Me.locationgridview.AllowUserToDeleteRows = False
        Me.locationgridview.AllowUserToOrderColumns = True
        Me.locationgridview.AllowUserToResizeColumns = False
        Me.locationgridview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.locationgridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.locationgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.locationgridview.ColumnHeadersHeight = 30
        Me.locationgridview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.locationgridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.locationgridview.Location = New System.Drawing.Point(0, 32)
        Me.locationgridview.Name = "locationgridview"
        Me.locationgridview.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.locationgridview.ReadOnly = True
        Me.locationgridview.RowHeadersVisible = False
        Me.locationgridview.RowHeadersWidth = 40
        Me.locationgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.locationgridview.Size = New System.Drawing.Size(412, 263)
        Me.locationgridview.StateCommon.Background.Color1 = System.Drawing.SystemColors.Control
        Me.locationgridview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.locationgridview.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.locationgridview.StateCommon.DataCell.Border.Width = 0
        Me.locationgridview.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.locationgridview.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.locationgridview.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.locationgridview.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.locationgridview.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.locationgridview.StateCommon.HeaderColumn.Border.Width = 0
        Me.locationgridview.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.locationgridview.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.locationgridview.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.locationgridview.TabIndex = 461
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton1.Location = New System.Drawing.Point(33, 58)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton1.Size = New System.Drawing.Size(60, 27)
        Me.KryptonButton1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.StateCommon.Border.Rounding = 4
        Me.KryptonButton1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton1.TabIndex = 462
        Me.KryptonButton1.Values.Text = "Add"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton2.Location = New System.Drawing.Point(99, 58)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton2.Size = New System.Drawing.Size(60, 27)
        Me.KryptonButton2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton2.StateCommon.Border.Rounding = 4
        Me.KryptonButton2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton2.TabIndex = 463
        Me.KryptonButton2.Values.Text = "Update"
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton3.Location = New System.Drawing.Point(165, 58)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton3.Size = New System.Drawing.Size(60, 27)
        Me.KryptonButton3.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton3.StateCommon.Border.Rounding = 4
        Me.KryptonButton3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton3.TabIndex = 464
        Me.KryptonButton3.Values.Text = "Delete"
        '
        'articleno
        '
        Me.articleno.AutoSize = False
        Me.articleno.Location = New System.Drawing.Point(281, 3)
        Me.articleno.Name = "articleno"
        Me.articleno.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.articleno.Size = New System.Drawing.Size(412, 36)
        Me.articleno.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.articleno.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.articleno.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.articleno.TabIndex = 471
        Me.articleno.Values.Text = "Article #"
        '
        'KryptonButton8
        '
        Me.KryptonButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton8.Location = New System.Drawing.Point(231, 58)
        Me.KryptonButton8.Name = "KryptonButton8"
        Me.KryptonButton8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton8.Size = New System.Drawing.Size(60, 27)
        Me.KryptonButton8.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton8.StateCommon.Border.Rounding = 4
        Me.KryptonButton8.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton8.TabIndex = 465
        Me.KryptonButton8.Values.Text = "Reload"
        '
        'setlocation
        '
        Me.setlocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.setlocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.setlocation.DropDownHeight = 206
        Me.setlocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setlocation.FormattingEnabled = True
        Me.setlocation.IntegralHeight = False
        Me.setlocation.Location = New System.Drawing.Point(44, 43)
        Me.setlocation.Name = "setlocation"
        Me.setlocation.Size = New System.Drawing.Size(156, 33)
        Me.setlocation.TabIndex = 19
        '
        'KryptonButton7
        '
        Me.KryptonButton7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KryptonButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton7.Location = New System.Drawing.Point(861, 137)
        Me.KryptonButton7.Name = "KryptonButton7"
        Me.KryptonButton7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton7.Size = New System.Drawing.Size(144, 38)
        Me.KryptonButton7.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.KryptonButton7.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton7.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.KryptonButton7.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.KryptonButton7.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton7.StateCommon.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton7.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.KryptonButton7.StateCommon.Border.Rounding = 10
        Me.KryptonButton7.StateCommon.Border.Width = 2
        Me.KryptonButton7.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonButton7.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton7.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton7.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.KryptonButton7.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.KryptonButton7.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton7.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton7.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton7.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KryptonButton7.TabIndex = 478
        Me.KryptonButton7.Values.Text = "Summary"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "set"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CboxHideZero
        '
        Me.CboxHideZero.BackColor = System.Drawing.Color.White
        Me.CboxHideZero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxHideZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxHideZero.FormattingEnabled = True
        Me.CboxHideZero.Items.AddRange(New Object() {"Hide", "Show"})
        Me.CboxHideZero.Location = New System.Drawing.Point(14, 28)
        Me.CboxHideZero.Name = "CboxHideZero"
        Me.CboxHideZero.Size = New System.Drawing.Size(71, 24)
        Me.CboxHideZero.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdjustmentToolStripMenuItem, Me.TransferToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 48)
        '
        'AdjustmentToolStripMenuItem
        '
        Me.AdjustmentToolStripMenuItem.Name = "AdjustmentToolStripMenuItem"
        Me.AdjustmentToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AdjustmentToolStripMenuItem.Text = "Adjustment"
        '
        'TransferToolStripMenuItem
        '
        Me.TransferToolStripMenuItem.Name = "TransferToolStripMenuItem"
        Me.TransferToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.TransferToolStripMenuItem.Text = "Transfer"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1014, 564)
        Me.Panel6.TabIndex = 481
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel8.Controls.Add(Me.Panel13)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 175)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1014, 389)
        Me.Panel8.TabIndex = 488
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LocationHistoryGV)
        Me.Panel13.Controls.Add(Me.Panel11)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(412, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(602, 389)
        Me.Panel13.TabIndex = 16
        '
        'LocationHistoryGV
        '
        Me.LocationHistoryGV.AllowUserToAddRows = False
        Me.LocationHistoryGV.AllowUserToDeleteRows = False
        Me.LocationHistoryGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LocationHistoryGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.LocationHistoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LocationHistoryGV.ColumnHeadersHeight = 20
        Me.LocationHistoryGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LocationHistoryGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocationHistoryGV.Location = New System.Drawing.Point(0, 32)
        Me.LocationHistoryGV.Name = "LocationHistoryGV"
        Me.LocationHistoryGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.LocationHistoryGV.ReadOnly = True
        Me.LocationHistoryGV.RowHeadersWidth = 25
        Me.LocationHistoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LocationHistoryGV.Size = New System.Drawing.Size(602, 357)
        Me.LocationHistoryGV.StateCommon.Background.Color1 = System.Drawing.SystemColors.Control
        Me.LocationHistoryGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.LocationHistoryGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.LocationHistoryGV.StateCommon.DataCell.Border.Width = 0
        Me.LocationHistoryGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LocationHistoryGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.LocationHistoryGV.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel11.Controls.Add(Me.lblLocationHeader)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(602, 32)
        Me.Panel11.TabIndex = 15
        '
        'lblLocationHeader
        '
        Me.lblLocationHeader.AutoSize = True
        Me.lblLocationHeader.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationHeader.ForeColor = System.Drawing.Color.Black
        Me.lblLocationHeader.Location = New System.Drawing.Point(3, 4)
        Me.lblLocationHeader.Name = "lblLocationHeader"
        Me.lblLocationHeader.Size = New System.Drawing.Size(136, 23)
        Me.lblLocationHeader.TabIndex = 484
        Me.lblLocationHeader.Text = "Location History"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel9.Controls.Add(Me.locationgridview)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(412, 389)
        Me.Panel9.TabIndex = 14
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Linen
        Me.Panel12.Controls.Add(Me.Label8)
        Me.Panel12.Controls.Add(Me.Panel1)
        Me.Panel12.Controls.Add(Me.tboxLocation)
        Me.Panel12.Controls.Add(Me.KryptonButton8)
        Me.Panel12.Controls.Add(Me.KryptonButton3)
        Me.Panel12.Controls.Add(Me.KryptonButton1)
        Me.Panel12.Controls.Add(Me.KryptonButton2)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 295)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(412, 94)
        Me.Panel12.TabIndex = 462
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(30, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 488
        Me.Label8.Text = "Location"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CboxHideZero)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(318, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 94)
        Me.Panel1.TabIndex = 487
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(19, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 489
        Me.Label9.Text = "zero qty"
        '
        'tboxLocation
        '
        Me.tboxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxLocation.Location = New System.Drawing.Point(33, 28)
        Me.tboxLocation.Name = "tboxLocation"
        Me.tboxLocation.Size = New System.Drawing.Size(258, 24)
        Me.tboxLocation.TabIndex = 486
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightBlue
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(412, 32)
        Me.Panel10.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(155, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 483
        Me.Label7.Text = "Location Table"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Controls.Add(Me.LoadingPBOX)
        Me.Panel7.Controls.Add(Me.Panel2)
        Me.Panel7.Controls.Add(Me.KryptonButton7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1014, 175)
        Me.Panel7.TabIndex = 483
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.articleno)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1014, 37)
        Me.Panel3.TabIndex = 645
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(899, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 37)
        Me.Button1.TabIndex = 644
        Me.Button1.Text = "C L O S E"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(3, 94)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(144, 74)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 643
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.setlocation)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.balance)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.KryptonButton5)
        Me.Panel2.Controls.Add(Me.currentqty)
        Me.Panel2.Controls.Add(Me.KryptonButton4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.setqty)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.minusr)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.addr)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(153, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 132)
        Me.Panel2.TabIndex = 488
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(308, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 19)
        Me.Label10.TabIndex = 488
        Me.Label10.Text = "INPUT FORM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(206, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 471
        Me.Label1.Text = "Transaction Qty"
        '
        'balance
        '
        Me.balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.balance.Enabled = False
        Me.balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance.Location = New System.Drawing.Point(209, 43)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(149, 24)
        Me.balance.TabIndex = 470
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(41, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 472
        Me.Label2.Text = "Select Location"
        '
        'KryptonButton5
        '
        Me.KryptonButton5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton5.Location = New System.Drawing.Point(528, 83)
        Me.KryptonButton5.Name = "KryptonButton5"
        Me.KryptonButton5.Size = New System.Drawing.Size(140, 34)
        Me.KryptonButton5.TabIndex = 487
        Me.KryptonButton5.Text = "- proceed to out"
        Me.KryptonButton5.UseVisualStyleBackColor = True
        '
        'currentqty
        '
        Me.currentqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentqty.Enabled = False
        Me.currentqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentqty.Location = New System.Drawing.Point(44, 93)
        Me.currentqty.Name = "currentqty"
        Me.currentqty.Size = New System.Drawing.Size(156, 24)
        Me.currentqty.TabIndex = 477
        Me.currentqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonButton4
        '
        Me.KryptonButton4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton4.Location = New System.Drawing.Point(528, 43)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.Size = New System.Drawing.Size(140, 34)
        Me.KryptonButton4.TabIndex = 486
        Me.KryptonButton4.Text = "+ proceed to in"
        Me.KryptonButton4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(41, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 478
        Me.Label3.Text = "Current Location Qty"
        '
        'setqty
        '
        Me.setqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setqty.Location = New System.Drawing.Point(209, 93)
        Me.setqty.Name = "setqty"
        Me.setqty.Size = New System.Drawing.Size(149, 30)
        Me.setqty.TabIndex = 485
        Me.setqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(206, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 479
        Me.Label4.Text = "Set Adjustment Qty"
        '
        'minusr
        '
        Me.minusr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.minusr.Enabled = False
        Me.minusr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusr.Location = New System.Drawing.Point(367, 93)
        Me.minusr.Name = "minusr"
        Me.minusr.Size = New System.Drawing.Size(155, 24)
        Me.minusr.TabIndex = 484
        Me.minusr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(364, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 481
        Me.Label5.Text = "Expected Balance (In)"
        '
        'addr
        '
        Me.addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addr.Enabled = False
        Me.addr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr.Location = New System.Drawing.Point(367, 43)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(155, 24)
        Me.addr.TabIndex = 483
        Me.addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(364, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 17)
        Me.Label6.TabIndex = 482
        Me.Label6.Text = "Expected Balance (Out)"
        '
        'locationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1014, 564)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "locationform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "location"
        Me.TransparencyKey = System.Drawing.Color.Green
        CType(Me.locationgridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.LocationHistoryGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents locationgridview As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents setlocation As ComboBox
    Friend WithEvents articleno As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton7 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AdjustmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KryptonButton8 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TransferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents CboxHideZero As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents balance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents currentqty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents minusr As TextBox
    Friend WithEvents addr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents setqty As TextBox
    Friend WithEvents KryptonButton5 As Button
    Friend WithEvents KryptonButton4 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents LocationHistoryGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblLocationHeader As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tboxLocation As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
