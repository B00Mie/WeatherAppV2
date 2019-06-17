using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Models;

namespace WeatherAppV2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //initializing viewbags for evading null reference exception
            ViewBag.weather = null;
            ViewData["forecast"] = null;
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string city, string unit, string lang)
        {
            //trying to get data from API
            try
            {
                //getting current weather
                var weather = WeatherController.GetWeather(city, unit, lang);


                //getting 5-day forecast
                var forecast = WeatherController.GetForecast(city, unit, lang);

                //adding some data to pass to our page
                ViewBag.unit = unit;
                ViewBag.weather = weather.Result;
                ViewData["forecast"] = forecast.Result;
                return View(weather.Result);
            }
            catch(Exception ex)
            {
                //handling possible errors
                if(ex.Message.Contains("Not Found"))
                {
                    ViewBag.errorMsg = "Cannot find city with given name, please try again...";
                }
                else
                {
                    ViewBag.errorMsg = "Something went wrong, please try again...";
                }
                
                return View();
            }

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
