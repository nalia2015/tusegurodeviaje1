<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagar.aspx.cs" Inherits="TuSegurodeViaje.WebSite.pagar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html>
	<head runat=server>
		<title>Pago | Tu Seguro de Viaje</title>
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


	     <!-- <script src="js/jquery.min.js"></script>-->
	  <script src="js/jquery-ui.js"></script>
		
  		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
		
	</head>


    <body class="landingcampare">
    
    <div id="page-wrapper1">
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
  
            </section>
          </div>
         </div>


     <!-- FORMAS DE PAGO -->

<div class="row">
    <div class="12u">
    <section class="box">
                  <h3>FORMAS DE PAGO</h3>
                  
                  <div class="row">
                    <div class="12u 12u(mobilep) cards_module">

                    <ul class="type_of_credit">
                      
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/visa.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/master.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/american.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/naranja.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/mercadopago.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/paypal.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="">
                      <img src="images/logos/bitcoin.png"></li>
                    </ul>
                    
                    </div>
                    </div>
                    
                    

                    
                    <div class="12u 12u(mobilep)">
                    <div class="row uniform 50%" style="margin-left:22px;">

                            <b> <input name="payment" type="radio" value="1" onclick=""> A convenir telefonicamente:</b> 
                           <div class="1u 12u(mobilep)">
                             Telefono: 
                             <div class="select-wrapper2">
                             <select id="ttcot" onchange="cambioDatoCoti()">
                             <option value="1">Celular </option>
                             <option value="2">Teléfono </option></select> 
                             </div> 
                          </div>


                        <div class="2u 12u(mobilep)">
                             Pais:
                        <div class="select-wrapper2">
                          <select name="pais" id="pais">

                            <option value="1" selected="selected">ARGENTINA</option>
                            <option value="2">ESPAÑA</option>
                            <option value="3">BOLIVIA</option>
                            <option value="4">BRASIL</option>
                            <option value="5">CHILE</option>
                            <option value="6">COLOMBIA</option>
                            <option value="7">CUBA</option>
                            <option value="8">CR</option>
                            <option value="9">ECUADOR</option>
                            <option value="10">EL SALVADOR</option>
                            <option value="11">GUAYANA</option>
                            <option value="12">HONDURAS</option>
                            <option value="13">MEXICO</option>
                            <option value="14">NICARAGUA</option>
                            <option value="15">PANAMA</option>
                            <option value="16">PARAGUAY</option>
                            <option value="17">PERU</option>
                            <option value="18">PUERTO RICO</option>
                            <option value="19">REP. DOMINICANA</option>
                            <option value="20">URUGUAY</option>
                            <option value="21">VENEZUELA</option>
                            <option value="22">UE</option>
                          </select>
                          </div>
                          </div>

                        
                        <div class="1u 12u(mobilep) ">
                             Cod. Ciudad: <input type="text" name="tciudad" id="tciudad" value="" placeholder="Area"> 
                        </div>
                        <div class="2u 12u(mobilep)">
                            Numero local: <input type="text" name="tlocal" id="tlocal" value="" placeholder="Numero local">
                        </div>
                      </div>                

                    </div>
                  </div>

    </section>

    </div>
 </div>
<!-- ---------------------------*************----------------------------- -->

