<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuttingListRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuttingListRecord))
        Me.GV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAllocation = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal_In = New System.Windows.Forms.Label()
        Me.lblPhysical = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal_Out = New System.Windows.Forms.Label()
        Me.lblTotal_For_Release = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblArticleno = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboxRefernce = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV
        '
        Me.GV.AllowUserToAddRows = False
        Me.GV.AllowUserToDeleteRows = False
        Me.GV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GV.ColumnHeadersHeight = 32
        Me.GV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GV.Location = New System.Drawing.Point(0, 191)
        Me.GV.Name = "GV"
        Me.GV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GV.RowHeadersWidth = 30
        Me.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GV.Size = New System.Drawing.Size(954, 355)
        Me.GV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.GV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.GV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GV.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GV.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GV.TabIndex = 629
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(794, 0)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(160, 30)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 594
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblArticleno)
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 131)
        Me.Panel1.TabIndex = 627
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblAllocation, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotal_In, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPhysical, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotal_Out, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotal_For_Release, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBalance, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.90476!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.09524!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(951, 74)
        Me.TableLayoutPanel1.TabIndex = 599
        '
        'lblAllocation
        '
        Me.lblAllocation.AutoSize = True
        Me.lblAllocation.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllocation.ForeColor = System.Drawing.Color.Blue
        Me.lblAllocation.Location = New System.Drawing.Point(795, 29)
        Me.lblAllocation.Name = "lblAllocation"
        Me.lblAllocation.Size = New System.Drawing.Size(101, 22)
        Me.lblAllocation.TabIndex = 607
        Me.lblAllocation.Text = "lblAllocation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(795, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 19)
        Me.Label8.TabIndex = 608
        Me.Label8.Text = "Allocation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 602
        Me.Label1.Text = "Total In"
        '
        'lblTotal_In
        '
        Me.lblTotal_In.AutoSize = True
        Me.lblTotal_In.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_In.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal_In.Location = New System.Drawing.Point(5, 29)
        Me.lblTotal_In.Name = "lblTotal_In"
        Me.lblTotal_In.Size = New System.Drawing.Size(77, 22)
        Me.lblTotal_In.TabIndex = 599
        Me.lblTotal_In.Text = "lblTotalIn"
        '
        'lblPhysical
        '
        Me.lblPhysical.AutoSize = True
        Me.lblPhysical.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysical.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPhysical.Location = New System.Drawing.Point(637, 29)
        Me.lblPhysical.Name = "lblPhysical"
        Me.lblPhysical.Size = New System.Drawing.Size(85, 22)
        Me.lblPhysical.TabIndex = 605
        Me.lblPhysical.Text = "lblPhysical"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(637, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 606
        Me.Label6.Text = "Physical"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(163, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 600
        Me.Label4.Text = "Total Out"
        '
        'lblTotal_Out
        '
        Me.lblTotal_Out.AutoSize = True
        Me.lblTotal_Out.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_Out.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal_Out.Location = New System.Drawing.Point(163, 29)
        Me.lblTotal_Out.Name = "lblTotal_Out"
        Me.lblTotal_Out.Size = New System.Drawing.Size(90, 22)
        Me.lblTotal_Out.TabIndex = 597
        Me.lblTotal_Out.Text = "lblTotalOut"
        '
        'lblTotal_For_Release
        '
        Me.lblTotal_For_Release.AutoSize = True
        Me.lblTotal_For_Release.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_For_Release.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal_For_Release.Location = New System.Drawing.Point(479, 29)
        Me.lblTotal_For_Release.Name = "lblTotal_For_Release"
        Me.lblTotal_For_Release.Size = New System.Drawing.Size(144, 22)
        Me.lblTotal_For_Release.TabIndex = 598
        Me.lblTotal_For_Release.Text = "lblTotalForRelease"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(479, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 601
        Me.Label3.Text = "For Release"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBalance.Location = New System.Drawing.Point(321, 29)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(85, 22)
        Me.lblBalance.TabIndex = 603
        Me.lblBalance.Text = "lblBalance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(321, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 604
        Me.Label5.Text = "Balance"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDescription.Location = New System.Drawing.Point(5, 30)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 19)
        Me.lblDescription.TabIndex = 598
        Me.lblDescription.Text = "Description"
        '
        'lblArticleno
        '
        Me.lblArticleno.AutoSize = True
        Me.lblArticleno.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticleno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblArticleno.Location = New System.Drawing.Point(5, 6)
        Me.lblArticleno.Name = "lblArticleno"
        Me.lblArticleno.Size = New System.Drawing.Size(80, 23)
        Me.lblArticleno.TabIndex = 597
        Me.lblArticleno.Text = "Articleno"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Button1.Location = New System.Drawing.Point(687, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 36)
        Me.Button1.TabIndex = 630
        Me.Button1.Text = "adjust stocks"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.tboxRefernce)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cboxStatus)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 60)
        Me.Panel2.TabIndex = 630
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.PaleGreen
        Me.Button3.Location = New System.Drawing.Point(800, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 36)
        Me.Button3.TabIndex = 636
        Me.Button3.Text = "update status"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(594, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 635
        Me.Button2.Text = "Find"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(47, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 19)
        Me.Label7.TabIndex = 634
        Me.Label7.Text = "Reference/Client"
        '
        'tboxRefernce
        '
        Me.tboxRefernce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxRefernce.Location = New System.Drawing.Point(172, 19)
        Me.tboxRefernce.Name = "tboxRefernce"
        Me.tboxRefernce.Size = New System.Drawing.Size(232, 23)
        Me.tboxRefernce.TabIndex = 633
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(410, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 632
        Me.Label2.Text = "Status"
        '
        'cboxStatus
        '
        Me.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Items.AddRange(New Object() {"All", "For release", "Released"})
        Me.cboxStatus.Location = New System.Drawing.Point(465, 19)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(123, 24)
        Me.cboxStatus.TabIndex = 631
        '
        'CuttingListRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 546)
        Me.Controls.Add(Me.GV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CuttingListRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cutting List Record"
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal_Out As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal_In As Label
    Friend WithEvents lblTotal_For_Release As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblArticleno As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAllocation As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPhysical As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tboxRefernce As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxStatus As ComboBox
    Friend WithEvents Button3 As Button
End Class
