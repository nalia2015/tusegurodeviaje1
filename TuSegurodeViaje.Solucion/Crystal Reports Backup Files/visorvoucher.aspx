<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visorvoucher.aspx.cs" Inherits="TuSegurodeViaje.WebSite.Reportes.visorvoucher" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<%--<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>--%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table>
            <tr>
            <td><CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" /></td>
            <td><asp:Panel ID="Panel2" Visible="true" Runat="server">
                    <asp:Label ID="lblError" runat="server" Text="Label" Height="16px" Width="900px"></asp:Label>
                    </asp:Panel></td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
