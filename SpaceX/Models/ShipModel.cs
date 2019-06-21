using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class ShipModel
    {
        public string ship_id { get; set; }
        public string ship_name { get; set; }
        public object ship_model { get; set; }
        public string ship_type { get; set; }
        public List<string> roles { get; set; }
        public bool active { get; set; }
        public int? imo { get; set; }
        public int? mmsi { get; set; }
        public int? abs { get; set; }
        public int? @class { get; set; }
        public int? weight_lbs { get; set; }
        public int? weight_kg { get; set; }
        public int? year_built { get; set; }
        public string home_port { get; set; }
        public string status { get; set; }
        public int? speed_kn { get; set; }
        public object course_deg { get; set; }
        public Position position { get; set; }
        public object successful_landings { get; set; }
        public object attempted_landings { get; set; }
        public List<Mission> missions { get; set; }
        public string url { get; set; }
        public string image { get; set; }
    }

    public class Position
    {
        public double? latitude { get; set; }
        public double? longitude { get; set; }
    }
}
