<?
	 $accion=$_GET["accion"];
	 if($accion=="enviar"){
		
		 $message_name=$_POST["message_name"];
		 $message_email=$_POST["message_email"];
		 $message_message=$_POST["message_message"];
			  $html = "Nuevo Contacto - N2 \n";
	
			  $html .= "Nombre: $message_name \n";
			  $html .= "E-mail : $message_email \n";
			  $html .= "Mensaje : $message_message \n";
			  $asunto="Nuevo Contacto - NITRO2 \n";
			  $headers = "From: presupuesto@nitro2.com.ar \n";
			mail("presupuesto@nitro2.com.ar",$asunto,$html,$headers); 
		  	//header("Location:gracias.html");
			//echo $html;
			}  ?>
<!DOCTYPE html>
<html lang="es">
    <head>
        <meta charset="utf-8">
        <title>Dise&ntilde;o paginas web en San Juan,  NITRO2 agencia creativa, presupuesto</title>
        <meta content="width=device-width, initial-scale=1.0" name="viewport">
        
<meta name="description" content="agencia de publicidad Dise&ntilde;o web en San Juan y dise&ntilde;o web en Argentina, servicios web, posicionamiento y e-commerce. Desarrollo web de portales y sitios web corporativos." />
<meta name="keywords" content="Dise&ntilde;o Paginas web, san juan, presupuesto, programacion PHP, comercio electronico, dise&ntilde;o base de datos, agencia de publicidad, marketing, sanjuan, aplicaciones web y movil,tiendas online,campa&ntilde;a marleting, puntos de venta, adwords,posicionamiento,seo, sem, diseño y creacion de Logotipos,Optimizacion,redes sociales,social media manager,mantenimiento" />

  <meta name="author" content="NITRO2 dise&ntilde;o web" />
         
        <!-- Bootstrap  -->
        <link href="css/bootstrap.css" rel="stylesheet">
        <!-- Font Awesome  -->
        <link href="css/font-awesome.min.css" rel="stylesheet">
        <!-- Revolution Responsive jQuery Slider -->
        <link rel="stylesheet" type="text/css" href="css/settings.css" media="screen" />
        <!-- Landlr Style -->
        <link href="css/colors.css" rel="stylesheet">
        <link href="css/style.css" rel="stylesheet">
        <link href="css/responsive.css" rel="stylesheet"> 
        
        <!-- Favicon and touch icons  -->
        <link href="ico/apple-touch-icon-144-precomposed.png" rel="apple-touch-icon-precomposed" sizes="144x144">
        <link href="ico/apple-touch-icon-114-precomposed.png" rel="apple-touch-icon-precomposed" sizes="114x114">
        <link href="ico/apple-touch-icon-72-precomposed.png" rel="apple-touch-icon-precomposed" sizes="72x72">
        <link href="ico/apple-touch-icon-57-precomposed.png" rel="apple-touch-icon-precomposed">
        <link href="ico/favicon.png" rel="shortcut icon">
        
        <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
        <!--[if lt IE 9]>
      	<script src="js/html5shiv.js"></script>
    	<![endif]-->
    	

    </head>
    <body class="page-aqua">
    
		<div id="back">

		</div>
		<!-- Navigation -->
		<header>
			<div class="navbar navbar-fixed-top">
				<div class="navbar-inner">
					<div class="container">
						<button type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
						</button>
						<a class="brand" href="index.php" title="NITRO2"><img src="images/nitro2.png" alt="NITRO2 dise&ntilde;o web"></a>
						<div class="nav-collapse collapse">
							<ul class="nav pull-right">
								<li><a href="#row1" title="Inicio">Inicio</a></li>
								<li><a href="#row2" title="Trabajos">Trabajos</a></li>
								<li><a href="#row3" title="Servicios">Servicios</a></li>
								<li><a href="#row4" title="Marketing Online">Marketing Online</a></li>
								<li><a href="#row7" title="Contacto">Contacto</a></li>
							</ul>
						</div>
					</div>
				</div>
			</div><!-- .navbar -->
		</header>
		
		<!-- Home -->
		<section class="wrapper home">
			<a class="anchor" id="row1"></a>
			<div class="container">
				<div class="row">
					<div class="span12 text-center">
						<hgroup class="main-title white">
							<h2>Somos una Agencia Creativa</h2>
							<h3>ESPECIALISTAS EN DISE&Ntilde;O DE PAGINAS WEB, SOCIAL MEDIA Y BRANDING</h3>
						</hgroup>
						<a class="btn btn-large btn-tomato uppercase" href="#row7" title="Solicitar presupuesto">Solicitar Presupuesto</a>
						
					</div>
				</div>
			</div>
		</section>
		
		<!-- Project -->
		<section class="wrapper bg-turquoise colored">
			<a class="anchor" id="row2"></a>
			<div class="container">
				<div class="row">
					<div class="span12 text-center">
						<hgroup>
							<h2>NUESTROS TRABAJOS</h2>
						</hgroup>
					</div>
				</div>
                
                <div class="bannercontainer" >
					<div class="banner" >
						<ul>
							<!-- THE FIRST SLIDE -->

							<!-- THE SECOND SLIDE -->
						  <li data-transition="papercut" data-slotamount="15" data-masterspeed="300" data-link="#row7" data-target="_blank" data-delay="13400" data-thumb="images/thumbs/thumb2.jpg">
										<img src="images/slides/sli17.jpg" alt="Paginas web personalizadas">

										<div class="caption very_big_white lfl stl"
											 data-x="18"
											 data-y="173"
											 data-speed="300"
											 data-start="500"
											 data-easing="easeOutExpo" data-end="13500" data-endspeed="300" data-endeasing="easeInSine" ><h4>DISE&Ntilde;O WEB PERSONALIZADO</h4></div>

										<div class="caption big_white lfl stl text-info"
											 data-x="18"
											 data-y="213"
											 data-speed="300"
											 data-start="800"
											 data-easing="easeOutExpo" data-end="13700" data-endspeed="300" data-endeasing="easeInSine" ><h5>	Dise&ntilde;o y desarrollo de sitios web sitios institucionales <br>
                                             y de comercio electr&oacute;nico</h5></div>

										<div class="caption lft ltb"
											 data-x="500"
											 data-y="20"
											 data-speed="600"
											 data-start="1100"
											 data-easing="easeOutExpo" data-end="3100" data-endspeed="600" data-endeasing="easeInSine" ><img src="images/slides/hoteldelbono-san-juan.jpg" alt="Image 3"></div>

										<div class="caption big_black sft stb"
											 data-x="447"
											 data-y="286"
											 data-speed="300"
											 data-start="1400"
											 data-easing="easeOutExpo" data-end="3300" data-endspeed="300" data-endeasing="easeInSine" ><h3>DELBONO HOTELS <br>
