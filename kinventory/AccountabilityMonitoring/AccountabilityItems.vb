Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class AccountabilityItems
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim _ds As New DataSet
    Dim _bs As New BindingSource
    Dim _objectSender As String

    'Trans Page Variables
    Dim _dsTrans As New DataSet
    Dim _bsTrans As New BindingSource
    Dim _dsAccount As New DataSet
    Dim _dsSearchAccount As New DataSet
    Dim _dsSearchItemDescription As New DataSet
    Dim _dsReference As New DataSet

    Dim _searchItemDescription As String
    Dim _searchTranstype As String
    Dim _searchAccount As String
    Dim _transtrype As String
    Dim _account As String
    Dim _quantity As Integer
    Dim _itemid As String
    Dim _transid As String
    Dim _transdate As String
    Dim _reference As String
    Dim _requested_date As String
    Public Sub InitializeSearchVariablesPage2()
        _searchItemDescription = cboxSearchItemDescription.Text
        _searchTranstype = cboxSearchTransType.Text
        _searchAccount = cboxSearchAccount.Text
    End Sub
    Public Sub InitializeVariablesPage2()
        _transtrype = cboxTransType.Text
        _account = cboxAccount.Text
        _quantity = Convert.ToInt32(tboxQty.Text)
        _itemid = lblItemId.Text
        _transdate = dtpTransDate.Text
        _reference = cboxReference.Text
        _requested_date = tboxRequestedDate.Text
    End Sub
    Private Sub AccountabilityItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        GV.DataSource = _bs
        gvTrans.DataSource = _bsTrans
        cboxSearchTransType.SelectedIndex = 0
        InitializeSearchVariablesPage1()
        starter("Get")
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
    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Get"
                GV.Columns.Clear()
                _bs.DataSource = _ds
                _bs.DataMember = "Warehouse_Item_Tbl"
                addbtn()
            Case "Get_Trans"
                gvTrans.Columns.Clear()
                _bsTrans.DataSource = _dsTrans
                _bsTrans.DataMember = "Warehouse_Trans_Tbl"
                addbtnTrans()
            Case "Distinct_Description"
                initializeDatasource(cboxSearchItemDescription, _dsSearchItemDescription, "Warehouse_Item_Tbl", "Item_Description", "Id")
            Case "Distinct_Reference"
                initializeDatasource(cboxReference, _dsReference, "Warehouse_Trans_Tbl", "Reference", "Reference")
            Case "Distinct_Account"
                If _objectSender = "cboxSearchAccount" Then
                    initializeDatasource(cboxSearchAccount, _dsSearchAccount, "Warehouse_Trans_Tbl", "Account", "Account")
                ElseIf _objectSender = "cboxAccount" Then
                    initializeDatasource(cboxAccount, _dsAccount, "Warehouse_Trans_Tbl", "Account", "Account")
                End If
        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Get"
                LoadingPBOX.Visible = False
            Case "Add"
                Dim x = _executeVal
                InitializeSearchVariablesPage1()
                starter("Get")
            Case "Update"
                btnCancel.PerformClick()
                InitializeSearchVariablesPage1()
                starter("Get")
            Case "Delete"
                InitializeSearchVariablesPage1()
                starter("Get")
            Case "Get_Trans"
                LoadingPBOX.Visible = False
                lblItemId.Text = cboxSearchItemDescription.SelectedValue.ToString()
                lblItemDescription.Text = cboxSearchItemDescription.Text
                lblAccount.Text = cboxSearchAccount.Text

                Dim qty_issue As Integer = 0
                Dim qty_return_used As Integer = 0
                Dim qty_return_good As Integer = 0

                For Each row As DataGridViewRow In gvTrans.Rows
                    Dim transtype = row.Cells("Trans_Type").Value.ToString
                    If transtype = "Issue" Then
                        qty_issue += Convert.ToInt32(row.Cells("Qty").Value.ToString)
                    End If
                    If transtype = "Return Good" Then
                        qty_return_good += Convert.ToInt32(row.Cells("Qty").Value.ToString)
                    End If
                    If transtype = "Return Used" Then
                        qty_return_used += Convert.ToInt32(row.Cells("Qty").Value.ToString)
                    End If
                Next

                lblIssue.Text = qty_issue.ToString
                lblReturnGood.Text = qty_return_good.ToString
                lblReturnUsed.Text = qty_return_used.ToString
                lblNeedToReturn.Text = (qty_issue - (qty_return_good + qty_return_used)).ToString

            Case "Distinct_Description"
                LoadingPBOX.Visible = False
            Case "Distinct_Reference"
                LoadingPBOX.Visible = False
            Case "Distinct_Account"
                LoadingPBOX.Visible = False
            Case "Add_Trans"
                InitializeSearchVariablesPage2()
                starter("Get_Trans")
            Case "Delete_Trans"
                InitializeSearchVariablesPage2()
                starter("Get_Trans")
            Case "Has_Record"
                If _has_record = 0 Then
                    starter("Delete")
                Else
                    MessageBox.Show("This item is currently being used. Please ask the programmer to execute this action.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    LoadingPBOX.Visible = False
                End If
        End Select
    End Sub
    Dim _has_record As Integer
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Get"
                Query(action)
                bgw.ReportProgress(0)
            Case "Add"
                Query(action)
                bgw.ReportProgress(0)
            Case "Update"
                Query(action)
                bgw.ReportProgress(0)
            Case "Delete"
                Query(action)
                bgw.ReportProgress(0)
            Case "Has_Record"
                Query(action)
                bgw.ReportProgress(0)
            Case "Get_Trans"
                Query_Page2(action, _searchAccount, _searchItemDescription, _searchTranstype)
                bgw.ReportProgress(0)
            Case "Distinct_Description"
                Query_Page2(action, "", "", "")
                bgw.ReportProgress(0)
            Case "Distinct_Account"
                Query_Page2(action, "", "", "")
                bgw.ReportProgress(0)
            Case "Add_Trans"
                Query_Page2(action, _account, "", _transtrype)
                bgw.ReportProgress(0)
            Case "Delete_Trans"
                Query_Page2(action, "", "", "")
                bgw.ReportProgress(0)
            Case "Distinct_Reference"
                Query_Page2(action, "", "", "")
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim _search As String
    Dim _description As String
    Dim _id As String
    Private Sub InitializeSearchVariablesPage1()
        _search = tboxSearch.Text
    End Sub
    Dim _executeVal As Integer
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()

                sqlcmd.CommandText = "Warehouse_Item_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Search", _search)
                sqlcmd.Parameters.AddWithValue("@Item_Description", _description)
                sqlcmd.Parameters.AddWithValue("@Id", _id)
                If command = "Has_Record" Then
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            _has_record = rd(0).ToString()
                        End While
                    End Using
                Else
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        If command = "Get" Then
                            _ds = New DataSet
                            _ds.Clear()
                            da.SelectCommand = sqlcmd
                            da.Fill(_ds, "Warehouse_Item_Tbl")
                        Else
                            _executeVal = sqlcmd.ExecuteNonQuery().ToString
                        End If
                    End Using
                End If

            End Using
        End Using
    End Sub
    Private Sub addbtn()
        Dim btndelete As New DataGridViewButtonColumn
        With btndelete
            .Name = ""
            .Text = "delete"
            .UseColumnTextForButtonValue = True
            .HeaderText = "Action"
        End With
        GV.Columns.Insert(0, btndelete)
    End Sub
    Private Sub addbtnTrans()
        Dim btndelete As New DataGridViewButtonColumn
        With btndelete
            .Name = ""
            .Text = "delete"
            .UseColumnTextForButtonValue = True
            .HeaderText = "Action"
        End With
        gvTrans.Columns.Insert(0, btndelete)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tboxDescription.Text = "" Then
            MessageBox.Show("Please add description!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            _description = tboxDescription.Text
            If btnAdd.Text = "Add" Then
                starter("Add")
            ElseIf btnAdd.Text = "Update" Then
                starter("Update")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InitializeSearchVariablesPage1()
        starter("Get")
    End Sub

    Private Sub GV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellDoubleClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then
            _id = GV.Item("Id", e.RowIndex).Value.ToString
            tboxDescription.Text = GV.Item("Item_Description", e.RowIndex).Value.ToString
            btnAdd.Text = "Update"
            btnCancel.Visible = True
            GV.Enabled = False
            lblFormTitle.Text = "Update Form"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Text = "Add"
        lblFormTitle.Text = "Add Form"
        btnCancel.Visible = False
        GV.Enabled = True
    End Sub

    Private Sub GV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GV.CellClick
        If GV.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                If MessageBox.Show("Continue to delete the item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If

                _id = GV.Item("Id", e.RowIndex).Value.ToString
                starter("Has_Record")
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cboxSearchItemDescription.Text = "" Then
            MessageBox.Show("Please select an item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        InitializeSearchVariablesPage2()
        starter("Get_Trans")
    End Sub

    Private Sub Query_Page2(ByVal command As String, ByVal account As String, ByVal itemdescription As String, ByVal transtype As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "Warehouse_Trans_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                sqlcmd.Parameters.AddWithValue("@Account", account)
                sqlcmd.Parameters.AddWithValue("@Item_Id", _itemid)
                sqlcmd.Parameters.AddWithValue("@Item_Description", itemdescription)
                sqlcmd.Parameters.AddWithValue("@Requested_Date", _requested_date)
                sqlcmd.Parameters.AddWithValue("@Reference", _reference)
                sqlcmd.Parameters.AddWithValue("@Trans_Date", _transdate)
                sqlcmd.Parameters.AddWithValue("@Trans_Type", transtype)
                sqlcmd.Parameters.AddWithValue("@Qty", _quantity)
                sqlcmd.Parameters.AddWithValue("@Id", _transid)
                sqlcmd.Parameters.AddWithValue("@Data_Source", "Warehouse")
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "Get_Trans" Then
                        _dsTrans = New DataSet
                        _dsTrans.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsTrans, "Warehouse_Trans_Tbl")
                    ElseIf command = "Distinct_Description" Then
                        _dsSearchItemDescription = New DataSet
                        _dsSearchItemDescription.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsSearchItemDescription, "Warehouse_Item_Tbl")
                    ElseIf command = "Distinct_Reference" Then
                        _dsReference = New DataSet
                        _dsReference.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(_dsReference, "Warehouse_Trans_Tbl")
                    ElseIf command = "Distinct_Account" Then
                        If _objectSender = "cboxSearchAccount" Then
                            _dsSearchAccount = New DataSet
                            _dsSearchAccount.Clear()
                            da.SelectCommand = sqlcmd
                            da.Fill(_dsSearchAccount, "Warehouse_Trans_Tbl")
                        ElseIf _objectSender = "cboxAccount" Then
                            _dsAccount = New DataSet
                            _dsAccount.Clear()
                            da.SelectCommand = sqlcmd
                            da.Fill(_dsAccount, "Warehouse_Trans_Tbl")
                        End If
                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboxSearchItemDescription_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxSearchItemDescription.MouseDown
        starter("Distinct_Description")
    End Sub
    Private Sub initializeDatasource(ByVal sender As Object, ByVal dset As DataSet, ByVal datamember As String, ByVal displaymember As String, ByVal valuemember As String)
        Dim x As Integer = sender.SelectedIndex
        Dim newbs As New BindingSource
        With newbs
            .DataSource = dset
            .DataMember = datamember
        End With
        With sender
            .DataSource = newbs
            .DisplayMember = displaymember
            .ValueMember = valuemember
        End With

        If x > sender.Items.Count - 1 Then
            sender.SelectedIndex = -1
        Else
            sender.SelectedIndex = x
        End If
    End Sub

    Private Sub cboxSearchAccount_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxSearchAccount.MouseDown
        _objectSender = "cboxSearchAccount"
        starter("Distinct_Account")
    End Sub

    Private Sub cboxAccount_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxAccount.MouseDown
        _objectSender = "cboxAccount"
        starter("Distinct_Account")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim errormessage As String = ""

        If lblItemId.Text = "Item Id" Then
            errormessage = "-Please select an item!"
        End If
        If cboxTransType.Text = "" Then
            errormessage += System.Environment.NewLine + "-Please select transaction type!"
        End If
        If cboxAccount.Text = "" Then
            errormessage += System.Environment.NewLine + "-Please select account!"
        End If
        If dtpTransDate.Text = "" Then
            errormessage += System.Environment.NewLine + "-Please select date!"
        End If
        If cboxReference.Text = "" Then
            errormessage += System.Environment.NewLine + "-Please fill reference field!"
        End If

        If Not errormessage = "" Then
            MessageBox.Show(Trim(errormessage), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cboxSearchAccount.Text = cboxAccount.Text
        cboxSearchTransType.Text = cboxTransType.Text
        InitializeVariablesPage2()
        starter("Add_Trans")
    End Sub

    Private Sub gvTrans_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvTrans.CellClick
        If gvTrans.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                If MessageBox.Show("Continue to delete the item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                _transid = gvTrans.Item("Id", e.RowIndex).Value.ToString
                starter("Delete_Trans")
            End If
        End If
    End Sub

    Private Sub gvTrans_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles gvTrans.RowPostPaint
        sql._rowPostPaint(sender, e)
    End Sub

    Private Sub GV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles GV.RowPostPaint
        sql._rowPostPaint(sender, e)
    End Sub

    Private Sub cboxReference_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxReference.MouseDown
        starter("Distinct_Reference")
    End Sub
End Class