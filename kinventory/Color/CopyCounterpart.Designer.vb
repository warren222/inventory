<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyCounterpart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyCounterpart))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTypecolor = New System.Windows.Forms.Label()
        Me.lblCosthead = New System.Windows.Forms.Label()
        Me.lblArticleno = New System.Windows.Forms.Label()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sourceArticleCbox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sourceColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sourceCostheadCbox = New System.Windows.Forms.ComboBox()
        Me.sourcegv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.sourcegv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTypecolor)
        Me.Panel1.Controls.Add(Me.lblCosthead)
        Me.Panel1.Controls.Add(Me.lblArticleno)
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 85)
        Me.Panel1.TabIndex = 3
        '
        'lblTypecolor
        '
        Me.lblTypecolor.AutoSize = True
        Me.lblTypecolor.BackColor = System.Drawing.Color.Transparent
        Me.lblTypecolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypecolor.ForeColor = System.Drawing.Color.Black
        Me.lblTypecolor.Location = New System.Drawing.Point(3, 61)
        Me.lblTypecolor.Name = "lblTypecolor"
        Me.lblTypecolor.Size = New System.Drawing.Size(41, 17)
        Me.lblTypecolor.TabIndex = 596
        Me.lblTypecolor.Text = "Color"
        '
        'lblCosthead
        '
        Me.lblCosthead.AutoSize = True
        Me.lblCosthead.BackColor = System.Drawing.Color.Transparent
        Me.lblCosthead.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosthead.ForeColor = System.Drawing.Color.Black
        Me.lblCosthead.Location = New System.Drawing.Point(3, 44)
        Me.lblCosthead.Name = "lblCosthead"
        Me.lblCosthead.Size = New System.Drawing.Size(68, 17)
        Me.lblCosthead.TabIndex = 595
        Me.lblCosthead.Text = "Costhead"
        '
        'lblArticleno
        '
        Me.lblArticleno.AutoSize = True
        Me.lblArticleno.BackColor = System.Drawing.Color.Transparent
        Me.lblArticleno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticleno.ForeColor = System.Drawing.Color.Black
        Me.lblArticleno.Location = New System.Drawing.Point(3, 26)
        Me.lblArticleno.Name = "lblArticleno"
        Me.lblArticleno.Size = New System.Drawing.Size(55, 17)
        Me.lblArticleno.TabIndex = 594
        Me.lblArticleno.Text = "Article#"
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(579, 4)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(137, 34)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 593
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reference"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.sourceArticleCbox)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.sourceColorCbox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.sourceCostheadCbox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(716, 50)
        Me.Panel2.TabIndex = 4
        '
        'sourceArticleCbox
        '
        Me.sourceArticleCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sourceArticleCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceArticleCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceArticleCbox.DropDownHeight = 206
        Me.sourceArticleCbox.FormattingEnabled = True
        Me.sourceArticleCbox.IntegralHeight = False
        Me.sourceArticleCbox.Location = New System.Drawing.Point(445, 16)
        Me.sourceArticleCbox.Name = "sourceArticleCbox"
        Me.sourceArticleCbox.Size = New System.Drawing.Size(150, 21)
        Me.sourceArticleCbox.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(601, 14)
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
        Me.Label6.Location = New System.Drawing.Point(396, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Article#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 16)
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
        Me.sourceColorCbox.Location = New System.Drawing.Point(253, 16)
        Me.sourceColorCbox.Name = "sourceColorCbox"
        Me.sourceColorCbox.Size = New System.Drawing.Size(140, 21)
        Me.sourceColorCbox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
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
        Me.sourceCostheadCbox.Location = New System.Drawing.Point(70, 16)
        Me.sourceCostheadCbox.Name = "sourceCostheadCbox"
        Me.sourceCostheadCbox.Size = New System.Drawing.Size(140, 21)
        Me.sourceCostheadCbox.TabIndex = 10
        '
        'sourcegv
        '
        Me.sourcegv.AllowUserToAddRows = False
        Me.sourcegv.AllowUserToDeleteRows = False
        Me.sourcegv.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourcegv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.sourcegv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sourcegv.ColumnHeadersHeight = 30
        Me.sourcegv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sourcegv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sourcegv.Location = New System.Drawing.Point(0, 135)
        Me.sourcegv.Name = "sourcegv"
        Me.sourcegv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.sourcegv.ReadOnly = True
        Me.sourcegv.RowHeadersWidth = 40
        Me.sourcegv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sourcegv.Size = New System.Drawing.Size(716, 262)
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
        Me.sourcegv.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 397)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(716, 78)
        Me.Panel3.TabIndex = 6
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 55)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(716, 23)
        Me.ProgressBar1.TabIndex = 599
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(152, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(426, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CopyCounterpart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 475)
        Me.Controls.Add(Me.sourcegv)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CopyCounterpart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CopyCounterpart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.sourcegv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sourceArticleCbox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sourceColorCbox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sourceCostheadCbox As ComboBox
    Friend WithEvents sourcegv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblTypecolor As Label
    Friend WithEvents lblCosthead As Label
    Friend WithEvents lblArticleno As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
