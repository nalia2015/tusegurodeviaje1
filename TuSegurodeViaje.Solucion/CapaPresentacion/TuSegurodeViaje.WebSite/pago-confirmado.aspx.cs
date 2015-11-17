using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using mercadopago;

using System.Net;
using System.Net.Mail;

using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using CrystalDecisions.ReportSource;

namespace TuSegurodeViaje.WebSite
{
    public partial class pago_confirmado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["op"] != null)
                    {                       
                            guardardatos();                                              
                    }                           
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
            }

        }

        private void guardardatos()
        {

            DataTable dtFormaPago = new DataTable();
            DataSet dsFormaPago = new DataSet();

            DataTable dtFactura = new DataTable();
            DataSet dsFactura = new DataSet();

            DataSet dsViajeros;
            DataSet dsOtraInfo;
            DataSet dsInfoEmergencia;

            DataSet ds = new DataSet();

            DataSet dsProducto;
            DataSet dsProveedor;
            DataSet dsPrecioPesos;
            DataSet dsPrecioDolar;
            DataSet dsCantidad;
            DataSet dsDatosViaje;

            dsViajeros = (DataSet)Session["Viajeros"];
            dsOtraInfo = (DataSet)Session["OtraInfoViajeros"];
            dsInfoEmergencia = (DataSet)Session["InfoEmergencia"];
            dsFormaPago = (DataSet)Session["InfoFormasdePago"];
            dsFactura = (DataSet)Session["InfoFactura"];
            dsDatosViaje = (DataSet)Session["DatosViaje"];

            dsProducto = (DataSet)Session["Productos"];
            dsProveedor = (DataSet)Session["Proveedor"];
            dsPrecioPesos = (DataSet)Session["PrecioPesos"];
            dsPrecioDolar = (DataSet)Session["PrecioDolar"];
            dsCantidad = (DataSet)Session["Cantidad"];

            String opciones = "";
            String[] Datos;
            int EsProductoAdicional = 0;
            String IdOperacionRetorno = "";

            SqlDataAdapter adapter;
                                 
                        
            try
            {

                MP mp = new MP("3592982235689583", "iwzO6CMeOH6gA0dMYnCtvZZo7L6aUYO3");

                mp.sandboxMode(true);

                Dictionary<String, String> filters = new Dictionary<String, String>();

                filters.Add("status", "success");

                Hashtable searchResult = mp.searchPayment(filters);
                
                ////Hashtable payment_info = mp.getPaymentInfo(Request["id"]);

                ////if ((int)payment_info["status"] == 200){
                ////    Response.Write(payment_info["response"]);
                ////}

                Hashtable payment = (Hashtable)searchResult["response"];

                ArrayList collection = (ArrayList)payment["results"];

                Hashtable items = (Hashtable)collection[0];

                Hashtable item = (Hashtable)items["collection"];

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');
                
                Session.Remove("Viajeros");
                Session.Remove("OtraInfoViajeros");
                Session.Remove("InfoEmergencia");
                Session.Remove("InfoFormasdePago");
                Session.Remove("InfoFactura");
                Session.Remove("DatosViaje");

                Session.Remove("Productos");
                Session.Remove("Proveedor");
                Session.Remove("PrecioPesos");
                Session.Remove("PrecioDolar");
                Session.Remove("Cantidad");

                try
                {
                    if ((dsFactura != null) && (dsFactura.Tables[0].Rows.Count > 0))
                    {
                        if ((dsFormaPago != null) && (dsFormaPago.Tables[0].Rows.Count > 0))
                        {

                            System.Data.SqlClient.SqlConnection conn;
                            conn = new System.Data.SqlClient.SqlConnection();
                            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                            conn.Open();
                            SqlCommand command = new SqlCommand("spOperaciones", conn);
                            command.CommandType = CommandType.StoredProcedure;

                            SqlParameter paramCodRetorno = new SqlParameter("pCodigo", SqlDbType.Int);
                            paramCodRetorno.Direction = ParameterDirection.Output;
                            command.Parameters.Add(paramCodRetorno);
                            command.Parameters.AddWithValue("Facturacion_CodSituacionFiscal", Convert.ToInt32(dsFactura.Tables[0].Rows[0]["SituacionFiscal"].ToString()));
                            command.Parameters.AddWithValue("Facturacion_NombreoRazonSocial", dsFactura.Tables[0].Rows[0]["RazonSocial"].ToString());
                            command.Parameters.AddWithValue("Facturacion_CUILCUIT", dsFactura.Tables[0].Rows[0]["CUILCUIT"].ToString());
                            command.Parameters.AddWithValue("Facturacion_CodigoPostal", dsFactura.Tables[0].Rows[0]["CodigoPostal"].ToString());
                            command.Parameters.AddWithValue("Facturacion_Domicilio", dsFactura.Tables[0].Rows[0]["Domicilio"].ToString());
                            command.Parameters.AddWithValue("Facturacion_Ciudad", dsFactura.Tables[0].Rows[0]["CiudadDomicilio"].ToString());
                            command.Parameters.AddWithValue("Facturacion_IdPais", Convert.ToInt32(dsFactura.Tables[0].Rows[0]["PaisDomicilio"].ToString()));
                            command.Parameters.AddWithValue("Facturacion_TipoTelefono", Convert.ToInt32(dsFactura.Tables[0].Rows[0]["TipoTelefono"].ToString()));
                            command.Parameters.AddWithValue("Facturacion_IdPaisTelefono", Convert.ToInt32(dsFactura.Tables[0].Rows[0]["PaisTelefono"].ToString()));
                            command.Parameters.AddWithValue("Facturacion_CodArea", dsFactura.Tables[0].Rows[0]["CodAreaCiudad"].ToString());
                            command.Parameters.AddWithValue("Facturacion_NroTelefono", dsFactura.Tables[0].Rows[0]["NroLocal"].ToString());
                            command.Parameters.AddWithValue("IdOrigen", Convert.ToInt32(dsDatosViaje.Tables[0].Rows[0]["IdOrigen"].ToString()));
                            command.Parameters.AddWithValue("IdDestino", Convert.ToInt32(dsDatosViaje.Tables[0].Rows[0]["IdDestino"].ToString()));
                            command.Parameters.AddWithValue("IdProducto", Convert.ToInt32(dsDatosViaje.Tables[0].Rows[0]["IdProducto"].ToString()));
                            command.Parameters.AddWithValue("FechaPartida", Datos[0].ToString());
                            command.Parameters.AddWithValue("FechaRegreso", Datos[1].ToString());
                            command.Parameters.AddWithValue("ImporteTarifaPesos", Convert.ToDecimal(Datos[2].ToString()));
                            command.Parameters.AddWithValue("ImporteTarifaDolar", Convert.ToDecimal(Datos[3].ToString()));
                            command.Parameters.AddWithValue("IdFormadePago", Convert.ToInt32(dsFormaPago.Tables[0].Rows[0]["TipoPago"].ToString()));
                            command.Parameters.AddWithValue("IdBancoEmisor", 0);
                            command.Parameters.AddWithValue("IdTarjeta", 0);
                            command.Parameters.AddWithValue("NroTarjeta", 0);
                            command.Parameters.AddWithValue("VtoDia", 0);
                            command.Parameters.AddWithValue("VtoAnio", 0);
                            command.Parameters.AddWithValue("CodigoSeguridad", 0);
                            command.Parameters.AddWithValue("NroCuotas", 0);
                            //command.Parameters.AddWithValue("Id_OperacionMercadoPago", Convert.ToInt32(item["id"]));
                            command.Parameters.AddWithValue("Id_OperacionMercadoPago", 1);
                            command.Parameters.AddWithValue("Estado", 3);
                            command.Parameters.AddWithValue("TipoTelefono", Convert.ToInt32(dsFormaPago.Tables[0].Rows[0]["TipoTelefono"].ToString()));
                            command.Parameters.AddWithValue("CodArea", dsFormaPago.Tables[0].Rows[0]["CodAreaTelefono"].ToString());
                            command.Parameters.AddWithValue("NroTelefono", dsFormaPago.Tables[0].Rows[0]["NroTelefono"].ToString());
                            command.Parameters.AddWithValue("IdPais", Convert.ToInt32(dsFormaPago.Tables[0].Rows[0]["PaisTelefono"].ToString()));
                            command.ExecuteNonQuery();
                            adapter = new SqlDataAdapter(command);
                            conn.Close();
                            IdOperacionRetorno = paramCodRetorno.SqlValue.ToString();
                            lblOperacion.Text = IdOperacionRetorno;

                            if ((dsViajeros != null) && (dsViajeros.Tables[0].Rows.Count > 0))
                            {

                                //if ((dsOtraInfo != null) && (dsOtraInfo.Tables[0].Rows.Count > 0))
                                //{

                                    for (int y = 0; y < dsViajeros.Tables[0].Rows.Count; y++)
                                    {

                                        System.Data.SqlClient.SqlConnection conn1;
                                        conn1 = new System.Data.SqlClient.SqlConnection();
                                        conn1.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                                        conn1.Open();
                                        SqlCommand command1 = new SqlCommand("spPasajeros", conn1);
                                        command1.CommandType = CommandType.StoredProcedure;

                                        SqlParameter paramCodRetorno1 = new SqlParameter("pCodigo", SqlDbType.Int);
                                        paramCodRetorno1.Direction = ParameterDirection.Output;
                                        command1.Parameters.Add(paramCodRetorno1);
                                        command1.Parameters.AddWithValue("Nombre", dsViajeros.Tables[0].Rows[y]["Nombre"].ToString());
                                        command1.Parameters.AddWithValue("Apellido", dsViajeros.Tables[0].Rows[y]["Apellido"].ToString());
                                        command1.Parameters.AddWithValue("FechaNac", dsViajeros.Tables[0].Rows[y]["Fecha"].ToString());
                                        command1.Parameters.AddWithValue("Edad", Convert.ToInt32(dsViajeros.Tables[0].Rows[y]["Edad"].ToString()));
                                        command1.Parameters.AddWithValue("TipoDocu", 1);
                                        command1.Parameters.AddWithValue("NroDocumento", Convert.ToInt32(dsViajeros.Tables[0].Rows[y]["DNI"].ToString()));
                                        command1.Parameters.AddWithValue("IdPaisResidencia", Convert.ToInt32(dsViajeros.Tables[0].Rows[y]["Pais"].ToString()));
                                        command1.Parameters.AddWithValue("Ciudad", dsViajeros.Tables[0].Rows[y]["Ciudad"].ToString());
                                        command1.Parameters.AddWithValue("Domicilio", "");
                                        command1.Parameters.AddWithValue("TipoTelefono", 0);
                                        command1.Parameters.AddWithValue("CodArea", "");
                                        command1.Parameters.AddWithValue("Telefono", "");
                                        command1.Parameters.AddWithValue("Email", dsViajeros.Tables[0].Rows[y]["Email"].ToString());
                                        command1.Parameters.AddWithValue("ContactoEmergencia_Apellido", dsInfoEmergencia.Tables[0].Rows[0]["Apellido"].ToString());
                                        command1.Parameters.AddWithValue("ContactoEmergencia_Nombre", dsInfoEmergencia.Tables[0].Rows[0]["Nombre"].ToString());
                                        command1.Parameters.AddWithValue("ContactoEmergencia_TipoTelefono", Convert.ToInt32(dsInfoEmergencia.Tables[0].Rows[0]["TipoTelefono"].ToString()));
                                        command1.Parameters.AddWithValue("ContactoEmergencia_CodArea", dsInfoEmergencia.Tables[0].Rows[0]["CodCiudad"].ToString());
                                        command1.Parameters.AddWithValue("ContactoEmergencia_Telefono", dsInfoEmergencia.Tables[0].Rows[0]["NumeroLocal"].ToString());
                                        command1.Parameters.AddWithValue("ContactoEmergencia_Email", dsInfoEmergencia.Tables[0].Rows[0]["Email"].ToString());
                                        command1.Parameters.AddWithValue("ContactoEmergencia_IdPaisResidencia", Convert.ToInt32(dsInfoEmergencia.Tables[0].Rows[0]["Pais"].ToString()));
                                        command1.Parameters.AddWithValue("ContactoEmergencia_Ciudad", "");
                                        command1.Parameters.AddWithValue("InfoContacto_Apellido", dsOtraInfo.Tables[0].Rows[0]["Apellido"].ToString());
                                        command1.Parameters.AddWithValue("InfoContacto_Nombre", dsOtraInfo.Tables[0].Rows[0]["Nombre"].ToString());
                                        command1.Parameters.AddWithValue("InfoContacto_TipoTelefono", Convert.ToInt32(dsOtraInfo.Tables[0].Rows[0]["TipoTelefono"].ToString()));
                                        command1.Parameters.AddWithValue("InfoContacto_CodArea", dsOtraInfo.Tables[0].Rows[0]["CodCiudad"].ToString());
                                        command1.Parameters.AddWithValue("InfoContacto_Telefono", dsOtraInfo.Tables[0].Rows[0]["NumeroLocal"].ToString());
                                        command1.Parameters.AddWithValue("InfoContacto_Email", dsOtraInfo.Tables[0].Rows[0]["Email"].ToString());
                                        command1.Parameters.AddWithValue("InfoContacto_IdPaisResidencia", Convert.ToInt32(dsOtraInfo.Tables[0].Rows[0]["Pais"].ToString()));
                                        command1.Parameters.AddWithValue("InfoContacto_Ciudad", "");
                                        command1.ExecuteNonQuery();
                                        adapter = new SqlDataAdapter(command1);
                                        conn1.Close();

                                        if (paramCodRetorno1.SqlValue.ToString() != null)
                                        {
                                            System.Data.SqlClient.SqlConnection conn2;
                                            conn2 = new System.Data.SqlClient.SqlConnection();
                                            conn2.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                                            conn2.Open();
                                            SqlCommand command2 = new SqlCommand("spOperacionesPasajeros", conn2);
                                            command2.CommandType = CommandType.StoredProcedure;
                                            command2.Parameters.AddWithValue("IdOperacion", Convert.ToInt32(paramCodRetorno.SqlValue.ToString()));
                                            command2.Parameters.AddWithValue("IdPasajero", Convert.ToInt32(paramCodRetorno1.SqlValue.ToString()));
                                            command2.ExecuteNonQuery();
                                            adapter = new SqlDataAdapter(command2);
                                            adapter.Fill(ds);
                                            conn2.Close();
                                            ds.Dispose();
                                        }
                                    }
                                //}
                            }

                            if ((dsProducto != null) && (dsProducto.Tables[0].Rows.Count > 0))
                            {
                                for (int z = 0; z < dsProducto.Tables[0].Rows.Count; z++)
                                {

                                    System.Data.SqlClient.SqlConnection conn3;
                                    conn3 = new System.Data.SqlClient.SqlConnection();
                                    conn3.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                                    conn3.Open();
                                    SqlCommand command3 = new SqlCommand("spOperacionesProductosAdicionales", conn3);
                                    command3.CommandType = CommandType.StoredProcedure;
                                    command3.Parameters.AddWithValue("IdOperacion", Convert.ToInt32(paramCodRetorno.SqlValue.ToString()));
                                    command3.Parameters.AddWithValue("IdProducto", Convert.ToInt32(dsProducto.Tables[0].Rows[z]["IdProductos"].ToString()));
                                    command3.Parameters.AddWithValue("IdProveedor", Convert.ToInt32(dsProveedor.Tables[0].Rows[z]["IdProveedor"].ToString()));
                                    command3.Parameters.AddWithValue("ImporteTarifa", Convert.ToDecimal(dsPrecioPesos.Tables[0].Rows[z]["PrecioPesos"].ToString()));
                                    command3.Parameters.AddWithValue("IdMoneda", Convert.ToInt32(1));
                                    command3.Parameters.AddWithValue("Cantidad", Convert.ToInt32(dsCantidad.Tables[0].Rows[z]["Cantidad"].ToString()));
                                    command3.ExecuteNonQuery();
                                    adapter = new SqlDataAdapter(command3);
                                    adapter.Fill(dsProducto);
                                    conn3.Close();
                                    dsProducto.Dispose();
                                }
                            
                            }
                        }
                    }

                    cargarvinculos(dsViajeros, IdOperacionRetorno);

                    dsFormaPago.Dispose();
                    dsFactura.Dispose();
                    dsViajeros.Dispose();
                    dsOtraInfo.Dispose();
                    dsInfoEmergencia.Dispose();
                    dsProducto.Dispose();
                    dsProveedor.Dispose();
                    dsCantidad.Dispose();
                    dsPrecioPesos.Dispose();
                    dsPrecioDolar.Dispose();
                    dsDatosViaje.Dispose();
                    muestrareporte(IdOperacionRetorno);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
            }
        }


        private void muestrareporte(String IdOperacion)
        {
            SqlDataAdapter adapter;
            DataSet ds = new DataSet();

            String archivo = "";

            DataTable dtVoucher = new DataTable();
            DataSet dsVoucher = new DataSet();

            String emailenviavoucher = "";

            dtVoucher.Columns.Add("IdOperacion");
            dtVoucher.Columns.Add("FechaEmision");
            dtVoucher.Columns.Add("NroVoucher");

            dtVoucher.Columns.Add("Pasajero_Nombre");
            dtVoucher.Columns.Add("Pasajero_Apellido");
            dtVoucher.Columns.Add("Pasajero_Documento");

            dtVoucher.Columns.Add("Pasajero_FechaNac");
            dtVoucher.Columns.Add("Pasajero_TipoTelefono");
            dtVoucher.Columns.Add("Pasajero_Telefono");

            dtVoucher.Columns.Add("Pasajero_Celular");
            dtVoucher.Columns.Add("Pasajero_Email");
            dtVoucher.Columns.Add("ContactoEmergencia_Apellido");


            dtVoucher.Columns.Add("ContactoEmergencia_Nombre");
            dtVoucher.Columns.Add("ContactoEmergencia_Email");

            dtVoucher.Columns.Add("ProductoDescripcion");
            dtVoucher.Columns.Add("OrigenDescripcion");

            dtVoucher.Columns.Add("DestinoDescripcion");
            dtVoucher.Columns.Add("FechaPartida");

            dtVoucher.Columns.Add("FechaRegreso");
            dtVoucher.Columns.Add("ImporteTarifaPesos");
            dtVoucher.Columns.Add("ImporteTarifaDolar");

            dtVoucher.Columns.Add("IdCobertura");
            dtVoucher.Columns.Add("DescripcionCobertura");
            dtVoucher.Columns.Add("ValorCobertura");
            dtVoucher.Columns.Add("MonedaDescripcion");
            dtVoucher.Columns.Add("SimboloMoneda");

            dtVoucher.Columns.Add("IdCobertura2");
            dtVoucher.Columns.Add("DescripcionCobertura2");
            dtVoucher.Columns.Add("ValorCobertura2");
            dtVoucher.Columns.Add("MonedaDescripcion2");
            dtVoucher.Columns.Add("SimboloMoneda2");
            dtVoucher.Columns.Add("EmailEnviaVoucher");

            try
            {

                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                conn.Open();
                SqlCommand command = new SqlCommand("spselImprimeVoucher", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id_Operacion", Convert.ToInt32(IdOperacion));
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                conn.Close();
                ds.Dispose();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    DataRow row = dtVoucher.NewRow();
                    row["IdOperacion"] = ds.Tables[0].Rows[i]["IdOperacion"].ToString();
                    row["FechaEmision"] = ds.Tables[0].Rows[i]["FechaEmision"].ToString(); ;
                    row["NroVoucher"] = ds.Tables[0].Rows[i]["NroVoucher"].ToString();

                    row["Pasajero_Nombre"] = ds.Tables[0].Rows[i]["Pasajero_Nombre"].ToString();
                    row["Pasajero_Apellido"] = ds.Tables[0].Rows[i]["Pasajero_Apellido"].ToString();
                    row["Pasajero_Documento"] = ds.Tables[0].Rows[i]["Pasajero_Documento"].ToString();
                    row["Pasajero_FechaNac"] = ds.Tables[0].Rows[i]["Pasajero_FechaNac"].ToString();
                    row["Pasajero_TipoTelefono"] = ds.Tables[0].Rows[i]["Pasajero_TipoTelefono"].ToString();
                    row["Pasajero_Telefono"] = ds.Tables[0].Rows[i]["Pasajero_Telefono"].ToString();
                    row["Pasajero_Celular"] = ds.Tables[0].Rows[i]["Pasajero_Celular"].ToString();
                    row["Pasajero_Email"] = ds.Tables[0].Rows[i]["Pasajero_Email"].ToString();

                    row["ContactoEmergencia_Apellido"] = ds.Tables[0].Rows[i]["ContactoEmergencia_Apellido"].ToString();
                    row["ContactoEmergencia_Nombre"] = ds.Tables[0].Rows[i]["ContactoEmergencia_Nombre"].ToString();
                    row["ContactoEmergencia_Email"] = ds.Tables[0].Rows[i]["ContactoEmergencia_Email"].ToString();

                    row["ProductoDescripcion"] = ds.Tables[0].Rows[i]["ProductoDescripcion"].ToString();
                    row["OrigenDescripcion"] = ds.Tables[0].Rows[i]["OrigenDescripcion"].ToString();
                    row["DestinoDescripcion"] = ds.Tables[0].Rows[i]["DestinoDescripcion"].ToString();
                    row["FechaPartida"] = ds.Tables[0].Rows[i]["FechaPartida"].ToString();
                    row["FechaRegreso"] = ds.Tables[0].Rows[i]["FechaRegreso"].ToString();
                    row["ImporteTarifaPesos"] = ds.Tables[0].Rows[i]["ImporteTarifaPesos"].ToString();
                    row["ImporteTarifaDolar"] = ds.Tables[0].Rows[i]["ImporteTarifaDolar"].ToString();

                    row["IdCobertura"] = ds.Tables[0].Rows[i]["IdCobertura"].ToString();
                    row["DescripcionCobertura"] = ds.Tables[0].Rows[i]["DescripcionCobertura"].ToString();
                    row["ValorCobertura"] = ds.Tables[0].Rows[i]["ValorCobertura"].ToString();
                    row["MonedaDescripcion"] = ds.Tables[0].Rows[i]["MonedaDescripcion"].ToString();
                    row["SimboloMoneda"] = ds.Tables[0].Rows[i]["SimboloMoneda"].ToString();

                    row["IdCobertura2"] = ds.Tables[0].Rows[i]["IdCobertura2"].ToString();
                    row["DescripcionCobertura2"] = ds.Tables[0].Rows[i]["DescripcionCobertura2"].ToString();
                    row["ValorCobertura2"] = ds.Tables[0].Rows[i]["ValorCobertura2"].ToString();
                    row["MonedaDescripcion2"] = ds.Tables[0].Rows[i]["MonedaDescripcion2"].ToString();
                    row["SimboloMoneda2"] = ds.Tables[0].Rows[i]["SimboloMoneda2"].ToString();
                    row["EmailEnviaVoucher"] = ds.Tables[0].Rows[i]["EmailEnviaVoucher"].ToString();
                    emailenviavoucher = ds.Tables[0].Rows[i]["EmailEnviaVoucher"].ToString();

                    dtVoucher.Rows.Add(row);

                }

                ds.Dispose();
                dsVoucher.Tables.Add(dtVoucher);

                ReportDocument reporte = new ReportDocument(); // creating object of crystal report                                             
                reporte.Load(Server.MapPath("~/Reportes/pagoconfirmado.rpt")); // path of report             
                reporte.SetDataSource(dsVoucher.Tables[0]);

                dsVoucher.Dispose();

                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();
                reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                archivo = "C:/Data/Tusegurodeviaje/Reports/TempReports/pagoconfirmado_" + IdOperacion + ".pdf";

                diskOpts.DiskFileName = archivo;
                reporte.ExportOptions.DestinationOptions = diskOpts;

                reporte.Export();

                //CrystalReportViewer1.ReportSource = reporte;
                //reporte.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "pagoconfirmado" + IdOperacion);
                enviaemail(archivo, emailenviavoucher);

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
            }
        }

        private void enviaemail(String archivoadjunto, String emailenviavoucher)
        {

            try
            {

                MailMessage mail = new MailMessage();
                //set the addresses
                string emailAddressList = emailenviavoucher; //System.Configuration.ConfigurationManager.AppSettings["emailsToSend"];
                string displayName = System.Configuration.ConfigurationManager.AppSettings["displayNameEmailAddressToSendAuthorizationDocs"];
                mail.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["fromEmailAddressToSendAuthorizationDocs"], displayName);
                mail.To.Add(emailAddressList);
                mail.IsBodyHtml = true;
                //set the content
                mail.Subject = "Voucher";
                //set the body          
                mail.Body += "Muchas gracias.<br />";
                //MailAttachment objArchivo = new MailAttachment("E:\\Email\\pedido.pdf");
                mail.Attachments.Add(new Attachment(archivoadjunto));
                //mail.Attachments.Add(archivo);
                string SMTPServer = System.Configuration.ConfigurationManager.AppSettings["SMTPServer"];
                SmtpClient smtp = new SmtpClient(SMTPServer); //specify the mail server address                     
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
            }
        }

        public void cargarvinculos(DataSet dsViajeros, String IdOperacion)
        {

            try
            {

                for (int i = 0; i < dsViajeros.Tables[0].Rows.Count; i++)
                {

                    if (i == 0)
                    {
                        Pasajero1.Visible = true;
                        lblOperacionPasajero1.Text = IdOperacion;
                        lblPasajeroNombre1.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                        lblPasajeroApellido1.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                    }
                    if (i == 1)
                    {
                        Pasajero2.Visible = true;
                        lblOperacionPasajero2.Text = IdOperacion;
                        lblPasajeroNombre2.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                        lblPasajeroApellido2.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                    }
                    if (i == 2)
                    {
                        Pasajero3.Visible = true;
                        lblOperacionPasajero3.Text = IdOperacion;
                        lblPasajeroNombre3.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                        lblPasajeroApellido3.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                    }
                    if (i == 3)
                    {
                        Pasajero4.Visible = true;
                        lblOperacionPasajero4.Text = IdOperacion;
                        lblPasajeroNombre4.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                        lblPasajeroApellido4.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                    }
                    if (i == 4)
                    {
                        Pasajero5.Visible = true;
                        lblOperacionPasajero5.Text = IdOperacion;
                        lblPasajeroNombre5.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                        lblPasajeroApellido5.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                    }

                    if (i == 5)
                    {
                        Pasajero6.Visible = true;
                        lblOperacionPasajero6.Text = IdOperacion;
                        lblPasajeroNombre6.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                        lblPasajeroApellido6.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {

            }
        }


    }
}