using SahinTurizim.Entity;
using System;

using Microsoft.EntityFrameworkCore;
namespace SahinTurizim.Data.Concrete.EfCore
{
    public class SahinTurizimContext:DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<City> Cities{ get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet <Ticket> Tickets{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= SahinTurizimDb");

        }
      
       
    }
}
