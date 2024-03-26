Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class CuttingListRecord
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _ds As New DataSet
    Dim _bs As New BindingSource
    Public Shared _stockno As String
    Private Sub CuttingListRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        GV.DataSource = _bs
        cboxStatus.SelectedIndex = 0
        InitializeControls()
        starter("Get_Cutting_List")
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Cutting_List"
                Query(action)
                bgw.ReportProgress(0)
            Case "Get_Stock"
                Query(action)
                bgw.ReportProgress(0)
            Case "Delete_Adjustment"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Cutting_List"
                GV.Columns.Clear()
                _bs.DataSource = _ds
                _bs.DataMember = "CL_List_Tb"
                addbtn()
                btntext()
                tablevalues()
                'GV.Columns("Id").Visible = False
                GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            Case "Get_Stock"
                lblAllocation.Text = _allocation
                lblArticleno.Text = _articleno
                lblDescription.Text = _description

        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Cutting_List"
                starter("Get_Stock")
            Case "Get_Stock"
                LoadingPBOX.Visible = False
            Case "Delete_Adjustment"
                InitializeControls()
                starter("Get_Cutting_List")
        End Select
    End Sub


    Public Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub InitializeControls()
        _status = cboxStatus.Text
        _reference = tboxRefernce.Text
    End Sub
    Dim _articleno As String
    Dim _description As String
    Dim _allocation As String
    Dim _status As String
    Dim _reference As String
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "For_Released_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Stockno", _stockno)
                sqlcmd.Parameters.AddWithValue("@Status", _status)
                sqlcmd.Parameters.AddWithValue("@Reference", _reference)
                sqlcmd.Parameters.AddWithValue("@Id", _id)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Get_Cutting_List" Then
                        _ds = New DataSet
                        _ds.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_ds, "CL_List_Tb")
                    ElseIf command = "Get_Stock" Then
                        Using rd As SqlDataReader = sqlcmd.ExecuteReader
                            While rd.Read
                                _articleno = rd(0).ToString
                                _description = rd(1).ToString
                                _allocation = rd(3).ToString
                            End While
                        End Using

                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub CuttingListRecord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Input_Adjustment.ShowDialog()
    End Sub
    Private Sub addbtn()
        Dim btnview As New DataGridViewButtonColumn
        With btnview
            .Name = ""
            .Text = "-"
            .UseColumnTextForButtonValue = False
            .HeaderText = "ACTION"
        End With
        GV.Columns.Insert(0, btnview)
    End Sub
    Private Sub btntext()
        For i As Integer = 0 To GV.RowCount - 1
            Dim row As DataGridViewRow = GV.Rows(i)
            If row.Cells("Input_Type").Value.ToString = "Stock Adjustment" Then
                row.Cells(0).Value = "delete"
            Else
                If row.Cells("Issue").Value > 0 Then
                    row.Cells(0).Value = "view transactions"
                Else
                    row.Cells(0).Value = "-"
                End If
            End If
        Next
    End Sub
    Private Sub tablevalues()
        Dim _total_in As Decimal
        Dim _total_out As Decimal
        Dim _balance As Decimal
        Dim _total_cl As Decimal
        Dim _total_for_release As Decimal
        Dim _total_adjustment As Decimal

        For i As Integer = 0 To GV.Rows.Count - 1
            Dim _row As DataGridViewRow = GV.Rows(i)
            Dim _input_type As String = _row.Cells("INPUT_TYPE").Value.ToString
            Dim _qty As Decimal = _row.Cells("QTY").Value.ToString
            Dim _issue As Decimal = _row.Cells("ISSUE").Value.ToString

            If _input_type = "Cutting List" Then

                _total_out += _issue
                _total_cl += _qty
                _total_for_release += (_qty - _issue)

            ElseIf _input_type = "Inventory Receipt" Then
                _total_in += _qty
            ElseIf _input_type = "Stock Adjustment" Then
                _total_adjustment += _qty
            End If
        Next

        _total_in = (_total_in + _total_adjustment)

        lblTotal_In.Text = _total_in.ToString("n0")
        lblTotal_For_Release.Text = _total_for_release.ToString("n0")
        lblTotal_Out.Text = _total_out.ToString("n0") + "/" + _total_cl.ToString("n0")
        _balance = _total_in - _total_cl
        lblBalance.Text = _balance.ToString("n0")
        lblPhysical.Text = (_total_in - _total_out).ToString("n0")
    End Sub
    Public Shared _idList As New ArrayList
    Private Sub GV_SelectionChanged(sender As Object, e As EventArgs) Handles GV.SelectionChanged
        Dim items As DataGridViewSelectedRowCollection = GV.SelectedRows
        _idList = New ArrayList
        For Each item As DataGridViewRow In items
            If item.Cells("Input_Type").Value.ToString() = "Cutting List" Then
                _idList.Add(item.Cells("Id").Value.ToString())
            End If
        Next
    End Sub
    Dim _id As String
    Private Sub GV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                Dim _btntext As String = GV.Item(0, e.RowIndex).Value.ToString
                If _btntext = "view transactions" Then
                    TransactionRecord._stockno = GV.Item("STOCKNO", e.RowIndex).Value.ToString
                    TransactionRecord._controlno = GV.Item("CLNO", e.RowIndex).Value.ToString
                    TransactionRecord.ShowDialog()
                ElseIf _btntext = "delete" Then
                    If MessageBox.Show("Delete item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        Exit Sub
                    End If
                    _id = GV.Item("Id", e.RowIndex).Value.ToString
                    starter("Delete_Adjustment")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InitializeControls()
        starter("Get_Cutting_List")
    End Sub

    Private Sub GV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellDoubleClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then

            'Dim row As DataGridViewRow = GV.Rows(e.RowIndex)
            'Dim id As String = row.Cells("Id").Value.ToString
            'CLStatusUpdate._id = id


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'For i As Integer = 0 To _idList.Count - 1
        '    MsgBox(_idList(i).ToString)
        'Next
        CLStatusUpdate.ShowDialog()
    End Sub
End Class