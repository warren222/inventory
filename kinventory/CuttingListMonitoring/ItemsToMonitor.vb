Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ItemsToMonitor
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _ds As New DataSet
    Dim _dsGroup_Name As New DataSet
    Dim _bs As New BindingSource
    Dim _bsGroup_Name As New BindingSource
    Dim _search As String
    Dim _group_name As String
    Dim _classification As String
    Private Sub ItemsToMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        GV.DataSource = _bs
        InitializeControls()
        starter("Get")
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get"
                Query(action)
                bgw.ReportProgress(0)
            Case "Group_Name"
                Query(action)
                bgw.ReportProgress(0)
            Case "Delete"
                DeleteQuery(action)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get"
                GV.Columns.Clear()
                _bs.DataSource = _ds
                _bs.DataMember = "Source_tb"
                addbtn()
            Case "Group_Name"
                _bsGroup_Name.DataSource = _dsGroup_Name
                _bsGroup_Name.DataMember = "Group_Name_Tb"
                cboxGroupName.DataSource = _bsGroup_Name
                cboxGroupName.DisplayMember = "GROUP_NAME"
                cboxGroupName.ValueMember = "GROUP_NAME"
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get"
                LoadingPBOX.Visible = False
            Case "Group_Name"
                LoadingPBOX.Visible = False
            Case "Delete"
                InitializeControls()
                starter("Get")
        End Select
    End Sub
    Private Sub addbtn()
        Dim btnDelete As New DataGridViewButtonColumn
        With btnDelete
            .Name = ""
            .Text = "delete"
            .UseColumnTextForButtonValue = True
            .HeaderText = "ACTION"
        End With
        GV.Columns.Insert(0, btnDelete)
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
    Private Sub InitializeControls()
        _search = tboxSearch.Text
        _classification = cboxClassification.Text
        _group_name = cboxGroupName.Text
    End Sub

    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_List_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Search", _search)
                sqlcmd.Parameters.AddWithValue("@Classification", _classification)
                sqlcmd.Parameters.AddWithValue("@Group_Name", _group_name)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Get" Then
                        _ds = New DataSet
                        _ds.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_ds, "Source_tb")
                    ElseIf command = "Group_Name" Then
                        _dsGroup_Name = New DataSet
                        _dsGroup_Name.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsGroup_Name, "Group_Name_Tb")
                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub DeleteQuery(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_List_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Stockno", _strstockno)
                sqlcmd.Parameters.AddWithValue("@Classification", _strclassification)
                sqlcmd.Parameters.AddWithValue("@Group_Name", _strgroup_name)
                sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitializeControls()
        starter("Get")
    End Sub

    Private Sub GV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellDoubleClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then
            CuttingListRecord._stockno = GV.Item("STOCKNO", e.RowIndex).Value.ToString
            CuttingListRecord.ShowDialog()
        End If
    End Sub

    Private Sub ItemsToMonitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cboxClassification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxClassification.SelectedIndexChanged
        InitializeControls()
        starter("Group_Name")
    End Sub
    Dim _strclassification As String
    Dim _strgroup_name As String
    Dim _strstockno As String
    Private Sub GV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellClick
        If e.RowIndex >= 0 And GV.RowCount >= 0 Then
            If e.ColumnIndex = 0 Then
                Dim row As DataGridViewRow = GV.Rows(e.RowIndex)
                _strclassification = row.Cells("classification").Value.ToString
                _strgroup_name = row.Cells("group_name").Value.ToString
                _strstockno = row.Cells("stockno").Value.ToString
                If MessageBox.Show("do you want to delete it?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                starter("Delete")
            End If
        End If
    End Sub
End Class