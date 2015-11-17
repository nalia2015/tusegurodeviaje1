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
using System.Globalization;

using System.Net;
using System.Net.Mail;

using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using CrystalDecisions.ReportSource;

namespace TuSegurodeViaje.WebSite
{
    public partial class Comparativa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){           
               CargarDatos();              
            }
            else{
                    if (Request.QueryString["op"].ToString() == "recotizar"){

                        if (hdfOpcion.Value == "vistagrilla")
                        {
                            hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfEmail.Value + "_" + hdfTipoViaje.Value + "_" + hdfIdProv.Value + "_" + hdfOpcion.Value;
                            Response.Redirect("planes_ver.aspx?op=" + hdfCadena.Value);
                        }
                        if (hdfOpcion.Value == "comprar")
                        {
                            hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEmail.Value + "_" + hdfCantPasajeros.Value + "_" + hdfCantDias.Value + "_" + hdfPrecioPesos.Value + "_" + hdfPrecioDolar.Value + "_" + hdfOpcion.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfIdProducto.Value + "_" + hdfIdProveedor.Value;
                            Response.Redirect("datos.aspx?op=" + hdfCadena.Value);
                        }
                    }
            }

            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:contarfiltros();</script>");                          
        }

        public void mostrarresultcotiza() 
        {
            String      opciones = "";
            String[]    Datos;
            DataSet     ds;
            DataSet     dsxseg=new DataSet();    
            SqlConnection connection;
            SqlDataAdapter adapter;
            SqlCommand command = new SqlCommand();
            String tabla = "";
            Int32   idOrigen = 0;
            Int32   IdDestino = 0;
            String  FechaDesde;
            String  FechaHasta; 
            Int32   edad1 = 0;
            Int32   edad2 = 0;
            Int32   edad3 = 0;
            Int32   edad4 = 0;
            Int32   edad5 = 0;
            Int32   edad6 = 0;
            String  Email = "";
            Int32 ordenadopor = 5;   
            Int32   Segmento = 0;
            String[] Prov;
            Boolean muestraprove = true;
            Boolean muestralimxcobertura = true;
            Boolean muestralimxtarifa = true;
            String[] Seg;
            Boolean muestraprodxsegmento = true;
            Boolean band = false;
            int cont =0 ;
            DataSet dscompara= new DataSet();
            String  valorcoberturaaccidente="";
            String  valorcoberturaenfermedad="";
            String  valorcoberturacancelacion="";
            String  valorcoberturaperdida="";
            String  valorcoberturadeducible= "";
            int cantpasajeros=0;
            DataTable dtOrdena = new DataTable();
            DataSet dsOrdena = new DataSet();
            String totalporcentajedto = "";
            String preciosindto = "";
            Decimal cambio = 0;
            Decimal valorcambio=0;
            String cantdias="";
            DataSet dstarifa = new DataSet();
            Int32 ordenadoxTarifa = 0;
            Int32 ordenadoxValorCobertura = 0;
            String edades = "";

            Decimal desdeTarifa= 0;
            Decimal hastaTarifa = 0;

            Decimal desdeValorCobertura = 0;
            Decimal hastaValorCobertura = 0;

            DataSet dsestrellas = new DataSet();    

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
            dtOrdena.Columns.Add("pathCG");
            
            if ((hdfOpcion.Value == "recotizar")||(hdfOpcion.Value=="buscarseg")){
                idOrigen = ddlOrigen.SelectedIndex;
                IdDestino = ddlDestino.SelectedIndex;
                FechaDesde= datepicker.Text;
                FechaHasta= datepicker2.Text;
                if (txtEdad1.Text.Length != 0){
                    edad1 = Convert.ToInt32(txtEdad1.Text);
                    edades = txtEdad1.Text;
                    cantpasajeros = cantpasajeros + 1; 
                }
                if (txtEdad2.Text.Length != 0){
                    edad2 = Convert.ToInt32(txtEdad2.Text);
                    edades = edades + "/" + txtEdad2.Text;
                    cantpasajeros = cantpasajeros + 1; 
                }
                if (txtEdad3.Text.Length != 0){
                    edad3 = Convert.ToInt32(txtEdad3.Text);
                    edades = edades + "/" + txtEdad3.Text;
                    cantpasajeros = cantpasajeros + 1; 
                }
                if (txtEdad4.Text.Length != 0){
                    edad4 = Convert.ToInt32(txtEdad4.Text);
                    edades = edades + "/" + txtEdad4.Text;
                    cantpasajeros = cantpasajeros + 1; 
                }
                if (txtEdad5.Text.Length != 0){
                    edad5 = Convert.ToInt32(txtEdad5.Text);
                    edades = edades + "/" + txtEdad5.Text;
                    cantpasajeros = cantpasajeros + 1; 
                }
                if (txtEdad6.Text.Length != 0){
                    edad6 = Convert.ToInt32(txtEdad6.Text);
                    edades = edades + "/" + txtEdad6.Text;
                    cantpasajeros = cantpasajeros + 1; 
                }
                Email = hdfEmail.Value;
                Segmento = Convert.ToInt32(hdfTipoViaje.Value);
            }                 
                      

            if (hdfOpcion.Value == "OK"){                   
                    
                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                for (int i = 0; i < Datos.Count(); i++){

                        if (i == 0) {
                            idOrigen = Convert.ToInt32(Datos[i].ToString());
                        }

                        if (i == 1){
                            IdDestino = Convert.ToInt32(Datos[i].ToString());
                        }

                        if (i == 2){                            
                            FechaDesde = Datos[i].ToString();
                        }

                        if (i == 3){
                            FechaHasta = Datos[i].ToString();
                        }

                        if (i == 4){
                            if (Datos[i].ToString() != ""){
                                edad1 = Convert.ToInt32(Datos[4].ToString());
                                edades = Datos[4].ToString();
                                cantpasajeros=cantpasajeros + 1; 
                            }
                        }

                        if (i==5) {
                            if (Datos[5].ToString() != ""){
                                edad2 = Convert.ToInt32(Datos[5].ToString());
                                edades = edades + "/" + Datos[5].ToString();
                                cantpasajeros=cantpasajeros + 1; 
                            }
                        }
                        if (i==6) {
                          if (Datos[6].ToString() != ""){
                                edad3 = Convert.ToInt32(Datos[6].ToString());
                                edades = edades + "/" + Datos[6].ToString();
                               cantpasajeros=cantpasajeros + 1; 
                          }
                        }

                        if (i == 7){
                            if (Datos[7].ToString() != ""){
                                edad4 = Convert.ToInt32(Datos[7].ToString());
                                edades = edades + "/" + Datos[7].ToString();
                                cantpasajeros=cantpasajeros + 1; 
                            }
                        }

                        if (i == 8){
                            if (Datos[8].ToString() != ""){
                                edad5 = Convert.ToInt32(Datos[8].ToString());
                                edades = edades + "/" + Datos[8].ToString();
                                cantpasajeros=cantpasajeros + 1; 
                            }
                        }

                        if (i == 9){
                            if (Datos[9].ToString() != ""){
                                edad6 = Convert.ToInt32(Datos[9].ToString());
                                edades = edades + "/" + Datos[9].ToString();
                                cantpasajeros=cantpasajeros + 1; 
                            }
                        }

                        if (i == 10){
                            if (Datos[10].ToString() != "")
                                Email = Datos[10].ToString();
                        }

                        if (i == 11){
                            if (Datos[11].ToString() != "")
                                Segmento = Convert.ToInt32(Datos[11].ToString());
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

            if (ordenadoxTarifa == 2){
                desdeTarifa = Convert.ToDecimal(hdfPrecioDesde1.Value);
                hastaTarifa = Convert.ToDecimal(hdfPrecioHasta1.Value);
            }
            else{
                desdeTarifa = 0;
                hastaTarifa = 0;           
            }

            ordenadopor = Convert.ToInt32(hdfOrdenarPor.Value);
            
                                
            try{
                
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
                    //pregunto por si tengo filtro por proveedor 
                    Prov = hdfIdProv.Value.Split('*');
                    cambio = moneda.GetConvertion("ARS", "USD");           

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++){
                                
                                if (Prov.Count() - 1 > 0){
                                                                      
                                    for (int j = 0; j < Prov.Count() - 1; j++){
                                        if (ds.Tables[0].Rows[i]["IdProveedor"].ToString() == Prov[j].ToString()){
                                            muestraprove = true;
                                            break;
                                        }
                                        else{
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


                                //FIN pregunto por si tengo filtro por límite de cobertura activado
                                // pregunto si tengo segmento seleccionado

                                if (Segmento == 1)
                                {
                                    if (ds.Tables[0].Rows[i]["IdSegmento1"].ToString() == "1")
                                    {
                                        band = true;                                       
                                    }                                    
                                    if (band == true)
                                        muestraprodxsegmento = true;
                                    else
                                        muestraprodxsegmento = false;
                                }
                                else
                                {
                                    Seg = hdfIdSeg.Value.Split('*');
                                    cont = 0;
                                    if (Seg.Count() - 1 > 0)
                                    {
                                        for (int x = 0; x < Seg.Count() - 1; x++)
                                        {
                                            if (ds.Tables[0].Rows[i]["IdSegmento1"].ToString() == Seg[x].ToString())
                                            {
                                                cont += 1;
                                                break;
                                            }
                                            if (ds.Tables[0].Rows[i]["IdSegmento2"].ToString() == Seg[x].ToString())
                                            {
                                                cont += 1;
                                                break;
                                            }
                                            if (ds.Tables[0].Rows[i]["IdSegmento3"].ToString() == Seg[x].ToString())
                                            {
                                                cont += 1;
                                                break;
                                            }
                                            if (ds.Tables[0].Rows[i]["IdSegmento4"].ToString() == Seg[x].ToString())
                                            {
                                                cont += 1;
                                                break;
                                            }
                                            if (ds.Tables[0].Rows[i]["IdSegmento5"].ToString() == Seg[x].ToString())
                                            {
                                                cont += 1;
                                                break;
                                            }
                                            if (ds.Tables[0].Rows[i]["IdSegmento6"].ToString() == Seg[x].ToString())
                                            {
                                                cont += 1;
                                                break;
                                            }

                                        }
                                    }

                                    if (cont == (Seg.Count() - 1))
                                        muestraprodxsegmento = true;
                                    else
                                        muestraprodxsegmento = false;

                                }


                                //FIN pregunto por si tengo segmento seleccionado

                                if (((hdfOpcion.Value == "OK") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)) || ((hdfOpcion.Value == "recotizar") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)) || ((hdfOpcion.Value == "buscarseg") && (muestraprove == true) && (muestralimxcobertura == true) && (muestralimxtarifa == true) && (muestraprodxsegmento == true)))
                                {                                      
                                                  
                                        if (Convert.ToInt32(ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString()) > 0){
                                            totalporcentajedto = ds.Tables[0].Rows[i]["PorcentajeTotalDtoAplicados"].ToString() + " % OFF";
                                            preciosindto = "AR$ " + ds.Tables[0].Rows[i]["TotalFinalSinDtosAplicados"].ToString();                           
                                        }
                                        else {
                                            totalporcentajedto = "";
                                            preciosindto = "";                                          
                                        }

                                          valorcambio = Decimal.Round(Convert.ToDecimal(ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString()) * cambio, 2);                                       

                                          tabla += " <div id='uno' class='product-list-plan-wrapper' style='display:block'> " +
                                          //"<span class='tituloenviar'><a href='Reportes/visorpresupuesto.aspx?op=" + FechaDesde + "_" + FechaHasta + "_" + idOrigen + "_" + IdDestino + "_" + Email + "_" + edades + "'><i class='fa fa-envelope-o'></i> Haga click  AQUÍ para descargar la cotizacion </a></span>" +
                                          " <div class='column-name'> " +
                                          " <div class='plan-logo'><a href='verempresa.html' class=' iframe2 viewMoreInfoLogo cboxElement'><img alt='Travelex logo' src='images/logos/Travelex.gif' style='border: none;' height='36' width='100'></a> " +
                                          "<div class='plan-compare'> " +
                                          " <div class='checkbox'> " +
                                          "    <label for='toggle-TXFP' title='Seleccionar este plan para compararlo con otros planes.'> " +
                                                  "<input id=" + ds.Tables[0].Rows[i]["IdProducto"].ToString() + "  class='compare-check no-auto-update' name='compara' value='TXFP' title='Seleccionar este plan para compararlo con otros planes.' type='checkbox' onclick='cuentacompara();' > " +
                                                      " <span id='compare-TXFP' class='compare-label'>comparar planes</span> " +
                                              "</label> " +
                                          "</div> " +
                                          "</div> " +
                                          "</div> " +
                                         " </div> " +
                                         " <div class='product-list-compare-column-show productos'> " +
                                          " <!--<div class='icon_enf tit-pre'><p>Enfermedad</p> " +
                                          " <h5 class='am_valu'>u$s 15.000</h5></div>--> " +
                                          " </div>  " +
                                          " <div class='product-list-compare-column-star'> " +
                                          " <div class='product-list-compare-column column-ratings'> ";
                                        tabla += "<div class='plan-rating'><a href='#' target='_blank' class='ratingPopup AAB'> " +
                                                "<div class='review-stars--sm plan-rating__stars'> ";
                                              if (ds.Tables[0].Rows[i]["estrella1"].ToString() == "1")
                                              {
                                                  tabla += " <i class='review-stars__star review-stars__star-'></i> ";
                                              }
                                              if (ds.Tables[0].Rows[i]["estrella2"].ToString() == "1")
                                              {
                                                  tabla += " <i class='review-stars__star review-stars__star-'></i> ";
                                              }
                                              if (ds.Tables[0].Rows[i]["estrella3"].ToString() == "1")
                                              {
                                                  tabla += " <i class='review-stars__star review-stars__star-'></i> ";
                                              }
                                              if (ds.Tables[0].Rows[i]["estrella4"].ToString() == "1")
                                              {
                                                  tabla += " <i class='review-stars__star review-stars__star-'></i> ";
                                              }
                                              if (ds.Tables[0].Rows[i]["estrella5"].ToString() == "1")
                                              {
                                                  tabla += " <i class='review-stars__star review-stars__star-'></i> ";
                                              }
                                              if (ds.Tables[0].Rows[i]["estrellasmedia"].ToString() == "1")
                                              {
                                                  tabla += " <i class='review-stars__star review-stars__star--half'></i> ";
                                              }
                                              tabla += "</div> " +
                                                    "<br>" + ds.Tables[0].Rows[i]["cant_revisiones"].ToString() + " revisiones del plan</a> " +
                                                    "</div> " +
                                                    "<div class='plan-productRecommend'><span class='recommendationLink' title='99% recomendado'>" + ds.Tables[0].Rows[i]["porcentajerecomendado"].ToString() + "% recomendado</span></div> ";                         

                                          tabla += "</div> " +
                                           "</div> " +
                                           "<div class='option-tool'> " +
                                           " <span class='precio-des2'>" + totalporcentajedto + " </span> " +
                                           " <span class='precioantes2'> " + preciosindto + "</span><br> " +
                                           " <span class='plan-cost2'>AR$ " + ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString() + "</span><br> " +
                                           " <span class='plan-dolar2'>U$D " + valorcambio.ToString() + " </span> " +
                                           " <div class='details-option list-viewMoreInfo'> " +
                                           "<a href='' target='_blank' class='viewMoreInfopersonas'>Precio final para " + Convert.ToString(cantpasajeros) + " pasajeros</a>" +
                                           "<a href='verplan.aspx?op=" + ds.Tables[0].Rows[i]["IdProducto"].ToString() + "' class='iframe'><i class='fa fa-xs fa-search'></i> VER MAS</a> " +
                                           "</div> " +
                                           " </div> " +
                                           " <div class='plan-options'> " +
                                           " <input class='btn btn-success' name='productCode:TXFP' value='COMPRAR' type='submit'  onclick='comprar(" + ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString() + "," + valorcambio.ToString() + "," + cantpasajeros.ToString() + "," + cantdias + ", " + ds.Tables[0].Rows[i]["IdProducto"].ToString() + "," + ds.Tables[0].Rows[i]["IdProveedor"].ToString() + ");'> " +
                                           "</div> " +
                                       " <a class='close link-hide TXFP' onclick='ponevisible1();'><i class='fa fa-times-circle' title='Click para remover de esta lista'></i></a> " +
                                       "</div>";
                                }
                        }
               }


                DataSet dsPresu = new DataSet();
                DataTable dtPresu = new DataTable();

                dtPresu.Columns.Add("Producto");
                dtPresu.Columns.Add("Producto2");
                dtPresu.Columns.Add("Producto3");
                dtPresu.Columns.Add("Producto4");

                dtPresu.Columns.Add("Cobertura1");
                dtPresu.Columns.Add("Cobertura2");
                dtPresu.Columns.Add("Cobertura3");
                dtPresu.Columns.Add("Cobertura4");
                dtPresu.Columns.Add("Cobertura5");
                dtPresu.Columns.Add("Cobertura6");

                dtPresu.Columns.Add("ValorCobertura_1");
                dtPresu.Columns.Add("ValorCobertura_1_2");
                dtPresu.Columns.Add("ValorCobertura_1_3");
                dtPresu.Columns.Add("ValorCobertura_1_4");
                dtPresu.Columns.Add("ValorCobertura_1_5");
                dtPresu.Columns.Add("ValorCobertura_1_6");

                dtPresu.Columns.Add("ValorCobertura_2");
                dtPresu.Columns.Add("ValorCobertura_2_2");
                dtPresu.Columns.Add("ValorCobertura_2_3");
                dtPresu.Columns.Add("ValorCobertura_2_4");
                dtPresu.Columns.Add("ValorCobertura_2_5");
                dtPresu.Columns.Add("ValorCobertura_2_6");

                dtPresu.Columns.Add("ValorCobertura_3");
                dtPresu.Columns.Add("ValorCobertura_3_2");
                dtPresu.Columns.Add("ValorCobertura_3_3");
                dtPresu.Columns.Add("ValorCobertura_3_4");
                dtPresu.Columns.Add("ValorCobertura_3_5");
                dtPresu.Columns.Add("ValorCobertura_3_6");

                dtPresu.Columns.Add("ValorCobertura_4");
                dtPresu.Columns.Add("ValorCobertura_4_2");
                dtPresu.Columns.Add("ValorCobertura_4_3");
                dtPresu.Columns.Add("ValorCobertura_4_4");
                dtPresu.Columns.Add("ValorCobertura_4_5");
                dtPresu.Columns.Add("ValorCobertura_4_6");

                dtPresu.Columns.Add("Pasajero");
                dtPresu.Columns.Add("Inicio");
                dtPresu.Columns.Add("Fin");
                dtPresu.Columns.Add("IdOrigen");
                dtPresu.Columns.Add("Origen");
                dtPresu.Columns.Add("IdDestino");
                dtPresu.Columns.Add("Destino");
                dtPresu.Columns.Add("cantdias");
                dtPresu.Columns.Add("cantpasajeros");
                dtPresu.Columns.Add("edades");

                dtPresu.Columns.Add("tarifa1");
                dtPresu.Columns.Add("promo1");
                dtPresu.Columns.Add("comision1");
                dtPresu.Columns.Add("Neto1");

                dtPresu.Columns.Add("tarifa2");
                dtPresu.Columns.Add("promo2");
                dtPresu.Columns.Add("comision2");
                dtPresu.Columns.Add("Neto2");

                dtPresu.Columns.Add("tarifa3");
                dtPresu.Columns.Add("promo3");
                dtPresu.Columns.Add("comision3");
                dtPresu.Columns.Add("Neto3");

                dtPresu.Columns.Add("tarifa4");
                dtPresu.Columns.Add("promo4");
                dtPresu.Columns.Add("comision4");
                dtPresu.Columns.Add("Neto4");

                dtPresu.Columns.Add("IdProducto");
                dtPresu.Columns.Add("IdProducto2");
                dtPresu.Columns.Add("IdProducto3");
                dtPresu.Columns.Add("IdProducto4");

                dtPresu.Columns.Add("email");
                dtPresu.Columns.Add("path");
                dtPresu.Columns.Add("enviado");

                dtPresu.Columns.Add("IdCobertura");
                dtPresu.Columns.Add("IdCobertura2");
                dtPresu.Columns.Add("IdCobertura3");
                dtPresu.Columns.Add("IdCobertura4");
                dtPresu.Columns.Add("IdCobertura5");
                dtPresu.Columns.Add("IdCobertura6");

                dtPresu.Columns.Add("logoDesktop1");
                dtPresu.Columns.Add("logoDesktop2");
                dtPresu.Columns.Add("logoDesktop3");
                dtPresu.Columns.Add("logoDesktop4");

                DataRow rowp = dtPresu.NewRow();

                int columnas = 4;

                for (int p = 0; p < ds.Tables[0].Rows.Count; p++)
                {

                    if (columnas == 4)
                    {

                        rowp["Producto"] = ds.Tables[0].Rows[p]["NombreProd"].ToString();
                        rowp["IdProducto"] = ds.Tables[0].Rows[p]["IdProducto"].ToString();
                        rowp["Cobertura1"] = "Asistencia Médica por Enfermedad";
                        rowp["Cobertura2"] = "Asistencia Médica por Accidente";
                        rowp["Cobertura3"] = "Asistencia Médica por preexistencias";
                        rowp["Cobertura4"] = "Compensacion por cancelación de viaje";
                        rowp["Cobertura5"] = "Compensacion por pérdida de equipaje (línea aérea)";
                        rowp["Cobertura6"] = "Compensacion por vuelo demorado o cacelado";

                        rowp["ValorCobertura_1"] = "$10000";//ds.Tables[0].Rows[p]["coberturaenfermedad"].ToString();
                        rowp["ValorCobertura_1_2"] = "$10000";//ds.Tables[0].Rows[p]["coberturaaccidente"].ToString();
                        rowp["ValorCobertura_1_3"] = "$10000";
                        rowp["ValorCobertura_1_4"] = "$10000";//ds.Tables[0].Rows[p]["coberturacancelacion"].ToString();
                        rowp["ValorCobertura_1_5"] = "$10000";//ds.Tables[0].Rows[p]["coberturaperdida"].ToString();
                        rowp["ValorCobertura_1_6"] = "$10000";

                        rowp["Pasajero"] = "";
                        rowp["Inicio"] = FechaDesde;
                        rowp["Fin"] = FechaHasta;
                        rowp["IdOrigen"] = idOrigen;
                        rowp["Origen"] = ddlOrigen.SelectedItem;
                        rowp["IdDestino"] = IdDestino;
                        rowp["Destino"] = ddlDestino.SelectedItem;
                        rowp["cantdias"] = "";
                        rowp["cantpasajeros"] = cantpasajeros;
                        rowp["edades"] = edades;

                        rowp["email"] = Email;
                        rowp["path"] = "";
                        rowp["enviado"] = 0;
                        rowp["IdCobertura"] = "2";
                        rowp["IdCobertura2"] = "1";
                        rowp["IdCobertura3"] = "0";
                        rowp["IdCobertura4"] = "6";
                        rowp["IdCobertura5"] = "10";
                        rowp["IdCobertura6"] = "0";

                        rowp["tarifa1"] = ds.Tables[0].Rows[p]["TotalFinalSinDtosAplicados"].ToString();
                        rowp["promo1"] = ds.Tables[0].Rows[p]["PorcentajeTotalDtoAplicados"].ToString();
                        rowp["comision1"] = "";
                        rowp["Neto1"] = ds.Tables[0].Rows[p]["TotalFinalDtosAplicados"].ToString();
                        rowp["logoDesktop1"] = ds.Tables[0].Rows[p]["logoDesktop"].ToString();

                    }


                    if (columnas == 3)
                    {

                        rowp["Producto2"] = ds.Tables[0].Rows[p]["NombreProd"].ToString();
                        rowp["IdProducto2"] = ds.Tables[0].Rows[p]["IdProducto"].ToString();
                        rowp["ValorCobertura_2"] = "$10000";//ds.Tables[0].Rows[p]["coberturaenfermedad"].ToString();
                        rowp["ValorCobertura_2_2"] = "$10000";// ds.Tables[0].Rows[p]["coberturaaccidente"].ToString();
                        rowp["ValorCobertura_2_3"] = "$10000";
                        rowp["ValorCobertura_2_4"] = "$10000";//ds.Tables[0].Rows[p]["coberturacancelacion"].ToString();
                        rowp["ValorCobertura_2_5"] = "$10000";//ds.Tables[0].Rows[p]["coberturaperdida"].ToString();
                        rowp["ValorCobertura_2_6"] = "$10000";

                        rowp["tarifa2"] = ds.Tables[0].Rows[p]["TotalFinalSinDtosAplicados"].ToString();
                        rowp["promo2"] = ds.Tables[0].Rows[p]["PorcentajeTotalDtoAplicados"].ToString();
                        rowp["comision2"] = "";
                        rowp["Neto2"] = ds.Tables[0].Rows[p]["TotalFinalDtosAplicados"].ToString();
                        rowp["logoDesktop2"] = ds.Tables[0].Rows[p]["logoDesktop"].ToString();

                    }

                    if (columnas == 2)
                    {

                        rowp["Producto3"] = ds.Tables[0].Rows[p]["NombreProd"].ToString();
                        rowp["IdProducto3"] = ds.Tables[0].Rows[p]["idproducto"].ToString();
                        rowp["ValorCobertura_3"] = "$10000";//ds.Tables[0].Rows[p]["coberturaenfermedad"].ToString();
                        rowp["ValorCobertura_3_2"] = "$10000";//ds.Tables[0].Rows[p]["coberturaaccidente"].ToString();
                        rowp["ValorCobertura_3_3"] = "$10000";
                        rowp["ValorCobertura_3_4"] = "$10000";//ds.Tables[0].Rows[p]["coberturacancelacion"].ToString();
                        rowp["ValorCobertura_3_5"] = "$10000";//ds.Tables[0].Rows[p]["coberturaperdida"].ToString();
                        rowp["ValorCobertura_3_6"] = "$10000";

                        rowp["tarifa3"] = ds.Tables[0].Rows[p]["TotalFinalSinDtosAplicados"].ToString();
                        rowp["promo3"] = ds.Tables[0].Rows[p]["PorcentajeTotalDtoAplicados"].ToString();
                        rowp["comision3"] = "";
                        rowp["Neto3"] = ds.Tables[0].Rows[p]["TotalFinalDtosAplicados"].ToString();
                        rowp["logoDesktop3"] = ds.Tables[0].Rows[p]["logoDesktop"].ToString();

                    }

                    if (columnas == 1)
                    {

                        rowp["Producto4"] = ds.Tables[0].Rows[p]["NombreProd"].ToString();
                        rowp["IdProducto4"] = ds.Tables[0].Rows[p]["IdProducto"].ToString();
                        rowp["ValorCobertura_4"] = "$10000";// ds.Tables[0].Rows[p]["coberturaenfermedad"].ToString();
                        rowp["ValorCobertura_4_2"] = "$10000";// ds.Tables[0].Rows[p]["coberturaaccidente"].ToString();
                        rowp["ValorCobertura_4_3"] = "$10000";
                        rowp["ValorCobertura_4_4"] = "$10000"; //ds.Tables[0].Rows[p]["coberturacancelacion"].ToString();
                        rowp["ValorCobertura_4_5"] = "$10000"; //ds.Tables[0].Rows[p]["coberturaperdida"].ToString();
                        rowp["ValorCobertura_4_6"] = "$10000";

                        rowp["tarifa4"] = ds.Tables[0].Rows[p]["TotalFinalSinDtosAplicados"].ToString();
                        rowp["promo4"] = ds.Tables[0].Rows[p]["PorcentajeTotalDtoAplicados"].ToString();
                        rowp["comision4"] = "";
                        rowp["Neto4"] = ds.Tables[0].Rows[p]["TotalFinalDtosAplicados"].ToString();
                        rowp["logoDesktop4"] = ds.Tables[0].Rows[p]["logoDesktop"].ToString();
                    }
                    if ((columnas > 1) && (p < ds.Tables[0].Rows.Count - 1))
                    {
                        columnas = columnas - 1;
                    }
                    else
                    {
                        columnas = 4;
                        dtPresu.Rows.Add(rowp);
                        rowp = dtPresu.NewRow();
                    }
                }


                dsPresu.Tables.Add(dtPresu);
                guardacotizacion(dsPresu);
                ds.Dispose();
                dsPresu.Dispose();
                conn.Close();
                Response.Write(tabla);                      
               
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{             
            }
            
        }

        private void guardacotizacion( DataSet dspresupuesto) {                     

            DataSet ds = new DataSet();
            SqlConnection connection;
            SqlDataAdapter adapter;         
            ds = new DataSet();

            System.Data.SqlClient.SqlConnection conn;
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;                       
            
            try {
                
                    for (int p = 0; p < dspresupuesto.Tables[0].Rows.Count; p++){                        

                        conn.Open();
                        SqlCommand command = new SqlCommand("spImprimeCotizacion", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("Producto", dspresupuesto.Tables[0].Rows[p]["Producto"].ToString());
                        command.Parameters.AddWithValue("Producto2", dspresupuesto.Tables[0].Rows[p]["Producto2"].ToString());
                        command.Parameters.AddWithValue("Producto3", dspresupuesto.Tables[0].Rows[p]["Producto3"].ToString());
                        command.Parameters.AddWithValue("Producto4", dspresupuesto.Tables[0].Rows[p]["Producto4"].ToString());
                        command.Parameters.AddWithValue("Cobertura1", dspresupuesto.Tables[0].Rows[p]["Cobertura1"].ToString());
                        command.Parameters.AddWithValue("Cobertura2", dspresupuesto.Tables[0].Rows[p]["Cobertura2"].ToString());
                        command.Parameters.AddWithValue("Cobertura3", dspresupuesto.Tables[0].Rows[p]["Cobertura3"].ToString());
                        command.Parameters.AddWithValue("Cobertura4", dspresupuesto.Tables[0].Rows[p]["Cobertura4"].ToString());
                        command.Parameters.AddWithValue("Cobertura5", dspresupuesto.Tables[0].Rows[p]["Cobertura5"].ToString());
                        command.Parameters.AddWithValue("Cobertura6", dspresupuesto.Tables[0].Rows[p]["Cobertura6"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_1", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_1"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_1_2", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_1_2"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_1_3", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_1_3"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_1_4", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_1_4"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_1_5", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_1_5"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_1_6", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_1_6"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_2", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_2"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_2_2", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_2_2"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_2_3", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_2_3"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_2_4", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_2_4"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_2_5", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_2_5"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_2_6", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_2_6"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_3", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_3"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_3_2", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_3_2"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_3_3", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_3_3"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_3_4", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_3_4"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_3_5", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_3_5"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_3_6", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_3_6"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_4", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_4"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_4_2", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_4_2"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_4_3", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_4_3"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_4_4", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_4_4"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_4_5", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_4_5"].ToString());
                        command.Parameters.AddWithValue("ValorCobertura_4_6", dspresupuesto.Tables[0].Rows[p]["ValorCobertura_4_6"].ToString());
                        command.Parameters.AddWithValue("Pasajero", dspresupuesto.Tables[0].Rows[p]["Pasajero"].ToString());
                        command.Parameters.AddWithValue("Inicio", dspresupuesto.Tables[0].Rows[p]["Inicio"].ToString());
                        command.Parameters.AddWithValue("Fin", dspresupuesto.Tables[0].Rows[p]["Fin"].ToString());
                        command.Parameters.AddWithValue("IdOrigen", dspresupuesto.Tables[0].Rows[p]["IdOrigen"].ToString());
                        command.Parameters.AddWithValue("Origen", dspresupuesto.Tables[0].Rows[p]["Origen"].ToString());
                        command.Parameters.AddWithValue("IdDestino", dspresupuesto.Tables[0].Rows[p]["IdDestino"].ToString());
                        command.Parameters.AddWithValue("Destino", dspresupuesto.Tables[0].Rows[p]["Destino"].ToString());
                        command.Parameters.AddWithValue("cantdias", dspresupuesto.Tables[0].Rows[p]["cantdias"].ToString());
                        command.Parameters.AddWithValue("cantpasajeros", dspresupuesto.Tables[0].Rows[p]["cantpasajeros"].ToString());
                        command.Parameters.AddWithValue("edades", dspresupuesto.Tables[0].Rows[p]["edades"].ToString());
                        command.Parameters.AddWithValue("tarifa1", dspresupuesto.Tables[0].Rows[p]["tarifa1"].ToString());
                        command.Parameters.AddWithValue("promo1", dspresupuesto.Tables[0].Rows[p]["promo1"].ToString());
                        command.Parameters.AddWithValue("comision1", dspresupuesto.Tables[0].Rows[p]["comision1"].ToString());
                        command.Parameters.AddWithValue("Neto1", dspresupuesto.Tables[0].Rows[p]["Neto1"].ToString());
                        command.Parameters.AddWithValue("tarifa2", dspresupuesto.Tables[0].Rows[p]["tarifa2"].ToString());
                        command.Parameters.AddWithValue("promo2", dspresupuesto.Tables[0].Rows[p]["promo2"].ToString());
                        command.Parameters.AddWithValue("comision2", dspresupuesto.Tables[0].Rows[p]["comision2"].ToString());
                        command.Parameters.AddWithValue("Neto2", dspresupuesto.Tables[0].Rows[p]["Neto2"].ToString());
                        command.Parameters.AddWithValue("tarifa3", dspresupuesto.Tables[0].Rows[p]["tarifa3"].ToString());
                        command.Parameters.AddWithValue("promo3", dspresupuesto.Tables[0].Rows[p]["promo3"].ToString());
                        command.Parameters.AddWithValue("comision3", dspresupuesto.Tables[0].Rows[p]["comision3"].ToString());
                        command.Parameters.AddWithValue("Neto3", dspresupuesto.Tables[0].Rows[p]["Neto3"].ToString());
                        command.Parameters.AddWithValue("tarifa4", dspresupuesto.Tables[0].Rows[p]["tarifa4"].ToString());
                        command.Parameters.AddWithValue("promo4", dspresupuesto.Tables[0].Rows[p]["promo4"].ToString());
                        command.Parameters.AddWithValue("comision4", dspresupuesto.Tables[0].Rows[p]["comision4"].ToString());
                        command.Parameters.AddWithValue("Neto4", dspresupuesto.Tables[0].Rows[p]["Neto4"].ToString());
                        command.Parameters.AddWithValue("IdProducto", dspresupuesto.Tables[0].Rows[p]["IdProducto"].ToString());
                        command.Parameters.AddWithValue("IdProducto2", dspresupuesto.Tables[0].Rows[p]["IdProducto2"].ToString());
                        command.Parameters.AddWithValue("IdProducto3", dspresupuesto.Tables[0].Rows[p]["IdProducto3"].ToString()); ;
                        command.Parameters.AddWithValue("IdProducto4", dspresupuesto.Tables[0].Rows[p]["IdProducto4"].ToString());
                        command.Parameters.AddWithValue("email", dspresupuesto.Tables[0].Rows[p]["email"].ToString());
                        command.Parameters.AddWithValue("path", dspresupuesto.Tables[0].Rows[p]["path"].ToString());
                        command.Parameters.AddWithValue("enviado", dspresupuesto.Tables[0].Rows[p]["enviado"].ToString());
                        command.Parameters.AddWithValue("IdCobertura", dspresupuesto.Tables[0].Rows[p]["IdCobertura"].ToString());
                        command.Parameters.AddWithValue("IdCobertura2", dspresupuesto.Tables[0].Rows[p]["IdCobertura2"].ToString());
                        command.Parameters.AddWithValue("IdCobertura3", dspresupuesto.Tables[0].Rows[p]["IdCobertura3"].ToString());
                        command.Parameters.AddWithValue("IdCobertura4", dspresupuesto.Tables[0].Rows[p]["IdCobertura4"].ToString());
                        command.Parameters.AddWithValue("IdCobertura5", dspresupuesto.Tables[0].Rows[p]["IdCobertura5"].ToString());
                        command.Parameters.AddWithValue("IdCobertura6", dspresupuesto.Tables[0].Rows[p]["IdCobertura6"].ToString());
                        command.ExecuteNonQuery();
                        adapter = new SqlDataAdapter(command);
                        adapter.Fill(ds);
                        conn.Close();
                        ds.Dispose();
                      
                }
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
            }
        
        }



        public void muestracomparacion() 
        { 
            DataSet ds=new DataSet();          
            SqlConnection connection;
            SqlDataAdapter adapter;
            String tabla = "";
            String[] Prod;

            try
            {
                if (hdfActivaCompara.Value=="1"){            
                        tabla="<tabla>" ;
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
                                                      tabla+= "<tr>" +
                                                                "<td>"+ ds.Tables[0].Rows[i]["Nombre"].ToString()  +"</td>"+
                                                                "<td>"+ ds.Tables[0].Rows[i]["Descripcion"].ToString() +"</td>"+
                                                                "<td>"+ ds.Tables[0].Rows[i]["ValorCobertura"].ToString()+"</td>"+
                                                                "<td>"+ ds.Tables[0].Rows[i]["SimboloMoneda"].ToString()+"</td>"+
                                                              "</tr>";
                                               }                                                
                                        }                                        
                                    }
                                    
                                    tabla+="</tabla>";                                    
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
                            if ((Prov.Count()-1) > 0)
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
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{
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

                if ((hdfOpcion.Value == "OK")){
                    if (Datos.Count() > 0)
                        Segmento = Datos[11].ToString();
                }
                if ((hdfOpcion.Value == "recotizar")|| (hdfOpcion.Value == "buscarseg")){
                    Segmento = hdfTipoViaje.Value;
                }

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0)) {

                    if (Segmento == "1"){
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++){
                                    if (ds.Tables[0].Rows[i]["IdSegmento"].ToString() == "1"){
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
                     if (Segmento=="2"){
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
                             else {

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
            catch (Exception ex){
                Response.Write(ex.Message);
            }
            finally{

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
                                         " Select '5'   as 'Id',  'Proveedor DESC' as 'Descripcion'     Union " +
                                         " Select '6'   as 'Id',  'Proveedor DESC' as 'Descripcion'    Union " +
                                         " Select '7'   as 'Id',  'Enfermedad ASC' as 'Descripcion'    Union" +
                                         " Select '8'   as 'Id',  'Enfermedad DESC' as 'Descripcion'   Union " +
                                         " Select '9'   as 'Id',  'Accidente ASC' as 'Descripcion'     Union" +
                                         " Select '10'   as 'Id', 'Accidente DESC' as 'Descripcion'    Union " +
                                         " Select '11'   as 'Id', 'Pérdida ASC' as 'Descripcion'       Union" +
                                         " Select '12'   as 'Id', 'Pérdida DESC' as 'Descripcion'      Union " + 
                                         " Select '13'   as 'Id', 'Cancelación ASC' as 'Descripcion'   Union" +
                                         " Select '14'   as 'Id', 'Cancelación DESC' as 'Descripcion'  Union " +
                                         " Select '15'   as 'Id', 'Deducible ASC' as 'Descripcion'   Union " +
                                         " Select '16'   as 'Id', 'Deducible DESC' as 'Descripcion' ", conn);


                ds = new DataSet();
                da.Fill(ds);
                ds.Dispose();

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                for (int i = 0; i < Datos.Count(); i++) {

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

                    if (i == 10) {
                        if (Datos[10].ToString() != "")
                           hdfEmail.Value = Datos[10].ToString();
                    }

                    if (i == 11)
                    {
                        if (Datos[11].ToString() != "")
                            hdfTipoViaje.Value = Datos[11].ToString();
                    }

                    if (i == 13)
                    {
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
                Response.Write(ex.Message);
            }
            finally{
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