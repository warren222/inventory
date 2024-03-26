Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CLStatusUpdate
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CLStatusUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        starter("Status_List")
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

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Update_Status"
                LoadingPBOX.Visible = False
                MessageBox.Show("Status Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CuttingListRecord.Button2.PerformClick()
                Me.Close()
            Case "Status_List"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Status_List"
                _bsStatus.DataSource = _dsStatus
                _bsStatus.DataMember = "cllist"
                cboxStatus.DataSource = _bsStatus
                cboxStatus.DisplayMember = "cl_status"
                cboxStatus.ValueMember = "cl_status"
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Update_Status"
                For i As Integer = 0 To CuttingListRecord._idList.Count - 1
                    _id = CuttingListRecord._idList(i).ToString
                    Query(action)
                Next
                bgw.ReportProgress(0)
            Case "Status_List"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim _id As String
    Dim _status As String
    Dim _dsStatus As New DataSet
    Dim _bsStatus As New BindingSource
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Id", _id)
                sqlcmd.Parameters.AddWithValue("@Cl_Status", _status)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Status_List" Then
                        _dsStatus = New DataSet
                        _dsStatus.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsStatus, "cllist")
                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _status = cboxStatus.Text
        starter("Update_Status")
    End Sub

    Private Sub CLStatusUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class