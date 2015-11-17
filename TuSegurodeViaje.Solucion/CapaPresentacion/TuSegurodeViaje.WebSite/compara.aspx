<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compara.aspx.cs" Inherits="TuSegurodeViaje.WebSite.compara" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!doctype html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="es">
    <!--<![endif]-->
    <head runat=server>
        <title>Tu Seguro de Viaje | COMPARAR PLANES </title>
        <meta name="description" content="tu seguro de viaje"/>
        <meta charset="utf-8">
        <meta name="author" content=""/>
        <meta name="format-detection" content="telephone=yes">
        <meta name="viewport" content="initial-scale=1">

        <link rel="stylesheet" href="assets/css/main.css" />
        <link rel="stylesheet" href="assets/css/mainboos.css" />
        <link rel="stylesheet" href="assets/css/styletsv.css" />
        <link rel="icon" type="image/png" href="assets/images/favicon.png" /> 
    </head>
<body  >
 <form id="frmCompara" action="#" method="POST" name="comparativa" runat=server >
    <asp:HiddenField ID="hdfOrigen" runat="server" Value="0" />
    <asp:HiddenField ID="hdfDestino" runat="server" Value="0" />
    <asp:HiddenField ID="hdfFechaDesde" runat="server" Value="0" />
    <asp:HiddenField ID="hdfFechaHasta" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEdad1" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEdad2" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEdad3" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEdad4" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEdad5" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEdad6" runat="server" Value="0" />
    <asp:HiddenField ID="hdfEmail" runat="server" Value="0" />
    <asp:HiddenField ID="hdfOpcion" runat="server" Value="OK"/>
    <asp:HiddenField ID="hdfCantPasajeros" runat="server" Value="0"/>
<div  class="texto">
        <div class="row">
            <div class="10u">
              <section class="box sub">
                 <%-- <h3>DATOS DE TU VIAJE</h3>
                  <div class="row">
                    <div class="2u 12u(mobilep)">

                    <span><b>Origen:</b> <asp:Label ID="lblOrigen" runat="server" Text="Label"></asp:Label></span><br>
                    <span><b>Destino:</b> <asp:Label ID="lblDestino" runat="server" Text="Label"></asp:Label></span>

                    </div>
                    <div class="3u 12u(mobilep)">

                    <span><b>Fecha de Salida:</b><asp:Label ID="lblSalida" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Fecha de LLegada:</b><asp:Label ID="lblLlegada" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Cantidad de Dias:</b><asp:Label ID="lblCantidad" runat="server" Text=""></asp:Label> </span>

                    </div>

                    <div class="3u 12u(mobilep)">

                     <span><b>Cantidad de pasajeros:</b> <asp:Label ID="lblCantPersonas" runat="server" Text="Label"></asp:Label> personas</span><br>

                    </div>
                  </div>
  --%>
            </section>
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
            <asp:Panel ID="Panel2" Visible="true" Runat="server">
                <asp:Label ID="lblError" runat="server" Text="" Height="16px" Width="900px"></asp:Label>
            </asp:Panel> 
          </div>
         </div>


</div>

<div class="quoteCompareResults">
   
   <% muestracomparativa(); %>                 

</div>
</form>
</body>
</html>
