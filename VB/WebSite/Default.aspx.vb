Imports System
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub ASPxPivotGrid1_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs)
        If ReferenceEquals(e.DataField, fieldProductAmount) Then
            ' This is a Grand Total cell.
            If ReferenceEquals(e.ColumnField, Nothing) OrElse ReferenceEquals(e.RowField, Nothing) Then
                e.CustomValue = "Grand Total"
                Return
            End If
            Dim pivot As ASPxPivotGrid = TryCast(sender, ASPxPivotGrid)
            Dim lastRowFieldIndex As Integer = pivot.Fields.GetVisibleFieldCount(PivotArea.RowArea) -1
            Dim lastColumnFieldIndex As Integer = pivot.Fields.GetVisibleFieldCount(PivotArea.ColumnArea) - 1

            ' This is an ordinary cell.
            If e.RowField.AreaIndex = lastRowFieldIndex AndAlso e.ColumnField.AreaIndex = lastColumnFieldIndex Then
                e.CustomValue = e.SummaryValue.Average
            ' This is a Total cell.
            Else
                e.CustomValue = "Total"
            End If
        End If
    End Sub
End Class
