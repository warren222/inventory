Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class genreferenceFRM
    Dim sqlcmd As New SqlCommand
    Dim sql As New sql
    Dim da As New SqlDataAdapter
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _dsGet_Reference As New DataSet
    Dim _bsGet_Reference As New BindingSource
    Dim _dsGet_Data As New DataSet
    Dim _bsGet_Data As New BindingSource
    Dim _ref As String
    Private Sub genreferenceFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        Loadreference()
        Starter("Get_Reference")
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
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Reference"
                reference.DataSource = _bsGet_Reference
                reference.DisplayMember = "project_label"
                LoadingPBOX.Visible = False
            Case "Get_Data"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Reference"
                _bsGet_Reference.DataSource = _dsGet_Reference
                _bsGet_Reference.DataMember = "Reference_Tbl"

            Case "Get_Data"
                _bsGet_Data.DataSource = _dsGet_Data
                _bsGet_Data.DataMember = "Data_Tbl"
                GridView.DataSource = _bsGet_Data
                With GridView
                    .Columns("job_order_no").Visible = False
                    .Columns("label").Visible = False
                    .Columns("sub_jo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End With
                For i As Integer = 0 To GridView.RowCount - 1
                    If GridView.Rows(i).Cells("label").Value = "1" Then
                        GridView.Rows(i).Cells("project_label").Style.Font = New Font("Tahoma", 9, FontStyle.Bold)
                        GridView.Rows(i).Cells("sub_jo").Style.Font = New Font("Tahoma", 9, FontStyle.Bold)
                    End If
                Next
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Reference"
                Loadreference()
                bgw.ReportProgress(0)
            Case "Get_Data"
                databaseform()
                bgw.ReportProgress(0)
        End Select
    End Sub
    Public Sub Loadreference()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "Assign_Reference_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Reference")
                    _dsGet_Reference = New DataSet
                    _dsGet_Reference.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsGet_Reference, "Reference_Tbl")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function turnover() As Boolean
        Dim x As Boolean = False
        Try
            Dim cs As String = "select * from turnoveraccesstb"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Using sqlcmd As SqlCommand = New SqlCommand(cs, sqlcon)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows Then
                            x = True
                        Else
                            x = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return x
    End Function
    Public Sub databaseform()
        Try
            Dim t As Integer
            Dim x As Boolean = turnover()
            If x = True Then
                t = 1
            Else
                t = 0
            End If
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "Assign_Reference_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Data")
                    sqlcmd.Parameters.AddWithValue("@Turn_Over", t)
                    sqlcmd.Parameters.AddWithValue("@Reference", _ref)
                    _dsGet_Data = New DataSet
                    _dsGet_Data.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsGet_Data, "Data_Tbl")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        _ref = reference.Text
        Starter("Get_Data")
    End Sub

    Private Sub GridView_SelectionChanged(sender As Object, e As EventArgs) Handles GridView.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = GridView.SelectedRows
        Dim xx As ArrayList = New ArrayList(selecteditems.Count)
        Dim yy As ArrayList = New ArrayList(selecteditems.Count)
        For Each row As DataGridViewRow In selecteditems
            xx.Add(row.Cells("project_label").Value.ToString)
            yy.Add(row.Cells("original jo").Value.ToString)
        Next
    End Sub

    Private Sub GridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellDoubleClick
        Me.Close()
    End Sub

    Private Sub genreferenceFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim selecteditems As DataGridViewSelectedRowCollection = GridView.SelectedRows
        Dim xx As ArrayList = New ArrayList(selecteditems.Count)
        Dim yy As ArrayList = New ArrayList(selecteditems.Count)
        For Each row As DataGridViewRow In selecteditems
            xx.Add(row.Cells("project_label").Value.ToString)
            yy.Add(row.Cells("original jo").Value.ToString)
        Next
        For i As Integer = 0 To xx.Count - 1
            Dim project As String = xx(i).ToString
            Dim pjo As String = yy(i).ToString
            If Me.Text = "Input" Then
                Form2.reference.Text = project
                Form2.jo.Text = pjo
            ElseIf Me.Text = "Receipt" Then
                Form2.receiptreference.Text = project
                Form2.receiptjo.Text = pjo
            ElseIf Me.Text = "Issue" Then
                Form2.issuereference.Text = project
                Form2.issuejo.Text = pjo
            ElseIf Me.Text = "movealloc" Then
                moveallocation.reference.Text = project
                moveallocation.jo.Text = pjo
            ElseIf Me.Text = "multimove" Then
                multimove.reference.Text = project
                multimove.JO.Text = pjo
            ElseIf Me.Text = "transman" Then
                Form2.transreference.Text = project
                Form2.transjo.Text = pjo
            ElseIf Me.Text = "reference" Then
                Form2.reffromreference.Text = project
                Form2.reffromjo.Text = pjo
            ElseIf Me.Text = "form5" Then
                Form5.newreference.Text = project
                Form5.NEWJO.Text = pjo
            ElseIf Me.Text = "change reference" Then
                changereferenceFRM.reference.Text = project
                changereferenceFRM.jo.Text = pjo
                changereferenceFRM.Button3.PerformClick()
            ElseIf Me.Text = "copy alloc" Then
                CopyTransaction.tboxreference.Text = project
                CopyTransaction.tboxjo.Text = pjo
            ElseIf Me.Text = "report" Then
                Form2.reporttboxreference.Text = project
                Form2.reporttboxjo.Text = pjo
            End If
        Next


        If Me.Text = "Input" Then
            Form2.reference.Text = reference.Text
        ElseIf Me.Text = "transman" Then
            Form2.transreference.Text = reference.Text
        ElseIf Me.Text = "form5" Then
            Form5.newreference.Text = reference.Text
        End If
        Me.Dispose()
    End Sub

    Private Sub reference_KeyDown(sender As Object, e As KeyEventArgs) Handles reference.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton5.PerformClick()
        End If
    End Sub

    Private Sub reference_MouseDown(sender As Object, e As MouseEventArgs) Handles reference.MouseDown
        Dim i As Integer = reference.SelectedIndex
        If i > reference.Items.Count - 1 Then
            reference.SelectedIndex = -1
        Else
            reference.SelectedIndex = i
        End If
    End Sub
End Class