SAN JUAN, ARGENTINA</h3></div>
										<div class="caption lft ltb"
											 data-x="500"
											 data-y="20"
											 data-speed="600"
											 data-start="3600"
											 data-easing="easeOutExpo" data-end="5600" data-endspeed="600" data-endeasing="easeInSine" ><img src="images/slides/massanassa-club-de-futbol.jpg" alt="Image 4"></div>
							<div class="caption big_black sft stb"
											 data-x="447"
											 data-y="286"
											 data-speed="300"
											 data-start="3900"
											 data-easing="easeOutExpo" data-end="5800" data-endspeed="300" data-endeasing="easeInSine" ><h4>MASSANASSA CLUB DE FUTBOL<br>
VALENCIA, ESPA&Ntilde;A</h4></div>

										

							<div class="caption lft ltb"
											 data-x="500"
											 data-y="20"
											 data-speed="600"
											 data-start="6100"
											 data-easing="easeOutExpo" data-end="8100" data-endspeed="300" data-endeasing="easeInSine" ><img src="images/slides/fraser-impresores-de-publicidad2.jpg" alt="Image 5"></div>

										<!--<div class="caption big_black sft stb white"
											 data-x="447"
											 data-y="286"
											 data-speed="300"
											 data-start="6400"
											 data-easing="easeOutExpo" data-end="8300" data-endspeed="300" data-endeasing="easeInSine" ><h4>FRASER<br>
VALENCIA, ESPA&Ntilde;A</h4></div>

										<div class="caption lft ltb"
											 data-x="500"
											 data-y="20"
											 data-speed="600"
											 data-start="6100"
											 data-easing="easeOutExpo" data-end="8100" data-endspeed="300" data-endeasing="easeInSine" ><img src="images/slides/fraser-impresores-de-publicidad2.jpg" alt="Image 6"></div>-->

							<div class="caption big_black sft stb white"
											 data-x="447"
											 data-y="286"
											 data-speed="300"
											 data-start="6400"
											 data-easing="easeOutExpo" data-end="8300" data-endspeed="300" data-endeasing="easeInSine" ><h4>FRASER<br>
