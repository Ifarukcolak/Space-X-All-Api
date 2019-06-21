using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class Height
    {
        public double meters { get; set; }
        public double feet { get; set; }
    }

    public class Mass
    {
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class PayloadWeight
    {
        public string id { get; set; }
        public string name { get; set; }
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class ThrustSeaLevel
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class ThrustVacuum
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class FirstStage1
    {
        public bool reusable { get; set; }
        public int engines { get; set; }
        public double fuel_amount_tons { get; set; }
        public int burn_time_sec { get; set; }
        public ThrustSeaLevel thrust_sea_level { get; set; }
        public ThrustVacuum thrust_vacuum { get; set; }
        public int? cores { get; set; }
    }

    public class Height2
    {
        public double? meters { get; set; }
        public double? feet { get; set; }
    }

    public class Diameter2
    {
        public double? meters { get; set; }
        public double? feet { get; set; }
    }

    public class CompositeFairing
    {
        public Height2 height { get; set; }
        public Diameter2 diameter { get; set; }
    }

    public class Payloads
    {
        public string option_1 { get; set; }
        public CompositeFairing composite_fairing { get; set; }
        public string option_2 { get; set; }
    }

    public class SecondStage1
    {
        public int engines { get; set; }
        public double fuel_amount_tons { get; set; }
        public int burn_time_sec { get; set; }
        public Thrust thrust { get; set; }
        public Payloads payloads { get; set; }
    }

    public class ThrustSeaLevel2
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class ThrustVacuum2
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class Engines
    {
        public int number { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public string layout { get; set; }
        public int? engine_loss_max { get; set; }
        public string propellant_1 { get; set; }
        public string propellant_2 { get; set; }
        public ThrustSeaLevel2 thrust_sea_level { get; set; }
        public ThrustVacuum2 thrust_vacuum { get; set; }
        public double? thrust_to_weight { get; set; }
    }

    public class LandingLegs
    {
        public int number { get; set; }
        public string material { get; set; }
    }

    public class RocketModel
    {
        public int id { get; set; }
        public bool active { get; set; }
        public int stages { get; set; }
        public int boosters { get; set; }
        public int cost_per_launch { get; set; }
        public int success_rate_pct { get; set; }
        public string first_flight { get; set; }
        public string country { get; set; }
        public string company { get; set; }
        public Height height { get; set; }
        public Diameter diameter { get; set; }
        public Mass mass { get; set; }
        public List<PayloadWeight> payload_weights { get; set; }
        public FirstStage1 first_stage { get; set; }
        public SecondStage1 second_stage { get; set; }
        public Engines engines { get; set; }
        public LandingLegs landing_legs { get; set; }
        public string wikipedia { get; set; }
        public string description { get; set; }
        public string rocket_id { get; set; }
        public string rocket_name { get; set; }
        public string rocket_type { get; set; }
    }
}
