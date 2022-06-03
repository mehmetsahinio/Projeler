using System;
using System.Collections.Generic;

namespace SahinTurizim.Entity
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusPNR { get; set; }
        public int BusSeatCapacity { get; set; }
        public List<Route> Routes { get; set; }

    }
}
