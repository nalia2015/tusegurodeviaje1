<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comparar-la-libertad.aspx.cs" Inherits="TuSegurodeViaje.WebSite.comparar_la_libertad" %>

<!DOCTYPE HTML>
<html lang="es">
	<head runat=server>
		<title>Comparar, La libertad de elegir mejor | Tu Seguro de Viaje</title>
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
<div class="12u cabe12 indicador"><h4>Comparar, La libertad de elegir mejor</h4></div>



<!-- inicio de float-->
<%--<div class=" cotizadorsolo ">
    
<!-- inicio recategorizacion-->
<form class="contact_formdos" action="#" method="post" name="contact_formdos">
        <div class="inner55miosolo " >

           <div class="innerbox flexbox">
            <div class="row 50%">
                    <!-- STARTS destination group-->
                    <div class="">
                    <div class="controlsmiosolo">
                    <select class="" name="quote[destination]" data-placeholder="ORIGEN: " tabindex="1" required>
                    <option selected="" value="" disabled="disabled">ORIGEN: </option>
                    <option value="1">ARGENTINA</option>
                    <option value="2">BRASIL</option>
                    <option value="3">COLOMBIA</option>
                    <option value="4">EEUU</option>
                    </select></div>
                    </div>



                    <div class="">
                    <div class="controlsmiosolo">
                    <select class="" name="quote[destination]" data-placeholder="DESTINO: " tabindex="2" required>
                    <option value="" disabled="disabled" selected>DESTINO: </option>            
                    <option value="1">AMERICA DEL NORTE</option>
                    <option value="2">AMERICA CENTRAL</option>
                    <option value="3">AMERICA DEL SUR</option>
                    <option value="4">EUROPA</option>
                    <option value="5">NACIONAL</option>
                    <option value="6">RESTO DEL MUNDO</option>
                    </select></div>
                    </div>


                    <!-- ENDS destination group-->
                    <div class="departure-date22">
                       <div class="controlsmiosolo ">
                        <script>
                            $(function () {
                                $.datepicker.regional['es'] =
                                                         {
                                                             closeText: 'Cerrar',
                                                             prevText: 'Previo',
                                                             nextText: 'Próximo',

                                                             monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio',
                                                         'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                                                             monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun',
                                                         'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                                                             monthStatus: 'Ver otro mes', yearStatus: 'Ver otro año',
                                                             dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
                                                             dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sáb'],
                                                             dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                                                             dateFormat: 'dd/mm/yy', firstDay: 0,
                                                             initStatus: 'Selecciona la fecha', isRTL: false
                                                         };
                                $.datepicker.setDefaults($.datepicker.regional['es']);
                                $("#datepicker").datepicker({
                                    minDate: 0,
                                    defaultDate: "1D",
                                    changeMonth: true,
                                    numberOfMonths: 2,
                                    onClose: function (selectedDate) {
                                        $("#datepicker2").datepicker("option", "minDate", selectedDate);
                                    }
                                });
                                $("#datepicker2").datepicker({
                                    defaultDate: "1D",
                                    changeMonth: true,
                                    numberOfMonths: 2,
                                    onClose: function (selectedDate) {
                                        $("#datepicker").datepicker("option", "maxDate", selectedDate);
                                    }
                                });
                            });
                    </script>
                         <input name="" class="" placeholder="SALIDA:" type="text" tabindex="3" id="datepicker" autocomplete="off" required>
                        </div>
                       </div>
                    <!-- ENDs Departure date group-->
                    
                    <div class="return-date22">
                    <div class="controlsmiosolo"><input name="quote[returnDate]" class="destinop" placeholder="REGRESO:" maxlength="8" size="7" type="text" tabindex="4" id="datepicker2" autocomplete="off" required></div> 
                    </div>
                    

                        <div class="return-date">
                        <div class="controlsmiosolo"><input name="" class="" placeholder="EDAD" type="number" tabindex="6" id="p1" min="0" max="99" autocomplete="off" required></div>
                        </div>

                        <div class="return-date">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class="" placeholder="EDAD"  type="number" tabindex="7" id="p2" min="0" max="99" autocomplete="off"></div>
                        </div>

                        <div class="return-date22">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class="" placeholder="EDAD"  type="number" tabindex="8" id="p3" min="0" max="99" autocomplete="off"></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class="" placeholder="EDAD"  type="number" tabindex="9" id="p4" min="0" max="99" autocomplete="off"></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class=" " placeholder="EDAD" type="number" tabindex="10" id="p5" min="0" max="99" autocomplete="off"></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class="" placeholder="EDAD"  type="number" tabindex="11" id="p6" min="0" max="99" autocomplete="off"></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class="descuentosolo" placeholder="COD. DESCUENTO" type="text" tabindex="11" id="p6" style="background-color:#FFE549" title="Si posee un CODIGO DE DESCUENTO, ingréselo aquí" autocomplete="off"></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmiosolo"><input name="quote[returnDate]" class="" placeholder="TU E-MAIL" type="email" tabindex="12" id="p6"  title="Ingrese E-mail" autocomplete="off" required></div>
                        </div>
                        <div class="return-date22"><button class="button2 specialg" type="submit">COTIZAR <i class="fa fa-chevron-right fa-lg">&nbsp;</i></button>
                        </div>

                        <!-- ENDS Return date group-->

                  
                </div>
            </div>
        </div>
