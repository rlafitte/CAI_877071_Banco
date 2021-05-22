using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BancoDatos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            //rutabase = "https://cai-api.azurewebsites.net/api/v1/";
            rutaBase = ConfigurationManager.AppSettings["URL_API"];
            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
    }
}
