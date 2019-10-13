using System;
using System.Net;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;

namespace WebApplication.Pages
{
    public class CurrencyConverter : PageModel
    {
        public StringValues Gbp;
        public StringValues Eur;
        private float exchangeRate()
        {
            var jsonString = new WebClient().DownloadString("https://api.exchangeratesapi.io/latest\\?symbols\\=GBP");
            var json = JObject.Parse(jsonString);
            return json["rates"]["GBP"].Value<float>();
        }
        
        public void OnPost()
        {
            var gbpValue= Request.Form["gbp"];
            this.Gbp = float.Parse(gbpValue).ToString("0.00");
            
            var result = float.Parse(gbpValue) * this.exchangeRate();
            this.Eur = result.ToString("0.00");
        }
    }
}