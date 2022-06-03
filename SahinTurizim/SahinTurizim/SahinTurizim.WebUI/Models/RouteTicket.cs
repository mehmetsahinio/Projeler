using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.WebUI.Models
{
    public class RouteTicket
    {

        public List<Ticket> Tickets { get; set; }
        public List<Route> Routes { get; set; }
        public List<City> Cities { get; set; }
        public Route NewRoute { get; set; }
        public string Hour { get; set; }
        public string Date { get; set; }
        public Ticket Ticket { get; set; }
    }
}
