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


namespace TuSegurodeViaje.WebSite
{
    public partial class contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) { }
            else {
                if ((Request.QueryString["op"] != null)&&(Request.QueryString["op"]=="guardar")) { 
                    guardardatos();                
                }
            }
          
        }


        private void guardardatos()
        {

            DataSet ds;
            SqlDataAdapter adapter;

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                ds = new DataSet();
                conn.Open();
                SqlCommand command = new SqlCommand("spContacto", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("NombreyApellido", txtNombreyApellido.Text);
                command.Parameters.AddWithValue("Email", txtEmail.Text);
                command.Parameters.AddWithValue("Mensaje", txtMensaje.Text);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                conn.Close();
                ds.Dispose();
            }
            catch (Exception ex){
                Response.Write(ex.Message);

            }
            finally { }

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            guardardatos();
        }

    }
}