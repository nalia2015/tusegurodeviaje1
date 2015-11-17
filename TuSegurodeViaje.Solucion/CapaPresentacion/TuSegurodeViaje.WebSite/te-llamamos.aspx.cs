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
    public partial class te_llamamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                cargardatos();
            }else{
                if ((Request.QueryString["op"] != null) && (Request.QueryString["op"] == "guardar"))
                {
                    guardardatos();
                }
            }
        }

        private void cargardatos() {

            SqlDataAdapter da;
            DataSet ds;           

            try
            {
                
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'Pais' as 'Descripcion' union select IdPais as 'Id',NombrePais as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlPaisContacto.DataSource = ds;
                ddlPaisContacto.DataValueField = "Id";
                ddlPaisContacto.DataTextField = "Descripcion";
                ddlPaisContacto.DataBind();

                ds.Dispose();              

                
                da = new SqlDataAdapter("Select TipoTelefono as 'Id', Descripcion as 'Descripcion' from TipoTelefono  order by TipoTelefono.TipoTelefono ", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlTipoTelefonoContacto.DataSource = ds;
                ddlTipoTelefonoContacto.DataValueField = "Id";
                ddlTipoTelefonoContacto.DataTextField = "Descripcion";
                ddlTipoTelefonoContacto.DataBind();

                ds.Dispose();
                

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            finally { }
        
        
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
                SqlCommand command = new SqlCommand("sptellamamos", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("NombreyApellido", txtNombreyApellido.Text);
                command.Parameters.AddWithValue("TipoTelefono", ddlTipoTelefonoContacto.SelectedIndex);
                command.Parameters.AddWithValue("IdPais", ddlPaisContacto.SelectedIndex);
                command.Parameters.AddWithValue("CodigoArea", txtCodigoArea.Text);
                command.Parameters.AddWithValue("NroTelefono", txtNrodeTelefono.Text);
                command.Parameters.AddWithValue("Email", txtEmail.Text);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                conn.Close();
                ds.Dispose();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            finally { }

        }

       
    }
}