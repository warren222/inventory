Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ColorManagerTool
    Dim sql As New sql
    Dim bgw As New BackgroundWorker

    Dim _sourceds As New DataSet
    Dim _sourcebs As New BindingSource

    Dim _cpartds As New DataSet
    Dim _cpartbs As New BindingSource

    Dim _colorMgds As New DataSet
    Dim _colorMgbs As New BindingSource

    Dim _colorAssignedds As New DataSet
    Dim _specifiedColords As New DataSet

    Dim _sourceCostheadds As New DataSet
    Dim _sourceColords As New DataSet
    Dim _sourceArticleds As New DataSet

    Dim _cpartCostheadds As New DataSet
    Dim _cpartColords As New DataSet
    Dim _cpartArticleds As New DataSet

    Dim _cmCostheadds As New DataSet
    Dim _cmColords As New DataSet
    Dim _cmArticleds As New DataSet

    Dim action As String

    Dim _Costhead As String
    Dim _Color As String
    Dim _Article As String

    Dim _row As String

    Private Sub initializeSourceVariables()
        _Article = sourceArticleCbox.Text
        _Color = sourceColorCbox.Text
        _Costhead = sourceCostheadCbox.Text
    End Sub
    Private Sub initializeCpartVariables()
        _Costhead = cpartCostheadCbox.Text
        _Color = cpartColorCbox.Text
        _Article = cpartArticleCbox.Text
    End Sub
    Private Sub initializeCMVariables()
        _Costhead = cmCostheadCbox.Text
        _Color = cmColorCbox.Text
        _Article = cmArticleCbox.Text
        _colorAssigned = specifiedColorCbox.Text
        _row = rowCbox.Text
    End Sub
    Private Sub initializeTables()
        sourcegv.DataSource = _sourcebs
        cpartgv.DataSource = _cpartbs
        colorMngrgv.DataSource = _colorMgbs
    End Sub
    Private Sub ColorManagerTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        rowCbox.SelectedIndex = 1
        initializeTables()
        initializeCMVariables()
        starter("loadColorMngr")
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
            Case "loadSource"
                LoadingPBOX.Visible = False
            Case "loadCpart"
                LoadingPBOX.Visible = False
            Case "loadColorMngr"
                LoadingPBOX.Visible = False
            Case "add"
                initializeCMVariables()
                starter("loadColorMngr")
            Case "delete"
                initializeCMVariables()
                starter("loadColorMngr")
            Case "ColorSuggestion"
                LoadingPBOX.Visible = False
            Case "specifiedColorSuggestion"
                LoadingPBOX.Visible = False
            Case "sourceArticleSuggestion"
                LoadingPBOX.Visible = False
            Case "sourceColorSuggestion"
                LoadingPBOX.Visible = False
            Case "sourceCostheadSuggestion"
                LoadingPBOX.Visible = False
            Case "cpartArticleSuggestion"
                LoadingPBOX.Visible = False
            Case "cpartColorSuggestion"
                LoadingPBOX.Visible = False
            Case "cpartCostheadSuggestion"
                LoadingPBOX.Visible = False
            Case "cmArticleSuggestion"
                LoadingPBOX.Visible = False
            Case "cmColorSuggestion"
                LoadingPBOX.Visible = False
            Case "cmCostheadSuggestion"
                LoadingPBOX.Visible = False
            Case "copy"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "loadSource"
                _sourcebs.DataSource = _sourceds
                _sourcebs.DataMember = "stocks_tb"
            Case "loadCpart"
                _cpartbs.DataSource = _cpartds
                _cpartbs.DataMember = "stocks_tb"
            Case "loadColorMngr"
                _colorMgbs.DataSource = _colorMgds
                _colorMgbs.DataMember = "ColorMngr_Tb"
                colorMngrgv.Columns(0).Visible = False
                For i As Integer = 0 To colorMngrgv.Rows.Count - 1
                    For x As Integer = 0 To 4
                        colorMngrgv.Columns(x).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
                    Next
                    For x As Integer = 6 To 9
                        colorMngrgv.Columns(x).DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 255)
                    Next
                Next
            Case "ColorSuggestion"
                initializeDatasource(colorAssignedCbox, _colorAssignedds, "ColorMngr_Tb", "Color")
            Case "specifiedColorSuggestion"
                initializeDatasource(specifiedColorCbox, _specifiedColords, "ColorMngr_Tb", "Color")
            Case "sourceArticleSuggestion"
                'Dim x As Integer = sourceArticleCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _sourceArticleds
                'newbs.DataMember = "stocks_tb"
                'sourceArticleCbox.DataSource = newbs
                'sourceArticleCbox.DisplayMember = "Articleno"
                'If x > sourceArticleCbox.Items.Count - 1 Then
                '    sourceArticleCbox.SelectedIndex = -1
                'Else
                '    sourceArticleCbox.SelectedIndex = x
                'End If
                initializeDatasource(sourceArticleCbox, _sourceArticleds, "stocks_tb", "Articleno")
            Case "sourceColorSuggestion"
                'Dim x As Integer = sourceColorCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _sourceColords
                'newbs.DataMember = "stocks_tb"
                'sourceColorCbox.DataSource = newbs
                'sourceColorCbox.DisplayMember = "TypeColor"
                'If x > sourceColorCbox.Items.Count - 1 Then
                '    sourceColorCbox.SelectedIndex = -1
                'Else
                '    sourceColorCbox.SelectedIndex = x
                'End If
                initializeDatasource(sourceColorCbox, _sourceColords, "stocks_tb", "TypeColor")
            Case "sourceCostheadSuggestion"
                'Dim x As Integer = sourceCostheadCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _sourceCostheadds
                'newbs.DataMember = "stocks_tb"
                'sourceCostheadCbox.DataSource = newbs
                'sourceCostheadCbox.DisplayMember = "Costhead"
                'If x > sourceCostheadCbox.Items.Count - 1 Then
                '    sourceCostheadCbox.SelectedIndex = -1
                'Else
                '    sourceCostheadCbox.SelectedIndex = x
                'End If
                initializeDatasource(sourceCostheadCbox, _sourceCostheadds, "stocks_tb", "Costhead")
            Case "cpartArticleSuggestion"
                'Dim x As Integer = cpartArticleCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _cpartArticleds
                'newbs.DataMember = "stocks_tb"
                'cpartArticleCbox.DataSource = newbs
                'cpartArticleCbox.DisplayMember = "Articleno"
                'If x > cpartArticleCbox.Items.Count - 1 Then
                '    cpartArticleCbox.SelectedIndex = -1
                'Else
                '    cpartArticleCbox.SelectedIndex = x
                'End If
                initializeDatasource(cpartArticleCbox, _cpartArticleds, "stocks_tb", "Articleno")
            Case "cpartColorSuggestion"
                'Dim x As Integer = cpartColorCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _cpartColords
                'newbs.DataMember = "stocks_tb"
                'cpartColorCbox.DataSource = newbs
                'cpartColorCbox.DisplayMember = "TypeColor"
                'If x > cpartColorCbox.Items.Count - 1 Then
                '    cpartColorCbox.SelectedIndex = -1
                'Else
                '    cpartColorCbox.SelectedIndex = x
                'End If
                initializeDatasource(cpartColorCbox, _cpartColords, "stocks_tb", "TypeColor")
            Case "cpartCostheadSuggestion"
                'Dim x As Integer = cpartCostheadCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _cpartCostheadds
                'newbs.DataMember = "stocks_tb"
                'cpartCostheadCbox.DataSource = newbs
                'cpartCostheadCbox.DisplayMember = "Costhead"
                'If x > cpartCostheadCbox.Items.Count - 1 Then
                '    cpartCostheadCbox.SelectedIndex = -1
                'Else
                '    cpartCostheadCbox.SelectedIndex = x
                'End If
                initializeDatasource(cpartCostheadCbox, _cpartCostheadds, "stocks_tb", "Costhead")
            Case "cmArticleSuggestion"
                'Dim x As Integer = cmArticleCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _cmArticleds
                'newbs.DataMember = "ColorMngr_Tb"
                'cmArticleCbox.DataSource = newbs
                'cmArticleCbox.DisplayMember = "Articleno"
                'If x > cmArticleCbox.Items.Count - 1 Then
                '    cmArticleCbox.SelectedIndex = -1
                'Else
                '    cmArticleCbox.SelectedIndex = x
                'End If
                initializeDatasource(cmArticleCbox, _cmArticleds, "ColorMngr_Tb", "Articleno")
            Case "cmColorSuggestion"
                'Dim x As Integer = cmColorCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _cmColords
                'newbs.DataMember = "ColorMngr_Tb"
                'cmColorCbox.DataSource = newbs
                'cmColorCbox.DisplayMember = "TypeColor"
                'If x > cmColorCbox.Items.Count - 1 Then
                '    cmColorCbox.SelectedIndex = -1
                'Else
                '    cmColorCbox.SelectedIndex = x
                'End If
                initializeDatasource(cmColorCbox, _cmColords, "ColorMngr_Tb", "TypeColor")
            Case "cmCostheadSuggestion"
                'Dim x As Integer = cmCostheadCbox.SelectedIndex
                'Dim newbs As New BindingSource
                'newbs.DataSource = _cmCostheadds
                'newbs.DataMember = "ColorMngr_Tb"
                'cmCostheadCbox.DataSource = newbs
                'cmCostheadCbox.DisplayMember = "Costhead"
                'If x > cmCostheadCbox.Items.Count - 1 Then
                '    cmCostheadCbox.SelectedIndex = -1
                'Else
                '    cmCostheadCbox.SelectedIndex = x
                'End If
                initializeDatasource(cmCostheadCbox, _cmCostheadds, "ColorMngr_Tb", "Costhead")
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "loadSource"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "loadCpart"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "loadColorMngr"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "add"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "delete"
                For i As Integer = 0 To _id.Count - 1
                    Query(action, _id(i).ToString())
                Next
                bgw.ReportProgress(0)
            Case "ColorSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "specifiedColorSuggestion"
                Query(action, "")
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
            Case "cpartArticleSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "cpartColorSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "cpartCostheadSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "cmArticleSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "cmColorSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "cmCostheadSuggestion"
                Query(action, "")
                bgw.ReportProgress(0)
            Case "copy"
                Query(action, "")
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim da As SqlDataAdapter = New SqlDataAdapter()
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
                sqlcmd.Parameters.AddWithValue("@SourceStockno", _sourceStockno)
                sqlcmd.Parameters.AddWithValue("@CpartStockno", _cpartStockno)
                sqlcmd.Parameters.AddWithValue("@ColorAssigned", _colorAssigned)
                sqlcmd.Parameters.AddWithValue("@Id", id)
                sqlcmd.Parameters.AddWithValue("@row", _row)
                If command = "loadSource" Then
                    _sourceds = New DataSet
                    _sourceds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_sourceds, "Stocks_Tb")
                ElseIf command = "loadCpart" Then
                    _cpartds = New DataSet
                    _cpartds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cpartds, "Stocks_Tb")
                ElseIf command = "loadColorMngr" Then
                    _colorMgds = New DataSet
                    _colorMgds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_colorMgds, "ColorMngr_Tb")
                ElseIf command = "ColorSuggestion" Then
                    _colorAssignedds = New DataSet
                    _colorAssignedds.Clear()
                    initializeDataset(sqlcmd, _colorAssignedds, "ColorMngr_Tb")
                ElseIf command = "specifiedColorSuggestion" Then
                    _specifiedColords = New DataSet
                    _specifiedColords.Clear()
                    initializeDataset(sqlcmd, _specifiedColords, "ColorMngr_Tb")
                ElseIf command = "sourceArticleSuggestion" Then
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
                ElseIf command = "cpartArticleSuggestion" Then
                    _cpartArticleds = New DataSet
                    _cpartArticleds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cpartArticleds, "Stocks_Tb")
                ElseIf command = "cpartColorSuggestion" Then
                    _cpartColords = New DataSet
                    _cpartColords.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cpartColords, "Stocks_Tb")
                ElseIf command = "cpartCostheadSuggestion" Then
                    _cpartCostheadds = New DataSet
                    _cpartCostheadds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cpartCostheadds, "Stocks_Tb")
                ElseIf command = "cmArticleSuggestion" Then
                    _cmArticleds = New DataSet
                    _cmArticleds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cmArticleds, "ColorMngr_Tb")
                ElseIf command = "cmColorSuggestion" Then
                    _cmColords = New DataSet
                    _cmColords.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cmColords, "ColorMngr_Tb")
                ElseIf command = "cmCostheadSuggestion" Then
                    _cmCostheadds = New DataSet
                    _cmCostheadds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_cmCostheadds, "ColorMngr_Tb")
                Else
                    sqlcmd.ExecuteNonQuery()
                End If
            End Using
        End Using
    End Sub
    Private Sub initializeDataset(ByVal sqlcmd As SqlCommand, ByVal dset As DataSet, ByVal tbl As String)
        da.SelectCommand = sqlcmd
        da.Fill(dset, tbl)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        initializeSourceVariables()
        starter("loadSource")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        initializeCpartVariables()
        starter("loadCpart")
    End Sub
    Dim _sourceStockno As String = ""
    Dim _cpartStockno As String = ""
    Dim _id As New ArrayList

    Private Sub sourcegv_SelectionChanged(sender As Object, e As EventArgs) Handles sourcegv.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = sourcegv.SelectedRows
        For Each row As DataGridViewRow In rows
            _sourceStockno = row.Cells("Stockno").Value.ToString()
        Next
    End Sub

    Private Sub cpartgv_SelectionChanged(sender As Object, e As EventArgs) Handles cpartgv.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = cpartgv.SelectedRows
        For Each row As DataGridViewRow In rows
            _cpartStockno = row.Cells("Stockno").Value.ToString()
        Next
    End Sub
    Dim _colorAssigned As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _colorAssigned = colorAssignedCbox.Text
        If Not _sourceStockno = "" Then
            starter("add")
        End If
    End Sub

    Private Sub colorMngrgv_SelectionChanged(sender As Object, e As EventArgs) Handles colorMngrgv.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = colorMngrgv.SelectedRows
        _id = New ArrayList
        For Each row As DataGridViewRow In rows
            _id.Add(row.Cells("Id").Value.ToString())
            CopyToCpart._sourceStockno = row.Cells("Source_Stockno").Value.ToString()
            CopyCounterpart._sourceStockno = row.Cells("Source_Stockno").Value.ToString()
            CopyCounterpart.lblArticleno.Text = row.Cells("Articleno").Value.ToString()
            CopyCounterpart.lblCosthead.Text = row.Cells("Costhead").Value.ToString()
            CopyCounterpart.lblTypecolor.Text = row.Cells("Typecolor").Value.ToString()
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Delete selected record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        starter("delete")
    End Sub


    Private Sub sourceArticleCbox_MouseDown_1(sender As Object, e As MouseEventArgs) Handles sourceArticleCbox.MouseDown
        initializeSourceVariables()
        starter("sourceArticleSuggestion")
    End Sub

    Private Sub sourceColorCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles sourceColorCbox.MouseDown
        sourceArticleCbox.Text = ""
        initializeSourceVariables()
        starter("sourceColorSuggestion")
    End Sub

    Private Sub sourceCostheadCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles sourceCostheadCbox.MouseDown
        sourceColorCbox.Text = ""
        sourceArticleCbox.Text = ""
        initializeSourceVariables()
        starter("sourceCostheadSuggestion")
    End Sub

    Private Sub cpartCostheadCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles cpartCostheadCbox.MouseDown
        cpartColorCbox.Text = ""
        cpartArticleCbox.Text = ""
        initializeCpartVariables()
        starter("cpartCostheadSuggestion")
    End Sub

    Private Sub cpartColorCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles cpartColorCbox.MouseDown
        cpartArticleCbox.Text = ""
        initializeCpartVariables()
        starter("cpartColorSuggestion")
    End Sub

    Private Sub cpartArticleCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles cpartArticleCbox.MouseDown
        initializeCpartVariables()
        starter("cpartArticleSuggestion")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        initializeCMVariables()
        starter("loadColorMngr")
    End Sub

    Private Sub cmCostheadCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles cmCostheadCbox.MouseDown
        cmColorCbox.Text = ""
        cmArticleCbox.Text = ""
        initializeCMVariables()
        starter("cmCostheadSuggestion")
    End Sub

    Private Sub cmColorCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles cmColorCbox.MouseDown
        cmArticleCbox.Text = ""
        initializeCMVariables()
        starter("cmColorSuggestion")
    End Sub

    Private Sub cmArticleCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles cmArticleCbox.MouseDown
        initializeCMVariables()
        starter("cmArticleSuggestion")
    End Sub

    Private Sub colorAssignedCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles colorAssignedCbox.MouseDown
        starter("ColorSuggestion")
    End Sub

    Private Sub specifiedColorCbox_MouseDown(sender As Object, e As MouseEventArgs) Handles specifiedColorCbox.MouseDown
        starter("specifiedColorSuggestion")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CopyCounterpart._sourceStockno = "" Then
            MessageBox.Show("please select a reference from the main table", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            CopyCounterpart.Show()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If CopyToCpart._sourceStockno = "" Then
            MessageBox.Show("please select a reference from the main table", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            CopyToCpart.Show()
        End If
    End Sub

    Private Sub colorMngrgv_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles colorMngrgv.RowPostPaint
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
End Class