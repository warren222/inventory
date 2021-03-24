<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStockNo
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
        Me.KryptonGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.newtypecolor = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.transno = New System.Windows.Forms.ComboBox()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.jo = New System.Windows.Forms.ComboBox()
        Me.reference = New System.Windows.Forms.ComboBox()
        Me.xyz = New System.Windows.Forms.ComboBox()
        Me.transtype = New System.Windows.Forms.ComboBox()
        Me.articleno = New System.Windows.Forms.ComboBox()
        Me.costhead = New System.Windows.Forms.ComboBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup4.Panel.SuspendLayout()
        Me.KryptonGroup4.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonGroup4
        '
        Me.KryptonGroup4.Location = New System.Drawing.Point(129, 12)
        Me.KryptonGroup4.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonGroup4.Name = "KryptonGroup4"
        '
        'KryptonGroup4.Panel
        '
        Me.KryptonGroup4.Panel.Controls.Add(Me.newtypecolor)
        Me.KryptonGroup4.Size = New System.Drawing.Size(232, 30)
        Me.KryptonGroup4.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup4.StateCommon.Border.Rounding = 0
        Me.KryptonGroup4.StateCommon.Border.Width = 3
        Me.KryptonGroup4.TabIndex = 460
        '
        'newtypecolor
        '
        Me.newtypecolor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.newtypecolor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.newtypecolor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.newtypecolor.DropDownHeight = 206
        Me.newtypecolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newtypecolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newtypecolor.FormattingEnabled = True
        Me.newtypecolor.IntegralHeight = False
        Me.newtypecolor.Location = New System.Drawing.Point(0, 0)
        Me.newtypecolor.Name = "newtypecolor"
        Me.newtypecolor.Size = New System.Drawing.Size(226, 24)
        Me.newtypecolor.TabIndex = 447
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(22, 12)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonLabel25.Size = New System.Drawing.Size(86, 22)
        Me.KryptonLabel25.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel25.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel25.TabIndex = 456
        Me.KryptonLabel25.Values.Text = "Type / Color"
        '
        'transno
        '
        Me.transno.FormattingEnabled = True
        Me.transno.Location = New System.Drawing.Point(101, 218)
        Me.transno.Name = "transno"
        Me.transno.Size = New System.Drawing.Size(263, 21)
        Me.transno.TabIndex = 470
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonButton1.Location = New System.Drawing.Point(286, 58)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.KryptonButton1.Size = New System.Drawing.Size(75, 29)
        Me.KryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.KryptonButton1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.KryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.KryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.KryptonButton1.StateCommon.Border.Rounding = 0
        Me.KryptonButton1.StateCommon.Border.Width = 2
        Me.KryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonButton1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton1.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.KryptonButton1.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.KryptonButton1.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.KryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.KryptonButton1.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.TabIndex = 471
        Me.KryptonButton1.Values.Text = "Save"
        '
        'jo
        '
        Me.jo.FormattingEnabled = True
        Me.jo.Location = New System.Drawing.Point(101, 245)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(263, 21)
        Me.jo.TabIndex = 472
        '
        'reference
        '
        Me.reference.FormattingEnabled = True
        Me.reference.Location = New System.Drawing.Point(101, 272)
        Me.reference.Name = "reference"
        Me.reference.Size = New System.Drawing.Size(263, 21)
        Me.reference.TabIndex = 473
        '
        'xyz
        '
        Me.xyz.FormattingEnabled = True
        Me.xyz.Location = New System.Drawing.Point(101, 299)
        Me.xyz.Name = "xyz"
        Me.xyz.Size = New System.Drawing.Size(263, 21)
        Me.xyz.TabIndex = 474
        '
        'transtype
        '
        Me.transtype.FormattingEnabled = True
        Me.transtype.Location = New System.Drawing.Point(101, 326)
        Me.transtype.Name = "transtype"
        Me.transtype.Size = New System.Drawing.Size(263, 21)
        Me.transtype.TabIndex = 475
        '
        'articleno
        '
        Me.articleno.FormattingEnabled = True
        Me.articleno.Location = New System.Drawing.Point(101, 380)
        Me.articleno.Name = "articleno"
        Me.articleno.Size = New System.Drawing.Size(263, 21)
        Me.articleno.TabIndex = 477
        '
        'costhead
        '
        Me.costhead.FormattingEnabled = True
        Me.costhead.Location = New System.Drawing.Point(101, 353)
        Me.costhead.Name = "costhead"
        Me.costhead.Size = New System.Drawing.Size(263, 21)
        Me.costhead.TabIndex = 476
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProgressBar2.Location = New System.Drawing.Point(-3, 93)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(405, 26)
        Me.ProgressBar2.TabIndex = 478
        Me.ProgressBar2.Visible = False
        '
        'UpdateStockNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(399, 116)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.articleno)
        Me.Controls.Add(Me.costhead)
        Me.Controls.Add(Me.transtype)
        Me.Controls.Add(Me.xyz)
        Me.Controls.Add(Me.reference)
        Me.Controls.Add(Me.jo)
        Me.Controls.Add(Me.KryptonButton1)
        Me.Controls.Add(Me.transno)
        Me.Controls.Add(Me.KryptonGroup4)
        Me.Controls.Add(Me.KryptonLabel25)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(415, 155)
        Me.MinimumSize = New System.Drawing.Size(415, 155)
        Me.Name = "UpdateStockNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Color"
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonGroup4 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents newtypecolor As ComboBox
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents transno As ComboBox
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents jo As ComboBox
    Friend WithEvents reference As ComboBox
    Friend WithEvents xyz As ComboBox
    Friend WithEvents transtype As ComboBox
    Friend WithEvents articleno As ComboBox
    Friend WithEvents costhead As ComboBox
    Friend WithEvents ProgressBar2 As ProgressBar
End Class
