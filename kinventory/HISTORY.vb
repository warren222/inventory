Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class HISTORY
    Dim sql As New sql
    Dim sqlcmd As New SqlCommand
    Public Shared stockno As String
    Public Shared _location As String
    Public Shared _reference As String
    Dim x As Integer
    Dim y As Integer
    Dim drag As Boolean
    Dim bgw As New BackgroundWorker
    Dim action As String

    Private Sub HISTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        KryptonLabel1.Text = _location + " (Transaction Record)"
        Starter("Get_Distinct_Reference")
    End Sub
    Private Sub Starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Distinct_Reference"
                LoadingPBOX.Visible = False
                Starter("Get_Location_History")
            Case "Get_Location_History"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Distinct_Reference"
                _bsReference.DataSource = _dsReference
                _bsReference.DataMember = "lochistory"
                cboxReference.DataSource = _bsReference
                cboxReference.DisplayMember = "Reference"
            Case "Get_Location_History"
                _bs.DataSource = _ds
                _bs.DataMember = "lochistory"
                With transactiongridview
                    .DataSource = _bs
                    .Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("qty").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("LOCATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("stockno").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("transdate").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("transtype").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("balqty").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("balqty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("RBALQTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("RBALQTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("qty").DefaultCellStyle.Format = "N2"
                    .Columns("balqty").DefaultCellStyle.Format = "N2"
                    .Columns("RBALQTY").DefaultCellStyle.Format = "N2"
                End With
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Distinct_Reference"
                LoadDistinctReference()
                bgw.ReportProgress(0)
            Case "Get_Location_History"
                Loaddata()
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs)
        _reference = cboxReference.Text
        Starter("Get_Location_History")
    End Sub
    Dim _bs As New BindingSource
    Dim _ds As New DataSet
    Private Sub Loaddata()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "Loc_History_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_History")
                    sqlcmd.Parameters.AddWithValue("@Location", _location)
                    sqlcmd.Parameters.AddWithValue("@Reference", _reference)
                    _ds = New DataSet
                    _ds.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_ds, "lochistory")
                        Dim bs As New BindingSource
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim _bsReference As New BindingSource
    Dim _dsReference As New DataSet
    Public Sub LoadDistinctReference()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "Loc_History_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Distinct_Reference")
                    sqlcmd.Parameters.AddWithValue("@Location", _location)
                    _dsReference = New DataSet
                    _dsReference.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsReference, "lochistory")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub KryptonPanel1_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    Private Sub KryptonPanel1_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        x = Cursor.Position.X - Me.Left
        y = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub KryptonPanel1_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Left = Cursor.Position.X - x
            Me.Top = Cursor.Position.Y - y
        End If
    End Sub

    Private Sub HISTORY_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _reference = cboxReference.Text
        Starter("Get_Location_History")
    End Sub
End Class