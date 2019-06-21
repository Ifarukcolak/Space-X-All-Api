using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class LaunchPadModel
    {
        public int id { get; set; }
        public string status { get; set; }
        public Location location { get; set; }
        public List<string> vehicles_launched { get; set; }
        public int attempted_launches { get; set; }
        public int successful_launches { get; set; }
        public string wikipedia { get; set; }
        public string details { get; set; }
        public string site_id { get; set; }
        public string site_name_long { get; set; }
    }
}
