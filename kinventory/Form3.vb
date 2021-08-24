Imports System.Data.SqlClient

Public Class Form3
    Dim sql As New sql
    Dim drag As Boolean
    Dim xm As Integer
    Dim ym As Integer

    Public Sub btn2()
        If Me.Text = "New" Or Me.Text = "Copy" Then
            remove()
            sql.Newstock(supplier.Text,
                        costhead.Text,
                        ufactor.Text,
                        typecolor.Text,
                        monetary.Text,
                        articleno.Text,
                        unitprice.Text,
                        description.Text,
                        qty.Text,
                        unit.Text,
                        location.Text,
                        header.Text,
                        colorbased.Text,
                        xrate.Text,
                         foilwitha.Text,
                         foilwithb.Text,
                         foilcolor.Text,
                         tofoil.Text,
                         toorder.Text,
                         tboxSourceStockno.Text,
                         tboxspecifiedcolor.Text,
                         CheckBox1.Checked.ToString())
            'sql.loadstocks()
            Form2.KryptonButton1.PerformClick()
            Button1.PerformClick()
        ElseIf Me.Text = "Edit" Then
            remove()
            sql.updatestocks(stockno.Text,
ufactor.Text,
monetary.Text,
unitprice.Text,
description.Text,
unit.Text,
location.Text,
min.Text, colorbased.Text, xrate.Text,
                         foilwitha.Text,
                         foilwithb.Text,
                         foilcolor.Text,
                         tofoil.Text,
                         toorder.Text)
            sql.loadstocks(Form2.stocktoprows.Text)
            Form2.KryptonButton1.PerformClick()
            Button1.PerformClick()
        End If
    End Sub
    Public Sub remove()
        supplier.Text = supplier.Text.Replace("'", "")
        supplier.Text = supplier.Text.Replace("""", "")
        costhead.Text = costhead.Text.Replace("'", "")
        costhead.Text = costhead.Text.Replace("""", "")
        ufactor.Text = ufactor.Text.Replace("'", "")
        ufactor.Text = ufactor.Text.Replace("""", "")
        typecolor.Text = typecolor.Text.Replace("'", "")
        typecolor.Text = typecolor.Text.Replace("""", "")
        monetary.Text = monetary.Text.Replace("'", "")
        monetary.Text = monetary.Text.Replace("""", "")
        articleno.Text = articleno.Text.Replace("'", "")
        articleno.Text = articleno.Text.Replace("""", "")
        unitprice.Text = unitprice.Text.Replace("'", "")
        unitprice.Text = unitprice.Text.Replace("""", "")
        description.Text = description.Text.Replace("'", "")
        description.Text = description.Text.Replace("""", "")
        qty.Text = qty.Text.Replace("'", "")
        qty.Text = qty.Text.Replace("""", "")
        unit.Text = unit.Text.Replace("'", "")
        unit.Text = unit.Text.Replace("""", "")
        location.Text = location.Text.Replace("'", "")
        location.Text = location.Text.Replace("""", "")
        header.Text = header.Text.Replace("'", "")
        header.Text = header.Text.Replace("""", "")
        colorbased.Text = colorbased.Text.Replace("'", "")
        colorbased.Text = colorbased.Text.Replace("""", "")
        supplier.Text = Trim(supplier.Text)
        costhead.Text = Trim(costhead.Text)
        ufactor.Text = Trim(ufactor.Text)
        typecolor.Text = Trim(typecolor.Text)
        monetary.Text = Trim(monetary.Text)
        articleno.Text = Trim(articleno.Text)
        unitprice.Text = Trim(unitprice.Text)
        description.Text = Trim(description.Text)
        qty.Text = Trim(qty.Text)
        unit.Text = Trim(unit.Text)
        location.Text = Trim(location.Text)
        header.Text = Trim(header.Text)
        colorbased.Text = Trim(colorbased.Text)
    End Sub

    Private Sub unitprice_Leave(sender As Object, e As EventArgs) Handles unitprice.Leave
        Dim name As String = "Unit price"
        validnumber(unitprice, name)
    End Sub

    Private Sub totalreceipt_Leave(sender As Object, e As EventArgs) Handles qty.Leave
        Dim name As String = "Qty"
        validnumber(qty, name)
    End Sub
    Public Sub validnumber(ByVal x As Object, ByVal name As String)
        If IsNumeric(x.text) Then
        Else
            MessageBox.Show("" & name & " must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            x.Focus()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.accounttype.Text = "Guest" Then
            KryptonButton2.Enabled = False
        ElseIf Form1.accounttype.Text = "Admin" Or Form1.accounttype.Text = "Encoder" Then
            KryptonButton2.Enabled = True
        End If
        If Me.Text = "New" Then
            stockno.Text = ""
            supplier.SelectedIndex = -1
            costhead.SelectedIndex = -1
            colorbased.SelectedIndex = -1
            ufactor.Text = 0
            typecolor.SelectedIndex = -1
            monetary.Text = ""
            articleno.SelectedIndex = -1
            unitprice.Text = 0
            xrate.Text = 0
            description.Text = ""
            qty.Text = 0
            unit.Text = ""
            location.Text = ""
            header.SelectedIndex = -1
            supplier.Enabled = True
            costhead.Enabled = True
            typecolor.Enabled = True
            articleno.Enabled = True
            qty.Enabled = True
            header.Enabled = True
            min.Visible = False
            KryptonLabel14.Visible = False
        ElseIf Me.Text = "Edit" Then
            supplier.Enabled = False
            costhead.Enabled = False
            typecolor.Enabled = False
            articleno.Enabled = False
            qty.Enabled = False
            header.Enabled = False
            min.Visible = True
            KryptonLabel14.Visible = True
        ElseIf Me.Text = "Copy" Then
            qty.Text = 0
            supplier.Enabled = True
            costhead.Enabled = True
            typecolor.Enabled = True
            articleno.Enabled = True
            qty.Enabled = True
            header.Enabled = True
            min.Visible = False
            KryptonLabel14.Visible = False
        End If

        loadColorSuggestion()
    End Sub
    Dim _colorAssignedds As New DataSet
    Dim da As New SqlDataAdapter
    Private Sub loadColorSuggestion()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "ColorManagerTool_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", "ColorSuggestion")

                _colorAssignedds = New DataSet
                _colorAssignedds.Clear()
                initializeDataset(sqlcmd, _colorAssignedds, "ColorMngr_Tb")
                initializeDatasource(tboxspecifiedcolor, _colorAssignedds, "ColorMngr_Tb", "Color")
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

    Private Sub min_Leave(sender As Object, e As EventArgs) Handles min.Leave
        Dim name As String = "Minimum qty"
        validnumber(min, name)
    End Sub

    Private Sub ufactor_Leave(sender As Object, e As EventArgs) Handles ufactor.Leave
        Dim name As String = "U-Factor qty"
        validnumber(ufactor, name)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub KryptonPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles KryptonPanel1.MouseDown
        drag = True
        xm = Cursor.Position.X - Me.Left
        ym = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub KryptonPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles KryptonPanel1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - xm
            Me.Top = Cursor.Position.Y - ym
        End If
    End Sub

    Private Sub KryptonPanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles KryptonPanel1.MouseUp
        drag = False
    End Sub

    Private Sub Form3_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        KryptonLabel16.Text = Me.Text
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Me.Close()
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        btn2()

    End Sub

    Private Sub xrate_Leave(sender As Object, e As EventArgs) Handles xrate.Leave
        Dim name As String = "X-Rate"
        validnumber(xrate, name)
    End Sub

    Private Sub foilwitha_MouseDown(sender As Object, e As MouseEventArgs) Handles foilwitha.MouseDown, foilcolor.MouseDown, foilwithb.MouseDown
        loadfoiling(sender)
    End Sub
    Public Sub loadfoiling(ByVal sender As Object)
        Try
            Dim SQLCMD As New SqlCommand
            sql.sqlcon.Open()
            Dim col As String
            Select Case sender.name
                Case "foilwitha"
                    col = "FOILWITHA"
                Case "foilcolor"
                    col = "FOILCOLOR"
                Case "foilwithb"
                    col = "FOILWITHB"
            End Select

            Dim ds As New DataSet
            ds.Clear()
            Dim bs As New BindingSource
            Dim da As New SqlDataAdapter
            Dim str As String = "select distinct " & col & " from stocks_tb"
            sqlcmd = New SqlCommand(str, sql.sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "stocks_tb")
            bs.DataSource = ds
            bs.DataMember = "stocks_tb"
            sender.datasource = bs
            sender.displaymember = "" & col & ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sql.sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        stocksReference.ShowDialog()
    End Sub
End Class