using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class MissionModel
    {
        public string mission_name { get; set; }
        public string mission_id { get; set; }
        public List<string> manufacturers { get; set; }
        public List<string> payload_ids { get; set; }
        public string wikipedia { get; set; }
        public string website { get; set; }
        public string twitter { get; set; }
        public string description { get; set; }
    }
}
