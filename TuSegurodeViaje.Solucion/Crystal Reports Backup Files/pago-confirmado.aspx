﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pago-confirmado.aspx.cs" Inherits="TuSegurodeViaje.WebSite.pago_confirmado" %>
<%@ Import Namespace="System.Collections" %>
<%@ Import Namespace="mercadopago" %>

<!DOCTYPE HTML>
<html>
	<head runat=server>
		<title>Pago Confirmado | Tu Seguro de Viaje</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->

		<link rel="stylesheet" href="assets/css/main.css" />
		<link rel="stylesheet" href="assets/css/mainboos.css" />
        
       <link rel="stylesheet" href="assets/css/colorbox.css" />
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
        <script src="assets/js/jquery.colorbox.js"></script>
        <script>
            $(document).ready(function () {
                //Examples of how to assign the Colorbox event to elements
                $(".iframe").colorbox({ iframe: true, width: "95%", height: "95%" });
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
                    <header id="headern" class="alt">
                        <h1><a href="index.aspx" class="logotu">&nbsp;</a></h1>
                        <nav id="nav">
                            <ul>
                                <li class="special22">
                                    <a href="#menun" class="menuToggle"><span>&nbsp;</span></a>
                                    <div id="menun">
                                        <ul>
                            <li>
                                <a href="#" class="icon fa-angle-down"> Nosotros</a>
                                <ul>
                                    <li><a href="la-empresa.html">La Empresa</a></li>
                                    <li><a href="staff-especialidad.html">Staff & Especialidad</a></li>
                                    <li><a href="objetivo-filosofia.html">Objetivo & Filosofia</a></li>
                                    <li><a href="ventajas-para-nuestros-clientes.html">Ventajas para nuestros clientes</a></li>
                                    <li><a href="medios-de-pago.html">Medios de Pago</a></li>
                                    <li><a href="certificaciones.html">Certificaciones</a></li>
                                    <li><a href="seguridad-del-sitio.html">Seguridad del Sitio</a></li>
                                    <li><a href="por-que-elegirnos.html">Por que elegirnos</a></li>
                                    
                                </ul>
                            </li>
                            <li>
                                <a href="#" class="icon fa-angle-down"> Productos</a>
                                <ul>
                                    <li><a href="seguro-de-viaje-obligatorio-a-cuba.html">Seguro de Viaje obligatorio a Cuba</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-venezuela.html">Seguro de Viaje obligatorio a Venezuela</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-europa.html">Seguro de Viaje obligatorio a Europa</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-schengen.html">Seguro de Viaje Schengen</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-usa.html">Seguro de Viaje obligatorio a USA</a></li>
                                    
                                </ul>   
                            </li>
                           
                        </ul>
                                    </div>
                                </li>
                            </ul>
                        </nav>
                    </header>

            <!-- Header -->
                <header id="header" class="alt2">
                    <h1><a href="index.aspx" class="logotu">&nbsp;</a></h1>
                    <nav id="nav">
                        <ul>
                            <li><a href="#" class="ftel"> &nbsp; +54 11 5235 3998</a></li>
                            <li>&nbsp;</li>
                            <li><a href="#" class="icon fa-angle-down"><img src="images/ban/argentina.jpg" width="16" height="11"></a></li>
                        </ul>
                    </nav>
                </header>

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
                    <h3>PAGO CONFIRMADO</h3>
                    <br>
                    <div class="row">
                      <div class="12u 12u(mobilep)">

                     <div class="mensaje">Su pago ha sido procesado con éxito, en breve nos pondremos en contacto con usted.</div>


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
                     <asp:Panel ID="Panel2" Visible="true" Runat="server">
                           <asp:Label ID="lblError" runat="server" Text="" Height="16px" Width="900px"></asp:Label>
                    </asp:Panel>   
                   </div>
                   <hr>
                   
    </section>
    </div>
    </div>

    <br>
</div>



	 <footer id="footer pieblanco" class="pieblanco center" >

        <div style="margin-left:20px;"><a href="terminos-condiciones.html" class="iframe4"><span class="">Termino y condiciones</span></a> | <a href="politicas-de-privacidad.html" class="iframe4">Politicas de Privacidad</a>
    <div style="margin-left:20px;"><a href="TuSegurodeViaje.net" class=""><span class="">TuSegurodeViaje.net</span></a> | Telefono en Argentina: +54 11 5235 3998  |  Avenida General San Martín 3430,Piso 2, Oficina 201, Edificio Florida Office,  Florida, Buenos Aires, Argentina</div>
              
    </footer>
    </form>
		</div>

        <div class="feedback-tab">
            <a href="contacto.html" class="iframe5 initColorBox cboxElement" data-lightbox-type="mini">
                <img src="assets/images/contacto.png" alt="Contacto" title="Contacto">
            </a>
        </div>
        <div class="feedback-tabt">
            <a href="te-llamamos.html" class="iframe6 initColorBox cboxElement" data-lightbox-type="mini">
                <img src="assets/images/tellamamos.png" alt="Te llamamos" title="Te llamamos">
            </a>
        </div>
        <div class="feedback-tabw">
            <a href="#" class="" data-lightbox-type="mini">
                <img src="assets/images/whatsapp.png" alt="whatsapp" title="whatsapp">
            </a>
        </div><!-- -->
		
        <!-- Scripts -->
			<script src="assets/js/jquery.dropotron.min.js"></script>
			<script src="assets/js/jquery.scrollgress.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
      <script src="11/assets/js/main.js"></script>
      <script src="11/assets/js/jquery.scrollex.min.js"></script>
      <script src="11/assets/js/jquery.scrolly.min.js"></script>
	</body>
</html>
