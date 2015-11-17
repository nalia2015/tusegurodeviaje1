<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pago-confirmado.aspx.cs" Inherits="TuSegurodeViaje.WebSite.pago_confirmado" %>
<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<%@ Import Namespace="System.Collections" %>
<%@ Import Namespace="mercadopago" %>

<!DOCTYPE HTML>
<html lang="es">
	<head runat=server>
		<title>Pago Confirmado | Tu Seguro de Viaje</title>
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

            function asignarurl(idhref) {
                document.getElementById('hdfIdOperacion').value = document.getElementById('lblOperacion').innerHTML;
                var url = document.getElementById(idhref.toString()).getAttribute('href');
                var inputValue = 'Reportes/visorsolicitudes.aspx?op=' + document.getElementById('hdfIdOperacion').value;
                document.getElementById(idhref.toString()).setAttribute('href', inputValue);
            } 

        </script>  
   	  
 		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body class="landingcampare">
    <div>
    <form id="frmpago" runat="server" method="post">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>       
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />      
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
   <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
  <div id="innerpago" class="texto">
          <div class="row">
              <div class="12u">
                <section class="box sub">
                    <h3>PAGO CONFIRMADO</h3>
                    <br>
                    <div class="row">
                      <div class="12u 12u(mobilep)">

                     <div class="mensaje">SU TRANSACCION RESULTO EXITOSA!!</div>
                      <br>
<div class="final">
  <h2>Tusegurodeviaje.net agradece su elección!</h2>
  <h2 class="mensajeope center">Su número de operación es <asp:Label ID="lblOperacion" runat="server" Text="Label"></asp:Label></h2>

<p>A continuación podrá acceder a la/s SOLICITUD/ES DE EMISION/ES DE su voucher/s.</p>
<p>Encontrara también el acceso al texto de las condiciones generales del servicio posicionándose en cada enlace.</p>
 
 <asp:Panel ID="Pasajero1" runat="server" Visible=false> 
   <p><b><a id="url1" href=""  onclick="asignarurl('url1');" >SOLICITUD de EMISION de Voucher OP Nro.<asp:Label ID="lblOperacionPasajero1" runat="server" Text=""></asp:Label> <asp:Label ID="lblPasajeroNombre1" runat="server" Text=""></asp:Label> y <asp:Label ID="lblPasajeroApellido1" runat="server" Text=""></asp:Label> </a></b></p> 
 </asp:Panel>

 <asp:Panel ID="Pasajero2" runat="server" Visible=false> 
   <p><b><a id="url2" href="" onclick="asignarurl('url2');">SOLICITUD de EMISION de Voucher OP Nro.<asp:Label ID="lblOperacionPasajero2" runat="server" Text=""></asp:Label> <asp:Label ID="lblPasajeroNombre2" runat="server" Text=""></asp:Label> y <asp:Label ID="lblPasajeroApellido2" runat="server" Text=""></asp:Label> </a></b></p> 
 </asp:Panel>

 <asp:Panel ID="Pasajero3" runat="server" Visible=false> 
   <p><b><a id="url3" href="" onclick="asignarurl('url3');">SOLICITUD de EMISION de Voucher OP Nro.<asp:Label ID="lblOperacionPasajero3" runat="server" Text=""></asp:Label> <asp:Label ID="lblPasajeroNombre3" runat="server" Text=""></asp:Label> y <asp:Label ID="lblPasajeroApellido3" runat="server" Text=""></asp:Label> </a></b></p> 
 </asp:Panel>

  <asp:Panel ID="Pasajero4" runat="server" Visible=false> 
   <p><b><a id="url4" href="" onclick="asignarurl('url4');">SOLICITUD de EMISION de Voucher OP Nro.<asp:Label ID="lblOperacionPasajero4" runat="server" Text=""></asp:Label> <asp:Label ID="lblPasajeroNombre4" runat="server" Text=""></asp:Label> y <asp:Label ID="lblPasajeroApellido4" runat="server" Text=""></asp:Label> </a></b></p> 
 </asp:Panel>

 <asp:Panel ID="Pasajero5" runat="server" Visible=false> 
   <p><b><a id="url5" href="" onclick="asignarurl('url5');">SOLICITUD de EMISION de Voucher OP Nro.<asp:Label ID="lblOperacionPasajero5" runat="server" Text=""></asp:Label> <asp:Label ID="lblPasajeroNombre5" runat="server" Text=""></asp:Label> y <asp:Label ID="lblPasajeroApellido5" runat="server" Text=""></asp:Label> </a></b></p> 
 </asp:Panel>

  <asp:Panel ID="Pasajero6" runat="server" Visible=false> 
   <p><b><a id="url6" href="" onclick="asignarurl('url6');">SOLICITUD de EMISION de Voucher OP Nro.<asp:Label ID="lblOperacionPasajero6" runat="server" Text=""></asp:Label> <asp:Label ID="lblPasajeroNombre6" runat="server" Text=""></asp:Label> y <asp:Label ID="lblPasajeroApellido6" runat="server" Text=""></asp:Label> </a></b></p> 
 </asp:Panel>

<br>
<h2> Condiciones Generales del Servicio del producto contratado</h2>

<p>- Cuando los vouchers definitivos sean emitidos, dicha información le será enviada a la casilla de correo electrónico por Ud. Informado.</p>

<p>- Verifique que la información registrada sea correcta, y ante posibles correcciones o modificaciones contáctenos inmediatamente a <a href ="mailto:clientes@tusegurodeviaje.net">clientes@tusegurodeviaje.net</a> para gestionar las modificaciones que correspondan.</p>

<p>- Su factura, será enviada a la casilla de correo electrónico por Ud. Informado.</p>

<p>- Le recomendamos lea con detenimiento la documentación y la información recibida: detalles del producto adquirido, alcances y limitaciones del mismo que se describen en el texto de las condiciones generales del servicio.</p>

<p>- Durante su viaje, en caso de requerir asistencia, comuníquese siempre a los teléfonos correspondientes a la central de asistencias de la compañía contratada.  Dicha información se encuentran en su voucher.</p>

<h2>El equipo de Tusegurodeviaje.net le desea un muy buen viaje!</h2>
</div>


                      </div>
                    </div>
  				</section>
  			</div>
       </div>                
  </div>
  <div class="row texto">
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
