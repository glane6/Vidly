using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Viewmodels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
       public List<Customer> customers = new List<Customer>
        {
            new Customer{Name = "Greg", Id=1},
            new Customer{Name = "Kristen", Id=2}
                

        };

      
        // GET: Customers
        public ActionResult Index()
        {
         RandomMovieViewModel viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };
            
            return View(viewModel);
            
        }

        public ActionResult Edit(int id)
        {
            var customer = customers.SingleOrDefault(e => e.Id == id);

            if(string.IsNullOrWhiteSpace(customer.Name))
            {
                return HttpNotFound();
            }

            return View(customer);


        }
    }
}