using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;

namespace TuSegurodeViaje.WebSite.varios
{
    public class conversiondemonedas
    {
        protected void Page_Load(object sender, EventArgs e){
            //decimal x = this.GetConvertion("ARS", "USD");
        }

        public decimal GetConvertion(string from, string to){
            WebClient objWebClient = null;
            UTF8Encoding objUTF8 = null;
            decimal result = 0;

            try{
                objWebClient = new WebClient();
                objUTF8 = new UTF8Encoding();

                byte[] aRequestedHTML = objWebClient.DownloadData(String.Format("http://www.xe.com/ucc/convert/?Amount=1&From={0}&To={1}", from, to));
                string strRequestedHTML = objUTF8.GetString(aRequestedHTML);

                int search1 = strRequestedHTML.LastIndexOf("&nbsp;<span class=\"uccResCde\">USD</span>");
                string search2 = strRequestedHTML.Substring(search1 - 21, 21);
                int search3 = search2.LastIndexOf(">");
                string stringRepresentingCE = search2.Substring(search3 + 1);

                result = Convert.ToDecimal(stringRepresentingCE.Trim());


            }
            catch (Exception ex){
                // Agregar codigo para manejar la excepción.
            }

            return result;
        }      
    }
}