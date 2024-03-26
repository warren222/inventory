Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AddItemsToMonitor
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _dsGroup_Name As New DataSet
    Dim _bsGroup_Name As New BindingSource
    Dim _group_name As String
    Dim _classification As String
    Public Shared _stockno As String
    Private Sub AddItemsToMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Group_Name"
                Query(action)
                bgw.ReportProgress(0)
            Case "Add"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
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
            Case "Group_Name"
                LoadingPBOX.Visible = False
            Case "Add"
                LoadingPBOX.Visible = False
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
    Private Sub InitializeControls()
        _classification = cboxClassification.Text
        _group_name = cboxGroupName.Text
    End Sub
    Private Sub cboxClassification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxClassification.SelectedIndexChanged
        InitializeControls()
        starter("Group_Name")
    End Sub
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_List_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Classification", _classification)
                sqlcmd.Parameters.AddWithValue("@Group_Name", _group_name)
                sqlcmd.Parameters.AddWithValue("@Stockno", _stockno)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Group_Name" Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AddItemsToMonitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboxClassification.Text = "" And cboxGroupName.Text = "" Then
            MessageBox.Show("fill all fields!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            InitializeControls()
            starter("Add")
        End If

    End Sub
End Class