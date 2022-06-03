using System;
using System.Collections.Generic;
using System.Linq;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket, SahinTurizimContext>, ITicketRepository
    {
        public string GetDate(int id)
        {
            using (var context = new SahinTurizimContext())
            {
                var ticketDate = context
                    .Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.Date)
                    .FirstOrDefault();

                return ticketDate;
            }
        }

        public string GetHour(int id)
            {
                using (var context = new SahinTurizimContext())
                {
                    var ticketTime = context.Routes
                        .Where(i => i.RouteId == id)
                        .Select(i => i.Hour)
                        .FirstOrDefault();

                    return ticketTime;
                }
            }

        public int GetId()
        {
            using (var context = new SahinTurizimContext())
            {
                var id = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .Select(i => i.RouteId)
                    .FirstOrDefault();
                return id;
            }
        }

        public Ticket GetLastTicket()
        {
              using (var context = new SahinTurizimContext())
              {
                var lastTicket = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .FirstOrDefault();
                return lastTicket;
              }
        }

        public double GetPrice(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> GetSeat(int id)
        {
            using (var context = new SahinTurizimContext())
            {
                var seat = context.Tickets
                    .Where(i => i.RouteId == id)
                    .Select(i => i.SeatNo)
                    .ToList();

                return seat;
            }
        }

        public int GetSeatNo(int id)
        {
            using (var context = new SahinTurizimContext())
            {
                return context.Tickets
                    .Where(i => i.RouteId == id)
                    .Select(i => i.SeatNo)
                    .Count();
            }
        }

            public Ticket GetTicket(int prnNumber)
            {
               using (var context = new SahinTurizimContext())
               {
                var ticket = context
                    .Tickets
                    .Where(i => i.PeronNumber == prnNumber)
                    .FirstOrDefault();

                return ticket;
               }
            }

           
    }
}
