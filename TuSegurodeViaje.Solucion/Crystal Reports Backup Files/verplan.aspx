﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verplan.aspx.cs" Inherits="TuSegurodeViaje.WebSite.verplan" %>

<!doctype html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
    <!--<![endif]-->
    <head id="Head1" runat=server>
        <title>Tu Seguro de Viaje | VER PLAN </title>
        <meta name="description" content="tu seguro de viaje"/>
        <meta charset="utf-8">
        <meta name="author" content=""/>
        <meta name="format-detection" content="telephone=yes">
        <meta name="viewport" content="initial-scale=1">

        <link rel="stylesheet" href="assets/css/main.css" />
        <link rel="stylesheet" href="assets/css/mainboos.css" />
       
    </head>
<body itemscope itemtype="http://schema.org/WebPage" id="quote-results-list">
<script type="text/javascript" >
    function enviamensaje() {
        document.getElementById("hdfenviamensaje").value = 'envia';
        frmCompara.submit();
    }
</script>

<div class="" style="">
        <div class="quoteCompareResults">
            <form id="frmCompara" action="#" method="POST" name="comparativa" runat=server>
                <asp:HiddenField ID="hdfenviamensaje" runat="server" Value="0" /> 
                <div class="quoteCompareDisplay">
                    <% muestracomparativa(); %>                           
                </div> 
                <asp:Panel ID="Panel2" Visible="true" Runat="server">
                    <asp:Label ID="lblError" runat="server" Text="" Height="16px" Width="900px"></asp:Label>
                </asp:Panel>                   
             </form>
         </div>
</div>
</body>
</html>
