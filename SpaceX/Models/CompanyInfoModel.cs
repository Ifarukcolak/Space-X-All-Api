using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class CompanyInfoModel
    {
        public string name { get; set; }
        public string founder { get; set; }
        public int founded { get; set; }
        public int employees { get; set; }
        public int vehicles { get; set; }
        public int launch_sites { get; set; }
        public int test_sites { get; set; }
        public string ceo { get; set; }
        public string cto { get; set; }
        public string coo { get; set; }
        public string cto_propulsion { get; set; }
        public long valuation { get; set; }
        public Headquarters headquarters { get; set; }
        public string summary { get; set; }
    }
    public class Headquarters
    {
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
}
