<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compara.aspx.cs" Inherits="TuSegurodeViaje.WebSite.Comparativa" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>

<!doctype html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
    <!--<![endif]-->
   <head runat=server>
		<title>Tu Seguro de Viaje</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
		<link rel="stylesheet" href="assets/css/main.css" />
        <link rel="stylesheet" href="assets/css/mainboos.css" />
		<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->

	</head>

    <form id="frmPrincipal" runat="server" >   
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

        <script type="text/javascript" >
            function enviar(opcion) {
                var chkB;
                var idseg = '';

                for (var i = 0; i < document.getElementsByName("seg").length; i++) {
                    chkB = document.getElementsByName("seg")[i];
                    if (chkB.checked) {
                        idseg = idseg + chkB.id + '_';
                    }
                }

                document.getElementById("hdfOrigen").value = document.getElementById("ddlOrigen").value;
                document.getElementById("hdfDestino").value = document.getElementById("ddlDestino").value;
                document.getElementById("hdfFechaDesde").value = document.getElementById("txtFechaDesde").value;
                document.getElementById("hdfFechaHasta").value = document.getElementById("txtFechaHasta").value;
                document.getElementById("hdfEdad1").value = document.getElementById("txtEdad1").value;
                document.getElementById("hdfEdad2").value = document.getElementById("txtEdad2").value;
                document.getElementById("hdfEdad3").value = document.getElementById("txtEdad3").value;
                document.getElementById("hdfEdad4").value = document.getElementById("txtEdad4").value;
                document.getElementById("hdfEdad5").value = document.getElementById("txtEdad5").value;
                document.getElementById("hdfEdad6").value = document.getElementById("txtEdad6").value;
                document.getElementById("hdfEmail").value = document.getElementById("txtEmail").value;
                document.getElementById("hdfTipoViaje").value = '2';
                document.getElementById("hdfIdSeg").value =  idseg.toString();
                document.getElementById("hdfOpcion").value = opcion.toString();
                document.getElementById("hdfCadena").value = document.getElementById("hdfOrigen").value + "_" + document.getElementById("hdfDestino").value + "_" + document.getElementById("hdfFechaDesde").value + "_" + document.getElementById("hdfFechaHasta").value + "_" + document.getElementById("hdfEdad1").value + "_" + document.getElementById("hdfEdad2").value + "_" + document.getElementById("hdfEdad3").value + "_" + document.getElementById("hdfEdad4").value + "_" + document.getElementById("hdfEdad5").value + "_" + document.getElementById("hdfEdad6").value + "_" + document.getElementById("hdfEmail").value + "_" + document.getElementById("hdfTipoViaje").value + "_" + document.getElementById("hdfIdProv").value + "_" + document.getElementById("hdfOpcion").value; ;
                frmPrincipal.submit();
            }


            function buscarprov() {

                var chkB;
                var idprove = '';
                var cont = 0;

                for (var i = 0; i < document.getElementsByName("prov").length; i++) {
                    chkB = document.getElementsByName("prov")[i];
                    if (chkB.checked) {
                        idprove = idprove + chkB.id + '_';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) 
                {
                   
                    document.getElementById("hdfIdProv").value = idprove;                    
                }
                else 
                {
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
                        idseg = idseg + chkB.id + '_';
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

                    if (document.getElementById("hdfOpcionxPrecio").value.toString() == "1") 
                    {
                        document.getElementById("precioA1").value = document.getElementById("hdfPrecioDesde").value;
                        document.getElementById("precioA2").value = document.getElementById("hdfPrecioHasta").value;
                        cont=cont+1;
                    }

                   if (document.getElementById("hdfOpcionxPrecio1").value.toString() == "2")  
                    {
                        document.getElementById("precioE1").value = document.getElementById("hdfPrecioDesde1").value;
                        document.getElementById("precioE2").value = document.getElementById("hdfPrecioHasta1").value;
                        cont=cont+1;
                    }

                    if (cont > 0) {

                       document.getElementById("lblValorFiltro").innerHTML  = cont;                                       
                   }

               }

            function sacarfiltros() {

                for (var i=0;i < document.forms["frmPrincipal"].elements.length;i++)
                    {
                        if (document.forms["frmPrincipal"].elements[i].type == "checkbox") 
                            {
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

            function buscarxprecio(opcion) 
            {
                if (opcion.toString() == "1") {
                    
                    document.getElementById("hdfOpcionxPrecio").value = opcion;
                }
                if (opcion.toString() == "2") {                   
                    document.getElementById("hdfOpcionxPrecio1").value = opcion;
                }

                document.getElementById("hdfPrecioDesde").value = document.getElementById("precioA1").value;
                document.getElementById("hdfPrecioHasta").value = document.getElementById("precioA2").value;
                document.getElementById("hdfPrecioDesde1").value = document.getElementById("precioE1").value;
                document.getElementById("hdfPrecioHasta1").value = document.getElementById("precioE2").value;              
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
                        idprod = idprod + chkB.id + '_';
                        cont = cont + 1;
                    }
                }

                if (cont > 0) {
                    document.getElementById("hdfProdCompara").value = idprod;
                }
                else {
                    document.getElementById("hdfProdCompara").value = '0';
                
                }               

            }


            function comparaplan() {
               document.getElementById("hdfActivaCompara").value = '1';               
               frmPrincipal.submit();
            }

            
                
    </script>

    <body class="landingcampare">
		<div id="page-wrapper">
        <header id="header" class="alt2">
					<h1><a href="index.aspx" class="logotu">&nbsp;</a></h1>
					<nav id="nav">
						<ul>
							<!--<li><a href="index.html">Inicio</a></li>-->
							<li>
								<a href="#" class="icon fa-angle-down">Nosotros</a>
								<ul>
									<li><a href="la-empresa.html">La Empresa</a></li>
                                    <li><a href="staff-especialidad.html">Staff & Especialidad</a></li>
                                    <li><a href="objetivo-filosofia.html">Objetivo & Filosofia</a></li>
                                    <li><a href="ventajas-para-nuestros-clientes.html">Ventajas para nuestros clientes</a></li>
                                    <li><a href="medios-de-pago.html">Medios de Pago</a></li>
                                    <li><a href="certificaciones.html">Certificaciones</a></li>
                                    <li><a href="seguridad-del-sitio.html">Seguridad del Sitio</a></li>
                                    <li><a href="por-que-elegirnos.html">Por que elegirnos</a></li>
									<li>
										<a href="#">otros</a>
										<ul>
											<li><a href="#">otros1</a></li>
											<li><a href="#">otros2</a></li>
											<li><a href="#">otros3</a></li>
											<li><a href="#">otros4</a></li>
										</ul>
									</li>
								</ul>
							</li>
                            <li>
								<a href="#" class="icon fa-angle-down">Productos</a>
								<ul>
									<li><a href="seguro-de-viaje-obligatorio-a-cuba.html">Seguro de Viaje obligatorio a Cuba</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-venezuela.html">Seguro de Viaje obligatorio a Venezuela</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-europa.html">Seguro de Viaje obligatorio a Europa</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-schengen.html">Seguro de Viaje Schengen</a></li>
                                    <li><a href="seguro-de-viaje-obligatorio-a-usa.html">Seguro de Viaje obligatorio a USA</a></li>
                                    
                                </ul>   
                            </li>
                            
                            
							
                            <li>&nbsp;</li>
                            <li class="ftel"><a href="#" class="icon fa-mobile ftel ">08003335555</a></li>
                            <li>&nbsp;</li>
                            <li><a href="#" class="icon fa-angle-down"><img src="images/ban/argentina.jpg" width="16" height="11"></a></li>
						</ul>
					</nav>
				</header>



        <div class="container" id="compara">
         <br>
         <br>

                    <div class="inner55">
                    <div class="innerbox">
					<div id="quote-form-a" class="row uniform 50%">
					<!-- STARTS destination group-->
					<div class="destination">
					<!--<label title="Cual es el Origen de su viaje?">Origen</label>-->
					<div class="controls">

					 <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                <asp:DropDownList ID="ddlOrigen" runat="server" 
                                        class="quoteForm form-control js-focusfix" name="quote[destination]" 
                                        data-placeholder="ORIGEN: Ciudad" tabindex="1" 
                                        onselectedindexchanged="ddlOrigen_SelectedIndexChanged" ></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="ddlOrigen" EventName="SelectedIndexChanged"/>
                            </Triggers>
                    </asp:UpdatePanel>		                    
                                        
                    </div>
					</div>

                    
					<div class="">
					<!--<label title="Cual es el destino de su viaje?">Destino</label>-->
					<div class="">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                         <ContentTemplate>
                                <asp:DropDownList ID="ddlDestino" runat="server" 
                                    class="quoteForm form-control js-focusfix" name="quote[destination]" 
                                    data-placeholder="DESTINO: Ciudad" 
                                    onselectedindexchanged="ddlDestino_SelectedIndexChanged"></asp:DropDownList>
                         </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlId="ddlDestino" EventName="SelectedIndexChanged"/>
                        </Triggers>
                    </asp:UpdatePanel>		                    			
                    
                    </div>
					</div>
                    
					<!-- ENDS destination group--><!-- STARTS Departure date group-->
					<div class="departure-date">
					<div class="controls">
					<!--<input name="quote[departureDate]" class="form-control input-small quoteForm" placeholder="SALIDA: Fecha" maxlength="10" size="15" type="text" tabindex="3" id="dp1440468543969">-->
                        <asp:TextBox ID="txtFechaDesde" runat="server" class="form-control input-small quoteForm" placeholder="SALIDA: Fecha" maxlength="10" size="15"  tabindex="3"></asp:TextBox>
                            <ajaxtoolkit:CalendarExtender ID="CFechaDesde" runat="server" TargetControlID="txtFechaDesde" Format="dd/MM/yyyy"  CssClass="form-control input-small quoteForm"  >
                        </ajaxtoolkit:CalendarExtender>

                    </div>
					
					</div>
					<!-- ENDS Departure date group-->
					<!-- STARTS Return date group-->
					<div class="return-date">
					<div class="controls">
                    <!--<input name="quote[returnDate]" class="form-control input-small quoteForm" placeholder="REGRESO: Fecha" maxlength="10" size="15" type="text" tabindex="4" />-->
                        <asp:TextBox ID="txtFechaHasta" runat="server" class="form-control input-small quoteForm" placeholder="REGRESO: Fecha" maxlength="10" size="15" type="text" tabindex="4"></asp:TextBox>
                        <ajaxtoolkit:CalendarExtender ID="CFechaHasta" runat="server" TargetControlID="txtFechaHasta" Format="dd/MM/yyyy"  CssClass="form-control input-small quoteForm"></ajaxtoolkit:CalendarExtender>    

                    </div>
					</div>
					<!-- ENDS Return date group-->



					
					</div>



</div>
</div>




<section id="banner55">
<!--inicio edades-->
<section id="banner22">
<div class="inner77" >
<div class="innerbox77">
<div  class="row uniform 50%">
<!-- STARTS destination group-->
<!-- ENDS destination group--><!-- STARTS Departure date group-->

<!-- ENDS Departure date group-->
<!-- STARTS Return date group-->
<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="6" id="dp1440468543970">-->
<asp:TextBox ID="txtEdad1" runat="server"  class="" placeholder="Edad" maxlength="2" size="2" type="text" tabindex="3" ></asp:TextBox>
</div>
</div>

<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="7" id="dp1440468543970">-->
<asp:TextBox ID="txtEdad2" runat="server" class="" placeholder="Edad" maxlength="2" size="2" type="text" tabindex="3" ></asp:TextBox>
</div>
</div>

<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="8" id="dp1440468543970">-->
<asp:TextBox ID="txtEdad3" runat="server" class="" placeholder="Edad" maxlength="2" size="2" type="text" tabindex="3" ></asp:TextBox>
</div>
</div>
<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="9" id="dp1440468543970">-->
<asp:TextBox ID="txtEdad4" runat="server" class="" placeholder="Edad" maxlength="2" size="2" type="text" tabindex="3" ></asp:TextBox>
</div>
</div>
<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="10" id="dp1440468543970">-->
<asp:TextBox ID="txtEdad5" runat="server" class="" placeholder="Edad" maxlength="2" size="3" type="text" tabindex="3" ></asp:TextBox>
</div>
</div>
<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="11" id="dp1440468543970">-->
<asp:TextBox ID="txtEdad6" runat="server" class="" placeholder="Edad" maxlength="3" size="3" type="text" tabindex="3"></asp:TextBox>
</div>
</div>


<div class="destination">
<!--<label title="Cual es el destino de su viaje?">Destino</label>-->
<div class="controls">

<!--<select class="quoteForm form-control js-focusfix" name="quote[destination]" data-placeholder="Tipo de viaje" tabindex="12">
<option selected="selected" value="" disabled="disabled">Tipo de viaje</option>
<option value="9">Cover Plus</option><option value="4">Deporte</option><option value="5">Multiviaje para viajero frecuente</option><option value="1">Turismo, estudio, negocios</option><option value="8">Work and Travel</option></select>
								
</select>-->

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    <asp:DropDownList ID="ddlTipodeViaje" runat="server"
      class="quoteForm form-control js-focusfix" name="quote[destination]" 
      data-placeholder="Tipo de viaje" OnSelectedIndexChanged="ddlTipodeViaje_SelectedIndexChanged" />    
</ContentTemplate>
<Triggers>
       <asp:AsyncPostBackTrigger ControlId="ddlTipodeViaje" EventName="SelectedIndexChanged"/>
</Triggers>
</asp:UpdatePanel>		

</div>
</div>


<div class="return-date">
<div class="controls">
<!--<input name="quote[returnDate]" class="form-control input-small quoteForm datepicker-return hasDatepicker" placeholder="Su mail" maxlength="30" size="20" type="text" tabindex="13" id="dp1440468543970">-->
<asp:TextBox ID="txtEmail" runat="server" class="" placeholder="Su mail" maxlength="30" size="10" type="text" tabindex="3"></asp:TextBox>
</div>
</div>


<!-- ENDS Return date group-->

<div class="controls">
<a class="btn btn-primary btn-xs quote-form-btn-a" href="#" onclick="enviar('recotizar');" tabindex="4">COTIZAR <i class="fa fa-chevron-right fa-lg">&nbsp;</i></a>
</div>
</div>


</section>
<!--fin edades-->

</section>
       
           </div>
        </div>

        <!-- number of plans showing-->
	    <div class="grid__container-pad ">

               
            <div class="grid__row">
                <div class="grid__filters">
                    

                    <div class="panel-group quoteresults-filters" id="accordion2">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseOne">
                                    Filtro(<span id="filters-count"><asp:Label ID="lblValorFiltro" runat="server" Text="0"></asp:Label></span>)</a>
                                <a id="resetFilters" style="cursor:pointer" onclick="sacarfiltros();">Reset</a>
                            </div>
                            <div id="collapseOne" class="panel-collapse in collapse">
                                <div class="panel-body">
                                    <div class="filter-group">
                                        <h4 class="filter-group" id="group-plantype">Segmentos <i class="fa fa-caret-down"></i></h4>
                                        <ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-plantype">
                                             <% cargarfiltrosSegmentos(); %>
                                        </ul>
                                    </div>
                                    <div class="filter-group">
                                        <h4 class="filter-group" id="group-coverage">Proveedores <i class="fa fa-caret-down"></i></h4>
                                        <ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-coverage">
                                             <% cargarfiltrosproveedores(); %>
                                        </ul>
                                    </div>

							        <div class="filter-group">
                                        <h4 class="filter-group" id="group-coverage">Por cobertura en caso de:  <i class="fa fa-caret-down"></i></h4>
                                        <ul style="list-style-type:none; margin-left: 0; padding-left: 0;" class="group-coverage">
                                            <li class="filter__disabled">                                               
                                                
                                                <span>Accidente</span> <br>
                                                Desde:<input class="" value="Precio"  type="text" id="precioA1"/>
                                                Hasta:<input class="filter-coverage add input-small" value="Precio" type="text" size="3" onchange="buscarxprecio(1);" id="precioA2" /></li>
                                             <li class="filter__disabled">
                                                <span>Enfermedad</span> <br>
                                                Desde:<input class="" value="Precio" type="text"  id="precioE1"/>
                                                Hasta:<input class="filter-coverage add input-small" value="Precio" type="text"  size="3"  onchange="buscarxprecio(2);" id="precioE2"/></li>                                                                                         
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        
                    </div>

                </div>
                <div class="grid__quoteresults">                                 
                
                <!--End Quote Message-->

                    <div id="noPlansMatchFiltersModal" class="modal  fade" tabindex="-1" role="dialog" aria-labelledby="noPlansMatchFiltersModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                    <h3 id="noPlansMatchFiltersModalLabel">No Plans Found</h3>
                                </div>
                                <div class="modal-body">
                                    
                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-default" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div id="presetFilterNoPlansModal" class="modal  fade" tabindex="-1" role="dialog" aria-labelledby="presetFilterNoPlansModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                    <h3 id="presetFilterNoPlansModalLabel">No Plans Found</h3>
                                </div>
                                <div class="modal-body">
                                    No hay planes disponibles
                                    
                                    <span class='filterList'></span>
                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-default" data-dismiss="modal" aria-hidden="true">Close</button>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div id="noPlansToCompareModal" class="modal  fade" tabindex="-1" role="dialog" aria-labelledby="noPlansToCompareModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                    <h3 id="noPlansToCompareModalLabel">No Plans to Compare</h3>
                                </div>
                                <div class="modal-body">
                                    Sorry, based on your current quote information, the products you selected
                                    to compare are no-longer available.<br/>
                                    Please update your quote and try again.
                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-default" data-dismiss="modal" aria-hidden="true">Close</button>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div id="missingPlansToCompareModal" class="modal  fade" tabindex="-1" role="dialog" aria-labelledby="missingPlansToCompareModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                                    <h3 id="missingPlansToCompareModalLabel">Comparar planes</h3>
                                </div>
                                <div class="modal-body">
                                    Disculpe, uno o más de los productos seleccionados ya no están disponibles.
                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-default" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class='quoteCompareResults'>
                            <form action="#" method="POST">
                                <div class='quoteCompareDisplay'>       
                                    <% mostrarresultcotiza(); %>       
                                </div>
                            </form>
                        </div>
                 </div>

                 <div>
                    <% muestracomparacion(); %>                 
                 </div>

            </div>
        </div>
    </div>

    <!-- COMPARE PLANS BOTTOM FIXED BAR -->       


    <div id="loadingBox">
  <div class="loadingContent">
    <i class="fa fa-lg fa-refresh spin"></i><br>
    <span class="loadingText"></span> 
  </div>
</div>

    <footer class="footer noIndex">
    <div class="container">
    <div class="row js-snapengage-load">
        <div class=" col-lg-12">
            <div class="row">
             
                <div class="footer-link-farm about-us">
                    <h3><a href="../../../about/index.html">Nosotros</a></h3>
                    <ul class="link-list">
                        <li><a href="../../../about/#">La Empresa</a></li>
                        <li><a href="../../../about/#">Staff & Especialidad</a></li>
                        <li><a href="../../../about/#">Objetivo & Filosofía</a></li>
                        <li><a href="../../../about/#">Ventajas para nuestros clientes</a></li>
                    </ul>
                </div>
                <div class="footer-link-farm">
                    <h3><a href="../../../about/#">Servicios al Cliente</a></h3>
                    <ul class="link-list">


                        <li><a href="../../../about/#">Comparar Seguros de Viaje</a></li>
                        <li><a href="../../../about/#">Garantia de mejor oferta</a></li>
                        <li><a href="../../../about/#">Atencion al Cliente - Mesa de Ayuda</a></li>
                        <li><a href="../../../about/#">Oficinas comerciales</a></li>
                        <li><a href="../../../about/#">Partners y Alianzas promocionales</a></li>
                        <li><a href="../../../about/#">Noticias y Novedades</a></li>
                        <li><a href="../../../about/#">Galeria</a></li>
                        <li><a href="../../../about/#">Preguntas Frecuentes</a></li>
                        <li><a href="../../../about/#">Testimoniales</a></li>
                        <li><a href="../../../about/#">Blog</a></li>
                    </ul>
                </div>
                <div class="footer-link-farm">
                    <h3><a href="../../../about/#">Seguro de Viaje</a></h3>
                    <ul class="link-list">
                        <li><a href="../../../about/#">Compañias de Asistencia en Viaje</a></li>
                        <li><a href="../../../about/#">Coberturas, Prestaciones y Servicios</a></li>
                        <li><a href="../../../about/#">Seguro de Viaje obligatorio a Cuba</a></li>
                        <li><a href="../../../about/#">Seguro de Viaje obligatorio a Venezuela</a></li>
                        <li><a href="../../../about/#">Seguro de Viaje obligatorio a Europa</a></li>
                        <li><a href="../../../about/#">Seguro de Viaje Schengen</a></li>
                        <li><a href="../../../about/#">Seguro de Viaje obligatorio a USA</a></li>
                        <li><a href="../../../about/#">Tipos de Seguros de Viaje</a></li>

                    </ul>
                </div>
                
                
                
                <div class="footer-connect-farm"><h2 class="phone-number"><i class="fa fa-phone"></i> 800-3335555</h2>

                    <!-- Send us a message -->
                    <a class="btn btn-info btn-lg newsletter-btn" href="../../../contact/index.html" title="Enviar su mensaje">
                        <i class="fa fa-envelope"></i> Enviar su mensaje</a>

                    <!-- Mail Chimp Newsletter -->
                    <div id="mc_embed_signup" class="mailchimp-load">
                        <form action="" method="post" id="mc-embedded-subscribe-form" name="mc-embedded-subscribe-form" class="validate" target="_blank" novalidate>
                            <div class="mc-field-group">
                                <label for="mce-EMAIL">Subscribir al newsletter</label>
                                <div class="clear">
                                    <input value="Subscribe" name="subscribe" id="mc-embedded-subscribe" class="btn btn-info btn-xs button" type="submit"></div>
                                <input value="" name="EMAIL" class="form-control required email" id="mce-EMAIL" placeholder="email" type="email">
                            </div>
                            <div id="mce-responses" class="clear">
                                <div class="response" id="mce-error-response" style="display:none"></div>
                                <div class="response" id="mce-success-response" style="display:none"></div>
                            </div>
                            
                            <div style="position: absolute; left: -5000px;"><input name="b_9100312b8f2ad5a183667b53e_fb87093922" tabindex="-1" value="" type="text"></div>
                        </form>
                    </div>
                    <!-- End Mail Chimp -->

                    <div class="social-buttons"> <a id="social-button-facebook" href="https://www.facebook.com/" target="blanc" title="Connect with  on Facebook"><i class="fa fa-facebook-square"></i></a> <a id="social-button-twitter" href="https://twitter.com/" target="blanc" title="Follow Insure My Trip"><i class="fa fa-twitter-square"></i></a> <a id="social-button-google-plus" href="https://plus.google.com/" target="blanc" title="Connect on Google+"><i class="fa fa-google-plus-square"></i></a> <a id="social-button-linkedin" href="http://www.linkedin.com/company/" target="blanc" title=" company on LinkedIn"><i class="fa fa-linkedin-square"></i></a>
                        <a id="social-button-google-plus" href="http://www.youtube.com/user/" target="blank" title=" company on YouTube"><i class="fa fa-youtube-square"></i></a>
                        <a id="social-button-pinterest" href="http://www.pinterest.com/" target="blanc" title=" company on Pinterest"><i class="fa fa-pinterest"></i></a>
                    </div>

                </div>
                
                
                
            </div>

        </div>

        <!-- ENDS row of 5 columns -->

        
    </div>
    </div>
    </footer>

	<footer id="footer " class="piegris" >

	<div class="izq22">
	<ul class="icons">
					<li><a href="#"><img src="images/garantizado.png"  alt="" /></a></li>
					<li><a href="#"><img src="images/secure.png"  alt="" /></a></li>
					<li><a href="#"><img src="images/pdp.png"  alt="" /></a></li>
					<li><a href="#"><img src="images/cace.png"  alt="" /></a></li>
					<li><a href="#"><img src="images/datafiscal.png"  alt="" /></a></li>
												
				</ul>
			</div>
	<div style="margin-left:20px;">
		<a href="#"><img  src="images/formadepago1.jpg"  alt="" /></a>
	</div>
    	

	</footer>
		
	<footer id="footer pieblanco" class="pieblanco" >

	<div style="margin-left:20px;"><a href="#" class=""><span class="">TuSegurodeViaje.net</span></a> | Telefono: +54 11 5235 3998   |   General San Martín 3430,Piso 2, Oficina 201, Edificio Florida Office,  Florida Oeste, Buenos Aires, Argentina</div>
							
	</footer>


	</div>

	<!-- Scripts -->
		<script src="assets/js/jquery.min.js"></script>
		<script src="assets/js/jquery.dropotron.min.js"></script>
		<script src="assets/js/jquery.scrollgress.min.js"></script>
		<script src="assets/js/skel.min.js"></script>
		<script src="assets/js/util.js"></script>
		<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
		<script src="assets/js/main.js"></script>
    </form>
    </body>
</html>
