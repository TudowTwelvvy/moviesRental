using moviesRental.Models;
using System.Collections.Generic;

namespace moviesRental.ViewModels
{
    public class RondomMovieModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}