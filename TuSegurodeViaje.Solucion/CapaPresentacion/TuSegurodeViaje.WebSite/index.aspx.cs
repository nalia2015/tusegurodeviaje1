using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace TuSegurodeViaje.WebSite
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (hdfOpcion.Value == "buscar")
                {
                    hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfEmail.Value + "_" + hdfTipoViaje.Value; 
                    Response.Redirect("planes.aspx?op=" + hdfCadena.Value);
                }
                CargarDatos();
            }
            else
            {
                if (hdfOpcion.Value == "buscar")
                {
                    hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfEmail.Value + "_" + hdfTipoViaje.Value;
                    Response.Redirect("planes.aspx?op=" + hdfCadena.Value);
                }
            }      
            
        }

        protected void CargarDatos()
        {

            SqlDataAdapter da;
            DataSet ds;

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'ORIGEN' as 'Descripcion' union select IdPais as 'Id', UPPER(NombrePais) as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlOrigen.DataSource = ds;
                ddlOrigen.DataValueField = "Id";
                ddlOrigen.DataTextField = "Descripcion";
                ddlOrigen.DataBind();

                ds.Dispose();
                
                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'DESTINO' as 'Descripcion' union select IdDestino as 'Id', UPPER(Descripcion) as 'Descripcion' from Destinos order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlDestino.DataSource = ds;
                ddlDestino.DataValueField = "Id";
                ddlDestino.DataTextField = "Descripcion";
                ddlDestino.DataBind();

                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["Id"].ToString() == "1")
                    {
                        ddlOrigen.SelectedIndex= Convert.ToInt32(ds.Tables[0].Rows[i]["Id"].ToString());
                    }
                }

                ds.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {

            }        
        
        }
        
        protected void ddlOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da;
            DataSet ds;

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'ORIGEN' as 'Descripcion' union select IdPais as 'Id', UPPER(NombrePais) as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlOrigen.DataSource = ds;
                ddlOrigen.DataValueField = "Id";
                ddlOrigen.DataTextField = "Descripcion";
                ddlOrigen.DataBind();

                ds.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {

            }        
        }

        protected void ddlDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da;
            DataSet ds;

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'DESTINO' as 'Descripcion' union select IdDestino as 'Id', UPPER(Descripcion) as 'Descripcion' from Destinos order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlDestino.DataSource = ds;
                ddlDestino.DataValueField = "Id";
                ddlDestino.DataTextField = "Descripcion";
                ddlDestino.DataBind();

                ds.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {

            }  
        }

        protected void ddlTipodeViaje_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da;
            DataSet ds;

            try
            {
              


            }
            catch (Exception ex)
            {

            }
        }     
    }
}