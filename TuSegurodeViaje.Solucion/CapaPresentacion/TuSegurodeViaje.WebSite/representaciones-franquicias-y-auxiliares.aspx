<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="representaciones-franquicias-y-auxiliares.aspx.cs" Inherits="TuSegurodeViaje.WebSite.representaciones_franquicias_y_auxiliares" %>

<!DOCTYPE HTML>
<html lang="es">
	<head runat=server>
		<title>Representaciones, Franquicias y Auxiliares | Tu Seguro de Viaje</title>
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


	     <!-- <script src="js/jquery.min.js"></script>-->
	  <script src="js/jquery-ui.js"></script>
		
  		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
		
    <link rel="stylesheet" type="text/css" href="assets/css/default.css" />
    <link rel="stylesheet" type="text/css" href="assets/css/component.css" />
    <script src="assets/js/modernizr.custom.js"></script>

	</head>
        <body class="landingcampare">

    <div id="page-wrapper1">
       <!-- Header -->
       <!--#include virtual="menu.html" -->            
         <br>
         <br>
<div id="page-wrapper" class="container">
<div class="12u cabe12 indicador"><h4>Representaciones, Franquicias y Auxiliares</h4></div>
<!-- datos PF -->
<div class="row texto">
    <div class="12u">
    <section class="box">
              
                  <div class="row">
                    <div class="12u 12u(mobilep) textop">
                    
                              
        <div class="2u 12u(mobilep) bandera"><img src="images/franquicias-2.jpg"></div>
        <div class="12u 12u(mobilep)">
         
            <p><b>El modelo de Franchising o Representacion de Tusegurodeviaje.net</b> es un moderno sistema que habilita a los franquiciados o representantes la distribución y comercialización de los productos y/o servicios que ofrecemos en nuestro sitio.</p>
            <p>Nuestra empresa ha logrado en este ámbito, un éxito comercial en el mercado mundial.</p>
            <p>El objetivo es transmitir a otros empresarios emprendedores nuestros conocimientos y experiencia sobre este interesante negocio que le dara la oportunidad de ampliar su cartera de productos y servicios y acceder a una ingreso adicional sin costos asociados y con ningún riesgo comercial.</p>

            <p>Nuestras Franquicias…</p>
            <ul>
            <li>No requieres de inversión</li>
            <li>Poseen una alta rentabilidad</li>
            <li>Proveemos tecnología</li>
            <li>Proveemos capacitación en todos los procesos de comercialización y operaciones</li>
            <li>Permanente innovación, mejora y actualizaciónde nuestros productos y servicios</li>
            </ul>

            <p>Si desea ser Representante o Franquiciado de <b>tusegurodeviaje.net</b> complete el siguiente formulario y lo contactaremos</p> 
        </div>  
</div>
</div>
</section>

<section class="box sub">
<form class="contact_form" action="#" method="post" name="contact_form">
    <ul>
        <li>
            <label for="fempresa">Nombre de la Empresa:</label>
            <input type="text" placeholder="Nombre de la Empresa" title="Ingrese Nombre de la Empresa" required />
        </li>
        <li>
            <label for="frubro">Rubro:</label>
            <input type="text" placeholder="Rubro" title="Ingrese Rubro" required />
        </li>
        <li>
            <label for="fpais">Pais:</label>
            <input type="text" placeholder="Pais" title="Ingrese Pais" required />
        </li>
        <li>
            <label for="ftel">Telefono:</label>
            <input type="text" name="ftel" placeholder="Telefono" required />
        </li>
        <li>
            <label for="femail">Email:</label>
            <input type="email" name="femail" placeholder="juan@example.com" required />
            <span class="form_hint">Formato aprobado "juan@example.com"</span>
        </li>
        
        <li>
            <label for="fmessage">Comentarios:</label>
            <textarea name="fmessage" cols="40" rows="3" required ></textarea>
        </li>
        <li>
          <button class="submit" type="submit">ENVIAR</button>
        </li>
    </ul>
</form>
</section>
       </div>
     </div>

<!-- -->
  </div>

<br>
<br>

   <!--#include virtual="pie2.html" -->

</div>

<!-- lateral derecha -->
<div class="feedback-tab">
    <a href="contacto.aspx" class="iframe5 initColorBox cboxElement" data-lightbox-type="mini">
        <img src="assets/images/contacto.png" alt="Contacto" title="Contacto">
    </a>
</div>
<div class="feedback-tabt">
    <a href="te-llamamos.aspx" class="iframe6 initColorBox cboxElement" data-lightbox-type="mini">
        <img src="assets/images/tellamamos.png" alt="Te llamamos" title="Te llamamos">
    </a>
</div>
<div class="feedback-tabw">
    <a href="#" class="" data-lightbox-type="mini">
        <img src="assets/images/whatsapp.png" alt="whatsapp" title="whatsapp">
    </a>
</div>
<div class="feedback-tabs">
    <a onclick="return skypeCheck();" href="skype:fernandotellado?call" class="" data-lightbox-type="mini">
        <img src="assets/images/skype.png" alt="Skype" title="Skype">
    </a>
</div>
<!-- fin lateral derecha -->
        	
    <!--#include virtual="buscando.html" -->		
		<!-- Scripts 
			<script src="//assets/js/jquery.min.js"></script>-->
			<script src="assets/js/jquery.dropotron.min.js"></script>
			<script src="assets/js/jquery.scrollgress.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
		<!-- 	<script src="assets/js/main.js"></script>-->
            <script src="11/assets/js/main.js"></script>
            <script src="11/assets/js/jquery.scrollex.min.js"></script>
            <script src="11/assets/js/jquery.scrolly.min.js"></script>
            
            <!--#include virtual="chat.html" -->   

	</body>
</html>
