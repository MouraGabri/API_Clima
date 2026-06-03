using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_System.Models
{
    public class Results_Model
    {
        public int temp { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string condition_code { get; set; }
        public string description { get; set; }
        public string currently { get; set; }
        public int woeid { get; set; }
        public string city { get; set; }
        public string img_id { get; set; }
        public int humidity { get; set; }
        public double cloudiness { get; set; }
        public double rain { get; set; }
        public string wind_speedy { get; set; }
        public int wind_direction { get; set; }
        public string wind_cardinal { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moon_phase { get; set; }
        public string condition_slug { get; set; }
        public string city_name { get; set; }
        public string timezone { get; set; }
        public List<Forecast_Model> forecast { get; set; }
        public string cref { get; set; }
    }

}