VALENCIA, ESPA&Ntilde;A</h4></div>


										<div class="caption lft ltb"
											 data-x="500"
											 data-y="20"
											 data-speed="600"
											 data-start="8600"
											 data-easing="easeOutExpo" data-end="10600" data-endspeed="300" data-endeasing="easeInSine" ><img src="images/slides/saur-technologies2.jpg" alt="Image 7"></div>

							<div class="caption big_black sft stb white"
											 data-x="447"
											 data-y="286"
											 data-speed="300"
											 data-start="8600"
											 data-easing="easeOutExpo" data-end="10900" data-endspeed="300" data-endeasing="easeInSine" ><h4>SAURTECHNOLOGIES<br>
VALENCIA, ESPA&Ntilde;A</h4></div>


										<div class="caption lft ltb"
											 data-x="500"
											 data-y="20"
											 data-speed="600"
											 data-start="11200"
											 data-easing="easeOutExpo" data-end="13200" data-endspeed="300" data-endeasing="easeInSine" ><img src="images/slides/bolsa-de-comercio-san-juan.jpg" alt="Image 8"></div>

							<div class="caption big_black sft stb white"
											 data-x="447"
											 data-y="286"
											 data-speed="300"
											 data-start="11200"
											 data-easing="easeOutExpo" data-end="13400" data-endspeed="300" data-endeasing="easeInSine" ><h4>BOLSA DE COMERCIO DE SAN JUAN<br>
SAN JUAN, ARGENTINA</h4></div>
										
						  </li>
										

							
							

							<!-- THE FOURTH SLIDE -->
							<li data-transition="slideleft" data-slotamount="1" data-masterspeed="300" data-thumb="images/thumbs/thumb5.jpg">

							  <img src="images/slides/sli152.jpg">

									<div class="caption large_text sft"
										 data-x="50"
										 data-y="44"
										 data-speed="300"
										 data-start="800"
										 data-easing="easeOutExpo"><h4>DISE&Ntilde;O ADAPTABLE</h4></div>

									<div class="caption medium_text sfl"
										 data-x="79"
										 data-y="82"
										 data-speed="300"
										 data-start="1100"
										 data-easing="easeOutExpo"><h4>A</h4></div>

									<div class="caption large_text sfr"
										 data-x="128"
										 data-y="82"
										 data-speed="300"
										 data-start="1100"
										 data-easing="easeOutExpo"><h2><span style="color: #ffc600;">TODOS LOS DISPOSITIVOS MOVILES</span></h2></div>

									<div class="caption lfl"
										 data-x="233"
										 data-y="152"
										 data-speed="300"
										 data-start="1400"
										 data-easing="easeOutExpo"><img src="images/slides/bolsa-de-comercio-san-juan.jpg" alt="Image 4"></div>

									<div class="caption lfl"
										 data-x="473"
										 data-y="215"
										 data-speed="300"
										 data-start="1500"
										 data-easing="easeOutExpo"><img src="images/slides/ipad.jpg" alt="Image 5"></div>

									<div class="caption lfl"
										 data-x="592"
										 data-y="245"
										 data-speed="300"
										 data-start="1600"
										 data-easing="easeOutExpo"><img src="images/slides/iphone.jpg" alt="Image 6"></div>
							</li>


							<!-- THE FIFTH SLIDE -->
							<li data-transition="flyin" data-slotamount="1" data-masterspeed="300" data-thumb="images/thumbs/thumb6.jpg">
									<img src="images/slides/sli19.jpg" >

									<div class="caption large_text sft bg-tomato"
										 data-x="38"
										 data-y="200"
										 data-speed="300"
										 data-start="1000"
										 data-easing="easeOutExpo"><h4>Online Advertising</h4>
</div>

									<div class="caption bg-turquoise sfl"
										 data-x="37"
										 data-y="243"
										 data-speed="300"
										 data-start="1300"
										 data-easing="easeOutExpo">ASESORAMIENTO INTEGRAL DE ESTRATEGIAS
