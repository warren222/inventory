Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class CopyToCpart
    Public _sourceStockno As String
    Dim _cpartStockno As String

    Dim sql As New sql
    Dim bgw As New BackgroundWorker

    Dim action As String

    Dim _cpartStocknoList As New ArrayList
    Dim pinterval As Integer = 0
    Private Sub CopyToCpart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        starter("getList")
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "getList"
                LoadingPBOX.Visible = False
            Case "copy"
                If pinterval < _cpartStocknoList.Count - 1 Then
                    pinterval += 1
                    ProgressBar1.Value = pinterval
                    _cpartStockno = _cpartStocknoList(pinterval).ToString
                    starter("copy")
                Else
                    LoadingPBOX.Visible = False
                    pinterval = 0
                    ProgressBar1.Value = _cpartStocknoList.Count - 1
                    LoadingPBOX.Visible = False
                    MessageBox.Show("Color counterparts copied successfully!")
                    ColorManagerTool.Button5.PerformClick()
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)

    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "getList"
                Query(action)
                bgw.ReportProgress(0)
            Case "copy"
                Query(action)
                bgw.ReportProgress(0)
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
                sqlcmd.CommandText = "ColorManagerTool_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@SourceStockno", _sourceStockno)
                sqlcmd.Parameters.AddWithValue("@CpartStockno", _cpartStockno)
                If command = "getList" Then
                    _cpartStocknoList = New ArrayList
                    Dim rd As SqlDataReader = sqlcmd.ExecuteReader
                    While rd.Read
                        _cpartStocknoList.Add(rd(0).ToString())
                    End While
                Else
                    sqlcmd.ExecuteNonQuery()
                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Copy color?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        ProgressBar1.Maximum = _cpartStocknoList.Count - 1
        ProgressBar1.Value = 0

        _cpartStockno = _cpartStocknoList(0)
        starter("copy")

    End Sub
End Class