<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TuSegurodeViaje.WebSite.index" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>

<!doctype html>
<html lang="es">
        <head runat=server>
		<title>Tu Seguro de Viaje</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
		<link rel="icon" type="image/png" href="assets/images/favicon.png" />

		<link rel="stylesheet" href="assets/css/main.css" />
		<link rel="stylesheet" href="assets/css/mainboos.css" />
		<link rel="stylesheet" href="assets/css/styletsv.css" />
		<link rel="stylesheet" href="lib/jquery.bxslider.css" type="text/css" />
	
	    <script src="js/jquery.min.js"></script>
	    <script src="js/jquery-ui.js"></script>
	    <script src="lib/jquery.bxslider.js"></script>
		
  		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->

		<link rel="stylesheet" href="assets/css/colorbox.css" />
       
        <script src="assets/js/jquery.colorbox.js"></script>
        <script>
            $(document).ready(function () {
                //Examples of how to assign the Colorbox event to elements

                $(".iframe5").colorbox({ iframe: true, width: "90%", height: "90%" });
                $(".iframe6").colorbox({ iframe: true, width: "90%", height: "90%" });
                $(".iframe7").colorbox({ iframe: true, width: "90%", height: "90%" });
            });
        </script>

	</head>
	<body id="landing">
	
		<div id="page-wrapper">

		<!-- Header -->
        <!--#include virtual="menu.html" -->

<!--<form class="contact_formdos" action="#" method="post" name="form">-->

