<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="te-llamamos.aspx.cs" Inherits="TuSegurodeViaje.WebSite.te_llamamos" %>

<!doctype html>
<html lang="en">
    <head>
        <title>Tu Seguro de Viaje | CONTACTO </title>
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


<div class="11u indicadorlogo"><h4> <i class="fa fa-phone-square"></i> TE LLAMAMOS?</h4></div>
        <div class="row">
            <div class="11u">
              <section class="box sub">
              <form id="frmtellamamos" class="contact_form" action="te-llamamos.aspx?op=guardar"   method="post" name="contact_form" runat="server"><h3>Solicitud de Informacion</h3>
                  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                  <script type="text/javascript">
                      function ponevisible1() {
                          document.getElementById("ok").style.display = "block";
                          document.getElementById("boton").style.display = "none";
                          //frmtellamamos.submit();                   
                      }
                     </script>
                  <ul>
                      <li>
                          <label for="name">Nombre y Apellido:</label>                          
                          <asp:TextBox ID="txtNombreyApellido" runat="server" placeholder="Juan Lopez" title="Ingrese Nombre y Apellido"  style="height: 2.4em; padding: 4px 4px;" required="required"></asp:TextBox>
                      </li>
                      <li>
                          <label for="tel">Telefono:</label>
                            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlTipoTelefonoContacto" runat="server"  style="width:80px; display: inline-block; height: 3.1em; padding: 4px 4px;" required="required">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                </Triggers>
                             </asp:UpdatePanel>
                            </li> <li>
                             <label for="tel">Pais:</label>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlPaisContacto" runat="server" class="" name="quote[destination]"  data-placeholder="PAIS: "  style="width:100px; display: inline-block; height: 3.1em; padding: 4px 4px;" required="required"></asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                            </Triggers>
                          </asp:UpdatePanel>
                          </li> <li> <label for="tel">Codigo de Area:</label>
                            <asp:TextBox ID="txtCodigoArea" runat="server"  pattern="[0-9]{3,10}" required="required" style="width:90px; display: inline-block;height: 2.4em; padding: 4px 4px;" autocomplete="off"></asp:TextBox>
                          </li> <li><label for="tel">Numero de telefono:</label>
                            <asp:TextBox ID="txtNrodeTelefono" runat="server" placeholder="Numero"  pattern="[0-9]{3,10}" required="required" style="display: inline-block; height: 2.4em; padding: 4px 4px;" autocomplete="off"></asp:TextBox>                            
                      </li>
                      <li>
                          <label for="email">Email:</label>
                          <asp:TextBox ID="txtEmail" runat="server" style="height: 2.4em; padding: 4px 4px;" placeholder="juan@example.com" autocomplete="off" required="required"></asp:TextBox>
                          <span class="form_hint">Formato aprobado "juan@example.com"</span>
                      </li>
                      <li id="boton" style="display:block;">
                        <button class="submit" type="submit" onclick="ponevisible1();">ENVIAR</button>
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
