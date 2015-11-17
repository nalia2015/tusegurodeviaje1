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
    public partial class visorcondicionesgrales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                muestrareporte();
            }
        }

        private void muestrareporte() {

            DataSet ds;
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();

            try {
   
                    System.Data.SqlClient.SqlConnection conn;
                    conn = new System.Data.SqlClient.SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                    connection = new SqlConnection(conn.ConnectionString);
                    ds = new DataSet();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spselPathCCGG";
                    command.Parameters.AddWithValue("IdProducto", Convert.ToInt32(Request.QueryString["op"].ToString()));
                    command.ExecuteNonQuery();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);

                    string targetFileName = Server.MapPath(ds.Tables[0].Rows[0]["PathCCGG"].ToString());


                    FileInfo file = new FileInfo(targetFileName);

                    Response.ClearContent();
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    Response.ContentType = "application/pdf";
                    Response.TransmitFile(file.FullName);            

                }
                catch (Exception ex){
                    lblError.Text = "Error de carga " + ex.Message;
                }
                finally 
                { }        
        }
    }
}