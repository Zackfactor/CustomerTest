using CustomerTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer>? Customers { get; set; }
    }
}
