<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorMngrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASRefoilingQuotationSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.accounttype = New System.Windows.Forms.Label()
        Me.nickname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AccountsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1088, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ColorMngrToolStripMenuItem, Me.ASRefoilingQuotationSummaryToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FileToolStripMenuItem.Text = "System"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.NewToolStripMenuItem.Text = "Inventory"
        '
        'ColorMngrToolStripMenuItem
        '
        Me.ColorMngrToolStripMenuItem.Name = "ColorMngrToolStripMenuItem"
        Me.ColorMngrToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ColorMngrToolStripMenuItem.Text = "ColorMngr"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.LogOutToolStripMenuItem.Text = "log out"
        '
        'ASRefoilingQuotationSummaryToolStripMenuItem
        '
        Me.ASRefoilingQuotationSummaryToolStripMenuItem.Name = "ASRefoilingQuotationSummaryToolStripMenuItem"
        Me.ASRefoilingQuotationSummaryToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ASRefoilingQuotationSummaryToolStripMenuItem.Text = "AS Refoiling Quotation Summary"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageAccountsToolStripMenuItem, Me.ManageColumnsToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'ManageAccountsToolStripMenuItem
        '
        Me.ManageAccountsToolStripMenuItem.Name = "ManageAccountsToolStripMenuItem"
        Me.ManageAccountsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ManageAccountsToolStripMenuItem.Text = "Manage Accounts"
        '
        'ManageColumnsToolStripMenuItem
        '
        Me.ManageColumnsToolStripMenuItem.Name = "ManageColumnsToolStripMenuItem"
        Me.ManageColumnsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ManageColumnsToolStripMenuItem.Text = "Manage Columns"
        '
        'accounttype
        '
        Me.accounttype.AutoSize = True
        Me.accounttype.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.accounttype.Location = New System.Drawing.Point(57, 17)
        Me.accounttype.Name = "accounttype"
        Me.accounttype.Size = New System.Drawing.Size(39, 13)
        Me.accounttype.TabIndex = 458
        Me.accounttype.Text = "Label2"
        '
        'nickname
        '
        Me.nickname.AutoSize = True
        Me.nickname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nickname.Location = New System.Drawing.Point(12, 17)
        Me.nickname.Name = "nickname"
        Me.nickname.Size = New System.Drawing.Size(39, 13)
        Me.nickname.TabIndex = 457
        Me.nickname.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.nickname)
        Me.Panel1.Controls.Add(Me.accounttype)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 0)
        Me.Panel1.TabIndex = 459
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1088, 472)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents accounttype As Label
    Friend WithEvents nickname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ManageColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorMngrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASRefoilingQuotationSummaryToolStripMenuItem As ToolStripMenuItem
End Class
