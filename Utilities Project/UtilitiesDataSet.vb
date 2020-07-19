Partial Class UtilitiesDataSet
    Partial Public Class BillsDataTable
        Private Sub BillsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MonthColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
