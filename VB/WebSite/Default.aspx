<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v10.1, Version=10.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dxwpg" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v10.1, Version=10.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>

	</div>
	<dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
		DataSourceID="AccessDataSource1" OnCustomSummary="ASPxPivotGrid1_CustomSummary">
		<Fields>
			<dxwpg:PivotGridField ID="fieldProductName" AreaIndex="0"
				FieldName="ProductName">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldCompanyName" Area="RowArea" AreaIndex="0" 
				FieldName="CompanyName">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldOrderYear" Area="ColumnArea" AreaIndex="0" 
				FieldName="OrderDate" GroupInterval="DateYear">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldOrderQuarter" Area="ColumnArea" AreaIndex="1" 
				FieldName="OrderDate" GroupInterval="DateQuarter" >
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
	</form>
</body>
</html>