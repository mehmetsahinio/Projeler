using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Entity;
using SahinTurizim.WebUI.Models;
using Route = SahinTurizim.Entity.Route;

namespace SahinTurizim.WebUI.Controllers
{
    public class TicketController:Controller
    {
        private IRouteService _routeService;
        private ITicketService _ticketService;
        private IBusService _busService;

        public TicketController(IRouteService routeService, ITicketService ticketService, IBusService busService)
        {
            _routeService = routeService;
            _ticketService = ticketService;
            _busService = busService;
        }
        public IActionResult Details(int id)
        {
            Route route = _routeService.GetRouteDetails(id);
            int seatNumber = _ticketService.GeatSeatNo(id);
            List<int> takenSeat = _ticketService.GetSeat(id);
            List<int> seatNumbers = new List<int>();
            int seats = _busService.BusSeatCapacity(id / id);

            for (int i = 1; i <= seats; i++)
            {
                seatNumbers.Add(i);
            }

            foreach (var item in takenSeat)
            {
                seatNumbers.Remove(item);
            }

            ViewBag.SeatNumber = seatNumber;
            ViewBag.SeatNumbers = new SelectList(seatNumbers);

            return View(route);

        }

        [HttpPost]
        public IActionResult Details(int routeId, double price, string startTerminal, string endTerminal, int seatNo, string phoneNumber, string firstName, string lastName)
        {
            Random rnd = new Random();
            int PrnNumber = rnd.Next();
            var entity = new Ticket()
            {
                CustomerName = firstName,
                CustomerSurname = lastName,
                CustomerPhone = phoneNumber,
                CustomerTravel = startTerminal,
                CustomerToTravel = endTerminal,
                SeatNo = seatNo,
                Price = price,
                RouteId = routeId,
                PeronNumber = PrnNumber
            };

            _ticketService.Create(entity);
            return RedirectToAction("TicketDetails");
        }

        public IActionResult TicketDetails()
        {
            Ticket lastTicket = _ticketService.GetLastTicket();
            int routeId = _ticketService.GetId();
            string Hour = _ticketService.GetTime(routeId);
            string Date = _ticketService.GetDate(routeId);

            var routeTicket = new RouteTicket()
            {
                Date = Date,
                Hour = Hour,
                Ticket = lastTicket
            };
            return View(routeTicket);
        }

    }
}

