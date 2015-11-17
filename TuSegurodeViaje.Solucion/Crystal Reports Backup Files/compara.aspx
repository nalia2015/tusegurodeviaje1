<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compara.aspx.cs" Inherits="TuSegurodeViaje.WebSite.compara" %>

<!doctype html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
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
       
    </head>
<body  >
 <form id="frmCompara" action="#" method="POST" name="comparativa" runat=server >
 <asp:HiddenField ID="hdfenviamensaje" runat="server" Value="0" /> 
<div  class="texto">
        <div class="row">
            <div class="10u">
            <%--  <section class="box sub">
                  <h3>DATOS DE TU VIAJE</h3>
                  <div class="row">
                    <div class="2u 12u(mobilep)">

                    <span><b>Origen:</b> Argentina</span><br>
                    <span><b>Destino:</b> Europa</span>

                    </div>
                    <div class="3u 12u(mobilep)">

                    <span><b>Fecha de Salida:</b> 10/10/2015</span><br>
                    <span><b>Fecha de Salida:</b> 20/10/2015</span><br>
                    <span><b>Cantidad de Dias:</b> 10 dias</span>

                    </div>

                    <div class="3u 12u(mobilep)">

                    <span><b>Producto:</b> Economico</span><br>
                    <span><b>Cantidad de pasajeros:</b> 4 personas</span><br>
                    <span><b>Tarifa Total:</b> AR$ 1000 <b>|</b> <span class="gris">(U$S 50)</span></span>

                    </div>
                  </div>
  
            </section>--%>
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
