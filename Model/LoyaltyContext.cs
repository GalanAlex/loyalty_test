using LoyaltyTest.Model;
using Microsoft.EntityFrameworkCore;

namespace LoyaltyTest.Models
{
    public class LoyaltyContext : DbContext
    {
        public LoyaltyContext(DbContextOptions<LoyaltyContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderTablePart> OrderTableParts { get; set; }
    }
}