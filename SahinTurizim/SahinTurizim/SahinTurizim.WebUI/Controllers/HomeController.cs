using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Entity;
using SahinTurizim.WebUI.Models;

namespace SahinTurizim.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICityService _cityService;
        private IRouteService _routeService;
        private ITicketService _ticketService;

        public HomeController(ICityService cityService, IRouteService routeService, ITicketService ticketService)
        {
            _cityService = cityService;
            _routeService = routeService;
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {

            return View();

        }

        public IActionResult Search(int PeronNumber)
        {
            PeronNumber = Convert.ToInt32(PeronNumber);
            int routeId = _ticketService.GetId();
            string Hour = _ticketService.GetTime(routeId);
            string Date = _ticketService.GetDate(routeId);
            Ticket ticket = _ticketService.GetTicket(PeronNumber);
            var routeTicket = new RouteTicket()
            {
                Date = Date,
                Hour = Hour,
                Ticket = ticket
            };
            return View(routeTicket);
        }
    }
}