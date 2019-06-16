using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAppV2.Models
{
    public class WeatherVM
    {
        public int id { get; set; }

        public string name { get; set; }

        public Main Main { get; set; }

        public Wind Wind { get; set; }

        public List<Weather> Weather { get; set; }

    }
}
