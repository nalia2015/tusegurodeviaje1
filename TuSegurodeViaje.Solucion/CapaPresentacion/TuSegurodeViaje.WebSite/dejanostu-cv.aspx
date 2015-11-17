<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dejanostu-cv.aspx.cs" Inherits="TuSegurodeViaje.WebSite.dejanostu_cv" %>

<!DOCTYPE HTML>
<html lang="es">
	<head runat=server>
		<title>RRHH Dejanos tu CV | Tu Seguro de Viaje</title>
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
        <!-- Banner -->            
         <br>
         <br>
<div id="page-wrapper" class="container">
<div class="12u cabe12 indicador"><h4>RRHH Dejanos tu CV</h4></div>
<!-- datos PF -->
<div class="row texto">
    <div class="12u">
    <section class="box sub">
<form class="contact_form" action="#" method="post" name="contact_form"><h3>Tus datos de contacto:</h3>
    <ul>
        <li>
            <label for="name">Nombre y Apellido:</label>
            <input type="text" placeholder="Juan Lopez" title="Ingrese Nombre y Apellido" required />
        </li>
        <li>
            <label for="tel">Telefono:</label>
            <input type="text" name="tel" placeholder="Telefono" required />
        </li>
        
        <li>
            <label for="cel">Celular:</label>
            <input type="text" name="cel" placeholder="Celular" required />
        </li>
        <li>
            <label for="cel">Adjuntar CV:</label>
            <input type="file" multiple name="ad" placeholder="Adjuntar CV"  >
        </li> 
        <li>
            <label for="email">Email:</label>
            <input type="email" name="email" placeholder="juan@example.com" required />
            <span class="form_hint">Formato aprobado "juan@example.com"</span>
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
    <a href="te-llamamos.html" class="iframe6 initColorBox cboxElement" data-lightbox-type="mini">
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
