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
    Public Shared transtype As String
    Public Shared reference As String
    Public id As String
    Dim UpdateLocation As String
    Private Sub location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboxHideZero.SelectedIndex = 0
        LoadLocationTb()
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
                    sqlcmd.Parameters.AddWithValue("@Visibility", CboxHideZero.Text)

                    Dim ds As New DataSet
                    Dim bs As New BindingSource
                    ds.Clear()

                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "locationtb")
                    End Using

                    bs.DataSource = ds
                    bs.DataMember = "locationtb"
                    locationgridview.DataSource = bs
                    locationgridview.Columns("ID").Visible = False
                    locationgridview.Columns("STOCKNO").Visible = False
                    locationgridview.Columns("QTY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    locationgridview.Columns("QTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    locationgridview.Columns("QTY").DefaultCellStyle.Format = "N2"
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            setlocation.Text = ""
            currentqty.Text = "0"
            LoadSetLocation()
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
            LoadLocationTb()
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
            LoadLocationTb()
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
            LoadLocationTb()
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
    Public Sub LoadSetLocation()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandText = "LocationRecord_Stp"
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Distinct_Location")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    Dim ds As New DataSet
                    ds.Clear()
                    Dim bs As New BindingSource
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "locationtb")
                        bs.DataSource = ds
                        bs.DataMember = "locationtb"
                        setlocation.DataSource = bs
                        setlocation.DisplayMember = "location"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub setlocation_TextChanged(sender As Object, e As EventArgs) Handles setlocation.TextChanged
        GetLocationQty()
        lblLocationHeader.Text = setlocation.Text + " - History"
        GetLocationHistory(setlocation.Text)
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
    Private Sub GetLocationHistory(ByVal location As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    sqlcon.Open()
                    sqlcmd.CommandText = "Loc_History_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@Command", "Get_Location_History")
                    sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                    sqlcmd.Parameters.AddWithValue("@Location", location)
                    Dim ds As New DataSet
                    ds.Clear()
                    Dim da As New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.Fill(ds, "lochistory")
                    Dim bs As New BindingSource
                    bs.DataSource = ds
                    bs.DataMember = "lochistory"
                    With LocationHistoryGV
                        .DataSource = bs
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
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        If balance.Text = 0 Then
        Else
            inserthistory()
            additional()
            Dim loc As String = setlocation.Text
            setlocation.Text = ""
            LoadLocationTb()
            setlocation.Text = loc
        End If

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
                MessageBox.Show("0 transaction qty.", "Insufficient balance!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                setqty.Text = "0"
            Else
            End If
        Else
            MessageBox.Show("Non numeric data detected! please input a valid number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            setqty.Focus()
        End If
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        If balance.Text = 0 Then
        Else
            Dim x As Integer = currentqty.Text
            Dim y As Integer = setqty.Text

            If x < y Then
                MessageBox.Show("insufficient stocks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                inserthistory()
                subtract()
                Dim loc As String = setlocation.Text
                setlocation.Text = ""
                LoadLocationTb()
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


    Private Sub locationgridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles locationgridview.CellDoubleClick
        'HISTORY.location.Text = location.Text
        'HISTORY.stockno = stockno
        'HISTORY.ShowDialog()
        If locationgridview.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = locationgridview.Rows(e.RowIndex)
            Dim loc As String = row.Cells("location").Value.ToString()
            lblLocationHeader.Text = loc + " - History"
            GetLocationHistory(loc)
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
        LoadLocationTb()
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
        LoadLocationTb()
    End Sub

    Private Sub KryptonButton7_Click(sender As Object, e As EventArgs) Handles KryptonButton7.Click
        LocationSummaryFRM.ShowDialog()
    End Sub
End Class