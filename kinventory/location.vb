Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Transitions
Public Class locationform
    Dim sql As New sql
    Public sqlcmd As New SqlCommand
    Public DA As New SqlDataAdapter

    Dim x As Integer
    Dim y As Integer
    Dim drag As Boolean

    Public Shared stockno As String
    Public Shared transno As String
    Public Shared transtype As String
    Public Shared reference As String
    Public id As String
    Dim UpdateLocation As String
    Public Shared Update_Trans_Location_bool As Boolean = False
    Dim HideZero As String
    Dim bgw As New BackgroundWorker
    Dim action As String

    Dim _bsLocation_List As New BindingSource
    Dim _bsDistinct_Location As New BindingSource
    Dim _bsGet_Location_History As New BindingSource
    Dim _dsGet_Location_History As New DataSet
    Dim _dsLocation_List As New DataSet
    Dim _dsDistinct_Location As New DataSet

    Private Sub location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        CboxHideZero.SelectedIndex = 1

        locationgridview.DataSource = _bsLocation_List
        Starter("Get_Location_List")
        location1load = True
    End Sub
    Private Sub Starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            HideZero = CboxHideZero.Text
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get_Location_List"
                setlocation.Text = ""
                currentqty.Text = "0"
                LoadingPBOX.Visible = False
                Starter("Get_Distinct_Location")
            Case "Get_Distinct_Location"
                LoadingPBOX.Visible = False
                locationHistory = setlocation.Text
                Starter("Get_Location_History")
                location1load = False
            Case "Get_Location_History"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get_Location_List"
                _bsLocation_List.DataSource = _dsLocation_List
                _bsLocation_List.DataMember = "locationtb"
                With locationgridview
                    .Columns("ID").Visible = False
                    .Columns("STOCKNO").Visible = False
                    .Columns("QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("QTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("QTY").DefaultCellStyle.Format = "N2"
                End With
            Case "Get_Distinct_Location"
                _bsDistinct_Location.DataSource = _dsDistinct_Location
                _bsDistinct_Location.DataMember = "locationtb"
                setlocation.DataSource = _bsDistinct_Location
                setlocation.DisplayMember = "location"
            Case "Get_Location_History"
                _bsGet_Location_History.DataSource = _dsGet_Location_History
                _bsGet_Location_History.DataMember = "lochistory"
                With LocationHistoryGV
                    .DataSource = _bsGet_Location_History
                    .Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("qty").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("LOCATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("stockno").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("transdate").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("transtype").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("balqty").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("balqty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("RBALQTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("RBALQTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("qty").DefaultCellStyle.Format = "N2"
                    .Columns("balqty").DefaultCellStyle.Format = "N2"
                    .Columns("RBALQTY").DefaultCellStyle.Format = "N2"
                End With
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get_Location_List"
                LoadLocationTb()
                bgw.ReportProgress(0)
            Case "Get_Distinct_Location"
                LoadSetLocation()
                bgw.ReportProgress(0)
            Case "Get_Location_History"
                GetLocationHistory()
                bgw.ReportProgress(0)
        End Select
    End Sub
    Public Sub LoadSetLocation()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Distinct_Location")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    _dsDistinct_Location = New DataSet
                    _dsDistinct_Location.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsDistinct_Location, "locationtb")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub LoadLocationTb()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_List")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Visibility", HideZero)
                    _dsLocation_List = New DataSet
                    _dsLocation_List.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsLocation_List, "locationtb")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        tboxLocation.Text = tboxLocation.Text.Replace("'", "")
        tboxLocation.Text = tboxLocation.Text.Replace("""", "")
        Additem()
    End Sub
    Private Sub Add_Location()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Add_Location")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", tboxLocation.Text)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Function Location_HasRow() As Boolean
        Dim result As Boolean
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Search_Location")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", tboxLocation.Text)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows = True Then
                            result = True
                        Else
                            result = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function
    Public Sub Additem()
        Try
            If Location_HasRow() = True Then
                MessageBox.Show("Try different location.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Add_Location()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Starter("Get_Location_List")
        End Try
    End Sub

    Private Sub locationgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles locationgridview.CellClick
        If locationgridview.RowCount >= 0 And e.RowIndex >= 0 Then
            id = locationgridview.Item(0, e.RowIndex).Value.ToString
            tboxLocation.Text = locationgridview.Item(2, e.RowIndex).Value.ToString
            UpdateLocation = locationgridview.Item(2, e.RowIndex).Value.ToString
            adjustment.setlocation.Text = locationgridview.Item(2, e.RowIndex).Value.ToString
            adjustment.currentqty.Text = locationgridview.Item(3, e.RowIndex).Value.ToString
            transfer.location.Text = locationgridview.Item(2, e.RowIndex).Value.ToString
            transfer.currentqty.Text = locationgridview.Item(3, e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        Updateitem()
    End Sub
    Private Sub Update_Location()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Update_Location")
                    sqlcmd.Parameters.AddWithValue("@Id", id)
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", tboxLocation.Text)
                    sqlcmd.Parameters.AddWithValue("@UpdateLocation", UpdateLocation)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Updateitem()
        Try
            If Location_HasRow() = True Then
                MessageBox.Show("Try different location.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Update_Location()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Starter("Get_Location_List")
        End Try
    End Sub
    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        Deleteitem()
    End Sub
    Private Sub Delete_Location()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@Command", "Delete_Location")
                    sqlcmd.Parameters.AddWithValue("@Id", id)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Function Search_Loc_History() As Boolean
        Dim result As Boolean
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "Loc_History_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Search_Loc_History")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", UpdateLocation)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows = True Then
                            result = True
                        Else
                            result = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return result
    End Function

    Public Sub Deleteitem()
        Try
            If Search_Loc_History() = True Then
                MessageBox.Show("unable to delete location, transaction history detected", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If MessageBox.Show("click yes to continue", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    MessageBox.Show("operation cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                Delete_Location()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Starter("Get_Location_List")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim x As String
        Dim y As String
        Try
            sql.sqlcon.Open()
            Dim str As String = "select sum(qty) from locationtb where stockno = '" & stockno & "'"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            Dim read As SqlDataReader = sqlcmd.ExecuteReader
            While read.Read
                x = read(0).ToString
            End While
            read.Close()

            Dim str1 As String = "select physical from stocks_tb where stockno = '" & stockno & "'"
            sqlcmd = New SqlCommand(str1, sql.sqlcon)
            Dim read1 As SqlDataReader = sqlcmd.ExecuteReader
            While read1.Read
                y = read1(0).ToString
            End While
            read1.Close()
        Catch ex As SqlException
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try


        If Not balance.Text = "0" Then
            MessageBox.Show("use remaining balance", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not x = y Then
            MessageBox.Show("location :" + x + " not equal to physical :" + y, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.Dispose()
            Me.Close()
        End If

    End Sub

    Private Sub KryptonPanel1_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    Private Sub KryptonPanel1_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        x = Cursor.Position.X - Me.Left
        y = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub KryptonPanel1_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Left = Cursor.Position.X - x
            Me.Top = Cursor.Position.Y - y
        End If
    End Sub

    Private Sub setlocation_MouseDown(sender As Object, e As MouseEventArgs) Handles setlocation.MouseDown
        Dim i As Integer = setlocation.SelectedIndex

        If i > setlocation.Items.Count - 1 Then
            setlocation.SelectedIndex = -1
        Else
            setlocation.SelectedIndex = i
        End If
    End Sub

    Dim location1load As Boolean = False
    Private Sub setlocation_TextChanged(sender As Object, e As EventArgs) Handles setlocation.TextChanged
        GetLocationQty()
        lblLocationHeader.Text = setlocation.Text + " - History"
        locationHistory = setlocation.Text
        If location1load = False Then
            Starter("Get_Location_History")
        End If
    End Sub
    Private Sub GetLocationQty()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_Qty")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", setlocation.Text)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            currentqty.Text = rd(0).ToString
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GetLocationHistory()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandText = "Loc_History_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_History")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", locationHistory)
                    _dsGet_Location_History = New DataSet
                    _dsGet_Location_History.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsGet_Location_History, "lochistory")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        If balance.Text = 0 Then
            MessageBox.Show("Insufficient balance!", "Transaction Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Update_Trans_Location_bool Then
                Update_Trans_Location()
            End If
            Inserthistory()
            Additional()
            Dim loc As String = setlocation.Text
            setlocation.Text = ""
            Starter("Get_Location_List")
            setlocation.Text = loc
        End If

    End Sub
    Private Sub Update_Trans_Location()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                Try
                    sqlcon.Open()
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("Command", "Update_Trans_Location")
                    sqlcmd.Parameters.AddWithValue("@Transno", transno)
                    sqlcmd.Parameters.AddWithValue("@Location", setlocation.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub Additional()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@Command", "Additional")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", setlocation.Text)
                    sqlcmd.ExecuteNonQuery()
                    balance.Text = balance.Text - setqty.Text
                    setqty.Text = 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub TrimInputFormFields()
        transtype = Trim(transtype)
        tboxLocation.Text = Trim(tboxLocation.Text)
        setlocation.Text = Trim(setlocation.Text)
        setqty.Text = Trim(setqty.Text)
        reference = Trim(reference)
    End Sub
    Private Function Get_Location_Qty() As Double
        Dim result As Double = 0
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_Qty")
                    sqlcmd.Parameters.AddWithValue("@Location", setlocation.Text)
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            result = Convert.ToDouble(rd(0).ToString)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Return result
    End Function
    Private Function Get_Stock_Location_Qty() As Double
        Dim result As Double = 0
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Stock_Location_Qty")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            result = Convert.ToDouble(rd(0).ToString)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Return result
    End Function
    Private Sub Insert_Location_Record(ByVal newbal As Double, ByVal robalance As Double)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "Loc_History_Stp"
                    With sqlcmd.Parameters
                        .AddWithValue("@Command", "Insert")
                        .AddWithValue("@Trans_Type", transtype)
                        .AddWithValue("@Trans_Date", Form2.transdate.Text)
                        .AddWithValue("@Stockno", stockno)
                        .AddWithValue("@Reference", reference)
                        .AddWithValue("@Location", setlocation.Text)
                        .AddWithValue("@Qty", setqty.Text)
                        .AddWithValue("@BalQty", newbal)
                        .AddWithValue("@RBalQty", robalance)
                    End With
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Inserthistory()
        Try
            TrimInputFormFields()
            Dim ebl As Double = Get_Location_Qty()
            Dim p As Double = Get_Stock_Location_Qty()
            Dim robalance As Double
            Dim q As Double = setqty.Text
            Dim newbal As Double
            If transtype = "Issue" Then
                newbal = p - q
                robalance = ebl - q
            ElseIf transtype = "Receipt" Then
                newbal = p + q
                robalance = ebl + q
            ElseIf transtype = "Return" Then
                newbal = p + q
                robalance = ebl + q
            ElseIf transtype = "+Adjustment" Then
                newbal = p + q
                robalance = ebl + q
            ElseIf transtype = "-Adjustment" Then
                newbal = p - q
                robalance = ebl - q
            End If
            Insert_Location_Record(newbal, robalance)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub setqty_Leave(sender As Object, e As EventArgs) Handles setqty.Leave
        If IsNumeric(setqty.Text) Then
            Dim x As Integer = balance.Text
            Dim y As Integer = setqty.Text
            If x < y Then
                MessageBox.Show("Insufficient balance!", "Transaction Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                setqty.Text = "0"
            Else
            End If
        Else
            MessageBox.Show("Nonnumeric data detected! please input a valid number.", "Set Adjustment Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            setqty.Text = "0"
            setqty.Focus()
        End If
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        If balance.Text = 0 Then
            MessageBox.Show("Insufficient balance!", "Transaction Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim x As Integer = currentqty.Text
            Dim y As Integer = setqty.Text

            If x < y Then
                MessageBox.Show("Insufficient stocks!", "Current Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Inserthistory()
                Subtract()
                Dim loc As String = setlocation.Text
                setlocation.Text = ""
                Starter("Get_Location_List")
                setlocation.Text = loc
            End If
        End If

    End Sub
    Public Sub Subtract()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Update_Qty")
                    sqlcmd.Parameters.AddWithValue("@Set_Qty", setqty.Text)
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", setlocation.Text)
                    sqlcmd.ExecuteNonQuery()
                    balance.Text = balance.Text - setqty.Text
                    setqty.Text = 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Dim locationHistory As String
    Private Sub locationgridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles locationgridview.CellDoubleClick

        If locationgridview.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = locationgridview.Rows(e.RowIndex)
            Dim loc As String = row.Cells("location").Value.ToString()
            lblLocationHeader.Text = loc + " - History"
            locationHistory = loc
            Starter("Get_Location_History")
        End If

    End Sub


    Private Sub locationgridview_MouseDown(sender As Object, e As MouseEventArgs) Handles locationgridview.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(locationgridview, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub AdjustmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdjustmentToolStripMenuItem.Click
        adjustment.stockno.Text = stockno
        adjustment.ShowDialog()
    End Sub

    Private Sub KryptonButton8_Click(sender As Object, e As EventArgs) Handles KryptonButton8.Click
        Starter("Get_Location_List")
    End Sub

    Private Sub TransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferToolStripMenuItem.Click
        transfer.stockno.Text = stockno
        transfer.ShowDialog()
    End Sub

    Private Sub setqty_TextChanged(sender As Object, e As EventArgs) Handles setqty.TextChanged
        Dim x As String = Trim(currentqty.Text)
        Dim y As String = Trim(setqty.Text)
        If IsNumeric(x) And IsNumeric(y) Then
            Dim d As Double = x
            Dim t As Double = y
            minusr.Text = (d - t).ToString("n2")
            addr.Text = (t + d).ToString("n2")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Starter("Get_Location_List")
    End Sub

    Private Sub KryptonButton7_Click(sender As Object, e As EventArgs) Handles KryptonButton7.Click
        LocationSummaryFRM.ShowDialog()
    End Sub

    Private Sub locationform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class