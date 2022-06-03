using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Abstract
{
    public interface ITicketRepository:IRepository<Ticket>
    {
        int GetSeatNo(int id);
        List<int> GetSeat(int id);
        Ticket GetTicket(int prnNumber);
        Ticket GetLastTicket();
        string GetDate(int id);
        string GetHour(int id);
        double GetPrice(int id);
        int GetId();
    }
}
