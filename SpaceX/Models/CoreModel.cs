using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class CoreModel
    {
        public string core_serial { get; set; }
        public int block { get; set; }
        public string status { get; set; }
        public DateTime original_launch { get; set; }
        public int original_launch_unix { get; set; }
        public List<Mission> missions { get; set; }
        public int reuse_count { get; set; }
        public int rtls_attempts { get; set; }
        public int rtls_landings { get; set; }
        public int asds_attempts { get; set; }
        public int asds_landings { get; set; }
        public bool water_landing { get; set; }
        public string details { get; set; }
    }
}
