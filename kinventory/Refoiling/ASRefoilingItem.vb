Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ASRefoilingItem
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String

    Dim _projectds As New DataSet
    Dim _projectbs As New BindingSource

    Public Shared jo As String
    Public Shared project As String
    Public Shared color As String
    Public Shared qdate As String
    Public Shared command As String
    Private Sub ASRefoilingItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gvProject.DataSource = _projectbs
        starter("Items")
        If command = "Items" Then
            lblProject.Text = project
        Else
            lblProject.Text = color
            lblDate.Text = ""
        End If

        lblDate.Text = qdate
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Items"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Items"
                _projectbs.DataSource = _projectds
                _projectbs.DataMember = "Item_Tbl"
                If command = "Items" Then
                    gvProject.Columns("Project").Visible = False
                Else
                    gvProject.Columns("Project").Visible = True
                End If
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Items"
                Query()
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim da As SqlDataAdapter = New SqlDataAdapter()
    Private Sub Query()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "Refoiling_Area_Summary_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Jo", jo)
                sqlcmd.Parameters.AddWithValue("@Project", project)
                sqlcmd.Parameters.AddWithValue("@Article_No", color)
                sqlcmd.Parameters.AddWithValue("@Date", qdate)
                sqlcmd.Parameters.AddWithValue("@Refoiling_Status", ASRefoilingQuotationSummary._refoiling_Status)
                _projectds = New DataSet
                _projectds.Clear()
                da.SelectCommand = sqlcmd
                da.Fill(_projectds, "Item_Tbl")

            End Using
        End Using
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

    Private Sub ASRefoilingItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
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
End Class