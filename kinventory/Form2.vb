﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class Form2
    Dim sql As New sql
    Dim sqlcmd As New SqlCommand


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        Me.Text = Form1.accounttype.Text
        toprows.SelectedIndex = 0
        reftoprows.SelectedIndex = 0
        stocktoprows.SelectedIndex = 0
        sql.loadstocks(stocktoprows.Text)
        sql.loadtransactions(toprows.Text)
        sql.referencetb(reftoprows.Text)
        Timer1.Start()
        myyear.Text = Today.Date.Year

        If Form1.accounttype.Text = "Guest" Then
            'stocks
            KryptonButton2.Enabled = False
            KryptonButton17.Enabled = False
            KryptonButton3.Enabled = False
            KryptonButton23.Enabled = False
            'input
            KryptonButton4.Enabled = False
            'receipt
            KryptonButton5.Enabled = False
            'issue
            KryptonButton8.Enabled = False
            'reference
            KryptonButton14.Enabled = False

            physicaldatebtn.Enabled = False
            updatedatabtn.Enabled = False
        ElseIf Form1.accounttype.Text = "Admin" Then
            KryptonButton2.Enabled = True
            KryptonButton17.Enabled = True
            KryptonButton3.Enabled = True
            KryptonButton23.Enabled = True
            'input
            KryptonButton4.Enabled = True
            'receipt
            KryptonButton5.Enabled = True
            'issue
            KryptonButton8.Enabled = True
            'reference
            KryptonButton14.Enabled = True
        ElseIf Form1.accounttype.Text = "Encoder" Then
            KryptonButton2.Enabled = False
            KryptonButton17.Enabled = False
            KryptonButton3.Enabled = False
            KryptonButton23.Enabled = False
            'input
            KryptonButton4.Enabled = True
            'receipt
            KryptonButton5.Enabled = True
            'issue
            KryptonButton8.Enabled = True
            'reference
            KryptonButton14.Enabled = True

            physicaldatebtn.Enabled = False
            updatedatabtn.Enabled = False
        ElseIf Form1.accounttype.Text = "Allocation" Then

            KryptonButton2.Enabled = False
            KryptonButton17.Enabled = False
            KryptonButton3.Enabled = False
            KryptonButton23.Enabled = False
            'input
            KryptonButton4.Enabled = True
            'receipt
            KryptonButton5.Enabled = False
            'issue
            KryptonButton8.Enabled = False
            'reference
            KryptonButton14.Enabled = False
            If Form1.nickname.Text = "Joy" Or Form1.nickname.Text = "Nico" Or Form1.nickname.Text = "Lei" Then
                KryptonButton14.Enabled = True
            End If
            transaction.Text = "Allocation"
            transaction.Enabled = False


            physicaldatebtn.Enabled = False
            updatedatabtn.Enabled = False
        End If
        If Form1.nickname.Text = "Daniel" Or
           Form1.nickname.Text = "Warren" Or
           Form1.nickname.Text = "Noreen" Then
            btnCLMonitoring.Visible = True
            btnAddCLM.Visible = True
            physicaldatebtn.Enabled = True
            updatedatabtn.Enabled = True
        Else
            btnCLMonitoring.Visible = False
            btnAddCLM.Visible = False
        End If

        If Form1.nickname.Text = "Grace" Or Form1.nickname.Text = "Warren" Then
            AccountabilityMonitorToolStripMenuItem.Visible = True
        Else
            AccountabilityMonitorToolStripMenuItem.Visible = False
        End If
        cboxMonth1.SelectedIndex = Today.Month - 1
        cboxMonthPicker.SelectedIndex = 0
        loadYear()
    End Sub

    Private Sub stocksgridview_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles stocksgridview.RowPostPaint
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

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        stocksgridview.ClearSelection()
        Form3.Text = "New"
        Form3.ShowDialog()
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        Form3.Text = "Edit"
        Form3.ShowDialog()
    End Sub

    Private Sub stocksgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stocksgridview.CellClick
        If stocksgridview.RowCount >= 0 And e.RowIndex >= 0 Then
            Form3.colorbased.SelectedIndex = -1
            Form4.colorbased.SelectedIndex = -1
            stocknoinput.Text = stocksgridview.Item("STOCKNO", e.RowIndex).Value.ToString
            Form3.stockno.Text = stocksgridview.Item("STOCKNO", e.RowIndex).Value.ToString
            Form3.supplier.Text = stocksgridview.Item("SUPPLIER", e.RowIndex).Value.ToString
            Form3.costhead.Text = stocksgridview.Item("COSTHEAD", e.RowIndex).Value.ToString
            Form3.ufactor.Text = stocksgridview.Item("UFACTOR", e.RowIndex).Value.ToString
            Form3.typecolor.Text = stocksgridview.Item("TYPECOLOR", e.RowIndex).Value.ToString
            Form3.monetary.Text = stocksgridview.Item("MONETARY", e.RowIndex).Value.ToString
            Form3.articleno.Text = stocksgridview.Item("ARTICLENO", e.RowIndex).Value.ToString
            Form3.unitprice.Text = stocksgridview.Item("UNITPRICE", e.RowIndex).Value.ToString
            Form3.description.Text = stocksgridview.Item("DESCRIPTION", e.RowIndex).Value.ToString
            Form3.qty.Text = stocksgridview.Item("QTY", e.RowIndex).Value.ToString
            Form3.unit.Text = stocksgridview.Item("UNIT", e.RowIndex).Value.ToString
            Form3.location.Text = stocksgridview.Item("LOCATION", e.RowIndex).Value.ToString
            Form3.header.Text = stocksgridview.Item("HEADER", e.RowIndex).Value.ToString
            Form3.min.Text = stocksgridview.Item("MINIMUM", e.RowIndex).Value.ToString
            Form3.colorbased.Text = stocksgridview.Item("COLORBASED", e.RowIndex).Value.ToString
            Form3.foilwitha.Text = stocksgridview.Item("foilwitha", e.RowIndex).Value.ToString
            Form3.foilwithb.Text = stocksgridview.Item("foilwithb", e.RowIndex).Value.ToString
            Form3.foilcolor.Text = stocksgridview.Item("foilcolor", e.RowIndex).Value.ToString
            Form3.tofoil.Text = stocksgridview.Item("tofoil", e.RowIndex).Value.ToString
            Form3.toorder.Text = stocksgridview.Item("toorder", e.RowIndex).Value.ToString


            Form4.stockno.Text = stocksgridview.Item("STOCKNO", e.RowIndex).Value.ToString
            Form4.supplier.Text = stocksgridview.Item("SUPPLIER", e.RowIndex).Value.ToString
            Form4.costhead.Text = stocksgridview.Item("COSTHEAD", e.RowIndex).Value.ToString
            Form4.typecolor.Text = stocksgridview.Item("TYPECOLOR", e.RowIndex).Value.ToString
            Form4.monetary.Text = stocksgridview.Item("MONETARY", e.RowIndex).Value.ToString
            Form4.articleno.Text = stocksgridview.Item("ARTICLENO", e.RowIndex).Value.ToString
            Form4.unitprice.Text = stocksgridview.Item("UNITPRICE", e.RowIndex).Value.ToString
            Form4.description.Text = stocksgridview.Item("DESCRIPTION", e.RowIndex).Value.ToString
            Form4.unit.Text = stocksgridview.Item("UNIT", e.RowIndex).Value.ToString
            Form4.location.Text = stocksgridview.Item("LOCATION", e.RowIndex).Value.ToString
            Form4.header.Text = stocksgridview.Item("HEADER", e.RowIndex).Value.ToString
            Form4.qty.Text = stocksgridview.Item("QTY", e.RowIndex).Value.ToString
            Form4.allocation.Text = stocksgridview.Item("ALLOCATION", e.RowIndex).Value.ToString
            Form4.free.Text = stocksgridview.Item("FREE", e.RowIndex).Value.ToString
            Form4.order.Text = stocksgridview.Item("STOCKORDER", e.RowIndex).Value.ToString
            Form4.min.Text = stocksgridview.Item("MINIMUM", e.RowIndex).Value.ToString
            Form4.colorbased.Text = stocksgridview.Item("COLORBASED", e.RowIndex).Value.ToString

            description.Text = stocksgridview.Item("DESCRIPTION", e.RowIndex).Value.ToString
            location.Text = stocksgridview.Item("LOCATION", e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub stocksgridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles stocksgridview.CellDoubleClick
        sql.srockstransactiontb(Form4.stockno.Text)
        Form4.ShowDialog()
    End Sub

    Private Sub DateTimePicker8_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker8.ValueChanged
        duedate.Text = DateTimePicker8.Text
    End Sub

    Private Sub DateTimePicker8_MouseDown(sender As Object, e As MouseEventArgs) Handles DateTimePicker8.MouseDown
        duedate.Text = DateTimePicker8.Text
    End Sub

    Private Sub CheckBox38_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            DateTimePicker8.Visible = True
            duedate.Text = DateTimePicker8.Text
        ElseIf CheckBox38.Checked = False Then
            DateTimePicker8.Visible = False
        Else
            DateTimePicker8.Value = duedate.Text
        End If
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        If reference.Text = "" Then
            MessageBox.Show("input reference to proceed", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If transaction.Text = "Receipt" Or
                transaction.Text = "Return" Or transaction.Text = "+Adjustment" Then

                If transaction.Text = "Receipt" Then
                    receiptprocess()
                ElseIf transaction.Text = "Return" Then
                    returnprocess()
                ElseIf transaction.Text = "+Adjustment" Then
                    addadjustmentprocess()
                End If

                locationform.articleno.Text = transarticleno.Text + " - " + transaction.Text
                locationform.KryptonButton4.Visible = True
                locationform.KryptonButton5.Visible = False
                locationform.addr.Visible = True
                locationform.minusr.Visible = False
                locationform.addr.Visible = True
                locationform.minusr.Visible = False
                locationform.balance.Text = transqty.Text
                locationform.transtype = transaction.Text
                locationform.stockno = transstockno.Text
                locationform.reference = reference.Text
                locationform.ShowDialog()
            ElseIf transaction.Text = "-Adjustment" Then
                minadjustmentprocess()
                locationform.articleno.Text = transarticleno.Text + " - " + transaction.Text
                locationform.KryptonButton4.Visible = False
                locationform.KryptonButton5.Visible = True
                locationform.addr.Visible = False
                locationform.minusr.Visible = True
                locationform.addr.Visible = False
                locationform.minusr.Visible = True
                locationform.balance.Text = transqty.Text
                locationform.transtype = transaction.Text
                locationform.stockno = transstockno.Text
                locationform.reference = reference.Text
                locationform.ShowDialog()
            End If
            If transaction.Text = "Allocation" Then
                allocationproccess()
            ElseIf transaction.Text = "Order" Then
                orderprocess()
            ElseIf transaction.Text = "Supply" Then
                supplyprocess()
            ElseIf transaction.Text = "Spare" Then
                spareprocess()
            ElseIf transaction.Text = "Issue" Then
                Try
                    sql.sqlcon.Open()
                    Dim FINDALLOC As String = "Select ALLOCATION FROM REFERENCE_TB WHERE REFERENCE='" & reference.Text & "' and jo = '" & jo.Text & "' AND STOCKNO='" & transstockno.Text & "'"
                    sqlcmd = New SqlCommand(FINDALLOC, sql.sqlcon)
                    Dim read As SqlDataReader = sqlcmd.ExecuteReader
                    If read.HasRows = True Then
                        read.Close()
                        Dim da As New SqlDataAdapter
                        Dim ds As New DataSet
                        ds.Clear()
                        Dim bs As New BindingSource
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reference_tb")
                        bs.DataSource = ds
                        bs.DataMember = "reference_tb"
                        currentallocation.DataBindings.Clear()
                        currentallocation.DataBindings.Add("text", bs, "allocation")
                    Else
                        read.Close()
                        currentallocation.DataBindings.Clear()
                        currentallocation.Text = "0"
                    End If
                    sql.sqlcon.Close()
                    If currentallocation.Text = "0" Then
                        issueprocess()
                        locationform.articleno.Text = transarticleno.Text + " - " + transaction.Text
                        locationform.KryptonButton4.Visible = False
                        locationform.KryptonButton5.Visible = True
                        locationform.addr.Visible = False
                        locationform.minusr.Visible = True
                        locationform.balance.Text = transqty.Text
                        locationform.transtype = transaction.Text
                        locationform.stockno = transstockno.Text
                        locationform.reference = reference.Text
                        locationform.ShowDialog()
                    Else
                        msgbox2.ShowDialog()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            transaction.Focus()
        End If
    End Sub
    Public Sub allocationproccess()
        Dim allocate As Double = transqty.Text
        Dim free As Double = transfree.Text
        If allocate <= 0 Then
            MessageBox.Show("Allocate more than 0 To Continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                      transaction.Text,
                      transdate.Text,
                      duedate.Text,
                      transqty.Text,
                      reference.Text, jo.Text,
                      account.Text,
                      controlno.Text,
                               XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)

            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If

        End If
    End Sub
    Public Sub orderprocess()
        Dim myorder As Double = transqty.Text
        If myorder <= 0 Then
        Else

            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If

        End If
    End Sub
    Public Sub receiptprocess()
        Dim myreceipt As Double = transqty.Text
        If myreceipt <= 0 Then
        Else

            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub returnprocess()
        Dim myreturn As Double = transqty.Text
        If myreturn <= 0 Then
        Else
            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub supplyprocess()
        Dim mysupply As Double = transqty.Text
        If mysupply <= 0 Then
        Else
            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub spareprocess()
        Dim myspare As Double = transqty.Text
        If myspare <= 0 Then
        Else
            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub addadjustmentprocess()
        Dim myadjustment As Double = transqty.Text
        If myadjustment <= 0 Then
        Else
            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub minadjustmentprocess()
        Dim myadjustment As Double = transqty.Text
        If myadjustment <= 0 Then
        Else
            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub issueprocess()
        Dim issue As Double = transqty.Text
        Dim free As Double = transfree.Text
        Dim physical As Double = transphysical.Text
        If issue <= 0 Then

        Else

            Dim XYZ As String = ""
            Dim XYZREF As String = ""
            sql.newtransaction(transstockno.Text,
                   transaction.Text,
                   transdate.Text,
                   duedate.Text,
                   transqty.Text,
                   reference.Text, jo.Text,
                   account.Text,
                   controlno.Text, XYZ, XYZREF, remarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationInput.Text)
            updatestock(transstockno.Text, reference.Text, jo.Text)
            loadinputgridviews()
            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            'Dim II As Integer = transarticleno.SelectedIndex
            'sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
            'If II > transarticleno.Items.Count - 1 Then
            '    transarticleno.SelectedIndex = -1
            'Else
            '    transarticleno.SelectedIndex = II
            'End If
        End If
    End Sub
    Public Sub loadinputgridviews()
        Try
            sql.sqlcon.Open()
            Dim ds As New DataSet
            Dim bs As New BindingSource
            ds.Clear()
            Dim loadinput As String = "Declare @transno As varchar(50) = (select max(transno) from trans_tb) select * from trans_tb where transno = @transno"
            sqlcmd = New SqlCommand(loadinput, sql.sqlcon)
            Dim da As New SqlDataAdapter
            da.SelectCommand = sqlcmd
            da.Fill(ds, "trans_tb")
            bs.DataSource = ds
            bs.DataMember = "trans_tb"
            inputGridView.DataSource = bs
            Dim ds1 As New DataSet
            Dim bs1 As New BindingSource
            ds1.Clear()
            Dim loadstocks As String = "select STOCKNO,TYPECOLOR,ARTICLENO,QTY,PHYSICAL,ALLOCATION,FREE,STOCKORDER,MINIMUM from stocks_tb where STOCKNO = '" & transstockno.Text & "'"
            sqlcmd = New SqlCommand(loadstocks, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds1, "stocks_tb")
            bs1.DataSource = ds1
            bs1.DataMember = "stocks_tb"
            inputDataGridView1.DataSource = bs1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub updatetransaction(ByVal qty As String, ByVal transno As String)
        Try
            sql.sqlcon.Open()
            Dim x As String = "
declare @unitprice as decimal(10,4)=(select isnull(unitprice,0) from trans_tb where transno = '" & transno & "')
declare @xrate as decimal(10,2)=(select isnull(xrate,0) from trans_tb where transno = '" & transno & "')
declare @ufactor as decimal(10,4)=(select isnull(ufactor,0) from trans_tb where transno = '" & transno & "')
declare @qty as decimal(10,2)=" & qty & "
declare @netprice as decimal(10,2)=(@unitprice*@xrate)*(@qty*@ufactor)

DECLARE @receipt as varchar(max)=(select transno from trans_tb where xyzref='" & transno & "')
update trans_tb set qty = '" & qty & "',xyzref=@receipt,netamount=@netprice where transno = '" & transno & "'
update trans_tb set ufactor=@ufactor,unitprice=@unitprice,xrate=@xrate,netamount=@netprice where xyzref='" & transno & "'
"
            sqlcmd = New SqlCommand(x, sql.sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub updatestock(ByVal stockno As String, ByVal reference As String, ByVal jo As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "
                                    declare @stn as int = @stockno
                                    declare @allocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0)from trans_tb where stockno =@stn AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Return')+0
                                    declare @supply as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Supply')+0
                                    declare @spare as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Spare')+0
                                    declare @addadjustment as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='+Adjustment')+0
                                    declare @minadjustment as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='-Adjustment')+0
                                    declare @receipt as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation

                                    declare @productionallocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Allocation' and not PRODUCTIONALLOCATION = '')+0
                                    declare @multiply as decimal(10,2) = (select case when @productionallocation=0 then 0 else 1 end)
            update stocks_tb set  
                                    physical=(QTY+@totalreceipt+@return+@addadjustment)-(@totalissue+@minadjustment),
                                    allocation = @allocation-(@issueallocation+@cancelalloc),
                                    PRODUCTIONALLOCATION=(@productionallocation-(@issueallocation+@cancelalloc))*@multiply,
                                    free=(((QTY+@totalreceipt+@return+@addadjustment)-(@allocation-@cancelalloc)))-(@issue+@minadjustment),
                                    stockorder=@order-@receiptorder,
                                    issue=@totalissue
                                    where stockno=@stn"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            sqlcmd.Parameters.AddWithValue("@stockno", stockno)
            sqlcmd.CommandTimeout = 600
            sqlcmd.ExecuteNonQuery()


            Dim bny As String = "   declare @stn as int = @stockno
                                    declare @allocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "' and jo = '" & jo & "' AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "'  and jo = '" & jo & "' AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "'  and jo = '" & jo & "' AND TRANSTYPE='Return')+0
                                    declare @receipt as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "'  and jo = '" & jo & "' AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "'  and jo = '" & jo & "' AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "'  and jo = '" & jo & "' AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn and reference = '" & reference & "'  and jo = '" & jo & "' AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
                              
