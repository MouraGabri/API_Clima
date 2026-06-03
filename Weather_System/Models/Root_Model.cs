using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_System.Models
{
    public class Root_Model
    {
        public string by { get; set; }
        public bool valid_key { get; set; }
        public Results_Model results { get; set; }
        public double execution_time { get; set; }
        public bool from_cache { get; set; }

    }
}
