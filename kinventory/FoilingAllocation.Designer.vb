<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoilingAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoilingAllocation))
        Me.sourceArticleCbox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sourceColorCbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sourceCostheadCbox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sourceArticleCbox
        '
        Me.sourceArticleCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sourceArticleCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceArticleCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceArticleCbox.DropDownHeight = 206
        Me.sourceArticleCbox.FormattingEnabled = True
        Me.sourceArticleCbox.IntegralHeight = False
        Me.sourceArticleCbox.Location = New System.Drawing.Point(93, 124)
        Me.sourceArticleCbox.Name = "sourceArticleCbox"
        Me.sourceArticleCbox.Size = New System.Drawing.Size(258, 21)
        Me.sourceArticleCbox.TabIndex = 477
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 476
        Me.Label6.Text = "Article#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 475
        Me.Label5.Text = "Color"
        '
        'sourceColorCbox
        '
        Me.sourceColorCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sourceColorCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceColorCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceColorCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceColorCbox.FormattingEnabled = True
        Me.sourceColorCbox.Location = New System.Drawing.Point(93, 75)
        Me.sourceColorCbox.Name = "sourceColorCbox"
        Me.sourceColorCbox.Size = New System.Drawing.Size(258, 21)
        Me.sourceColorCbox.TabIndex = 474
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 473
        Me.Label4.Text = "Costhead"
        '
        'sourceCostheadCbox
        '
        Me.sourceCostheadCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sourceCostheadCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sourceCostheadCbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sourceCostheadCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceCostheadCbox.FormattingEnabled = True
        Me.sourceCostheadCbox.Location = New System.Drawing.Point(93, 31)
        Me.sourceCostheadCbox.Name = "sourceCostheadCbox"
        Me.sourceCostheadCbox.Size = New System.Drawing.Size(258, 21)
        Me.sourceCostheadCbox.TabIndex = 472
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(243, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 36)
        Me.Button2.TabIndex = 478
        Me.Button2.Text = "Normal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(29, 165)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(72, 34)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 594
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(129, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 36)
        Me.Button1.TabIndex = 595
        Me.Button1.Text = "Color-based"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FoilingAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 211)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LoadingPBOX)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.sourceArticleCbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sourceColorCbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sourceCostheadCbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FoilingAllocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sourceArticleCbox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sourceColorCbox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sourceCostheadCbox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Button1 As Button
End Class
