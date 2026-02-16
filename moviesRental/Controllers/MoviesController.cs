using moviesRental.DAL;
using System.Linq;
using System.Web.Mvc;

namespace moviesRental.Controllers
{
    public class MoviesController : Controller
    {

        private MoviesContext db = new MoviesContext();
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = db.Movies.ToList();




            return View(movies);
        }

        /*[Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);


        }*/
    }
}