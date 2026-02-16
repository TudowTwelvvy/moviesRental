using moviesRental.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace moviesRental.DAL
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("MoviesContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}