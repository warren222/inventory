﻿Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ASRefoilingQuotationSummary
    Dim sql As New sql
    Dim bgw As New BackgroundWorker
    Dim action As String

    Dim _projectds As New DataSet
    Dim _projectbs As New BindingSource

    Dim _colords As New DataSet
    Dim _colorbs As New BindingSource

    Private Sub ASRefoilingQuotationSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gvProject.DataSource = _projectbs
        gvColor.DataSource = _colorbs
        starter("loadProject")
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
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "loadProject"
                starter("loadColor")
            Case "loadColor"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "loadProject"
                _projectbs.DataSource = _projectds
                _projectbs.DataMember = "Project_Tbl"
            Case "loadColor"
                _colorbs.DataSource = _colords
                _colorbs.DataMember = "Color_Tbl"
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "loadProject"
                Query(action)
                bgw.ReportProgress(0)
            Case "loadColor"
                Query(action)
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim da As SqlDataAdapter = New SqlDataAdapter()
    Private Sub Query(ByVal command As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                sqlcmd.CommandText = "Refoiling_Area_Summary_Stp"
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@Command", command)
                If command = "loadProject" Then
                    _projectds = New DataSet
                    _projectds.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_projectds, "Project_Tbl")
                ElseIf command = "loadColor" Then
                    _colords = New DataSet
                    _colords.Clear()
                    da.SelectCommand = sqlcmd
                    da.Fill(_colords, "Color_Tbl")
                End If
            End Using
        End Using
    End Sub
End Class