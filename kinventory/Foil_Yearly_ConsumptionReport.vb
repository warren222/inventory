Imports Microsoft.Reporting.WinForms

Public Class Foil_Yearly_ConsumptionReport
    Private Sub Foil_Yearly_ConsumptionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.ZoomMode -= Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Foil_Yearly_ConsumptionReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class