Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class UpdateStockNo
    Dim sql As New sql
    Dim sqlcmd As New SqlCommand
    Private Sub UpdateStockNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typecolorgen1()
    End Sub



    Public Sub typecolorgen1()
        Try
            sql.sqlcon.Open()
            Dim str As String = "select distinct typecolor FROM STOCKS_TB order by typecolor asc"
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            newtypecolor.DataSource = bs
            newtypecolor.DisplayMember = "typecolor"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub



    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        If MessageBox.Show("Update record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ProgressBar2.Visible = True
        ProgressBar2.Maximum = transno.Items.Count
        ProgressBar2.Value = 0
        For i As Integer = 0 To transno.Items.Count - 1
            If (transtype.Items(i).ToString() = "Order" And Not xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Receipt" And xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Receipt" And Not xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Allocation" And Not xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Issue" And xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Issue" And Not xyz.Items(i).ToString() = "") Then
            Else
                If Exist(costhead.Items(i).ToString, newtypecolor.Text, articleno.Items(i).ToString) Then
                    KryptonButton1.Visible = False
                    ProgressBar2.Value += 1
                    Dim newstockno As String = GetStockno(costhead.Items(i).ToString, newtypecolor.Text, articleno.Items(i).ToString)
                    updatenewstockno(transno.Items(i).ToString(), newstockno)
                    findnewreference(newstockno, reference.Items(i).ToString(), jo.Items(i).ToString())
                    updatestock(newstockno, reference.Items(i).ToString(), jo.Items(i).ToString())
                Else

                End If
            End If
        Next

        If ProgressBar2.Value = ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar2.Visible = False
            KryptonButton1.Visible = True
        End If
        Form2.KryptonButton11.PerformClick()
        Me.Close()
    End Sub
    Private Function Exist(ByVal costhead As String, ByVal color As String, ByVal articleno As String) As Boolean
        Dim bol As Boolean = False
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Dim str As String = "select stockno from stocks_tb where costhead = '" & costhead & "' and typecolor = '" & color & "' and articleno = '" & articleno & "'"
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows Then
                            bol = True
                        Else
                            bol = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return bol
    End Function
    Private Function GetStockno(ByVal costhead As String, ByVal color As String, ByVal articleno As String) As String
        Dim stockno As String = ""
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Dim str As String = "select stockno from stocks_tb where costhead = '" & costhead & "' and typecolor = '" & color & "' and articleno = '" & articleno & "'"
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            stockno = rd(0).ToString()
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return stockno
    End Function
    Public Sub updatenewstockno(ByVal transno As String, ByVal stockno As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Dim str As String = "
declare @unitprice as decimal(10,2) = (select unitprice from stocks_tb where stockno = '" & stockno & "')
Declare @xrate as decimal(10,2) = (select xrate from stocks_tb where stockno = '" & stockno & "')
declare @ufactor decimal(10,2)= (select ufactor from stocks_tb where stockno = '" & stockno & "')

update trans_tb set 
stockno = '" & stockno & "',
unitprice=@unitprice,
xrate=@xrate,
ufactor=@ufactor,
netamount=(@unitprice*@xrate)*(qty*@ufactor)
where transno = '" & transno & "'"
                sqlcmd = New SqlCommand(str, sqlcon)
                sqlcmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub findnewreference(ByVal stockno As String, ByVal reference As String, ByVal jo As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Dim find As String = "select * from reference_tb where reference='" & reference & "' and jo = '" & jo & "' and stockno='" & stockno & "'"
                sqlcmd = New SqlCommand(find, sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                If read.HasRows = True Then
                    read.Close()
                Else
                    read.Close()
                    Dim insert As String = "
declare @id as integer = (select max(id)+1 from reference_tb)
insert into reference_tb (id,reference,jo,stockno) values(@id,'" & reference & "','" & jo & "','" & stockno & "')"
                    sqlcmd = New SqlCommand(insert, sqlcon)
                    sqlcmd.ExecuteNonQuery()
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub updatestock(ByVal stockno As String, ByVal reference As String, ByVal jo As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Dim str As String = "
                                    Declare @allocation as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Allocation')+0
                                    Declare @cancelalloc as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Return')+0
                                    declare @supply as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Supply')+0
                                    declare @spare as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Spare')+0
                                    declare @addadjustment as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='+Adjustment')+0
                                    declare @minadjustment as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='-Adjustment')+0
                                    declare @receipt as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
            update stocks_tb set 
                                    
                                    physical=(QTY+@totalreceipt+@return+@addadjustment)-(@totalissue+@minadjustment),
                                    allocation = @allocation-(@issueallocation+@cancelalloc),
                                    free=(((QTY+@totalreceipt+@return+@addadjustment)-(@allocation-@cancelalloc)))-(@issue+@minadjustment),
                                    stockorder=@order-@receiptorder,
                                    issue=@totalissue
                                    where stockno='" & stockno & "'"
                sqlcmd = New SqlCommand(str, sqlcon)
                sqlcmd.ExecuteNonQuery()


                Dim bny As String = "
                                    declare @allocation as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Return')+0
                                    declare @receipt as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
update reference_tb set 

                                    allocation=@allocation-(@issueallocation+@cancelalloc),
                                    stockorder=@order-@receiptorder,
                                    TOTALRECEIPT=@totalreceipt,
                                    totalissue=@totalissue,
                                    totalreturn=@return
                                    where stockno='" & stockno & "' and reference='" & reference & "' and jo = '" & jo & "' "
                sqlcmd = New SqlCommand(bny, sqlcon)
                sqlcmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class