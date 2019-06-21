using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class LandingPadModel
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string status { get; set; }
        public Location location { get; set; }
        public string landing_type { get; set; }
        public int attempted_landings { get; set; }
        public int successful_landings { get; set; }
        public string wikipedia { get; set; }
        public string details { get; set; }
    }
    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
