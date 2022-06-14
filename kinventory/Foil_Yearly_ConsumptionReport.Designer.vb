<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foil_Yearly_ConsumptionReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inventoryds = New kinventory.inventoryds()
        Me.monthly_consumptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.inventoryds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monthly_consumptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.monthly_consumptionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "kinventory.Foil_Yearly_Consumption_RDLC.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(855, 415)
        Me.ReportViewer1.TabIndex = 0
        '
        'inventoryds
        '
        Me.inventoryds.DataSetName = "inventoryds"
        Me.inventoryds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'monthly_consumptionBindingSource
        '
        Me.monthly_consumptionBindingSource.DataMember = "monthly_consumption"
        Me.monthly_consumptionBindingSource.DataSource = Me.inventoryds
        '
        'Foil_Yearly_ConsumptionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 415)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Foil_Yearly_ConsumptionReport"
        Me.Text = "Foil_Yearly_ConsumptionReport"
        CType(Me.inventoryds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monthly_consumptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents monthly_consumptionBindingSource As BindingSource
    Friend WithEvents inventoryds As inventoryds
End Class
