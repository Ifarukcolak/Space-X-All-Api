using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class CapsuleModel
    {
        public string capsule_serial { get; set; }
        public string capsule_id { get; set; }
        public string status { get; set; }
        public DateTime? original_launch { get; set; }
        public int? original_launch_unix { get; set; }
        public List<Mission> missions { get; set; }
        public int landings { get; set; }
        public string type { get; set; }
        public object details { get; set; }
        public int reuse_count { get; set; }
    }

    public class Mission
    {
        public string name { get; set; }
        public int flight { get; set; }
    }



}
