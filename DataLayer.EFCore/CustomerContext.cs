using CustomerDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerDetails.DataLayer.EFCore
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}