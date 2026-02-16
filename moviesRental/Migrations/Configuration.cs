namespace moviesRental.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<moviesRental.DAL.MoviesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(moviesRental.DAL.MoviesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*var customers = new List<Customer>
            {
            new Customer {Id=1, Name = "Tumelo Khanye" },
            new Customer {Id=2, Name = "Thokozani Sibelo" },
            new Customer {Id=3, Name = "Boitumelo Mokoena" },
            };

            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
            }
            context.SaveChanges();

            var movies = new List<Movie>
            {
               new Movie { Id = 1, Name = "Shrek!" },
               new Movie { Id = 2, Name = "The Dark Knight" },
               new Movie { Id = 3, Name = "Inception" },
               new Movie { Id = 4, Name = "Avengers: Endgame" },
               new Movie { Id = 5, Name = "Titanic" }
             };

            foreach (var movie in movies)
            {
                context.Movies.Add(movie);
            }
            context.SaveChanges();*/
        }
    }
}
