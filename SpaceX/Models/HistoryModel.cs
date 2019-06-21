using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX.Models
{
    public class HistoryModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime event_date_utc { get; set; }
        public int event_date_unix { get; set; }
        public int? flight_number { get; set; }
        public string details { get; set; }
        public Links links { get; set; }
    }
    public class Links
    {
        public string reddit { get; set; }
        public string article { get; set; }
        public string wikipedia { get; set; }
    }
}
