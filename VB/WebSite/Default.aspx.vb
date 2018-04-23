Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxPivotGrid1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotGridCustomSummaryEventArgs)
		If ReferenceEquals(e.DataField, fieldProductAmount) Then
			If ReferenceEquals(e.ColumnField, Nothing) OrElse ReferenceEquals(e.RowField, Nothing) Then
				'this is Grand Total cell
				e.CustomValue = "Grand Total"
				Return
			End If
			Dim pivot As ASPxPivotGrid = TryCast(sender, ASPxPivotGrid)
			Dim lastRowFieldIndex As Integer = pivot.Fields.GetVisibleFieldCount(DevExpress.XtraPivotGrid.PivotArea.RowArea) -1
			Dim lastColumnFieldIndex As Integer = pivot.Fields.GetVisibleFieldCount(DevExpress.XtraPivotGrid.PivotArea.ColumnArea) - 1
			If e.RowField.AreaIndex = lastRowFieldIndex AndAlso e.ColumnField.AreaIndex = lastColumnFieldIndex Then
				'this is Ordinary cell
				e.CustomValue = e.SummaryValue.Summary
			Else
				'this is Total cell
				e.CustomValue = "Total"
			End If


		End If
	End Sub
End Class
