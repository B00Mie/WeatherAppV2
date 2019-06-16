using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAppV2.Models
{
    public class ForecastVM
    {
        public List<List> list { get; set; }

        public City City { get; set; }
    }
}
