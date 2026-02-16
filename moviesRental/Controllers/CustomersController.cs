using moviesRental.DAL;
using System.Linq;
using System.Web.Mvc;

namespace moviesRental.Controllers
{
    public class CustomersController : Controller
    {
        /* public List<Customer> Customers = new List<Customer>
         {
             new Customer {Id=1, Name = "Tumelo Khanye" },
             new Customer {Id=2, Name = "Thokozani Sibelo" },
             new Customer {Id=3, Name = "Boitumelo Mokoena" },
         };*/

        private MoviesContext _dbContext;

        public CustomersController()
        {
            _dbContext = new MoviesContext();
        }

        // GET: Customers/AllCustomers
        public ActionResult Index()
        {

            /*var viewModel = new CustomersViewModel
            {
                Customers = db.Customers.ToList()
            };*/
            var customers = _dbContext.Customers.ToList();

            return View(customers);
        }


        // GET: Customers/Details/{id}
        public ActionResult Details(int id)
        {

            var customers = _dbContext.Customers.ToList();

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {

                    return View(customer);
                }

            }
            return HttpNotFound();


        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}