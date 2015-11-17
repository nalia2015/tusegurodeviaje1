<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagar.aspx.cs" Inherits="TuSegurodeViaje.WebSite.pagar" %>
<%@ Import Namespace="System.Collections" %>
<%@ Import Namespace="mercadopago" %>

<!DOCTYPE HTML>
<html>
	<head id="Head1" runat=server>
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
   	  
 		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body class="landingcampare">
   <script type="text/javascript" >
       
       function selecciona(opcion){
           document.getElementById("hdfFormaPago").value = opcion.toString();
       }
       
       function asignarurl(opcion){
           
           document.getElementById("hdfOpcion").value = opcion.toString();           
           frmpago.submit();           
       }     

       function pagar(){           
           document.getElementById("hdfOpcion").value = "pagar";
           frmpago.submit();
       }

       function compraadicional() {

          var cant= "";         
          var chkB;
          var idprove = '';
          var idprod = '';
          var preciopesos = '';
          var preciodolar = '';
          var cantxProd = '';
          var cont = 0;
          var dolar='';
          var pesos = '';
          var id = '';

          for (var i = 0; i < document.getElementsByName("chkcompra").length; i++) {
              chkB = document.getElementsByName("chkcompra")[i];
                if (chkB.checked) {
                    idprod = idprod + chkB.id + '*';
                    cant = "cant_" + chkB.id;
                    cantxProd = cantxProd + document.getElementById(cant).value + '*';
                    cont = cont + 1;
                }
          }

          if (cont > 0) {
              document.getElementById("hdfIdProducto").value =  idprod;
              document.getElementById("hdfCantidad").value = cantxProd ;
              document.getElementById("hdfOpcionAdicionales").value = '1';
          }
          else {
              document.getElementById("hdfIdProducto").value = '';
              document.getElementById("hdfCantidad").value = '';
              document.getElementById("hdfOpcionAdicionales").value = '1';
          }    
          
      }
    
    </script>

    <div>
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

<form id="frmpago" runat="server" method="post" class="contact_formdos">
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>         
<asp:HiddenField ID="hdfEmail" runat="server" Value="0" /> 
<asp:HiddenField ID="hdfFormaPago" runat="server" Value="0" />
<asp:HiddenField ID="hdfOrigen" runat="server" Value="0" />
<asp:HiddenField ID="hdfDestino" runat="server" Value="0" /> 
<asp:HiddenField ID="hdfOpcion" runat="server" Value="OK"/>       
<asp:HiddenField ID="hdfOpcionAdicionales" runat="server" Value="0"/>   
<asp:HiddenField ID="hdfUrl" runat="server" Value=""/>
<asp:HiddenField ID="hdfIdProducto" runat="server" Value=""/>
<asp:HiddenField ID="hdfIdProveedor" runat="server" Value=""/>
<asp:HiddenField ID="hdfPrecioPesos" runat="server" Value=""/>
<asp:HiddenField ID="hdfPrecioDolar" runat="server" Value=""/>
<asp:HiddenField ID="hdfCantidad" runat="server" Value=""/>

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
                  <br>
                  <div class="row">
                    <div class="2u 12u(mobilep)">

                    <span><b>Origen:</b> <asp:Label ID="lblOrigen" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Destino:</b> <asp:Label ID="lblDestino" runat="server" Text=""></asp:Label></span>

                    </div>
                    <div class="3u 12u(mobilep)">

                    <span><b>Fecha de Salida:</b> <asp:Label ID="lblFechaSalida" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Fecha de Llegada:</b> <asp:Label ID="lblFechaLlegada" runat="server" Text=""></asp:Label></span><br>
                    <span><b>Cantidad de Dias:</b> <asp:Label ID="lblCantDias" runat="server" Text=""></asp:Label></span>

                    </div>

                    <div class="3u 12u(mobilep)">

                    <span><b>Producto:</b> <asp:Label ID="lblTipoProducto" runat="server" Text="Económico"></asp:Label></span><br>
                    <span><b>Cantidad de pasajeros:</b> <asp:Label ID="lblCantPasajeros" runat="server" Text="Label"></asp:Label></span><br>
                    <span><b style="background-color:#ccc; padding:7px; font-size:1.2em; color:#fff">Tarifa Total:</b> <span style="background-color:#FF8000; padding:7px; font-size:1.2em; color:#fff"> AR$ <asp:Label ID="lblPrecioPesos" runat="server" Text="Label"></asp:Label> <b>|</b> <span class="gris2">(U$S <asp:Label ID="lblPrecioDolar" runat="server" Text=""></asp:Label>)</span></span></span>
                    </div>
                  </div>
				</section>
			</div>
         </div>



