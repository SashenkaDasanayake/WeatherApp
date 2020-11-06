using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    class Weather
    {
        public Object getWeatherForcast()
        {
            string appid = "Change this to your APPID from openweathermap.org";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Minneriya&appid=b46dac9ab9628ac1264c3d5069620236&units=imperial";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

    }
}
