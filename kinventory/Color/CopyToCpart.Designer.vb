<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CopyToCpart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyToCpart))
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(25, 3)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(137, 34)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 594
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.LoadingPBOX)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(189, 102)
        Me.Panel3.TabIndex = 595
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 79)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(189, 23)
        Me.ProgressBar1.TabIndex = 599
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CopyToCpart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 102)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CopyToCpart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
End Class
