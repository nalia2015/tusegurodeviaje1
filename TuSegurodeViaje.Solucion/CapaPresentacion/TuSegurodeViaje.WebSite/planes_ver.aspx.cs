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
using TuSegurodeViaje.WebSite.varios;

namespace TuSegurodeViaje.WebSite
{
    public partial class planes_ver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){                           
                CargarDatos();                
            }
            else {
                if (hdfOpcion.Value == "recotizar"){
                    hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfEmail.Value + "_" + hdfTipoViaje.Value + "_" + hdfIdProv.Value + "_" + hdfOpcion.Value;
                }

                if (hdfOpcion.Value == "comprar")
                {
                    hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEmail.Value + "_" + hdfCantPasajeros.Value + "_" + hdfCantDias.Value + "_" + hdfPrecioPesos.Value + "_" + hdfPrecioDolar.Value + "_" + hdfOpcion.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfIdProducto.Value; 
                    Response.Redirect("datos.aspx?op=" + hdfCadena.Value);
                }              
            }

            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:contarfiltros();</script>");           

        }


        public void mostrarresultcotiza(){
            String opciones = "";
            String[] Datos;
            DataSet ds;
            DataSet dsxseg = new DataSet();
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            String tabla = "";
            Int32 idOrigen = 0;
            Int32 IdDestino = 0;
            String FechaDesde;
            String FechaHasta;
            Int32 edad1 = 0;
            Int32 edad2 = 0;
            Int32 edad3 = 0;
            Int32 edad4 = 0;
            Int32 edad5 = 0;
            Int32 edad6 = 0;
            String Email = "";
            Int32 ordenadopor = 5;
            Int32 Segmento = 0;
            String[] Prov;
            Boolean muestraprove = true;
            Boolean muestralimxcobertura = true;
            Boolean muestralimxtarifa = true;
            String[] Seg;
            Boolean muestraprodxsegmento = true;
            Boolean band = false;
            int cont = 0;
            DataSet dscompara = new DataSet();
            String valorcoberturaaccidente = "";
            String valorcoberturaenfermedad = "";
            String valorcoberturacancelacion = "";
            String valorcoberturaperdida = "";
            String valorcoberturadeducible = "";
            int cantpasajeros = 0;
           
            DataTable dtOrdena = new DataTable();
            DataSet dsOrdena = new DataSet();

            DataTable dtOrdena1 = new DataTable();
            DataSet dsOrdena1 = new DataSet();
            
            DataTable dtOrdena2 = new DataTable();
            DataSet dsOrdena2 = new DataSet();

            DataTable dtOrdena3 = new DataTable();
            DataSet dsOrdena3 = new DataSet();

            DataTable dtOrdena4 = new DataTable();
            DataSet dsOrdena4 = new DataSet();

            DataTable dtOrdena5 = new DataTable();
            DataSet dsOrdena5 = new DataSet();

            int contopciones = 0;
            String totalporcentajedto = "";
            String preciosindto = "";
            Decimal cambio = 0;
            Decimal valorcambio = 0;
            String cantdias = "";

            DataSet dstarifa = new DataSet();
            Int32 ordenadoxTarifa = 0;
            Decimal desdeTarifa = 0;
            Decimal hastaTarifa = 0;

            Int32 ordenadoxValorCobertura = 0;
            Decimal desdeValorCobertura = 0;
            Decimal hastaValorCobertura = 0;

            conversiondemonedas moneda = new conversiondemonedas();

            FechaDesde = "1900/01/01";
            FechaHasta = "1900/01/01";

            dtOrdena.Columns.Add("idproveedor");
            dtOrdena.Columns.Add("nombreproveedor");
            dtOrdena.Columns.Add("idproducto");
            dtOrdena.Columns.Add("nombreproducto");
            dtOrdena.Columns.Add("coberturaenfermedad");
            dtOrdena.Columns.Add("coberturaaccidente");
            dtOrdena.Columns.Add("coberturaperdida");
            dtOrdena.Columns.Add("coberturacancelacion");
            dtOrdena.Columns.Add("deducible");
            dtOrdena.Columns.Add("tarifafinal");
            dtOrdena.Columns.Add("TotalFinalDtosAplicados");
            dtOrdena.Columns.Add("TotalFinalSinDtosAplicados");
            dtOrdena.Columns.Add("PorcentajeTotalDtoAplicados");

            /*Muestra ordena*/

            dtOrdena1.Columns.Add("idproveedor");
            dtOrdena1.Columns.Add("nombreproveedor");
            dtOrdena1.Columns.Add("idproducto");
            dtOrdena1.Columns.Add("nombreproducto");
            dtOrdena1.Columns.Add("coberturaenfermedad");
            dtOrdena1.Columns.Add("coberturaaccidente");
            dtOrdena1.Columns.Add("coberturaperdida");
            dtOrdena1.Columns.Add("coberturacancelacion");
            dtOrdena1.Columns.Add("deducible");
            dtOrdena1.Columns.Add("tarifafinal");
            dtOrdena1.Columns.Add("TotalFinalDtosAplicados");
            dtOrdena1.Columns.Add("TotalFinalSinDtosAplicados");
            dtOrdena1.Columns.Add("PorcentajeTotalDtoAplicados");

            /*Muestra ordena*/

            dtOrdena2.Columns.Add("idproveedor");
            dtOrdena2.Columns.Add("nombreproveedor");
            dtOrdena2.Columns.Add("idproducto");
            dtOrdena2.Columns.Add("nombreproducto");
            dtOrdena2.Columns.Add("coberturaenfermedad");
            dtOrdena2.Columns.Add("coberturaaccidente");
            dtOrdena2.Columns.Add("coberturaperdida");
            dtOrdena2.Columns.Add("coberturacancelacion");
            dtOrdena2.Columns.Add("deducible");
            dtOrdena2.Columns.Add("tarifafinal");
            dtOrdena2.Columns.Add("TotalFinalDtosAplicados");
            dtOrdena2.Columns.Add("TotalFinalSinDtosAplicados");
            dtOrdena2.Columns.Add("PorcentajeTotalDtoAplicados");

            /*Muestra ordena*/

            dtOrdena3.Columns.Add("idproveedor");
            dtOrdena3.Columns.Add("nombreproveedor");
            dtOrdena3.Columns.Add("idproducto");
            dtOrdena3.Columns.Add("nombreproducto");
            dtOrdena3.Columns.Add("coberturaenfermedad");
            dtOrdena3.Columns.Add("coberturaaccidente");
            dtOrdena3.Columns.Add("coberturaperdida");
            dtOrdena3.Columns.Add("coberturacancelacion");
            dtOrdena3.Columns.Add("deducible");
            dtOrdena3.Columns.Add("tarifafinal");
            dtOrdena3.Columns.Add("TotalFinalDtosAplicados");
            dtOrdena3.Columns.Add("TotalFinalSinDtosAplicados");
            dtOrdena3.Columns.Add("PorcentajeTotalDtoAplicados");
            
            /*Muestra ordena*/

            dtOrdena4.Columns.Add("idproveedor");
            dtOrdena4.Columns.Add("nombreproveedor");
            dtOrdena4.Columns.Add("idproducto");
            dtOrdena4.Columns.Add("nombreproducto");
            dtOrdena4.Columns.Add("coberturaenfermedad");
            dtOrdena4.Columns.Add("coberturaaccidente");
            dtOrdena4.Columns.Add("coberturaperdida");
            dtOrdena4.Columns.Add("coberturacancelacion");
            dtOrdena4.Columns.Add("deducible");
            dtOrdena4.Columns.Add("tarifafinal");
            dtOrdena4.Columns.Add("TotalFinalDtosAplicados");
            dtOrdena4.Columns.Add("TotalFinalSinDtosAplicados");
            dtOrdena4.Columns.Add("PorcentajeTotalDtoAplicados");
            
            /*Muestra ordena*/

            dtOrdena5.Columns.Add("idproveedor");
            dtOrdena5.Columns.Add("nombreproveedor");
            dtOrdena5.Columns.Add("idproducto");
            dtOrdena5.Columns.Add("nombreproducto");
            dtOrdena5.Columns.Add("coberturaenfermedad");
            dtOrdena5.Columns.Add("coberturaaccidente");
            dtOrdena5.Columns.Add("coberturaperdida");
            dtOrdena5.Columns.Add("coberturacancelacion");
            dtOrdena5.Columns.Add("deducible");
            dtOrdena5.Columns.Add("tarifafinal");
            dtOrdena5.Columns.Add("TotalFinalDtosAplicados");
            dtOrdena5.Columns.Add("TotalFinalSinDtosAplicados");
            dtOrdena5.Columns.Add("PorcentajeTotalDtoAplicados");


            if ((hdfOpcion.Value == "recotizar") || (hdfOpcion.Value == "buscarseg"))
            {
                idOrigen = ddlOrigen.SelectedIndex;
                IdDestino = ddlDestino.SelectedIndex;
                FechaDesde = datepicker.Text;
                FechaHasta = datepicker2.Text;
                if (txtEdad1.Text.Length != 0)
                {
                    edad1 = Convert.ToInt32(txtEdad1.Text);
                    cantpasajeros = cantpasajeros + 1;
                }
                if (txtEdad2.Text.Length != 0)
                {
                    edad2 = Convert.ToInt32(txtEdad2.Text);
                    cantpasajeros = cantpasajeros + 1;
                }
                if (txtEdad3.Text.Length != 0)
                {
                    edad3 = Convert.ToInt32(txtEdad3.Text);
                    cantpasajeros = cantpasajeros + 1;
                }
                if (txtEdad4.Text.Length != 0)
                {
                    edad4 = Convert.ToInt32(txtEdad4.Text);
                    cantpasajeros = cantpasajeros + 1;
                }
                if (txtEdad5.Text.Length != 0)
                {
                    edad5 = Convert.ToInt32(txtEdad5.Text);
                    cantpasajeros = cantpasajeros + 1;
                }
                if (txtEdad6.Text.Length != 0)
                {
                    edad6 = Convert.ToInt32(txtEdad6.Text);
                    cantpasajeros = cantpasajeros + 1;
                }
                Email = hdfEmail.Value;
                Segmento = Convert.ToInt32(hdfTipoViaje.Value);
            }


            if ((hdfOpcion.Value == "OK")||(hdfOpcion.Value=="vistalista"))
            {

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                for (int i = 0; i < Datos.Count(); i++)
                {

                    if (i == 0)
                    {
                        idOrigen = Convert.ToInt32(Datos[i].ToString());
                    }

                    if (i == 1)
                    {
                        IdDestino = Convert.ToInt32(Datos[i].ToString());

                    }

                    if (i == 2){
                        FechaDesde = Datos[i].ToString();
                    }

                    if (i == 3){
                        FechaHasta = Datos[i].ToString();
                    }

                    if (i == 4)
                    {
                        if (Datos[i].ToString() != ""){
                            edad1 = Convert.ToInt32(Datos[4].ToString());
                            cantpasajeros = cantpasajeros + 1;
                        }

                    }

                    if (i == 5)
                    {
                        if (Datos[5].ToString() != ""){
                            edad2 = Convert.ToInt32(Datos[5].ToString());
                            cantpasajeros = cantpasajeros + 1;
                        }
                    }
                    if (i == 6)
                    {
                        if (Datos[6].ToString() != ""){
                            edad3 = Convert.ToInt32(Datos[6].ToString());
                            cantpasajeros = cantpasajeros + 1;
                        }
                    }

                    if (i == 7)
                    {
                        if (Datos[7].ToString() != ""){
                            edad4 = Convert.ToInt32(Datos[7].ToString());
                            cantpasajeros = cantpasajeros + 1;
                        }
                    }

                    if (i == 8)
                    {
                        if (Datos[8].ToString() != ""){
                            edad5 = Convert.ToInt32(Datos[8].ToString());
                            cantpasajeros = cantpasajeros + 1;
                        }
                    }

                    if (i == 9)
                    {
                        if (Datos[9].ToString() != ""){
                            edad6 = Convert.ToInt32(Datos[9].ToString());
                            cantpasajeros = cantpasajeros + 1;
                        }
                    }

                    if (i == 10)
                    {
                        if (Datos[10].ToString() != "")
                            Email = Datos[10].ToString();
                    }

                    if (i == 11)
                    {
                        if (Datos[11].ToString() != "")
                            Segmento = Convert.ToInt32(Datos[11].ToString());
                    }
                 
                    if (i == 14)
                    {
                        if (Datos[14].ToString() != "")
                            hdfIdSeg.Value = Datos[14].ToString();
                    }

                }
            }

            ordenadoxValorCobertura = Convert.ToInt32(hdfOpcionxPrecio.Value);

            if (ordenadoxValorCobertura == 1)
            {
                desdeValorCobertura = Convert.ToDecimal(hdfPrecioDesde.Value);
                hastaValorCobertura = Convert.ToDecimal(hdfPrecioHasta.Value);
            }
            else
            {
                desdeValorCobertura = 0;
                hastaValorCobertura = 0;
            }

            ordenadoxTarifa = Convert.ToInt32(hdfOpcionxPrecio1.Value);

            if (ordenadoxTarifa == 2)
            {
                desdeTarifa = Convert.ToDecimal(hdfPrecioDesde1.Value);
                hastaTarifa = Convert.ToDecimal(hdfPrecioHasta1.Value);
            }
            else
            {
                desdeTarifa = 0;
                hastaTarifa = 0;
            }

            ordenadopor = Convert.ToInt32(hdfOrdenarPor.Value);
            try
            {
                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                connection = new SqlConnection(conn.ConnectionString);
                ds = new DataSet();
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spBusquedaAvanzadadeTarifas";
                command.Parameters.AddWithValue("IDOrigen", idOrigen);
                command.Parameters.AddWithValue("IDDestino", IdDestino);
                command.Parameters.AddWithValue("FechaDesde1", FechaDesde);
                command.Parameters.AddWithValue("FechaHasta1", FechaHasta);
                command.Parameters.AddWithValue("Edad1", edad1);
                command.Parameters.AddWithValue("Edad2", edad2);
                command.Parameters.AddWithValue("Edad3", edad3);
                command.Parameters.AddWithValue("Edad4", edad4);
                command.Parameters.AddWithValue("Edad5", edad5);
                command.Parameters.AddWithValue("Edad6", edad6);
                command.Parameters.AddWithValue("Email", Email);
                command.Parameters.AddWithValue("ordenadoxTarifa", ordenadoxTarifa);
                command.Parameters.AddWithValue("desdeTarifa", desdeTarifa);
                command.Parameters.AddWithValue("hastaTarifa", hastaTarifa);
                command.Parameters.AddWithValue("ordenadoxCoberturaGlobal", ordenadopor);
                command.Parameters.AddWithValue("desdeValor", desdeValorCobertura);
                command.Parameters.AddWithValue("hastaValor", hastaValorCobertura);
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {
                    cantdias = ds.Tables[0].Rows[0]["cantdias"].ToString();

                    Prov = hdfIdProv.Value.Split('*');

                    cambio = moneda.GetConvertion("ARS", "USD");

                    int columnas = 6;

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        //pregunto por si tengo filtro por proveedor 

                        if (Prov.Count() - 1 > 0)
                        {
                            for (int j = 0; j < Prov.Count() - 1; j++)
                            {
                                if (ds.Tables[0].Rows[i]["IdProveedor"].ToString() == Prov[j].ToString())
                                {
                                    muestraprove = true;
                                    break;
                                }
                                else
                                {
                                    muestraprove = false;
                                }
                            }
                        }

                        //FIN pregunto por si tengo filtro por proveedor 
                        //pregunto por si tengo filtro por límite de cobertura activado

                        if ((Convert.ToInt32(hdfOpcionxPrecio.Value) == 1))
                        {

                            System.Data.SqlClient.SqlConnection conn1;
                            conn1 = new System.Data.SqlClient.SqlConnection();
                            conn1.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                            conn1.Open();
                            SqlCommand command1 = new SqlCommand("spselLimiteFiltrosCoberturas", conn1);
                            command1.CommandType = CommandType.StoredProcedure;

                            SqlParameter paramCodRetorno = new SqlParameter("Opcion", SqlDbType.Int);
                            paramCodRetorno.Direction = ParameterDirection.Output;
                            command1.Parameters.Add(paramCodRetorno);
                            command1.Parameters.AddWithValue("IdProducto", Convert.ToInt32(ds.Tables[0].Rows[i]["IdProducto"].ToString()));
                            command1.Parameters.AddWithValue("OpcionCobertura", Convert.ToInt32(hdfOpcionxPrecio.Value));
                            command1.Parameters.AddWithValue("PrecioDesde", Convert.ToInt32(hdfPrecioDesde.Value));
                            command1.Parameters.AddWithValue("PrecioHasta", Convert.ToInt32(hdfPrecioHasta.Value));
                            command1.ExecuteNonQuery();
                            conn1.Close();

                            if (paramCodRetorno.SqlValue.ToString() == "1")
                                muestralimxcobertura = true;
                            else
                                muestralimxcobertura = false;
                        }


                        if (((hdfOpcion.Value == "OK") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)) || ((hdfOpcion.Value == "recotizar") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)) || ((hdfOpcion.Value == "buscarseg") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)) || ((hdfOpcion.Value == "vistalista") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)))
                        {

                            if (columnas == 1)
                            {

                                DataRow row = dtOrdena.NewRow();
                                row["idproveedor"] = ds.Tables[0].Rows[i]["IdProveedor"].ToString();
                                row["nombreproveedor"] = ds.Tables[0].Rows[i]["NombreProveedor"].ToString();
                                row["idproducto"] = ds.Tables[0].Rows[i]["IdProducto"].ToString();
                                row["nombreproducto"] = ds.Tables[0].Rows[i]["NombreProd"].ToString();
                                row["coberturaenfermedad"] = valorcoberturaenfermedad;
                                row["coberturaaccidente"] = valorcoberturaaccidente;
                                row["coberturaperdida"] = valorcoberturaperdida;
                                row["coberturacancelacion"] = valorcoberturacancelacion;
                                row["deducible"] = valorcoberturadeducible;
                                row["tarifafinal"] = ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString();
                                row["TotalFinalDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalDtosAplicados"].ToString();
                                row["TotalFinalSinDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();
                                row["PorcentajeTotalDtoAplicados"] = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString();
                                dtOrdena.Rows.Add(row);
                            }

                            if (columnas == 2)
                            {

                                DataRow row1 = dtOrdena1.NewRow();
                                row1["idproveedor"] = ds.Tables[0].Rows[i]["IdProveedor"].ToString();
                                row1["nombreproveedor"] = ds.Tables[0].Rows[i]["NombreProveedor"].ToString();
                                row1["idproducto"] = ds.Tables[0].Rows[i]["IdProducto"].ToString();
                                row1["nombreproducto"] = ds.Tables[0].Rows[i]["NombreProd"].ToString();
                                row1["coberturaenfermedad"] = valorcoberturaenfermedad;
                                row1["coberturaaccidente"] = valorcoberturaaccidente;
                                row1["coberturaperdida"] = valorcoberturaperdida;
                                row1["coberturacancelacion"] = valorcoberturacancelacion;
                                row1["deducible"] = valorcoberturadeducible;
                                row1["tarifafinal"] = ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString();
                                row1["TotalFinalDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalDtosAplicados"].ToString();
                                row1["TotalFinalSinDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();
                                row1["PorcentajeTotalDtoAplicados"] = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString();
                                dtOrdena1.Rows.Add(row1);
                            }


                            if (columnas == 3)
                            {
                                DataRow row2 = dtOrdena2.NewRow();
                                row2["idproveedor"] = ds.Tables[0].Rows[i]["IdProveedor"].ToString();
                                row2["nombreproveedor"] = ds.Tables[0].Rows[i]["NombreProveedor"].ToString();
                                row2["idproducto"] = ds.Tables[0].Rows[i]["IdProducto"].ToString();
                                row2["nombreproducto"] = ds.Tables[0].Rows[i]["NombreProd"].ToString();
                                row2["coberturaenfermedad"] = valorcoberturaenfermedad;
                                row2["coberturaaccidente"] = valorcoberturaaccidente;
                                row2["coberturaperdida"] = valorcoberturaperdida;
                                row2["coberturacancelacion"] = valorcoberturacancelacion;
                                row2["deducible"] = valorcoberturadeducible;
                                row2["tarifafinal"] = ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString();
                                row2["TotalFinalDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalDtosAplicados"].ToString();
                                row2["TotalFinalSinDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();
                                row2["PorcentajeTotalDtoAplicados"] = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString();
                                dtOrdena2.Rows.Add(row2);
                            }

                            if (columnas == 4)
                            {

                                DataRow row3 = dtOrdena3.NewRow();
                                row3["idproveedor"] = ds.Tables[0].Rows[i]["IdProveedor"].ToString();
                                row3["nombreproveedor"] = ds.Tables[0].Rows[i]["NombreProveedor"].ToString();
                                row3["idproducto"] = ds.Tables[0].Rows[i]["IdProducto"].ToString();
                                row3["nombreproducto"] = ds.Tables[0].Rows[i]["NombreProd"].ToString();
                                row3["coberturaenfermedad"] = valorcoberturaenfermedad;
                                row3["coberturaaccidente"] = valorcoberturaaccidente;
                                row3["coberturaperdida"] = valorcoberturaperdida;
                                row3["coberturacancelacion"] = valorcoberturacancelacion;
                                row3["deducible"] = valorcoberturadeducible;
                                row3["tarifafinal"] = ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString();
                                row3["TotalFinalDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalDtosAplicados"].ToString();
                                row3["TotalFinalSinDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();
                                row3["PorcentajeTotalDtoAplicados"] = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString();
                                dtOrdena3.Rows.Add(row3);
                            }

                            if (columnas == 5)
                            {

                                DataRow row5 = dtOrdena4.NewRow();
                                row5["idproveedor"] = ds.Tables[0].Rows[i]["IdProveedor"].ToString();
                                row5["nombreproveedor"] = ds.Tables[0].Rows[i]["NombreProveedor"].ToString();
                                row5["idproducto"] = ds.Tables[0].Rows[i]["IdProducto"].ToString();
                                row5["nombreproducto"] = ds.Tables[0].Rows[i]["NombreProd"].ToString();
                                row5["coberturaenfermedad"] = valorcoberturaenfermedad;
                                row5["coberturaaccidente"] = valorcoberturaaccidente;
                                row5["coberturaperdida"] = valorcoberturaperdida;
                                row5["coberturacancelacion"] = valorcoberturacancelacion;
                                row5["deducible"] = valorcoberturadeducible;
                                row5["tarifafinal"] = ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString();
                                row5["TotalFinalDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalDtosAplicados"].ToString();
                                row5["TotalFinalSinDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();
                                row5["PorcentajeTotalDtoAplicados"] = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString();
                                dtOrdena4.Rows.Add(row5);
                            }

                            if (columnas == 6)
                            {
                                DataRow row6 = dtOrdena5.NewRow();
                                row6["idproveedor"] = ds.Tables[0].Rows[i]["IdProveedor"].ToString();
                                row6["nombreproveedor"] = ds.Tables[0].Rows[i]["NombreProveedor"].ToString();
                                row6["idproducto"] = ds.Tables[0].Rows[i]["IdProducto"].ToString();
                                row6["nombreproducto"] = ds.Tables[0].Rows[i]["NombreProd"].ToString();
                                row6["coberturaenfermedad"] = valorcoberturaenfermedad;
                                row6["coberturaaccidente"] = valorcoberturaaccidente;
                                row6["coberturaperdida"] = valorcoberturaperdida;
                                row6["coberturacancelacion"] = valorcoberturacancelacion;
                                row6["deducible"] = valorcoberturadeducible;
                                row6["tarifafinal"] = ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString();
                                row6["TotalFinalDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalDtosAplicados"].ToString();
                                row6["TotalFinalSinDtosAplicados"] = ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();
                                row6["PorcentajeTotalDtoAplicados"] = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString();
                                dtOrdena5.Rows.Add(row6);
                            }

                            //if ((columnas < 6) && (p < ds.Tables[0].Rows.Count - 1))
                            //{
                            //    columnas = columnas + 1;
                            //}
                            //else
                            //{
                            //    columnas = 1;
                            //}

                        }

                        dsOrdena.Tables.Add(dtOrdena);
                        dsOrdena1.Tables.Add(dtOrdena1);

                        dsOrdena2.Tables.Add(dtOrdena2);
                        dsOrdena3.Tables.Add(dtOrdena3);

                        dsOrdena4.Tables.Add(dtOrdena4);
                        dsOrdena5.Tables.Add(dtOrdena5);

                        /* Primer Dataset */

                        tabla += " <div id='vis1' style='display:block;'> " +
                                    " <div class='table-wrapper tipotabla'> " +
                                    " <table> " +
                                      " <thead> " +
                                        " <tr> " +
                                          " <td class='center'><span>COMPARE PLANES</span></td> " +
                                          " <td class='center'><span>OPCION 1</span></td> " +
                                          " <td class='center'><span>OPCION 2</span></td> " +
                                          " <td class='center'><span>OPCION 3</span> " +
                                          " <a class='close link-hide TXFP' onclick='v1()'><i class='fa fa-chevron-right' title='ver mas'></i></a> " +
                                          " </td> " +
                                        " </tr> " +
                                      " </thead> " +
                                      " <tbody> ";

                        for (int q = 0; q < dsOrdena.Tables[0].Rows.Count; q++)
                        {
                            tabla += "  <tr> " +
                                     "  <th class='plan-titulo'><img alt='Travelex logo' src='images/logos/Travelex.gif' style='border: none;;border: none;' height='36' width='100'><br>" + dsOrdena.Tables[0].Rows[q]["NombreProveedor"].ToString() + "</th> ";
                            contopciones = 0;
                            for (int t = 0; t < dsOrdena.Tables[0].Rows.Count; t++)
                            {
                                if ((dsOrdena.Tables[0].Rows[q]["idproveedor"].ToString() == dsOrdena1.Tables[0].Rows[t]["idproveedor"].ToString()) && (contopciones < 3))
                                {
                                    if (Convert.ToInt32(dsOrdena1.Tables[0].Rows[t]["PorcentajeTotalDtoAplicados"].ToString()) > 0)
                                    {
                                        totalporcentajedto = dsOrdena1.Tables[0].Rows[t]["PorcentajeTotalDtoAplicados"].ToString() + " % OFF";
                                        preciosindto = "AR$ " + dsOrdena1.Tables[0].Rows[t]["TotalFinalSinDtosAplicados"].ToString();
                                    }
                                    else
                                    {
                                        totalporcentajedto = "";
                                        preciosindto = "";
                                    }

                                    valorcambio = Decimal.Round(Convert.ToDecimal(dsOrdena1.Tables[0].Rows[t]["tarifafinal"].ToString()) * cambio, 2);

                                    contopciones += 1;

                                    tabla += " <td><span class='precio-des'> " + totalporcentajedto + " </span><span class='precioantes'> " + preciosindto + "</span><br> " +
                                    " <span class='plan-cost'>AR$ " + dsOrdena1.Tables[0].Rows[t]["tarifafinal"].ToString() + "</span><br> " +
                                    " <span class='plan-dolar'>U$D " + valorcambio.ToString() + " </span> " +
                                    " <input class='button special small' name='productCode:TXFP' value='COMPRAR' type='submit' onclick='comprar(" + dsOrdena1.Tables[0].Rows[t]["tarifafinal"].ToString() + "," + valorcambio.ToString() + "," + cantpasajeros.ToString() + "," + cantdias + "," + dsOrdena1.Tables[0].Rows[t]["IdProducto"].ToString() + ");'> " +
                                    " <div class='plan-compare'> " +
                                    " <div class='checkbox plan2'> " +
                                    " <label style=''> " +
                                            " <input id=" + dsOrdena1.Tables[0].Rows[t]["IdProducto"].ToString() + " name='compara' class='compare-check no-auto-update' value='TXFP' type='checkbox' onclick='cuentacompara();'> " +
                                            " <span class='compare-label'>comparar</span> | <span class='compare-label'><a href='verplan.aspx?op=" + dsOrdena1.Tables[0].Rows[t]["IdProducto"].ToString() + "*" + "' class='iframe'><i class='fa fa-xs fa-search'></i> VER MAS</a></span> " +
                                    " </label> " +
                                    " </div> " +
                                    " </div> " +
                                    " </td> ";
                                }
                            }
                            tabla += " </tr> ";
                        }

                        tabla += " </tbody> " +
                                 " </table>" +
                                 " </div> " +
                                 " </div> ";

                        tabla += " <div id='vis2' style='display:none;'> " +
                                    " <div class='table-wrapper tipotabla'> " +
                                    " <table> " +
                                      " <thead> " +
                                        " <tr> " +
                                          " <td class='center'><a class='close2 link-hide TXFP' onclick='v2()' ><i class='fa fa-chevron-left' title='ver mas'></i></a><span>COMPARE PLANES</span></td> " +
                                          " <td class='center'><span>OPCION 4</span></td> " +
                                          " <td class='center'><span>OPCION 5</span></td> " +
                                          " <td class='center'><span>OPCION 6</span> " +
                                          " </td> " +
                                        " </tr> " +
                                      " </thead> " +
                                      " <tbody> ";

                        for (int y = 0; y < dsOrdena2.Tables[0].Rows.Count; y++)
                        {

                            if (dsOrdena2.Tables[0].Rows[y]["idproveedor"].ToString() != dsOrdena3.Tables[0].Rows[y]["idproveedor"].ToString())
                            {
                                tabla += " <tr> " +
                                " <th class='plan-titulo'> " +
                                " <div class='masatras'><a onclick='v2()'><i class='fa fa-chevron-left' title='ver mas'></i></a></div> " +
                                " <img alt='Travelex logo' src='images/logos/Travelex.gif' style='border: none;;border: none;' height='36' width='100'><br>" + dsOrdena2.Tables[0].Rows[y]["NombreProveedor"].ToString() + "</th> ";
                                contopciones = 0;

                                for (int p = 0; p < dsOrdena3.Tables[0].Rows.Count; p++)
                                {
                                    if ((dsOrdena2.Tables[0].Rows[y]["idproveedor"].ToString() == dsOrdena3.Tables[0].Rows[p]["idproveedor"].ToString()) && (contopciones < 3))
                                    {
                                        if (Convert.ToInt32(dsOrdena2.Tables[0].Rows[y]["PorcentajeTotalDtoAplicados"].ToString()) > 0)
                                        {
                                            totalporcentajedto = dsOrdena2.Tables[0].Rows[y]["PorcentajeTotalDtoAplicados"].ToString() + " % OFF";
                                            preciosindto = "AR$ " + dsOrdena2.Tables[0].Rows[y]["TotalFinalSinDtosAplicados"].ToString();
                                        }
                                        else
                                        {
                                            totalporcentajedto = "";
                                            preciosindto = "";
                                        }

                                        valorcambio = Decimal.Round(Convert.ToDecimal(dsOrdena2.Tables[0].Rows[y]["tarifafinal"].ToString()) * cambio, 2);
                                        contopciones += 1;
                                        tabla += " <td><span class='precio-des'> " + totalporcentajedto + " </span><span class='precioantes'> " + preciosindto + "</span><br> " +
                                            " <span class='plan-cost'>AR$ " + dsOrdena2.Tables[0].Rows[y]["tarifafinal"].ToString() + "</span><br> " +
                                            " <span class='plan-dolar'>U$D " + valorcambio.ToString() + "</span> " +
                                            " <input class='button special small' name='productCode:TXFP' value='COMPRAR' type='submit' onclick='comprar(" + dsOrdena2.Tables[0].Rows[y]["tarifafinal"].ToString() + "," + valorcambio.ToString() + "," + cantpasajeros.ToString() + "," + cantdias + "," + dsOrdena2.Tables[0].Rows[y]["IdProducto"].ToString() + ");'> " +
                                            " <div class='plan-compare'> " +
                                            " <div class='checkbox plan2'> " +
                                            " <label style=''> " +
                                                " <input  id=" + dsOrdena2.Tables[0].Rows[y]["IdProducto"].ToString() + " name='compara' class='compare-check no-auto-update' value='TXFP' type='checkbox' onclick='cuentacompara();'> " +
                                                    " <span class='compare-label'>comparar</span> | <span class='compare-label'><a href='verplan.aspx?op=" + dsOrdena2.Tables[0].Rows[y]["IdProducto"].ToString() + "*" + "' class='iframe'><i class='fa fa-xs fa-search'></i> VER MAS</a></span> " +
                                            " </label> " +
                                            " </div> " +
                                            " </div> " +
                                        "</td> ";
                                    }
                                }

                                tabla += "</tr>  ";
                            }
                        }

                        tabla += " </tbody> " +
                                 " </table>" +
                                 " </div> " +
                                 " </div> ";
                    }


                    ds.Dispose();
                    dsOrdena.Dispose();
                    dsOrdena1.Dispose();
                    dsOrdena2.Dispose();
                    dsOrdena3.Dispose();

                    dtOrdena.Dispose();
                    dtOrdena1.Dispose();
                    dtOrdena2.Dispose();
                    dtOrdena3.Dispose();

                    conn.Close();

                    Response.Write(tabla);
                }
            }
            catch (Exception ex)
            { }
            finally
            {

            }

        }


        public void muestracomparacion()
        {
            DataSet ds = new DataSet();
            SqlConnection connection;
            SqlDataAdapter adapter;
            String tabla = "";
            String[] Prod;

            try
            {
                if (hdfActivaCompara.Value == "1")
                {
                    tabla = "<tabla>";
                    Prod = hdfProdCompara.Value.Split('*');

                    if (Prod.Count() - 1 > 0)
                    {
                        for (int j = 0; j < Prod.Count() - 1; j++)
                        {
                            System.Data.SqlClient.SqlConnection conn;
                            conn = new System.Data.SqlClient.SqlConnection();
                            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                            conn.Open();
                            SqlCommand command = new SqlCommand("spselComparativa", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("IDProducto", Convert.ToInt32(Prod[j].ToString()));
                            command.ExecuteNonQuery();
                            adapter = new SqlDataAdapter(command);
                            adapter.Fill(ds);
                            conn.Close();

                            if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                            {
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    tabla += "<tr>" +
                                              "<td>" + ds.Tables[0].Rows[i]["Nombre"].ToString() + "</td>" +
                                              "<td>" + ds.Tables[0].Rows[i]["Descripcion"].ToString() + "</td>" +
                                              "<td>" + ds.Tables[0].Rows[i]["ValorCobertura"].ToString() + "</td>" +
                                              "<td>" + ds.Tables[0].Rows[i]["SimboloMoneda"].ToString() + "</td>" +
                                            "</tr>";
                                }
                            }
                        }

                        tabla += "</tabla>";
                    }


                    ds.Dispose();

                    Response.Write(tabla);
                }

            }
            catch (Exception ex)
            { }
            finally { }
        }


        public void cargarfiltrosproveedores()
        {

            DataSet ds;
            DataTable dtSource;
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            String tabla = "";
            String[] Prov;
            Prov = hdfIdProv.Value.Split('*');

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                connection = new SqlConnection(conn.ConnectionString);
                ds = new DataSet();
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spselProveedores";
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if ((Prov.Count() - 1) > 0)
                        {

                            for (int j = 0; j < Prov.Count() - 1; j++)
                            {
                                if (ds.Tables[0].Rows[i]["IdProveedor"].ToString() == Prov[j].ToString())
                                {
                                    tabla += " <li class=''> " +
                                     " <input id=" + ds.Tables[0].Rows[i]["IdProveedor"].ToString() + "  checked='checked' type='checkbox'  name='prov' onclick='buscarprov();' /> " +
                                     " <span>" + ds.Tables[0].Rows[i]["Nombre"].ToString() + "</span> (<span class='dynamicCount'>0</span>)</li> ";
                                }
                                else
                                {
                                    tabla += " <li class=''> " +
                                              " <input id=" + ds.Tables[0].Rows[i]["IdProveedor"].ToString() + " type='checkbox'  name='prov' onclick='buscarprov();'/> " +
                                               " <span>" + ds.Tables[0].Rows[i]["Nombre"].ToString() + "</span> (<span class='dynamicCount'>0</span>)</li> ";


                                }
                            }
                        }
                        else
                        {
                            tabla += " <li class=''> " +
                            " <input id=" + ds.Tables[0].Rows[i]["IdProveedor"].ToString() + " type='checkbox'  name='prov' onclick='buscarprov();'/> " +
                            " <span>" + ds.Tables[0].Rows[i]["Nombre"].ToString() + "</span> (<span class='dynamicCount'>0</span>)</li> ";
                        }
                    }
                }

                ds.Dispose();
                conn.Close();

                Response.Write(tabla);
            }
            catch (Exception ex)
            { }
            finally
            {

            }

        }

        public void cargarfiltrosSegmentos()
        {

            DataSet ds;
            DataTable dtSource;
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            String tabla = "";
            String opciones = "";
            String[] Datos;
            String Segmento = "";
            String[] idSeg;
            Boolean muestrasegseleccionado = false;

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                connection = new SqlConnection(conn.ConnectionString);
                ds = new DataSet();
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spselSegmentos";
                command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);

                tabla += "  <table>";

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');
              
                if ((hdfOpcion.Value == "OK")||(hdfOpcion.Value == "vistalista"))
                {
                    if (Datos.Count() > 0)
                        Segmento = Datos[11].ToString();
                }
                if ((hdfOpcion.Value == "recotizar") || (hdfOpcion.Value == "buscarseg"))
                {
                    Segmento = hdfTipoViaje.Value;
                }

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {

                    if (Segmento == "1")
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++){
                            if (ds.Tables[0].Rows[i]["IdSegmento"].ToString() == "8"){
                                tabla += "  <li class=''>" +
                                            " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' checked='checked'/> " +
                                            " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                            "</li> ";
                            }
                            else{
                                tabla += "  <li class=''>" +
                                " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' /> " +
                                " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                "</li> ";
                            }
                        }
                    }
                    if (Segmento == "2"){
                        
                        idSeg = hdfIdSeg.Value.Split('*');

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++){
                            if (idSeg.Count() > 0){
                                muestrasegseleccionado = false;
                                for (int j = 0; j < idSeg.Count() - 1; j++){
                                    if (ds.Tables[0].Rows[i]["IdSegmento"].ToString() == idSeg[j].ToString()){
                                        muestrasegseleccionado = true;
                                        break;
                                    }
                                }
                            }

                            if (muestrasegseleccionado == true){
                                tabla += "  <li class=''>" +
                                           " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' checked='checked'/> " +
                                           " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                        "</li> ";
                            }
                            else{
                                tabla += "  <li class=''>" +
                                       " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' /> " +
                                       " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                       "</li> ";
                            }
                        }
                    }
                }

                ds.Dispose();
                conn.Close();

                tabla += "  </table";
                Response.Write(tabla);
            }
            catch (Exception ex)
            { }
            finally
            {

            }

        }

        protected void CargarDatos()
        {

            SqlDataAdapter da;
            DataSet ds;
            String opciones = "";
            String[] Datos;
            Int32 idOrigen = 0;
            Int32 IdDestino = 0;

            try
            {
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdPais as 'Id',NombrePais as 'Descripcion' from PaisdeOrigen order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlOrigen.DataSource = ds;
                ddlOrigen.DataValueField = "Id";
                ddlOrigen.DataTextField = "Descripcion";
                ddlOrigen.DataBind();

                ds.Dispose();


                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdDestino as 'Id',Descripcion as 'Descripcion' from Destinos order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlDestino.DataSource = ds;
                ddlDestino.DataValueField = "Id";
                ddlDestino.DataTextField = "Descripcion";
                ddlDestino.DataBind();

                ds.Dispose();


                da = new SqlDataAdapter("  Select '17'  as 'Id',  'Menor Precio' as 'Descripcion'      Union " +
                                         " Select '18'  as 'Id',  'Mayor Precio' as 'Descripcion'      Union " +
                                         " Select '5'   as 'Id',  'Proveedor ASC' as 'Descripcion'     Union " +
                                         " Select '6'   as 'Id',  'Proveedor DESC' as 'Descripcion'    Union " +
                                         " Select '7'   as 'Id',  'Enfermedad ASC' as 'Descripcion'    Union " +
                                         " Select '8'   as 'Id',  'Enfermedad DESC' as 'Descripcion'   Union " +
                                         " Select '9'   as 'Id',  'Accidente ASC' as 'Descripcion'     Union " +
                                         " Select '10'  as 'Id',  'Accidente DESC' as 'Descripcion'    Union " +
                                         " Select '11'  as 'Id',  'Pérdida ASC' as 'Descripcion'       Union " +
                                         " Select '12'  as 'Id',  'Pérdida DESC' as 'Descripcion'      Union " +
                                         " Select '13'  as 'Id',  'Cancelación ASC' as 'Descripcion'   Union " +
                                         " Select '14'  as 'Id',  'Cancelación DESC' as 'Descripcion'  Union " +
                                         " Select '15'  as 'Id',  'Deducible ASC' as 'Descripcion'     Union " +
                                         " Select '16'  as 'Id',  'Deducible DESC' as 'Descripcion' ", conn);


                ds = new DataSet();
                da.Fill(ds);
                ds.Dispose();

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                for (int i = 0; i < Datos.Count(); i++)
                {

                    if (i == 0){
                        ddlOrigen.SelectedIndex = Convert.ToInt32(Datos[i].ToString());
                    }

                    if (i == 1){
                        ddlDestino.SelectedIndex = Convert.ToInt32(Datos[i].ToString());
                    }

                    if (i == 2){
                        datepicker.Text = Datos[i].ToString();
                    }

                    if (i == 3){
                        datepicker2.Text = Datos[i].ToString();
                    }

                    if (i == 4){
                        if (Datos[i].ToString() != "")
                            txtEdad1.Text = Datos[4].ToString();
                    }

                    if (i == 5){
                        if (Datos[5].ToString() != "")
                            txtEdad2.Text = Datos[5].ToString();
                    }
                    
                    if (i == 6){
                        if (Datos[6].ToString() != "")
                            txtEdad3.Text = Datos[6].ToString();
                    }

                    if (i == 7){
                        if (Datos[7].ToString() != "")
                            txtEdad4.Text = Datos[7].ToString();
                    }

                    if (i == 8){
                        if (Datos[8].ToString() != "")
                            txtEdad5.Text = Datos[8].ToString();
                    }

                    if (i == 9){
                        if (Datos[9].ToString() != "")
                            txtEdad6.Text = Datos[9].ToString();
                    }

                    if (i == 10){
                        if (Datos[10].ToString() != "")
                            hdfEmail.Value = Datos[10].ToString();
                    }

                    if (i == 11){
                        if (Datos[11].ToString() != "")
                            hdfTipoViaje.Value = Datos[11].ToString();
                    }

                    if (i == 13){
                        if (Datos[13].ToString() != "")
                            hdfOpcion.Value = Datos[13].ToString();
                    }

                    if (i == 14){
                         if (Datos[14].ToString() != "")
                             hdfIdSeg.Value = Datos[14].ToString();
                    }
                }
            }
            catch (Exception ex){
            }

        }


        protected void ddlOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            }
            catch (Exception ex){
            }
        }

        protected void ddlDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            }
            catch (Exception ex){
            }
        }


        protected void ddlOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            }
            catch (Exception ex){
            }
        }

        protected void ddlTipodeViaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
            }
            catch (Exception ex){
            }
        }

    }  
    
}
         