<div class="row texto">
    <div class="12u">
    <section class="box">
                  <h3>DATOS DE FACTURACION</h3>
                  <div class="row">
                    <div class="12u 12u(mobilep)">
                    
                                                
                  <!-- <form method="post" action="#"> -->
                    <div class="row uniform 50%">

                    <div class="2u 12u(mobilep)">
                      Situación Fiscal:
                        <div class="select-wrapper2">
                        <select name="ifiscal" id="ifiscal">
                              <option value="CONSUMIDOR_FINAL" selected="">Consumidor Final</option>
                              <option value="RESPONSABLE_INSCRIPTO">Responsable Inscripto</option>
                              <option value="MONOTRIBUTO">Monotributo</option>
                              <option value="EXENTO">Exento</option>
                            
                          </select>
                        </div>
                        </div>
                      
                      <div class="2u 12u(mobilep)">
                      Nombre o razón social:
                        <input type="text" name="nombref" id="nombref" value="" placeholder="Nombre o razón social">
                      </div>
                      

                      
                      <div class="1u 12u(mobilep)">
                      Cuil o Cuit:
                        <input type="text" name="dnif" id="dnif" value="" placeholder="Cuil o Cuit">
                      </div>

                       <div class="1u 12u(mobilep)">
                      Cod. Postal:
                        <input type="text" name="telefonof" id="telefonof" value="" placeholder="Cod. Postal">
                      </div>

                      <div class="2u 12u(mobilep)">
                      Domicilio:
                        <input type="text" name="domiciliof" id="domiciliof" value="" placeholder="Domicilio">
                      </div>

                      <div class="1u 12u(mobilep)">
                      Ciudad:
                        <input type="text" name="ciudadf" id="ciudadf" value="" placeholder="Ciudad">
                      </div>

                      <div class="2u 12u(mobilep)">
                      Pais:
                        <div class="select-wrapper2">
                        <select name="paisf" id="paisf">
                              <option value="">Pais de residencia</option>
                              <option value="1" >ARGENTINA</option>
                              <option value="2">ESPAÑA</option>
                              <option value="3">BOLIVIA</option>
                              <option value="4">BRASIL</option>
                              <option value="5">CHILE</option>
                              <option value="6">COLOMBIA</option>
                              <option value="7">CUBA</option>
                              <option value="8">CR</option>
                              <option value="9">ECUADOR</option>
                              <option value="10">EL SALVADOR</option>
                              <option value="11">GUAYANA</option>
                              <option value="12">HONDURAS</option>
                              <option value="13">MEXICO</option>
                              <option value="14">NICARAGUA</option>
                              <option value="15">PANAMA</option>
                              <option value="16">PARAGUAY</option>
                              <option value="17">PERU</option>
                              <option value="18">PUERTO RICO</option>
                              <option value="19">REP. DOMINICANA</option>
                              <option value="20">URUGUAY</option>
                              <option value="21">VENEZUELA</option>
                              <option value="22">UE</option>
                          </select>
                        </div>
                     </div>


                    </div>





                      <div class="row uniform 50%">
                          <div class="1u 12u(mobilep)">
                             Telefono: 
                             <div class="select-wrapper2">
                             <select id="ttcot" onchange="cambioDatoCoti()">
                             <option value="1">Celular </option>
                             <option value="2">Teléfono </option></select> 
                          </div> 
                          </div>


                          <div class="2u 12u(mobilep)">
                             Pais: 


                          <div class="select-wrapper2">
                          <select name="pais" id="pais">

                          <option value="1" selected="selected">ARGENTINA</option>
                          <option value="2">ESPAÑA</option>
                          <option value="3">BOLIVIA</option>
                          <option value="4">BRASIL</option>
                          <option value="5">CHILE</option>
                          <option value="6">COLOMBIA</option>
                          <option value="7">CUBA</option>
                          <option value="8">CR</option>
                          <option value="9">ECUADOR</option>
                          <option value="10">EL SALVADOR</option>
                          <option value="11">GUAYANA</option>
                          <option value="12">HONDURAS</option>
                          <option value="13">MEXICO</option>
                          <option value="14">NICARAGUA</option>
                          <option value="15">PANAMA</option>
                          <option value="16">PARAGUAY</option>
                          <option value="17">PERU</option>
                          <option value="18">PUERTO RICO</option>
                          <option value="19">REP. DOMINICANA</option>
                          <option value="20">URUGUAY</option>
                          <option value="21">VENEZUELA</option>
                          <option value="22">UE</option>
                        </select>
                          </div>
                          </div>

                        
                        <div class="1u 12u(mobilep) ">
                             Cod. Ciudad: <input type="text" name="tciudad" id="tciudad" value="" placeholder="Area"> 
                        </div>
                        <div class="2u 12u(mobilep)">
                            Numero local: <input type="text" name="tlocal" id="tlocal" value="" placeholder="Numero local">
                        </div>

                        </div>

                  </div>
                  </div>
        </section>
                    
       </div>
     </div>

<!-- -->

<div class="row texto">
    <div class="12u">
    
              <section class="box sub destaca">
                  <h3>Otras personas tambien compraron los siguientes servicios y productos exclusivos:</h3>
                  
                  <div class="row" style="margin-left:2px">
                    <div class="5u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Seguro de Cancelacion de Viaje</a></span>
                  </div>
                    
                  <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 50 / AR$ 100</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

                  <div class="row" style="margin-left:2px">
                    <div class="5u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Seguro de Compra Protegida</a></span>
                    </div>
                    
                    <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 150 / AR$ 300</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

                  <div class="row" style="margin-left:2px">
                    <div class="5u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Seguro de Cancelacion de Viaje</a></span>
                    </div>
                    
                    <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 300 / AR$ 1500</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

            </section>
          </div>
         </div>



