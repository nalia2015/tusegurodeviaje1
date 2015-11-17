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
    public partial class verplan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){

            if (!IsPostBack){

                if (Request.QueryString["email"] != null)
                {
                    if (Request.QueryString["email"].ToString() == "enviar")
                    {

                        imprimecomparativa();
                    }
                }
            }
            else {

                if (hdfenviamensaje.Value == "OK"){

                    imprimecomparativa();
                }
            }
        }

        public void muestracomparativa(){
            String opciones = "";
            DataSet ds = new DataSet();
            DataSet dsCompara = new DataSet();
            SqlDataAdapter adapter;
            String valorcobertura = "-";
            String tabla = "";
            Boolean band = false;
            int planes = 0;
          
            opciones = Request.QueryString["op"];   
            try
            {
                tabla = "<div class='table-wrapper tipotabla'>" +
                   "<table>" +
                     "<thead>" +
                       "<tr>" +
                         "<td class='center'><br><span class='titulocompare'>PLAN</span><br>" +
                         "<span class='tituloenviar'><a href='Reportes/visorcondicionesgrales.aspx?op=" + Request.QueryString["op"].ToString() + "'><i class='fa fa-file-pdf-o'></i> Ver Condiciones Generales</a></span><br>" +
                         "<span class='tituloenviar'><a href='verplan.aspx?op=" + Request.QueryString["op"] + "&email=enviar' onclick='ponevisibleenviarpdf();'><i class='fa fa-envelope-o'></i> Enviar comparativa en PDF</a></span>";

                   tabla +=" <td class='center'> " +
                        " <img alt='AXA Assistance USA logo' src='images/logos/Travelex.gif' height='36' width='100'><br> " +
                        " <span class='plan-cost'>TIT PLAN1</span><br> " +
                        " <input class='button special small' name='productCode:TXFP' value='COMPRAR' type='submit'> " +
                        "</td> ";

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
                                    
                            System.Data.SqlClient.SqlConnection conn1;
                            conn1 = new System.Data.SqlClient.SqlConnection();
                            conn1.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                            conn1.Open();
                            SqlCommand command1 = new SqlCommand("spselComparativa", conn1);
                            command1.CommandType = CommandType.StoredProcedure;
                            command1.Parameters.AddWithValue("IDProducto", Convert.ToInt32(Request.QueryString["op"].ToString()));
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

                            tabla += " </tr> ";
                            dsCompara.Dispose();
                        }
                    }

                    ds.Dispose();                 
                    

                    tabla += "</tbody> "+
                             "</table> " +
                             "</div>";
                
                Response.Write(tabla);                
            }
            catch (Exception ex){
                lblError.Text =  ex.Message;
            }
            finally{
            }

        }

        private void imprimecomparativa()
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
            String archivo = "";
            DataTable dtComparativa = new DataTable();
            DataSet dsComparativa = new DataSet();


            dtComparativa.Columns.Add("Producto");
            dtComparativa.Columns.Add("Cobertura");
            dtComparativa.Columns.Add("Importe");


            opciones = Request.QueryString["op"];
            Datos = opciones.Split('*');
            planes = (Datos.Count() - 1);

            try
            {


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

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {

                    for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
                    {
                        for (int j = 0; j < Datos.Count() - 1; j++)
                        {

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
                            for (int z = 0; z < dsCompara.Tables[0].Rows.Count; z++)
                            {
                                if (ds.Tables[0].Rows[x]["IdCobertura"].ToString() == dsCompara.Tables[0].Rows[z]["IdCobertura"].ToString())
                                {

                                    DataRow row = dtComparativa.NewRow();
                                    row["Producto"] = dsCompara.Tables[0].Rows[x]["Nombre"].ToString();
                                    row["Cobertura"] = dsCompara.Tables[0].Rows[x]["Descripcion"].ToString();
                                    row["Importe"] = dsCompara.Tables[0].Rows[x]["ValorCobertura"].ToString();
                                    dtComparativa.Rows.Add(row);
                                    band = true;
                                    break;
                                }
                            }
                            dsCompara.Dispose();
                        }
                    }
                }

                ds.Dispose();

                dsComparativa.Tables.Add(dtComparativa);

                ReportDocument reporte = new ReportDocument();
                reporte.Load(Server.MapPath("~/Reportes/comparativa.rpt"));
                reporte.SetDataSource(dsComparativa.Tables[0]);
                dsComparativa.Dispose();

                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
                reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                archivo = "C:/Data/Tusegurodeviaje/Reports/TempReports/plan_" + (new Random()).Next() + ".pdf";    
                diskOpts.DiskFileName = archivo;
                reporte.ExportOptions.DestinationOptions = diskOpts;

                reporte.Export();

                enviamensaje(archivo);

            }
            catch (Exception ex)
            {
                lblError.Text = "Error enviando correo electrónico: " + ex.Message;
            }
            finally
            {
            }
        }


      

        private void enviamensaje(String archivo)
        {

            MailMessage mail = new MailMessage();
            //set the addresses
            string emailAddressList = System.Configuration.ConfigurationManager.AppSettings["emailsToSend"];
            string displayName = System.Configuration.ConfigurationManager.AppSettings["displayNameEmailAddressToSendAuthorizationDocs"];
            mail.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["fromEmailAddressToSendAuthorizationDocs"], displayName);
            mail.To.Add(emailAddressList);
            mail.IsBodyHtml = true;
            //set the content
            mail.Subject = "Plan";
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