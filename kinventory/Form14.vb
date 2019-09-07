Imports Microsoft.Reporting.WinForms

Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim param1 As ReportParameter = New ReportParameter("v", Form2.vchk.Checked)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Form14_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class