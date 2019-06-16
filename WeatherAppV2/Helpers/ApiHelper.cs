using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherAppV2.Helpers
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static string ApiKey { get; set; }

        public static void InitializeClient()
        {
            ApiKey = "ab612ebf5375d77352246f16e80ad5c7";
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://api.openweathermap.org/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("Helper initialized");

        }
    }
}
