using moviesRental.Models;
using moviesRental.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace moviesRental.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> Customers = new List<Customer>
        {
            new Customer {Id=1, Name = "Tumelo Khanye" },
            new Customer {Id=2, Name = "Thokozani Sibelo" },
            new Customer {Id=3, Name = "Boitumelo Mokoena" },
        };

        // GET: Customers/AllCustomers
        public ActionResult Index()
        {

            var viewModel = new CustomersViewModel
            {
                Customers = this.Customers
            };

            return View(viewModel);
        }


        // GET: Customers/Details/{id}
        public ActionResult Details(int id)
        {


            foreach (var customer in this.Customers)
            {
                if (customer.Id == id)
                {
                    var viewModel = new CustomerViewModel
                    {
                        Customer = customer
                    };

                    return View(viewModel);
                }

            }
            return Content("No Customer Found");


        }
    }
}