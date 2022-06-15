Imports System.ComponentModel

Public Class CreateStocks_Frm
    Dim action As String
    Dim pinterval As Integer = 0
    Dim bgw As New BackgroundWorker
    Private Sub CreateStocks_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True

    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Dim _supplierString As String
    Dim _costheadString As String
    Dim _typecolorString As String
    Dim _articleString As String
    Dim _descriptionString As String
    Dim _qtyString As String
    Dim _unitString As String
    Dim _unitpriceString As String
    Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "Paste"
                LoadingPBOX.Visible = False
            Case "Remove"
                LoadingPBOX.Visible = False
            Case "Add"
                If pinterval < _supplierList.Count - 1 Then
                    pinterval += 1
                    ProgressBar1.Value = pinterval
                    _supplierString = _supplierList(pinterval).ToString
                    _costheadString = _costheadList(pinterval).ToString
                    _typecolorString = _typecolorList(pinterval).ToString
                    _articleString = _articlenoList(pinterval).ToString
                    _descriptionString = _descriptionList(pinterval).ToString
                    _qtyString = _qtyList(pinterval).ToString
                    _unitString = _unitList(pinterval).ToString
                    _unitpriceString = _unitpriceList(pinterval).ToString
                    starter("Add")
                Else
                    pinterval = 0
                    ProgressBar1.Value = _supplierList.Count - 1
                    LoadingPBOX.Visible = False
                    MessageBox.Show("data imported successfully!")

                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "Paste"
                Try
                    Dim row As Integer = 0
                    If DataGridView1.Rows.Count > 1 Then
                        row = DataGridView1.Rows.Count - 1
                    End If
                    Dim s As String = Clipboard.GetText()
                    Dim lines As String() = s.Replace(vbLf, "").Split(vbCr)
                    DataGridView1.Rows.Add(lines.Length - 1)
                    Dim fields As String()

                    Dim col As Integer = 0

                    For Each item As String In lines
                        fields = item.Split(vbTab)
                        For Each f As String In fields
                            Console.WriteLine(f)
                            DataGridView1(col, row).Value = f
                            col += 1
                        Next
                        row += 1
                        col = 0
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case "Remove"
                Try
                    Dim rows As DataGridViewSelectedRowCollection = DataGridView1.SelectedRows
                    For Each row As DataGridViewRow In rows
                        DataGridView1.Rows.Remove(row)
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "Paste"
                bgw.ReportProgress(0)
            Case "Remove"
                bgw.ReportProgress(0)
            Case "Add"
                'MsgBox(_supplierString)
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        starter("Paste")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        starter("Remove")

    End Sub

    Dim _supplierList As New ArrayList
    Dim _costheadList As New ArrayList
    Dim _typecolorList As New ArrayList
    Dim _articlenoList As New ArrayList
    Dim _descriptionList As New ArrayList
    Dim _qtyList As New ArrayList
    Dim _unitList As New ArrayList
    Dim _unitpriceList As New ArrayList

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.RowCount > 1 Then

            _supplierList = New ArrayList
            _costheadList = New ArrayList
            _typecolorList = New ArrayList
            _articlenoList = New ArrayList
            _descriptionList = New ArrayList
            _qtyList = New ArrayList
            _unitList = New ArrayList
            _unitpriceList = New ArrayList

            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim row As DataGridViewRow = DataGridView1.Rows(i)
                _supplierList.Add(row.Cells("supplier").Value.ToString())
                _costheadList.Add(row.Cells("costhead").Value.ToString())
                _typecolorList.Add(row.Cells("typecolor").Value.ToString())
                _articlenoList.Add(row.Cells("articleno").Value.ToString())
                _descriptionList.Add(row.Cells("description").Value.ToString())
                _qtyList.Add(row.Cells("qty").Value.ToString())
                _unitList.Add(row.Cells("unit").Value.ToString())
                _unitpriceList.Add(row.Cells("unitprice").Value.ToString())
            Next
            ProgressBar1.Maximum = _supplierList.Count - 1
            ProgressBar1.Value = 0
            _supplierString = _supplierList(0)
            starter("Add")
        End If
    End Sub

End Class