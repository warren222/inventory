﻿Public Class Form1
    Dim sql As New sql
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Form2.Show()
        Form2.MdiParent = Me

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form9.KryptonLabel2.Text = "Admin" Then
            ManageAccountsToolStripMenuItem.Visible = True
            ColorMngrToolStripMenuItem.Visible = True
        Else
            ManageAccountsToolStripMenuItem.Enabled = False
            ColorMngrToolStripMenuItem.Visible = False
        End If

        If nickname.Text = "Daniel" Or
           nickname.Text = "Warren" Then
            CuttingListMonitoringToolStripMenuItem.Visible = True
        Else
            CuttingListMonitoringToolStripMenuItem.Visible = False
        End If

        If nickname.Text = "Grace" Or nickname.Text = "Warren" Then
            WarehouseItemsToolStripMenuItem.Visible = True
            AccountabilityMonitoringToolStripMenuItem.Visible = True
        Else
            WarehouseItemsToolStripMenuItem.Visible = False
            AccountabilityMonitoringToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Exit Sub?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
        Form9.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MessageBox.Show("Exit Sub?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.Close()
        Form9.Show()
    End Sub

    Private Sub ManageAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAccountsToolStripMenuItem.Click
        Form10.ShowDialog()
    End Sub

    Private Sub ManageColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageColumnsToolStripMenuItem.Click
        managecolumns.ShowDialog()
    End Sub

    Private Sub ColorMngrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorMngrToolStripMenuItem.Click
        ColorManagerTool.Show()
    End Sub

    Private Sub ASRefoilingQuotationSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASRefoilingQuotationSummaryToolStripMenuItem.Click
        ASRefoilingQuotationSummary.Show()
    End Sub

    Private Sub CuttingListMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingListMonitoringToolStripMenuItem.Click
        ItemsToMonitor.Show()
    End Sub

    Private Sub AccountabilityMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountabilityMonitoringToolStripMenuItem.Click
        AccountabilityPage.Show()
        AccountabilityPage.MdiParent = Me
    End Sub

    Private Sub WarehouseItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WarehouseItemsToolStripMenuItem.Click
        AccountabilityItems.Show()
        AccountabilityItems.MdiParent = Me
    End Sub
End Class
