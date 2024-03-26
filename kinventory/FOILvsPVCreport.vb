Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FOILvsPVCreport
    Dim sql As New sql
    Private Sub FOILvsPVCreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
        Dim asof As String = ""
        If Form2.cboxMonth1.Text = Form2.cboxMonth2.Text Then
            asof = Form2.cboxMonth1.Text + " " + Form2.cboxYear.Text
        Else
            asof = Form2.cboxMonth1.Text + " - " + Form2.cboxMonth2.Text + " " + Form2.cboxYear.Text
        End If
        Dim param As ReportParameter = New ReportParameter("asof", asof)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param})

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub loadReport()
        Using sqlConnection As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlCommand As SqlCommand = sqlConnection.CreateCommand
                Try
                    Dim ds As New inventoryds
                    ds.Clear()
                    Dim sdate As String = Form2.cboxYear.Text + "-" + Form2.cboxMonth1.Text + "-01"
                    Dim edate As String = Form2.cboxYear.Text + "-" + Form2.cboxMonth2.Text + "-01"
                    sqlConnection.Open()
                    sqlCommand.CommandText = "PVC_FOIL_Consumption_Stp"
                    sqlCommand.Parameters.AddWithValue("@Sdate", sdate)
                    sqlCommand.Parameters.AddWithValue("@Edate", edate)
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    Using da As SqlDataAdapter = New SqlDataAdapter()
                        da.SelectCommand = sqlCommand
                        da.Fill(ds.FOIL_PVC)
                        FOIL_PVCBindingSource.DataSource = ds.FOIL_PVC.DefaultView
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End Using
        End Using
    End Sub

    Private Sub FOILvsPVCreport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ReportViewer1.RefreshReport()
    End Sub
End Class