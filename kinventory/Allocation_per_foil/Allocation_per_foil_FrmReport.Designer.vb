<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Allocation_per_foil_FrmReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Allocation_Per_Foil_TblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inventoryds = New kinventory.inventoryds()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Allocation_Per_Foil_TblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Allocation_Per_Foil_TblBindingSource
        '
        Me.Allocation_Per_Foil_TblBindingSource.DataMember = "Allocation_Per_Foil_Tbl"
        Me.Allocation_Per_Foil_TblBindingSource.DataSource = Me.inventoryds
        '
        'inventoryds
        '
        Me.inventoryds.DataSetName = "inventoryds"
        Me.inventoryds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Allocation_Per_Foil_TblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "kinventory.Allocation_per_foil_RPT.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(604, 415)
        Me.ReportViewer1.TabIndex = 0
        '
        'Allocation_per_foil_FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 415)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Allocation_per_foil_FrmReport"
        CType(Me.Allocation_Per_Foil_TblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Allocation_Per_Foil_TblBindingSource As BindingSource
    Friend WithEvents inventoryds As inventoryds
End Class
