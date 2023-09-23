Imports System.Data.SqlClient

Public Class FOILvsPVCreport
    Dim sql As New sql
    Private Sub FOILvsPVCreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub loadReport()
        Using sqlConnection As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlCommand As SqlCommand = sqlConnection.CreateCommand
                Try
                    Dim ds As New inventoryds
                    ds.Clear()
                    sqlConnection.Open()
                    sqlCommand.CommandText = "PVC_FOIL_Stp"
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