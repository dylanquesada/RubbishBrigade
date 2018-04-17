using System;
using System.Data.Entity;
namespace RubbishBrigade.Models
{
    public class Pickup
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public DateTime PickupDate { get; set; }
        public decimal Price { get; set; }
    }
    public class PickupDBContext : DbContext
    {
        public DbSet<Pickup> Pickups { get; set; }
    }
}