<div class="row">
            <div class="12u">
              <section class="box sub">
                  <h3>DATOS DE VIAJEROS</h3>
                  <div class="row">
                    <div class="10u 12u(mobilep)">

                    <asp:Panel ID="PanelPasajero1" Visible=false runat=server >
                    <table>
                    <tr style="font-size:1.1em; font-weight: bold;">
                      <td>Datos</td>
                      <td>Nombre</td>
                      <td>Edad</td>
                      <td>Fecha Nacimiento</td>
                      <td>Nro. Documento</td>
                    </tr>
                    <tr>
                      <td>Pasajero 1</td>
                      <td><asp:Label ID="lblApellidoPasajero1" runat="server" Text=""></asp:Label> , <asp:Label ID="lblNombrePasajero1" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblEdadPasajero1" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblFechaNacPasajero1" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblNroDocuPasajero1" runat="server" Text=""></asp:Label></td>
                    </tr>
                    </table>
                   </asp:Panel>
                   
                   <asp:Panel ID="PanelPasajero2" Visible=false runat=server>
                    <table>
                    <tr style="font-size:1.1em; font-weight: bold;">
                      <td>Datos</td>
                      <td>Nombre</td>
                      <td>Edad</td>
                      <td>Fecha Nacimiento</td>
                      <td>Nro. Documento</td>
                    </tr>
                    <tr>
                      <td>Pasajero 2</td>
                      <td><asp:Label ID="lblApellidoPasajero2" runat="server" Text=""></asp:Label> , <asp:Label ID="lblNombrePasajero2" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblEdadPasajero2" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblFechaNacPasajero2" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblNroDocuPasajero2" runat="server" Text=""></asp:Label></td>
                    </tr>
                    </table>
                   </asp:Panel>

                    <asp:Panel ID="PanelPasajero3" Visible=false runat=server>
                    <table>
                    <tr style="font-size:1.1em; font-weight: bold;">
                      <td>Datos</td>
                      <td>Nombre</td>
                      <td>Edad</td>
                      <td>Fecha Nacimiento</td>
                      <td>Nro. Documento</td>
                    </tr>
                    <tr>
                      <td>Pasajero 3</td>
                      <td><asp:Label ID="lblApellidoPasajero3" runat="server" Text=""></asp:Label> , <asp:Label ID="lblNombrePasajero3" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblEdadPasajero3" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblFechaNacPasajero3" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblNroDocuPasajero3" runat="server" Text=""></asp:Label></td>
                    </tr>
                    </table>
                   </asp:Panel>

                   <asp:Panel ID="PanelPasajero4" Visible=false runat=server>
                    <table>
                    <tr style="font-size:1.1em; font-weight: bold;">
                      <td>Datos</td>
                      <td>Nombre</td>
                      <td>Edad</td>
                      <td>Fecha Nacimiento</td>
                      <td>Nro. Documento</td>
                    </tr>
                    <tr>
                      <td>Pasajero 4</td>
                      <td><asp:Label ID="lblApellidoPasajero4" runat="server" Text=""></asp:Label> , <asp:Label ID="lblNombrePasajero4" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblEdadPasajero4" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblFechaNacPasajero4" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblNroDocuPasajero4" runat="server" Text=""></asp:Label></td>
                    </tr>
                    </table>
                   </asp:Panel>

                    <asp:Panel ID="PanelPasajero5" Visible=false runat=server>
                    <table>
                    <tr style="font-size:1.1em; font-weight: bold;">
                      <td>Datos</td>
                      <td>Nombre</td>
                      <td>Edad</td>
                      <td>Fecha Nacimiento</td>
                      <td>Nro. Documento</td>
                    </tr>
                    <tr>
                      <td>Pasajero 5</td>
                      <td><asp:Label ID="lblApellidoPasajero5" runat="server" Text=""></asp:Label> , <asp:Label ID="lblNombrePasajero5" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblEdadPasajero5" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblFechaNacPasajero5" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblNroDocuPasajero5" runat="server" Text=""></asp:Label></td>
                    </tr>
                    </table>
                   </asp:Panel>

                   <asp:Panel ID="PanelPasajero6" Visible=false runat=server>
                    <table>
                    <tr style="font-size:1.1em; font-weight: bold;">
                      <td>Datos</td>
                      <td>Nombre</td>
                      <td>Edad</td>
                      <td>Fecha Nacimiento</td>
                      <td>Nro. Documento</td>
                    </tr>
                    <tr>
                      <td>Pasajero 6</td>
                      <td><asp:Label ID="lblApellidoPasajero6" runat="server" Text=""></asp:Label> , <asp:Label ID="lblNombrePasajero6" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblEdadPasajero6" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblFechaNacPasajero6" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="lblNroDocuPasajero6" runat="server" Text=""></asp:Label></td>
                    </tr>
                    </table>
                   </asp:Panel>


                   

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
                      
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('1');" id="visa">
                      <img src="images/logos/visa.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('1');" id="master">
                      <img src="images/logos/master.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('1');" id="american">
                      <img src="images/logos/american.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('2');" id="naranja">
                      <img src="images/logos/naranja.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('7');" id="mercadopago">
                      <img src="images/logos/mercadopago.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('3');" id="paypal">
                      <img src="images/logos/paypal.png"></li>
                      <li class="text-center uppercase"><input name="payment" type="radio" value="1" onclick="selecciona('4');" id="bitcoin">
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
                                <asp:DropDownList ID="ddlTipoTelefono" runat="server" required>                                
                                </asp:DropDownList>
                             </div> 
                          </div>


                        <div class="2u 12u(mobilep)">
                             Pais:
                        <div class="select-wrapper2">
                          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                             <ContentTemplate>
                                <asp:DropDownList ID="ddlPaisTelefono" runat="server"                            
                                    class="" name="quote[destination]" 
                                    data-placeholder="PAIS: " tabindex="1" required></asp:DropDownList>
                             </ContentTemplate>
                             <Triggers>
                             </Triggers>
                             </asp:UpdatePanel>  
                          </div>
                          </div>

                        
                        <div class="1u 12u(mobilep) ">
                             Cod. Ciudad: <asp:TextBox ID="txtCodigoAreaCiudad" runat="server" placeholder="Area" required></asp:TextBox>
                        </div>
                        <div class="2u 12u(mobilep)">
                            Numero: <asp:TextBox ID="txtNroLocal" runat="server" placeholder="Número local" required></asp:TextBox>
                        </div>
                      </div>                

                    </div>
    </div>
    </section>
    </div>
 </div>



