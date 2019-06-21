using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class PayloadModel
    {
        public string payload_id { get; set; }
        public List<object> norad_id { get; set; }
        public bool reused { get; set; }
        public List<string> customers { get; set; }
        public string nationality { get; set; }
        public string manufacturer { get; set; }
        public string payload_type { get; set; }
        public int? payload_mass_kg { get; set; }
        public int? payload_mass_lbs { get; set; }
        public string orbit { get; set; }
        public OrbitParams1 orbit_params { get; set; }
    }
    public class OrbitParams1
    {
        public string reference_system { get; set; }
        public string regime { get; set; }
        public object longitude { get; set; }
        public object semi_major_axis_km { get; set; }
        public object eccentricity { get; set; }
        public int? periapsis_km { get; set; }
        public int? apoapsis_km { get; set; }
        public int? inclination_deg { get; set; }
        public object period_min { get; set; }
        public object lifespan_years { get; set; }
    }
}
