﻿Imports System.Data.SqlClient
Public Class chagexrate
    Public sqlcmd As New SqlCommand
    Public da As New SqlDataAdapter
    Dim sql As New sql
    Private Sub xrate_Leave(sender As Object, e As EventArgs) Handles xrate.Leave
        If IsNumeric(xrate.Text) Then
        Else
            MessageBox.Show("invalid x-rate", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            xrate.Focus()
        End If
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click

        If MessageBox.Show("Update record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        For i As Integer = 0 To transno.Items.Count - 1
            Dim tno As String = transno.Items(i).ToString
            If KryptonCheckBox8.Checked = True Then
                changerate(tno, xrate.Text)
            End If
            If KryptonCheckBox1.Checked = True Then
                changeunit(tno, unit.Text)
            End If
            If KryptonCheckBox2.Checked = True Then
                changeufactor(tno, ufactor.Text)
            End If
            If KryptonCheckBox3.Checked = True Then
                changedisc(tno, discount.Text)
            End If
        Next
        MessageBox.Show(" update!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form2.KryptonButton11.PerformClick()
        Me.Close()

    End Sub
    Public Sub changerate(ByVal tno As String, ByVal rate As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()
                Dim transtype As String = ""
                Dim xyz As String
                Dim xyzref As String
                Dim str As String = "select transtype,xyz,xyzref from trans_tb where transno = '" & tno & "'"
                sqlcmd = New SqlCommand(str, sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                While read.Read
                    transtype = read(0).ToString
                    xyz = read(1).ToString
                    xyzref = read(2).ToString
                End While
                read.Close()
                If (transtype = "Order" Or transtype = "Receipt") And xyz = "" And xyzref = "" Then
                    Try
                        Dim updateorder As String = "update trans_tb set netamount=((unitprice-((disc*0.01)*unitprice))*" & rate & ")*(qty*ufactor),xrate=" & rate & " where transno = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Order" And xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "
update trans_tb set netamount=((unitprice-((disc*0.01)*unitprice))*" & rate & ")*(qty*ufactor),xrate=" & rate & " where transno = '" & tno & "'
update trans_tb set netamount=((unitprice-((disc*0.01)*unitprice))*" & rate & ")*(qty*ufactor),xrate=" & rate & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Receipt" And Not xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "
update trans_tb set netamount=((unitprice-((disc*0.01)*unitprice))*" & rate & ")*(qty*ufactor),xrate=" & rate & " where transno = '" & tno & "'
update trans_tb set netamount=((unitprice-((disc*0.01)*unitprice))*" & rate & ")*(qty*ufactor),xrate=" & rate & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else

                End If
                If KryptonCheckBox7.Checked = True Then
                    Try
                        Dim updatestock As String = "declare @stockno as varchar(100) = (select stockno from trans_tb where transno = '" & tno & "')
                                   update [stocks_tb] set [XRATE] = '" & rate & "' where stockno = @stockno"
                        sqlcmd = New SqlCommand(updatestock, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub changeunit(ByVal tno As String, ByVal unit As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()

                Dim transtype As String
                Dim xyz As String
                Dim xyzref As String
                Dim disc As String
                Dim str As String = "select transtype,xyz,xyzref from trans_tb where transno = '" & tno & "'"
                sqlcmd = New SqlCommand(str, sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                While read.Read
                    transtype = read(0).ToString
                    xyz = read(1).ToString
                    xyzref = read(2).ToString

                End While
                read.Close()



                If (transtype = "Order" Or transtype = "Receipt") And xyz = "" And xyzref = "" Then
                    Try
                        Dim updateorder As String = "

update trans_tb set netamount=(xrate*(" & unit & "-((disc*0.01)*" & unit & ")))*(qty*ufactor),unitprice=" & unit & " where transno = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Order" And xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "

update trans_tb set netamount=(xrate*(" & unit & "-((disc*0.01)*" & unit & ")))*(qty*ufactor),unitprice=" & unit & " where transno = '" & tno & "'
update trans_tb set netamount=(xrate*(" & unit & "-((disc*0.01)*" & unit & ")))*(qty*ufactor),unitprice=" & unit & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Receipt" And Not xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "

update trans_tb set netamount=(xrate*(" & unit & "-((disc*0.01)*" & unit & ")))*(qty*ufactor),unitprice=" & unit & " where transno = '" & tno & "'
update trans_tb set netamount=(xrate*(" & unit & "-((disc*0.01)*" & unit & ")))*(qty*ufactor),unitprice=" & unit & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else

                End If
                If KryptonCheckBox5.Checked = True Then
                    Try
                        Dim updatestock As String = "declare @stockno as varchar(100) = (select stockno from trans_tb where transno = '" & tno & "')
                                   update [stocks_tb] set [UNITPRICE] = '" & unit & "' where stockno = @stockno"
                        sqlcmd = New SqlCommand(updatestock, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub changeufactor(ByVal tno As String, ByVal ufactor As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()


                Dim transtype As String
                Dim xyz As String
                Dim xyzref As String
                Dim str As String = "select transtype,xyz,xyzref from trans_tb where transno = '" & tno & "'"
                sqlcmd = New SqlCommand(str, sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                While read.Read
                    transtype = read(0).ToString
                    xyz = read(1).ToString
                    xyzref = read(2).ToString
                End While
                read.Close()
                If (transtype = "Order" Or transtype = "Receipt") And xyz = "" And xyzref = "" Then
                    Try
                        Dim updateorder As String = "update trans_tb set netamount=(xrate*(unitprice-((disc*0.01)*unitprice))*(qty*" & ufactor & ")),ufactor=" & ufactor & " where transno = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Order" And xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "
update trans_tb set netamount=(xrate*(unitprice-((disc*0.01)*unitprice))*(qty*" & ufactor & ")),ufactor=" & ufactor & " where transno = '" & tno & "'
update trans_tb set netamount=(xrate*(unitprice-((disc*0.01)*unitprice))*(qty*" & ufactor & ")),ufactor=" & ufactor & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Receipt" And Not xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "
update trans_tb set netamount=(xrate*(unitprice-((disc*0.01)*unitprice))*(qty*" & ufactor & ")),ufactor=" & ufactor & " where transno = '" & tno & "'
update trans_tb set netamount=(xrate*(unitprice-((disc*0.01)*unitprice))*(qty*" & ufactor & ")),ufactor=" & ufactor & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else

                End If
                If KryptonCheckBox4.Checked = True Then
                    Try
                        Dim updatestock As String = "declare @stockno as varchar(100) = (select stockno from trans_tb where transno = '" & tno & "')
                                   update [stocks_tb] set [UFACTOR] = '" & ufactor & "' where stockno = @stockno"
                        sqlcmd = New SqlCommand(updatestock, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub changedisc(ByVal tno As String, ByVal disc As String)
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
                sqlcon.Open()


                Dim transtype As String
                Dim xyz As String
                Dim xyzref As String
                Dim str As String = "select transtype,xyz,xyzref from trans_tb where transno = '" & tno & "'"
                sqlcmd = New SqlCommand(str, sqlcon)
                Dim read As SqlDataReader = sqlcmd.ExecuteReader
                While read.Read
                    transtype = read(0).ToString
                    xyz = read(1).ToString
                    xyzref = read(2).ToString
                End While
                read.Close()
                If (transtype = "Order" Or transtype = "Receipt") And xyz = "" And xyzref = "" Then
                    Try
                        Dim updateorder As String = "update trans_tb set netamount=(xrate*(unitprice-((" & disc & "*0.01)*unitprice))*(qty*ufactor)),disc=" & disc & " where transno = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Order" And xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "
update trans_tb set netamount=(xrate*(unitprice-((" & disc & "*0.01)*unitprice))*(qty*ufactor)),disc=" & disc & " where transno = '" & tno & "'
update trans_tb set netamount=(xrate*(unitprice-((" & disc & "*0.01)*unitprice))*(qty*ufactor)),disc=" & disc & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                ElseIf transtype = "Receipt" And Not xyz = "" And Not xyzref = "" Then
                    Try
                        Dim updateorder As String = "
update trans_tb set netamount=(xrate*(unitprice-((" & disc & "*0.01)*unitprice))*(qty*ufactor)),disc=" & disc & " where transno = '" & tno & "'
update trans_tb set netamount=(xrate*(unitprice-((" & disc & "*0.01)*unitprice))*(qty*ufactor)),disc=" & disc & " where xyzref = '" & tno & "'"
                        sqlcmd = New SqlCommand(updateorder, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else

                End If
                If KryptonCheckBox6.Checked = True Then
                    Try
                        Dim updatestock As String = "declare @stockno as varchar(100) = (select stockno from trans_tb where transno = '" & tno & "')
                                   update [stocks_tb] set [DISC] = '" & disc & "' where stockno = @stockno"
                        sqlcmd = New SqlCommand(updatestock, sqlcon)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub chagexrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.accounttype.Text = "Guest" Then
            KryptonButton1.Enabled = False
        ElseIf Form1.accounttype.Text = "Admin" Or Form1.accounttype.Text = "Encoder" Then
            KryptonButton1.Enabled = True
        End If

    End Sub

    Private Sub unit_Leave(sender As Object, e As EventArgs) Handles unit.Leave
        If IsNumeric(unit.Text) Then
        Else
            MessageBox.Show("invalid unit price", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            unit.Focus()
        End If
    End Sub

    Private Sub chagexrate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KryptonCheckBox8.Checked = False
        KryptonCheckBox1.Checked = False
        KryptonCheckBox2.Checked = False
        KryptonCheckBox3.Checked = False
    End Sub

    Private Sub ufactor_Leave(sender As Object, e As EventArgs) Handles ufactor.Leave
        If IsNumeric(ufactor.Text) Then
        Else
            MessageBox.Show("invalid ufactor", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ufactor.Focus()
        End If
    End Sub

    Private Sub discount_Leave(sender As Object, e As EventArgs) Handles discount.Leave
        If IsNumeric(discount.Text) Then
        Else
            MessageBox.Show("invalid discount", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            discount.Focus()
        End If
    End Sub

    Private Sub KryptonCheckBox1_Click(sender As Object, e As EventArgs) Handles KryptonCheckBox1.Click
        If IsNumeric(Form2.tqty) And IsNumeric(ufactor.Text) And IsNumeric(tboxTotalAmount.Text) Then
            Dim quantity As Decimal = Form2.tqty
            Dim unitfactor As Decimal = ufactor.Text
            Dim totalamount As Decimal = tboxTotalAmount.Text
            If quantity > 0 And unitfactor > 0 And totalamount > 0 Then
                unit.Text = (totalamount / quantity) / unitfactor
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KryptonCheckBox8.Checked = False
        KryptonCheckBox1.Checked = False
        KryptonCheckBox2.Checked = False
        KryptonCheckBox3.Checked = False
        Me.Close()
    End Sub
End Class