EN MEDIOS DIGITALES</div>

									<div class="caption randomrotate"
										 data-x="610"
										 data-y="20"
										 data-speed="800"
										 data-start="1600"
										 data-easing="easeOutExpo"><img src="images/slides/shop.png" alt="Image 4"></div>
							</li>
						</ul>

						<div class="tp-bannertimer tp-bottom"></div>
					</div>
				</div>

			<!--
			##############################
			 - ACTIVATE THE BANNER HERE -
			##############################
			-->
			<script type="text/javascript">

				var tpj=jQuery;
				tpj.noConflict();

				tpj(document).ready(function() {

				if (tpj.fn.cssOriginal!=undefined)
					tpj.fn.css = tpj.fn.cssOriginal;

					tpj('.banner').revolution(
						{
							delay:13400,
							startheight:450,
							startwidth:960,


							hideThumbs:200,

							thumbWidth:100,							// Thumb With and Height and Amount (only if navigation Tyope set to thumb !)
							thumbHeight:50,
							thumbAmount:5,

							navigationType:"bullet",				// bullet, thumb, none
							navigationArrows:"nexttobullets",				// nexttobullets, solo (old name verticalcentered), none

							navigationStyle:"navbar",				// round,square,navbar,round-old,square-old,navbar-old, or any from the list in the docu (choose between 50+ different item), custom


							navigationHAlign:"center",				// Vertical Align top,center,bottom
							navigationVAlign:"bottom",					// Horizontal Align left,center,right
							navigationHOffset:0,
							navigationVOffset:20,

							soloArrowLeftHalign:"left",
							soloArrowLeftValign:"center",
							soloArrowLeftHOffset:20,
							soloArrowLeftVOffset:0,

							soloArrowRightHalign:"right",
							soloArrowRightValign:"center",
							soloArrowRightHOffset:20,
							soloArrowRightVOffset:0,

							touchenabled:"on",						// Enable Swipe Function : on/off
							onHoverStop:"on",						// Stop Banner Timet at Hover on Slide on/off

							stopAtSlide:-1,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
							stopAfterLoops:-1,						// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic

							hideCaptionAtLimit:0,					// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
							hideAllCaptionAtLilmit:0,				// Hide all The Captions if Width of Browser is less then this value
							hideSliderAtLimit:0,					// Hide the whole slider, and stop also functions if Width of Browser is less than this value

							shadow:1,								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows  (No Shadow in Fullwidth Version !)
							fullWidth:"on"							// Turns On or Off the Fullwidth Image Centering in FullWidth Modus


						});



					});

			</script>
				
				<!-- Slider -->	
				<!-- .bannercontainer -->
			</div>
		</section>
		
		<!-- Features -->
		<section class="wrapper bg-white">
			<a class="anchor" id="row3"></a>
			<div class="container">
				<div class="row">
					<div class="span12 text-center mar-b30">
						<hgroup>
							<h2>NUESTROS SERVICIOS</h2>
							<h3>Nuestro objetivo es generar y producir ideas que mejoren los resultados de las marcas a traves del medio interactivo.</h3>
						</hgroup>
					</div>
				</div>
				<div class="row">
					<div class="span4">
						<div class="row-fluid">
							<div class="span2">
								<i class="icon-search icon-3x"></i>
                                
							</div>
							<div class="span9">
								<h3>&iquest;QUE LE OFRECEMOS?</h3>
<p>NITRO2 es una agencia creativa en la cual nos encargamos de dar toda la cobertura de servicios de marketing de principio a fin en cada proyecto, mediante la realizaci&oacute;n de un estudio previo para asesorar, dise&ntilde;ar y desarrollo de la campa&ntilde;a y finalmente la implementaci&oacute;n en los medios, formatos y &aacute;mbitos id&oacute;neos para encontrar tus clientes.</p>
<p>Somos expertos en dise&ntilde;o y programaci&oacute;n de un amplio abanico de aplicaciones digitales, desde webs corporativas hasta complejos sistemas de gesti&oacute;n en l&iacute;nea. Tambi&eacute;n ofrecemos consultor&iacute;a tecnol&oacute;gica con el objetivo de que las empresas se puedan beneficiar de las principales ventajas de las nuevas tecnolog&iacute;as.</p>
<p>Dise&ntilde;o de productos interactivos, marketing en l&iacute;nea o redacci&oacute;n de contenidos, posicionamiento y mantenimiento web son otros de los servicios que ofrecemos desde NITRO2.</p>
<p>Nos caracterizamos por ofrecer un servicio integral y de calidad durante todo el proceso de desarrollo del proyecto</p>
							</div>
						</div>
					</div>
                    <div class="span4">
						<div class="row-fluid">
							<div class="span2">
								<i class="icon-laptop icon-3x"></i>
							</div>
							<div class="span9">
								<h3>EXPERIENCIA</h3>
<p>Nuestros profesionales llevan desarrollando desde que naci&oacute; la web.</p>

<strong>EFICACIA</strong>
<p>Hacemos crecer su negocio abriendo nuevas posibilidades en internet.</p>

<strong>DISE&Ntilde;O ORIGINAL</strong>
<p>Dise&ntilde;os profesionales y 100% originales, no utilizamos plantillas.</p>

<strong>PRECIOS</strong>
<p>Pregunte por nuestros precios y seguro que se sorprente gratamente.</p>

