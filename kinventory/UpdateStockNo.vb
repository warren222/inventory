Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class UpdateStockNo
    Dim sql As New sql
    Dim sqlcmd As New SqlCommand
    Private Sub UpdateStockNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub newcosthead_MouseDown(sender As Object, e As MouseEventArgs) Handles newcosthead.MouseDown
        newstockno.Text = ""
        'newtypecolor.SelectedIndex = -1
        'newarticleno.SelectedIndex = -1
        Dim x As Integer = newcosthead.SelectedIndex
        Try
            sql.sqlcon.Open()
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            Dim str As String = "select distinct costhead from stocks_tb order by costhead asc"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            newcosthead.DataSource = bs
            newcosthead.DisplayMember = "costhead"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
        If x > newcosthead.Items.Count - 1 Then
            newcosthead.SelectedIndex = -1
        Else
            newcosthead.SelectedIndex = x
        End If
    End Sub

    Private Sub newtypecolor_MouseDown(sender As Object, e As MouseEventArgs) Handles newtypecolor.MouseDown
        newstockno.Text = ""
        'newarticleno.SelectedIndex = -1
        Dim x As Integer = newtypecolor.SelectedIndex
        If newcosthead.Text = "" Then
            typecolorgen1()
        Else
            typecolorgen(newcosthead.Text)
        End If
        If x > newtypecolor.Items.Count - 1 Then
            newtypecolor.SelectedIndex = -1
        Else
            newtypecolor.SelectedIndex = x
        End If
    End Sub
    Public Sub typecolorgen(ByVal costhead As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "select distinct typecolor FROM STOCKS_TB WHERE COSTHEAD = '" & costhead & "' order by typecolor asc"
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

    Private Sub newarticleno_MouseDown(sender As Object, e As MouseEventArgs) Handles newarticleno.MouseDown

        Dim i As Integer = newarticleno.SelectedIndex
        If newcosthead.Text = "" And newtypecolor.Text = "" Then
            articlenogen1()
        ElseIf Not newcosthead.Text = "" And newtypecolor.Text = "" Then
            articlenogen2(newcosthead.Text)
        ElseIf newcosthead.Text = "" And Not newtypecolor.Text = "" Then
            articlenogen3(newtypecolor.Text)
        Else
            articlenogen(newcosthead.Text, newtypecolor.Text)
        End If
        If i > newarticleno.Items.Count - 1 Then
            newarticleno.SelectedIndex = -1
        Else
            newarticleno.SelectedIndex = i
        End If
    End Sub
    Public Sub articlenogen(ByVal costhead As String, ByVal typecolor As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "select articleno,stockno FROM STOCKS_TB where costhead = '" & costhead & "' and typecolor= '" & typecolor & "' order by articleno asc"
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            newarticleno.DataSource = bs
            newarticleno.DisplayMember = "articleno"
            newstockno.DataBindings.Clear()
            newstockno.DataBindings.Add("text", bs, "stockno")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub articlenogen1()
        Try
            sql.sqlcon.Open()
            Dim str As String = "select distinct articleno,stockno FROM STOCKS_TB order by articleno asc"
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            newarticleno.DataSource = bs
            newarticleno.DisplayMember = "articleno"
            newstockno.DataBindings.Clear()
            newstockno.DataBindings.Add("text", bs, "stockno")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub articlenogen2(ByVal costhead As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "select distinct articleno,stockno FROM STOCKS_TB where costhead = '" & costhead & "' order by articleno asc"
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            newarticleno.DataSource = bs
            newarticleno.DisplayMember = "articleno"
            newstockno.DataBindings.Clear()
            newstockno.DataBindings.Add("text", bs, "stockno")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub articlenogen3(ByVal typecolor As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "select distinct articleno,stockno FROM STOCKS_TB where typecolor = '" & typecolor & "' order by articleno asc"
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            newarticleno.DataSource = bs
            newarticleno.DisplayMember = "articleno"
            newstockno.DataBindings.Clear()
            newstockno.DataBindings.Add("text", bs, "stockno")
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
        For i As Integer = 0 To transno.Items.Count - 1
            If (transtype.Items(i).ToString() = "Order" And Not xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Receipt" And xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Receipt" And Not xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Allocation" And Not xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Issue" And xyz.Items(i).ToString() = "") Or
        (transtype.Items(i).ToString() = "Issue" And Not xyz.Items(i).ToString() = "") Then
            Else
                updatenewstockno(transno.Items(i).ToString(), newstockno.Text)
                findnewreference(newstockno.Text, reference.Items(i).ToString(), jo.Items(i).ToString())
                updatestock(newstockno.Text, reference.Items(i).ToString(), jo.Items(i).ToString())
            End If
        Next
    End Sub
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
                sqlcmd = New SqlCommand(str, sql.sqlcon)
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
                sqlcmd = New SqlCommand(find, sql.sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                If read.HasRows = True Then
                    read.Close()
                Else
                    read.Close()
                    Dim insert As String = "
declare @id as integer = (select max(id)+1 from reference_tb)
insert into reference_tb (id,reference,jo,stockno) values(@id,'" & reference & "','" & jo & "','" & stockno & "')"
                    sqlcmd = New SqlCommand(insert, sql.sqlcon)
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
                sqlcmd = New SqlCommand(str, sql.sqlcon)
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
                sqlcmd = New SqlCommand(bny, sql.sqlcon)
                sqlcmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class