<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatereferenceFRM
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
        Me.gv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv
        '
        Me.gv.AllowUserToAddRows = False
        Me.gv.AllowUserToDeleteRows = False
        Me.gv.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gv.ColumnHeadersHeight = 30
        Me.gv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gv.Location = New System.Drawing.Point(12, 12)
        Me.gv.Name = "gv"
        Me.gv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.gv.ReadOnly = True
        Me.gv.RowHeadersWidth = 40
        Me.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gv.Size = New System.Drawing.Size(473, 396)
        Me.gv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.gv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.gv.StateCommon.DataCell.Border.Width = 0
        Me.gv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.gv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.gv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.gv.StateCommon.HeaderColumn.Border.Width = 0
        Me.gv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.gv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.gv.TabIndex = 1
        '
        'updatereferenceFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 420)
        Me.Controls.Add(Me.gv)
        Me.Name = "updatereferenceFRM"
        Me.Text = "updatereferenceFRM"
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