<strong>PRESUPUESTO DISE&Ntilde;O WEB</strong>
<p>Al igual que cada proyecto, cada presupuesto es &uacute;nico. NITRO2 le ofrecer&aacute; siempre la mejor relaci&oacute;n calidad-precio.</p>
							</div>
						</div>
					</div>
					<div class="span4">
						<div class="row-fluid">
							<div class="span2">
								<i class="icon-rocket icon-3x"></i>
							</div>
							<div class="span9 text-left">
								<h3>NUESTROS SERVICIOS</h3>
<ul>
<li>Dise&ntilde;o y programaci&oacute;n de sitios web</li>
<li>Estrategia digital: an&aacute;lisis de mercado, plan de marketing online</li>
<li>Websites din&aacute;micos, microsites, sitios para promociones</li>
<li>Creatividad e implementaci&oacute;n de Banners & Landing Pages</li>
<li>E-mail Marketing</li>
<li>Marketing en buscadores y Optimizaci&oacute;n de contenidos SEM / SEO</li>
<li>Social Media</li>
<li>Aplicaciones para Facebook</li>
<li>Posicionamiento web en buscadores</li>
<li>Traducci&oacute;n de p&aacute;ginas web</li>
<li>Interfaz m&oacute;vil y dise&ntilde;o de respuesta</li>
<li>SMS Masivos para Empresas, Env&iacute;a y recibe SMS</li>
<li>Arquitectura comercial</li>
<li>Dise&ntilde;o y armado de stands</li>
<li>Exhibidores y puntos de venta</li>
<li>Ambientacion de eventos</li>
<li>Showrooms, locales comerciales y oficinas</li>
</ul>
							</div>
						</div>
					</div>
					
				</div>
			</div>
		</section>		
		
		<!-- Specifications -->
		<section class="wrapper bg-turquoise colored">
			<a class="anchor" id="row4"></a>
			<div class="container">
				<div class="row">
					<div class="span12 text-center">
						<h2>MARKETING ONLINE</h2>
						<h3>En NITRO2 tenemos como principal prop&oacute;sito brindar soluciones a las necesidades de comunicaci&oacute;n de nuestros clientes.</h3>
					</div>
				</div>
				<div class="tabbable row mar-t30">
					<ul class="nav nav-tabs nav-stacked span3">
						<li class="active"><a href="#tab1" data-toggle="tab">SEM</a></li>
						<li><a href="#tab2" data-toggle="tab">DISPLAY ADVERTISING</a></li>
						<li><a href="#tab3" data-toggle="tab">SOCIAL MEDIA</a></li>
						<li><a href="#tab4" data-toggle="tab">INTERACTIVE SOLUTIONS</a></li>
                        <li><a href="#tab5" data-toggle="tab">SEO</a></li>
                        <li><a href="#tab6" data-toggle="tab">YOUTUBE</a></li>
					</ul>
	  				<div class="tab-content span9">
		                <div class="tab-pane active fade in" id="tab1">
							<div class="row-fluid">
								<div class="span7">
									<div class="row-fluid">
										
										<div class="span12">
											<h4>SEM - SEARCH ENGINE MARKETING</h4>
											<p>El buscador de Google funciona como una plataforma de comunicaci&oacute;n eficiente, donde un clic en un anuncio representa a un usuario interesado en un servicio o producto.</p>
                                            <p>Nuestro servicio se basa en un asesoramiento que recomienda al cliente la mejor manera de incursionar en el uso de esta herramienta. Posteriormente, con equipos dedicados, nos ocupamos de desarrollar, gestionar y optimizar la campa&ntilde;a para alcanzar los objetivos planteados en un inicio.</p>
                                            <p>Google AdWords: publicidad en l&iacute;nea con la tecnolog&iacute;a de Google</p>
                                            <a class="btn btn-large btn-tomato uppercase" href="#row7">Asesoramiento en AdWords</a>
										</div>
									</div>
								</div>
								<div class="span5">
									<div class="row-fluid">
										<img class="img-polaroid" src="images/sem-san-juan.jpg" alt="image" />
									</div>
								</div>
							</div>
							
		                </div><!-- .tab-pane -->
						<div class="tab-pane fade" id="tab2">
							<div class="row-fluid">
								<div class="span7">
									<div class="row-fluid">
										
										<div class="span12">
											<h4>DISPLAY ADVERTISING</h4>
											<p>Display Advertising permite atraer la atenci&oacute;n de los usuarios con banners atractivos (en algunos casos con animaci&oacute;n, audio y video) llegando a ellos en miles de sitios logrando as&iacute; una gran cobertura e interacci&oacute;n con la marca, el servicio o el producto publicitado.</p>

