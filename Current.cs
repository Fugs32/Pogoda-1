using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda_1
{
    internal class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public double temperature_2m { get; set; }
        public int relative_humidity_2m { get; set; }
        public int weather_code { get; set; }
        public double surface_pressure { get; set; }
        public double wind_speed_10m { get; set; }
        public int wind_direction_10m { get; set; }
    }
}
