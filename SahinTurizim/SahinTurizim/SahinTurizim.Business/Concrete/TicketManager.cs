using System;
using System.Collections.Generic;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;
        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        

        public void Create(Ticket entity)
        {
            _ticketRepository.Create(entity);

         }

        public void Delete(Ticket entity)
        {
            _ticketRepository.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public string GetDate(int id)
        {
            return _ticketRepository.GetDate(id);
        }

        public int GetId()
        {
            return _ticketRepository.GetId();
        }

        public Ticket GetLastTicket()
        {
            return _ticketRepository.GetLastTicket();
        }

        public List<int> GetSeat(int routeId)
        {
            return _ticketRepository.GetSeat(routeId);
        }

        public int GeatSeatNo(int routeId)
        {
            return _ticketRepository.GetSeatNo(routeId);
        }

        public Ticket GetTicket(int PrnNumber)
        {
            return _ticketRepository.GetTicket(PrnNumber);
        }

        public string GetTime(int id)
        {
            return _ticketRepository.GetHour(id);
        }

        public void Update(Ticket entity)
        {
             _ticketRepository.Update(entity);
        }
    }
}
