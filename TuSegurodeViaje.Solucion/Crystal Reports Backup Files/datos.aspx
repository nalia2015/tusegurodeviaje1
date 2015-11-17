<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datos.aspx.cs" Inherits="TuSegurodeViaje.WebSite.datos" %>

<!DOCTYPE HTML>
<html>
	<head id="Head1" runat=server>
		<title>Datos Personales | Tu Seguro de Viaje</title>
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
    <li class="arrow_box op3 activo2">PASO 3. PAGO</li>
</ul>
</div>
<div class="12u cabe12 indicador"><h4>DATOS PERSONALES</h4></div>

         <form id="frmDatos" runat="server" method="post" name="contact_formdos" class="contact_formdos" action="datos.aspx?op='pagar'">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:HiddenField ID="hdfOrigen" runat="server" Value="0" />
        <asp:HiddenField ID="hdfDestino" runat="server" Value="0" />
        <asp:HiddenField ID="hdfFechaDesde" runat="server" Value="0" />
        <asp:HiddenField ID="hdfFechaHasta" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEmail" runat="server" Value="0" />
        <asp:HiddenField ID="hdfOpcion" runat="server" Value="OK"/>
        <asp:HiddenField ID="hdfCantPasajeros" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfPrecioPesos" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfPrecioDolar" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfCantDias" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfCadena" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEdad1" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEdad2" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEdad3" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEdad4" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEdad5" runat="server" Value="0" />
        <asp:HiddenField ID="hdfEdad6" runat="server" Value="0" />
        <asp:HiddenField ID="hdfIdProducto" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfIdProveedor" runat="server" Value="0"/>
           <script type="text/javascript" >

               function pagar() {
                   document.getElementById("hdfOrigen").value = document.getElementById("hdfOrigen").value;
                   document.getElementById("hdfDestino").value = document.getElementById("hdfDestino").value;
                   document.getElementById("hdfFechaDesde").value = document.getElementById("hdfFechaDesde").value;
                   document.getElementById("hdfFechaHasta").value = document.getElementById("hdfFechaHasta").value;
                   document.getElementById("hdfEmail").value = document.getElementById("hdfEmail").value;
                   document.getElementById("hdfCantPasajeros").value = document.getElementById("hdfCantPasajeros").value;
                   document.getElementById("hdfCantDias").value = document.getElementById("hdfCantDias").value;
                   document.getElementById("hdfPrecioPesos").value = document.getElementById("hdfPrecioPesos").value;
                   document.getElementById("hdfPrecioDolar").value = document.getElementById("hdfPrecioDolar").value;
                   document.getElementById("hdfOpcion").value = 'pagar';
                   document.getElementById("hdfEdad1").value = document.getElementById("hdfEdad1").value;
                   document.getElementById("hdfEdad2").value = document.getElementById("hdfEdad2").value;
                   document.getElementById("hdfEdad3").value = document.getElementById("hdfEdad3").value;
                   document.getElementById("hdfEdad4").value = document.getElementById("hdfEdad4").value;
                   document.getElementById("hdfEdad5").value = document.getElementById("hdfEdad5").value;
                   document.getElementById("hdfEdad6").value = document.getElementById("hdfEdad6").value;
                   document.getElementById("hdfIdProducto").value = document.getElementById("hdfIdProducto").value;
                   document.getElementById("hdfCadena").value = document.getElementById("hdfOrigen").value + "_" + document.getElementById("hdfDestino").value + "_" + document.getElementById("hdfFechaDesde").value + "_" + document.getElementById("hdfFechaHasta").value + "_" + document.getElementById("hdfEmail").value + "_" + document.getElementById("hdfCantPasajeros").value + "_" + document.getElementById("hdfCantDias").value + "_" + document.getElementById("hdfPrecioPesos").value + "_" + document.getElementById("hdfPrecioDolar").value + "_" + document.getElementById("hdfOpcion").value + "_" + document.getElementById("hdfIdProducto").value;
                   //frmDatos.submit();
                   //var url = document.getElementById("irapagar").getAttribute('href');
                   //var inputValue = 'pagar.aspx?op=' + document.getElementById("hdfCadena").value;
                   //document.getElementById("irapagar").setAttribute('href', inputValue);
               } 

            </script>  



  <div id="innerpago" class="texto">
  


        <div class="row">
            <div class="12u">
              <section class="box sub">
                  <h3>DATOS DE TU VIAJE</h3>
                  <br>
                  <div class="row">
                    <div class="2u 12u(mobilep)">

                    <span><b>Origen:</b> <asp:Label ID="lblOrigen" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Destino:</b> <asp:Label ID="lblDestino" runat="server" Text=""></asp:Label></span>

                    </div>
                    <div class="3u 12u(mobilep)">

                    <span><b>Fecha de Salida:</b> <asp:Label ID="lblFechaSalida" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Fecha de Llegada:</b> <asp:Label ID="lblFechaLlegada" runat="server" Text=""></asp:Label> </span><br>
                    <span><b>Cantidad de Dias:</b> <asp:Label ID="lblCantDias" runat="server" Text=""></asp:Label></span>

                    </div>

                    <div class="3u 12u(mobilep)">

                    <span><b>Producto:</b> <asp:Label ID="lblTipoProducto" runat="server" Text="Económico"></asp:Label></span><br>
                    <span><b>Cantidad de pasajeros:</b> <asp:Label ID="lblCantPasajeros" runat="server" Text="Label"></asp:Label> personas</span><br>
                    <span><b style="background-color:#ccc; padding:7px; font-size:1.2em; color:#fff">Tarifa Total:</b> <span style="background-color:#FF8000; padding:7px; font-size:1.2em; color:#fff"> AR$ <asp:Label ID="lblPrecioPesos" runat="server" Text="Label"></asp:Label> <b>|</b> <span class="gris2">(U$S <asp:Label ID="lblPrecioDolar" runat="server" Text=""></asp:Label>)</span></span></span>

                    </div>
                  </div>
  
            </section>
          </div>
       </div>