<p>Adicionalmente a los portales tradicionales, existen redes de sitios con contenidos segmentados para diversos p&uacute;blicos, que permiten llegar a audiencias objetivo definidas de forma masiva, cuando persiguen sus intereses al navegar.</p>

<p>En NITRO2 contamos con amplia experiencia en el desarrollo e implementaci&oacute;n de campa&ntilde;as digitales orientadas a incrementar la presencia de marca o generar respuesta directa en categor&iacute;as de sitios definidos.</p>

<p>Google Display Network es una manera f&aacute;cil y efectiva de anunciar su negocio en p&aacute;ginas de Internet. La tecnolog&iacute;a de publicidad online de Google permite crear anuncios de texto, imagen y v&iacute;deo para promocionar su negocio ante clientes potenciales a trav&eacute;s de millones de p&aacute;ginas de Internet y propiedades de Google relevantes.</p>
<a class="btn btn-large btn-tomato uppercase" href="#row7">Asesoramiento en Google Display Network</a>

										</div>
									</div>
								</div>
								<div class="span5">
									<div class="row-fluid">
										<img class="img-polaroid" src="images/display-advertising-san-juan.jpg" alt="image" />
									</div>
								</div>
							</div>
						</div><!-- .tab-pane -->
						<div class="tab-pane fade" id="tab3">
							
						<div class="row-fluid">
								<div class="span7">
									<div class="row-fluid">
										
										<div class="span12">
											<h4>SOCIAL MEDIA</h4>
											<p>Una estrategia adecuada en Redes Sociales es una herramienta muy poderosa para impulsar y acompa&ntilde;ar las acciones de marketing y comunicaci&oacute;n de cualquier tipo de organizaci&oacute;n, producto o marca.</p>
<p>Como expertos en perfomance, en NITRO2 entendemos que cualquier acci&oacute;n emprendida en redes sociales debe estar orientada a resultados. Para esto integramos una serie de herramientas y m&eacute;tricas que nos permiten analizar la evoluci&oacute;n y necesidades de sus comunidades online.</p>
<p>Pinterest, Google, Facebook, Twitter, Youtube.</p>
<a class="btn btn-large btn-tomato uppercase" href="#row7">Conoc&eacute; Nuestros Servicios</a>
										</div>
									</div>
								</div>
								<div class="span5">
									<div class="row-fluid">
										<img class="img-polaroid" src="images/redes-sociales-san-juan.jpg" alt="image" />
									</div>
								</div>
							</div>	
							
						</div><!-- .tab-pane -->
						<div class="tab-pane fade" id="tab4">
							<div class="row-fluid">
								<div class="span12">
									<div class="row-fluid">
										
										<div class="span12">
											<h4>INTERACTIVE SOLUTIONS</h4>
											
                                          <div class="row-fluid"> 
                                          <div class="span8"> 
                                            <h5>APLICACIONES FACEBOOK</h5>
<p>Ofrecemos una amplia gama de soluciones a la hora de crear su campa&ntilde;a y le brindamos todas las herramientas necesarias para desarrollarla gestionarla y reportar resultados reales.</p>
<p>Desarrollamos aplicaciones interactivas y entretenidas, para redes sociales customizadas en funci&oacute;n de la necesidad de las marcas.</p>

</div>
<div class="span4">
									<img class="img-polaroid" src="images/facebook-san-juan.jpg" alt="image" />
								</div>
</div>


<h5>SITIOS Y BLOG</h5>
<p>Con apoyo en el an&aacute;lisis de bases de datos y seguimiento de conversiones, sumado a nuestra amplia experiencia en el rubro, le brindamos la mejor optimizaci&oacute;n de recursos en la implementaci&oacute;n de sus proyectos para cumplir con el desaf&iacute;o final: llegar a su p&uacute;blico objetivo.</p>

<div class="row-fluid">
<div class="span8">
<h5>APLICACIONES M&Oacute;VILES</h5>
<p>Nos especializamos en la gesti&oacute;n de la estrategia m&oacute;vil, desarrollando aplicaciones y sitios que se integran en sus campa&ntilde;as para conseguir objetivos de negocio y marca.</p>

<h5>IBRANDING</h5>
<p>Los medios digitales han cambiado la forma de hacer negocios, las empresas tienen la posibilidad de entablar un trato directo con sus clientes, identificar oportunidades y conocer el alcance real de sus campa&ntilde;as.</p>

