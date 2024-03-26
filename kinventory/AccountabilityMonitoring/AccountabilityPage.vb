Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class AccountabilityPage
    Dim sql As New sql
    Dim bgw As New BackgroundWorker

    Dim action As String
    Dim _ds As New DataSet
    Dim _bs As New BindingSource
    Dim _dsAccount As New DataSet
    Dim _bsAccount As New BindingSource
    Dim _account As String
    Private Sub AccountabilityPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        GV.DataSource = _bs
        starter("Account_List")
        InitializeControls()
    End Sub
    Private Sub InitializeControls()
        _account = cboxAccount.Text
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
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Get" Then
                        _ds = New DataSet
                        _ds.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_ds, "Source_tb")
                    ElseIf command = "Account_List" Then
                        _dsAccount = New DataSet
                        _dsAccount.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsAccount, "trans_tb")
                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get"
                Query(action)
                bgw.ReportProgress(0)
            Case "Account_List"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get"
                _bs.DataSource = _ds
                _bs.DataMember = "Source_tb"
                For i As Integer = 0 To GV.RowCount - 1
                    Dim row As DataGridViewRow = GV.Rows(i)
                    row.Cells(0).Style.ForeColor = Color.White
                    row.Cells(0).Style.SelectionForeColor = Color.White
                    If row.Cells("Data_Source").Value.ToString = "Inventory" Then
                        row.Cells(0).Style.BackColor = Color.Green
                        row.Cells(0).Style.SelectionBackColor = Color.Green
                    Else
                        row.Cells(0).Style.BackColor = Color.DeepPink
                        row.Cells(0).Style.SelectionBackColor = Color.DeepPink
                    End If
                Next
                GV.Columns("Data_Source").Visible = False
            Case "Account_List"
                _bsAccount.DataSource = _dsAccount
                _bsAccount.DataMember = "trans_tb"
                cboxAccount.DataSource = _bsAccount
                cboxAccount.DisplayMember = "ACCOUNT"
                cboxAccount.ValueMember = "ACCOUNT"
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get"
                LoadingPBOX.Visible = False
                lblAccount.Text = cboxAccount.Text
                Dim qty_issue As Decimal = 0
                Dim qty_return As Decimal = 0
                For Each row As DataGridViewRow In GV.Rows
                    qty_issue += Convert.ToDecimal(row.Cells("Issue_Qty").Value.ToString)
                    qty_return += Convert.ToDecimal(row.Cells("Return_Qty").Value.ToString)
                Next
                lblIssue.Text = qty_issue.ToString
                lblReturn.Text = qty_return.ToString
                lblBalance.Text = (qty_issue - qty_return).ToString
            Case "Account_List"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitializeControls()
        starter("Get")
    End Sub


    Private Sub AccountabilityPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub GV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellDoubleClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then
            AccountabilityTransactions._stockno = GV.Item("STOCKNO", e.RowIndex).Value.ToString
            AccountabilityTransactions._reference = GV.Item("REFERENCE", e.RowIndex).Value.ToString
            AccountabilityTransactions._account = GV.Item("ACCOUNT", e.RowIndex).Value.ToString
            AccountabilityTransactions._description = GV.Item("DESCRIPTION", e.RowIndex).Value.ToString
            AccountabilityTransactions._data_source = GV.Item("DATA_SOURCE", e.RowIndex).Value.ToString
            AccountabilityTransactions.ShowDialog()
        End If
    End Sub


End Class