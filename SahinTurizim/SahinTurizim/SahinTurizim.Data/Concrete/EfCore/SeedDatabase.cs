using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
            public static void Seed()
            {
                var context = new SahinTurizimContext();

                if (context.Database.GetPendingMigrations().Count() == 0)
                {
                    if (context.Cities.Count() == 0)
                    {
                        context.Cities.AddRange(Cities);
                    }
                    if (context.Buses.Count() == 0)
                    {
                        context.Buses.AddRange(Buses);
                    }
                    if (context.Routes.Count() == 0)
                    {
                        context.Routes.AddRange(Routes);
                    }
                    if (context.Tickets.Count() == 0)
                    {
                        context.Tickets.AddRange(Tickets);
                    }
                    context.SaveChanges();
                }
            }

        private static City[] Cities =
        {
            new City() { CityName = "İstanbul" },
            new City() { CityName = "Kocaeli" },
            new City() { CityName = "Kütahya" },
            new City() { CityName = "Afyon" },
            new City() { CityName = "Isparta" },
            new City() { CityName = "Samsun" },
            new City() { CityName = "Ordu" },
            new City() { CityName = "Rize" },
            new City() { CityName = "Tokat" },
            new City() { CityName = "Adana" }
        };

        private static Bus[] Buses =
        {
            new Bus() { BusSeatCapacity = 20 }
        };

        private static Route[] Routes =
        {
            new Route() { StartTerminal = "İstanbul", FirstTerminal = "Kocaeli", SecondTerminal = "Kütahya", ThirdTerminal = "Afyon", EndTerminal = "Isparta", Date = "15.06.2022", Hour = "19.00", Price = 110 },
            new Route() { StartTerminal = "Rize", FirstTerminal = "Ordu", SecondTerminal = "Samsun", ThirdTerminal = "Kocaeli", EndTerminal = "İstanbul", Date = "16.06.2022", Hour = "19.00", Price = 180 }
        };

        private static Ticket[] Tickets =
        {
            new Ticket() { CustomerName = "Ahmet", CustomerSurname = "ÖZTÜRK", CustomerPhone = "+905315076460", CustomerTravel = "İstanbul", SeatNo = 11, Price=300, PeronNumber= 5554752, RouteId = 1}
        };
    }
}
