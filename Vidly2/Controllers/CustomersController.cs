using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customerList = GetCustomers();

            RandomMovieViewModel viewModel = new RandomMovieViewModel
            {
                Customers = customerList,
                Movie = new Movie { Id = 1, Name = "Shrek" }
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            List<Customer> customerList = GetCustomers();

            if (id == 1)
            {
                return View(customerList[0]);
            }
            else if(id==2)
            {
                return View(customerList[1]);
            }
            else
            {
                return HttpNotFound();
            }
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id=1, Name="Narendra Karmalkar" },
                new Customer {Id=2, Name="Ameya Karmalkar" }
            };
        }
    }
}