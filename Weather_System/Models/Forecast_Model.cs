using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_System.Models
{
    public class Forecast_Model
    {
        public string date { get; set; }
        public string full_date { get; set; }
        public string weekday { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public int humidity { get; set; }
        public double cloudiness { get; set; }
        public double rain { get; set; }
        public int rain_probability { get; set; }
        public string wind_speedy { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moon_phase { get; set; }
        public string description { get; set; }
        public string condition { get; set; }

    }
}
