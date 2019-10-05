using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AutoMapper;
using Vidlly.DTOs;
using Vidlly.Models;
using System.Data.Entity;
using System.Web.Http.Results;
using Microsoft.Ajax.Utilities;

namespace Vidlly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<CustomersDto> GetCustomers(string query = null)
        {
             var customersQuery = _context.Customers.Include(c => c.MemberShipType);

             if (!query.IsNullOrWhiteSpace())
                  customersQuery = customersQuery.Where(c => c.Name.Contains(query));
             
                 
                 return customersQuery.ToList().Select(Mapper.Map<Customer, CustomersDto>);
        }

        public IHttpActionResult GetCustomer(int id)
        {
            var customerInDb = _context.Customers.Single(c => c.Id == id);
            if (customerInDb == null)
            {
                return NotFound();
            }

            var customer = Mapper.Map<Customer, CustomersDto>(customerInDb);
            return Ok(customer);

        }

        [Authorize(Roles = Roles.CanManageCustomer)]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var customer = _context.Customers.Single(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

    }
}
