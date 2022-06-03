using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class EfCoreRouteRepository : EfCoreGenericRepository<Route, SahinTurizimContext>, IRouteRepository
    {
        public string GetByEndCity(string endCity)
        {
            using (var context=new SahinTurizimContext())
            {
                var end = context.Cities.Where(i => i.CityId == Convert.ToInt32(endCity)).Select(i => i.CityName).ToList();
                return end[0];
            }
        }



        public string GetByFristCity(string startTerminal)
        {
            using (var context = new SahinTurizimContext())
            {
                var start = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(startTerminal))
                    .Select(i => i.CityName)
                    .ToList();
                return start[0];
            }
        }

        public List<Route> GetRoute(string startTerminal, string endTerminal, DateTime Date)
        {

            string dateTimeLocal = Date.ToString("yyyy-MM-dd");
            using (var context = new SahinTurizimContext())
            {
                var start = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(startTerminal))
                    .Select(i => i.CityName)
                    .ToList();

                var end = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(endTerminal))
                    .Select(i => i.CityName)
                    .ToList();

                var routes = context.Routes
                    .FromSqlRaw($"Select * From Routes Where ((StartTerminal='{start[0]}' or FirstTerminal='{start[0]}' or SecondTerminal='{start[0]}' or ThirdTerminal='{start[0]}' ) and (EndTerminal='{end[0]}' or ThirdTerminal='{end[0]}' or SecondTerminal='{end[0]}' or FirstTerminal='{end[0]}' ) and Date='{dateTimeLocal}') ")
                    .ToList();

                return routes;
            }
        }

        public Route GetRouteDetails(int id)
        {
            using (var context = new SahinTurizimContext())
            {
                return context.Routes
                    .Where(i => i.RouteId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }
    }
}
