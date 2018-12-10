Imports System.Data.SqlClient
Public Class changereferenceFRM
    Dim sql As New sql
    Public Shared oldreference As String
    Public Shared oldjo As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        genreferenceFRM.Text = "change reference"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("save changes", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Dim str As String = "declare @add as varchar(100) = (select fulladd from kmdidata.dbo.addendum_to_contract_tb where job_order_no = '" & jo.Text & "')
                            update trans_tb set reference = '" & reference.Text & "' , jo = '" & jo.Text & "' where reference = '" & oldreference & "' and jo = '" & oldjo & "'
                            update reference_tb set address=@add,reference = '" & reference.Text & "' , jo = '" & jo.Text & "' where reference = '" & oldreference & "' and jo = '" & oldjo & "'"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        Form2.KryptonButton12.PerformClick()
        Me.Close()
    End Sub

    Private Sub changereferenceFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "Change from

REFERENCE------------------" & oldreference & "
JO----------------------------" & oldjo & "

to

NEW REFEERNCE----------" & reference.Text & "
NEW JO--------------------" & jo.Text & ""
    End Sub

    Private Sub changereferenceFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class