</div>




<div class="row texto">
    <div class="12u">
    <section class="box">
                  <h3>DATOS DE VIAJEROS</h3>
                  <div class="row">
                    <div class="12u 12u(mobilep)">
                    
                              <script>
                                  $(function ($) {
                                      $.datepicker.regional['es'] = {
                                          closeText: 'Cerrar',
                                          /* prevText: '<Ant',
                                          nextText: 'Sig>',*/
                                          currentText: 'Hoy',
                                          monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                                          monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                                          dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
                                          dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
                                          dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
                                          weekHeader: 'Sm',
                                          dateFormat: 'dd/mm/yy',
                                          firstDay: 1,
                                          isRTL: false,
                                          showMonthAfterYear: false,
                                          yearSuffix: ''
                                      };
                                      $.datepicker.setDefaults($.datepicker.regional['es']);
                                      $("#txtFechaNacimientoViajero1, #txtFechaNacimientoViajero2,#txtFechaNacimientoViajero3,#txtFechaNacimientoViajero4,#txtFechaNacimientoViajero5,#txtFechaNacimientoViajero6, #datepicker2").datepicker();
                                  });
                              </script>

                  <asp:Panel ID=Pasajero1  runat=server Visible="true">
                  <h4><b>Datos de Pasajero 1 (Edad: <asp:Label ID="lblEdad1" runat="server" Text=""></asp:Label> años)</b></h4>
                  
                    <div class="row uniform 50%">
                      
                      <div class="2u 12u(mobilep)">
                      Nombres:
                        <asp:TextBox ID="txtNombreViajero1" name="nombre" runat="server" placeholder="Como figura en el documento" type="text"  autocomplete="off" required="required"></asp:TextBox>                     
                      </div>
                      <div class="2u 12u(mobilep)">
                      Apellidos:
                         <asp:TextBox ID="txtApellidoViajero1" name="apellido" runat="server" placeholder="Como figura en el documento" type="text" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Fecha: (dd/mm/aaaa)
                        <asp:TextBox ID="txtFechaNacimientoViajero1" name="fecha" runat="server" placeholder="Fecha Nacimiento" type="text"  autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      

                      <div class="2u 12u(mobilep)">
                      Nro. Documento:
                        <asp:TextBox ID="txtDNIViajero1" name="dni" runat="server" placeholder="DNI" type="text" pattern="[0-9]{5,10}" autocomplete="off" required="required"></asp:TextBox>
                      </div>

                      
                      

                    </div>
                    </asp:Panel>
