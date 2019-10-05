using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using Vidlly.DTOs;
using Vidlly.Models;

namespace Vidlly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }



        public IList<Rental> GetRentals()
        {
            return _context.Rentals.ToList();
        }

        [HttpPost]
        public IHttpActionResult Add(NewRentalDto newRentalDto)
        {
            var customer = _context.Customers.Single(c => c.Id == newRentalDto.CustomerId);
            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();
            foreach (var movie in movies)
            {

                if (movie.AvailInStock == 0 )
                    return BadRequest("the movie is not available!");
                    
                var newRetal = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Today
                };
                _context.Rentals.Add(newRetal);
                movie.AvailInStock--;
            }
            _context.SaveChanges();

            return Ok("Posted");

        }





    }
}
