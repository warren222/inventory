Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class AccountabilityTransactions
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _ds As New DataSet
    Dim _bs As New BindingSource
    Public Shared _account As String
    Public Shared _reference As String
    Public Shared _stockno As String
    Public Shared _description As String
    Public Shared _data_source As String
    Private Sub AccountabilityTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        GV.DataSource = _bs
        starter("Get_Transactions")
        If _data_source = "Inventory" Then
            cboxTransType.Items.Clear()
            cboxTransType.Items.Add("Return Used")
        End If
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "Warehouse_Accountability_Monitoring_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Account", _account)
                sqlcmd.Parameters.AddWithValue("@Reference", _reference)
                sqlcmd.Parameters.AddWithValue("@Stockno", _stockno)
                sqlcmd.Parameters.AddWithValue("@Data_Source", _data_source)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Get_Transactions" Then
                        _ds = New DataSet
                        _ds.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_ds, "trans_tb")
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub Query2(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "Warehouse_Trans_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Id", _transid)
                sqlcmd.Parameters.AddWithValue("@Account", _account)
                sqlcmd.Parameters.AddWithValue("@Item_Id", _stockno)
                sqlcmd.Parameters.AddWithValue("@Reference", _reference)
                sqlcmd.Parameters.AddWithValue("@Requested_Date", _requested_date)
                sqlcmd.Parameters.AddWithValue("@Trans_Date", _transdate)
                sqlcmd.Parameters.AddWithValue("@Trans_Type", _transtype)
                sqlcmd.Parameters.AddWithValue("@Qty", _quantity)
                sqlcmd.Parameters.AddWithValue("@Data_Source", _data_source)
                sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Transactions"
                Query(action)
                bgw.ReportProgress(0)
            Case "Delete_Trans"
                Query2(action)
                bgw.ReportProgress(0)
            Case "Add_Trans"
                Query2(action)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Transactions"
                GV.Columns.Clear()
                _bs.DataSource = _ds
                _bs.DataMember = "trans_tb"
                addbtn()
                btntext()
                GV.Columns("DELETABLE").Visible = False
                For i As Integer = 0 To GV.RowCount - 1
                    Dim row As DataGridViewRow = GV.Rows(i)
                    row.Cells(1).Style.ForeColor = Color.White
                    row.Cells(1).Style.SelectionForeColor = Color.White
                    If row.Cells("DELETABLE").Value.ToString = "0" Then
                        row.Cells(1).Style.BackColor = Color.Green
                        row.Cells(1).Style.SelectionBackColor = Color.Green
                    Else
                        row.Cells(1).Style.BackColor = Color.DeepPink
                        row.Cells(1).Style.SelectionBackColor = Color.DeepPink
                    End If
                Next
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Transactions"
                LoadingPBOX.Visible = False
                lblAccount.Text = _account
                lblReference.Text = _reference
                lblItemId.Text = _stockno
                lblItemDescription.Text = _description
                lblDatasource.Text = _data_source
                Dim qty_issue As Decimal = 0
                Dim qty_returngood As Decimal = 0
                Dim qty_returnused As Decimal = 0

                For Each row As DataGridViewRow In GV.Rows
                    Dim transtype = row.Cells("TRANS_TYPE").Value.ToString
                    If transtype = "Issue" Then
                        qty_issue += Convert.ToDecimal(row.Cells("QTY").Value.ToString)
                    End If
                    If transtype = "Return" Or transtype = "Return Good" Then
                        qty_returngood += Convert.ToDecimal(row.Cells("QTY").Value.ToString)
                    End If
                    If transtype = "Return Used" Then
                        qty_returnused += Convert.ToDecimal(row.Cells("QTY").Value.ToString)
                    End If
                Next
                lblIssue.Text = qty_issue.ToString
                lblReturnGood.Text = qty_returngood.ToString
                lblReturnUsed.Text = qty_returnused.ToString
                lblNeedtoReturn.Text = (qty_issue - (qty_returngood + qty_returnused)).ToString
            Case "Delete_Trans"
                starter("Get_Transactions")
            Case "Add_Trans"
                starter("Get_Transactions")
        End Select
    End Sub

    Private Sub AccountabilityTransactions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub addbtn()
        Dim btndelete As New DataGridViewButtonColumn
        With btndelete
            .Name = ""
            .Text = "delete"
            .UseColumnTextForButtonValue = False
            .HeaderText = "ACTION"
        End With
        GV.Columns.Insert(0, btndelete)
    End Sub
    Private Sub btntext()
        For i As Integer = 0 To GV.RowCount - 1
            Dim row As DataGridViewRow = GV.Rows(i)
            If row.Cells("DELETABLE").Value.ToString = "1" Then
                row.Cells(0).Value = "delete"
            Else
                row.Cells(0).Value = "-"
            End If
        Next
    End Sub
    Dim _transid As String
    Private Sub GV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                Dim row As DataGridViewRow = GV.Rows(e.RowIndex)
                If row.Cells(0).Value.ToString = "delete" Then
                    If MessageBox.Show("Continue to delete the item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        Exit Sub
                    End If
                    _transid = GV.Item("ID", e.RowIndex).Value.ToString
                    starter("Delete_Trans")
                Else
                    MessageBox.Show("Unable to delete this item!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Dim _transdate As String
    Dim _quantity As String
    Dim _transtype As String
    Dim _requested_date As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim errormessage As String = ""

        If cboxTransType.Text = "" Then
            errormessage += System.Environment.NewLine + "-Please select transaction type!"
        End If
        If dtpTransDate.Text = "" Then
            errormessage += System.Environment.NewLine + "-Please select date!"
        End If

        If Not errormessage = "" Then
            MessageBox.Show(Trim(errormessage), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        _transdate = dtpTransDate.Text
        _quantity = tboxQty.Text
        _transtype = cboxTransType.Text
        _requested_date = tboxRequestedDate.Text
        starter("Add_Trans")
    End Sub

    Private Sub GV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles GV.RowPostPaint
        sql._rowPostPaint(sender, e)
    End Sub
End Class