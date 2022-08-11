Imports System.Data.SqlClient

Public Class CopyTransaction
    Dim sql As New sql
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tboxreference.Text = "" Then
            MessageBox.Show("Reference is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If MessageBox.Show("Copy record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MessageBox.Show("Operation Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Form2.ProgressBar2.Visible = True
            Form2.ProgressBar2.Maximum = Form2.transnoAlist.Count
            Form2.ProgressBar2.Value = 0
            For i As Integer = 0 To Form2.transnoAlist.Count - 1
                Dim tno As String = Form2.transnoAlist(i).ToString
                Dim skno As String = Form2.stocknoAlist(i).ToString
                copyallocation(tno)
                updatestock(skno, tboxreference.Text, tboxjo.Text)
                Form2.ProgressBar2.Value += 1
            Next
            If Form2.ProgressBar2.Value = Form2.ProgressBar2.Maximum Then
                MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.ProgressBar2.Visible = False
                Me.Close()
            End If
        End If
    End Sub
    Public Sub copyallocation(ByVal tno As String)
        Try
            Dim str As String = "
declare @id as integer = (select max(transno)+1 from trans_tb)

insert into trans_tb 
     (transno,STOCKNO,
            TRANSTYPE,
            TRANSDATE,
            DUEDATE,
            QTY,
            BALQTY,
            REFERENCE,jo,
            ACCOUNT,
            CONTROLNO,
            XYZ,
            XYZREF,
            REMARKS,
            INPUTTED) 
select
            @id,STOCKNO,
             TRANSTYPE,
            TRANSDATE,
            DUEDATE,
            QTY,
            BALQTY,
            '" & tboxreference.Text & "','" & tboxjo.Text & "',
            ACCOUNT,
            CONTROLNO,
            XYZ,
            XYZREF,
            REMARKS,
            '" & Form1.nickname.Text & "'
 from trans_tb where transno = '" & tno & "'"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub updatestock(ByVal stockno As String, ByVal reference As String, ByVal jo As String)
        Dim str As String = "
                                    declare @stn as int = @stockno
                                    declare @allocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Return')+0
                                    declare @supply as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Supply')+0
                                    declare @spare as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Spare')+0
                                    declare @addadjustment as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='+Adjustment')+0
                                    declare @minadjustment as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='-Adjustment')+0
                                    declare @receipt as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
            update stocks_tb set 
                                    
                                    physical=(QTY+@totalreceipt+@return+@addadjustment)-(@totalissue+@minadjustment),
                                    allocation = @allocation-(@issueallocation+@cancelalloc),
                                    free=(((QTY+@totalreceipt+@return+@addadjustment)-(@allocation-@cancelalloc)))-(@issue+@minadjustment),
                                    stockorder=@order-@receiptorder,
                                    issue=@totalissue
                                    where stockno=@stn"

        Dim bny As String = "
                                    declare @stn as int = @stockno
                                    declare @allocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Return')+0
                                    declare @receipt as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
                              
update reference_tb set 

                                    allocation=@allocation-(@issueallocation+@cancelalloc),
                                    stockorder=@order-@receiptorder,
                                    TOTALRECEIPT=@totalreceipt,
                                    totalissue=@totalissue,
                                    totalreturn=@return
                                    where stockno=@stn and reference='" & reference & "'  and jo = '" & jo & "'"

        'Dim NEWSTR As String = "
        '                        declare @allocation as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Allocation')+0
        '                        declare @order as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Order')+0
        '                        declare @receipt as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Receipt')+0
        '                        declare @issue as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Issue')+0

        'update reference_tb set 

        '                        allocation=@allocation-@issue,
        '                        stockorder=@order-@receipt,
        '                        TOTALRECEIPT=@receipt,
        '                        totalissue=@issue
        '                        where stockno='" & stockno & "' and reference='" & reference & "'"
        'sqlcmd = New SqlCommand(NEWSTR, sql.sqlcon)
        'sqlcmd.ExecuteNonQuery()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@stockno", stockno)
                    sqlcmd.CommandTimeout = 600
                    sqlcmd.ExecuteNonQuery()
                End Using
                Using sqlcmd As SqlCommand = New SqlCommand(bny, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@stockno", stockno)
                    sqlcmd.CommandTimeout = 600
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        genreferenceFRM.Text = "copy alloc"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub CopyTansaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CopyTransaction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class