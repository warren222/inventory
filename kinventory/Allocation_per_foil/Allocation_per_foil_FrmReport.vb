Public Class Allocation_per_foil_FrmReport
    Private Sub Allocation_per_foil_FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Allocation_per_foil_FrmReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class