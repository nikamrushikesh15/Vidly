﻿using System;
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

        [HttpPost]
        public ActionResult create(Customer customer)
        {
            if (!ModelState.IsValid) {

                var viewmodel = new newcustomerviewmodel
                {
                    customer = customer,
                    membershipTypes = _context.membershipTypes.ToList()
               

                };
                return View("New", viewmodel);
            }


            if (customer.ID == 0)
            {
                _context.Customer.Add(customer);


            }
            else
            {
                var customerInDb = _context.Customer.Single(c => c.ID == customer.ID);
                customerInDb.name = customer.name;
                customerInDb.birthdate = customer.birthdate;
                customerInDb.IssusbscribedtoNewsletter = customer.IssusbscribedtoNewsletter;
                customerInDb.MembershipTypeId = customer
                    .MembershipTypeId;


            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
          //  return View();

        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            var viewmodel = new newcustomerviewmodel()
            {
                customer = customer,
                membershipTypes = _context.membershipTypes.ToList()



        };
            return View("New",viewmodel);
        }
        public ActionResult Detail(int id)
        {
            var memenership = _context.membershipTypes;
            var customer = _context.Customer.Include(c => c.MembershipType).SingleOrDefault(c => c.ID == id);


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