using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Helpers;
using WeatherAppV2.Models;

namespace WeatherAppV2.Controllers
{
    public class WeatherController : Controller
    {
        public static async Task<WeatherVM> GetWeather(string name = "Kiev", string unit="metric", string lang="en")
        {
            string url = $"data/2.5/weather?q={name}&units={unit}&lang={lang}&APPID={ApiHelper.ApiKey}";

            using (HttpResponseMessage responceMessage = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (responceMessage.IsSuccessStatusCode)
                {
                    WeatherVM weather = await responceMessage.Content.ReadAsAsync<WeatherVM>();

                    return weather;
                }
                else
                {
                    throw new Exception(responceMessage.ReasonPhrase);
                }
            }
        }

        public static async Task<ForecastVM> GetForecast(string name, string unit = "metric", string lang = "en")
        {
            string url = $"data/2.5/forecast?q={name}&units={unit}&lang={lang}&APPID={ApiHelper.ApiKey}";

            using (HttpResponseMessage responceMessage = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (responceMessage.IsSuccessStatusCode)
                {
                    ForecastVM weather = await responceMessage.Content.ReadAsAsync<ForecastVM>();

                    return weather;
                }
                else
                {
                    throw new Exception(responceMessage.ReasonPhrase);
                }
            }
        }
    }
}