<p>Es fundamental contar con una estrategia de branding para estar presente en las plataformas digitales, entablando relaciones a largo plazo con nuestros futuros consumidores a&uacute;n antes de haberse generado la necesidad de compra.</p>
</div>
<div class="span4"><img class="img-polaroid" src="images/aplicacion-movil-san-juan.jpg" alt="image" /></div>
</div>
<a class="btn btn-large btn-tomato uppercase" href="#row7">Conoc&eacute; Nuestros Servicios</a>
										</div>
									</div>
								</div>
								
							</div>
                            
						</div><!-- .tab-pane -->
                        
                        
                        <div class="tab-pane fade" id="tab5">
							<div class="row-fluid">
								<div class="span8">
									<div class="row-fluid">
										
										<div class="span12">
											<h4>SEO - SEARCH ENGINE OPTIMIZATION</h4>
											
<p>Es el proceso de incrementar la visibilidad de un sitio Web en los motores de b&uacute;squeda como Google, Yahoo o Bing. Este trabajo tiene como objetivo capturar tr&aacute;fico calificado para derivarlo al sitio de su empresa.</p>

<p>Luego de analizar su negocio y sus objetivos, podemos establecer en conjunto cu&aacute;les son las palabras claves para las cuales es primordial posicionarnos.</p>

<p>Creemos que la clave de todo trabajo de SEO es el correcto armado de una estrategia as&iacute; como una adecuada implementaci&oacute;n.</p>
										</div>
									</div>
								</div>
								<div class="span4"><img class="img-polaroid" src="images/seo-san-juan.jpg" alt="image" /></div>
							
                            
                            
                            
                            </div>
                            <div class="row-fluid">
                            <div class="span12">
                            <p>Es por esto que inicialmente realizamos un an&aacute;lisis de su negocio, el nicho en el que este se encuentra, los problemas que su sitio web pueda presentar as&iacute; tambi&eacute;n como la situaci&oacute;n actual de sus competidores. En base a esta informaci&oacute;n pensamos en una estrategia que aproveche toda oportunidad, maximice fortalezas al mismo tiempo que busca resolver todo punto d&eacute;bil que se detecte.</p>

<p>Para facilitar una correcta implementaci&oacute;n de la estrategia propuesta, trabajamos por medio de la entrega de una serie de documentos que cuentan con m&uacute;ltiples secciones y entregas dependiendo de la complejidad que su sitio presente.</p>

<p>Finalmente para asegurarnos que cada documento fuera correctamente implementado, se pasa a una etapa de revisi&oacute;n en la que se busca que cada punto mencionado dentro de los documentos fuera correctamente implementado asegurandonos asi que la estrategia sugerida fuera implementada correctamente.</p>
<a class="btn btn-large btn-tomato uppercase" href="#row7">Conoc&eacute; Nuestros Servicios</a>
</div>
</div>
                            
						</div><!-- .tab-pane -->
                        
                        
                        <div class="tab-pane fade" id="tab6">
							<div class="row-fluid">
								<div class="span12">
									<div class="row-fluid">
										
										<div class="span12">
											<h4>YOUTUBE</h4>
<p>YouTube se ha establecido como una soluci&oacute;n utilizada por las empresas para promover sus activos de video, ya sea generando un canal propio como tambi&eacute;n utilizando las opciones publicitarias que presenta la plataforma.</p>

<h3>Los anuncios de v&iacute;deo consiguen que la gente vea tu negocio</h3>
<h3>Presenta tu empresa de una manera &uacute;nica en el momento y lugar adecuados</h3>
										</div>
									</div>
								</div></div>
<div class="row-fluid">
<div class="span4"><img src="images/publicidad-antes2.jpg" alt="image" /></div>
<div class="span4"><img src="images/publicidad-junto.jpg" alt="image" /></div>
<div class="span4"><img src="images/publicidad-resultado-de-busqueda.jpg" alt="image" /></div>
							</div>
                            
                   <div align="center" ><p>
<a class="btn btn-large btn-tomato uppercase" href="#row7">Gesti&oacute;n anuncios de v&iacute;deo de YouTube</a></p></div>
                            
						</div><!-- .tab-pane -->
                        
                        
	    			</div>
				</div>
			</div>
		</section>
		
		<!-- Get Started -->
		<section class="wrapper mini-wrapper">
			<a class="anchor" id="row7"></a>
			<div class="container">
				<div class="row">
					<div class="span12 text-center">
						<hgroup class="main-title white">
							<h2>Presupuesto de dise&ntilde;o web en menos de 24 horas</h2>
						</hgroup>
                        
                        <div class="row-fluid">
                        <div class="span6 text-left main-title white">
                       
                        <h3>TRABAJE CON NOSOTROS</h3>

