Imports Microsoft.Reporting.WinForms

Public Class WarehouseReport
    Private Sub WarehouseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.ZoomMode = ZoomMode.PageWidth
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub WarehouseReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class