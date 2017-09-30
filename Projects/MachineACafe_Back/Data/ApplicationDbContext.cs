using Domain.Entities;
using System.Data.Entity;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<CoffeOrder> CoffeOrders { get; set; }

    }
}
