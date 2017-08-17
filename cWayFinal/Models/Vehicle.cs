using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cWayFinal.Models
{
    public class Vehicle : DbContext
    {
        public Vehicle() : base("name=DefaultConnection")
        {
        }
        
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}