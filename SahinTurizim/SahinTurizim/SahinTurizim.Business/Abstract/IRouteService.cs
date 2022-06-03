using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Abstract
{
    public interface IRouteService
    {
        Route GetById(int id);
        void Create(Route entity);
        void Update(Route entity);
        void Delete(Route entity);

        List<Route> GetAll();

        List<Route> GetRoute(string startLocation, string endLocation, DateTime dateTime);
        string GetEndLocation(string endLocation);
        string GetStartLocation(string startLocation);
        Route GetRouteDetails(int id); 
    }
}
