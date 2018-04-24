<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dxwpg" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASPxPivotGrid Custom Summary</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" Theme="Metropolis" Width="800" Height="500" 
            OptionsView-VerticalScrollBarMode="Auto" OptionsView-VerticalScrollingMode="Standard" OptionsPager-Visible="False"
            DataSourceID="AccessDataSource1" OnCustomSummary="ASPxPivotGrid1_CustomSummary" >
            <Fields>
                <dxwpg:PivotGridField ID="fieldProductName" AreaIndex="0"
                    FieldName="ProductName">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldCompanyName" Area="RowArea" AreaIndex="0" 
                    FieldName="CompanyName">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldOrderYear" Area="ColumnArea" AreaIndex="0" 
                    Caption="Year" FieldName="OrderDate" GroupInterval="DateYear">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldOrderQuarter" Area="ColumnArea" AreaIndex="1" 
                    Caption="Quarter" FieldName="OrderDate" GroupInterval="DateQuarter" ValueFormat-FormatType="Custom"
                    ValueFormat-FormatString="Qtr {0}" >
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldProductAmount" Area="DataArea" AreaIndex="0" 
                    FieldName="ProductAmount" SummaryType="Custom">
                </dxwpg:PivotGridField>
            </Fields>
        </dxwpg:ASPxPivotGrid>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/nwind.mdb" 
            SelectCommand="SELECT * FROM [CustomerReports]">
        </asp:AccessDataSource>
    </div>
    </form>
</body>
</html>
