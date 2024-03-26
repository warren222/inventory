Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class TransactionRecord
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _ds As New DataSet
    Dim _bs As New BindingSource

    Public Shared _stockno As String
    Public Shared _controlno As String

    Private Sub TransactionRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        GV.DataSource = _bs
        starter("Get_Transaction")
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Transaction"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Transaction"
                _bs.DataSource = _ds
                _bs.DataMember = "trans_tb"
                GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Transaction"
                LoadingPBOX.Visible = False
        End Select
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
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Stockno", _stockno)
                sqlcmd.Parameters.AddWithValue("@Clno", _controlno)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Get_Transaction" Then
                        _ds = New DataSet
                        _ds.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_ds, "trans_tb")
                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub TransactionRecord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub GV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles GV.RowPostPaint

    End Sub
End Class