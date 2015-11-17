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
using TuSegurodeViaje.WebSite.varios;
using mercadopago;

namespace TuSegurodeViaje.WebSite
{
    public partial class pagar : System.Web.UI.Page
    {
        public Hashtable preference;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack){                 
                        CargarDatos();
                }                              
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
            }
        }

        protected void CargarDatos(){

            SqlDataAdapter da;
            DataSet ds;
            String opciones = "";
            String[] Datos;
            int cantpasajeros = 0;
            DataSet dsViajeros;

            DataTable dtDatosViaje = new DataTable();
            DataSet dsDatosViaje = new DataSet();
            
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

                ds.Dispose();

                lblOrigen.Text = ds.Tables[0].Rows[0]["NombrePais"].ToString();
                hdfOrigen.Value = ds.Tables[0].Rows[0]["IdPais"].ToString();

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select IdDestino, Descripcion from Destinos where Destinos.IdDestino= " + Datos[1].ToString() + "", conn);
                ds = new DataSet();
                da.Fill(ds);

                ds.Dispose();

                lblDestino.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                hdfDestino.Value = ds.Tables[0].Rows[0]["IdDestino"].ToString();

                lblFechaSalida.Text = Datos[2].ToString();
                lblFechaLlegada.Text = Datos[3].ToString();
                lblTipoProducto.Text = "Económico";
                cantpasajeros = Convert.ToInt32(Datos[5].ToString());
                lblCantPasajeros.Text = Datos[5].ToString();
                lblCantDias.Text = Datos[6].ToString();
                lblPrecioPesos.Text = Datos[7].ToString();
                lblPrecioDolar.Text = Datos[8].ToString();
                
                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'Pais' as 'Descripcion' union select IdPais as 'Id',NombrePais as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);

                ds.Dispose();
                ddlPaisTelefono.DataSource = ds;
                ddlPaisTelefono.DataValueField = "Id";
                ddlPaisTelefono.DataTextField = "Descripcion";
                ddlPaisTelefono.DataBind();

                ds.Dispose();


                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'Pais' as 'Descripcion' union select IdPais as 'Id',NombrePais as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);

                ds.Dispose();
                ddlPaisTelefonoFactura.DataSource = ds;
                ddlPaisTelefonoFactura.DataValueField = "Id";
                ddlPaisTelefonoFactura.DataTextField = "Descripcion";
                ddlPaisTelefonoFactura.DataBind();

                ds.Dispose();

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'Pais' as 'Descripcion' union select IdPais as 'Id',NombrePais as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);

                ds.Dispose();

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select TipoTelefono as 'Id', Descripcion as 'Descripcion' from TipoTelefono  order by TipoTelefono.TipoTelefono ", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlTipoTelefonoFactura.DataSource = ds;
                ddlTipoTelefonoFactura.DataValueField = "Id";
                ddlTipoTelefonoFactura.DataTextField = "Descripcion";
                ddlTipoTelefonoFactura.DataBind();

                ds.Dispose();

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select TipoTelefono as 'Id', Descripcion as 'Descripcion' from TipoTelefono  order by TipoTelefono.TipoTelefono ", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlTipoTelefono.DataSource = ds;
                ddlTipoTelefono.DataValueField = "Id";
                ddlTipoTelefono.DataTextField = "Descripcion";
                ddlTipoTelefono.DataBind();

                ds.Dispose();
                
                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select Codigo as 'Id', Descripcion as 'Descripcion' from SituacionFiscal  order by SituacionFiscal.Codigo ", conn);
                ds = new DataSet();
                da.Fill(ds);

                ddlSituacionFiscal.DataSource = ds;
                ddlSituacionFiscal.DataValueField = "Id";
                ddlSituacionFiscal.DataTextField = "Descripcion";
                ddlSituacionFiscal.DataBind();

                ds.Dispose();

                hdfIdProducto.Value = Datos[16].ToString();
                hdfIdProveedor.Value = Datos[17].ToString();

                dsViajeros = (DataSet)Session["Viajeros"];
                
                dtDatosViaje.Columns.Add("IdOrigen");
                dtDatosViaje.Columns.Add("IdDestino");
                dtDatosViaje.Columns.Add("IdProducto");
                dtDatosViaje.Columns.Add("IdProveedor");

                //DatosViaje
                DataRow row2 = dtDatosViaje.NewRow();
                row2["IdOrigen"] = hdfOrigen.Value;
                row2["IdDestino"] = hdfDestino.Value;
                row2["IdProducto"] = Datos[16].ToString();
                row2["IdProveedor"] = Datos[17].ToString();

                dtDatosViaje.Rows.Add(row2);
                dsDatosViaje.Tables.Add(dtDatosViaje);
                
                Session["DatosViaje"] = dsDatosViaje;

               if ((dsViajeros != null) && (dsViajeros.Tables[0].Rows.Count > 0))
               {
                    for (int i = 0; i < dsViajeros.Tables[0].Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            PanelPasajero1.Visible = true;
                            lblApellidoPasajero1.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                            lblNombrePasajero1.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                            lblFechaNacPasajero1.Text = dsViajeros.Tables[0].Rows[i]["Fecha"].ToString();
                            lblNroDocuPasajero1.Text = dsViajeros.Tables[0].Rows[i]["DNI"].ToString();
                            lblEdadPasajero1.Text = dsViajeros.Tables[0].Rows[i]["Edad"].ToString();
                        }

                        if (i == 1)
                        {
                            PanelPasajero2.Visible = true;
                            lblApellidoPasajero2.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                            lblNombrePasajero2.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                            lblFechaNacPasajero2.Text = dsViajeros.Tables[0].Rows[i]["Fecha"].ToString();
                            lblNroDocuPasajero2.Text = dsViajeros.Tables[0].Rows[i]["DNI"].ToString();
                            lblEdadPasajero2.Text = dsViajeros.Tables[0].Rows[i]["Edad"].ToString();

                        }
                        if (i == 2)
                        {
                            PanelPasajero3.Visible = true;
                            lblApellidoPasajero3.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                            lblNombrePasajero3.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                            lblFechaNacPasajero3.Text = dsViajeros.Tables[0].Rows[i]["Fecha"].ToString();
                            lblNroDocuPasajero3.Text = dsViajeros.Tables[0].Rows[i]["DNI"].ToString();
                            lblEdadPasajero3.Text = dsViajeros.Tables[0].Rows[i]["Edad"].ToString();

                        }
                        if (i == 3)
                        {
                            PanelPasajero4.Visible = true;
                            lblApellidoPasajero4.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                            lblNombrePasajero4.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                            lblFechaNacPasajero4.Text = dsViajeros.Tables[0].Rows[i]["Fecha"].ToString();
                            lblNroDocuPasajero4.Text = dsViajeros.Tables[0].Rows[i]["DNI"].ToString();
                            lblEdadPasajero4.Text = dsViajeros.Tables[0].Rows[i]["Edad"].ToString();

                        }
                        if (i == 4)
                        {
                            PanelPasajero5.Visible = true;
                            lblApellidoPasajero5.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                            lblNombrePasajero5.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                            lblFechaNacPasajero5.Text = dsViajeros.Tables[0].Rows[i]["Fecha"].ToString();
                            lblNroDocuPasajero5.Text = dsViajeros.Tables[0].Rows[i]["DNI"].ToString();
                            lblEdadPasajero5.Text = dsViajeros.Tables[0].Rows[i]["Edad"].ToString();

                        }
                        if (i == 5)
                        {
                            PanelPasajero5.Visible = true;
                            lblApellidoPasajero6.Text = dsViajeros.Tables[0].Rows[i]["Apellido"].ToString();
                            lblNombrePasajero6.Text = dsViajeros.Tables[0].Rows[i]["Nombre"].ToString();
                            lblFechaNacPasajero6.Text = dsViajeros.Tables[0].Rows[i]["Fecha"].ToString();
                            lblNroDocuPasajero6.Text = dsViajeros.Tables[0].Rows[i]["DNI"].ToString();
                            lblEdadPasajero6.Text = dsViajeros.Tables[0].Rows[i]["Edad"].ToString();
                        }
                    }                    
                }

                            
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
            }
        }


        public void otrosproductosintangibles() {

            DataSet ds=new DataSet();
            SqlDataAdapter adapter;
            String tabla="";

            String preciosindto = "";
            Decimal cambio = 0;
            Decimal valorcambio = 0;

            try{

                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                conn.Open();
                SqlCommand command = new SqlCommand("spselProductosIntangibles", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("IdProveedor", hdfIdProveedor.Value);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                conn.Close();

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {             
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        tabla += " <tr> " +
                                " <td><a href='verproducto.html' class='iframe'><i class='fa fa-xs fa-search'></i> " + ds.Tables[0].Rows[i]["Nombre"].ToString() + " </a></td> " +
                                " <td> </td> ";

                        conversiondemonedas moneda = new conversiondemonedas();            
                        preciosindto = ds.Tables[0].Rows[i]["Tarifa"].ToString();
                        cambio = moneda.GetConvertion("ARS", "USD");                      
                        valorcambio = Decimal.Round(Convert.ToDecimal(ds.Tables[0].Rows[i]["Tarifa"].ToString()) * cambio, 2);
                        tabla +=" <td>Precio para todos los viajeros</td> " +
                                " <td> U$S " + valorcambio + " / AR$ " + preciosindto + " </td> " +
                                " <td class='rojo'></td> " +
                                " <td class='cant'><input type='number' name='cantidad' id='cant_" + ds.Tables[0].Rows[i]["IdProducto"].ToString() + "' value='' placeholder='0' min='0' max='20' size='2' maxlength='2'></td> " +
                                " <td> <input id=" + ds.Tables[0].Rows[i]["IdProducto"].ToString() + "  name='chkcompra'  type='checkbox'  onclick='compraadicional();' ></td> " +
                                " <td>U$S " + valorcambio + "  / " + preciosindto + " </td> " +
                                " </tr> ";
                    }
                }

                ds.Dispose();             
                Response.Write(tabla);               
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
            }           
        
        }

        private void guardardatos() {

            String[] Producto;        
            String[] Proveedor;        
            String[] PrecioPesos;        
            String[] PrecioDolar; 
            String[] Cantidad;
            Decimal totalpreciopesosadicionales = 0;
            Decimal totalpreciodolaradicionales = 0;

            Decimal totalpreciopesos= 0;
            Decimal totalpreciodolar= 0;

            DataTable dtProductos = new DataTable();
            DataTable dtProveedor = new DataTable();
            DataTable dtPrecioPesos = new DataTable();
            DataTable dtPrecioDolar = new DataTable();
            DataTable dtCantidad = new DataTable();

            DataSet dsProductos = new DataSet();
            DataSet dsProveedor = new DataSet();
            DataSet dsPrecioPesos = new DataSet();
            DataSet dsPrecioDolar = new DataSet();
            DataSet dsCantidad = new DataSet();

            DataSet ds = new DataSet();
            SqlDataAdapter adapter;
            String tabla = "";

            String preciosindto = "";
            Decimal cambio = 0;
            Decimal valorcambio = 0;

            DataTable dtFormaPago = new DataTable();
            DataSet dsFormaPago = new DataSet();

            DataTable dtFactura = new DataTable();
            DataSet dsFactura = new DataSet();
            
            try{            
                
                dtFormaPago.Columns.Add("TipoPago");
                dtFormaPago.Columns.Add("TipoTelefono");
                dtFormaPago.Columns.Add("PaisTelefono");
                dtFormaPago.Columns.Add("CodAreaTelefono");
                dtFormaPago.Columns.Add("NroTelefono");

                //FormaPago
                DataRow row = dtFormaPago.NewRow();
                row["TipoPago"] = hdfFormaPago.Value;
                row["TipoTelefono"] = ddlTipoTelefono.SelectedIndex;
                row["PaisTelefono"] = ddlPaisTelefono.SelectedIndex;
                row["CodAreaTelefono"] = txtCodigoAreaCiudad.Text;
                row["NroTelefono"] = txtNroLocal.Text;

                dtFormaPago.Rows.Add(row);
                dsFormaPago.Tables.Add(dtFormaPago);

                dtFactura.Columns.Add("SituacionFiscal");
                dtFactura.Columns.Add("RazonSocial");
                dtFactura.Columns.Add("CUILCUIT");
                dtFactura.Columns.Add("CodigoPostal");
                dtFactura.Columns.Add("Domicilio");
                dtFactura.Columns.Add("CiudadDomicilio");
                dtFactura.Columns.Add("PaisDomicilio");
                dtFactura.Columns.Add("TipoTelefono");
                dtFactura.Columns.Add("PaisTelefono");
                dtFactura.Columns.Add("CodAreaCiudad");
                dtFactura.Columns.Add("NroLocal");

                //FormaPago
                DataRow row1 = dtFactura.NewRow();
                row1["SituacionFiscal"] = ddlSituacionFiscal.SelectedIndex;
                row1["RazonSocial"] = txtNombreoRazonSocial.Text;
                row1["CUILCUIT"] = txtCuit.Text;
                row1["CodigoPostal"] = txtCodigoPostal.Text;
                row1["Domicilio"] = txtDomicilio.Text;
                row1["CiudadDomicilio"] = txtCiudad.Text;
                row1["PaisDomicilio"] = ddlPaisTelefono.SelectedIndex;
                row1["TipoTelefono"] = ddlTipoTelefonoFactura.SelectedIndex;
                row1["PaisTelefono"] = ddlPaisTelefonoFactura.SelectedIndex;
                row1["CodAreaCiudad"] = txtCodigoAreaCiudad.Text;
                row1["NroLocal"] = txtNroLocalFactura.Text;

                dtFactura.Rows.Add(row1);
                dsFactura.Tables.Add(dtFactura);

                Session["InfoFormasdePago"] = dsFormaPago;
                Session["InfoFactura"] = dsFactura;       

                dtProductos.Columns.Add("IdProductos");
                dtProveedor.Columns.Add("IdProveedor");
                dtPrecioPesos.Columns.Add("PrecioPesos");
                dtPrecioDolar.Columns.Add("PrecioDolar");
                dtCantidad.Columns.Add("Cantidad");
                
                Producto = hdfIdProducto.Value.Split('*');
                Proveedor = hdfIdProveedor.Value.Split('*');
                Cantidad = hdfCantidad.Value.Split('*');
                
                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                conn.Open();
                SqlCommand command = new SqlCommand("spselProductosIntangibles", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("IdProveedor", hdfIdProveedor.Value);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                conn.Close();
                
                conversiondemonedas moneda = new conversiondemonedas();

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {
                    for (int j = 0; j < Producto.Count(); j++)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {                            
                            if (ds.Tables[0].Rows[i]["IdProducto"].ToString() == Producto[j].ToString())
                            {                                                             
                                preciosindto = ds.Tables[0].Rows[i]["Tarifa"].ToString();
                                cambio = moneda.GetConvertion("ARS", "USD");
                                valorcambio = Decimal.Round(Convert.ToDecimal(ds.Tables[0].Rows[i]["Tarifa"].ToString()) * cambio, 2);
                                hdfPrecioPesos.Value = hdfPrecioPesos.Value + preciosindto + "*";
                                hdfPrecioDolar.Value = hdfPrecioDolar.Value + valorcambio + "*"; 
                            }
                        }
                    }
                }

                PrecioPesos = hdfPrecioPesos.Value.Split('*');
                PrecioDolar = hdfPrecioDolar.Value.Split('*');

                ds.Dispose();
                conn.Close();
                
                if (hdfOpcionAdicionales.Value == "1") {

                    if (Producto.Count() - 1 > 0)
                    {
                        for (int x = 0; x < Producto.Count() - 1; x++)
                        {                            
                            DataRow row3 = dtProductos.NewRow();
                            row3["IdProductos"] = Producto[x].ToString();
                            dtProductos.Rows.Add(row3);     

                            DataRow row4 = dtProveedor.NewRow();
                            row4["IdProveedor"] = Proveedor[x].ToString();
                            dtProveedor.Rows.Add(row4);  

                            DataRow row5 = dtPrecioPesos.NewRow();
                            row5["PrecioPesos"] = PrecioPesos[x].ToString();
                            dtPrecioPesos.Rows.Add(row5);  

                            DataRow row6 = dtPrecioDolar.NewRow();
                            row6["PrecioDolar"] = PrecioDolar[x].ToString();
                            dtPrecioDolar.Rows.Add(row6);  

                            DataRow row7 = dtCantidad.NewRow();
                            row7["Cantidad"] = Cantidad[x].ToString();
                            dtCantidad.Rows.Add(row7);  
                        }
                    }                                               
                }

                dsProductos.Tables.Add(dtProductos);
                dsProveedor.Tables.Add(dtProveedor);
                dsPrecioPesos.Tables.Add(dtPrecioPesos);
                dsPrecioDolar.Tables.Add(dtPrecioDolar);
                dsCantidad.Tables.Add(dtCantidad);

                Session["Productos"] = dsProductos;
                Session["Proveedor"] = dsProveedor;
                Session["PrecioPesos"] = dsPrecioPesos;
                Session["PrecioDolar"] = dsPrecioDolar;
                Session["Cantidad"] = dsCantidad;
                

                if (PrecioPesos.Count() > 0){
                    
                    for (int z = 0; z < PrecioPesos.Count()-1 ; z++){
                        totalpreciopesosadicionales += Convert.ToDecimal(PrecioPesos[z].ToString());
                        totalpreciodolaradicionales += Convert.ToDecimal(PrecioDolar[z].ToString());
                    }

                }

                totalpreciopesos += totalpreciopesosadicionales + Convert.ToDecimal(lblPrecioPesos.Text);

                totalpreciodolar += totalpreciodolaradicionales + Convert.ToDecimal(lblPrecioDolar.Text);

                MP mp = new MP("3592982235689583", "iwzO6CMeOH6gA0dMYnCtvZZo7L6aUYO3");

                String url1 = "";
                String url2 = "";
                String url3 = "";

                //url1 = "http://testing.portsoft.com.ar/tusegurodeviaje/pago-confirmado.aspx?op=" + lblFechaSalida.Text + "_" + lblFechaLlegada.Text + "_" + Convert.ToString(totalpreciopesos) + "_" + Convert.ToString(totalpreciodolar) + "";
                //url2 = "http://testing.portsoft.com.ar/tusegurodeviaje/pago-pendiente.aspx?op=" + lblFechaSalida.Text + "_" + lblFechaLlegada.Text + "_" + Convert.ToString(totalpreciopesos) + "_" + Convert.ToString(totalpreciodolar) + "";
                //url3 = "http://testing.portsoft.com.ar/tusegurodeviaje/pago-fallo.aspx?op=" + lblFechaSalida.Text + "_" + lblFechaLlegada.Text + "_" + Convert.ToString(totalpreciopesos) + "_" + Convert.ToString(totalpreciodolar) + "";

                url1 = "http://localhost:50814/pago-confirmado.aspx?op=" + lblFechaSalida.Text + "_" + lblFechaLlegada.Text + "_" + Convert.ToString(totalpreciopesos) + "_" + Convert.ToString(totalpreciodolar) + "";
                url2 = "http://localhost:50814/pago-pendiente.aspx?op=" + lblFechaSalida.Text + "_" + lblFechaLlegada.Text + "_" + Convert.ToString(totalpreciopesos) + "_" + Convert.ToString(totalpreciodolar) + "";
                url3 = "http://localhost:50814/pago-fallo.aspx?op=" + lblFechaSalida.Text + "_" + lblFechaLlegada.Text + "_" + Convert.ToString(totalpreciopesos) + "_" + Convert.ToString(totalpreciodolar) + "";

                String datos = "{\"items\":[{\"title\":\"sdk-dotnet\",\"quantity\":1,\"currency_id\":\"ARS\",\"unit_price\":" + Convert.ToString(totalpreciopesos) + "}] , \"back_urls\":{\"success\": \"" + url1 + "\", \"pending\": \"" + url2 + "\",\"failure\":\"" + url3 + "\"} }";

                Hashtable preference = mp.createPreference(datos);
                Hashtable url = ((Hashtable)preference["response"]);

                hdfUrl.Value = url["sandbox_init_point"].ToString();

                Response.Redirect(url["sandbox_init_point"].ToString());
                
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
            }                           
        }

        protected void botonpagar_Click(object sender, EventArgs e)
        {
            guardardatos();
        }

    }
}