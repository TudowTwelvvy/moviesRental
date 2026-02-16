using System.Data.Entity;

namespace moviesRental.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Customer> Customers { get; set; }

    }
}