<!--INICIO PASAJERO 2 -->
<br>
<asp:Panel ID="Pasajero2" runat="server" Visible="false">
<h4><b>Datos de Pasajero 2 (Edad: <asp:Label ID="lblEdad2" runat="server" Text=""></asp:Label> años)</b></h4>
                  
                    <div class="row uniform 50%">
                      
                      <div class="2u 12u(mobilep)">
                      Nombres:
                        <asp:TextBox ID="txtNombreViajero2" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Apellidos:
                        <asp:TextBox ID="txtApellidoViajero2" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Fecha: (dd/mm/aaaa)
                        <asp:TextBox ID="txtFechaNacimientoViajero2" runat="server" type="text" placeholder="Fecha Nacimiento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      

                      <div class="2u 12u(mobilep)">
                      Nro. Documento:
                        <asp:TextBox ID="txtDNIViajero2" runat="server" type="text" placeholder="DNI" pattern="[0-9]{5,10}" autocomplete="off" required="required"></asp:TextBox>
                      </div>

                    </div>
</asp:Panel>
<!-- FIN PASAJERO 2 -->

<!--INICIO PASAJERO 3 -->
<br>
<asp:Panel ID="Pasajero3" runat="server" Visible="false">
<h4><b>Datos de Pasajero 3 (Edad: <asp:Label ID="lblEdad3" runat="server" Text=""></asp:Label> años)</b></h4>
                  
                    <div class="row uniform 50%">
                      
                      <div class="2u 12u(mobilep)">
                      Nombre:
                        <asp:TextBox ID="txtNombreViajero3" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required" ></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Apellido:
                       <asp:TextBox ID="txtApellidoViajero3" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="1u 12u(mobilep)">
                      Fecha:
                        <asp:TextBox ID="txtFechaNacimientoViajero3" runat="server" type="text" placeholder="Fecha Nacimiento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      

                      <div class="1u 12u(mobilep)">
                      Nro. Documento:
                        <asp:TextBox ID="txtDNIViajero3" runat="server" type="text" placeholder="DNI" pattern="[0-9]{5,10}" autocomplete="off" required="required"></asp:TextBox>
                      </div>                                              

                    </div>
</asp:Panel>
<!-- FIN PASAJERO 3 -->


<!--INICIO PASAJERO 4 -->
<br>

<asp:Panel ID="Pasajero4" runat="server" Visible="false">
<h4><b>Datos de Pasajero 4 (Edad: <asp:Label ID="lblEdad4" runat="server" Text=""></asp:Label> años)</b></h4>
                  
                    <div class="row uniform 50%">
                      
                      <div class="2u 12u(mobilep)">
                      Nombre:
                        <asp:TextBox ID="txtNombreViajero4" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Apellido:
                       <asp:TextBox ID="txtApellidoViajero4" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="1u 12u(mobilep)">
                      Fecha:
                        <asp:TextBox ID="txtFechaNacimientoViajero4" runat="server" type="text" placeholder="Fecha Nacimiento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      

                      <div class="1u 12u(mobilep)">
                      Nro de Documento:
                        <asp:TextBox ID="txtDNIViajero4" runat="server" type="text" placeholder="DNI" pattern="[0-9]{5,10}" autocomplete="off" required="required"></asp:TextBox>
                      </div>                   
                              

                    </div>
</asp:Panel>

<!-- FIN PASAJERO 4 -->

<!--INICIO PASAJERO 5 -->
<br>

