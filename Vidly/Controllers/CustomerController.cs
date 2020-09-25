using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;



        public CustomerController() {

            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    //Dispose(disposing);
        }

        public ViewResult Index()
        {
            var customers = _context.Customer.Include(c=>c.MembershipType).ToList();

            return View(customers);
        }
        public ActionResult New() {

            var membershiptype = _context.membershipTypes.ToList();
            var viewmodel = new newcustomerviewmodel {

                membershipTypes = membershiptype
        };
            return View(viewmodel);
        }

        public ActionResult Detail(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.ID == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { ID = 1, name = "John Smith" },
                new Customer { ID = 2, name = "Mary Williams" }
            };
        }
    }
}