<form id="frmPrincipal" runat="server" class="contact_formdos" action="index.aspx" method="post" name="form">   
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:HiddenField ID="hdfCadena" runat="server" Value="0" />
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
            <asp:HiddenField ID="hdfTipoViaje" runat="server" Value="0" />
            <asp:HiddenField ID="hdfEmail" runat="server" Value="0" />
            <asp:HiddenField ID="hdfOpcion" runat="server" Value="OK"/>

			<!-- Banner -->
				<section id="banner">
					<h2>Comparar, la libertad de elegir mejor tu seguro de viaje</h2>
					<h3>Para aquellas personas que prefieren viajar sin preocupaciones</h3>
					
                    
                    <!--inicio-->

                    <script type="text/javascript">
                        function ponevisible1() {

                            document.getElementById("nuevo-form-b").style.display = "block";
                            document.getElementById("boton-form-a").style.display = "none";
                            document.getElementById("pasoblanco1").style.color = "#ccc";
                            document.getElementById("pasogris1").style.color = "#fff";
                        }
                        function ponevisible2(opcion) {

                            document.getElementById("hdfOrigen").value = document.getElementById("ddlOrigen").value;
                            document.getElementById("hdfDestino").value = document.getElementById("ddlDestino").value;
                            document.getElementById("hdfFechaDesde").value = document.getElementById("datepicker").value;
                            document.getElementById("hdfFechaHasta").value = document.getElementById("datepicker2").value;
                            document.getElementById("hdfEdad1").value = document.getElementById("txtEdad1").value;
                            document.getElementById("hdfEdad2").value = document.getElementById("txtEdad2").value;
                            document.getElementById("hdfEdad3").value = document.getElementById("txtEdad3").value;
                            document.getElementById("hdfEdad4").value = document.getElementById("txtEdad4").value;
                            document.getElementById("hdfEdad5").value = document.getElementById("txtEdad5").value;
                            document.getElementById("hdfEdad6").value = document.getElementById("txtEdad6").value;
                            document.getElementById("hdfEmail").value = document.getElementById("txtEmail").value;
                            document.getElementById("hdfTipoViaje").value = '1';
                            document.getElementById("hdfOpcion").value = opcion.toString();
                            document.getElementById("hdfCadena").value = document.getElementById("hdfOrigen").value + "_" + document.getElementById("hdfDestino").value + "_" + document.getElementById("hdfFechaDesde").value + "_" + document.getElementById("hdfFechaHasta").value + "_" + document.getElementById("hdfEdad1").value + "_" + document.getElementById("hdfEdad2").value + "_" + document.getElementById("hdfEdad3").value + "_" + document.getElementById("hdfEdad4").value + "_" + document.getElementById("hdfEdad5").value + "_" + document.getElementById("hdfEdad6").value + "_" + document.getElementById("hdfEmail").value + "_" + document.getElementById("hdfTipoViaje").value;

                            //document.getElementById("quote-form-a").style.display="block";				
                            //document.getElementById("nuevo-form-b").style.display="none";
                            //document.getElementById("pasoblanco1").style.color="#eee";
                            //document.getElementById("pasogris1").style.color="#fff";
                        }
                        function seleczona() {
                            switch (document.getElementById("ddlDestino").value) {
                                case "1": case "":

                                    document.body.id = "landing";
                                    break;
                                case "2":
                                    document.body.id = "landing2";
                                    break;
                                case "3":
                                    document.body.id = "landing3";
                                    break;
                                case "4":
                                    document.body.id = "landing4";
                                    break;
                                case "5":
                                    document.body.id = "landing5";
                                    break;
                                case "6":
                                    document.body.id = "landing6";
                                    break;
                            }

                        }
					</script>
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
                    
                    <div class="inner" >
                    <div class="innerbox">
					<div id="quote-form-a" style="display:block">
					<div class="row uniform 50%">
					<!-- STARTS destination group-->
					<div class="destination">
					<div class="controls select-wrapper origen">
					<asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                            <asp:DropDownList ID="ddlOrigen" runat="server" 
                                    class="quoteForm form-control js-focusfix" name="quote[destination]" 
                                    data-placeholder="ORIGEN: " 
                                    onselectedindexchanged="ddlOrigen_SelectedIndexChanged" tabindex="1"  required="required"></asp:DropDownList>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="ddlOrigen" EventName="SelectedIndexChanged"/>
                        </Triggers>
                    </asp:UpdatePanel></div>
                    </div>


					<div class="destination">
					<div class="controls select-wrapper destino" >
					<asp:UpdatePanel ID="UpdatePanel2" runat="server">
                         <ContentTemplate>
                                <asp:DropDownList ID="ddlDestino" runat="server" 
                                    class="" name="quote[destination]" 
                                    data-placeholder="DESTINO: " 
                                    onselectedindexchanged="ddlDestino_SelectedIndexChanged" tabindex="2" onclick="seleczona();" required="required"></asp:DropDownList>
                         </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlId="ddlDestino" EventName="SelectedIndexChanged"/>
                        </Triggers>
                     </asp:UpdatePanel></div>
					</div>

   		<!-- ENDS destination group--><!-- STARTS Departure date group-->
					<div class="departure-date22">
					<div class="controls">
					<asp:TextBox id="datepicker" runat="server" class="form-control input-small quoteForm cal2" placeholder="SALIDA: " maxlength="10" size="16" type="text"  tabindex="3" autocomplete="off" title="Fecha de Salida"  required="required" name="salida"></asp:TextBox></div>
					</div>
					<!-- ENDS Departure date group-->
					<!-- STARTS Return date group-->
					<div class="return-date22">
					<div class="controls">
					<asp:TextBox id="datepicker2" runat="server" class="form-control input-small quoteForm cal2" placeholder="REGRESO: " maxlength="10" size="16" type="text" tabindex="4" autocomplete="off" title="Fecha de Regreso" required="required"></asp:TextBox></div>
                    </div>
					<!-- ENDS Return date group-->

					<div class="controls2" id="boton-form-a" style="display:block;">
					<a class="btn btn-primary btn-lg quote-form-btn-a" onclick="ponevisible1();" tabindex="5"> &nbsp;<i class="fa fa-chevron-right fa-lg">&nbsp;</i></a>   				
					</div>