<p class="white text-left">En NITRO2 nos comprometemos a facilitarle un presupuesto detallado para su proyecto en un m&aacute;ximo de 24 horas, sabemos que el tiempo es importante para usted y no queremos que lo pierda.</p>

<p class="white text-left">Si desea un presupuesto personalizado solic&iacute;telo y en 24 horas recibir&aacute; su presupuesto. presupuesto@nitro2.com.ar
</p>
<div id="fb-root"></div>
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/es_ES/all.js#xfbml=1";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
<div class="fb-like" data-href="https://www.facebook.com/nitro2.com.ar" data-width="100" data-layout="box_count" data-show-faces="true" data-send="false"></div>
<a href="http://www.facebook.com/nitro2.com.ar" class="text-face" target="_blank"><i class="icon-facebook-sign icon-4x text-face"></i></a>
<a href="https://twitter.com/nitro2ar" class="text-tw" target="_blank"><i class="icon-twitter-sign icon-4x"></i></a>
<a href="https://plus.google.com/+Nitro2Ar" class="text-goog" target="_blank"><i class="icon-google-plus-sign icon-4x"></i></a>
<a href="http://www.linkedin.com/in/marceloabraham" class="text-lin" target="_blank"><i class="icon-linkedin-sign icon-4x"></i></a>
<a href="http://www.youtube.com/user/ArgentinaYou/" class="text-goog" target="_blank"><i class="icon-youtube-sign icon-4x"></i></a>
<a href="skype:nitro2arg?call" class="text-tw"><i class="icon-skype icon-4x"></i></a>
<a href="http://www.pinterest.com/nitro2arg/" class="text-goog" target="_blank"><i class="icon-pinterest-sign icon-4x"></i></a>

                                

</div>
<div class="span6">
<form  enctype="multipart/form-data" action="" method="post" name="form" id="form"> 
      <script type="text/javascript">
	  function enviar(){
			var foco="";
			var cadena="";
		if(cadena==""){
			document.form.action="index.php?accion=enviar";
			document.form.submit()
		}
		}
	  </script>
<div style="margin:0;padding:0;display:inline">
<input name="utf8" type="hidden" value="&#x2713;" />
<input name="authenticity_token" type="hidden" value="8kjLqR9E5Ixk54BglXdxFIEtWV5+qWjXHFBf+ydAXfo=" />
</div>
<fieldset>
<div class="white text-left" style="margin-left:50px;">Nombre</div>
<input id="message_name" name="message_name" size="30" type="text" class="span10" />
<div class="white text-left" style="margin-left:50px;">Email</div>
<input id="message_email" name="message_email" size="30" type="text" class="span10" />
<div class="white text-left" style="margin-left:50px;">Mensaje</div>
<textarea cols="30" id="message_message" name="message_message" rows="5" class="span10"></textarea>
<input id="submit" name="commit" type="submit" value="Enviar" onClick="enviar()" class="btn btn-large btn-turquoise  uppercase" />
</fieldset>
</form>
</div>
</div>
					</div>
				</div>
			</div>
		</section>
		
		<!-- Footer -->
		<footer>
			<div class="container">
				<div class="row">
					<div class="span8 pull-right">
						<ul class="unstyled inline text-right footer-nav">
							<li><a href="#row1">Inicio</a></li>
							<li><a href="#row2">Trabajos</a></li>
							<li><a href="#row3">Servicios</a></li>
							<li><a href="#row4">Marketing Online</a></li>
							<li><a href="#row7">Contacto</a></li>
						</ul>
					</div>
					<div class="span4 pull-left copyright">
						NITRO2 Dise&ntilde;o paginas web en San Juan
					</div>
                    <div class="span2 pull-left copyright">
						Copyright 2004 - 2014
					</div>
				</div>
			</div>		
		</footer>		
	    <!-- Javascript  -->
	    <script type="text/javascript" src="js/jquery.js"></script>
	    <script type="text/javascript" src="js/bootstrap.min.js"></script>
	    <script type="text/javascript" src="js/jquery.scrollTo.min.js"></script>
	    <script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
	    <!-- Revolution Responsive jQuery Slider -->
	    <script type="text/javascript" src="js/jquery.themepunch.revolution.min.js"></script>
	    <script type="text/javascript" src="js/custom.js"></script>
        <script type="text/javascript" src="http://cdn.dev.skype.com/uri/skype-uri.js"></script>
        <script type="text/javascript">
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2052141-1', 'auto');
  ga('send', 'pageview');

</script>
    </body>
</html>