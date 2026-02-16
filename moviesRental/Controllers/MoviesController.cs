using moviesRental.ViewModels;
using System.Web.Mvc;

namespace moviesRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = ;

            var viewModel = new RondomMovieModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }

        /*[Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);


        }*/
    }
}