</div>

<div id="nuevo-form-b" style="display: none; margin-top: 1.3em;">
<div class="row uniform 50%">
<div class="return-date">
<div class="controls"><asp:TextBox ID="txtEdad1" name="edad1" runat="server" class="edad form-control" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="6" min="1" max="99" autocomplete="off" required="required" title="Ingrese Edad" pattern="[0-9]{1,2}" ></asp:TextBox></div>
</div>
<div class="return-date">
<div class="controls"><asp:TextBox ID="txtEdad2" name="edad2" runat="server" class="edad form-control" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="7" min="1" max="99" autocomplete="off"  title="Ingrese Edad" pattern="[0-9]{1,2}"  ></asp:TextBox></div>
</div>
<div class="return-date">
<div class="controls"><asp:TextBox ID="txtEdad3" name="edad3" runat="server" class="edad form-control" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="8" min="1" max="99" autocomplete="off"  title="Ingrese Edad" pattern="[0-9]{1,2}"  ></asp:TextBox></div>
</div>
<div class="return-date">
<div class="controls"><asp:TextBox ID="txtEdad4" name="edad4" runat="server" class="edad form-control" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="9" min="1" max="99" autocomplete="off"  title="Ingrese Edad" pattern="[0-9]{1,2}"  ></asp:TextBox></div>
</div>
<div class="return-date">
<div class="controls"><asp:TextBox ID="txtEdad5" name="edad5" runat="server" class="edad form-control" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="10" min="1" max="99" autocomplete="off" title="Ingrese Edad" pattern="[0-9]{1,2}"  ></asp:TextBox></div>
</div>
<div class="return-date">
<div class="controls"><asp:TextBox ID="txtEdad6" name="edad6" runat="server" class="edad form-control" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="11" min="1" max="99" autocomplete="off" title="Ingrese Edad" pattern="[0-9]{1,2}"  ></asp:TextBox></div>
</div>
<div class="return-date">
<div class="controlsm mailindex"><asp:TextBox ID="txtEmail" runat="server" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Tu e-mail" type="email" tabindex="12"  autocomplete="off"  title="Ingrese mail"  size="24" required="requerid"></asp:TextBox></div>
</div>
<!-- ENDS Return date group-->
<div class="controls2">
 <button class="2btn2 btn-primary btn-lg "  onclick="ponevisible2('buscar');" type="submit">COTIZAR <i class="fa fa-chevron-right fa-lg">&nbsp;</i></button>
</div>
</div>
</div>
</div>
</div>
</div>

<!--BOTON PASO 1 Y PASO 2-->

<div class="form-control align_center pasos"> 
<div id="pasoblanco1" class="pasoblanco" style="color:#fff;">PASO 1 <i class="fa fa-angle-right"></i> VIAJE</div> &nbsp;&nbsp; | &nbsp;&nbsp;
<div id="pasogris1" class="pasogris" style="color:#bbb;">PASO 2 <i class="fa fa-angle-right"></i> VIAJEROS</div></div> 

</section>
</form>
					<div style="margin-top:0em;">
								<script type="text/javascript">
						            $(document).ready(function(){
						          	$('.bxslider,.bxslider2').bxSlider({
							            minSlides: 2,
							            maxSlides: 10,
							            slideWidth: 100,
							            slideMargin: 10,
							            auto: true,
						          		});
						            });
						          </script>
				            <ul class="bxslider">
				              <li><img src="images/logos/1.jpg"></li>
				              <li><img src="images/logos/2.jpg"></li>
				              <li><img src="images/logos/3.jpg"></li>
				              <li><img src="images/logos/4.jpg"></li>
				              <li><img src="images/logos/7.jpg"></li>
				              <li><img src="images/logos/8.jpg"></li>
				              <li><img src="images/logos/9.jpg"></li>
				              <li><img src="images/logos/11.jpg"></li>
				              <li><img src="images/logos/14.jpg"></li>
				              <li><img src="images/logos/15.jpg"></li>
				              <li><img src="images/logos/16.jpg"></li>
				              <li><img src="images/logos/17.jpg"></li>
				              <li><img src="images/logos/18.jpg"></li>
				              <li><img src="images/logos/19.jpg"></li>
				              <li><img src="images/logos/20.jpg"></li>
				            </ul>
				    </div>


