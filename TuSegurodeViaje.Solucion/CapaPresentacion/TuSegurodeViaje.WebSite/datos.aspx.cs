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
    public partial class datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                CargarDatos();
            }
            else{
                if (hdfOpcion.Value == "pagar"){
                    hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEmail.Value + "_" + hdfCantPasajeros.Value + "_" + hdfCantDias.Value + "_" + hdfPrecioPesos.Value + "_" + hdfPrecioDolar.Value + "_" + hdfOpcion.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfIdProducto.Value + "_" + hdfIdProveedor.Value ;
                    guardarDatos();
                }                      
            }     
        }

        protected void CargarDatos(){

            SqlDataAdapter da;
            DataSet ds;
            String opciones = "";
            String[] Datos;
            int cantpasajeros = 0;

            try{
                
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select IdPais, NombrePais from PaisdeOrigen where PaisdeOrigen.IdPais=" + Datos[0].ToString() + "", conn);
                ds = new DataSet();
                da.Fill(ds);

                lblOrigen.Text = ds.Tables[0].Rows[0]["NombrePais"].ToString();                
                hdfOrigen.Value = Datos[0].ToString();                
                ds.Dispose();
                                
                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select IdDestino, Descripcion from Destinos where Destinos.IdDestino= " + Datos[1].ToString() + "", conn);
                ds = new DataSet();
                da.Fill(ds);

                lblDestino.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                ds.Dispose();

                hdfDestino.Value = Datos[1].ToString();
                lblFechaSalida.Text = Datos[2].ToString();
                hdfFechaDesde.Value = Datos[2].ToString();                
                lblFechaLlegada.Text= Datos[3].ToString();
                hdfFechaHasta.Value = Datos[3].ToString();
                hdfEmail.Value = Datos[4].ToString();
                hdfCantPasajeros.Value = Datos[5].ToString();
                hdfCantDias.Value = Datos[6].ToString();
                hdfPrecioPesos.Value =  Datos[7].ToString();
                hdfPrecioDolar.Value = Datos[8].ToString();
                hdfOpcion.Value = "";

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select TipoTelefono as 'Id', Descripcion as 'Descripcion' from TipoTelefono  order by TipoTelefono.TipoTelefono ", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlTipoTelefonoContacto.DataSource = ds;
                ddlTipoTelefonoContacto.DataValueField = "Id";
                ddlTipoTelefonoContacto.DataTextField = "Descripcion";
                ddlTipoTelefonoContacto.DataBind();

                ds.Dispose();

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select TipoTelefono as 'Id', Descripcion as 'Descripcion' from TipoTelefono  order by TipoTelefono.TipoTelefono ", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlTipoTelefonoEmergencia.DataSource = ds;
                ddlTipoTelefonoEmergencia.DataValueField = "Id";
                ddlTipoTelefonoEmergencia.DataTextField = "Descripcion";
                ddlTipoTelefonoEmergencia.DataBind();

                ds.Dispose();

                lblTipoProducto.Text= "Económico";                
                cantpasajeros = Convert.ToInt32(Datos[5].ToString());
                lblCantPasajeros.Text = Datos[5].ToString();
                lblCantDias.Text = Datos[6].ToString();
                lblPrecioPesos.Text = Datos[7].ToString();
                lblPrecioDolar.Text = Datos[8].ToString();
                
                hdfEdad1.Value = Datos[10].ToString();
                lblEdad1.Text = Datos[10].ToString();
                hdfEdad2.Value = Datos[11].ToString();
                lblEdad2.Text = Datos[11].ToString();
                hdfEdad3.Value = Datos[12].ToString();
                lblEdad3.Text = Datos[12].ToString();
                hdfEdad4.Value = Datos[13].ToString();
                lblEdad4.Text = Datos[13].ToString();
                hdfEdad5.Value = Datos[14].ToString();
                lblEdad5.Text = Datos[14].ToString();
                hdfEdad6.Value = Datos[15].ToString();
                lblEdad6.Text = Datos[15].ToString();
                hdfIdProducto.Value = Datos[16].ToString();
                hdfIdProveedor.Value = Datos[17].ToString();

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'Pais' as 'Descripcion' union select IdPais as 'Id',NombrePais as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);

                //Pais Contacto Emergencia
                ddlPaisContactoEmergencia.DataSource = ds;
                ddlPaisContactoEmergencia.DataValueField = "Id";
                ddlPaisContactoEmergencia.DataTextField = "Descripcion";
                ddlPaisContactoEmergencia.DataBind();

                //Pais Contacto Emergencia
                ddlPaisContacto.DataSource = ds;
                ddlPaisContacto.DataValueField = "Id";
                ddlPaisContacto.DataTextField = "Descripcion";
                ddlPaisContacto.DataBind();

                ds.Dispose();

                for (int i = 0; i < cantpasajeros; i++){
                    if (i == 0){
                        Pasajero1.Visible = true;
                    }      

                    if (i ==1){
                        Pasajero2.Visible = true;
                    }
                    if (i == 2){
                        Pasajero3.Visible = true;
                    }
                    if (i == 3){
                        Pasajero4.Visible = true;
                    }                    
                    if (i == 4){
                        Pasajero5.Visible = true;
                    }                    
                    if (i == 5){
                        Pasajero6.Visible = true;
                    }
                }                
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
            }
        }


        private void guardarDatos() {
            
            DataTable dtViajeros = new DataTable();
            DataSet dsViajeros = new DataSet();

            DataTable dtOtraInfo = new DataTable();
            DataSet dsOtraInfo = new DataSet();

            DataTable dtInfoEmergencia = new DataTable();
            DataSet dsInfoEmergencia = new DataSet();

            try{

                dtViajeros.Columns.Add("Nombre");
                dtViajeros.Columns.Add("Apellido");
                dtViajeros.Columns.Add("Fecha");
                dtViajeros.Columns.Add("DNI");
                dtViajeros.Columns.Add("Pais");
                dtViajeros.Columns.Add("Ciudad");
                dtViajeros.Columns.Add("Edad");
                dtViajeros.Columns.Add("Email");

                if (hdfEdad1.Value != "") 
                {                
                    //Primer Viajero
                    DataRow row1 = dtViajeros.NewRow();
                    row1["Nombre"] = txtNombreViajero1.Text;
                    row1["Apellido"] = txtApellidoViajero1.Text;
                    row1["Fecha"] = txtFechaNacimientoViajero1.Text;
                    row1["DNI"] = txtDNIViajero1.Text;
                    row1["Pais"] = 0; //ddlPaisViajero1.SelectedIndex;
                    row1["Ciudad"] = "";//txtCiudadViajero1.Text;
                    row1["Edad"] = hdfEdad1.Value;
                    row1["Email"] = hdfEmail.Value;
                
                    dtViajeros.Rows.Add(row1);
                }

                if (hdfEdad2.Value != "")
                {
                    //Segundo Viajero
                    DataRow row2 = dtViajeros.NewRow();
                    row2["Nombre"] = txtNombreViajero2.Text;
                    row2["Apellido"] = txtApellidoViajero2.Text;
                    row2["Fecha"] = txtFechaNacimientoViajero2.Text;
                    row2["DNI"] = txtDNIViajero2.Text;
                    row2["Pais"] = 0; //ddlPaisViajero2.SelectedIndex;
                    row2["Ciudad"] = ""; // txtCiudadViajero2.Text;
                    row2["Edad"] = hdfEdad2.Value;
                    row2["Email"] = hdfEmail.Value;

                    dtViajeros.Rows.Add(row2);
                }

                if (hdfEdad3.Value != "")
                {
                    //Tercer Viajero
                    DataRow row3 = dtViajeros.NewRow();
                    row3["Nombre"] = txtNombreViajero3.Text;
                    row3["Apellido"] = txtApellidoViajero3.Text;
                    row3["Fecha"] = txtFechaNacimientoViajero3.Text;
                    row3["DNI"] = txtDNIViajero3.Text;
                    row3["Pais"] = 0;// dlPaisViajero3.SelectedIndex;
                    row3["Ciudad"] = "";// txtCiudadViajero3.Text;
                    row3["Edad"] = hdfEdad3.Value;
                    row3["Email"] = hdfEmail.Value;

                    dtViajeros.Rows.Add(row3);
                }


                if (hdfEdad4.Value != "")
                {
                    //Cuarto Viajero
                    DataRow row4 = dtViajeros.NewRow();
                    row4["Nombre"] = txtNombreViajero4.Text;
                    row4["Apellido"] = txtApellidoViajero4.Text;
                    row4["Fecha"] = txtFechaNacimientoViajero4.Text;
                    row4["DNI"] = txtDNIViajero4.Text;
                    row4["Pais"] = 0; // ddlPaisViajero4.SelectedIndex;
                    row4["Ciudad"] = ""; //txtCiudadViajero4.Text;
                    row4["Edad"] = hdfEdad4.Value;
                    row4["Email"] = hdfEmail.Value;

                    dtViajeros.Rows.Add(row4);
                }

                if (hdfEdad5.Value != "")
                {
                    //Quinto Viajero
                    DataRow row5 = dtViajeros.NewRow();
                    row5["Nombre"] = txtNombreViajero5.Text;
                    row5["Apellido"] = txtApellidoViajero5.Text;
                    row5["Fecha"] = txtFechaNacimientoViajero5.Text;
                    row5["DNI"] = txtDNIViajero5.Text;
                    row5["Pais"] = 0; //ddlPaisViajero5.SelectedIndex;
                    row5["Ciudad"] = ""; //txtCiudadViajero5.Text;
                    row5["Edad"] = hdfEdad5.Value;
                    row5["Email"] = hdfEmail.Value;

                    dtViajeros.Rows.Add(row5);
                }

                if (hdfEdad6.Value != "")
                {
                    //Sexto Viajero
                    DataRow row6 = dtViajeros.NewRow();
                    row6["Nombre"] = txtNombreViajero6.Text;
                    row6["Apellido"] = txtApellidoViajero6.Text;
                    row6["Fecha"] = txtFechaNacimientoViajero6.Text;
                    row6["DNI"] = txtDNIViajero6.Text;
                    row6["Pais"] = 0; // ddlPaisViajero6.SelectedIndex;
                    row6["Ciudad"] = ""; //txtCiudadViajero6.Text;
                    row6["Edad"] = hdfEdad6.Value;
                    row6["Email"] = hdfEmail.Value;

                    dtViajeros.Rows.Add(row6);

                }
                
                dsViajeros.Tables.Add(dtViajeros);                
                Session["Viajeros"] = dsViajeros;
                
                //Información de Contacto de Emergencia

                dtInfoEmergencia.Columns.Add("Nombre");
                dtInfoEmergencia.Columns.Add("Apellido");
                dtInfoEmergencia.Columns.Add("TipoTelefono");
                dtInfoEmergencia.Columns.Add("Email");
                dtInfoEmergencia.Columns.Add("Pais");
                dtInfoEmergencia.Columns.Add("CodCiudad");
                dtInfoEmergencia.Columns.Add("NumeroLocal");
                dtInfoEmergencia.Columns.Add("TipoContacto");

                DataRow row7 = dtInfoEmergencia.NewRow();
                row7["Nombre"] = txtNombreContactoEmergencia.Text;
                row7["Apellido"] = txtApellidoContactoEmergencia.Text;
                row7["Email"] = txtEmailContactoEmergencia.Text;
                row7["TipoTelefono"] = ddlTipoTelefonoEmergencia.SelectedIndex;               
                row7["Pais"] = ddlPaisContactoEmergencia.SelectedIndex;
                row7["CodCiudad"] = txtCiudadEmergencia.Text;
                row7["NumeroLocal"] = txtNroLocalEmergencia.Text;
                row7["TipoContacto"] = "Emergencia";

                dtInfoEmergencia.Rows.Add(row7);
                dsInfoEmergencia.Tables.Add(dtInfoEmergencia);

                //Información de Contacto

                dtOtraInfo.Columns.Add("Nombre");
                dtOtraInfo.Columns.Add("Apellido");
                dtOtraInfo.Columns.Add("TipoTelefono");
                dtOtraInfo.Columns.Add("Email");
                dtOtraInfo.Columns.Add("Pais");
                dtOtraInfo.Columns.Add("CodCiudad");
                dtOtraInfo.Columns.Add("NumeroLocal");
                dtOtraInfo.Columns.Add("TipoContacto");

                DataRow row8 = dtOtraInfo.NewRow();
                row8["Nombre"] = ""; //txtNombreContacto.Text;
                row8["Apellido"] = ""; //txtApellidoContacto.Text;
                row8["Email"] = txtEmailContacto.Text;
                row8["TipoTelefono"] = ddlTipoTelefonoContacto.SelectedIndex;               
                row8["Pais"] = ddlPaisContacto.SelectedIndex;
                row8["CodCiudad"] = txtCiudadContacto.Text;
                row8["NumeroLocal"] = txtNroLocalContacto.Text;
                row8["TipoContacto"] = "Contacto";

                dtOtraInfo.Rows.Add(row8);                                 
                dsOtraInfo.Tables.Add(dtOtraInfo);

                Session["InfoEmergencia"] = dsInfoEmergencia;
                Session["OtraInfoViajeros"] = dsOtraInfo;
                
                dsOtraInfo.Dispose();
                dsInfoEmergencia.Dispose();
                dsViajeros.Dispose();

                Response.Redirect("pagar.aspx?op=" + hdfCadena.Value);
               
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