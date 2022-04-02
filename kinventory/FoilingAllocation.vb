Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FoilingAllocation
    Dim sql As New sql
    Dim bgw As New BackgroundWorker

    Dim _sourceds As New DataSet
    Dim _sourcebs As New BindingSource

    Dim _sourceCostheadds As New DataSet
    Dim _sourceColords As New DataSet
    Dim _sourceArticleds As New DataSet

    Dim action As String

    Dim _sourceStockno As String
    Dim _Costhead As String
    Dim _Color As String
    Dim _Article As String

    Dim _cpartStocknoList As New ArrayList
    Private Sub initializeSourceVariables()
        _Article = sourceArticleCbox.Text
        _Color = sourceColorCbox.Text
        _Costhead = sourceCostheadCbox.Text
    End Sub

    Private Sub FoilingAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get"
                LoadingPBOX.Visible = False
                Allocation_per_foil_FrmReport.Show()
            Case "Get_Color_Based"
                LoadingPBOX.Visible = False
                Allocation_per_foil_FrmReport.Show()
            Case "sourceArticleSuggestion"
                LoadingPBOX.Visible = False
            Case "sourceColorSuggestion"
                LoadingPBOX.Visible = False
            Case "sourceCostheadSuggestion"
                LoadingPBOX.Visible = False

        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get"
                Allocation_per_foil_FrmReport.Allocation_Per_Foil_TblBindingSource.DataSource = ds.Allocation_Per_Foil_Tbl.DefaultView
            Case "Get_Color_Based"
                Allocation_per_foil_FrmReport.Allocation_Per_Foil_TblBindingSource.DataSource = ds.Allocation_Per_Foil_Tbl.DefaultView
            Case "sourceArticleSuggestion"
                initializeDatasource(sourceArticleCbox, _sourceArticleds, "stocks_tb", "Articleno")
            Case "sourceColorSuggestion"
                initializeDatasource(sourceColorCbox, _sourceColords, "stocks_tb", "TypeColor")
            Case "sourceCostheadSuggestion"
                initializeDatasource(sourceCostheadCbox, _sourceCostheadds, "stocks_tb", "Costhead")
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get"
                load_Query(action)
                bgw.ReportProgress(0)
            Case "Get_Color_Based"
                load_Query(action)
                bgw.ReportProgress(0)
            Case "sourceArticleSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "sourceColorSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "sourceCostheadSuggestion"
                Query(action, "")
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
    Dim da As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As inventoryds = New inventoryds()
    Private Sub Query(ByVal command As String, ByVal id As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand

                sqlcon.Open()
                sqlcmd.CommandText = "ColorManagerTool_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Costhead", _Costhead)
                sqlcmd.Parameters.AddWithValue("@Color", _Color)
                sqlcmd.Parameters.AddWithValue("@Article", _Article)
                If command = "sourceArticleSuggestion" Then
                    _sourceArticleds = New DataSet
                    _sourceArticleds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_sourceArticleds, "Stocks_Tb")
                ElseIf command = "sourceColorSuggestion" Then
                    _sourceColords = New DataSet
                    _sourceColords.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_sourceColords, "Stocks_Tb")
                ElseIf command = "sourceCostheadSuggestion" Then
                    _sourceCostheadds = New DataSet
                    _sourceCostheadds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_sourceCostheadds, "Stocks_Tb")

                Else
                    sqlcmd.ExecuteNonQuery()
                End If
            End Using
        End Using

    End Sub
    Private Sub load_Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand

                sqlcon.Open()
                sqlcmd.CommandText = "Allocation_Foiled_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Costhead", _Costhead)
                sqlcmd.Parameters.AddWithValue("@Color", _Color)
                sqlcmd.Parameters.AddWithValue("@Article", _Article)
                If command = "Get" Or command = "Get_Color_Based" Then
                    ds = New inventoryds
                    ds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(ds.Allocation_Per_Foil_Tbl)
                Else
                    sqlcmd.ExecuteNonQuery()
                End If
            End Using
        End Using
    End Sub
    Private Sub initializeDatasource(ByVal sender As Object, ByVal dset As DataSet, ByVal datamember As String, ByVal displaymember As String)
        Dim x As Integer = sender.SelectedIndex
        Dim newbs As New BindingSource
        newbs.DataSource = dset
        newbs.DataMember = datamember
        sender.DataSource = newbs
        sender.DisplayMember = displaymember
        If x > sender.Items.Count - 1 Then
            sender.SelectedIndex = -1
        Else
            sender.SelectedIndex = x
        End If
    End Sub

    Private Sub sourceCostheadCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles sourceCostheadCbox.MouseDown
        sourceColorCbox.Text = ""
        sourceArticleCbox.Text = ""
        initializeSourceVariables()
        starter("sourceCostheadSuggestion")
    End Sub

    Private Sub sourceColorCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles sourceColorCbox.MouseDown
        sourceArticleCbox.Text = ""
        initializeSourceVariables()
        starter("sourceColorSuggestion")
    End Sub

    Private Sub sourceArticleCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles sourceArticleCbox.MouseDown
        initializeSourceVariables()
        starter("sourceArticleSuggestion")
    End Sub

    Private Sub FoilingAllocation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        initializeSourceVariables()
        starter("Get")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        initializeSourceVariables()
        starter("Get_Color_Based")
    End Sub
End Class