<asp:Panel ID="Pasajero5" runat="server" Visible="false">
<h4><b>Datos de Pasajero 5 (Edad: <asp:Label ID="lblEdad5" runat="server" Text=""></asp:Label> años)</b></h4>
                  
                    <div class="row uniform 50%">
                      
                      <div class="2u 12u(mobilep)">
                      Nombre:
                        <asp:TextBox ID="txtNombreViajero5" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Apellido:
                       <asp:TextBox ID="txtApellidoViajero5" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="1u 12u(mobilep)">
                      Fecha:
                        <asp:TextBox ID="txtFechaNacimientoViajero5" runat="server" type="text" placeholder="Fecha Nacimiento"  autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      

                      <div class="1u 12u(mobilep)">
                      Nro de Documento:
                        <asp:TextBox ID="txtDNIViajero5" runat="server" type="text" placeholder="DNI" pattern="[0-9]{5,10}" autocomplete="off" required="required"></asp:TextBox>
                      </div>                                    

                    </div>
</asp:Panel>

<!-- FIN PASAJERO 5 -->

<!--INICIO PASAJERO 6 -->
<br>


<asp:Panel ID="Pasajero6" runat="server" Visible="false">
<h4><b>Datos de Pasajero 6 (Edad: <asp:Label ID="lblEdad6" runat="server" Text=""></asp:Label> años)</b></h4>
                  
                    <div class="row uniform 50%">
                      
                      <div class="2u 12u(mobilep)">
                      Nombre:
                        <asp:TextBox ID="txtNombreViajero6" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="2u 12u(mobilep)">
                      Apellido:
                       <asp:TextBox ID="txtApellidoViajero6" runat="server" type="text" placeholder="Como figura en el documento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      <div class="1u 12u(mobilep)">
                      Fecha:
                        <asp:TextBox ID="txtFechaNacimientoViajero6" runat="server" type="text" placeholder="Fecha Nacimiento" autocomplete="off" required="required"></asp:TextBox>
                      </div>
                      

                      <div class="1u 12u(mobilep)">
                      Nro de Documento:
                        <asp:TextBox ID="txtDNIViajero6" runat="server" type="text" placeholder="DNI" pattern="[0-9]{5,10}" autocomplete="off" required="required"></asp:TextBox>
                      </div>                    

                    </div>
</asp:Panel>

<!-- FIN PASAJERO 6 -->




                    

                   
                  </div>
                  </div>
        </section>
                    
       </div>
     </div>


<!-- datos de persona de contacto -->

