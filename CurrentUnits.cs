using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda_1
{
    internal class CurrentUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string relative_humidity_2m { get; set; }
        public string weather_code { get; set; }
        public string surface_pressure { get; set; }
        public string wind_speed_10m { get; set; }
    }
}
