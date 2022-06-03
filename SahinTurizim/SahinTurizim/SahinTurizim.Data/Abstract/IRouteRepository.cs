using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Abstract
{
    public interface IRouteRepository:IRepository<Route>
    {
        string GetByFristCity(string fristCity);
        string GetByEndCity(string endCity);
        List<Route> GetRoute(string startTerminal, string endTerminal, DateTime Date);
        Route GetRouteDetails(int id);
    }
}
