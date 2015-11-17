using System;
using System.IO;
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

using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using CrystalDecisions.ReportSource;


namespace TuSegurodeViaje.WebSite.Reportes
{
    public partial class visorsolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){

            if (!IsPostBack) {
                muestrareporte();
            }
        }


        private void muestrareporte()
        {
            SqlDataAdapter adapter;
            DataSet ds = new DataSet();

            String archivo = "";
            String IdOperacion = "";

            DataTable dtVoucher = new DataTable();
            DataSet dsVoucher = new DataSet();

            String emailenviavoucher = "";
                            
            IdOperacion=Request.QueryString["op"].ToString();

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

                CrystalReportViewer1.ReportSource = reporte;
                reporte.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "pagoconfirmado" + IdOperacion);
         
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