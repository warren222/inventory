Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class updatereferenceFRM
    Dim sql As New sql
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Dim bgw As New BackgroundWorker
    Dim action As String

    Private Sub updatereferenceFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschange
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gv.DataSource = bs
        starter("load record")
    End Sub

    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)

    End Sub

    Private Sub bgw_progresschange(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "load record"
                bs.DataSource = ds
                bs.DataMember = "trans_tb"
        End Select
    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "load record"
                searchtransaction()
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            bgw.RunWorkerAsync()
        Else

        End If
    End Sub
    Dim transaction As String = Form2.transtransaction.Text
    Dim transdate As String = Form2.transadate.Text
    Dim todate As String = Form2.todate.Text
    Dim all As Boolean = Form2.all.Checked
    Dim thisdate As Boolean = Form2.thisdate.Checked
    Dim before As Boolean = Form2.before.Checked
    Dim after As Boolean = Form2.after.Checked
    Dim tomydate As Boolean = Form2.tomydate.Checked
    Dim transreference As String = Form2.transreference.Text
    Dim transjo As String = Form2.transjo.Text
    Dim transactioncosthead As String = Form2.transactioncosthead.Text
    Public Sub searchtransaction()

        ds = New DataSet


        Dim dtt As String = ""
        Dim tr As String = ""
        Dim where As String = ""
        If transaction = "Issue & Supply" Then
            tr = "(a.transtype='Issue' or a.transtype='Supply')"
        ElseIf transaction = "Issue & Receipt & +Adjustment-" Then
            tr = "(a.transtype='Issue' or a.transtype='Receipt' or a.transtype='+Adjustment' or a.transtype='-Adjustment')"
        ElseIf transaction = "" Then
            tr = "a.transtype=a.transtype"
        Else
            tr = "a.transtype='" & transaction & "'"
        End If

        Dim dec As String = "
                                declare @sdate as date = '" & transdate & "'
                                declare @edate as date = '" & todate & "'"

        If all = True Then
            dtt = " and a.TRANSDATE = a.TRANSDATE"
        ElseIf thisdate = True Then
            dtt = " and a.TRANSDATE = @sdate"
        ElseIf before = True Then
            dtt = " and a.TRANSDATE < @sdate"
        ElseIf after = True Then
            dtt = " and a.TRANSDATE > @sdate"
        ElseIf tomydate = True Then
            dtt = " and a.TRANSDATE between @sdate and @edate"
        End If

        Dim a As String = transreference
        Dim b As String = transjo
        Dim c As String = transactioncosthead

        Dim acol As String = "a.reference"
        Dim bcol As String = "a.jo"
        Dim ccol As String = "b.costhead"

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

        where = "           where
                                " & acol & " = " & a & " and 
                                " & bcol & " = " & b & " and 
                                " & ccol & " = " & c & " and 
                                " & tr & "
                                " & dtt & " "

        Dim str As String = "" & dec & "
                                select distinct
                                a.STOCKNO,

                                a.REFERENCE,
                                a.JO

                                from trans_tb as a inner join stocks_tb as b
                                on a.stockno = b.stockno
                                " & where & ""



        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.Fill(ds, "trans_tb")

                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub
    Dim stockno As New ArrayList

    Private Sub gv_SelectionChanged(sender As Object, e As EventArgs) Handles gv.SelectionChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gv.SelectAll()
        Dim selecteditems As DataGridViewSelectedRowCollection = gv.SelectedRows
        Dim reflist As ArrayList = New ArrayList(selecteditems.Count)
        Dim stlist As ArrayList = New ArrayList(selecteditems.Count)
        Dim jolist As ArrayList = New ArrayList(selecteditems.Count)

        For Each selecteditem As DataGridViewRow In selecteditems
            reflist.Add(selecteditem.Cells("reference").Value.ToString)
            stlist.Add(selecteditem.Cells("stockno").Value.ToString)
            jolist.Add(selecteditem.Cells("jo").Value.ToString)
        Next
        Form2.ProgressBar2.Visible = True
        Form2.ProgressBar2.Maximum = reflist.Count
        Form2.ProgressBar2.Value = 0
        For i As Integer = 0 To reflist.Count - 1
            Dim reference As String = reflist(i).ToString
            Dim stockno As String = stlist(i).ToString
            Dim jo As String = jolist(i).ToString
            Form2.updatereferencerecord(reference, jo, stockno)
            Form2.updatestock(stockno, reference, jo)
            Form2.ProgressBar2.Value += 1
        Next
        If Form2.ProgressBar2.Value = Form2.ProgressBar2.Maximum Then
            MessageBox.Show("Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.ProgressBar2.Visible = False
        End If
    End Sub

    Private Sub updatereferenceFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class