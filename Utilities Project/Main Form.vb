' Name:         Utilities Project
' Purpose:      Display utility bills.
' Programmer:   Austin Parker // June 22,2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub BillsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BillsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.BillsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UtilitiesDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UtilitiesDataSet.Bills' table. You can move, or remove it, as needed.
        Me.BillsTableAdapter.Fill(Me.UtilitiesDataSet.Bills)

    End Sub



    Private Sub BillsDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BillsDataGridView.CellContentClick

    End Sub
End Class
