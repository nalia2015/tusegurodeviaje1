<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="TuSegurodeViaje.WebSite.contacto" %>

<!doctype html>
<html lang="en">
    <head>
        <title>CONTACTO | Tu Seguro de Viaje</title>
        <meta name="description" content="tu seguro de viaje"/>
        <meta charset="utf-8">
        <meta name="author" content=""/>
        <meta name="format-detection" content="telephone=yes">
        <meta name="viewport" content="initial-scale=1">
        <link rel="icon" type="image/png" href="assets/images/favicon.png" />
        
        <link rel="stylesheet" href="assets/css/main.css" />
        <link rel="stylesheet" href="assets/css/mainboos.css" />
       
        
    </head>
<body class="landingcampare">
  <div id="page-wrapper1" class="container contactotop">
  <div id="innerpago" class="texto">


<div class="11u indicadorlogo"><h4> <i class="fa fa-xs fa-envelope"></i> CONTACTO</h4></div>
        <div class="row">
            <div class="11u">

<section class="box sub">
<form id="frmcontacto" class="contact_form" action="contacto.aspx?op=guardar"  method="post" name="contact_form" runat="server"  ><h3>Solicitud de Informacion</h3>

<script type="text/javascript">
    function ponevisible1() {
        document.getElementById("ok").style.display = "block";
        document.getElementById("boton").style.display = "none";
        //frmcontacto.submit();      
    }
  </script>
    <ul>
        <li>
            <label for="name">Nombre y Apellido:</label>            
            <asp:TextBox ID="txtNombreyApellido" runat="server" title="Ingrese Nombre y Apellido"  required="required"></asp:TextBox>
        </li>
        <li>
            <label for="email">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox>
            <span class="form_hint">Formato aprobado "juan@example.com"</span>
        </li>
        
        <li>
            <label for="message">Mensaje:</label>
            <asp:TextBox ID="txtMensaje" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
        </li>
        <li id="boton" style="display:block;">          
          <button class="submit" type="submit"  onclick="ponevisible1();">ENVIAR</button>
        </li>
        <li id="ok" style="display:none; background-color:#458DCB; color:fff" >
          <h2 style="color:fff">Su mensaje a sido enviado correctamente</h2>
        </li>       
    </ul>
</form>
</section>

        </div>
        </div>

    </div>
    </div>

</body>
</html>
