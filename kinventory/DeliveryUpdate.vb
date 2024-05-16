Imports System.Data.SqlClient

Public Class DeliveryUpdate
    Dim sql As New sql
    Public Shared transnoList As New ArrayList
    Private Sub DeliveryUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Update the status of the selected items", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Exit Sub
        End If
        UpdateStatus(cboxStatus.Text)
    End Sub

    Private Sub UpdateStatus(ByVal deliver_status As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                For i As Integer = 0 To transnoList.Count - 1
                    Dim transno As String = transnoList(i).ToString
                    Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                        sqlcmd.CommandText = "Delivery_Status_Stp"
                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.AddWithValue("@Command", "Update_Status")
                        sqlcmd.Parameters.AddWithValue("@Delivery_Status", deliver_status)
                        sqlcmd.Parameters.AddWithValue("@Transno", transno)
                        sqlcmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Form4.KryptonButton4.PerformClick()
            Me.Close()
        End Try
    End Sub
    Private Sub LoadStatus()
        Try
            Dim ds As New DataSet
            Dim bs As New BindingSource
            ds.Clear()

            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcmd.CommandText = "Delivery_Status_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@Command", "Load_Status")
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "transtb")
                        bs.DataSource = ds
                        bs.DataMember = "transtb"
                        cboxStatus.DataSource = bs
                        cboxStatus.ValueMember = "delivery_status"
                        cboxStatus.DisplayMember = "delivery_status"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class