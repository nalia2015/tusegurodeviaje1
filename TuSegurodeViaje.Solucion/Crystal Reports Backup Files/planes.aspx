<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="planes.aspx.cs" Inherits="TuSegurodeViaje.WebSite.Comparativa" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<!DOCTYPE HTML>
<html>
	<head id="Head1" runat=server>
		<title>Planes | Tu Seguro de Viaje</title>
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
                $(".iframe2").colorbox({ iframe: true, width: "70%", height: "80%" });
                $(".iframe3").colorbox({ iframe: true, width: "50%", height: "80%" });
                $(".iframe4").colorbox({ iframe: true, width: "70%", height: "80%" });
                $(".iframe5").colorbox({ iframe: true, width: "70%", height: "80%" });
                $(".iframe6").colorbox({ iframe: true, width: "70%", height: "80%" });
            });
        </script>


	     <!-- <script src="js/jquery.min.js"></script>-->
	  <script src="js/jquery-ui.js"></script>
		
  		<!--[if lt IE 9]><script src="/js/html5shiv.js"></script><![endif]-->
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
		
	</head>
    <body class="landingcampare">

    <div id="page-wrapper">       


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



        <div class="container" id="compara">
         <br>
         <br>


<div class="flechas">
<ul class="pasosPedido">
    <li class="arrow_box op1 activo">PASO 1. COTIZACION</li>
    <li class="arrow_box op2 ">PASO 2. DATOS PERSONALES</li>
    <li class="arrow_box op3 activo2">PASO 3. PAGO</li>
</ul>
</div>

