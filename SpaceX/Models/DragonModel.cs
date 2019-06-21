using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class DragonModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool active { get; set; }
        public int crew_capacity { get; set; }
        public int sidewall_angle_deg { get; set; }
        public int orbit_duration_yr { get; set; }
        public int dry_mass_kg { get; set; }
        public int dry_mass_lb { get; set; }
        public string first_flight { get; set; }
        public HeatShield heat_shield { get; set; }
        public List<Thruster> thrusters { get; set; }
        public LaunchPayloadMass launch_payload_mass { get; set; }
        public LaunchPayloadVol launch_payload_vol { get; set; }
        public ReturnPayloadMass return_payload_mass { get; set; }
        public ReturnPayloadVol return_payload_vol { get; set; }
        public PressurizedCapsule pressurized_capsule { get; set; }
        public Trunk trunk { get; set; }
        public HeightWTrunk height_w_trunk { get; set; }
        public Diameter diameter { get; set; }
        public string wikipedia { get; set; }
        public string description { get; set; }
    }
    public class HeatShield
    {
        public string material { get; set; }
        public double size_meters { get; set; }
        public int temp_degrees { get; set; }
        public string dev_partner { get; set; }
    }

    public class Thrust
    {
        public double kN { get; set; }
        public int lbf { get; set; }
    }

    public class Thruster
    {
        public string type { get; set; }
        public int amount { get; set; }
        public int pods { get; set; }
        public string fuel_1 { get; set; }
        public string fuel_2 { get; set; }
        public Thrust thrust { get; set; }
    }

    public class LaunchPayloadMass
    {
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class LaunchPayloadVol
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class ReturnPayloadMass
    {
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class ReturnPayloadVol
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class PayloadVolume
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class PressurizedCapsule
    {
        public PayloadVolume payload_volume { get; set; }
    }

    public class TrunkVolume
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class Cargo
    {
        public int solar_array { get; set; }
        public bool unpressurized_cargo { get; set; }
    }

    public class Trunk
    {
        public TrunkVolume trunk_volume { get; set; }
        public Cargo cargo { get; set; }
    }

    public class HeightWTrunk
    {
        public double meters { get; set; }
        public double feet { get; set; }
    }

    public class Diameter
    {
        public double meters { get; set; }
        public int feet { get; set; }
    }
}
