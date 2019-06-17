using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherAppV2.Helpers
{
    public static class ApiHelper
    {
        //defining our API cinet and key. We don't want to have more than 1 instance of them,
        //so we are making them static
        public static HttpClient ApiClient { get; set; }

        public static string ApiKey { get; set; }

        //initializing our client
        public static void InitializeClient()
        {
            //setting API key;
            ApiKey = "ab612ebf5375d77352246f16e80ad5c7";
            //creating new instance of Http client
            ApiClient = new HttpClient();
            //setting base address for it
            ApiClient.BaseAddress = new Uri("http://api.openweathermap.org/");
            //clearing request headers
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            //and adding a new ones;
            ApiClient.DefaultRequestHeaders.Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("Helper initialized");

        }
    }
}