<div class="12u cabe"> 

        <form id="frmPrincipal" runat="server" class="contact_formdos" action="planes.aspx?op=recotizar" method="post" name="contact_formdos">   
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:HiddenField ID="hdfPrecioDesde" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfPrecioHasta" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfPrecioDesde1" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfPrecioHasta1" runat="server" Value="0" />
        <asp:HiddenField ID="hdfOpcionxPrecio" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfOpcionxPrecio1" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfProdCompara" runat="server" Value="0" /> 
        <asp:HiddenField ID="hdfActivaCompara" runat="server" Value="0" /> 
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
        <asp:HiddenField ID="hdfIdProv" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfIdSeg" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfCantPasajeros" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfPrecioPesos" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfPrecioDolar" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfCantDias" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfIdProducto" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfOrdenarPor" runat="server" Value="0"/>
        <asp:HiddenField ID="hdfIdProveedor" runat="server" Value="0"/>
        <script type="text/javascript" >
            function enviar(opcion) {
                var chkB;
                var idseg = '';

                for (var i = 0; i < document.getElementsByName("seg").length; i++) {
                    chkB = document.getElementsByName("seg")[i];
                    if (chkB.checked) {
                        idseg = idseg + chkB.id + '*';
                    }
                }

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
                document.getElementById("hdfEmail").value = document.getElementById("hdfEmail").value;
                document.getElementById("hdfTipoViaje").value = '2';
                document.getElementById("hdfIdSeg").value = idseg.toString();
                document.getElementById("hdfOpcion").value = opcion.toString();
                document.getElementById("hdfCantPasajeros").value = document.getElementById("hdfCantPasajeros").value;
                document.getElementById("hdfIdProducto").value = document.getElementById("hdfIdProducto").value;
                document.getElementById("hdfCadena").value = document.getElementById("hdfOrigen").value + "_" + document.getElementById("hdfDestino").value + "_" + document.getElementById("hdfFechaDesde").value + "_" + document.getElementById("hdfFechaHasta").value + "_" + document.getElementById("hdfEdad1").value + "_" + document.getElementById("hdfEdad2").value + "_" + document.getElementById("hdfEdad3").value + "_" + document.getElementById("hdfEdad4").value + "_" + document.getElementById("hdfEdad5").value + "_" + document.getElementById("hdfEdad6").value + "_" + document.getElementById("hdfEmail").value + "_" + document.getElementById("hdfTipoViaje").value + "_" + document.getElementById("hdfIdProv").value + "_" + document.getElementById("hdfOpcion").value + "_" + document.getElementById("hdfIdSeg").value + "_ " + document.getElementById("hdfIdProducto").value;
                //frmPrincipal.submit();
            }

            function buscarprov() {

                var chkB;
                var idprove = '';
                var cont = 0;

                for (var i = 0; i < document.getElementsByName("prov").length; i++) {
                    chkB = document.getElementsByName("prov")[i];
                    if (chkB.checked) {
                        idprove = idprove + chkB.id + '*';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) {

                    document.getElementById("hdfIdProv").value = idprove;
                }
                else {
                    document.getElementById("hdfIdProv").value = '';
                }

                document.getElementById("hdfOpcion").value = 'recotizar';
                frmPrincipal.submit();
            }

            function buscarseg() {

                var chkB;
                var idseg = '';
                var cont = 0;

                for (var i = 0; i < document.getElementsByName("seg").length; i++) {
                    chkB = document.getElementsByName("seg")[i];
                    if (chkB.checked) {
                        idseg = idseg + chkB.id + '*';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) {

                    document.getElementById("hdfIdSeg").value = idseg;
                }
                else {
                    document.getElementById("hdfIdSeg").value = '';
                }

                document.getElementById("hdfOpcion").value = 'buscarseg';
                document.getElementById("hdfTipoViaje").value = '2';
                frmPrincipal.submit();
            }

            function contarfiltros() {

                var chkB;
                var idprove = '';
                var cont = 0;
                var contarplanes = 0;

                for (var i = 0; i < document.getElementsByName("prov").length; i++) {
                    chkB = document.getElementsByName("prov")[i];
                    if (chkB.checked) {
                        cont = cont + 1;
                    }
                }

                for (var i = 0; i < document.getElementsByName("seg").length; i++) {
                    chkB = document.getElementsByName("seg")[i];
                    if (chkB.checked) {
                        cont = cont + 1;
                    }
                }

                if (document.getElementById("hdfOpcionxPrecio").value.toString() == "1") {
                    document.getElementById("precioC1").value = document.getElementById("hdfPrecioDesde").value;
                    document.getElementById("precioC2").value = document.getElementById("hdfPrecioHasta").value;
                    cont = cont + 1;
                }

                if (document.getElementById("hdfOpcionxPrecio1").value.toString() == "2") {
                    document.getElementById("precioT1").value = document.getElementById("hdfPrecioDesde1").value;
                    document.getElementById("precioT2").value = document.getElementById("hdfPrecioHasta1").value;
                    cont = cont + 1;
                }

                if (cont > 0) {
                    document.getElementById("lblValorFiltro").innerHTML = cont;
                }

                cont = 0;
                contarplanes = 0;
                for (var i = 0; i < document.getElementsByName("compara").length; i++) {
                    chkB = document.getElementsByName("compara")[i];
                    contarplanes = contarplanes + 1;
                    if (chkB.checked) {
                        idprod = idprod + chkB.id + '*';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) {
                    document.getElementById("hdfProdCompara").value = idprod;
                    document.getElementById("habilitacompara").className = "quote-compbar selectedPlanStatus";
                    document.getElementById("cantplanes").innerHTML = cont;
                }
                else {
                    document.getElementById("hdfProdCompara").value = '0';
                    document.getElementById("habilitacompara").className = "quote-compbar selectedPlanStatus hide";
                    document.getElementById("cantplanes").innerHTML = '0';
                }

                if (contarplanes > 0)
                    document.getElementById("lblCantPlanes").innerHTML = contarplanes;
                else
                    document.getElementById("lblCantPlanes").innerHTML = '0';

            }

            function sacarfiltros() {

                for (var i = 0; i < document.forms["frmPrincipal"].elements.length; i++) {
                    if (document.forms["frmPrincipal"].elements[i].type == "checkbox") {
                        document.forms["frmPrincipal"].elements[i].checked = false
                    }
                }

                document.getElementById("hdfIdProv").value = '';
                document.getElementById("hdfOpcionxPrecio").value = '0';
                document.getElementById("hdfOpcionxPrecio1").value = '0';
                document.getElementById("hdfPrecioDesde").value = '0';
                document.getElementById("hdfPrecioHasta").value = '0';
                document.getElementById("hdfPrecioDesde1").value = '0';
                document.getElementById("hdfPrecioHasta1").value = '0';
                document.getElementById("hdfIdSeg").value = '0';
                document.getElementById("hdfTipoViaje").value = '1';
                document.getElementById("hdfOpcion").value = 'recotizar';
                frmPrincipal.submit();

            }

            function buscarxprecio(opcion) {
                var chkB;
                var idseg = '';
                var cont = 0;

                if (opcion.toString() == "1") {
                    document.getElementById("hdfOpcionxPrecio").value = opcion;
                }

                if (opcion.toString() == "2") {
                    document.getElementById("hdfOpcionxPrecio1").value = opcion;
                }

                for (var i = 0; i < document.getElementsByName("seg").length; i++) {
                    chkB = document.getElementsByName("seg")[i];
                    if (chkB.checked) {
                        idseg = idseg + chkB.id + '*';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) {

                    document.getElementById("hdfIdSeg").value = idseg;
                }
                else {
                    document.getElementById("hdfIdSeg").value = '';
                }

                document.getElementById("hdfOpcion").value = 'buscarseg';
                document.getElementById("hdfTipoViaje").value = '2';

                document.getElementById("hdfPrecioDesde").value = document.getElementById("precioC1").value;
                document.getElementById("hdfPrecioHasta").value = document.getElementById("precioC2").value;
                document.getElementById("hdfPrecioDesde1").value = document.getElementById("precioT1").value;
                document.getElementById("hdfPrecioHasta1").value = document.getElementById("precioT2").value;
                document.getElementById("hdfOpcion").value = 'recotizar';
                frmPrincipal.submit();
            }


            function cuentacompara() {

                var chkB;
                var idprod = '';
                var cont = 0;

                for (var i = 0; i < document.getElementsByName("compara").length; i++) {
                    chkB = document.getElementsByName("compara")[i];
                    if (chkB.checked) {
                        idprod = idprod + chkB.id + '*';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) {
                    document.getElementById("hdfProdCompara").value = idprod;
                    document.getElementById("habilitacompara").className = "quote-compbar selectedPlanStatus";
                    document.getElementById("cantplanes").innerHTML = cont;
                }
                else {
                    document.getElementById("hdfProdCompara").value = '0';
                    document.getElementById("habilitacompara").className = "quote-compbar selectedPlanStatus hide";
                    document.getElementById("cantplanes").innerHTML = '0';
                }
            }


            function comparaplan() {
                document.getElementById("hdfActivaCompara").value = '1';
            }

            function muestracompara() {
                frmPrincipal.submit();
            }

            function cargaprove() {
                var url = document.getElementById("envio").getAttribute('href');
                var inputValue = 'compara.aspx?op=' + document.getElementById("hdfProdCompara").value;
                document.getElementById("envio").setAttribute('href', inputValue);
            }

            function ordenarpor(opcion) {
                document.getElementById("hdfOrdenarPor").value = opcion.toString();
                document.getElementById("hdfOpcion").value = 'recotizar';
                frmPrincipal.submit();
            }

            function muestravistagrilla() {
                var chkB;
                var idseg = '';

                for (var i = 0; i < document.getElementsByName("seg").length; i++) {
                    chkB = document.getElementsByName("seg")[i];
                    if (chkB.checked) {
                        idseg = idseg + chkB.id + '*';
                    }
                }

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
                document.getElementById("hdfEmail").value = document.getElementById("hdfEmail").value;
                document.getElementById("hdfTipoViaje").value = '2';
                document.getElementById("hdfIdSeg").value = idseg.toString();
                document.getElementById("hdfOpcion").value = 'vistalista';
                document.getElementById("hdfCantPasajeros").value = document.getElementById("hdfCantPasajeros").value;
                document.getElementById("hdfCadena").value = document.getElementById("hdfOrigen").value + "_" + document.getElementById("hdfDestino").value + "_" + document.getElementById("hdfFechaDesde").value + "_" + document.getElementById("hdfFechaHasta").value + "_" + document.getElementById("hdfEdad1").value + "_" + document.getElementById("hdfEdad2").value + "_" + document.getElementById("hdfEdad3").value + "_" + document.getElementById("hdfEdad4").value + "_" + document.getElementById("hdfEdad5").value + "_" + document.getElementById("hdfEdad6").value + "_" + document.getElementById("hdfEmail").value + "_" + document.getElementById("hdfTipoViaje").value + "_" + document.getElementById("hdfIdProv").value + "_" + document.getElementById("hdfOpcion").value + "_" + document.getElementById("hdfIdSeg").value;

                var url = document.getElementById("vistagrilla").getAttribute('href');
                var inputValue = 'planes_ver.aspx?op=' + document.getElementById("hdfCadena").value;
                document.getElementById("vistagrilla").setAttribute('href', inputValue);
            }

            function comprar(tarifafinalpesos, tarifafinaldolar, cantpasajeros, cantdias, idproducto, idproveedor) {

                document.getElementById("hdfOrigen").value = document.getElementById("ddlOrigen").value;
                document.getElementById("hdfDestino").value = document.getElementById("ddlDestino").value;
                document.getElementById("hdfFechaDesde").value = document.getElementById("datepicker").value;
                document.getElementById("hdfFechaHasta").value = document.getElementById("datepicker2").value;
                document.getElementById("hdfEmail").value = document.getElementById("hdfEmail").value;
                document.getElementById("hdfCantPasajeros").value = cantpasajeros;
                document.getElementById("hdfCantDias").value = cantdias;
                document.getElementById("hdfPrecioPesos").value = tarifafinalpesos;
                document.getElementById("hdfPrecioDolar").value = tarifafinaldolar;
                document.getElementById("hdfEdad1").value = document.getElementById("txtEdad1").value;
                document.getElementById("hdfEdad2").value = document.getElementById("txtEdad2").value;
                document.getElementById("hdfEdad3").value = document.getElementById("txtEdad3").value;
                document.getElementById("hdfEdad4").value = document.getElementById("txtEdad4").value;
                document.getElementById("hdfEdad5").value = document.getElementById("txtEdad5").value;
                document.getElementById("hdfEdad6").value = document.getElementById("txtEdad6").value;
                document.getElementById("hdfIdProducto").value = idproducto;
                document.getElementById("hdfIdProveedor").value = idproveedor;
                document.getElementById("hdfOpcion").value = 'comprar';
                //frmPrincipal.submit();
            }

      </script>

<div class="3u indicadormenos"><h4>COMPARANDO <asp:Label ID="lblCantPlanes" runat="server" Text="0"></asp:Label> PLANES</h4></div>

<!-- inicio de float-->
<div class="8u cotizador ">
    
<!-- inicio recategorizacion-->
        <div class="inner55mio " >

           <div class="innerbox flexbox">
            <div class="row 50%">
                    <!-- STARTS destination group-->
                    <div class="">
                    <div class="controlsmio">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddlOrigen" runat="server" 
                                class="" name="quote[destination]" 
                                data-placeholder="ORIGEN: " tabindex="1" 
                                onselectedindexchanged="ddlOrigen_SelectedIndexChanged" required="required"></asp:DropDownList>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlOrigen" EventName="SelectedIndexChanged"/>
                    </Triggers>
                    </asp:UpdatePanel></div>
                    </div>


                    <div class="">
                    <div class="controlsmio ">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlDestino" runat="server" 
                            class="" name="quote[destination]" 
                            data-placeholder="DESTINO: " 
                            onselectedindexchanged="ddlDestino_SelectedIndexChanged" required="required"></asp:DropDownList>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlId="ddlDestino" EventName="SelectedIndexChanged"/>
                    </Triggers>
                    </asp:UpdatePanel></div>
                    </div>


                    <!-- ENDS destination group-->
                    <div class="departure-date22">
                       <div class="controlsmio">
                        <script>
                            $(function ($) {
                                $.datepicker.regional['es'] = {
                                    closeText: 'Cerrar',
                                    /*prevText: '<Ant',
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
                                $("#datepicker, #datepicker2").datepicker();
                            });
                            </script>
                         <asp:TextBox id="datepicker" runat="server" class="" placeholder="SALIDA: " maxlength="8" size="6"  tabindex="3" autocomplete="off" required="required"></asp:TextBox>
                        </div>
                       </div>
                    <!-- ENDs Departure date group-->
                    
                    <div class="return-date22">
                    <div class="controlsmio"><asp:TextBox id="datepicker2" runat="server" class="" placeholder="REGRESO: " maxlength="8" size="7" type="text" tabindex="4" autocomplete="off" required="required"></asp:TextBox></div> 
                    </div>
                    

                        <div class="return-date">
                        <div class="controlsmio"><asp:TextBox name="quote[returnDate]" ID="txtEdad1" runat="server"  class="" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="6" min="0" max="99" autocomplete="off" required="required"></asp:TextBox></div>
                        </div>

                        <div class="return-date">
                        <div class="controlsmio"><asp:TextBox name="quote[returnDate]" ID="txtEdad2" runat="server" class="" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="7" min="0" max="99" autocomplete="off" ></asp:TextBox></div>
                        </div>

                        <div class="return-date22">
                        <div class="controlsmio"><asp:TextBox name="quote[returnDate]" ID="txtEdad3" runat="server" class="" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="8" min="0" max="99" autocomplete="off" ></asp:TextBox></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmio"><asp:TextBox name="quote[returnDate]" ID="txtEdad4" runat="server" class="" placeholder="Edad" maxlength="2" size="3" type="number" tabindex="9" min="0" max="99" autocomplete="off" ></asp:TextBox></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmio"><asp:TextBox name="quote[returnDate]" ID="txtEdad5" runat="server" class="" placeholder="Edad" maxlength="3" size="3" type="number" tabindex="10" min="0" max="99" autocomplete="off" ></asp:TextBox></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmio"><asp:TextBox name="quote[returnDate]" ID="txtEdad6" runat="server" class="" placeholder="Edad" maxlength="3" size="3" type="number" tabindex="11" min="0" max="99" autocomplete="off" ></asp:TextBox></div>
                        </div>
                        <div class="return-date22">
                        <div class="controlsmio"><input name="quote[returnDate]" class="descuento" placeholder="COD. DESCUENTO" maxlength="8" size="8" type="text" tabindex="11" id="p6" style="background-color:#FFE549" title="Si posee un CODIGO DE DESCUENTO ingréselo aquí" autocomplete="off"></div>
                        </div>
                        <div class="return-date22"><button class="button2 specialg" onclick="enviar('recotizar');" type="submit">RECOTIZAR <i class="fa fa-chevron-right fa-lg">&nbsp;</i></button>
                        </div>


                        <!-- ENDS Return date group-->

               
                   <!--fin edades-->
                   
       
                </div>
            </div>
        </div>
<!--fin recotizacion-->





</div>

<!--finde float   -->     
</div>



<div class="grid__container-pad " style="margin-top:-11px;">
<div class="grid__row">
<div class="grid__filters">
<script src="js/bootstrap-collapse.js"></script>
<div class="bs-example">
    <div class="panel-group" id="accordion">
        <div class="panel panel-default">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseOneblock">Filtro(<asp:Label ID="lblValorFiltro" runat="server" Text="0"></asp:Label>)</a><a id="resetFilters" style="cursor:pointer" onclick="sacarfiltros();">Limpiar</a>
                </h4>
            </div>
            <div id="collapseOne" class="panel-collapse collapse in">
                <div class="panel-body">
                   

<div class="bs-example">
    <div class="panel-group" id="accordion2">
        <div class="panel panel-default">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion2" href="#collapseOne1">Tipo de viaje <i class="fa fa-caret-down"></i></a>
                </h4>
            </div>
            <div id="collapseOne1" class="panel-collapse collapse in">
                <div class="panel-body">
                    
										<ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-plantype">
                                          <% cargarfiltrosSegmentos(); %>
                                        </ul>

                </div>
            </div>
        </div>
        <div class="panel panel-default">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion2" href="#collapseTwo2">Proveedores <i class="fa fa-caret-down"></i></a>
                </h4>
            </div>
            <div id="collapseTwo2" class="panel-collapse collapse in">
                <div class="panel-body">
                    <ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-coverage">
                                         <% cargarfiltrosproveedores(); %>
                                        </ul>
                </div>
            </div>
        </div>
        <div class="panel panel-default">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion2" href="#collapseThree3">Por cobertura: <i class="fa fa-caret-down"></i></a>
                </h4>
            </div>
            <div id="collapseThree3" class="panel-collapse collapse in">
                <div class="panel-body">
                    					<ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-coverage">
                                            <li class="filter__disabled">
                                                <span>Tope de cobertura: </span> <br>
                                                Desde:<input class="span1 filter-coverage add input-small" value="Precio" type="text" maxlength="" size="3" id="precioC1" />&nbsp;&nbsp;
                                                Hasta:<input class="span1 filter-coverage add input-small" value="Precio" type="text" maxlength="" size="3" onchange="buscarxprecio(1);" id="precioC2"/></li>
                                        </ul>
                </div>
            </div>
     </div>

<div class="panel panel-default">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a data-toggle="collapse" data-parent="#accordion2" href="#collapseThree4">Por tarifa: <i class="fa fa-caret-down"></i></a>
                </h4>
            </div>
            

                <div id="collapseThree4" class="panel-collapse collapse in">
                <div class="panel-body">
                                        <ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-coverage">
                                            <li class="filter__disabled">
                                                <span>Tarifa: </span> <br>
                                                Desde:<input class="span1 filter-coverage add input-small" value="Precio" type="text" maxlength="" size="3" id="precioT1"/>&nbsp;&nbsp;
                                                Hasta:<input class="span1 filter-coverage add input-small" value="Precio" type="text" maxlength="" size="3" onchange="buscarxprecio(2);" id="precioT2"/></li>
                                            
                                        </ul>
                </div>
            </div>
        </div>

    </div>
</div>

                </div>
           </div>
        </div>
    </div>
</div>
                 </div>
                <div class="grid__quoteresults">
   <!--End Quote Message-->

                   <!-- inicio ordena -->
                   <div class="product-list-tools well-dark1 well-sm">

                        <div class="view-as"> Ver como
                            <a id="vistagrilla" class="view-ctl grid " href="planes_ver.aspx" title="Ver Columnas" onclick="muestravistagrilla();"><i class="fa fa-lg fa-columns"></i></a>
                            <a class="view-ctl list btn-active" href="#" title="Ver Lista"><i class="fa fa-lg fa-align-justify"></i></a>
                        </div>
                        <!-- show all was here -->

                            
                            <div class="sort-by pull-right" style=""> 
                            <div id="UpdatePanel5" style="display: inline-block; margin-right:20px;">Ordenar por Cobertura <a href="#" title="Descendente" onclick="ordenarpor('1');"><i class="fa fa-caret-down"></i></a> <a href="#" title="Ascendente" onclick="ordenarpor('2');"><i class="fa fa-caret-up"></i></a></div>
                            <div id="UpdatePanel5" style="display: inline-block;">Ordenar por Tarifa <a href="#" title="Menor precio" onclick="ordenarpor('3');" ><i class="fa fa-caret-down"></i></a> <a href="#" title="Mayor precio" onclick="ordenarpor('4');" ><i class="fa fa-caret-up"></i></a></div>
                            </div>

                    </div>
                    <!-- fin ordena -->



                    <div id="missingPlansToCompareModal" class="modal  fade" tabindex="-1" role="dialog" aria-labelledby="missingPlansToCompareModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                    <h3 id="missingPlansToCompareModalLabel">Comparar planes</h3>
                                </div>
                                
                                <div class="modal-footer">
                                    <button class="btn btn-default" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class='quoteCompareResults'>

                    <script type="text/javascript">
                        function ponevisible1() {
                            document.getElementById("uno").style.display = "none";
                        }
                        function ponevisible2() {
                            document.getElementById("uno2").style.display = "none";
                        }
                        function ponevisible3() {
                            document.getElementById("uno3").style.display = "none";
                        }

                    </script>
                            <form action="#" method="POST">
                                <div class='quoteCompareDisplay'>                         
                                      <% mostrarresultcotiza(); %>  
                                </div>
                            </form>
                        </div>
                 </div>

            </div>
        </div>
    </div>

<%--     </form>--%>
                        <script type="text/javascript">
                            function ponevisiblecomparar() {
                                document.getElementById("cerrarcomparar").style.display = "none";
                            }
                       </script>

    <!-- COMPARE PLANS BOTTOM FIXED BAR -->


<!-- Naty esta clase hide oculta, sin hide muestra, hay que programarlo segun select de checbox
<div class="quote-compbar selectedPlanStatus hide">-->
<div id="habilitacompara"class="quote-compbar selectedPlanStatus     " id="cerrarcomparar" style="background-color:#000">
        <div class="quote-compbar__container collapsed">
            <a onclick="ponevisiblecomparar();" class="quote-compbar__close selectedPlanClose close-btn" title="Cerrar Comparar Planes"><i class="fa fa-times"></i></a>
            <div class="quote-compbar__selected-plans">
                <span class="selectedPlanCount"><asp:Label ID="cantplanes" runat="server" Text="Label"></asp:Label></span>
                <span class="selectedPlanSingular hide">Plan seleccionado . Añadir al menos uno más para comparar.</span>
                <span class="selectedPlanPlural">Planes seleccionados para comparar</span>
            </div>
            <div class="quote-compbar__btn-wrap" >
         <a id="envio" class="quote-compbar__btn comparePlansButton btn btn-lg btn-primary iframe" href="compara.aspx" onclick="cargaprove();">Comparar planes</a>
            </div>
        </div>
    </div>
<!-- fin Compare planes cartel-->

        
    <div id="loadingBox">
  <div class="loadingContent">
    <i class="fa fa-lg fa-refresh spin"></i><br>
    <span class="loadingText"></span> 
  </div>
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
        </div><!-- -->		<!--<script src="1js2/jquery113.min.js"></script>
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
