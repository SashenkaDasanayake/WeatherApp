using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;

namespace WeatherApp.Models
{
    class Weather
    {
        internal static Weather weath;

        public Object getWeatherForcast()
        {
            string appid = "Change this to your APPID from openweathermap.org";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Colombo&appid=b46dac9ab9628ac1264c3d5069620236&units=imperial";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);


            string IP = "";
            string city = "";
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            IP = addr[2].ToString();

            XmlTextReader reader = new XmlTextReader(url);
            
            return jsonContent;
        }

    }
}
