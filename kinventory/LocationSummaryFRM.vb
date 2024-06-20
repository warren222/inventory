Imports System.Data.SqlClient

Public Class LocationSummaryFRM
    Dim sql As New sql
    Private Sub LocationSummaryFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsummary()
    End Sub
    Dim summarylocation As String
    Private Sub KryptonDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellClick
        If KryptonDataGridView1.RowCount >= 0 And e.RowIndex >= 0 Then
            summarylocation = KryptonDataGridView1.Item(0, e.RowIndex).Value.ToString
        End If
    End Sub
    Private Sub KryptonDataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellDoubleClick
        HISTORY.location.Text = summarylocation
        HISTORY.stockno.Text = ""
        HISTORY.ShowDialog()
    End Sub
    Public Sub loadsummary()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_Summary")
                    sqlcmd.Parameters.AddWithValue("@Visibility", locationform.CboxHideZero.Text)
                    sqlcmd.Parameters.AddWithValue("@Search", tboxFind.Text)
                    Dim ds As New DataSet
                    ds.Clear()
                    Dim bs As New BindingSource
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "locationtb")
                        bs.DataSource = ds
                        bs.DataMember = "locationtb"
                    End Using
                    KryptonDataGridView1.DataSource = bs
                    KryptonDataGridView1.Columns("LOCATION").DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                    KryptonDataGridView1.Columns("QTY").DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                    KryptonDataGridView1.Columns("QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    KryptonDataGridView1.Columns("QTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    KryptonDataGridView1.Columns("QTY").DefaultCellStyle.Format = "N2"
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadsummary()
    End Sub
End Class