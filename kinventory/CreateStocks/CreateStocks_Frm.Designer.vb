<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateStocks_Frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateStocks_Frm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticleNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Header = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorBased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XRate = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.UFactor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.Monetary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoilA = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.FoilB = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.FoilColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToFoil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Supplier, Me.CostHead, Me.TypeColor, Me.ArticleNo, Me.Description, Me.Qty, Me.Unit, Me.UnitPrice, Me.Location, Me.Header, Me.ColorBased, Me.XRate, Me.UFactor, Me.Monetary, Me.FoilA, Me.FoilB, Me.FoilColor, Me.ToOrder, Me.ToFoil})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(157, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(896, 472)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Paste"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 495)
        Me.Panel1.TabIndex = 3
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(9, 3)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(137, 22)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 595
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 34)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Create Stocks"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(157, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(896, 23)
        Me.ProgressBar1.TabIndex = 600
        '
        'Supplier
        '
        Me.Supplier.HeaderText = "Supplier"
        Me.Supplier.Name = "Supplier"
        '
        'CostHead
        '
        Me.CostHead.HeaderText = "CostHead"
        Me.CostHead.Name = "CostHead"
        '
        'TypeColor
        '
        Me.TypeColor.HeaderText = "TypeColor"
        Me.TypeColor.Name = "TypeColor"
        '
        'ArticleNo
        '
        Me.ArticleNo.HeaderText = "ArticleNo"
        Me.ArticleNo.Name = "ArticleNo"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Qty
        '
        Me.Qty.DecimalPlaces = 2
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Qty.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Qty.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Qty.Name = "Qty"
        Me.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Qty.Width = 100
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        '
        'UnitPrice
        '
        Me.UnitPrice.DecimalPlaces = 4
        Me.UnitPrice.HeaderText = "UnitPrice"
        Me.UnitPrice.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UnitPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.UnitPrice.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UnitPrice.Width = 100
        '
        'Location
        '
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        '
        'Header
        '
        Me.Header.HeaderText = "Header"
        Me.Header.Name = "Header"
        '
        'ColorBased
        '
        Me.ColorBased.HeaderText = "ColorBased"
        Me.ColorBased.Name = "ColorBased"
        '
        'XRate
        '
        Me.XRate.DecimalPlaces = 2
        Me.XRate.HeaderText = "XRate"
        Me.XRate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.XRate.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.XRate.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.XRate.Name = "XRate"
        Me.XRate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.XRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.XRate.Width = 100
        '
        'UFactor
        '
        Me.UFactor.DecimalPlaces = 2
        Me.UFactor.HeaderText = "UFactor"
        Me.UFactor.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UFactor.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.UFactor.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UFactor.Name = "UFactor"
        Me.UFactor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UFactor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UFactor.Width = 100
        '
        'Monetary
        '
        Me.Monetary.HeaderText = "Monetary"
        Me.Monetary.Name = "Monetary"
        '
        'FoilA
        '
        Me.FoilA.HeaderText = "FoilA"
        Me.FoilA.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FoilA.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FoilA.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FoilA.Name = "FoilA"
        Me.FoilA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FoilA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FoilA.Width = 100
        '
        'FoilB
        '
        Me.FoilB.HeaderText = "FoilB"
        Me.FoilB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FoilB.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FoilB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FoilB.Name = "FoilB"
        Me.FoilB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FoilB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FoilB.Width = 100
        '
        'FoilColor
        '
        Me.FoilColor.HeaderText = "FoilColor"
        Me.FoilColor.Name = "FoilColor"
        '
        'ToOrder
        '
        Me.ToOrder.HeaderText = "ToOrder"
        Me.ToOrder.Name = "ToOrder"
        '
        'ToFoil
        '
        Me.ToFoil.HeaderText = "ToFoil"
        Me.ToFoil.Name = "ToFoil"
        '
        'CreateStocks_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 495)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CreateStocks_Frm"
        Me.Text = "CreateStocks_Frm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Supplier As DataGridViewTextBoxColumn
    Friend WithEvents CostHead As DataGridViewTextBoxColumn
    Friend WithEvents TypeColor As DataGridViewTextBoxColumn
    Friend WithEvents ArticleNo As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Qty As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents Header As DataGridViewTextBoxColumn
    Friend WithEvents ColorBased As DataGridViewTextBoxColumn
    Friend WithEvents XRate As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents UFactor As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents Monetary As DataGridViewTextBoxColumn
    Friend WithEvents FoilA As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents FoilB As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Friend WithEvents FoilColor As DataGridViewTextBoxColumn
    Friend WithEvents ToOrder As DataGridViewTextBoxColumn
    Friend WithEvents ToFoil As DataGridViewTextBoxColumn
End Class
