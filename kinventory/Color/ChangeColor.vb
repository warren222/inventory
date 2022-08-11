Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ChangeColor
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim da As New SqlDataAdapter

    Public transnolist As New ArrayList
    Public stocknolist As New ArrayList
    Public referencelist As New ArrayList
    Public jolist As New ArrayList

    Dim _specifiedColords As New DataSet
    Private Sub ChangeColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        starter("specifiedColorSuggestion")
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Dim pinterval As Integer = 0
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "specifiedColorSuggestion"
                LoadingPBOX.Visible = False
            Case "exist"
                If pinterval < transnolist.Count - 1 Then
                    pinterval += 1
                    ProgressBar1.Value = pinterval
                    _sourceStockno = stocknolist(pinterval).ToString
                    _transno = transnolist(pinterval).ToString
                    _reference = referencelist(pinterval).ToString
                    _jo = jolist(pinterval).ToString
                    starter("exist")
                Else
                    pinterval = 0
                    ProgressBar1.Value = transnolist.Count - 1
                    LoadingPBOX.Visible = False
                    MessageBox.Show("Color changed successfully!")
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "specifiedColorSuggestion"
                initializeDatasource(specifiedColorCbox, _specifiedColords, "ColorMngr_Tb", "Color")
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "specifiedColorSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "exist"
                Query(action, "")
                bgw.ReportProgress(0)
        End Select
    End Sub

    Dim exist As Boolean = False
    Private Sub Query(ByVal command As String, ByVal id As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "ColorManagerTool_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@SourceStockno", _sourceStockno)
                sqlcmd.Parameters.AddWithValue("@ColorAssigned", _specifiedColor)
                If command = "specifiedColorSuggestion" Then
                    _specifiedColords = New DataSet
                    _specifiedColords.Clear()
                    initializeDataset(sqlcmd, _specifiedColords, "ColorMngr_Tb")
                ElseIf command = "exist" Then
                    Dim newStockno As String = ""
                    Dim rd As SqlDataReader = sqlcmd.ExecuteReader
                    If (rd.HasRows) Then
                        exist = True
                    Else
                        exist = False
                    End If
                    If (exist) Then
                        While rd.Read
                            newStockno = rd(0).ToString
                        End While
                        sqlcon.Close()
                        updatenewstockno(_transno, newStockno)
                        findnewreference(newStockno, _reference, _jo)
                        updatestock(newStockno, _reference, _jo)
                        deletereference(_sourceStockno, _reference, _jo)
                    End If

                Else
                    sqlcmd.ExecuteNonQuery()
                End If
            End Using
        End Using
    End Sub

    Private Sub deletereference(sourceStockno As String, reference As String, jo As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Dim str As String = "delete from reference_tb where stockno = @stockno and reference  =  @reference  and jo = @jo"
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@stockno", sourceStockno)
                    sqlcmd.Parameters.AddWithValue("@reference", reference)
                    sqlcmd.Parameters.AddWithValue("@jo", jo)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub initializeDataset(ByVal sqlcmd As SqlCommand, ByVal dset As DataSet, ByVal tbl As String)
        da.SelectCommand = sqlcmd
        da.Fill(dset, tbl)
    End Sub
    Private Sub initializeDatasource(ByVal sender As Object, ByVal dset As DataSet, ByVal datamember As String, ByVal displaymember As String)
        Dim x As Integer = sender.SelectedIndex
        Dim newbs As New BindingSource
        newbs.DataSource = dset
        newbs.DataMember = datamember
        sender.DataSource = newbs
        sender.DisplayMember = displaymember
        If x > sender.Items.Count - 1 Then
            sender.SelectedIndex = -1
        Else
            sender.SelectedIndex = x
        End If
    End Sub
    Dim _sourceStockno As String
    Dim _transno As String
    Dim _reference As String
    Dim _jo As String
    Dim _specifiedColor As String
    Private Sub initialize()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Change color?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        ProgressBar1.Maximum = transnolist.Count - 1
        ProgressBar1.Value = 0

        _sourceStockno = stocknolist(0).ToString
        _transno = transnolist(0).ToString
        _reference = referencelist(0).ToString
        _jo = jolist(0).ToString

        _specifiedColor = specifiedColorCbox.Text
        starter("exist")
    End Sub


    Dim sqlcmd As New SqlCommand
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
                                    declare @stn as int = @stockno
                                    Declare @allocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Allocation')+0
                                    Declare @cancelalloc as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Return')+0
                                    declare @supply as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Supply')+0
                                    declare @spare as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Spare')+0
                                    declare @addadjustment as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='+Adjustment')+0
                                    declare @minadjustment as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='-Adjustment')+0
                                    declare @receipt as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
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
                sqlcmd = New SqlCommand(str, sqlcon)
                sqlcmd.Parameters.AddWithValue("@stockno", stockno)
                sqlcmd.ExecuteNonQuery()


                Dim bny As String = "
                                    declare @stn as int = @stockno
                                    declare @allocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Return')+0
                                    declare @receipt as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "'  AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
                                    
                                    update reference_tb set 
                                    allocation=@allocation-(@issueallocation+@cancelalloc),
                                    stockorder=@order-@receiptorder,
                                    TOTALRECEIPT=@totalreceipt,
                                    totalissue=@totalissue,
                                    totalreturn=@return
                                    where stockno=@stn and reference='" & reference & "' and jo = '" & jo & "' "
                sqlcmd = New SqlCommand(bny, sqlcon)
                sqlcmd.Parameters.AddWithValue("@stockno", stockno)
                sqlcmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ChangeColor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class