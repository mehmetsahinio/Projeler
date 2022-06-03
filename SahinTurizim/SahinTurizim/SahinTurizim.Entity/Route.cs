using System;
using System.Collections.Generic;

namespace SahinTurizim.Entity
{
    public class Route
    {
        public int RouteId { get; set; }
        public string StartTerminal { get; set; }
        public string FirstTerminal { get; set; }
        public string SecondTerminal { get; set; }
        public string ThirdTerminal { get; set; }
        public string EndTerminal { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public int Price { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
