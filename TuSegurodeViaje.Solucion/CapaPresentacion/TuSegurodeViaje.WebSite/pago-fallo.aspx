<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pago-fallo.aspx.cs" Inherits="TuSegurodeViaje.WebSite.pago_fallo" %>
<%@ Import Namespace="System.Collections" %>
<%@ Import Namespace="mercadopago" %>

<!DOCTYPE HTML>
<html lang="es">
	<head runat=server>
		<title>Pago Fallo | Tu Seguro de Viaje</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="icon" type="image/png" href="assets/images/favicon.png" />

		<link rel="stylesheet" href="assets/css/main.css" />
		<link rel="stylesheet" href="assets/css/mainboos.css" />
        <link rel="stylesheet" href="assets/css/styletsv.css" />
       <link rel="stylesheet" href="assets/css/colorbox.css" />
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
        <script src="assets/js/jquery.colorbox.js"></script>
        <script>
            $(document).ready(function () {
                //Examples of how to assign the Colorbox event to elements
                $(".iframe").colorbox({ iframe: true, width: "95%", height: "95%" });
                $(".iframe5").colorbox({ iframe: true, width: "90%", height: "90%" });
                $(".iframe6").colorbox({ iframe: true, width: "90%", height: "90%" });
                $(".iframe7").colorbox({ iframe: true, width: "90%", height: "90%" });

            });

        </script>  
   	  
 		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body class="landingcampare">
    <div>
        <form id="frmpago" runat="server" method="post">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>         
        <asp:HiddenField ID="hdfEmail" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfFormaPago" runat="server" Value="0" />
        <asp:HiddenField ID="hdfOrigen" runat="server" Value="0" />
        <asp:HiddenField ID="hdfDestino" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfOpcion" runat="server" Value="OK"/>       
        <asp:HiddenField ID="hdfIdProducto" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfUrl" runat="server" Value=""/>

        
        <!-- Header -->
        		<!--#include virtual="menu.html" -->
        <!-- Banner -->
            
         <br>
         <br>
<div id="page-wrapper" class="container">
	<div class="flechas">
		<ul class="pasosPedido">
			<li class="arrow_box op1 activo">PASO 1. COTIZACION</li>
			<li class="arrow_box op2 ablanco">PASO 2. DATOS PERSONALES</li>
			<li class="arrow_box op3 ablanco2 activo2">PASO 3. PAGO</li>
		</ul>
	</div>
<div class="12u cabe12 indicador"><h4>FORMULARIO DE PAGO</h4></div>

  <div id="innerpago" class="texto">
          <div class="row">
              <div class="12u">
                <section class="box sub">
                    <h3>PAGO FALLO</h3>
                    <br>
                    <div class="row">
                      <div class="12u 12u(mobilep)">

                     <div class="mensajef">Su pago no ha sido procesado, en breve nos pondremos en contacto con usted.</div>


                      </div>
                    </div>
  				</section>
  			</div>
       </div>                
  </div><div class="row texto">
    <div class="12u">
    <section class="box">
                   <div class="center">
                     <a href="index.aspx">
                     <input type="button" value="INICIO" class="btn button specialg" name="p" />
                     </a>
                   </div>
                   <hr>
                   
    </section>
    </div>
    </div>

    <br>
</div>



           <!--#include virtual="pie2.html" -->
    </form>
		</div>

        	<!--#include virtual="lateral.html" -->
			<!--#include virtual="buscando.html" -->
		<!-- Scripts -->
			<script src="assets/js/jquery.dropotron.min.js"></script>
			<script src="assets/js/jquery.scrollgress.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
            <script src="11/assets/js/main.js"></script>
            <script src="11/assets/js/jquery.scrollex.min.js"></script>
            <script src="11/assets/js/jquery.scrolly.min.js"></script>

      			<!--#include virtual="chat.html" -->
	</body>
</html>
