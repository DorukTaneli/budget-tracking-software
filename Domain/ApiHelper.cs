using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackingSoftware
{
    class ApiHelper
    {
        #region Members
        public ExRates MyExRates { get; set; }
        #endregion

        #region Public Methods
        public void RefreshRates()
        {
            WebRequest request = HttpWebRequest.Create("https://api.exchangeratesapi.io/latest?base=TRY");

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string ExRates_JSON = reader.ReadToEnd();

            MyExRates = Newtonsoft.Json.JsonConvert.DeserializeObject<ExRates>(ExRates_JSON);
        }

        public void GetRates(DateTime dt)
        {
            String dateString = dt.ToString("yyyy-MM-dd");

            WebRequest request = HttpWebRequest.Create("https://api.exchangeratesapi.io/" + dateString + "?base=TRY");

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string ExRates_JSON = reader.ReadToEnd();

            MyExRates = Newtonsoft.Json.JsonConvert.DeserializeObject<ExRates>(ExRates_JSON);
        }
        #endregion

    }

    public class Rates
    {
        #region Members
        public decimal EUR { get; set; }
        public decimal USD { get; set; }
        public decimal GBP { get; set; }
        public decimal AUD { get; set; }
        public decimal CHF { get; set; }
        public decimal CAD { get; set; }
        #endregion
    }

    public class ExRates
    {
        #region Members
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
        #endregion
    }

}