!--fin recotizacion-->
<%--</form>--%>

</div>

<!--finde float   -->     

<!-- datos PF -->
<div class="row texto">
    <div class="12u">
    <section class="box">

                <div class="row">
                    <div class="12u 12u(mobilep) textop">
                    
                              
<div class="2u 12u(mobilep) bandera">
<img src="images/elegir-mejor-seguro.jpg">
</div>
<div class="12u 12u(mobilep)">
 <b>Comparar, proviene del latín comparatio.</b><br>
 
<p>Esta acción, refiere a fijar la atención en dos o más opciones de cosas reconociendo <b>sus diferencias, semejanzas y así</b>, descubrir sus <b>relaciones</b> y beneficios, pros y contras. </p>
<p>Tusegurodeviaje.net realiza en forma previa una comparación efectiva de toda la oferta de productos y servicios de asistencia al viajero y seguros de viaje, para que luego de un exhaustivo análisis y pruebas de calidad, seleccionamos para nuestros clientes las mejores opciones disponibles y que mejor se adecuan a sus necesidades puntuales.  Nuestra tecnología hace posible elaborar tablas comparativas para contrastar puntos claves como topes de cobertura, cantidad de servicios, tipos de viaje, limites de edad, precios, valuaciones de los usuarios, etcétera.  Pudiendo ser sometidos a análisis y selección con un alto grado de efectividad. </p>
<p>Nuestro objeto es facilitar y contribuir en el análisis individual de cada uno de nuestros clientes para la elección del producto que más se adapte a sus necesidades.</p>
<p>Nuestro comparador le permitirá no solo comparar tarifas y precios, sino también, calificación de proveedores, productos de cada uno de ellos y servicios adicionales al viajero, brindándole la tranquilidad de haber realizado una compra eficiente .</p>
<p>Nuestra misión:  Ser reconocidos  a nivel mundial como la mejor herramienta que contribuye y facilita la decisión de compra, porque nuestro lema es que COMPARAR BRINDA LA LIBERTAD DE ELEGIR MEJOR…</p>


       </div>    
              
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
		<!-- 	<script src="assets/js/main.js"></script>-->
            <script src="11/assets/js/main.js"></script>
            <script src="11/assets/js/jquery.scrollex.min.js"></script>
            <script src="11/assets/js/jquery.scrolly.min.js"></script>
            
            
        <!--#include virtual="chat.html" -->
	</body>
</html>