update reference_tb set 

                                    allocation=@allocation-(@issueallocation+@cancelalloc),
                                    stockorder=@order-@receiptorder,
                                    TOTALRECEIPT=@totalreceipt,
                                    totalissue=@totalissue,
                                    totalreturn=@return
                                    where stockno=@stn and reference='" & reference & "' and jo = '" & jo & "' "
            sqlcmd = New SqlCommand(bny, sql.sqlcon)
            sqlcmd.Parameters.AddWithValue("@stockno", stockno)
            sqlcmd.CommandTimeout = 600
            sqlcmd.ExecuteNonQuery()

            'Dim NEWSTR As String = "
            '                        declare @allocation as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Allocation')+0
            '                        declare @order as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Order')+0
            '                        declare @receipt as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Receipt')+0
            '                        declare @issue as decimal(10,2)=(select  COALESCE(sum(qty),0) from trans_tb where stockno ='" & stockno & "' and reference = '" & reference & "' AND TRANSTYPE='Issue')+0

            'update reference_tb set 

            '                        allocation=@allocation-@issue,
            '                        stockorder=@order-@receipt,
            '                        TOTALRECEIPT=@receipt,
            '                        totalissue=@issue
            '                        where stockno='" & stockno & "' and reference='" & reference & "'"
            'sqlcmd = New SqlCommand(NEWSTR, sql.sqlcon)
            'sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub



    Private Sub transcosthead_MouseDown(sender As Object, e As MouseEventArgs) Handles transcosthead.MouseDown
        ''Dim phasedout As String
        ''If KryptonCheckBox1.Checked = True Then
        ''    phasedout = " phasedout = 'Yes'"
        ''Else
        ''    phasedout = " not phasedout = 'Yes'"
        ''End If

        ''Dim x As Integer = transcosthead.SelectedIndex
        ''transtypecolor.Text = ""
        ''transarticleno.Text = ""
        ''transdescription.Text = ""
        ''transphysical.Text = 0
        ''transfree.Text = 0
        ''currentallocation.Text = 0
        ''unitprice.Text = 0
        ''xrate.Text = 0

        ''sql.costheadinput(phasedout)
        ''If x > transcosthead.Items.Count - 1 Then
        ''    transcosthead.SelectedIndex = -1
        ''Else
        ''    transcosthead.SelectedIndex = x
        ''End If
    End Sub

    Private Sub transtypecolor_MouseDown(sender As Object, e As MouseEventArgs) Handles transtypecolor.MouseDown
        'Dim phasedout As String
        'If KryptonCheckBox1.Checked = True Then
        '    phasedout = " and phasedout = 'Yes'"
        'Else
        '    phasedout = " and not phasedout = 'Yes'"
        'End If

        'transarticleno.Text = ""
        'transarticleno.Text = ""
        'transdescription.Text = ""
        'transphysical.Text = 0
        'transfree.Text = 0
        'currentallocation.Text = 0
        'unitprice.Text = 0
        'xrate.Text = 0
        'Dim x As Integer = transtypecolor.SelectedIndex
        'If transcosthead.Text = "" Then
        '    Dim phasedout1 As String
        '    If KryptonCheckBox1.Checked = True Then
        '        phasedout1 = " phasedout = 'Yes'"
        '    Else
        '        phasedout1 = " not phasedout = 'Yes'"
        '    End If
        '    sql.typecolorinput1(phasedout1)
        'Else
        '    sql.typecolorinput(transcosthead.Text, phasedout)
        'End If
        'If x > transtypecolor.Items.Count - 1 Then
        '    transtypecolor.SelectedIndex = -1
        'Else
        '    transtypecolor.SelectedIndex = x
        'End If
    End Sub

    Private Sub transarticleno_MouseDown(sender As Object, e As MouseEventArgs)

        'transdescription.Text = ""
        'transphysical.Text = 0
        'transfree.Text = 0
        'currentallocation.Text = 0
        'unitprice.Text = 0
        'xrate.Text = 0
        'Dim a As String

        'Dim phasedout As String = ""
        'If KryptonCheckBox1.Checked = True Then
        '    phasedout = "Yes"
        '    a = " phasedout "
        'ElseIf KryptonCheckBox1.Checked = False Then
        '    phasedout = ""
        '    a = " not phasedout "
        'End If

        'Dim x As Integer = transarticleno.SelectedIndex

        'If transcosthead.Text = "" And transtypecolor.Text = "" Then
        '    sql.articlenoinput1(phasedout, a)
        'ElseIf Not transcosthead.Text = "" And transtypecolor.Text = "" Then
        '    sql.articlenoinput2(transcosthead.Text, phasedout, a)
        'ElseIf transcosthead.Text = "" And Not transtypecolor.Text = "" Then
        '    sql.articlenoinput3(transtypecolor.Text, phasedout, a)
        'Else
        '    sql.articlenoinput(transcosthead.Text, transtypecolor.Text)
        'End If


        'If x > transarticleno.Items.Count - 1 Then
        '    transarticleno.SelectedIndex = -1
        'Else
        '    transarticleno.SelectedIndex = x
        'End If
    End Sub

    Private Sub receiptcosthead_MouseDown(sender As Object, e As MouseEventArgs) Handles receiptcosthead.MouseDown
        receipttypecolor.SelectedIndex = -1
        receiptarticleno.SelectedIndex = -1
        Dim i As Integer = receiptcosthead.SelectedIndex
        sql.costheadreceipt()
        If i > receiptcosthead.Items.Count - 1 Then
            receiptcosthead.SelectedIndex = -1
        Else
            receiptcosthead.SelectedIndex = i
        End If
    End Sub

    Private Sub receipttypecolor_MouseDown(sender As Object, e As MouseEventArgs) Handles receipttypecolor.MouseDown
        receiptarticleno.SelectedIndex = -1
        Dim i As Integer = receipttypecolor.SelectedIndex
        If receiptcosthead.Text = "" Then
            sql.typecolorreceipt1()
        Else
            sql.typecolorreceipt(receiptcosthead.Text)
        End If
        If i > receipttypecolor.Items.Count - 1 Then
            receipttypecolor.SelectedIndex = -1
        Else
            receipttypecolor.SelectedIndex = i
        End If
    End Sub

    Private Sub receiptarticleno_MouseDown(sender As Object, e As MouseEventArgs) Handles receiptarticleno.MouseDown
        Dim i As Integer = receiptarticleno.SelectedIndex
        If receiptcosthead.Text = "" And receipttypecolor.Text = "" Then
            sql.articlenoreceipt1()
        ElseIf Not receiptcosthead.Text = "" And receipttypecolor.Text = "" Then
            sql.articlenoreceipt2(receiptcosthead.Text)
        ElseIf receiptcosthead.Text = "" And Not receipttypecolor.Text = "" Then
            sql.articlenoreceipt3(receipttypecolor.Text)
        Else
            sql.articlenoreceipt(receiptcosthead.Text, receipttypecolor.Text)
        End If
        If i > receiptarticleno.Items.Count - 1 Then
            receiptarticleno.SelectedIndex = -1
        Else
            receiptarticleno.SelectedIndex = i
        End If
    End Sub

    Private Sub receiptreference_MouseDown(sender As Object, e As MouseEventArgs) Handles receiptreference.MouseDown
        Dim x As Integer = receiptreference.SelectedIndex
        sql.referencereceipt()
        If x > receiptreference.Items.Count - 1 Then
            receiptreference.SelectedIndex = -1
        Else
            receiptreference.SelectedIndex = x
        End If
        genjo("receipt", receiptreference.Text, receiptjo, "trans_tb", "jo")
    End Sub

    Private Sub KryptonButton6_Click(sender As Object, e As EventArgs) Handles KryptonButton6.Click
        sql.searchreference(receiptreference.Text, receiptstockno.Text)
        sql.selectreceiptreferencerecord1(receiptreference.Text, receiptjo.Text, receiptstockno.Text)
    End Sub

    Private Sub receiptGridView_SelectionChanged(sender As Object, e As EventArgs) Handles receiptGridView.SelectionChanged
        receiptarticleno.SelectedIndex = -1
        receiptcosthead.SelectedIndex = -1
        receipttypecolor.SelectedIndex = -1
        Dim selecteditem As DataGridViewSelectedRowCollection = receiptGridView.SelectedRows
        receiptorder.Text = 0

        For Each selecteditems As DataGridViewRow In selecteditem
            receiptorder.Text = selecteditems.Cells("qty").Value.ToString
            receiptstockno.Text = selecteditems.Cells("stockno").Value.ToString
            receipttransno.Text = selecteditems.Cells("transno").Value.ToString
            sql.selectsubreference(receiptstockno.Text)
        Next
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        Dim myreceipt As Double = receiptqty.Text
        Dim order As Double = receiptorder.Text

        If retainbal.Checked = False Then

            If myreceipt <= 0 Then
                MessageBox.Show("receipt more than 0 to continue", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf myreceipt > order Then
                MessageBox.Show("insufficient order", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim transaction = "Receipt"
                Dim duedate As String = ""
                Dim account As String = ""
                Dim controlno As String = ""
                Dim XYZ As String = "Order"
                Dim remarks As String = ""

                Dim discounted As Double
                Dim unit As Double = 0
                Dim rate As Double = 1
                Dim amount As Double = 0
                Dim ufactor As Double = 0
                Dim disc As Double = 0

                Dim rqty As Double = receiptqty.Text
                Try
                    sql.sqlcon.Open()
                    Dim str As String = "select ufactor,unitprice,xrate,disc,unitprice-((disc*0.01)*unitprice) as discounted from trans_tb where transno = '" & receipttransno.Text & "'"
                    sqlcmd = New SqlCommand(str, sql.sqlcon)
                    Dim read As SqlDataReader = sqlcmd.ExecuteReader
                    While read.Read
                        ufactor = read(0).ToString
                        discounted = read(4).ToString
                        rate = read(2).ToString
                        disc = read(3).ToString
                        unit = read(1).ToString
                    End While

                    read.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sql.sqlcon.Close()
                End Try

                amount = (rqty * ufactor) * (discounted * rate)





                sql.newtransaction(receiptstockno.Text,
                       transaction,
                       transdate.Text,
                       duedate,
                       receiptqty.Text,
                      receiptreference.Text, receiptjo.Text,
                       account,
                       controlno, XYZ, receipttransno.Text, remarks, ufactor, unit, disc, rate, amount, "")
                updatetransaction(receiptqty.Text, receipttransno.Text)
                updatestock(receiptstockno.Text, receiptreference.Text, receiptjo.Text)

                locationform.articleno.Text = receiptarticleno.Text + " - " + "Receipt"
                locationform.KryptonButton4.Visible = True
                locationform.KryptonButton5.Visible = False
                locationform.addr.Visible = True
                locationform.minusr.Visible = False
                locationform.balance.Text = receiptqty.Text
                locationform.transtype = "Receipt"
                locationform.stockno = receiptstockno.Text
                locationform.reference = receiptreference.Text

                locationform.ShowDialog()

                'sql.loadstocks()
                'sql.loadtransactions(toprows.Text)
                'sql.searchreference(receiptreference.Text, receiptstockno.Text)
                sql.selectreceiptreferencerecord(receiptreference.Text, receiptjo.Text)
            End If
        ElseIf retainbal.Checked = True Then
            If myreceipt <= 0 Then
                MessageBox.Show("receipt more than 0 to continue", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf myreceipt > order Then
                MessageBox.Show("insufficient order", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf myreceipt = order Then
                MessageBox.Show("0 balance expected", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Dim transaction = "Receipt"
                Dim duedate As String = ""
                Dim account As String = ""
                Dim controlno As String = ""
                Dim XYZ As String = "Order"
                Dim remarks As String = ""

                Dim discounted As Double
                Dim rate As Double
                Dim amount As Double
                Dim ufactor As Double
                Dim disc As Double

                Dim unitTCT As String
                Dim rqty As Double = receiptqty.Text
                Try
                    sql.sqlcon.Open()
                    Dim str As String = "select ufactor,unitprice,xrate,disc,unitprice-((disc*0.01)*unitprice) as discounted from trans_tb where transno = '" & receipttransno.Text & "'"
                    sqlcmd = New SqlCommand(str, sql.sqlcon)
                    Dim read As SqlDataReader = sqlcmd.ExecuteReader
                    While read.Read
                        ufactor = read(0).ToString
                        discounted = read(4).ToString
                        rate = read(2).ToString
                        disc = read(3).ToString
                        unitTCT = read(1).ToString
                    End While

                    read.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sql.sqlcon.Close()
                End Try

                amount = (rqty * ufactor) * (discounted * rate)


                sql.newtransaction(receiptstockno.Text,
                       transaction,
                       transdate.Text,
                       duedate,
                       receiptqty.Text,
                      receiptreference.Text, receiptjo.Text,
                       account,
                       controlno, XYZ, receipttransno.Text, remarks, ufactor, unitTCT, disc, rate, amount, "")
                updatetransaction(receiptqty.Text, receipttransno.Text)

                Dim bal = order - myreceipt
                neworderbalance(receipttransno.Text, bal)

                updatestock(receiptstockno.Text, receiptreference.Text, receiptjo.Text)
                'sql.loadstocks()
                'sql.loadtransactions(toprows.Text)
                'sql.searchreference(receiptreference.Text, receiptstockno.Text)



                locationform.articleno.Text = receiptarticleno.Text + " - " + "Receipt"
                locationform.KryptonButton4.Visible = True
                locationform.KryptonButton5.Visible = False
                locationform.addr.Visible = True
                locationform.minusr.Visible = False
                locationform.balance.Text = receiptqty.Text
                locationform.transtype = "Receipt"
                locationform.stockno = receiptstockno.Text
                locationform.ShowDialog()

                sql.selectreceiptreferencerecord(receiptreference.Text, receiptjo.Text)
            End If
        End If
    End Sub
    Public Sub neworderbalance(ByVal transno As String, ByVal bal As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "
declare @id as integer = (select max(TRANSNO)+1 from trans_tb)
insert into trans_tb
  (TRANSNO,STOCKNO,
            TRANSTYPE,
            TRANSDATE,
            DUEDATE,
            QTY,
            REFERENCE,jo,
            ACCOUNT,
            CONTROLNO,
            XYZ,
            XYZREF,
            REMARKS,
ufactor,unitprice,disc,xrate,netamount,
            INPUTTED)
select
   @id,STOCKNO,
            TRANSTYPE,
            TRANSDATE,
            DUEDATE,
            " & bal & ",
            REFERENCE,jo,
            ACCOUNT,
            CONTROLNO,
            '',
            '',
            REMARKS,ufactor,unitprice,disc,xrate,(unitprice*xrate)*(" & bal & "*ufactor),
            '" & Form1.nickname.Text & "'
            from trans_tb where transno = " & transno & ""
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub issuereference_MouseDown(sender As Object, e As MouseEventArgs) Handles issuereference.MouseDown
        Dim x As Integer = issuereference.SelectedIndex
        sql.referenceissue()
        If x > issuereference.Items.Count - 1 Then
            issuereference.SelectedIndex = -1
        Else
            issuereference.SelectedIndex = x
        End If
        genjo("issue", issuereference.Text, issuejo, "trans_tb", "jo")
    End Sub

    Private Sub issuecosthead_MouseDown(sender As Object, e As MouseEventArgs) Handles issuecosthead.MouseDown
        Dim x As Integer = issuecosthead.SelectedIndex
        issuearticleno.SelectedIndex = -1
        issuetypecolor.SelectedIndex = -1
        sql.costheadissue()
        If x > issuecosthead.Items.Count - 1 Then
            issuecosthead.SelectedIndex = -1
        Else
            issuecosthead.SelectedIndex = x
        End If
    End Sub

    Private Sub issuetypecolor_MouseDown(sender As Object, e As MouseEventArgs) Handles issuetypecolor.MouseDown
        Dim x As Integer = issuetypecolor.SelectedIndex
        issuearticleno.SelectedIndex = -1
        If issuecosthead.Text = "" Then
            sql.typecolorissue1()
        Else
            sql.typecolorissue(issuecosthead.Text)
        End If
        If x > issuetypecolor.Items.Count - 1 Then
            issuetypecolor.SelectedIndex = -1
        Else
            issuetypecolor.SelectedIndex = x
        End If
    End Sub

    Private Sub issuearticleno_MouseDown(sender As Object, e As MouseEventArgs) Handles issuearticleno.MouseDown
        Dim x As Integer = issuearticleno.SelectedIndex
        If issuecosthead.Text = "" And issuetypecolor.Text = "" Then
            sql.articlenoissue1()
        ElseIf Not issuecosthead.Text = "" And issuetypecolor.Text = "" Then
            sql.articlenoissue2(issuecosthead.Text)
        ElseIf issuecosthead.Text = "" And Not issuetypecolor.Text = "" Then
            sql.articlenoissue3(issuetypecolor.Text)
        Else
            sql.articlenoissue(issuecosthead.Text, issuetypecolor.Text)
        End If
        If x > issuearticleno.Items.Count - 1 Then
            issuearticleno.SelectedIndex = -1
        Else
            issuearticleno.SelectedIndex = x
        End If

    End Sub

    Private Sub KryptonButton7_Click(sender As Object, e As EventArgs) Handles KryptonButton7.Click
        issuearticleno.SelectedIndex = -1
        issuecosthead.SelectedIndex = -1
        issuetypecolor.SelectedIndex = -1
        sql.searchreferenceissue(issuereference.Text, issuejo.Text, issuestockno.Text)
        sql.selectissuereferencerecord1(issuereference.Text, issuejo.Text, issuestockno.Text)
    End Sub

    Private Sub issueDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles issueDataGridView.SelectionChanged
        Dim selecteditem As DataGridViewSelectedRowCollection = issueDataGridView.SelectedRows
        issueallocation.Text = 0

        For Each selecteditems As DataGridViewRow In selecteditem
            issueallocation.Text = selecteditems.Cells("allocation").Value.ToString
            issuestockno.Text = selecteditems.Cells("stockno").Value.ToString
            sql.selectsubreferenceissue(issuestockno.Text)
        Next
    End Sub

    Private Sub KryptonButton8_Click(sender As Object, e As EventArgs) Handles KryptonButton8.Click
        Dim myissue As Double = issueqty.Text
        Dim allocate As Double = issueallocation.Text
        Dim physical As Double = issuephysical.Text

        If myissue <= 0 Then
            MessageBox.Show("issue more than 0 to continue", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf myissue > allocate Then
            MessageBox.Show("insufficient allocation", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            loopissue.Text = issueqty.Text
            KryptonButton25.PerformClick()
            Dim duedate As String = ""
            Dim transaction = "Issue"

            Dim XYZ As String = "Allocation"
            Dim xyzref As String = ""
            sql.newtransaction(issuestockno.Text,
                   transaction,
                   transdate.Text,
                   duedate,
                   issueqty.Text,
                 issuereference.Text, issuejo.Text,
                   issueaccount.Text,
                   issuecontrolno.Text, XYZ, xyzref, issueremarks.Text, ufactor.Text, unitprice.Text, disc.Text, xrate.Text, netamount.Text, cboxLocationIssue.Text)

            updatestock(issuestockno.Text, issuereference.Text, issuejo.Text)


            locationform.articleno.Text = issuearticleno.Text + " - " + "Issue"
            locationform.KryptonButton4.Visible = False
            locationform.KryptonButton5.Visible = True
            locationform.addr.Visible = False
            locationform.minusr.Visible = True
            locationform.balance.Text = issueqty.Text
            locationform.transtype = "Issue"
            locationform.stockno = issuestockno.Text
            locationform.reference = issuereference.Text
            locationform.ShowDialog()

            'sql.loadstocks()
            'sql.loadtransactions(toprows.Text)
            sql.searchreferenceissue(issuereference.Text, issuejo.Text, issuestockno.Text)
            issueDataGridView.Visible = True
            KryptonGroup5.Visible = False

            issueqty.Text = 0

            KryptonButton9.PerformClick()
        End If
    End Sub

    Private Sub receiptreference_TextChanged(sender As Object, e As EventArgs) Handles receiptreference.TextChanged
        'genjo("receipt", receiptreference.Text, receiptjo, "trans_tb", "jo")
        'sql.selectreceiptreferencerecord(receiptreference.Text, receiptjo.Text)

    End Sub

    Private Sub issuereference_TextChanged(sender As Object, e As EventArgs) Handles issuereference.TextChanged
        'genjo("issue", issuereference.Text, issuejo, "trans_tb", "jo")
        'sql.selectissuereferencerecord(issuereference.Text, issuejo.Text)

    End Sub

    Private Sub KryptonButton9_Click(sender As Object, e As EventArgs) Handles KryptonButton9.Click
        issueDataGridView.Visible = True
        KryptonGroup5.Visible = False
    End Sub

    Private Sub issueDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles issueDataGridView.CellDoubleClick
        If issueDataGridView.RowCount > 0 And e.RowIndex >= 0 Then
            issueDataGridView.Visible = False
            KryptonGroup5.Visible = True
            loadallocationlist(KryptonTextBox1.Text, KryptonTextBox3.Text, KryptonTextBox2.Text)
            LISTOFALLOCATIONGRIDVIEW.SelectAll()
        End If
    End Sub
    Public Sub loadallocationlist(ByVal a As String, ByVal JO As String, ByVal b As String)
        Try
            sql.sqlcon.Open()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            Dim ds As New DataSet
            ds.Clear()
            Dim str As String = "select * from trans_tb where reference='" & a & "' and JO ='" & JO & "' and stockno='" & b & "' and transtype='Allocation' order by transdate desc"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "trans_tb")
            bs.DataSource = ds
            bs.DataMember = "trans_tb"
            LISTOFALLOCATIONGRIDVIEW.DataSource = bs
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub issueDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles issueDataGridView1.SelectionChanged
        Dim selecteditem As DataGridViewSelectedRowCollection = issueDataGridView1.SelectedRows
        issuephysical.Text = 0
        For Each x As DataGridViewRow In selecteditem
            issuephysical.Text = x.Cells("Physical").Value.ToString
        Next
    End Sub
    Public Sub clckbtn11event()
        Dim top As String = toprows.Text.Replace(",", "")
        Dim dtt As String = ""
        Dim tr As String = ""
        Dim where As String = ""
        If transtransaction.Text = "Issue & Supply" Then
            tr = "(a.transtype='Issue' or a.transtype='Supply')"
        ElseIf transtransaction.Text = "Issue & Receipt & +Adjustment-" Then
            tr = "(a.transtype='Issue' or a.transtype='Receipt' or a.transtype='+Adjustment' or a.transtype='-Adjustment')"
        ElseIf transtransaction.Text = "" Then
            tr = "a.transtype=a.transtype"
        Else
            tr = "a.transtype='" & transtransaction.Text & "'"
        End If

        Dim dec As String = "
                            declare @sdate as date = '" & transadate.Text & "'
                            declare @edate as date = '" & todate.Text & "'
                            declare @rownum as int = @top"

        If all.Checked = True Then
            dtt = " and a.TRANSDATE = a.TRANSDATE"
        ElseIf thisdate.Checked = True Then
            dtt = " and a.TRANSDATE = @sdate"
        ElseIf before.Checked = True Then
            dtt = " and a.TRANSDATE < @sdate"
        ElseIf after.Checked = True Then
            dtt = " and a.TRANSDATE > @sdate"
        ElseIf tomydate.Checked = True Then
            dtt = " and a.TRANSDATE between @sdate and @edate"
        End If

        Dim a As String = transreference.Text
        Dim b As String = transjo.Text
        Dim c As String = transactioncosthead.Text
        Dim d As String = transactiontypecolor.Text

        Dim acol As String = "a.reference"
        Dim bcol As String = "a.jo"
        Dim ccol As String = "b.costhead"
        Dim dcol As String = "b.typecolor"

        If a = "" Then
            a = "" & acol & ""
        Else
            a = "'" & a & "'"
        End If
        If b = "" Then
            b = "" & bcol & ""
        Else
            b = "'" & b & "'"
        End If
        If c = "" Then
            c = "" & ccol & ""
        Else
            c = "'" & c & "'"
        End If
        If d = "" Then
            d = "" & dcol & ""
        Else
            d = "'" & d & "'"
        End If

        where = "           where
                            " & acol & " = " & a & " and 
                            " & bcol & " = " & b & " and 
                            " & ccol & " = " & c & " and 
                            " & dcol & " = " & d & " and 
                            " & tr & "
                            " & dtt & " "

        Dim str As String = "" & dec & "
                            select * into #sourcetb from(select top (@rownum) a.TRANSNO,
                            a.STOCKNO,
                            b.COSTHEAD,
                            b.TYPECOLOR,
                            B.ARTICLENO,
                            B.DESCRIPTION,
                            a.TRANSTYPE,
                            a.TRANSDATE,
                            case when isdate(a.DUEDATE)=1 then cast(a.duedate as date) end as DUEDATE,
                            a.QTY,
                            a.REFERENCE,
                            a.JO,
                            a.ACCOUNT,
                            a.CONTROLNO,
                            a.LOCATION,
                            A.XYZ,
                            a.EXCESS,
                            a.REMARKS,
                            A.UFACTOR,
                            (a.ufactor * a.qty) as CHECKER,
                            a.UNITPRICE,
                            A.DISC,
                            ((a.ufactor * a.qty)*(a.unitprice-((a.disc*0.01)*a.unitprice))) as CURRENCY,
                            a.XRATE,
                            A.NETAMOUNT,
                            A.INPUTTED,
                            A.ADJUSTMENTQTY,
                            A.PRODUCTIONALLOCATION
                            from trans_tb as a inner join stocks_tb as b
                            on a.stockno = b.stockno
                            " & where & " order by transno desc) as sourcetb
                            select * from(select * from #sourcetb) as trans_tb"
        Dim count As String = "select format(count(a.TRANSNO),'n0'),format(sum(isnull(a.netamount,0)/isnull(a.xrate,0)),'n2') 
                              from trans_tb as a inner join stocks_tb as b on a.stockno = b.stockno
                            " & where & ""
        sql.searchtransaction(str, top, count)

    End Sub
    Private Sub KryptonButton11_Click(sender As Object, e As EventArgs) Handles KryptonButton11.Click
        clckbtn11event()

    End Sub

    Private Sub transgridview_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles transgridview.RowPostPaint
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

    Private Sub KryptonButton10_Click(sender As Object, e As EventArgs) Handles KryptonButton10.Click
        sql.loadtransactions(toprows.Text)
    End Sub

    Private Sub issueaccount_MouseDown(sender As Object, e As MouseEventArgs) Handles issueaccount.MouseDown

        Dim i As Integer = issueaccount.SelectedIndex
        sql.loadaccount()
        If i > issueaccount.Items.Count - 1 Then
            issueaccount.SelectedIndex = -1
        Else
            issueaccount.SelectedIndex = i
        End If
    End Sub

    Private Sub transgridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles transgridview.CellDoubleClick
        If transgridview.RowCount >= 0 And e.RowIndex >= 0 Then
            Form5.itcame.Text = ""
            sql.selecttransrec(Form5.transno.Text)
            sql.selectreference(Form5.stockno.Text, Form5.reference.Text, Form5.JO.Text)
            Form5.ShowDialog()
        End If
    End Sub

    Private Sub transgridview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles transgridview.CellClick
        If transgridview.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim ROW As DataGridViewRow = transgridview.Rows(e.RowIndex)
            Form5.transno.Text = ROW.Cells("TRANSNO").Value.ToString
            Form5.stockno.Text = ROW.Cells("STOCKNO").Value.ToString
            Form5.reference.Text = ROW.Cells("REFERENCE").Value.ToString
            Form5.XYZ.Text = ROW.Cells("XYZ").Value.ToString
            description.Text = ROW.Cells("DESCRIPTION").Value.ToString

            cuttinglist.transno.Text = ROW.Cells("TRANSNO").Value.ToString
            cuttinglist.remarks.Text = ROW.Cells("REMARKS").Value.ToString
        End If
    End Sub

    Private Sub transgridview_MouseDown(sender As Object, e As MouseEventArgs) Handles transgridview.MouseDown
        If e.Button = MouseButtons.Right Then
            transactionmenustrip.Show(transgridview, New Point(e.X, e.Y))
        End If
    End Sub
    Public transnoAlist As New ArrayList
    Public stocknoAlist As New ArrayList
    Public referenceAlist As New ArrayList
    Public joAlist As New ArrayList
    Public tqty As String
    Private Sub transgridview_SelectionChanged(sender As Object, e As EventArgs) Handles transgridview.SelectionChanged
        Dim selecteditem As DataGridViewSelectedRowCollection = transgridview.SelectedRows
        transnocombo.Items.Clear()
        transqtycombo.Items.Clear()
        Form6.transno.Items.Clear()
        reallocate.stockno.Items.Clear()
        reallocate.reference.Items.Clear()
        reallocate.transno.Items.Clear()
        reallocate.jo.Items.Clear()
        chagexrate.transno.Items.Clear()
        UpdateStockNo.transno.Items.Clear()
        UpdateStockNo.reference.Items.Clear()
        UpdateStockNo.jo.Items.Clear()
        UpdateStockNo.xyz.Items.Clear()
        UpdateStockNo.transtype.Items.Clear()
        UpdateStockNo.costhead.Items.Clear()
        UpdateStockNo.articleno.Items.Clear()
        transnoAlist = New ArrayList
        stocknoAlist = New ArrayList
        referenceAlist = New ArrayList
        joAlist = New ArrayList

        For Each item As DataGridViewRow In selecteditem
            Dim x As String = item.Cells("transno").Value.ToString
            Dim y As String = item.Cells("stockno").Value.ToString
            Dim z As String = item.Cells("reference").Value.ToString
            tqty = item.Cells("qty").Value.ToString
            Dim b As String = item.Cells("jo").Value.ToString
            Dim xyz As String = item.Cells("xyz").Value.ToString
            Dim transtype As String = item.Cells("transtype").Value.ToString
            Dim costhead As String = item.Cells("costhead").Value.ToString
            Dim articleno As String = item.Cells("articleno").Value.ToString

            transnocombo.Items.Add(x)
            transqtycombo.Items.Add(tqty)
            Form6.transno.Items.Add(x)
            reallocate.stockno.Items.Add(y)
            reallocate.reference.Items.Add(z)
            reallocate.transno.Items.Add(x)
            reallocate.jo.Items.Add(b)
            chagexrate.transno.Items.Add(x)
            UpdateStockNo.transno.Items.Add(x)
            UpdateStockNo.reference.Items.Add(z)
            UpdateStockNo.jo.Items.Add(b)
            UpdateStockNo.xyz.Items.Add(xyz)
            UpdateStockNo.transtype.Items.Add(transtype)
            UpdateStockNo.costhead.Items.Add(costhead)
            UpdateStockNo.articleno.Items.Add(articleno)
            transnoAlist.Add(item.Cells("transno").Value.ToString)
            stocknoAlist.Add(item.Cells("stockno").Value.ToString)
            referenceAlist.Add(item.Cells("reference").Value.ToString)
            joAlist.Add(item.Cells("jo").Value.ToString)


            chagexrate.xrate.Text = item.Cells("xrate").Value.ToString
            chagexrate.ufactor.Text = item.Cells("ufactor").Value.ToString
            chagexrate.discount.Text = item.Cells("disc").Value.ToString
            chagexrate.unit.Text = item.Cells("unitprice").Value.ToString
        Next
    End Sub

    Private Sub TransDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransDateToolStripMenuItem.Click
        Form6.KryptonLabel1.Text = "Edit Trans date"
        Form6.ShowDialog()
    End Sub

    Private Sub DueDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DueDateToolStripMenuItem.Click
        Form6.KryptonLabel1.Text = "Edit Due date"
        Form6.ShowDialog()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Or TabControl1.SelectedIndex = 2 Or TabControl1.SelectedIndex = 3 Or TabControl1.SelectedIndex = 5 Then
            description.Clear()
            location.Clear()
        ElseIf TabControl1.SelectedIndex = 0 Then
            description.Visible = True
            location.Visible = True
            KryptonLabel4.Visible = True
            KryptonLabel5.Visible = True
        ElseIf TabControl1.SelectedIndex = 4 Then
            description.Visible = True
            location.Visible = False
            KryptonLabel4.Visible = True
            KryptonLabel5.Visible = False
        End If
        If TabControl1.SelectedIndex = 2 Then
            Dim x As Integer = receiptreference.SelectedIndex
            sql.referencereceipt()
            If x > receiptreference.Items.Count - 1 Then
                receiptreference.SelectedIndex = -1
            Else
                receiptreference.SelectedIndex = x
            End If
        ElseIf TabControl1.SelectedIndex = 3 Then
            Dim x As Integer = issuereference.SelectedIndex
            sql.referenceissue()
            If x > issuereference.Items.Count - 1 Then
                issuereference.SelectedIndex = -1
            Else
                issuereference.SelectedIndex = x
            End If
        End If
    End Sub

    Private Sub transaction_TextChanged(sender As Object, e As EventArgs) Handles transaction.TextChanged
        If transaction.Text = "Issue" Or transaction.Text = "Return" Or transaction.Text = "Spare" Or transaction.Text = "Supply" Or
            transaction.Text = "+Adjustment" Or transaction.Text = "-Adjustment" Then
            KryptonLabel17.Visible = True
            controlno.Visible = True
            KryptonLabel16.Visible = True
            account.Visible = True
            KryptonLabel49.Visible = True
            currentallocation.Visible = True
            KryptonLabel50.Visible = True
            remarks.Visible = True
            cboxLocationInput.Visible = True
            KryptonLabel87.Visible = True
        Else
            KryptonLabel17.Visible = False
            controlno.Visible = False
            controlno.Text = ""
            KryptonLabel16.Visible = False
            account.Visible = False
            account.Text = ""
            KryptonLabel49.Visible = False
            currentallocation.Visible = False
            currentallocation.Text = 0
            KryptonLabel50.Visible = False
            remarks.Visible = False
            remarks.Text = ""
            'If transaction.Text = "Receipt" Then
            '    cboxLocationInput.Visible = True
            '    KryptonLabel87.Visible = True
            'Else
            '    cboxLocationInput.Visible = False
            '    KryptonLabel87.Visible = False
            'End If
        End If
        If transaction.Text = "Order" Or transaction.Text = "Receipt" Then
            unitprice.Visible = True
            xrate.Visible = True
            netamount.Visible = True
            currency.Visible = True
            ufactor.Visible = True
            disc.Visible = True
            KryptonLabel63.Visible = True
            KryptonLabel64.Visible = True
            KryptonLabel65.Visible = True
            KryptonLabel66.Visible = True
            KryptonLabel67.Visible = True
            KryptonLabel68.Visible = True
            'reference.Enabled = True
        Else
            unitprice.Visible = False
            xrate.Visible = False
            netamount.Visible = False
            currency.Visible = False
            ufactor.Visible = False
            disc.Visible = False
            KryptonLabel63.Visible = False
            KryptonLabel64.Visible = False
            KryptonLabel65.Visible = False
            KryptonLabel66.Visible = False
            KryptonLabel67.Visible = False
            KryptonLabel68.Visible = False
            xrate.Text = 0
            netamount.Text = 0
            ufactor.Text = 0
            disc.Text = 0
            currency.Text = 0
            'reference.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        KryptonLabel44.Text = TimeOfDay
    End Sub

    Private Sub referenceDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles referenceDataGridView.SelectionChanged
        refcombo.Items.Clear()
        refstock.Items.Clear()
        refjo.Items.Clear()
        Dim selecteditems As DataGridViewSelectedRowCollection = referenceDataGridView.SelectedRows
        Dim x As String
        Dim y As String
        Dim z As String
        For Each selecteditem As DataGridViewRow In selecteditems
            x = selecteditem.Cells("reference").Value.ToString
            y = selecteditem.Cells("stockno").Value.ToString
            z = selecteditem.Cells("jo").Value.ToString
            refcombo.Items.Add(x)
            refstock.Items.Add(y)
            refjo.Items.Add(z)
            changereferenceFRM.oldjo = selecteditem.Cells("jo").Value.ToString
            changereferenceFRM.oldreference = selecteditem.Cells("reference").Value.ToString
        Next

    End Sub

    Private Sub KryptonButton13_Click(sender As Object, e As EventArgs) Handles KryptonButton13.Click
        sql.referencetb(reftoprows.Text)
    End Sub

    Private Sub KryptonButton14_Click(sender As Object, e As EventArgs) Handles KryptonButton14.Click
        If MessageBox.Show("Do you want to delete this record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        For i As Integer = 0 To refcombo.Items.Count - 1
            Dim str As String = refcombo.Items(i).ToString
            Dim stockno As String = refstock.Items(i).ToString
            Dim jo As String = refjo.Items(i).ToString
            sql.removefromref(str, jo, stockno)
        Next
        KryptonButton12.PerformClick()
    End Sub

    Private Sub KryptonButton12_Click(sender As Object, e As EventArgs) Handles KryptonButton12.Click
        Dim where As String = ""
        Dim a As String = reffromreference.Text
        Dim b As String = reffromjo.Text
        Dim c As String = referencecosthead.Text
        Dim d As String = referencetypecolor.Text
        Dim f As String = referencearticleno.Text
        Dim acol As String = "a.reference"
        Dim bcol As String = "a.jo"
        Dim ccol As String = "b.costhead"
        Dim dcol As String = "b.typecolor"
        Dim fcol As String = "b.articleno"
        If a = "" Then
            a = "a.reference"
        Else
            a = "'" & a & "'"
        End If
        If b = "" Then
            b = "a.jo"
        Else
            b = "'" & b & "'"
        End If
        If c = "" Then
            c = "b.costhead"
        Else
            c = "'" & c & "'"
        End If
        If d = "" Then
            d = "b.typecolor"
        Else
            d = "'" & d & "'"
        End If
        If f = "" Then
            f = "b.articleno"
        Else
            f = "'" & f & "'"
        End If

        where = "where " & a & "= " & acol & " and 
                       " & b & "= " & bcol & " and 
                       " & c & "= " & ccol & " and 
                       " & d & "= " & dcol & " and 
                       " & f & "= " & fcol & ""
        sql.refsearch(where, reftoprows.Text)
    End Sub

    Private Sub notification_Click(sender As Object, e As EventArgs) Handles notification.Click
        sql.sqlcon.Open()
        sql.notifycritical()
        sql.sqlcon.Close()

        If Not notification.Text = "Notification" Then
            NotiForm.Show()
            NotiForm.MdiParent = Form1
            notification.StateCommon.Content.ShortText.Color1 = Color.Black
            notification.Enabled = False
        Else
            MessageBox.Show("0 Result Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub stocksgridview_MouseDown(sender As Object, e As MouseEventArgs) Handles stocksgridview.MouseDown
        If stocksgridview.RowCount >= 0 Then
            If e.Button = MouseButtons.Right Then
                ContextMenuStrip1.Show(stocksgridview, New Point(e.X, e.Y))
            End If
        End If
    End Sub
    Public Shared sotcknoArrayList As New ArrayList
    Private Sub stocksgridview_SelectionChanged(sender As Object, e As EventArgs) Handles stocksgridview.SelectionChanged
        stocksStocksno.Items.Clear()
        AccountabilityUpdate.stockList = New ArrayList
        AccountabilityUpdate.stockList.Clear()
        Dim x As String = ""
        Dim selecteditems As DataGridViewSelectedRowCollection = stocksgridview.SelectedRows
        For Each selecteditem As DataGridViewRow In selecteditems
            x = selecteditem.Cells("stockno").Value.ToString
            AccountabilityUpdate.stockList.Add(x)
            stocknoinput.Text = x
            stocksStocksno.Items.Add(x)
        Next
    End Sub

    Private Sub costheadsearch_MouseDown(sender As Object, e As MouseEventArgs) Handles costheadsearch.MouseDown
        Dim phasedout As String
        If phasedoutsearch.Checked = True Then
            phasedout = " and phasedout = 'Yes'"
        Else
            phasedout = " and not phasedout = 'Yes'"
        End If
        Dim x As Integer = costheadsearch.SelectedIndex
        Dim ssupplier As String = supplier.Text
        Dim headertxt As String = headercmb.Text
        If ssupplier = "" Then
            ssupplier = " supplier"
        Else
            ssupplier = "'" & ssupplier & "'"
        End If
        If headertxt = "" Then
            headertxt = " header"
        Else
            headertxt = "'" & headertxt & "'"
        End If
        sql.loadcostheadsearch(ssupplier, headertxt, phasedout)
        typecolorsearch.Text = ""
        articlenosearch.Text = ""
        If x > costheadsearch.Items.Count - 1 Then
            costheadsearch.SelectedIndex = -1
        Else
            costheadsearch.SelectedIndex = x
        End If

    End Sub

    Private Sub typecolorsearch_MouseDown(sender As Object, e As MouseEventArgs) Handles typecolorsearch.MouseDown
        Dim phasedout As String
        If phasedoutsearch.Checked = True Then
            phasedout = " and phasedout = 'Yes'"
        Else
            phasedout = " and not phasedout = 'Yes'"
        End If
        Dim x As Integer = typecolorsearch.SelectedIndex
        Dim ssupplier As String = supplier.Text
        Dim scosthead As String = costheadsearch.Text
        Dim headertxt As String = headercmb.Text
        If ssupplier = "" Then
            ssupplier = " supplier"
        Else
            ssupplier = "'" & ssupplier & "'"
        End If
        If scosthead = "" Then
            scosthead = " costhead"
        Else
            scosthead = "'" & scosthead & "'"
        End If
        If headertxt = "" Then
            headertxt = " header"
        Else
            headertxt = "'" & headertxt & "'"
        End If
        sql.loadtypecolorsearch(ssupplier, headertxt, scosthead, phasedout)
        articlenosearch.Text = ""
        If x > typecolorsearch.Items.Count - 1 Then
            typecolorsearch.SelectedIndex = -1
        Else
            typecolorsearch.SelectedIndex = x
        End If
    End Sub

    Private Sub articlenosearch_MouseDown(sender As Object, e As MouseEventArgs) Handles articlenosearch.MouseDown
        Dim phasedout As String
        If phasedoutsearch.Checked = True Then
            phasedout = " and phasedout = 'Yes'"
        Else
            phasedout = " and not phasedout = 'Yes'"
        End If
        Dim x As Integer = articlenosearch.SelectedIndex
        Dim ssupplier As String = supplier.Text
        Dim scosthead As String = costheadsearch.Text
        Dim stypecolor As String = typecolorsearch.Text
        Dim headertxt As String = headercmb.Text
        If ssupplier = "" Then
            ssupplier = " supplier"
        Else
            ssupplier = "'" & ssupplier & "'"
        End If
        If scosthead = "" Then
            scosthead = " costhead"
        Else
            scosthead = "'" & scosthead & "'"
        End If
        If stypecolor = "" Then
            stypecolor = " typecolor"
        Else
            stypecolor = "'" & stypecolor & "'"
        End If

        If headertxt = "" Then
            headertxt = " header"
        Else
            headertxt = "'" & headertxt & "'"
        End If

        sql.loadarticlesearch(ssupplier, headertxt, scosthead, stypecolor, phasedout)

        If x > articlenosearch.Items.Count - 1 Then
            articlenosearch.SelectedIndex = -1
        Else
            articlenosearch.SelectedIndex = x
        End If

    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        'Dim phasedout As String
        'If phasedoutsearch.Checked = True Then
        '    phasedout = "yes"
        'Else
        '    phasedout = ""
        'End If

        'Dim search As String = ""
        'Dim fields As String = ""
        'If Not costheadsearch.Text = "" And typecolorsearch.Text = "" And articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "costhead ='" & costheadsearch.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And Not typecolorsearch.Text = "" And articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "costhead ='" & costheadsearch.Text & "' and typecolor='" & typecolorsearch.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And typecolorsearch.Text = "" And Not articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "costhead ='" & costheadsearch.Text & "' and articleno='" & articlenosearch.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And typecolorsearch.Text = "" And articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "costhead ='" & costheadsearch.Text & "' and articleno='" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And Not typecolorsearch.Text = "" And articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "typecolor ='" & typecolorsearch.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And Not typecolorsearch.Text = "" And Not articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "typecolor ='" & typecolorsearch.Text & "' and articleno = '" & articlenosearch.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And Not typecolorsearch.Text = "" And articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "typecolor ='" & typecolorsearch.Text & "' and status = '" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And typecolorsearch.Text = "" And Not articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "articleno ='" & articlenosearch.Text & "'  and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And typecolorsearch.Text = "" And Not articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "articleno ='" & articlenosearch.Text & "' and status = '" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And typecolorsearch.Text = "" And articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "status = '" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And Not typecolorsearch.Text = "" And Not articlenosearch.Text = "" And status.Text = "" Then
        '    fields = "costhead = '" & costheadsearch.Text & "' and typecolor='" & typecolorsearch.Text & "' and articleno='" & articlenosearch.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And typecolorsearch.Text = "" And Not articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "costhead = '" & costheadsearch.Text & "' and articleno='" & articlenosearch.Text & "' and status='" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And Not typecolorsearch.Text = "" And articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "costhead = '" & costheadsearch.Text & "' and typecolor='" & typecolorsearch.Text & "' and status='" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And Not typecolorsearch.Text = "" And Not articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "typecolor='" & typecolorsearch.Text & "' and articleno = '" & articlenosearch.Text & "' and status='" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf Not costheadsearch.Text = "" And Not typecolorsearch.Text = "" And Not articlenosearch.Text = "" And Not status.Text = "" Then
        '    fields = "costhead = '" & costheadsearch.Text & "' and typecolor='" & typecolorsearch.Text & "' and articleno = '" & articlenosearch.Text & "' and status='" & status.Text & "' and phasedout = '" & phasedout & "'"
        'ElseIf costheadsearch.Text = "" And typecolorsearch.Text = "" And articlenosearch.Text = "" And status.Text = "" Then
        '    fields = " phasedout = '" & phasedout & "'"
        'End If
        'search = "select * from stocks_tb where " & fields & " order by articleno asc"
        'sql.searchstocks(search)

        Dim phasedout As String = "Yes"
        Dim z As String = headercmb.Text
        Dim a As String = supplier.Text
        Dim b As String = costheadsearch.Text
        Dim c As String = typecolorsearch.Text
        Dim d As String = articlenosearch.Text
        Dim f As String = status.Text
        Dim g As String = phasedout
        Dim zcol As String = "header"
        Dim acol As String = " Supplier"
        Dim bcol As String = " Costhead"
        Dim ccol As String = " typecolor"
        Dim dcol As String = " articleno"
        Dim fcol As String = " status"
        Dim gcol As String = " phasedout"

        If phasedoutsearch.Checked = True Then
            gcol = " phasedout"
        Else
            gcol = " not phasedout"
        End If

        If z = "" Then
            z = " header"
        Else
            z = "'" & z & "'"
        End If

        If a = "" Then
            a = " Supplier"
        Else
            a = "'" & a & "'"
        End If

        If b = "" Then
            b = " Costhead"
        Else
            b = "'" & b & "'"
        End If

        If c = "" Then
            c = " typecolor"
        Else
            c = "'" & c & "'"
        End If

        If d = "" Then
            d = " articleno"
        Else
            d = "'" & d & "%'"
        End If

        If f = "" Then
            f = " status"
        Else
            f = "'" & f & "'"
        End If

        If g = "" Then
            g = " phasedout"
        Else
            g = "'" & g & "'"
        End If

        Dim condition As String
        condition = " where 
" & zcol & " = " & z & " and 
" & acol & " = " & a & " and 
" & bcol & " = " & b & " and
" & ccol & " = " & c & " and 
" & dcol & " like " & d & " and
" & fcol & " = " & f & " and
" & gcol & "= " & g & ""

        Dim top As String = stocktoprows.Text
        top = top.Replace(",", "")
        Dim search As String = "
declare @rownum as int = @top

select top (@rownum)
       a.[STOCKNO]
      ,a.[SUPPLIER]
      ,a.[COSTHEAD]
      ,a.[UFACTOR]
      ,a.[TYPECOLOR]
      ,a.[MONETARY]
      ,a.[ARTICLENO]
      ,a.[INTERNAL_ART_NO]
      ,a.[DISC]
      ,a.[UNITPRICE]
      ,a.[DESCRIPTION]
      ,a.[QTY]
      ,a.[UNIT]
      ,a.[LOCATION]
      ,a.[HEADER]
      ,a.[PHYSICAL]
      ,a.[ALLOCATION]
      ,a.[CLBAL]
      ,a.[FREE]
      ,a.[STOCKORDER]
      ,a.[MINIMUM]
      ,a.[ISSUE]
      ,a.[AVEUSAGE]
      ,a.[STATUS]
      ,a.[PHASEDOUT]
      ,a.[COLORBASED]
      ,a.[NEEDTOORDER]
      ,a.[FINALNEEDTOORDER]
      ,a.[INPUTTED]
      ,a.[TOORDER]
      ,a.[TOFOIL]
      ,a.[BALALLOC]
      ,a.[PHYSICAL2]
      ,a.[WEIGHT]
      ,a.[XRATE]
      ,a.[NETAMOUNT]
      ,a.[CONSUMPTION]
      ,a.[FOILWITHA]
      ,a.[FOILWITHB]
      ,a.[FOILCOLOR]
      ,a.[PRODUCTIONALLOCATION]
      ,[ACCOUNTABILITY_MONITORING] = (case when a.[ACCOUNTABILITY_MONITORING] = 1 then 'True' else 'False' end)
      ,(select sum(qty) from LOCATIONTB where STOCKNO=a.STOCKNO) as MYLOCATION
 from stocks_tb as a " & condition & ""
        sql.searchstocks(search, top)
    End Sub

    Private Sub KryptonButton15_Click(sender As Object, e As EventArgs) Handles KryptonButton15.Click
        sql.loadstocks(stocktoprows.Text)
    End Sub

    Private Sub account_MouseDown(sender As Object, e As MouseEventArgs) Handles account.MouseDown
        sql.loadaccount()
    End Sub

    Private Sub referencecosthead_MouseDown(sender As Object, e As MouseEventArgs) Handles referencecosthead.MouseDown
        referencetypecolor.Text = ""
        referencearticleno.Text = ""
        findcostheadforref()
    End Sub
    Public Sub findcostheadforref()
        Try
            sql.sqlcon.Open()
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            Dim str As String = "select distinct costhead from STOCKS_TB where STOCKNO in (select stockno from reference_tb)"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "STOCKS_TB")
            bs.DataSource = ds
            bs.DataMember = "STOCKS_TB"
            referencecosthead.DataSource = bs
            referencecosthead.DisplayMember = "costhead"
            referencecosthead.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub referencetypecolor_MouseDown(sender As Object, e As MouseEventArgs) Handles referencetypecolor.MouseDown
        referencearticleno.Text = ""
        findtypecolorforref(referencecosthead.Text)
    End Sub
    Public Sub findtypecolorforref(ByVal costhead As String)
        Try
            sql.sqlcon.Open()
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            Dim str As String = "select distinct typecolor from STOCKS_TB where costhead= '" & costhead & "' and STOCKNO in (select stockno from reference_tb)"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "STOCKS_TB")
            bs.DataSource = ds
            bs.DataMember = "STOCKS_TB"
            referencetypecolor.DataSource = bs
            referencetypecolor.DisplayMember = "typecolor"
            referencetypecolor.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub referencearticleno_MouseDown(sender As Object, e As MouseEventArgs) Handles referencearticleno.MouseDown
        findarticlenoforref(referencecosthead.Text, referencetypecolor.Text)
    End Sub
    Public Sub findarticlenoforref(ByVal costhead As String, ByVal typecolor As String)
        Try
            sql.sqlcon.Open()
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            Dim str As String = "select distinct articleno from STOCKS_TB where costhead= '" & costhead & "' and typecolor='" & typecolor & "' and STOCKNO in (select stockno from reference_tb)"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "STOCKS_TB")
            bs.DataSource = ds
            bs.DataMember = "STOCKS_TB"
            referencearticleno.DataSource = bs
            referencearticleno.DisplayMember = "articleno"
            referencearticleno.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton16_Click(sender As Object, e As EventArgs) Handles alltransactionsbtn.Click
        sql.alltransaction()
        AllTrans.ShowDialog()
    End Sub

    Private Sub referenceDataGridView_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles referenceDataGridView.RowPostPaint
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

    Private Sub KryptonButton17_Click(sender As Object, e As EventArgs) Handles refreshdatabtn.Click
        sql.loadstocks(stocktoprows.Text)
        sql.loadtransactions(toprows.Text)
        sql.referencetb(reftoprows.Text)
    End Sub

    Private Sub KryptonButton18_Click(sender As Object, e As EventArgs) Handles KryptonButton18.Click
        physicaldatebtn.PerformClick()
        sql.loaddummies()
        mydummyDataGridView1.SelectAll()
        If ir.Checked = True Then
            Dim phasedout As String
            Dim toorder As String
            If reportpasedout.Checked = True Then
                phasedout = " phasedout like '%yes%'"
            Else
                phasedout = " phasedout = phasedout"
            End If
            If reporttoorder.Checked = True Then
                toorder = " toorder='yes'"
            Else
                toorder = " toorder=toorder"
            End If

            Dim excludezero As String
            If excludeZeroCbox.Checked = True Then
                excludezero = " PHYSICAL2 <> 0 "
            Else
                excludezero = " PHYSICAL2 = PHYSICAL2 "
            End If


            Dim str As String
            'If reportsupplier.Text = "" And reportstatus.Text = "" Then
            '    str = "select * from stocks_tb where " & phasedout & " and " & toorder & ""
            'ElseIf Not reportsupplier.Text = "" And Not reportstatus.Text = "" Then
            '    str = "select * from stocks_tb where supplier='" & reportsupplier.Text & "' and status= '" & reportstatus.Text & "' and phasedout = '" & phasedout & "'  and toorder='" & toorder & "'"
            'ElseIf reportsupplier.Text = "" And Not reportstatus.Text = "" Then
            '    str = "select * from stocks_tb where status= '" & reportstatus.Text & "' and phasedout = '" & phasedout & "'  and toorder='" & toorder & "'"
            'ElseIf Not reportsupplier.Text = "" And reportstatus.Text = "" Then
            '    str = "select * from stocks_tb where supplier='" & reportsupplier.Text & "' and phasedout = '" & phasedout & "'  and toorder='" & toorder & "'"
            'End If

            Dim a As String = reportsupplier.Text
            Dim b As String = reportheader.Text
            Dim c As String = reportcosthead.Text
            Dim d As String = reporttypecolor.Text
            Dim f As String = reportstatus.Text

            If a = "" Then
                a = " supplier = supplier"
            Else
                a = " supplier = '" & a & "'"
            End If
            If b = "" Then
                b = " header = header"
            Else
                b = " header = '" & b & "'"
            End If
            If c = "" Then
                c = " costhead = costhead"
            Else
                c = " costhead = '" & c & "'"
            End If
            If d = "" Then
                d = " typecolor = typecolor"
            Else
                d = " typecolor = '" & d & "'"
            End If
            If f = "" Then
                f = " status = status"
            Else
                f = " status = '" & f & "'"
            End If
            str = "select * from stocks_tb where  " & a & " and " & b & " and " & c & " and " & d & " and " & f & " and " & phasedout & " and " & toorder & " and " & excludezero & ""



            sql.reporting(str + " order by articleno asc")
            Form8.ShowDialog()
        ElseIf scr.Checked = True Or esv.Checked = True Or esvp.Checked = True Then
            Dim parReportParam1 As New ReportParameter("buffermonth", Me.mymonth.Text)
            Dim parReportParam2 As New ReportParameter("oldForm", cboxOldForm.Checked)
            Form7.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {parReportParam1})
            Form7.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {parReportParam2})


            ESVfrm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {parReportParam1})
            ESVPfrm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {parReportParam1})

            Dim updateneedtoorder As String = "
declare @buffmonth as decimal(10,2) = '" & mymonth.Text & "'
update
a
set a.needtoorder
=((((@buffmonth)*(b.CONSUMPTION/12))+(a.allocation+a.minimum))-(a.physical+a.stockorder))
from STOCKS_TB as a
inner join CONSUMPTIONTB as b
on a.stockno=b.stockno where B.MYYEAR = '" & myyear.Text & "'"
            Dim firststr As String = "
DECLARE @TOWEIGHT AS DECIMAL(10,2)=(select sum(isnull((a.UFACTOR*a.FINALNEEDTOORDER)*isnull(a.WEIGHT,0),0)) from STOCKS_TB as a where a.finalneedtoorder > 0 "
            Dim str As String = "
select 
a.STOCKNO,
a.SUPPLIER,
a.COSTHEAD,
a.UFACTOR,
a.TYPECOLOR,
a.MONETARY,
a.ARTICLENO,
a.UNITPRICE,
a.DESCRIPTION,
a.QTY,
a.UNIT,
a.LOCATION,
a.HEADER,
a.PHYSICAL,
a.ALLOCATION,
a.FREE,
a.STOCKORDER,
a.MINIMUM,
a.ISSUE,
a.AVEUSAGE,
a.STATUS,
a.PHASEDOUT,
a.COLORBASED,
a.needtoorder,
A.FINALNEEDTOORDER,
b.STOCKNO,
b.CONSUMPTION,
b.MYYEAR,
a.weight,
a.XRATE,
(((a.PHYSICAL*a.UFACTOR)*a.UNITPRICE)*a.XRATE) AS PPHYSICAL,
(((a.ALLOCATION*a.UFACTOR)*a.UNITPRICE)*a.XRATE) AS PALLOCATION,
(((a.FREE*a.UFACTOR)*a.UNITPRICE)*a.XRATE) AS PFREE,
(((a.STOCKORDER*a.UFACTOR)*a.UNITPRICE)*a.XRATE) AS PSTOCKORDER,
(b.CONSUMPTION*a.UFACTOR) as ANNUALCONSUMPTION,
(a.PHYSICAL*a.UFACTOR) as PHYSICAL1,
((a.PHYSICAL*a.UFACTOR)*a.UNITPRICE) as PHYSICAL1unit,
(a.ALLOCATION*a.UFACTOR) as ALLOCATION1,
((a.ALLOCATION*a.UFACTOR)*a.UNITPRICE) as ALLOCATION1unit,
(a.STOCKORDER*a.UFACTOR) as STOCKORDER2,
((a.STOCKORDER*a.UFACTOR)*a.UNITPRICE) as STOCKORDER2unit,
(((((a.STOCKORDER*a.UFACTOR)+(a.PHYSICAL*a.UFACTOR))-(a.ALLOCATION*a.UFACTOR))*a.UNITPRICE)*a.XRATE) AS PKMDIVALUE,
 @TOWEIGHT AS TOTALWEIGHT,
(((a.STOCKORDER*a.UFACTOR)+(a.PHYSICAL*a.UFACTOR))-(a.ALLOCATION*a.UFACTOR)) AS KMDIVALUE,
((((a.STOCKORDER*a.UFACTOR)+(a.PHYSICAL*a.UFACTOR))-(a.ALLOCATION*a.UFACTOR))*a.UNITPRICE) as AMOUNTINEUR,
(((((a.STOCKORDER*a.UFACTOR)+(a.PHYSICAL*a.UFACTOR))-(a.ALLOCATION*a.UFACTOR))*a.UNITPRICE)*a.XRATE) as AMOUNTINPHP
from STOCKS_TB AS a
inner join CONSUMPTIONTB as b
on a.stockno = b.stockno where b.myyear='" & myyear.Text & "'"

            Dim phasedout As String
            Dim toorder As String
            If reportpasedout.Checked = True Then
                phasedout = " a.phasedout like '%yes%'"
            Else
                phasedout = " a.phasedout=a.phasedout "
            End If
            If reporttoorder.Checked = True Then
                toorder = " a.toorder='yes'"
            Else
                toorder = " a.toorder=a.toorder"
            End If




            Dim condition As String
            Dim a As String = reportsupplier.Text
            Dim b As String = reportheader.Text
            Dim c As String = reportcosthead.Text
            Dim d As String = reporttypecolor.Text
            Dim f As String = reportstatus.Text

            Dim acol As String = "a.supplier"
            Dim bcol As String = "a.header"
            Dim ccol As String = "a.costhead"
            Dim dcol As String = "a.typecolor"
            Dim fcol As String = "a.status"

            If a = "" Then
                a = " a.supplier = a.supplier"
            Else
                a = " a.supplier = '" & a & "'"
            End If
            If b = "" Then
                b = " a.header = a.header"
            Else
                b = " a.header = '" & b & "'"
            End If
            If c = "" Then
                c = " a.costhead = a.costhead"
            Else
                c = " a.costhead = '" & c & "'"
            End If
            If d = "" Then
                d = " a.typecolor = a.typecolor"
            Else
                d = " a.typecolor = '" & d & "'"
            End If
            If f = "" Then
                f = " a.status = a.status"
            Else
                f = " a.status = '" & f & "'"
            End If



            If reportpasedout.Checked = True And reporttoorder.Checked = True Then
                condition = " and  " & a & " and " & b & " and " & c & " and " & d & " and " & f & " and (" & phasedout & " or " & toorder & ")"
            Else
                condition = " and  " & a & " and " & b & " and " & c & " and " & d & " and " & f & " and " & phasedout & " and " & toorder & ""
            End If

            If scr.Checked = True Then
                Dim mystr As String = "" & firststr & "" + condition + ")" + "" & str & "" + condition + " order by a.articleno asc"
                sql.anualreporting(mystr, updateneedtoorder)
                Form7.ShowDialog()
            ElseIf esv.Checked = True Then
                Dim mystr As String = "" & firststr & "" + condition + ")" + "" & str & "" + condition + " order by a.articleno asc"
                sql.anualreportingESV(mystr, updateneedtoorder)
                ESVfrm.ShowDialog()
            ElseIf esvp.Checked = True Then
                Dim mystr As String = "" & firststr & "" + condition + ")" + "" & str & "" + condition + " order by a.articleno asc"
                sql.anualreportingESVP(mystr, updateneedtoorder)
                ESVPfrm.ShowDialog()
            End If


        End If
    End Sub



    Private Sub KryptonButton19_Click(sender As Object, e As EventArgs) Handles KryptonButton19.Click
        sql.loaddummies()
        mydummyDataGridView1.SelectAll()
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = mydummycombobox.Items.Count
        ProgressBar1.Value = 0
        For i As Integer = 0 To mydummycombobox.Items.Count - 1
            Dim stockno As String = mydummycombobox.Items(i).ToString
            sql.calculateanualconsumption(stockno, myyear.Text)
            ProgressBar1.Value += 1
        Next
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub mydummyDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles mydummyDataGridView1.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = mydummyDataGridView1.SelectedRows
        mydummycombobox.Items.Clear()
        Dim s As String
        For Each selecteditem As DataGridViewRow In selecteditems
            s = selecteditem.Cells("stockno").Value.ToString
            mydummycombobox.Items.Add(s)
        Next
    End Sub

    Public Sub autoupdatestock(ByVal stockno As String)
        Try

            Dim str As String = " 
                                    declare @stn as int = @stockno
                                    select * into #sourcetb from(
                                                                select right(remarks, charindex('=', reverse(remarks) + '=') - 1) as remarks from trans_tb where stockno = @stn and remarks <> '' and transtype = 'Allocation'
                                                                ) as sourcetb
                                    declare @clbal as decimal(10,2)=(select isnull(sum(isnull(CAST(remarks AS FLOAT),0)),0) from #sourcetb where try_convert(float, remarks) is not null)                                    
                                    declare @allocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Allocation')+0
                                    declare @cancelalloc as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='CancelAlloc')+0
                                    declare @order as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Order')+0
                                    declare @return as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Return')+0
                                    declare @supply as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Supply')+0
                                    declare @spare as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Spare')+0
                                    declare @addadjustment as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='+Adjustment')+0
                                    declare @minadjustment as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='-Adjustment')+0
                                    declare @receipt as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND NOT XYZ='Order')+0
                                    declare @issue as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation')+0
                                    declare @receiptorder as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND XYZ='Order')+0
                                    declare @issueallocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND XYZ ='Allocation')+0

                                    declare @productionallocation as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Allocation' and not PRODUCTIONALLOCATION = '')+0
                                    declare @multiply as decimal(10,2) = (select case when @productionallocation=0 then 0 else 1 end)
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
            update stocks_tb set 
                                    clbal=@clbal-@issueallocation,
                                    physical=(QTY+@totalreceipt+@return+@addadjustment)-(@totalissue+@minadjustment),
                                    allocation = @allocation-(@issueallocation+@cancelalloc),
                                    PRODUCTIONALLOCATION=(@productionallocation-(@issueallocation+@cancelalloc))*@multiply,
                                    free=(((QTY+@totalreceipt+@return+@addadjustment)-(@allocation-@cancelalloc)))-(@issue+@minadjustment),
                                    stockorder=@order-@receiptorder,
                                    issue=@totalissue
                                    where stockno=@stn"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            sqlcmd.Parameters.AddWithValue("@stockno", stockno)
            sqlcmd.CommandTimeout = 600
            sqlcmd.ExecuteNonQuery()
        Catch ex As SqlException
            If ex.Number = 1205 Then
            Else
                MsgBox(ex.ToString)
                MsgBox(stockno)
            End If
        End Try
    End Sub

    Private Sub KryptonButton20_Click(sender As Object, e As EventArgs) Handles updatedatabtn.Click
        ProgressBar2.Visible = True
        ProgressBar2.Maximum = stocksStocksno.Items.Count
        ProgressBar2.Value = 0
        sql.sqlcon.Open()
        For i As Integer = 0 To stocksStocksno.Items.Count - 1
            Dim stockno As String = stocksStocksno.Items(i).ToString
            autoupdatestock(stockno)
            ProgressBar2.Value += 1
        Next
        sql.sqlcon.Close()
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar2.Visible = False
        End If
    End Sub

    'Private Sub KryptonButton21_Click(sender As Object, e As EventArgs) Handles KryptonButton21.Click
    '    sql.goback()
    'End Sub

    'Private Sub KryptonButton22_Click(sender As Object, e As EventArgs) Handles KryptonButton22.Click
    '    sql.gonext()
    'End Sub

    Private Sub costheadsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles costheadsearch.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton1.PerformClick()
        End If
    End Sub

    Private Sub typecolorsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles typecolorsearch.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton1.PerformClick()
        End If
    End Sub

    Private Sub articlenosearch_KeyDown(sender As Object, e As KeyEventArgs) Handles articlenosearch.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton1.PerformClick()
        End If
    End Sub

    Private Sub reportheader_MouseDown(sender As Object, e As MouseEventArgs) Handles reportheader.MouseDown
        Dim i As Integer = reportheader.SelectedIndex
        If reportsupplier.Text = "" Then
            sql.getreportheader1()
        Else
            sql.getreportheader(reportsupplier.Text)
        End If
        If i > reportheader.Items.Count - 1 Then
            reportheader.SelectedIndex = -1
        Else
            reportheader.SelectedIndex = i
        End If
    End Sub

    Private Sub reportcosthead_MouseDown(sender As Object, e As MouseEventArgs) Handles reportcosthead.MouseDown
        Dim i As Integer = reportcosthead.SelectedIndex
        If reportsupplier.Text = "" And reportheader.Text = "" Then
            sql.getreportcosthead1()
        ElseIf Not reportsupplier.Text = "" And reportheader.Text = "" Then
            sql.getreportcosthead2(reportsupplier.Text)
        ElseIf reportsupplier.Text = "" And Not reportheader.Text = "" Then
            sql.getreportcosthead3(reportheader.Text)
        Else
            sql.getreportcosthead(reportsupplier.Text, reportheader.Text)
        End If
        If i > reportcosthead.Items.Count - 1 Then
            reportcosthead.SelectedIndex = -1
        Else
            reportcosthead.SelectedIndex = i
        End If
    End Sub

    Private Sub reporttypecolor_MouseDown(sender As Object, e As MouseEventArgs) Handles reporttypecolor.MouseDown
        Dim I As Integer = reporttypecolor.SelectedIndex
        If reportsupplier.Text = "" And reportheader.Text = "" And reportcosthead.Text = "" Then
            sql.getreporttypecolor1()
        ElseIf Not reportsupplier.Text = "" And reportheader.Text = "" And reportcosthead.Text = "" Then
            sql.getreporttypecolor2(reportsupplier.Text)
        ElseIf reportsupplier.Text = "" And Not reportheader.Text = "" And reportcosthead.Text = "" Then
            sql.getreporttypecolor3(reportheader.Text)
        ElseIf reportsupplier.Text = "" And reportheader.Text = "" And Not reportcosthead.Text = "" Then
            sql.getreporttypecolor4(reportcosthead.Text)
        Else
            sql.getreporttypecolor(reportsupplier.Text, reportheader.Text, reportcosthead.Text)
        End If
        If I > reporttypecolor.Items.Count - 1 Then
            reporttypecolor.SelectedIndex = -1
        Else
            reporttypecolor.SelectedIndex = I
        End If
    End Sub

    Private Sub transtransaction_KeyDown(sender As Object, e As KeyEventArgs) Handles transtransaction.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton11.PerformClick()
        End If
    End Sub

    Private Sub transreference_KeyDown(sender As Object, e As KeyEventArgs) Handles transreference.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton11.PerformClick()
        End If
    End Sub

    Private Sub transactioncosthead_KeyDown(sender As Object, e As KeyEventArgs) Handles transactioncosthead.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton11.PerformClick()
        End If
    End Sub

    Private Sub referenceDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles referenceDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            'cancelall.ShowDialog()
            referencemenustrip.Show(referenceDataGridView, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub referenceDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles referenceDataGridView.CellClick
        If referenceDataGridView.RowCount >= 0 And e.RowIndex >= 0 Then
            editreference.reference.Text = referenceDataGridView.Item(0, e.RowIndex).Value.ToString
            editreference.jo.Text = referenceDataGridView.Item(1, e.RowIndex).Value.ToString
            editaddress.address.Text = referenceDataGridView.Item(12, e.RowIndex).Value.ToString
            editreference.stockno.Text = referenceDataGridView.Item(2, e.RowIndex).Value.ToString
            editreference.costhead.Text = referenceDataGridView.Item(3, e.RowIndex).Value.ToString
            editreference.typecolor.Text = referenceDataGridView.Item(4, e.RowIndex).Value.ToString
            editreference.articleno.Text = referenceDataGridView.Item(5, e.RowIndex).Value.ToString
            editreference.allocation.Text = referenceDataGridView.Item(7, e.RowIndex).Value.ToString
            description.Text = referenceDataGridView.Item(11, e.RowIndex).Value.ToString


        End If
    End Sub

    Private Sub stocksgridview_KeyDown(sender As Object, e As KeyEventArgs) Handles stocksgridview.KeyDown
        If e.KeyData = Keys.F1 Then
            TabControl1.SelectedIndex = 1
            sql.movetoinput(stocknoinput.Text)
        End If
    End Sub

    Private Sub receiptGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles receiptGridView.CellClick
        If receiptGridView.RowCount >= 0 And e.RowIndex >= 0 Then
            Form5.transno.Text = receiptGridView.Item("transno", e.RowIndex).Value.ToString
            Form5.stockno.Text = receiptGridView.Item("stockno", e.RowIndex).Value.ToString
            Form5.reference.Text = receiptGridView.Item("reference", e.RowIndex).Value.ToString
            Form5.JO.Text = receiptGridView.Item("jo", e.RowIndex).Value.ToString
            Form5.XYZ.Text = receiptGridView.Item("xyz", e.RowIndex).Value.ToString
            description.Text = receiptGridView.Item("description", e.RowIndex).Value.ToString

            cuttinglist.transno.Text = receiptGridView.Item("transno", e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub receiptGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles receiptGridView.CellDoubleClick
        If receiptGridView.RowCount >= 0 And e.RowIndex >= 0 Then
            Form5.itcame.Text = "RECEIPT"
            sql.selecttransrec(Form5.transno.Text)
            sql.selectreference(Form5.stockno.Text, Form5.reference.Text, Form5.JO.Text)
            Form5.ShowDialog()
        End If
    End Sub

    Private Sub transqty_KeyDown(sender As Object, e As KeyEventArgs) Handles transqty.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton4.Focus()
        End If

    End Sub

    Private Sub transqty_TextChanged(sender As Object, e As EventArgs) Handles transqty.TextChanged
        transqty.Text = transqty.Text.Replace("
", "")
    End Sub

    Private Sub reffromreference_KeyDown(sender As Object, e As KeyEventArgs) Handles reffromreference.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton12.PerformClick()
        End If
    End Sub

    Private Sub referencecosthead_KeyDown(sender As Object, e As KeyEventArgs) Handles referencecosthead.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton12.PerformClick()
        End If
    End Sub

    Private Sub referencetypecolor_KeyDown(sender As Object, e As KeyEventArgs) Handles referencetypecolor.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton12.PerformClick()
        End If
    End Sub

    Private Sub referencearticleno_KeyDown(sender As Object, e As KeyEventArgs) Handles referencearticleno.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton12.PerformClick()
        End If
    End Sub

    Private Sub receiptqty_TextChanged(sender As Object, e As EventArgs) Handles receiptqty.TextChanged
        receiptqty.Text = receiptqty.Text.Replace("
", "")
    End Sub

    Private Sub receiptqty_KeyDown(sender As Object, e As KeyEventArgs) Handles receiptqty.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton5.Focus()
        End If
    End Sub

    Private Sub CuttingListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingListToolStripMenuItem.Click
        cuttinglist.ShowDialog()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub KryptonButton23_Click(sender As Object, e As EventArgs) Handles KryptonButton23.Click
        Form3.Text = "Copy"
        Form3.ShowDialog()
    End Sub

    Private Sub referenceDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles referenceDataGridView.CellDoubleClick
        editreference.ShowDialog()
    End Sub

    Private Sub issueDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles issueDataGridView.CellClick
        If issueDataGridView.RowCount >= 0 And e.RowIndex >= 0 Then
            KryptonTextBox1.Text = issueDataGridView.Item("REFERENCE", e.RowIndex).Value.ToString
            KryptonTextBox2.Text = issueDataGridView.Item("STOCKNO", e.RowIndex).Value.ToString
            KryptonTextBox3.Text = issueDataGridView.Item("JO", e.RowIndex).Value.ToString
            description.Text = issueDataGridView.Item("description", e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub CancelMultiItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelMultiItemToolStripMenuItem.Click
        cancelall.KryptonButton2.Visible = True
        cancelall.header.Text = "Form2"
        cancelall.ShowDialog()
    End Sub

    Private Sub MoveMultiItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveMultiItemToolStripMenuItem.Click
        multimove.KryptonLabel6.Text = "Move Allocation"
        multimove.ShowDialog()
    End Sub

    Private Sub MoveOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveOrderToolStripMenuItem.Click
        multimove.KryptonLabel6.Text = "Move Order"
        multimove.ShowDialog()
    End Sub

    Private Sub supplier_MouseDown(sender As Object, e As MouseEventArgs) Handles supplier.MouseDown
        Dim x As Integer = supplier.SelectedIndex
        Dim PHASEDOUT As String
        If phasedoutsearch.Checked = True Then
            PHASEDOUT = " PHASEDOUT = 'Yes'"
        Else
            PHASEDOUT = " NOT PHASEDOUT = 'Yes'"
        End If

        sql.loadsuppliersearch(PHASEDOUT)
        costheadsearch.Text = ""
        typecolorsearch.Text = ""
        articlenosearch.Text = ""
        If x > supplier.Items.Count - 1 Then
            supplier.SelectedIndex = -1
        Else
            supplier.SelectedIndex = x
        End If
    End Sub

    Private Sub supplier_KeyDown(sender As Object, e As KeyEventArgs) Handles supplier.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton1.PerformClick()
        End If
    End Sub

    Private Sub KryptonButton24_Click(sender As Object, e As EventArgs) Handles KryptonButton24.Click
        DEFAULTITEMS.Show()
    End Sub

    Private Sub LISTOFALLOCATIONGRIDVIEW_SelectionChanged(sender As Object, e As EventArgs) Handles LISTOFALLOCATIONGRIDVIEW.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = LISTOFALLOCATIONGRIDVIEW.SelectedRows
        ComboBox1.Items.Clear()
        Dim a As String
        For Each selecteditem As DataGridViewRow In selecteditems
            a = selecteditem.Cells("transno").Value.ToString
            ComboBox1.Items.Add(a)
        Next
    End Sub

    Private Sub KryptonButton25_Click(sender As Object, e As EventArgs) Handles KryptonButton25.Click
        For i As Integer = 0 To ComboBox1.Items.Count - 1
            Dim transno As String
            transno = ComboBox1.Items(i).ToString
            transnooperation(transno)
        Next
    End Sub
    Public Sub transnooperation(ByVal transno As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "select balqty from trans_tb where transno = '" & transno & "'"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            Dim balqty As String
            Dim read As SqlDataReader = sqlcmd.ExecuteReader
            While read.Read
                balqty = read(0).ToString
                If balqty = "" Then
                    balqty = 0
                End If
            End While
            read.Close()
            Dim x As Double = balqty
            Dim y As Double = loopissue.Text

            If y = 0 Then
            ElseIf x = 0 Then
            Else
                Dim result As Double
                result = x - y
                If result < 0 Then
                    'MsgBox(result)
                    result = result * -1
                    Dim upto0 As String = "update trans_tb set balqty = 0 where transno = '" & transno & "'"
                    sqlcmd = New SqlCommand(upto0, sql.sqlcon)
                    sqlcmd.ExecuteNonQuery()
                Else
                    Dim uptoreault As String = "update trans_tb set balqty = '" & result & "' where transno = '" & transno & "'"
                    sqlcmd = New SqlCommand(uptoreault, sql.sqlcon)
                    sqlcmd.ExecuteNonQuery()
                    'MsgBox(result)
                    result = 0
                End If
                loopissue.Text = result
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub issueqty_Leave(sender As Object, e As EventArgs) Handles issueqty.Leave
        loopissue.Text = issueqty.Text
    End Sub
    Private Sub KryptonButton26_Click(sender As Object, e As EventArgs) Handles physicaldatebtn.Click
        'updatep2()
        'gettoupdate(transdate.Text)
        'stocksgridview.SelectAll()

        ProgressBar2.Visible = True
        ProgressBar2.Maximum = stocksStocksno.Items.Count
        ProgressBar2.Value = 0
        Try
            sql.sqlcon.Open()
            For i As Integer = 0 To stocksStocksno.Items.Count - 1
                Dim stockno As String = stocksStocksno.Items(i).ToString
                autoupdatestock2(stockno, transdate.Text)
                ProgressBar2.Value += 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try

        If ProgressBar2.Value = ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar2.Visible = False
        End If
        KryptonButton1.PerformClick()
        'gettoupdate(transdate.Text)
    End Sub
    Public Sub updatep2()
        Try
            sql.sqlcon.Open()
            Dim str As String = "update stocks_tb set physical2=physical"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub autoupdatestock2(ByVal stockno As String, ByVal md As String)
        Try

            Dim str As String = "  declare @stn as int = @stockno
                                   declare @md as varchar(100) = @mdd
                                   declare @return as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Return'  and transdate <= @md)+0
                                    declare @addadjustment as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='+Adjustment'  and transdate <= @md)+0
                                    declare @minadjustment as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='-Adjustment'  and transdate <= @md)+0
                                    declare @receipt as decimal(10,2)=(select isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND NOT XYZ='Order'  and transdate <= @md)+0
                                    declare @issue as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND NOT XYZ ='Allocation'  and transdate <= @md)+0
                                    declare @receiptorder as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Receipt' AND XYZ='Order'  and transdate <= @md)+0
                                    declare @issueallocation as decimal(10,2)=(select  isnull(sum(isnull(qty,0)),0) from trans_tb where stockno =@stn AND TRANSTYPE='Issue' AND XYZ ='Allocation'  and transdate <= @md)+0
                                    declare @totalreceipt as decimal(10,2)=@receipt+@receiptorder
                                    declare @totalissue as decimal(10,2)=@issue+@issueallocation
            update stocks_tb set 
                                    
                                    physical2=(QTY+@totalreceipt+@return+@addadjustment)-(@totalissue+@minadjustment)
                               
                                    where stockno=@stn"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            sqlcmd.Parameters.AddWithValue("@stockno", stockno)
            sqlcmd.Parameters.AddWithValue("@mdd", md)
            sqlcmd.ExecuteNonQuery()
        Catch ex As SqlException
            If ex.Number = 1205 Then
            Else
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub gettoupdate(ByVal ldate As String)
        Try
            sql.sqlcon.Open()

            Dim a As String = reportsupplier.Text
            Dim b As String = reportheader.Text
            Dim c As String = reportcosthead.Text
            Dim d As String = reporttypecolor.Text
            Dim e As String = reportstatus.Text

            Dim acol As String = "SUPPLIER"
            Dim bcol As String = "HEADER"
            Dim ccol As String = "COSTHEAD"
            Dim dcol As String = "TYPECOLOR"
            Dim ecol As String = "STATUS"

            If a = "" Then
                a = " supplier "
            Else
                a = "'" & reportsupplier.Text & "'"
            End If
            If b = "" Then
                b = " header "
            Else
                b = "'" & reportheader.Text & "'"
            End If
            If c = "" Then
                c = " costhead "
            Else
                c = "'" & reportcosthead.Text & "'"
            End If
            If d = "" Then
                d = " typecolor "
            Else
                d = "'" & reporttypecolor.Text & "'"
            End If
            If e = "" Then
                e = " status "
            Else
                e = "'" & reportstatus.Text & "'"
            End If

            Dim ds As New DataSet
            Dim bs As New BindingSource
            Dim da As New SqlDataAdapter
            ds.Clear()
            Dim str As String = "
select * from stocks_tb where stockno in (select distinct(stockno) from trans_tb where transdate > '" & ldate & "' and not transtype='Allocation')
and " & acol & " = " & a & "
and " & bcol & " = " & b & "
and " & ccol & " = " & c & "
and " & dcol & " = " & d & "
and " & ecol & " = " & e & "
"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            stocksgridview.DataSource = bs

            stocksgridview.Columns("UFACTOR").Visible = False
            stocksgridview.Columns("MONETARY").Visible = False
            stocksgridview.Columns("UNITPRICE").Visible = False
            stocksgridview.Columns("DESCRIPTION").Visible = False
            stocksgridview.Columns("UNIT").Visible = False
            stocksgridview.Columns("LOCATION").Visible = False
            stocksgridview.Columns("HEADER").Visible = False
            stocksgridview.Columns("AVEUSAGE").Visible = False
            stocksgridview.Columns("QTY").Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub


    Public Sub gettofoil()
        Try
            sql.sqlcon.Open()
            Dim ds As New DataSet
            Dim bs As New BindingSource
            Dim da As New SqlDataAdapter
            ds.Clear()
            Dim str As String = "
select * from stocks_tb where tofoil='yes' order by articleno asc"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            stocksgridview.DataSource = bs

            stocksgridview.Columns("UFACTOR").Visible = False
            stocksgridview.Columns("MONETARY").Visible = False
            stocksgridview.Columns("UNITPRICE").Visible = False
            stocksgridview.Columns("DESCRIPTION").Visible = False
            stocksgridview.Columns("UNIT").Visible = False
            stocksgridview.Columns("LOCATION").Visible = False
            stocksgridview.Columns("HEADER").Visible = False
            stocksgridview.Columns("AVEUSAGE").Visible = False
            stocksgridview.Columns("QTY").Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton29_Click(sender As Object, e As EventArgs) Handles KryptonButton29.Click
        gettofoil()
        stocksgridview.SelectAll()

        ProgressBar2.Visible = True
        ProgressBar2.Maximum = stocksStocksno.Items.Count
        ProgressBar2.Value = 0
        For i As Integer = 0 To stocksStocksno.Items.Count - 1
            Dim stockno As String = stocksStocksno.Items(i).ToString
            gettotalbalqty(stockno, tofoilstartdate.Text, plusmonths.Text)
            ProgressBar2.Value += 1
        Next

        gettofoil()
        tofoilreport()
        Form11.ShowDialog()
    End Sub
    Public Sub tofoilreport()
        Try

            Dim str As String = "select * from stocks_tb where tofoil='yes'"
            Dim ds As New inventoryds
            ds.Clear()
            Dim da As New SqlDataAdapter
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds.STOCKS_TB)
            Form11.STOCKS_TBBindingSource.DataSource = ds.STOCKS_TB.DefaultView
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub gettotalbalqty(ByVal stockno As String, ByVal mydate As String, ByVal pmonths As String)
        Try
            sql.sqlcon.Open()
            Dim str As String = "
                                declare @sdate as date ='" & mydate & "'
                                declare @totalbalqty as decimal(10,2)=(select sum(isnull(balqty,0)) from trans_tb
                                WHERE 
                                transtype='Allocation'
                                and
                                stockno='" & stockno & "'
                                and
                                case when isdate(duedate)=1 then cast(duedate as datetime) end <= DATEADD(month, +" & pmonths & ", @sdate))

                                UPDATE stocks_tb set balalloc = @totalbalqty where stockno = '" & stockno & "'"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            sqlcmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub mymonth_Leave(sender As Object, e As EventArgs) Handles mymonth.Leave
        If IsNumeric(mymonth.Text) Then
        Else
            MessageBox.Show("not numeric", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            mymonth.Focus()
        End If
    End Sub

    Private Sub plusmonths_Leave(sender As Object, e As EventArgs) Handles plusmonths.Leave
        If IsNumeric(plusmonths.Text) Then
        Else
            MessageBox.Show("not numeric", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            plusmonths.Focus()
        End If
    End Sub

    Private Sub receiptGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles receiptGridView.KeyDown
        If e.KeyData = Keys.F1 Then
            TabControl1.SelectedIndex = 1
            transaction.Text = "Order"
            reference.Text = receiptreference.Text
            sql.movetoinput(receiptstockno.Text)
        End If
    End Sub

    Private Sub ReallocateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReallocateToolStripMenuItem.Click
        reallocate.ShowDialog()
    End Sub

    Private Sub EditAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAddressToolStripMenuItem.Click
        editaddress.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If IsNumeric(transqty.Text) And IsNumeric(unitprice.Text) And IsNumeric(xrate.Text) And IsNumeric(ufactor.Text) And IsNumeric(disc.Text) Then
            Dim qty As Double = transqty.Text
            Dim unit As Double = unitprice.Text
            Dim rate As Double = xrate.Text
            Dim ufact As Double = ufactor.Text
            Dim discount As Double = disc.Text
            Dim discounted As Double = unit - ((discount * 0.01) * unit)
            Dim amount As Double
            Dim foreign As Double

            amount = (rate * discounted) * (qty * ufact)
            foreign = amount / rate
            netamount.Text = amount
            currency.Text = foreign
        Else
            netamount.Text = 0
            currency.Text = 0
        End If
    End Sub

    Private Sub ChangeXrateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeXrateToolStripMenuItem.Click
        chagexrate.ShowDialog()
    End Sub

    Private Sub KryptonButton27_Click(sender As Object, e As EventArgs) Handles allnetamountbtn.Click
        physicaldatebtn.PerformClick()
        KryptonButton15.PerformClick()
        stocksgridview.SelectAll()
        ProgressBar2.Visible = True
        ProgressBar2.Maximum = stocksStocksno.Items.Count
        ProgressBar2.Value = 0
        For i As Integer = 0 To stocksStocksno.Items.Count - 1
            net.Text = 0
            Dim stockno As String = stocksStocksno.Items(i).ToString
            getreceipttrans(stockno)
            caculatefromstocks(stockno, balphysical.Text)
            ProgressBar2.Value += 1
        Next

        If ProgressBar2.Value = ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar2.Visible = False
        End If
        accountingreport.ShowDialog()
    End Sub
    Private Sub KryptonButton28_Click(sender As Object, e As EventArgs) Handles selectednetamount.Click


        ProgressBar2.Visible = True
        ProgressBar2.Maximum = stocksStocksno.Items.Count
        ProgressBar2.Value = 0
        For i As Integer = 0 To stocksStocksno.Items.Count - 1
            net.Text = 0
            Dim stockno As String = stocksStocksno.Items(i).ToString
            getreceipttrans(stockno)
            caculatefromstocks(stockno, balphysical.Text)
            ProgressBar2.Value += 1
        Next

        If ProgressBar2.Value = ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ProgressBar2.Visible = False
        End If

    End Sub
    Public Sub getreceipttrans(ByVal stockno As String)
        Try
            sql.sqlcon.Open()
            Dim getphysical As String = "
update stocks_tb set netamount = 0 where stockno='" & stockno & "'
select physical2 from stocks_tb where stockno='" & stockno & "'"
            sqlcmd = New SqlCommand(getphysical, sql.sqlcon)
            Dim read As SqlDataReader = sqlcmd.ExecuteReader
            While read.Read
                myphysical.Text = read(0).ToString
                balphysical.Text = read(0).ToString
            End While
            read.Close()
            Dim checkphysical As Double = myphysical.Text
            If checkphysical < 0 Then
            Else
                GETTRANS(stockno)
                For i As Integer = 0 To transnocombo.Items.Count - 1
                    Dim tno As String = transnocombo.Items(i).ToString
                    Dim qty As String = Trim(transqtycombo.Items(i).ToString.Replace(",", ""))
                    If balphysical.Text <= 0 Then
                    Else
                        calcrate(tno, qty, stockno)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Public Sub calcrate(ByVal tno As String, ByVal qty As String, ByVal stockno As String)
        Try

            Dim mybal As Double = balphysical.Text
            Dim myqty As Double = qty
            Dim result As Double = mybal - myqty

            Dim mynet As Double = net.Text
            Dim netamount As Double
            If result >= 0 Then
                Dim str As String = "select isnull(netamount,0) from trans_tb where transno='" & tno & "'"
                sqlcmd = New SqlCommand(str, sql.sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                While read.Read
                    netamount = read(0).ToString
                End While
                read.Close()
                net.Text = mynet + netamount

                Dim str1 As String = "update stocks_tb set netamount = '" & net.Text & "' where stockno = '" & stockno & "'"
                sqlcmd = New SqlCommand(str1, sql.sqlcon)
                sqlcmd.ExecuteNonQuery()
            Else
                'get unit*rate*balqty then add to net
                Dim CONPO As Double = mybal
                Dim latqty As Double
                Dim str As String = "select (UNITPRICE*XRATE)*(" & CONPO & "*ufactor) FROM TRANS_TB WHERE TRANSNO = '" & tno & "'"
                sqlcmd = New SqlCommand(str, sql.sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                While read.Read
                    latqty = read(0).ToString
                End While
                read.Close()
                net.Text = mynet + latqty

                Dim str1 As String = "update stocks_tb set netamount = '" & net.Text & "' where stockno = '" & stockno & "'"
                sqlcmd = New SqlCommand(str1, sql.sqlcon)
                sqlcmd.ExecuteNonQuery()
            End If

            balphysical.Text = result


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub caculatefromstocks(ByVal stockno As String, ByVal qty As String)
        Try
            sql.sqlcon.Open()

            Dim str As String = " 
declare @unitprice as decimal(10,2)=(select unitprice from stocks_tb where stockno='" & stockno & "')
declare @xrate as decimal(10,2)=(select xrate from stocks_tb where stockno='" & stockno & "')
declare @disc as decimal(10,2)=(select disc from stocks_tb where stockno='" & stockno & "')
declare @ufactor as decimal(10,2)=(select ufactor from stocks_tb where stockno='" & stockno & "')

declare @netamount as decimal(10,2)=((@unitprice-((@disc*0.01)*@unitprice))*@xrate)*(" & qty & "*@ufactor)

update stocks_tb set netamount=netamount+@netamount where stockno = '" & stockno & "'"
            If qty > 0 Then
                sqlcmd = New SqlCommand(str, sql.sqlcon)
                sqlcmd.ExecuteReader()
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Public Sub GETTRANS(ByVal STOCKNO As String)
        Try
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            Dim bs As New BindingSource
            ds.Clear()
            Dim str As String = "select a.TRANSNO,
a.STOCKNO,
b.COSTHEAD,
b.TYPECOLOR,
B.ARTICLENO,
B.DESCRIPTION,
a.TRANSTYPE,
a.TRANSDATE,
a.DUEDATE,
a.QTY,
a.REFERENCE,
a.jo,
a.ACCOUNT,
a.CONTROLNO,
a.xyz,
a.REMARKS,
a.UNITPRICE,
a.XRATE,
A.NETAMOUNT,
A.INPUTTED
 from trans_tb as a inner join stocks_tb as b
on a.stockno = b.stockno where A.STOCKNO='" & STOCKNO & "' and a.TRANSTYPE='Receipt' and a.transdate <= '" & transdate.Text & "' order by a.transdate ASC"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "trans_tb")
            bs.DataSource = ds
            bs.DataMember = "trans_tb"
            transgridview.DataSource = bs
            transgridview.Columns("DESCRIPTION").Visible = False
            transgridview.Columns("xyz").Visible = False

            transgridview.SelectAll()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub KryptonButton30_Click(sender As Object, e As EventArgs) Handles accountingreportgbtn.Click
        accountingreport.ShowDialog()
    End Sub


    Private Sub PHASEDoUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PHASEDoUTToolStripMenuItem.Click
        PhasedoutForm.ShowDialog()
    End Sub

    Private Sub LocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationToolStripMenuItem.Click

        locationform.KryptonButton4.Visible = True
        locationform.KryptonButton5.Visible = True
        locationform.addr.Visible = True
        locationform.minusr.Visible = True
        locationform.articleno.Text = Form3.articleno.Text
        locationform.balance.Text = "0"
        locationform.stockno = stocknoinput.Text
        locationform.reference = ""
        locationform.ShowDialog()
    End Sub



    Private Sub KryptonButton31_Click(sender As Object, e As EventArgs) Handles KryptonButton31.Click
        If Form1.accounttype.Text = "Guest" Then

        Else
            checklisted.ShowDialog()
        End If
    End Sub

    Private Sub stocksgridview_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles stocksgridview.ColumnHeaderMouseClick
        For i As Integer = 0 To stocksgridview.RowCount - 1 Step +1
            Dim s As String = Trim(stocksgridview.Rows(i).Cells("PHYSICAL").Value.ToString)
            Dim t As String = Trim(stocksgridview.Rows(i).Cells("MYLOCATION").Value.ToString)
            If s = t Then
                stocksgridview.Rows(i).Cells("MYLOCATION").Style.ForeColor = Color.Black
            Else
                stocksgridview.Rows(i).Cells("MYLOCATION").Style.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub transqty_Leave(sender As Object, e As EventArgs) Handles transqty.Leave
        If IsNumeric(transqty.Text) And IsNumeric(ufactor.Text) And ufactor.Visible = True Then
            transqty.Text = transqty.Text / ufactor.Text
        Else
            Exit Sub
        End If
    End Sub

    Private Sub KryptonButton32_Click(sender As Object, e As EventArgs) Handles accountingheaderreportbtn.Click
        Try
            sql.sqlcon.Open()
            Dim str As String = "  SELECT
a.header,sum(a.netamount) as MOVING,( select sum(netamount) from stocks_tb where PHASEDOUT LIKE '%Yes%' and header = a.header) AS PHASEDOUT
  FROM stocks_tb as a where not a.PHASEDOUT = 'Yes'
 group by header order by a.header asc
"
            Dim DS As New inventoryds
            DS.Clear()
            Dim DA As New SqlDataAdapter
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            DA.SelectCommand = sqlcmd
            DA.Fill(DS.STOCKSTB1)
            HEADERREPORTFRM.STOCKSTB1BindingSource.DataSource = DS.STOCKSTB1.DefaultView
            HEADERREPORTFRM.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub


    Public Sub genjo(ByVal page As String, ByVal reference As String, ByVal ob As Object, ByVal database As String, ByVal col As String)
        Try
            sql.sqlcon.Close()
            sql.sqlcon.Open()
            Dim ds As New DataSet
            ds.Clear()
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource

            Dim str As String
            ob.text = ""
            str = "select distinct " & col & " from " & database & " where reference = '" & reference & "'"

            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "" & database & "")
            bs.DataSource = ds
            bs.DataMember = "" & database & ""
            ob.DataSource = bs
            ob.DisplayMember = "" & col & ""
            If ob.Items.Count > 0 Then
                ob.SelectedIndex = 0
            Else
                ob.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Private Sub reffromreference_MouseDown(sender As Object, e As MouseEventArgs) Handles reffromreference.MouseDown
        genjo("reference", reffromreference.Text, reffromjo, "trans_tb", "jo")
    End Sub

    Private Sub reffromreference_TextChanged(sender As Object, e As EventArgs) Handles reffromreference.TextChanged
        'genjo("reference", reffromreference.Text, reffromjo, "trans_tb", "jo")
    End Sub

    Private Sub reffromjo_MouseDown(sender As Object, e As MouseEventArgs) Handles reffromjo.MouseDown
        genjo("reference", reffromreference.Text, reffromjo, "trans_tb", "jo")
    End Sub

    Private Sub transreference_MouseDown(sender As Object, e As MouseEventArgs) Handles transreference.MouseDown
        genjo("transmanager", transreference.Text, transjo, "trans_tb", "jo")
    End Sub

    Private Sub transreference_TextChanged(sender As Object, e As EventArgs) Handles transreference.TextChanged
        'genjo("transmanager", transreference.Text, transjo, "trans_tb", "jo")
    End Sub

    Private Sub transjo_MouseDown(sender As Object, e As MouseEventArgs) Handles transjo.MouseDown
        genjo("transmanager", transreference.Text, transjo, "trans_tb", "jo")
    End Sub

    Private Sub issuejo_MouseDown(sender As Object, e As MouseEventArgs) Handles issuejo.MouseDown
        genjo("issue", issuereference.Text, issuejo, "trans_tb", "jo")
        sql.selectissuereferencerecord(issuereference.Text, issuejo.Text)
    End Sub

    Private Sub issuejo_TextChanged(sender As Object, e As EventArgs) Handles issuejo.TextChanged
        'sql.selectissuereferencerecord(issuereference.Text, issuejo.Text)
    End Sub
    Private Sub receiptjo_MouseDown(sender As Object, e As MouseEventArgs) Handles receiptjo.MouseDown
        genjo("receipt", receiptreference.Text, receiptjo, "trans_tb", "jo")
        sql.selectreceiptreferencerecord(receiptreference.Text, receiptjo.Text)
    End Sub

    Private Sub receiptjo_TextChanged(sender As Object, e As EventArgs) Handles receiptjo.TextChanged
        sql.selectreceiptreferencerecord(receiptreference.Text, receiptjo.Text)
    End Sub

    Private Sub UpdateReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateReferenceToolStripMenuItem.Click
        'Dim selecteditems As DataGridViewSelectedRowCollection = transgridview.SelectedRows
        'Dim reflist As ArrayList = New ArrayList(selecteditems.Count)
        'Dim stlist As ArrayList = New ArrayList(selecteditems.Count)
        'Dim jolist As ArrayList = New ArrayList(selecteditems.Count)

        'For Each selecteditem As DataGridViewRow In selecteditems
        '    reflist.Add(selecteditem.Cells("reference").Value.ToString)
        '    stlist.Add(selecteditem.Cells("stockno").Value.ToString)
        '    jolist.Add(selecteditem.Cells("jo").Value.ToString)
        'Next
        'ProgressBar2.Visible = True
        'ProgressBar2.Maximum = reflist.Count
        'ProgressBar2.Value = 0
        'For i As Integer = 0 To reflist.Count - 1
        '    Dim reference As String = reflist(i).ToString
        '    Dim stockno As String = stlist(i).ToString
        '    Dim jo As String = jolist(i).ToString
        '    updatereferencerecord(reference, jo, stockno)
        '    updatestock(stockno, reference, jo)
        '    ProgressBar2.Value += 1
        'Next
        'If ProgressBar2.Value = ProgressBar2.Maximum Then
        '    MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    ProgressBar2.Visible = False
        'End If
        updatereferenceFRM.ShowDialog()
    End Sub
    Public Sub updatereferencerecord(ByVal reference As String, ByVal jo As String, ByVal stockno As String)
        Try
            sql.sqlcon.Open()
            Dim find As String = "select * from reference_tb where reference='" & reference & "' and jo = '" & jo & "' and stockno='" & stockno & "'"
            sqlcmd = New SqlCommand(find, sql.sqlcon)
            Dim read As SqlDataReader = sqlcmd.ExecuteReader
            If read.HasRows = True Then
                read.Close()
            Else
                read.Close()

                Dim address As String
                Try
                    sql.sqlcon1.Open()
                    Dim getadd As String = "select fulladd from addendum_to_contract_tb where project_label = '" & reference & "' and parentjono ='" & jo & "'"
                    sqlcmd = New SqlCommand(getadd, sql.sqlcon1)
                    Dim sd As SqlDataReader = sqlcmd.ExecuteReader
                    While sd.Read
                        address = sd(0).ToString
                    End While
                    sd.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sql.sqlcon1.Close()
                End Try

                Dim insert As String = "
declare @id as integer = (select max(id)+1 from reference_tb)
insert into reference_tb (id,reference,jo,address,stockno) values(@id,'" & reference & "','" & jo & "','" & address & "','" & stockno & "')"
                sqlcmd = New SqlCommand(insert, sql.sqlcon)
                sqlcmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub
    Private Sub UpdateReferenceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateReferenceToolStripMenuItem1.Click
        ProgressBar2.Visible = True
        ProgressBar2.Maximum = refcombo.Items.Count
        ProgressBar2.Value = 0
        For i As Integer = 0 To refcombo.Items.Count - 1
            Dim reference As String = refcombo.Items(i).ToString
            Dim stockno As String = refstock.Items(i).ToString
            Dim jo As String = refjo.Items(i).ToString
            updatereferencerecord(reference, jo, stockno)
            updatestock(stockno, reference, jo)
            ProgressBar2.Value += 1
        Next
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar2.Visible = False
        End If
    End Sub

    Private Sub KryptonSplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles KryptonSplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        genreferenceFRM.Text = "Input"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        genreferenceFRM.Text = "Receipt"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KryptonButton7.PerformClick()
        genreferenceFRM.Text = "Issue"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql.rf()

        genreferenceFRM.Text = "transman"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        genreferenceFRM.Text = "reference"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub reference_MouseDown(sender As Object, e As MouseEventArgs) Handles reference.MouseDown
        lref()
        genjo("input", reference.Text, jo, "trans_tb", "jo")
    End Sub

    Private Sub reference_TextChanged(sender As Object, e As EventArgs) Handles reference.TextChanged
        'genjo("input", reference.Text, jo, "trans_tb", "jo")
    End Sub
    Public Sub lref()
        Try
            sql.sqlcon.Close()
            sql.sqlcon.Open()
            Dim str As String = "select distinct reference from trans_tb"
            Dim ds As New DataSet
            ds.Clear()
            Dim bs As New BindingSource
            Dim da As New SqlDataAdapter
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "trans_tb")
            bs.DataSource = ds
            bs.DataMember = "trans_tb"
            reference.DataSource = bs
            reference.DisplayMember = "reference"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub ChangeJOAndReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeJOAndReferenceToolStripMenuItem.Click

        changereferenceFRM.ShowDialog()
    End Sub
    Private Sub transtransaction_TextChanged(sender As Object, e As EventArgs) Handles transtransaction.TextChanged
        'If transtransaction.Text = "Order" Or transtransaction.Text = "Receipt" Then
        '    transreference.Enabled = True
        'Else
        '    transreference.Enabled = False
        'End If
    End Sub

    Private Sub KryptonGroup10_Panel_Paint(sender As Object, e As PaintEventArgs) Handles KryptonGroup10.Panel.Paint

    End Sub

    Private Sub KryptonButton33_Click(sender As Object, e As EventArgs) Handles KryptonButton33.Click
        sql.getfoilcolor("")
        Form14.title = "For Foiling"
        Form14.ShowDialog()
    End Sub

    Private Sub transdescription_TextChanged(sender As Object, e As EventArgs) Handles transdescription.TextChanged

    End Sub

    Private Sub ConsumptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumptionToolStripMenuItem.Click
        Dim STOCKNO As String = ""
        For I As Integer = 0 To stocksStocksno.Items.Count - 1
            STOCKNO = stocksStocksno.Items(I).ToString
            sql.calculateanualconsumption(STOCKNO, CDate(transdate.Text).Year.ToString)
        Next
        KryptonButton1.PerformClick()
    End Sub

    Private Sub KryptonGroup9_Panel_Paint(sender As Object, e As PaintEventArgs) Handles KryptonGroup9.Panel.Paint

    End Sub

    Private Sub receiptreference_KeyDown(sender As Object, e As KeyEventArgs) Handles receiptreference.KeyDown
        If e.KeyData = Keys.Enter Then
            genjo("receipt", receiptreference.Text, receiptjo, "trans_tb", "jo")
            sql.selectreceiptreferencerecord(receiptreference.Text, receiptjo.Text)
        End If
    End Sub

    Private Sub issuereference_KeyDown(sender As Object, e As KeyEventArgs) Handles issuereference.KeyDown, issuejo.KeyDown
        If e.KeyData = Keys.Enter Then
            Select Case sender.name
                Case "issuereference"
                    genjo("issue", issuereference.Text, issuejo, "trans_tb", "jo")
                    sql.selectissuereferencerecord(issuereference.Text, issuejo.Text)
                Case "issuejo"
                    sql.selectissuereferencerecord(issuereference.Text, issuejo.Text)
            End Select
        End If
    End Sub

    Private Sub header_MouseDown(sender As Object, e As MouseEventArgs) Handles headercmb.MouseDown
        Dim phasedout As String
        If phasedoutsearch.Checked = True Then
            phasedout = " and phasedout = 'Yes'"
        Else
            phasedout = " and not phasedout = 'Yes'"
        End If
        Dim x As Integer = headercmb.SelectedIndex
        Dim ssupplier As String = supplier.Text
        If ssupplier = "" Then
            ssupplier = " supplier"
        Else
            ssupplier = "'" & ssupplier & "'"
        End If
        sql.loadheadersearch(ssupplier, phasedout)
        costheadsearch.Text = ""
        typecolorsearch.Text = ""
        articlenosearch.Text = ""
        If x > headercmb.Items.Count - 1 Then
            headercmb.SelectedIndex = -1
        Else
            headercmb.SelectedIndex = x
        End If
    End Sub

    Private Sub ProductionAllocationDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionAllocationDateToolStripMenuItem.Click
        Form6.KryptonLabel1.Text = "Production Allocation date"
        Form6.ShowDialog()
    End Sub

    Private Sub transactiontypecolor_KeyDown(sender As Object, e As KeyEventArgs) Handles transactiontypecolor.KeyDown
        If e.KeyData = Keys.Enter Then
            KryptonButton11.PerformClick()
        End If
    End Sub

    Private Sub UpdateStocknoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStocknoToolStripMenuItem.Click
        UpdateStockNo.ShowDialog()
    End Sub

    Private Sub CopyTransToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTransToolStripMenuItem.Click
        CopyTransaction.ShowDialog()
    End Sub

    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        ChangeColor.transnolist = transnoAlist
        ChangeColor.stocknolist = stocknoAlist
        ChangeColor.referencelist = referenceAlist
        ChangeColor.jolist = joAlist
        ChangeColor.Show()
    End Sub

    Private Sub ClearJOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearJOToolStripMenuItem.Click
        If Form1.nickname.Text = "Noreen" Or Form1.nickname.Text = "Daniel" Or Form1.accounttype.Text = "Admin" Then
            If MessageBox.Show("Clear JO?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            ClearJO()
        Else
            MessageBox.Show("Invalid Access!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub ClearJO()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                For i As Integer = 0 To transnocombo.Items.Count - 1
                    Using sqlcmd As SqlCommand = New SqlCommand("update trans_tb set jo ='' where transno = " + transnocombo.Items(i) + "", sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    End Using
                Next

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            KryptonButton11.PerformClick()
        End Try

    End Sub

    Private Sub KryptonButton16_Click_1(sender As Object, e As EventArgs) Handles KryptonButton16.Click
        FoilingAllocation.Show()
    End Sub

    Private Sub reporttboxreference_MouseDown(sender As Object, e As MouseEventArgs)
        genjo("report", reporttboxreference.Text, reporttboxjo, "trans_tb", "jo")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        genreferenceFRM.Text = "report"
        genreferenceFRM.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ds = New inventoryds
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using cmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                With cmd
                    .CommandText = "to_foil_per_project_stp"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@reference", reporttboxreference.Text)
                    .Parameters.AddWithValue("@jo", reporttboxjo.Text)
                End With
                Dim da As SqlDataAdapter = New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(ds.Allocation_Per_Foil_Tbl)
                ToFoilPerProjectFrm.FoilPerProjectBindingSource.DataSource = ds.Allocation_Per_Foil_Tbl.DefaultView
            End Using

        End Using
        Dim param1 As New ReportParameter("Project", reporttboxreference.Text)
        Dim param2 As New ReportParameter("jo", reporttboxjo.Text)
        ToFoilPerProjectFrm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
        ToFoilPerProjectFrm.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param2})
        ToFoilPerProjectFrm.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ToFoilPerProjectFrm.ReportViewer1.ZoomMode = ZoomMode.PageWidth
        ToFoilPerProjectFrm.ShowDialog()

    End Sub
    Dim _dateselector As String
    Private Sub selectDate()
        Dim monthconverter As String
        Dim monthindex As Integer = cboxMonthPicker.SelectedIndex + 1
        monthconverter = monthindex.ToString()
        _dateselector = cboxYearPicker.Text + "-" + monthconverter + "-01"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        selectDate()
        sendRequest()
    End Sub
    Private Sub sendRequest()
        Try
            Dim ds As New inventoryds
            ds.Clear()
            ds = New inventoryds
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Using cmd As SqlCommand = sqlcon.CreateCommand()
                    cmd.CommandText = "foiling_yearly_consumption"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@month1", _dateselector)
                    cmd.Parameters.AddWithValue("@articleno", cboxArticlenoPicker.Text)
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = cmd
                    da.Fill(ds.monthly_consumption)
                    Foil_Yearly_ConsumptionReport.monthly_consumptionBindingSource.DataSource = ds.monthly_consumption.DefaultView
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Dim param As ReportParameter = New ReportParameter("mm", _dateselector)
            Foil_Yearly_ConsumptionReport.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param})
            Foil_Yearly_ConsumptionReport.Show()
        End Try
    End Sub

    Private Sub KryptonButton17_Click_1(sender As Object, e As EventArgs) Handles KryptonButton17.Click
        CreateStocks_Frm.Show()
    End Sub

    Private Sub KryptonButton20_Click_1(sender As Object, e As EventArgs) Handles KryptonButton20.Click
        sql.getfoilcolor("PVC")
        Form14.title = "PVC Foil"
        Form14.ShowDialog()
    End Sub

    Private Sub KryptonButton26_Click_1(sender As Object, e As EventArgs) Handles KryptonButton26.Click
        If cboxMonth2.Text = "" Then
            MsgBox("please select the end month in range")
        Else
            FOILvsPVCreport.ShowDialog()
        End If
    End Sub

    Private Sub loadYear()
        Try
            Using sqlconn As SqlConnection = New SqlConnection(sql.sqlconstr)
                Using sqlcmd As SqlCommand = sqlconn.CreateCommand()
                    sqlcmd.CommandText = "Year_List_Stp"
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        Dim ds As New DataSet
                        ds.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "year_tbl")
                        cboxYear.DataSource = ds.Tables(0)
                        cboxYear.DisplayMember = "Year"
                        cboxYear.ValueMember = "Year"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub cboxMonth2_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxMonth2.MouseDown
        cboxMonth2.Items.Clear()
        For i As Integer = cboxMonth1.SelectedIndex To 11 Step +1
            cboxMonth2.Items.Add(cboxMonth1.Items(i))
        Next
    End Sub

    Private Sub cboxMonth1_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxMonth1.MouseDown
        cboxMonth2.SelectedIndex = -1
    End Sub

    Private Sub KryptonButton27_Click_1(sender As Object, e As EventArgs) Handles btnCLMonitoring.Click
        CuttingListRecord._stockno = stocknoinput.Text
        CuttingListRecord.ShowDialog()
    End Sub

    Private Sub KryptonButton28_Click_1(sender As Object, e As EventArgs) Handles btnAddCLM.Click
        AddItemsToMonitor._stockno = stocknoinput.Text
        AddItemsToMonitor.ShowDialog()
    End Sub

    Private Sub AccountabilityMonitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountabilityMonitorToolStripMenuItem.Click
        AccountabilityUpdate.ShowDialog()
    End Sub

    Private Sub cboxLocationInput_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxLocationInput.MouseDown
        Dim I As Integer = cboxLocationInput.SelectedIndex
        loadlocationcombo(cboxLocationInput, transstockno.Text)
        If I > cboxLocationInput.Items.Count - 1 Then
            cboxLocationInput.SelectedIndex = -1
        Else
            cboxLocationInput.SelectedIndex = I
        End If
    End Sub

    Private Sub cboxLocationIssue_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxLocationIssue.MouseDown
        Dim I As Integer = cboxLocationIssue.SelectedIndex
        loadlocationcombo(cboxLocationIssue, issuestockno.Text)
        If I > cboxLocationIssue.Items.Count - 1 Then
            cboxLocationIssue.SelectedIndex = -1
        Else
            cboxLocationIssue.SelectedIndex = I
        End If
    End Sub
    Public Sub loadlocationcombo(ByVal obj As Object, ByVal stockno As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            sqlcon.Open()
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "WarehouseReport_Stp"
                sqlcmd.Parameters.AddWithValue("@Command", "Distinct_Location")
                sqlcmd.Parameters.AddWithValue("@Stockno", stockno)
                Dim ds As New DataSet
                ds.Clear()
                Dim bs As New BindingSource
                Using sqlda As SqlDataAdapter = New SqlDataAdapter
                    sqlda.SelectCommand = sqlcmd
                    sqlda.Fill(ds, "LOCATIONTB")
                    bs.DataSource = ds
                    bs.DataMember = "LOCATIONTB"
                End Using
                obj.DataSource = bs
                obj.ValueMember = "Location"
                obj.DisplayMember = "Location"
            End Using
        End Using
    End Sub

    Private Sub UpdateLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLocationToolStripMenuItem.Click
        UpdateLocation.ShowDialog()
    End Sub
End Class