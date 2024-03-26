Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Input_Adjustment
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Input_Adjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Add_Adjustment"
                LoadingPBOX.Visible = False
                MessageBox.Show("item added to CL Monitoing successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CuttingListRecord.starter("Get_Cutting_List")
                Me.Close()
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Add_Adjustment"
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Add_Adjustment"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim _qty As String
    Dim _reference As String
    Dim _unit As String
    Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub InitializeControls()
        _qty = tboxQty.Text
        _reference = tboxReference.Text
        _unit = tboxUnit.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitializeControls()
        starter("Add_Adjustment")
    End Sub
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Stockno", CuttingListRecord._stockno)
                sqlcmd.Parameters.AddWithValue("@Qty", _qty)
                sqlcmd.Parameters.AddWithValue("@Reference", _reference)
                sqlcmd.Parameters.AddWithValue("@Units", _unit)
                sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Input_Adjustment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class