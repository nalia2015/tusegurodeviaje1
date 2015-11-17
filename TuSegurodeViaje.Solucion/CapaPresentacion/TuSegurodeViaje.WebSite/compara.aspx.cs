using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using CrystalDecisions.ReportSource;

namespace TuSegurodeViaje.WebSite
{
    public partial class compara : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                cargardatos();

                if (Request.QueryString["email"] != null)
                {
                    if (Request.QueryString["email"].ToString() == "enviar")
                    {
                        //enviamensaje();
                        imprimecomparativa();
                    }
                }
            }
            else
            {

                if (Request.QueryString["email"] != null)
                {
                    if (Request.QueryString["email"].ToString() == "enviar")
                    {
                        //enviamensaje();
                        imprimecomparativa();
                    }
                }

            }
        }


        private void cargardatos() {
            String[] DatosViaje;
            String opciones = "";
            opciones = Request.QueryString["op"];          
            DatosViaje = opciones.Split('_');

            try
            {
                //lblOrigen.Text = DatosViaje[1].ToString();
                //lblDestino.Text =DatosViaje[2].ToString();
                //lblSalida.Text = DatosViaje[3].ToString();
                //lblLlegada.Text = DatosViaje[4].ToString();
                //lblCantPersonas.Text = DatosViaje[5].ToString();
            }
            catch (Exception ex) {
            }
            finally { 
            }              
        
        }


        public void muestracomparativa()
        {
            String opciones = "";
            String[] Datos;
            DataSet ds = new DataSet();
            DataSet dsCompara = new DataSet();
            SqlDataAdapter adapter;
            String valorcobertura = "-";
            String tabla = "";
            Boolean band = false;
            int planes = 0;
            String[] DatosViaje;

            opciones = Request.QueryString["op"];          
            Datos = opciones.Split('*');          
            planes = (Datos.Count() - 1);
            DatosViaje = opciones.Split('_');  

            try{

                tabla = "<div class='table-wrapper tipotabla'> " +
                        " <table> " +
                        " <thead> " +
                        " <tr> " +
                        "<td class='center'><br><br><span class='titulocompare'>COMPARAR PLANES</span></td> " +
                        //"<span class='tituloenviar'><a onclick='ponevisibleenviarpdf();'><i class='fa fa-envelope-o'></i> Enviar comparativa en PDF</a></span> " +
                        " <span class='tituloenviar'><a href='compara.aspx?op=" + Request.QueryString["op"] + "&email=enviar' onclick='enviamensaje();'><i class='fa fa-envelope-o'></i> Haga click  AQUÍ para descargar la comparación </a></span> " +
                        "<script type='text/javascript'>" +
                           " function ponevisibleenviarpdf(){ " +
                                " document.getElementById('enviarpdf').style.display='block'; " +
                       " } " +
                       "   function enviamensaje() { " +
                       "       document.getElementById('hdfenviamensaje').value = 'envia'; " +
                       "       frmCompara.submit(); " +
                       " } " +
                       " </script> " +
                       " <div id='enviarpdf' style='display:none' > " +
                           " <div class='mc-field-group'>" +
                               " <div class='clear'>" +
                               " <input value='' name='EMAIL' class='' id='mce-EMAIL' placeholder='Ingrese e-mail' type='email' style='margin:10px; width:90%;'> " +
                               " <input class='button special2 small' name='enviar' value='Enviar' type='submit'> " +
                           "</div> " +
                       "</div> " +
                       "</td> ";

                    for (int i = 0; i < Datos.Count()-1; i++){
                        tabla += "<td class='center'> " +
                                        " <img alt='AXA Assistance USA logo' src='images/logos/Travelex.gif' height='36' width='100'><br> " +
                                        " <span class='plan-cost'>TIT PLAN1</span><br> " +
                                        " <input class='button special small' name='productCode:TXFP' value='COMPRAR' type='submit'> " +
                                 "</td> ";
                    }

                    tabla += "</tr> " +
                            "</thead>";
                        
                    System.Data.SqlClient.SqlConnection conn;
                    conn = new System.Data.SqlClient.SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                    conn.Open();
                    SqlCommand command = new SqlCommand("spselCoberturas", conn);
                    command.CommandType = CommandType.StoredProcedure;                            
                    command.ExecuteNonQuery();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    conn.Close();

                    tabla+="<tbody> " ;    
                            
                    if ((ds != null) && (ds.Tables[0].Rows.Count > 0)){ 
                        for (int x = 0; x < ds.Tables[0].Rows.Count; x++) {
                            tabla += " <tr> " +
                                     " <th>" + ds.Tables[0].Rows[x]["Descripcion"].ToString() + "</th> ";
                                    
                            for (int j = 0; j < Datos.Count() - 1; j++) {                    
                                     
                                System.Data.SqlClient.SqlConnection conn1;
                                conn1 = new System.Data.SqlClient.SqlConnection();
                                conn1.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                                conn1.Open();
                                SqlCommand command1 = new SqlCommand("spselComparativa", conn1);
                                command1.CommandType = CommandType.StoredProcedure;
                                command1.Parameters.AddWithValue("IDProducto", Convert.ToInt32(Datos[j].ToString()));
                                command1.ExecuteNonQuery();
                                adapter = new SqlDataAdapter(command1);
                                adapter.Fill(dsCompara);
                                conn1.Close();

                                valorcobertura = "-";
                                band = false;
                                for (int z = 0; z < dsCompara.Tables[0].Rows.Count; z++) {                                                
                                        if (ds.Tables[0].Rows[x]["IdCobertura"].ToString() == dsCompara.Tables[0].Rows[z]["IdCobertura"].ToString()) {
                                        valorcobertura = " <td>" + dsCompara.Tables[0].Rows[x]["SimboloMoneda"].ToString() + " " + dsCompara.Tables[0].Rows[x]["ValorCobertura"].ToString() + "</td> ";
                                        band=true;
                                        break;
                                    }
                                }
                                if (band==true)
                                     tabla += valorcobertura;
                                else
                                    tabla += " <td>-</td> ";
                                
                                dsCompara.Dispose();
                            }

                                tabla += " </tr> ";                                         
                        }
                    }

                    ds.Dispose();
                    conn.Close();

                    tabla += "</tbody> "+
                             "</table> " +
                             "</div> ";

                Response.Write(tabla);
                
            }

            catch (Exception ex){
                Response.Write(ex.Message);            
            }
            finally { }
        }


        private void imprimecomparativa()
        {

            String opciones = "";
            String[] Datos;
            String[] DatosViaje;
            DataSet ds = new DataSet();
            DataSet dsCompara = new DataSet();
            SqlDataAdapter adapter;
            int planes = 0;
            String edades = "";
            DataTable dtComparativa = new DataTable();
            DataSet dsComparativa = new DataSet();
            String email = "";


            dtComparativa.Columns.Add("Producto");
            dtComparativa.Columns.Add("Cobertura");
            dtComparativa.Columns.Add("Importe");


            opciones = Request.QueryString["op"];
            Datos = opciones.Split('*');
            planes = (Datos.Count() - 1);

            try
            {

                DataTable dtPresu = new DataTable();                
                DataSet dsPresu = new DataSet();

                opciones = Request.QueryString["op"];
                DatosViaje = opciones.Split('_');

                email = DatosViaje[6].ToString();
                
                if (DatosViaje[7].ToString()!= "" )
                    edades = DatosViaje[7].ToString();
                
                if (DatosViaje[8].ToString() != "")
                    edades = edades + "/" + DatosViaje[8].ToString();
                
                if (DatosViaje[9].ToString() != "")
                    edades = edades + "/" + DatosViaje[9].ToString();
                
                if (DatosViaje[10].ToString() != "")
                    edades = edades + "/" + DatosViaje[10].ToString();

                if (DatosViaje[11].ToString() != "")
                    edades = edades + "/" + DatosViaje[11].ToString();
                
                if (DatosViaje[12].ToString() != "")
                    edades = edades + "/" + DatosViaje[12].ToString();


                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                conn.Open();
                SqlCommand command = new SqlCommand("spselImprimeCotizacion", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("FechaDesde", DatosViaje[3].ToString());
                command.Parameters.AddWithValue("FechaHasta", DatosViaje[4].ToString());
                command.Parameters.AddWithValue("idOrigen", DatosViaje[1].ToString());
                command.Parameters.AddWithValue("IdDestino", DatosViaje[2].ToString());
                command.Parameters.AddWithValue("Email", DatosViaje[6].ToString());
                command.Parameters.AddWithValue("edades", edades);

                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dsPresu);
                conn.Close();


                
                DataSet dsPresuCompara = new DataSet();
                DataTable dtPresuCompara = new DataTable();

                dtPresuCompara.Columns.Add("Producto");
                dtPresuCompara.Columns.Add("Producto2");
                dtPresuCompara.Columns.Add("Producto3");
                dtPresuCompara.Columns.Add("Producto4");

                dtPresuCompara.Columns.Add("Cobertura1");
                dtPresuCompara.Columns.Add("Cobertura2");
                dtPresuCompara.Columns.Add("Cobertura3");
                dtPresuCompara.Columns.Add("Cobertura4");
                dtPresuCompara.Columns.Add("Cobertura5");
                dtPresuCompara.Columns.Add("Cobertura6");

                dtPresuCompara.Columns.Add("ValorCobertura_1");
                dtPresuCompara.Columns.Add("ValorCobertura_1_2");
                dtPresuCompara.Columns.Add("ValorCobertura_1_3");
                dtPresuCompara.Columns.Add("ValorCobertura_1_4");
                dtPresuCompara.Columns.Add("ValorCobertura_1_5");
                dtPresuCompara.Columns.Add("ValorCobertura_1_6");

                dtPresuCompara.Columns.Add("ValorCobertura_2");
                dtPresuCompara.Columns.Add("ValorCobertura_2_2");
                dtPresuCompara.Columns.Add("ValorCobertura_2_3");
                dtPresuCompara.Columns.Add("ValorCobertura_2_4");
                dtPresuCompara.Columns.Add("ValorCobertura_2_5");
                dtPresuCompara.Columns.Add("ValorCobertura_2_6");

                dtPresuCompara.Columns.Add("ValorCobertura_3");
                dtPresuCompara.Columns.Add("ValorCobertura_3_2");
                dtPresuCompara.Columns.Add("ValorCobertura_3_3");
                dtPresuCompara.Columns.Add("ValorCobertura_3_4");
                dtPresuCompara.Columns.Add("ValorCobertura_3_5");
                dtPresuCompara.Columns.Add("ValorCobertura_3_6");

                dtPresuCompara.Columns.Add("ValorCobertura_4");
                dtPresuCompara.Columns.Add("ValorCobertura_4_2");
                dtPresuCompara.Columns.Add("ValorCobertura_4_3");
                dtPresuCompara.Columns.Add("ValorCobertura_4_4");
                dtPresuCompara.Columns.Add("ValorCobertura_4_5");
                dtPresuCompara.Columns.Add("ValorCobertura_4_6");

                dtPresuCompara.Columns.Add("Pasajero");
                dtPresuCompara.Columns.Add("Inicio");
                dtPresuCompara.Columns.Add("Fin");
                dtPresuCompara.Columns.Add("Origen");
                dtPresuCompara.Columns.Add("Destino");
                dtPresuCompara.Columns.Add("cantdias");
                dtPresuCompara.Columns.Add("cantpasajeros");
                dtPresuCompara.Columns.Add("edades");

                dtPresuCompara.Columns.Add("tarifa1");
                dtPresuCompara.Columns.Add("promo1");
                dtPresuCompara.Columns.Add("comision1");
                dtPresuCompara.Columns.Add("Neto1");

                dtPresuCompara.Columns.Add("tarifa2");
                dtPresuCompara.Columns.Add("promo2");
                dtPresuCompara.Columns.Add("comision2");
                dtPresuCompara.Columns.Add("Neto2");

                dtPresuCompara.Columns.Add("tarifa3");
                dtPresuCompara.Columns.Add("promo3");
                dtPresuCompara.Columns.Add("comision3");
                dtPresuCompara.Columns.Add("Neto3");

                dtPresuCompara.Columns.Add("tarifa4");
                dtPresuCompara.Columns.Add("promo4");
                dtPresuCompara.Columns.Add("comision4");
                dtPresuCompara.Columns.Add("Neto4");

                dtPresuCompara.Columns.Add("IdProducto");
                dtPresuCompara.Columns.Add("IdProducto2");
                dtPresuCompara.Columns.Add("IdProducto3");
                dtPresuCompara.Columns.Add("IdProducto4");


                DataRow rowComp = dtPresuCompara.NewRow();

                int columnas = 4;

                for (int p = 0; p < dsPresu.Tables[0].Rows.Count; p++){
                       
                        for (int j = 0; j < Datos.Count() - 1; j++){

                            if ((Datos[j].ToString() == dsPresu.Tables[0].Rows[p]["IdProducto"].ToString())||(Datos[j].ToString() == dsPresu.Tables[0].Rows[p]["IdProducto2"].ToString())||(Datos[j].ToString() == dsPresu.Tables[0].Rows[p]["IdProducto3"].ToString())||(Datos[j].ToString() == dsPresu.Tables[0].Rows[p]["IdProducto4"].ToString())){

                                if (columnas == 4){

                                    rowComp["Producto"] = dsPresu.Tables[0].Rows[p]["Producto"].ToString();
                                    rowComp["IdProducto"] = dsPresu.Tables[0].Rows[p]["IdProducto"].ToString();
                                    rowComp["Cobertura1"] = "Asistencia Médica por Enfermedad";
                                    rowComp["Cobertura2"] = "Asistencia Médica por Accidente";
                                    rowComp["Cobertura3"] = "Asistencia Médica por preexistencias";
                                    rowComp["Cobertura4"] = "Compensacion por cancelación de viaje";
                                    rowComp["Cobertura5"] = "Compensacion por pérdida de equipaje (línea aérea)";
                                    rowComp["Cobertura6"] = "Compensacion por vuelo demorado o cacelado";

                                    rowComp["ValorCobertura_1"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_1"].ToString();
                                    rowComp["ValorCobertura_1_2"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_1_2"].ToString();
                                    rowComp["ValorCobertura_1_3"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_1_3"].ToString();
                                    rowComp["ValorCobertura_1_4"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_1_4"].ToString();
                                    rowComp["ValorCobertura_1_5"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_1_5"].ToString();
                                    rowComp["ValorCobertura_1_6"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_1_6"].ToString();

                                    rowComp["Pasajero"] = dsPresu.Tables[0].Rows[p]["Pasajero"].ToString();
                                    rowComp["Inicio"] = dsPresu.Tables[0].Rows[p]["Inicio"].ToString();
                                    rowComp["Fin"] = dsPresu.Tables[0].Rows[p]["Fin"].ToString();
                                    rowComp["Origen"] = dsPresu.Tables[0].Rows[p]["Origen"].ToString();
                                    rowComp["Destino"] = dsPresu.Tables[0].Rows[p]["Destino"].ToString();
                                    rowComp["cantdias"] = dsPresu.Tables[0].Rows[p]["cantdias"].ToString();
                                    rowComp["cantpasajeros"] = dsPresu.Tables[0].Rows[p]["cantpasajeros"].ToString();
                                    rowComp["edades"] = dsPresu.Tables[0].Rows[p]["edades"].ToString();

                                    rowComp["tarifa1"] = dsPresu.Tables[0].Rows[p]["tarifa1"].ToString();
                                    rowComp["promo1"] = dsPresu.Tables[0].Rows[p]["promo1"].ToString();
                                    rowComp["comision1"] = dsPresu.Tables[0].Rows[p]["comision1"].ToString();
                                    rowComp["Neto1"] = dsPresu.Tables[0].Rows[p]["Neto1"].ToString();

                                }


                                if (columnas == 3){

                                    rowComp["Producto2"] = dsPresu.Tables[0].Rows[p]["Producto2"].ToString();
                                    rowComp["IdProducto2"] = dsPresu.Tables[0].Rows[p]["IdProducto2"].ToString();
                                    rowComp["ValorCobertura_2"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_2"].ToString();
                                    rowComp["ValorCobertura_2_2"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_2_2"].ToString();
                                    rowComp["ValorCobertura_2_3"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_2_3"].ToString();
                                    rowComp["ValorCobertura_2_4"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_2_4"].ToString();
                                    rowComp["ValorCobertura_2_5"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_2_5"].ToString();
                                    rowComp["ValorCobertura_2_6"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_2_6"].ToString();

                                    rowComp["tarifa2"] = dsPresu.Tables[0].Rows[p]["tarifa2"].ToString();
                                    rowComp["promo2"] = dsPresu.Tables[0].Rows[p]["promo2"].ToString();
                                    rowComp["comision2"] = dsPresu.Tables[0].Rows[p]["comision2"].ToString();
                                    rowComp["Neto2"] = dsPresu.Tables[0].Rows[p]["Neto2"].ToString();

                                }

                                if (columnas == 2){

                                    rowComp["Producto3"] = dsPresu.Tables[0].Rows[p]["Producto3"].ToString();
                                    rowComp["IdProducto3"] = dsPresu.Tables[0].Rows[p]["IdProducto3"].ToString();
                                    rowComp["ValorCobertura_3"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_3"].ToString();
                                    rowComp["ValorCobertura_3_2"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_3_2"].ToString();
                                    rowComp["ValorCobertura_3_3"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_3_3"].ToString();
                                    rowComp["ValorCobertura_3_4"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_3_4"].ToString();
                                    rowComp["ValorCobertura_3_5"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_3_5"].ToString();
                                    rowComp["ValorCobertura_3_6"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_3_6"].ToString();

                                    rowComp["tarifa3"] = dsPresu.Tables[0].Rows[p]["tarifa3"].ToString();
                                    rowComp["promo3"] = dsPresu.Tables[0].Rows[p]["promo3"].ToString();
                                    rowComp["comision3"] = dsPresu.Tables[0].Rows[p]["comision3"].ToString();
                                    rowComp["Neto3"] = dsPresu.Tables[0].Rows[p]["Neto3"].ToString();

                                }

                                if (columnas == 1){

                                    rowComp["Producto4"] = dsPresu.Tables[0].Rows[p]["Producto4"].ToString();
                                    rowComp["IdProducto4"] = dsPresu.Tables[0].Rows[p]["IdProducto4"].ToString();
                                    rowComp["ValorCobertura_4"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_4"].ToString();
                                    rowComp["ValorCobertura_4_2"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_4_2"].ToString();
                                    rowComp["ValorCobertura_4_3"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_4_3"].ToString();
                                    rowComp["ValorCobertura_4_4"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_4_4"].ToString();
                                    rowComp["ValorCobertura_4_5"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_4_5"].ToString();
                                    rowComp["ValorCobertura_4_6"] = dsPresu.Tables[0].Rows[p]["ValorCobertura_4_6"].ToString();

                                    rowComp["tarifa4"] = dsPresu.Tables[0].Rows[p]["tarifa4"].ToString();
                                    rowComp["promo4"] = dsPresu.Tables[0].Rows[p]["promo4"].ToString();
                                    rowComp["comision4"] = dsPresu.Tables[0].Rows[p]["comision4"].ToString();
                                    rowComp["Neto4"] = dsPresu.Tables[0].Rows[p]["Neto4"].ToString();
                                }

                                if ((columnas > 1) && (j+1 < Datos.Count() - 1)){
                                    columnas = columnas - 1;
                                }
                                else{
                                    columnas = 4;
                                    dtPresuCompara.Rows.Add(rowComp);
                                    rowComp = dtPresuCompara.NewRow();
                                }
                            }
                        }                  
                }

                dsPresuCompara.Tables.Add(dtPresuCompara);                                  
                
                ReportDocument rptDoc = new ReportDocument();
                rptDoc.Load(Server.MapPath("~/Reportes/presupuesto1.rpt"));
                rptDoc.SetDataSource(dsPresuCompara.Tables[0]);

                dsPresuCompara.Dispose();

                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();

                string targetFileName = "C:/Data/Tusegurodeviaje/Reports/TempReports/compara_" + (new Random()).Next() + ".pdf";  

                rptDoc.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                rptDoc.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                diskOpts.DiskFileName = targetFileName;

                //archivo = Server.MapPath(targetFileName);                
                rptDoc.ExportOptions.DestinationOptions = diskOpts;

                //Export report ... Server-Side.
                rptDoc.Export();

                enviamensaje(targetFileName, email);

                CrystalReportViewer1.ReportSource = rptDoc;
                rptDoc.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "comparativa");                                               
                

            }
            catch (Exception ex){
                lblError.Text = "Error enviando correo electrónico: " + ex.Message;
            }
            finally{
            }
        }

        private void enviamensaje(String archivo, String email)
        {

            MailMessage mail = new MailMessage();
            //set the addresses
            string emailAddressList = email; //System.Configuration.ConfigurationManager.AppSettings["emailsToSend"];
            string displayName = System.Configuration.ConfigurationManager.AppSettings["displayNameEmailAddressToSendAuthorizationDocs"];
            mail.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["fromEmailAddressToSendAuthorizationDocs"], displayName);
            mail.To.Add(emailAddressList);
            mail.IsBodyHtml = true;
            //set the content
            mail.Subject = "Comparativa";
            //set the body
            mail.Body += "Muchas gracias.<br />";
            mail.Attachments.Add(new Attachment(archivo));

            string SMTPServer = System.Configuration.ConfigurationManager.AppSettings["SMTPServer"];
            SmtpClient smtp = new SmtpClient(SMTPServer); //specify the mail server address

            try{
                smtp.Send(mail);
            }
            catch (Exception ex){
                lblError.Text = "Error enviando correo electrónico: " + ex.Message;
            }
            finally{
            }
        }     
    }
}