<div class="row texto">
    <div class="12u">
    <section class="box">
                  <h3>INFORMACION DE CONTACTO</h3>
                  <div class="row">
                    <div class="12u 12u(mobilep)">
                    
                              

                  
                 
                    <div class="row uniform 50%">
                      
                            <div class="2u 12u(mobilep)">
                            E-mail <span class="gris">(donde recibirá su voucher):</span>
                              <asp:TextBox ID="txtEmailContacto" runat="server" type="email" placeholder="Su e-mail" autocomplete="off" required="required"></asp:TextBox>
                            </div>
                            
                            

                            <div class="1u 12u(mobilep)">
                             Telefono: 
                             <div class="select-wrapper2">
                             <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlTipoTelefonoContacto" runat="server" required="required">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                </Triggers>
                             </asp:UpdatePanel></div> 
                          </div>


                          <div class="2u 12u(mobilep)">
                             Pais:
                          <div class="select-wrapper2">
                          <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlPaisContacto" runat="server" class="" name="quote[destination]"  data-placeholder="PAIS: " required="required"></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                            </Triggers>
                          </asp:UpdatePanel>
                          </div>
                          </div>

                        
                        <div class="1u 12u(mobilep) ">
                             Cod. Ciudad: <asp:TextBox ID="txtCiudadContacto" type="text" runat="server" placeholder="Area" autocomplete="off" pattern="[0-9]{3,10}" required="required"></asp:TextBox>
                        </div>
                        <div class="2u 12u(mobilep)">
                            Número: <asp:TextBox ID="txtNroLocalContacto" type="text" runat="server" placeholder="Número local"  autocomplete="off" pattern="[0-9]{3,10}" required="required"></asp:TextBox>
                        </div>

                      

                    </div>

                    
                   <br>
                    <h4 style="font-size: 1.4em; color:#555; margin-top:10px;border-bottom: solid 1px #ccc;">En caso de emergencia nos comunicaremos con:</h4>
                    <div class="row uniform 50%"> 
                         

                            
                            <div class="1u 12u(mobilep)">
                            Nombre:
                            <asp:TextBox ID="txtNombreContactoEmergencia" type="text" runat="server" placeholder="Nombre" autocomplete="off" required="required"></asp:TextBox>
                            </div>
                            <div class="1u 12u(mobilep)">
                            Apellido:
                            <asp:TextBox ID="txtApellidoContactoEmergencia" type="text" runat="server" placeholder="Apellido" autocomplete="off" required="required"></asp:TextBox>
                            </div>
                            <div class="1u 12u(mobilep)">
                            Su e-mail:
                            <asp:TextBox ID="txtEmailContactoEmergencia" type="email" runat="server" placeholder="Su e-mail" autocomplete="off" required="required"></asp:TextBox>
                            </div>

                            <div class="1u 12u(mobilep)">
                             Telefono: 
                             <div class="select-wrapper2">
                              <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlTipoTelefonoEmergencia" runat="server" required="required">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                </Triggers>
                             </asp:UpdatePanel>
                          </div> 
                          </div>


                          <div class="2u 12u(mobilep)">
                             Pais:
                          <div class="select-wrapper2">
                         <asp:UpdatePanel ID="UpdatePanel3" runat="server" required>
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlPaisContactoEmergencia" runat="server" class="" name="quote[destination]"  data-placeholder="PAIS: " required="required"></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                            </Triggers>
                          </asp:UpdatePanel>
                          </div>
                          </div>

                        
                        <div class="1u 12u(mobilep) ">
                             Cod. Ciudad:  <asp:TextBox ID="txtCiudadEmergencia" runat="server" type="text" placeholder="Area" autocomplete="off" pattern="[0-9]{3,10}" required="required"></asp:TextBox>
                        </div>
                        <div class="2u 12u(mobilep)">
                            Número: <asp:TextBox ID="txtNroLocalEmergencia" runat="server" type="text" placeholder="Número local" autocomplete="off" pattern="[0-9]{3,10}" required="required"></asp:TextBox>
                        </div>
                    </div>
                    
              
                  </div>
                  </div>
        </section>
                    
       </div>
     </div>


     <!-- fin datos de persona de contacto -->






<div class="row texto">
    <div class="12u">
    <section class="box">
                  

                  <div class="11u 12u(narrower)">
                  <span class="tituloenviar"><a href=""><i class="fa fa-file-pdf-o"></i> Ver Condiciones Generales</a></span>
                  <br>

                        <span><input type="checkbox" id="copy" name="copy"> Declaro ser mayor de edad, con capacidad suficiente para realizar este acto, haber leido y comprendido las condiciones generales del servicio de asistencia al viajero que deseo contratar, las que acepto en su totalidad.</span>
                   </div>            

                   <div class="center">
                     <button class="button specialg" type="submit" onclick='pagar();' >ENVIAR</button>
                   </div>


                   <hr>
                   
    </section>
    </div>
    </div>

   





    </div>
</form>

    

	<br>
<br>

    <footer id="footer pieblanco" class="pieblanco center" >

        <div style="margin-left:20px;"><a href="terminos-condiciones.html" class="iframe4"><span class="">Termino y condiciones</span></a> | <a href="politicas-de-privacidad.html" class="iframe4">Politicas de Privacidad</a>
        <div style="margin-left:20px;"><a href="TuSegurodeViaje.net" class=""><span class="">TuSegurodeViaje.net</span></a> | Telefono en Argentina: +54 11 5235 3998  |  Avenida General San Martín 3430,Piso 2, Oficina 201, Edificio Florida Office,  Florida, Buenos Aires, Argentina</div>
              
    </footer>

    <%-- </form>--%>

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

