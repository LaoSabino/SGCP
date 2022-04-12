using Microsoft.EntityFrameworkCore;
using SGCP.Core;

namespace SGCP.Data
{
    public class SGCPContext : DbContext
    {
        protected SGCPContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}