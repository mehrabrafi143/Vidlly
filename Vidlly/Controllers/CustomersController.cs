using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Vidlly.DTOs;
using Vidlly.Models;
using Vidlly.ViewModels;

namespace Vidlly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers
        public ActionResult Index()
        {
            if (User.IsInRole(Roles.CanManageCustomer))
            {
                return View("List");    
            }

            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {            
            var customerInDb = _context.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                return new HttpNotFoundResult("Invalid request");
            }

            return View("CustomerDetail", customerInDb);
        }

        [Authorize(Roles = Roles.CanManageCustomer)]
        public ActionResult New(CustomersDto customersDto)
        {

            var customer = new Customer();

            if (customersDto.Id != 0)
            {
                customer = _context.Customers.SingleOrDefault(c => c.Id == customersDto.Id);
            }

            var model = new CustomerViewModel
            {
                MemberShipTypes = _context.MemberShipTypes.ToList(),
                Customer = customer
            };
            return View("CustomerForm",model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.CanManageCustomer)]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var model = new CustomerViewModel
                {
                    MemberShipTypes = _context.MemberShipTypes.ToList(),
                    Customer = customer
                };
                return View("CustomerForm", model);
            }


            if (customer.Id != 0)
            {
                var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);

                if (customerinDb == null ) 
                {
                    return new HttpNotFoundResult();
                }

                customerinDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerinDb.Birthdate = customer.Birthdate;
                customerinDb.Name = customer.Name;

                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        
    }
}