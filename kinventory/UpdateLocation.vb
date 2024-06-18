Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class UpdateLocation
    Dim sql As New sql
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Dim bgw As New BackgroundWorker
    Dim action As String
    Private Sub UpdateLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschange
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
    End Sub

    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Save"
                LoadingPBOX.Visible = False
                Form2.KryptonButton11.PerformClick()
                Me.Close()
        End Select
    End Sub

    Private Sub bgw_progresschange(sender As Object, e As ProgressChangedEventArgs)

    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Save"
                For i As Integer = 0 To _transnoList.Count - 1
                    DataAccess(_location, _transnoList(i).ToString())
                Next
                bgw.ReportProgress(0)
        End Select
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show("Busy! please try again later.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateLocation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InitializeVariables()
        starter("Save")
    End Sub
    Dim _location As String
    Dim _transnoList As New ArrayList
    Private Sub InitializeVariables()
        _location = cboxLocation.Text
        _transnoList = Form2.transnoAlist
    End Sub
    Private Sub DataAccess(ByVal location As String, ByVal transno As String)
        Try
            Dim str As String = "update trans_tb set location = @location where transno = @transno"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()

                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@location", location)
                    sqlcmd.Parameters.AddWithValue("@transno", transno)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub cboxLocation_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxLocation.MouseDown
        Dim I As Integer = cboxLocation.SelectedIndex
        loadlocationcombo(cboxLocation)
        If I > cboxLocation.Items.Count - 1 Then
            cboxLocation.SelectedIndex = -1
        Else
            cboxLocation.SelectedIndex = I
        End If
    End Sub
    Public Sub loadlocationcombo(ByVal obj As Object)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            sqlcon.Open()
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "WarehouseReport_Stp"
                sqlcmd.Parameters.AddWithValue("@Command", "Distinct_Location")
                Dim ds As New DataSet
                ds.Clear()
                Dim bs As New BindingSource
                Using sqlda As SqlDataAdapter = New SqlDataAdapter
                    sqlda.SelectCommand = sqlcmd
                    sqlda.Fill(ds, "LOCATIONTB")
                    bs.DataSource = ds
                    bs.DataMember = "LOCATIONTB"
                End Using
                obj.DataSource = bs
                obj.ValueMember = "Location"
                obj.DisplayMember = "Location"
            End Using
        End Using
    End Sub

End Class