<!-- One -->
				<section id="one" class="spotlightpago style1 color3">


				<div style="margin-top:3em;">
								
				            <ul class="bxslider2">
				              <li><img src="images/logos/in-visa.jpg"></li>
				              <li><img src="images/logos/in-master.jpg"></li>
				              <li><img src="images/logos/in-american.jpg"></li>
				              <li><img src="images/logos/in-naranja.jpg"></li>
				              <li><img src="images/logos/in-nativa.jpg"></li>
				              <li><img src="images/logos/in-shopping.jpg"></li>
				              <li><img src="images/logos/in-cencosud.jpg"></li>
				              <li><img src="images/logos/in-cabal.jpg"></li>
				              <li><img src="images/logos/in-argencard.jpg"></li>
				              <li><img src="images/logos/in-mp.jpg"></li>
				              <li><img src="images/logos/in-paypal.jpg"></li>
				              <li><img src="images/logos/in-bitcoin.jpg"></li>
				              
				            </ul>
				    </div>
				
					<a href="#two" class="goto-next scrolly">Next</a>
					
				</section>
				<section class="color3">.</section>
				
			 <!--Two -->
				<section id="two" class="spotlight style2 left color55">
					
					<div class="content fcolor1">
					<div class="center" style="width:50%;float: left">
					<h2> <i class="fa fa-map-marker fcolor1"></i> Sitio 100% seguro</h2>
                       <div class="left" style="margin-left:30%;">
						<p><i class="fa fa-check"></i> Certificado de Seguridad 256 SSL Certified</p>
						<p><i class="fa fa-check"></i> Su información personal encriptada</p>
						<p><i class="fa fa-check"></i> Integración con Plataformas de Pago</p>
						</div>
						</div>
						<div class="center" style="width:50%; float: right"><img src="images/secure-x2.png"/></div>
			
					</div>
					<a href="#three" class="goto-next scrolly">Next</a>
				</section>

			<!-- Three -->
				<section id="three" class="spotlight style3 left color8" >
					<span class="image fit main bottom"></span>
					<div class="content fcolor2 center">
						<div style="width:100%;float: left">
						<h2><i class="fa fa-xs fa-map-marker"></i> ¿Por que elegirnos?</h2>
						
						<ul class="porque">
							<li><i class="fa fa-check"></i> Management con mas de 20 años de experiencia en el mercado</li>
							<li><i class="fa fa-check"></i> Productos, Servicios y Beneficios exclusivos</li>
							<li><i class="fa fa-check"></i> Selección de Prestadores.  Solo trabajamos con compañías líderes en el mundo</li>
							<li><i class="fa fa-check"></i> El mejor servicio post venta</li>
							<li><i class="fa fa-check"></i> Pasión y Perfección en nuestra tarea diaria</li>
							</ul>
						</div>
					</div>


					<a href="#four" class="goto-next scrolly">Next</a>
				</section>

			<!-- Four -->
					
			<section id="four" class="spotlight style4 left color4" >
					<div class="content fcolor3 center">

          <h2><i class="fa fa-map-marker"></i> Garantía de mejor oferta</h2>
					<div class="" style="width:50%;float: left">
          <img src="images/garantizado-mejor-precio.png"  alt="" />
					</div>

						<div class="center" style="width:50%; float: right">
						<img src="images/garantizado-mejor-servicio.png"  alt="" />
            </div>
					
					</div>
					<a href="#five" class="goto-next scrolly">Next</a>
					
				</section>

				<!-- five -->
				<section id="five" class="spotlight style5 left color6">
					<div class="content fcolor4 center">
						<h2><i class="fa fa-map-marker"></i> Seguro de Viaje obligatorio</h2>
						<ul class="obligatorio" >
						<li><a href="seguro-de-viaje-obligatorio.aspx"><img src="images/seguro-europa.png"  alt="Seguro de Viaje Schengen" /><br> <i class="icon fa-angle-right"></i> Seguro de Viaje Schengen</a></li>
						<li><a href="seguro-de-viaje-obligatorio.aspx"><img src="images/seguro-usa.png"  alt="Seguro de Viaje a USA y Canada" /><br><i class="icon fa-angle-right"></i> Seguro de Viaje a USA y Canada</a><li>
						<li><a href="seguro-de-viaje-obligatorio.aspx"><img src="images/seguro-puertorico.png"  alt="Seguro de Viaje a Cuba" /><br><i class="icon fa-angle-right"></i> Seguro de Viaje a Cuba</a></li>
						</ul>


						
					</div>
					<a href="#six" class="goto-next scrolly">Next</a>
				</section>
				<!-- six -->

				<section id="six" class="spotlight style6 left color5" >
					
						<div class="content fcolor5 center">
						<h2><i class="fa fa-map-marker"></i> Tipos de Seguros de Viaje</h2>
						
					<div class="fglobos">
						<a href="coberturas.aspx" title="Embarazadas"><i class="fa ico-2 icon-ico-embarazada"></i> Embarazadas</a>
						<a href="coberturas.aspx" title="Tercera Edad"><i class="fa ico-2 icon-ico-terceraedad"></i> Tercera Edad</a>
						<a href="coberturas.aspx" title="Cruceros"><i class="fa ico-2 icon-ico-cruceros"></i> Cruceros</a>
						<a href="coberturas.aspx" title="Seguro para Valijas"><i class="fa ico-2 icon-ico-valijas"></i> Seguro para Valijas </a>	
						<a href="coberturas.aspx" title="Seguro para Objetos Personales"><i class="fa ico-2 icon-ico-objetos"></i> Seguro para Objetos Personales</a>
						<a href="coberturas.aspx" title="Deportes"><i class="fa ico-2 icon-ico-deportes"></i> Deportes</a>	<br>
						<a href="coberturas.aspx" title="Enfermedades Preexistentes"><i class="fa ico-2 icon-ico-preexistente"></i> Enfermedades Preexistentes</a>
						<a href="coberturas.aspx" title="Mochileros/Bagpackers"><i class="fa ico-2 icon-ico-mochileros"></i> Mochileros/Bagpackers</a>
						<a href="coberturas.aspx" title="Intercambios, becas, pasantias, estudios"><i class="fa ico-2 icon-ico-intercambios"></i> Intercambios, becas, pasantias, estudios</a>	
						<a href="coberturas.aspx" title="Grupos"><i class="fa ico-2 icon-ico-grupo"></i> Grupos</a>
					</div>

						
						</div>
					<a href="#seven" class="goto-next scrolly">Next</a>
				</section>
               

   <!--#include virtual="pie1.html" -->

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

					<!-- Scripts -->
			<script src="assets/js/jquery.dropotron.min.js"></script>
			<script src="assets/js/jquery.scrollgress.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]
			<script src="assets/js/main.js"></script>-->
			<script src="11/assets/js/main.js"></script>
			<script src="11/assets/js/jquery.scrollex.min.js"></script>
			<script src="11/assets/js/jquery.scrolly.min.js"></script>

			<script src="assets/js/jquery.scrolly.min.js"></script>
			<script src="assets/js/jquery.dropotron.min.js"></script>
			<script src="assets/js/jquery.scrollex.min.js"></script>
            <!-- begin olark code -->
               <!--#include virtual="chat.html" -->   
            <!-- end olark code -->
	</body>
</html>