using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ASPxPivotGrid1_CustomSummary(object sender, DevExpress.Web.ASPxPivotGrid.PivotGridCustomSummaryEventArgs e)
    {
        if ( ReferenceEquals( e.DataField, fieldProductAmount))
        {
            if (ReferenceEquals(e.ColumnField, null) || ReferenceEquals(e.RowField, null))
            {
                //this is Grand Total cell
                e.CustomValue = "Grand Total";
                return;
            }
            ASPxPivotGrid pivot = sender as ASPxPivotGrid;
            int lastRowFieldIndex = pivot.Fields.GetVisibleFieldCount(DevExpress.XtraPivotGrid.PivotArea.RowArea) -1;
            int lastColumnFieldIndex = pivot.Fields.GetVisibleFieldCount(DevExpress.XtraPivotGrid.PivotArea.ColumnArea) - 1;
            if (e.RowField.AreaIndex == lastRowFieldIndex && e.ColumnField.AreaIndex == lastColumnFieldIndex)
            {
                //this is Ordinary cell
                e.CustomValue = e.SummaryValue.Summary;
            }
            else
            {
                //this is Total cell
                e.CustomValue = "Total";
            }

            
        }
    }
}
