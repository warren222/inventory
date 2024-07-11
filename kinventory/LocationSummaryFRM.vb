Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class LocationSummaryFRM
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _loc As String = ""
    Dim _visibility As String
    Private Sub LocationSummaryFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        KryptonDataGridView1.DataSource = _bsGet_Location_Summary
        _visibility = locationform.CboxHideZero.Text
        Starter("Get_All_Distinct_Location")
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
    Dim _bsGet_Location_Summary As New BindingSource
    Dim _bsGet_All_Distinct_Location As New BindingSource
    Dim _dsGet_Location_Summary As New DataSet
    Dim _dsGet_All_Distinct_Location As New DataSet
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Location_Summary"
                LoadingPBOX.Visible = False
            Case "Get_All_Distinct_Location"
                LoadingPBOX.Visible = False
                Starter("Get_Location_Summary")
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Location_Summary"
                _bsGet_Location_Summary.DataSource = _dsGet_Location_Summary
                _bsGet_Location_Summary.DataMember = "locationtb"
                KryptonDataGridView1.Columns("LOCATION").DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                KryptonDataGridView1.Columns("QTY").DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                KryptonDataGridView1.Columns("QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                KryptonDataGridView1.Columns("QTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                KryptonDataGridView1.Columns("QTY").DefaultCellStyle.Format = "N2"
            Case "Get_All_Distinct_Location"
                _bsGet_All_Distinct_Location.DataSource = _dsGet_All_Distinct_Location
                _bsGet_All_Distinct_Location.DataMember = "locationtb"
                cboxLocation.DataSource = _bsGet_All_Distinct_Location
                cboxLocation.DisplayMember = "location"
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Location_Summary"
                loadsummary()
                bgw.ReportProgress(0)
            Case "Get_All_Distinct_Location"
                LoadSetLocation()
                bgw.ReportProgress(0)
        End Select
    End Sub

    Dim summarylocation As String
    Private Sub KryptonDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellClick
        If KryptonDataGridView1.RowCount >= 0 And e.RowIndex >= 0 Then
            summarylocation = KryptonDataGridView1.Item(0, e.RowIndex).Value.ToString
        End If
    End Sub
    Private Sub KryptonDataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellDoubleClick
        If KryptonDataGridView1.RowCount >= 0 And e.RowIndex >= 0 Then
            summarylocation = KryptonDataGridView1.Item(0, e.RowIndex).Value.ToString
            HISTORY._location = summarylocation
            HISTORY.ShowDialog()
        End If
    End Sub
    Public Sub LoadSetLocation()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_All_Distinct_Location")
                    _dsGet_All_Distinct_Location = New DataSet
                    _dsGet_All_Distinct_Location.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsGet_All_Distinct_Location, "locationtb")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub loadsummary()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_Summary")
                    sqlcmd.Parameters.AddWithValue("@Visibility", _visibility)
                    sqlcmd.Parameters.AddWithValue("@Search", _loc)
                    _dsGet_Location_Summary = New DataSet
                    _dsGet_Location_Summary.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsGet_Location_Summary, "locationtb")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _loc = cboxLocation.Text
        Starter("Get_Location_Summary")
    End Sub

    Private Sub cboxLocation_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxLocation.MouseDown
        Dim i As Integer = cboxLocation.SelectedIndex

        If i > cboxLocation.Items.Count - 1 Then
            cboxLocation.SelectedIndex = -1
        Else
            cboxLocation.SelectedIndex = i
        End If
    End Sub

    Private Sub LocationSummaryFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class