Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ASRefoilingQuotationSummary
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String

    Dim _projectds As New DataSet
    Dim _projectbs As New BindingSource

    Dim _colords As New DataSet
    Dim _colorbs As New BindingSource

    Private Sub ASRefoilingQuotationSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gvProject.DataSource = _projectbs
        gvColor.DataSource = _colorbs
        starter("loadProject")
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
            Case "loadProject"
                starter("loadColor")
            Case "loadColor"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "loadProject"
                _projectbs.DataSource = _projectds
                _projectbs.DataMember = "Project_Tbl"
            Case "loadColor"
                _colorbs.DataSource = _colords
                _colorbs.DataMember = "Color_Tbl"
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "loadProject"
                Query(action)
                bgw.ReportProgress(0)
            Case "loadColor"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim da As SqlDataAdapter = New SqlDataAdapter()
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "Refoiling_Area_Summary_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                If command = "loadProject" Then
                    _projectds = New DataSet
                    _projectds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_projectds, "Project_Tbl")
                ElseIf command = "loadColor" Then
                    _colords = New DataSet
                    _colords.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_colords, "Color_Tbl")
                End If
            End Using
        End Using
    End Sub

    Private Sub gvProject_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvProject.CellDoubleClick
        If e.RowIndex >= 0 And gvProject.ColumnCount >= 0 Then
            Dim row As DataGridViewRow = gvProject.Rows(e.RowIndex)

            ASRefoilingItem.jo = row.Cells("JO").Value.ToString()
            ASRefoilingItem.project = row.Cells("PROJECT").Value.ToString()
            ASRefoilingItem.color = row.Cells("COLOR").Value.ToString()
            ASRefoilingItem.qdate = row.Cells("DATE").Value.ToString()
            ASRefoilingItem.command = "Items"
            ASRefoilingItem.ShowDialog()
        End If
    End Sub

    Private Sub gvProject_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles gvProject.RowPostPaint
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

    Private Sub gvColor_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles gvColor.RowPostPaint
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

    Private Sub gvColor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvColor.CellDoubleClick
        If e.RowIndex >= 0 And gvColor.ColumnCount >= 0 Then
            Dim row As DataGridViewRow = gvColor.Rows(e.RowIndex)

            ASRefoilingItem.color = row.Cells("COLOR").Value.ToString()
            ASRefoilingItem.command = "ItemsByColor"
            ASRefoilingItem.ShowDialog()
        End If
    End Sub
End Class