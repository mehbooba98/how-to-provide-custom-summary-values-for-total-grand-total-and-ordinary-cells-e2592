using System;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void ASPxPivotGrid1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e) {
        if ( ReferenceEquals( e.DataField, fieldProductAmount)) {
            // This is a Grand Total cell.
            if(ReferenceEquals(e.ColumnField, null) || ReferenceEquals(e.RowField, null)) {                
                e.CustomValue = "Grand Total";
                return;
            }
            ASPxPivotGrid pivot = sender as ASPxPivotGrid;
            int lastRowFieldIndex = pivot.Fields.GetVisibleFieldCount(PivotArea.RowArea) -1;
            int lastColumnFieldIndex = pivot.Fields.GetVisibleFieldCount(PivotArea.ColumnArea) - 1;
            
            // This is an ordinary cell.
            if(e.RowField.AreaIndex == lastRowFieldIndex && e.ColumnField.AreaIndex == lastColumnFieldIndex) {
                e.CustomValue = e.SummaryValue.Average;
            }
            // This is a Total cell.
            else {                
                e.CustomValue = "Total";
            }
        }
    }
}
