using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace TuSegurodeViaje.WebSite
{
    public partial class Comparativa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarDatos();
            }

            else
            {
                if (hdfOpcion.Value == "recotizar")
                {
                    hdfCadena.Value = hdfOrigen.Value + "_" + hdfDestino.Value + "_" + hdfFechaDesde.Value + "_" + hdfFechaHasta.Value + "_" + hdfEdad1.Value + "_" + hdfEdad2.Value + "_" + hdfEdad3.Value + "_" + hdfEdad4.Value + "_" + hdfEdad5.Value + "_" + hdfEdad6.Value + "_" + hdfEmail.Value + "_" + hdfTipoViaje.Value + "_" + hdfIdProv.Value + "_" + hdfOpcion.Value;
                }
            }
          
            ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript:contarfiltros();</script>");
        }

        public void mostrarresultcotiza() 
        {
            String opciones = "";
            String[] Datos;
            DataSet ds;
            DataSet dsxseg=new DataSet();    
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
            Int32 Segmento = 0;
            String[] Prov;
            Boolean muestraprove = true;
            Boolean muestralimcoberxenfermedad = true;
            Boolean muestralimcoberxaccidente = true;
            String[] Seg;
            Boolean muestraprodxsegmento = true;
            Boolean band = false;
            int cont =0 ;
            

            FechaDesde = "1900/01/01";
            FechaHasta = "1900/01/01";
            
            if ((hdfOpcion.Value == "recotizar")||(hdfOpcion.Value=="buscarseg"))
            {
                idOrigen = ddlOrigen.SelectedIndex;
                IdDestino = ddlDestino.SelectedIndex;
                FechaDesde= txtFechaDesde.Text;
                FechaHasta= txtFechaHasta.Text;
                if (txtEdad1.Text.Length != 0)                
                    edad1 = Convert.ToInt32(txtEdad1.Text);
                if (txtEdad2.Text.Length != 0)     
                    edad2 = Convert.ToInt32(txtEdad2.Text);
                if (txtEdad3.Text.Length != 0)     
                    edad3 = Convert.ToInt32(txtEdad3.Text);
                if (txtEdad4.Text.Length != 0)     
                    edad4 = Convert.ToInt32(txtEdad4.Text);
                if (txtEdad5.Text.Length != 0)     
                    edad5 = Convert.ToInt32(txtEdad5.Text);
                if (txtEdad6.Text.Length != 0)     
                    edad6 = Convert.ToInt32(txtEdad6.Text);
                Email = txtEmail.Text;
                Segmento = Convert.ToInt32(hdfTipoViaje.Value);
            }                 
                      

            if (hdfOpcion.Value == "OK")           
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

                        if (i == 2)
                        {
                            
                                FechaDesde = Datos[i].ToString();
                        }

                        if (i == 3)
                        {
                                FechaHasta = Datos[i].ToString();
                        }

                        if (i == 4)
                        {
                            if (Datos[i].ToString() != "")
                                edad1 = Convert.ToInt32(Datos[4].ToString());
                        }

                        if (i==5) 
                        {
                            if (Datos[5].ToString() != "")
                                edad2 = Convert.ToInt32(Datos[5].ToString());
                        }
                        if (i==6) 
                        {
                          if (Datos[6].ToString() != "")
                                edad3 = Convert.ToInt32(Datos[6].ToString());
                        }

                        if (i == 7)
                        {
                            if (Datos[7].ToString() != "")
                                edad4 = Convert.ToInt32(Datos[7].ToString());
                        }

                        if (i == 8)
                        {
                            if (Datos[8].ToString() != "")
                                edad5 = Convert.ToInt32(Datos[8].ToString());
                        }

                        if (i == 9)
                        {
                            if (Datos[9].ToString() != "")
                                edad6 = Convert.ToInt32(Datos[9].ToString());
                        }

                        if (i == 10)
                        {
                            if (Datos[10].ToString() != "")
                                Email =Datos[10].ToString();
                        }

                        if (i == 11)
                        {
                            if (Datos[11].ToString() != "")
                                Segmento = Convert.ToInt32(Datos[11].ToString());
                        }    
                    }                 
            }        

                     
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
	            command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {
                     for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                                //pregunto por si tengo filtro por proveedor 
                                Prov = hdfIdProv.Value.Split('_');

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
                                        muestralimcoberxaccidente = true;
                                    else
                                        muestralimcoberxaccidente = false;
                                }

                                if ((Convert.ToInt32(hdfOpcionxPrecio1.Value) == 2))
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
                                    command1.Parameters.AddWithValue("OpcionCobertura", Convert.ToInt32(hdfOpcionxPrecio1.Value));
                                    command1.Parameters.AddWithValue("PrecioDesde", Convert.ToInt32(hdfPrecioDesde1.Value));
                                    command1.Parameters.AddWithValue("PrecioHasta", Convert.ToInt32(hdfPrecioHasta1.Value));
                                    command1.ExecuteNonQuery();
                                    conn1.Close();

                                    if (paramCodRetorno.SqlValue.ToString() == "1")
                                        muestralimcoberxenfermedad = true;
                                    else
                                        muestralimcoberxenfermedad = false;
                                }
                         
                                //FIN pregunto por si tengo filtro por límite de cobertura activado

                                // pregunto si tengo segmento seleccionado

                                System.Data.SqlClient.SqlConnection conn2;
                                conn2 = new System.Data.SqlClient.SqlConnection();
                                conn2.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                                conn2.Open();
                                SqlCommand command2 = new SqlCommand("spselSegmentosxProductos", conn2);
                                command2.CommandType = CommandType.StoredProcedure;
                                command2.Parameters.AddWithValue("IdProducto", Convert.ToInt32(ds.Tables[0].Rows[i]["IdProducto"].ToString()));
                                command.ExecuteNonQuery();
                                adapter = new SqlDataAdapter(command2);
                                adapter.Fill(dsxseg);
                                conn2.Close();

                                if ((dsxseg != null) && (dsxseg.Tables[0].Rows.Count > 0))
                                {
                                    if (Segmento == 1)
                                    {
                                        for (int j = 0; j < dsxseg.Tables[0].Rows.Count; j++)
                                        {
                                            if (dsxseg.Tables[0].Rows[j]["IdSegmento"].ToString() == "8"){
                                                band = true;
                                                break;
                                            }                                             
                                        }
                                       if (band == true)
                                            muestraprodxsegmento = true;
                                        else
                                            muestraprodxsegmento = false;
                                    }
                                    else
                                    {                                        
                                        Seg = hdfIdSeg.Value.Split('_');
                                        cont = 0;
                                        if (Seg.Count()-1 > 0)
                                        {
                                            for (int x = 0; x < Seg.Count() - 1; x++)
                                            {
                                                for (int j = 0; j < dsxseg.Tables[0].Rows.Count; j++)
                                                {

                                                    if (dsxseg.Tables[0].Rows[j]["IdSegmento"].ToString() == Seg[x].ToString())
                                                    {
                                                        cont += 1;
                                                        break;
                                                    }
                                                }
                                            }                                                                                    
                                        }

                                        if (cont == (Seg.Count() - 1))
                                            muestraprodxsegmento = true;
                                        else
                                            muestraprodxsegmento = false;                                                
                                                                                                           
                                    }
                                }
                                

                                //FIN pregunto por si tengo segmento seleccionado

                                if ((hdfOpcion.Value == "OK") || ((hdfOpcion.Value == "recotizar") && (muestraprove == true) && (muestralimcoberxaccidente == true) && (muestralimcoberxenfermedad == true) && (muestraprodxsegmento = true)) || ((hdfOpcion.Value == "buscarseg")&&(muestraprove == true) && (muestralimcoberxaccidente == true) && (muestralimcoberxenfermedad == true) && (muestraprodxsegmento == true)))
                                    {
                                        tabla += " <div class='product-list-plan-wrapper product-list-  filter-add-24-7 filter-add-flight filter-baggage filter-evac filter-med-up-to-50k TXFP'> " +
                                               "    <div class='column-name'> " +
                                               " <div class='plan-logo'><a href='#' target='_blank' class='viewMoreInfoLogo cboxElement'><img alt='Travelex logo' src='images/logos/Travelex.gif' style='border: none;;border: none;' height='36' width='100'> " +
                                               " </a></div> " +
                                               " <div class='plan-heading'> " +
                                               " <div class='plan-name'>" + ds.Tables[0].Rows[i]["NombreProd"].ToString() + "</div> " +
                                               " <div class='plan-type'>Muerte accidental</div> " +
                                               " </div> " +
                                               " </div> " +
                                               " <div class='product-list-compare-column-show'> " +
                                               " <div class='product-list-compare-column column-tripDelay'> " +
                                               " <p>Trip Interruption</p> " +
                                               " — " +
                                               " <p>Trip Cancellation</p> " +
                                               " — " +
                                               " </div> " +
                                               " <div class='product-list-compare-column column-ratings'> " +
                                               " <div class='plan-rating'><a href='#' target='_blank' class='ratingPopup TICUSPK'> " +
                                               " <div class='review-stars--sm plan-rating__stars'><i class='review-stars__star review-stars__star-'></i><i class='review-stars__star review-stars__star-'></i><i class='review-stars__star review-stars__star-'></i><i class='review-stars__star review-stars__star-'></i><i class='review-stars__star review-stars__star--half'></i></div><br>142 plan </a> " +
                                               " </div> " +
                                               " <div class='plan-productRecommend'><span class='recommendationLink' title='98% de los clientes recomendarian este plan.'>98%  recomendado</span></div> " +
                                               " </div> " +
                                               " <div class='product-list-compare-column column-bbb'>A+</div> " +
                                               " <div class='product-list-compare-column column-company'><img alt='Travelex logo' src='images/logos/Travelex.gif' style='border: none;;border: none;' height='36' width='100'></div> " +
                                               " <div class='product-list-compare-column column-productTerms'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>View Certificate</a></div> " +
                                               " <div class='product-list-compare-column column-productType'><a href='#' onclick='return imtPopup(this.href);' target='_blank'>Flight Accidental Death</a></div> " +
                                               " <div class='product-list-compare-column column-availability'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>U.S. Residents  " +
                                               " <br></a></div> " +
                                               " <div class='product-list-compare-column column-tripCancellation'>—</div> " +
                                               " <div class='product-list-compare-column column-tripInterruption'>—</div> " +
                                               " <div class='product-list-compare-column column-financialDefault'>—</div> " +
                                               " <div class='product-list-compare-column column-terrorism'>—</div> " +
                                               " <div class='product-list-compare-column column-cancelForAnyReasonOption'>—</div> " +
                                               " <div class='product-list-compare-column column-baggage'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$2,000</a></div> " +
                                               " <div class='product-list-compare-column column-baggageDelay'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>12+ hours " +
                                               " <br>$500 max.</a></div> " +
                                               " <div class='product-list-compare-column column-travelDelay'>—</div> " +
                                               " <div class='product-list-compare-column column-medical'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$2,500 Sickness  " +
                                               " <br>$2,500 Accident</a></div> " +
                                               " <div class='product-list-compare-column column-dental'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>Incl. in Medical</a></div> " +
                                               " <div class='product-list-compare-column column-emergencyMedicalEvacuation'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$25,000</a></div> " +
                                               " <div class='product-list-compare-column column-emergencyAssistance'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>Yes</a></div> " +
                                               " <div class='product-list-compare-column column-preExWaiver'>—</div> " +
                                               " <div class='product-list-compare-column column-preExPeriod'>—</div> " +
                                               " <div class='product-list-compare-column column-insuranceCompany'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>Stonebridge Casualty</a></div>" +
                                               " <div class='product-list-compare-column column-AMBest'>A</div> " +
                                               " <div class='product-list-compare-column column-yearsInBuisness'>57</div> " +
                                               " <div class='product-list-compare-column column-refundPolicy'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>10 Day Review Period</a></div> " +
                                               " <div class='product-list-compare-column column-rentalCar'>—</div> " +
                                               " <div class='product-list-compare-column column-accidentalDeath24Hour'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$10,000</a></div> " +
                                               " <div class='product-list-compare-column column-accidentalDeathCommonCarrier'>Included in Accidental Death - 24-Hour</div> " +
                                               " <div class='product-list-compare-column column-accidentalDeathFlight'>Single-Trip &nbsp;<a class='limitations' onclick='return imtPopup(this.href);' target='_blank' href='#'>!</a> " +
                                               " <br> " +
                                               " <input class='auto-update' checked='checked' name='options[TXFP][accidentalDeathFlight]' value='300000' type='radio'> " +
                                               " <a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$300,000 (+$0)</a> " +
                                               " <br> " +
                                               " <input class='auto-update' name='options[TXFP][accidentalDeathFlight]' value='500000' type='radio'> " +
                                               " <a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$500,000 (+$20)</a> " +
                                               " <br> " +
                                               " <input class='auto-update' name='options[TXFP][accidentalDeathFlight]' value='1000000' type='radio'>" +
                                               " <a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>$1,000,000 (+$80)</a></div> " +
                                               " <div class='product-list-compare-column column-fulfillment'><a href='#' onclick='return imtPopup(this.href);' target='_blank' rel='nofollow'>Email</a></div> " +
                                               " <div class='product-list-compare-column column-optionalCoverages'>—</div> " +
                                               " <div class='product-list-compare-column column-travelSupplierRestrictions'>—</div> " +
                                               " <div class='product-list-compare-column column-complicationsOfPregnancy'>—</div> " +
                                               " <div class='product-list-compare-column column-terrorismMedical'>—</div> " +
                                               " <div class='product-list-compare-column column-evacFrom'>—</div> " +
                                               " <div class='product-list-compare-column column-evacTo'>—</div> " +
                                               " <div class='product-list-compare-column column-evacCriteria'>—</div> " +
                                               " <div class='product-list-compare-column column-recurrence'>—</div> " +
                                               " <div class='product-list-compare-column column-renewable'>—</div> " +
                                               " <div class='product-list-compare-column column-viewMoreInfo'><a href='#' target='_blank' class='viewMoreInfo cboxElement'>Ver mas Info</a></div> " +
                                               " <div class='product-list-compare-column column-coverageNotes'>&nbsp;<a class='limitations' onclick='return imtPopup(this.href);' target='_blank' href='#'>Notas de cobertura</a></div> " +
                                               " </div> " +

                                               " <div class='option-tool'> " +
                                               " <div class='plan-cost'> " + ds.Tables[0].Rows[i]["TotalTarifaFinal"].ToString() + "</div> " +
                                               " <div class='details-option list-viewMoreInfo'> " +
                                               " <a href='verplan.html' target='_blank' class='viewMoreInfo cboxElement'>Ver mas info</a> " +
                                               " </div> " +
                                               " </div> " +

                                               " <div class='plan-options'> " +
                                               " <input class='btn btn-success' name='productCode:TXFP' value='Pagar este Plan' type='submit'> " +
                                               " <div class='plan-compare'> " +
                                               " <div class=''> " +
                                               " <label for='toggle-TXFP' title='Seleccionar este plan para compararlo con otros planes.'> " +
                                               " <input id=" + ds.Tables[0].Rows[i]["IdProducto"].ToString() + "  class='compare-check no-auto-update' name='compara' value='TXFP' title='Seleccionar este plan para compararlo con otros planes.' type='checkbox' onclick='cuentacompara();'> " +
                                               //" <span id='compare-TXFP' class='compare-label'>compare plan</span> " +
                                               //" <a href='verplan.html' target='_blank' class='viewMoreInfo cboxElement'>Ver mas info</a> " +
                                               " <a id='compare-TXFP' style='cursor:pointer' onclick='comparaplan();'>compare plan</a> " +
                                               " </label> " +
                                               " </div> " +
                                               " </div> " +
                                               " </div> " +
                                               " <a class='close link-hide TXFP' href='#'><i class='fa fa-times-circle' title='Click para remover de esta lista'></i></a> " +
                                               " </div> ";
                                    }
                                }
                            
                    
                }

               
                ds.Dispose();
                conn.Close();

                Response.Write(tabla);
            }
            catch (Exception ex)
            { }
            finally { 
            
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
                        Prod = hdfProdCompara.Value.Split('_');

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
            Prov = hdfIdProv.Value.Split('_');
            
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

                if (hdfOpcion.Value == "OK")
                {
                    if (Datos.Count() > 0)
                        Segmento = Datos[11].ToString();
                }
                if ((hdfOpcion.Value == "buscarseg")|| (hdfOpcion.Value == "buscarseg"))
                {
                    Segmento = hdfTipoViaje.Value;
                }

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {

                    if (Segmento == "1")
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    if (ds.Tables[0].Rows[i]["IdSegmento"].ToString() == "8")
                                    {
                                        tabla += "  <li class=''>" +
                                                    " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' checked='checked'/> " +
                                                    " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                                    "</li> ";
                                    }
                                    else
                                    {
                                        tabla += "  <li class=''>" +
                                        " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' /> " +
                                        " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                        "</li> ";
                                    }
                                }                            
                        }
                     if (Segmento=="2")
                     {
                         idSeg = hdfIdSeg.Value.Split('_');

                         for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                         {
                             if (idSeg.Count() > 0)
                             {
                                 muestrasegseleccionado = false;
                                 for (int j = 0; j < idSeg.Count() - 1; j++)
                                 {
                                     if (ds.Tables[0].Rows[i]["IdSegmento"].ToString() == idSeg[j].ToString())
                                     {
                                         muestrasegseleccionado = true;
                                         break;
                                     }
                                 }
                             }

                             if (muestrasegseleccionado == true)
                             {
                                 tabla += "  <li class=''>" +
                                            " <input id=" + ds.Tables[0].Rows[i]["IdSegmento"].ToString() + " name='seg' type='checkbox' onclick='buscarseg();' checked='checked'/> " +
                                            " <span>" + ds.Tables[0].Rows[i]["Descripción"].ToString() + "</span> (<span class='dynamicCount'>0</span>) " +
                                         "</li> ";
                             }
                             else 
                             {

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
                da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdDestino as 'Id',Descripcion as 'Descripcion' from Destinos order by 'Id'", conn);
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

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdSegmento as 'Id' ,Descripción as 'Descripcion' from Segmentos order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlTipodeViaje.DataSource = ds;
                ddlTipodeViaje.DataValueField = "Id";
                ddlTipodeViaje.DataTextField = "Descripcion";
                ddlTipodeViaje.DataBind();

                opciones = Request.QueryString["op"];
                Datos = opciones.Split('_');

                for (int i = 0; i < Datos.Count(); i++)
                {

                    if (i == 0)
                    {
                        ddlOrigen.SelectedIndex = Convert.ToInt32(Datos[i].ToString());
                    }

                    if (i == 1)
                    {
                        ddlDestino.SelectedIndex = Convert.ToInt32(Datos[i].ToString());

                    }

                    if (i == 2)
                    {

                        txtFechaDesde.Text = Datos[i].ToString();
                    }

                    if (i == 3)
                    {
                        txtFechaHasta.Text = Datos[i].ToString();
                    }

                    if (i == 4)
                    {
                        if (Datos[i].ToString() != "")
                            txtEdad1.Text = Datos[4].ToString();
                    }

                    if (i == 5)
                    {
                        if (Datos[5].ToString() != "")
                            txtEdad2.Text = Datos[5].ToString();
                    }
                    if (i == 6)
                    {
                        if (Datos[6].ToString() != "")
                            txtEdad3.Text = Datos[6].ToString();
                    }

                    if (i == 7)
                    {
                        if (Datos[7].ToString() != "")
                            txtEdad4.Text = Datos[7].ToString();
                    }

                    if (i == 8)
                    {
                        if (Datos[8].ToString() != "")
                            txtEdad5.Text = Datos[8].ToString();
                    }

                    if (i == 9)
                    {
                        if (Datos[9].ToString() != "")
                            txtEdad6.Text = Datos[9].ToString();
                    }

                    if (i == 10)
                    {
                        if (Datos[10].ToString() != "")
                            txtEmail.Text = Datos[10].ToString();
                    }

                }                                            
              
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
                //System.Data.SqlClient.SqlConnection conn;
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                //conn = new System.Data.SqlClient.SqlConnection();
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                ////Set the DataAdapter's query.
                //da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdDestino as 'Id',Descripcion as 'Descripcion' from Destinos order by 'Id'", conn);
                //ds = new DataSet();
                //da.Fill(ds);
                //ddlOrigen.DataSource = ds;
                //ddlOrigen.DataValueField = "Id";
                //ddlOrigen.DataTextField = "Descripcion";
                //ddlOrigen.DataBind();

                //ds.Dispose();
                //conn.Close();

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
                //System.Data.SqlClient.SqlConnection conn;
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                //conn = new System.Data.SqlClient.SqlConnection();
                //conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                ////Set the DataAdapter's query.
                //da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdDestino as 'Id',Descripcion as 'Descripcion' from Destinos order by 'Id'", conn);
                //ds = new DataSet();
                //da.Fill(ds);
                //ddlDestino.DataSource = ds;
                //ddlDestino.DataValueField = "Id";
                //ddlDestino.DataTextField = "Descripcion";
                //ddlDestino.DataBind();

                //ds.Dispose();
                //conn.Close();

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
                System.Data.SqlClient.SqlConnection conn;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                conn = new System.Data.SqlClient.SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                //Set the DataAdapter's query.
                da = new SqlDataAdapter("Select '0' as 'Id', 'No Seleccionado' as 'Descripcion' union select IdSegmento as 'Id' ,Descripción as 'Descripcion' from Segmentos order by 'Id'", conn);
                ds = new DataSet();
                da.Fill(ds);
                ddlTipodeViaje.DataSource = ds;
                ddlTipodeViaje.DataValueField = "Id";
                ddlTipodeViaje.DataTextField = "Descripcion";
                ddlTipodeViaje.DataBind();

                ds.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {

            }
        }  
               


     }
}