<div class="row texto">
    <div class="12u">
    <section class="box">
                  <h3>DATOS DE FACTURACION</h3>
                  <div class="row">
                    <div class="12u 12u(mobilep)">
                    
                                         
              
                    <div class="row uniform 50%">

                    <div class="2u 12u(mobilep)">
                      Situación Fiscal:
                        <div class="select-wrapper2">
                         <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlSituacionFiscal" runat="server" required>
                                </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                            </Triggers>
                        </asp:UpdatePanel>
                        </div>
                        </div>
                      
                      <div class="2u 12u(mobilep)">
                      Nombre o razón social:
                        <asp:TextBox ID="txtNombreoRazonSocial" runat="server" placeholder="Nombre o razón social" required></asp:TextBox>
                      </div>
                      

                      
                      <div class="1u 12u(mobilep)">
                      Cuil o Cuit:
                        <asp:TextBox ID="txtCuit" runat="server" placeholder="Cuil o Cuit" required></asp:TextBox>
                      </div>

                       <div class="1u 12u(mobilep)">
                      Cod. Postal:
                        <asp:TextBox ID="txtCodigoPostal" runat="server" placeholder="Cod. Postal" required></asp:TextBox>
                      </div>

                      <div class="2u 12u(mobilep)">
                      Domicilio:
                        <asp:TextBox ID="txtDomicilio" runat="server" placeholder="Domicilio" required></asp:TextBox>
                      </div>

                      <div class="1u 12u(mobilep)">
                      Ciudad:
                        <asp:TextBox ID="txtCiudad" runat="server" placeholder="Ciudad"  required ></asp:TextBox>
                      </div>

                      <div class="2u 12u(mobilep)">
                      Pais:
                        <div class="select-wrapper2">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlPaisTelefonoFactura" runat="server" 
                                    class="" name="quote[destination]" 
                                    data-placeholder="PAIS: " tabindex="1" placeholder="Area" required></asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>                                    
                                </Triggers>
                            </asp:UpdatePanel>
                        </div>
                     </div>


                    </div>





                      <div class="row uniform 50%">
                          <div class="1u 12u(mobilep)">
                             Telefono: 
                             <div class="select-wrapper2">
                               <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlTipoTelefonoFactura" runat="server" required></asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                </Triggers>
                               </asp:UpdatePanel>
                          </div> 
                          </div>                        
                        <div class="3u 12u(mobilep)">
                            Número : <asp:TextBox ID="txtNroLocalFactura" runat="server" Type="Text" placeholder="Número " required></asp:TextBox> 
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
    
              <section class="box sub destaca" style="background-color:#CFFFBF">
                  <h3>Otras personas tambien compraron los siguientes servicios:</h3>
                  <br>
                  <div class="table-wrapper">
                    <table>
                      <thead>
                        <tr style="font-size:1.1em; font-weight: bold;">
                          <th style="width:250px"> </th>
                          <th style="width:60px"> </th>
                          <th style="width:180px"> </th>
                          <th> </th>
                          <th> </th>
                          <th>Cantidad</th>
                          <th></th>
                          <th class="center" style="width:150px">SubTotal</th>
                        </tr>
                      </thead>
                      <tbody>
                        <% otrosproductosintangibles(); %>                                     
                      </tbody>
                      <tfoot>
                        <tr>
                          <td colspan="8" class="rojo" style="font-size:1em; font-weight: bold;">(*) Para pasajeros mayores de 75 años no esta disponible la emision de este producto</td>
                        </tr>
                      </tfoot>
                    </table>
                  </div>                  

                  
</div>
</div>
<div class="row texto">
    <div class="12u">
    <section class="box">
                   <div class="center">
                      <%-- <a id="pagar" onclick="" href="">--%>
                        <asp:Button ID="botonpagar" runat="server" class="btn button specialg" Text="PAGAR" onclick="botonpagar_Click"></asp:Button>
                        <%--<input type="button" value="PAGAR" class="btn button specialg" name="p" onclick="asignarurl('pagar');"/>--%>
                    <%-- </a>--%>
                   </div>
                   <hr>
                   
    </section>
    </div>
    </div>
</div>



<br>
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
