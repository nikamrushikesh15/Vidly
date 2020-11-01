using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.CustomerApi
{
    public class CustomerApiController : ApiController
    {

        private ApplicationDbContext _context;

        public CustomerApiController() {
            _context = new ApplicationDbContext();

        }
        //GET/API/Customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }
        public Customer getcustomer(int id) {
            var customer = _context.Customer.SingleOrDefault(c => c.ID == id);
            if (customer == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return customer;

        }
        /// <summary>
        /// api/customer/
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public Customer createcustomer(Customer customer) {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customer.Add(customer);
            _context.SaveChanges();

            return customer;
                    }
        //put /api.customer/1
        [HttpPut]
        public void updatecustomer(int id, Customer customer) {

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerinddb = _context.Customer.SingleOrDefault(c => c.ID == id);

                if (customerinddb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerinddb.name = customer.name;
            customerinddb.IssusbscribedtoNewsletter = customer.IssusbscribedtoNewsletter;
            customerinddb.MembershipTypeId = customer.MembershipTypeId;
            customerinddb.birthdate = customer.birthdate;

            _context.SaveChanges();








        }
        [HttpDelete]
        public void deletecustomer(int id,Customer customer) {



            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerinddb = _context.Customer.SingleOrDefault(c => c.ID == id);

            if (customerinddb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customer
                .Remove(customerinddb);
            _context.SaveChanges();

        }
        




    }
}
