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
    public partial class visorpresupuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imprimepresupuesto();
        }

        private void imprimepresupuesto()
        {
            String opciones;
            String[] Datos;

            SqlConnection connection;
            SqlDataAdapter adapter;
         


            try
            {
                DataSet dspresupuesto= new DataSet();

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                
                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                conn.Open();
                SqlCommand command = new SqlCommand("spselImprimeCotizacion", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("FechaDesde", Datos[0].ToString());
                command.Parameters.AddWithValue("FechaHasta",  Datos[1].ToString());
                command.Parameters.AddWithValue("idOrigen",  Datos[2].ToString());
                command.Parameters.AddWithValue("IdDestino", Datos[3].ToString() );
                command.Parameters.AddWithValue("Email", Datos[4].ToString());
                command.Parameters.AddWithValue("edades", Datos[5].ToString());

                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dspresupuesto);
                conn.Close();

                String archivo = "";

                ReportDocument rptDoc = new ReportDocument();
                rptDoc.Load(Server.MapPath("~/Reportes/presupuesto1.rpt"));
                rptDoc.SetDataSource(dspresupuesto.Tables[0]);

                dspresupuesto.Dispose();

                DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions();

                string targetFileName = "C:/Data/Tusegurodeviaje/Reports/TempReports/presupuesto_" + (new Random()).Next() + ".pdf";    

                //string targetFileName = Request.PhysicalApplicationPath + "C:\Data\Tusegurodeviaje\Reports\TempReports\\presupuesto" + (new Random()).Next() + ".pdf";

                rptDoc.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                rptDoc.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                diskOpts.DiskFileName = targetFileName;

                //archivo = Server.MapPath(targetFileName);                
                rptDoc.ExportOptions.DestinationOptions = diskOpts;

                // Export report ... Server-Side.
                rptDoc.Export();
                CrystalReportViewer1.ReportSource = rptDoc;
                rptDoc.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "presupuesto");

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