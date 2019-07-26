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
End Class