<div class="row texto">
            <div class="12u">
              <section class="box sub">
                  <h4 style="margin-left:5px; font-size: 1.2em">Productos con costo de entrega a domicilio o para retirar en oficina:</h4>
                  
                  <div class="row" style="margin-left:2px">

                  

                    <div class="4u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Almohadilla de viaje</a></span>
                  </div>
                  <div class="1u 12u(mobilep) imaagregar">
                    <span><a href="verproducto.html" class="iframe"><img alt="Candado para valija" src="images/productos/like2.jpg" style="border: none;;border: none;" height="50" width="50"></a></span>
                    </div>
                    
                  <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 50 / AR$ 100</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

                  <div class="row" style="margin-left:2px">

                  


                    <div class="4u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Candado para valija</a></span>
                    </div>
                    <div class="1u 12u(mobilep) imaagregar">
                    <span><a href="verproducto.html" class="iframe"><img alt="Candado para valija" src="images/productos/p.jpg" style="border: none;;border: none;" height="50" width="50"></a></span>
                    </div>
                    <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 150 / AR$ 300</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

                  <div class="row" style="margin-left:2px">
                  
                    <div class="4u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Identificadores de valijas</a></span>
                    </div>
                    <div class="1u 12u(mobilep) imaagregar">
                    <span><a href="verproducto.html" class="iframe"><img alt="Candado para valija" src="images/productos/s.jpg" style="border: none;;border: none;" height="50" width="50"></a></span>
                    </div>
                    <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 300 / AR$ 1500</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

                  <div class="row" style="margin-left:2px">
                  

                    <div class="4u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Funda para valija</a></span>
                    </div>
                    <div class="1u 12u(mobilep) imaagregar">
                    <span><a href="verproducto.html" class="iframe"><img alt="Candado para valija" src="images/productos/f.jpg" style="border: none;;border: none;" height="50" width="50"></a></span>
                    </div>
                    
                    <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 300 / AR$ 1500</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                  </div>

                  <div class="row" style="margin-left:2px">
                  

                    <div class="4u 12u(mobilep) agregar">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-xs fa-search"></i> Localizador de valijas</a></span>
                    </div>

                    <div class="1u 12u(mobilep) imaagregar">
                    <span><a href="verproducto.html" class="iframe"><img alt="Candado para valija" src="images/productos/g.jpg" style="border: none;;border: none;" height="50" width="50"></a></span>
                    </div>
                    
                    <div class="3u 12u(mobilep) agregarcant">
                    <span>U$S 300 / AR$ 1500</span> 
                        <input type="number" name="cantidad" id="cantidad" value="" placeholder="Cantidad">
                    </div>
                    </div>


                 <div class="row" style="margin-left:2px">
                 <div class="5u 12u(mobilep) agregargris">
                    <span><a href="verproducto.html" class="iframe"><i class="fa fa-angle-right"></i>  NUEVO TOTAL DE SU COMPRA </a></span>
                    </div>

                    
                    
                    <div class="3u 12u(mobilep) agregarcantgris">
                    <span>U$S 300 / AR$ 1500</span> 
                        
                    </div>
                    </div>




            </section>
          </div>
         </div>





<!-- -->

<div class="row texto">
    <div class="12u">
    <section class="box">
                  
                  <div class="row">
                    <div class="12u 12u(mobilep)">
                   <div class="6u 12u(mobilep)" style="float: right;" style="background-color:#ccc">
                            <input class="btn button special" name="p" value="PAGAR" type="submit">
                        </div>
                   
                   
                  </div>
                  </div>
        </section>
                    
       </div>
     </div>
    </div>


<br>
<br>

		<footer id="footer " class="piegris" style="border-top:solid 1px #ccc" >
    <div class="row">
		
		<div class="3u" style="margin-left:20px;margin-top:30px;">
    <span class="tituloenviar"><a href=""><i class="fa fa-file-pdf-o"></i> Ver Condiciones Generales</a></span>
		</div>
    
    <div class="6u izq22 logospie" style="float:right; margin-right:20px">
    <ul class="icons">
            <li><a href="#"><img src="images/garantizado.png" alt="" /></a></li>
            <li><a href="#"><img src="images/secure.png" alt="" /></a></li>
            <li><a href="#"><img src="images/pdp.png" alt="" /></a></li>
            <li><a href="#"><img src="images/cace.png" alt="" /></a></li>
            <li><a href="#"><img src="images/datafiscal.png" alt="" /></a></li>
                        
          </ul>
        </div>

		</div>
    </footer>
		
		<footer id="footer pieblanco" class="pieblanco" >

		<div style="margin-left:20px;"><a href="#" class=""><span class="">TuSegurodeViaje.net</span></a> | Telefono en Argentina: +54 11 5235 3998  |  Avenida General San Martín 3430,Piso 2, Oficina 201, Edificio Florida Office,  Florida, Buenos Aires, Argentina</div>
		</footer>

  		</div>


		<!--<script src="1js2/jquery113.min.js"></script>
		<script src="1js2/bootstrap335.min.js"></script>-->

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



	</body>

</html>

