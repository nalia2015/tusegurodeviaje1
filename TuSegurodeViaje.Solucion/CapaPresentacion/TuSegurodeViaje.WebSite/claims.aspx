<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="claims.aspx.cs" Inherits="TuSegurodeViaje.WebSite.claims" %>

<!DOCTYPE HTML>
<html lang="es">
	<head runat=server>
		<title>CLIENTES - Claims: Reembolsos & Reintegros | Tu Seguro de Viaje</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
				<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
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
        
    </head>
        <body class="landingcampare">

    <div id="page-wrapper1">
        <!-- Header -->
        <!--#include virtual="menu.html" -->
        <!-- Banner -->
          
         <br>
         <br>
<div id="page-wrapper" class="container">
<div class="12u cabe12 indicador"><h4>TRAMITACION DE REINTEGROS</h4></div>
<!-- datos PF -->
<div class="row texto">
    <div class="12u">
    <section class="box">
              
                  <div class="row">
                    <div class="12u 12u(mobilep) textop">
                    <p>Para iniciar el trámite de solicitud de reembolso de gastos asistenciales que haya debido abonar en su viaje, deberá como primer paso enviar un correo electrónico a la dirección <a href="mailto:clientes@tusegurodeviaje.net">clientes@tusegurodeviaje.net</a> con la información abajo detallada o completar el siguiente formulario: </p>
<h3>Solicitud de reembolso de gastos asistenciales:</h3> 
<table>

<tr>
<td>Número de Operación:</td>
<td><input type="text" name="cnoperacion" id="cnoperacion" value="" placeholder="OPXXXXX"> </td>
</tr>
<tr>
<td>Número de Voucher</td>
<td><input type="text" name="cnvaucher" id="cnvaucher" value="" placeholder="Número de Voucher"></td>
</tr>
<tr>
<td>Nombre y Apellido del Pasajero</td>
<td><input type="text" name="cnombre" id="cnombre" value="" placeholder="Nombre y Apellido"></td>
</tr>
<tr>
<td>Correo electrónico del Pasajero:</td>
<td><input type="text" name="cmail" id="cmail" value="" placeholder="E-mail Pasajero"></td>
</tr>
<tr>
<td>Teléfono de Contacto:</td>
<td><input type="text" name="ctel" id="ctel" value="" placeholder="Teléfono"></td>
</tr>
<tr>
<td>Breve relato de los hechos:</td>
<td><textarea name="crelato" id="crelato" placeholder="Breve relato"></textarea>
</td>
</tr>
</table>
<div class="12u 12u(mobilep)">

<h3>Detalle de gastos solicitados para reembolso:</h3>                
 
 <table>
    <tr>
        <td>Comprobante Numero</td>
        <td>Fecha (dd/mm/aaaa)</td>
        <td>Concepto</td>
        <td>Moneda</td>
        <td>Importe</td>
    </tr>
     <tr>
        <td><input type="text" name="ccomprobante" id="ccomprobante" value="" placeholder="Numero"></td>
        <td><input type="text" name="cfechas" id="p2" value="" placeholder="Fecha"></td>
        <td><input type="text" name="cconcepto" id="cconcepto" value="" placeholder="Concepto"></td>
        <td><input type="text" name="moneda" id="moneda" value="" placeholder="Moneda"></td>
        <td><input type="text" name="cimporte" id="cimporte" value="" placeholder="Importe"></td>
    </tr>

  </table>
<br>
                    <div class="center">
                     <a href="#">
                     <input type="button" value="ENVIAR" class="btn button specialg" name="p" />
                     </a>
                   </div>
                   <hr>

</div>          
                    

                   <ol type="A">
                   <li><b>Plazo para pedir el reintegro:</b> 60 días corridos desde la fecha de regreso del beneficiario al país de su residencia.</li>
<li><b>Las prestadoras,</b> según el texto de las Condiciones Generales del Servicio tienen derecho a requerir toda la documentación necesaria para corroborar la procedencia del reintegro en base a los hechos alegados y requerimiento establecido en las presentes condiciones generales. La no presentación de la documentación suspenderá los términos y eximirá a la prestadora de efectuar reintegro alguno.</li>
<li><b>Respuesta:</b> Las prestadoras dispondrán de hasta 90 días desde que haya recibido toda la documentación necesaria para responder al beneficiario si procede o no el reintegro solicitado.</li>
<li><b>Moneda:</b> Los reintegros se harán en la moneda de curso legal del país de la contratación del servicio de asistencia al viajero.</li>
<li><b>Lugar y fecha de pago:</b> Los reintegros se harán una vez finalizado el viaje en el país de residencia del beneficiario según el domicilio declarado y/o en el país de contratación del servicio de asistencia al viajero.</li>
<li><b>Tipo de cambio:</b> El tipo de cambio que se aplicará será el vigente en la fecha del pago del reintegro.</li>
<li><b>Límite:</b> El importe a reintegrar no podrá exceder los aranceles y tarifas vigentes según los usos y costumbres en el país en que se generaron los gastos, ni el tope de gastos previsto para cada producto.</li>
</ol>
              
                  </div>
                  </div>
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
        <!--    <script src="assets/js/main.js"></script>-->
            <script src="11/assets/js/main.js"></script>
            <script src="11/assets/js/jquery.scrollex.min.js"></script>
            <script src="11/assets/js/jquery.scrolly.min.js"></script>
            

       <!--#include virtual="chat.html" -->
            

	</body>
</html>
