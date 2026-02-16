using moviesRental.Models;
using System.Collections.Generic;

namespace moviesRental.DAL
{
    public class MoviesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MoviesContext>
    {

        protected override void Seed(MoviesContext context)
        {
            var customers = new List<Customer>
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
            context.SaveChanges();

        }
    }
}