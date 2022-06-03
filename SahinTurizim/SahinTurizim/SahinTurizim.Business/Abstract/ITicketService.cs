using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Abstract
{
    public interface ITicketService
    {
        Ticket GetById(int id);
        void Create(Ticket entity);
        void Update(Ticket entity);
        void Delete(Ticket entity);
        List<Ticket> GetAll();

        int GeatSeatNo(int routeId);
        List<int> GetSeat(int routeId);
        Ticket GetLastTicket();
        Ticket GetTicket(int PrnNumber);
        int GetId();
        string GetDate(int id);
        string GetTime(int id);
    }
}

