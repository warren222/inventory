Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AccountabilityUpdate
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Public Shared stockList As New ArrayList
    Dim _am As Integer

    Private Sub AccountabilityUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        cboxAM.SelectedIndex = 0
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Update"
                For i As Integer = 0 To stockList.Count - 1
                    Dim stockno As String = stockList(i).ToString
                    updateAccountability(stockno)
                Next
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)

    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Update"
                LoadingPBOX.Visible = False
                Form2.KryptonButton1.PerformClick()
                Me.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        initializeVariable()
        starter("Update")
    End Sub


    Private Sub initializeVariable()
        _am = If(cboxAM.Text = "True", 1, 0)
    End Sub
    Public Sub updateAccountability(ByVal stockno As String)
        Try
            Dim str As String = "update stocks_tb set accountability_monitoring = " & _am & " where stockno = '" & stockno & "'"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AccountabilityUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class