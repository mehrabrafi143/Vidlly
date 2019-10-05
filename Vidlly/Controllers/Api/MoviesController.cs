using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using Vidlly.DTOs;
using Vidlly.Models;

namespace Vidlly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<MovieDTo> GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies.Include(c => c.Gener);

            if (!query.IsNullOrWhiteSpace())
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query) && m.AvailInStock > 0);

            return moviesQuery.ToList().Select(Mapper.Map<Movie, MovieDTo>);

        }

        public IHttpActionResult GetMovie(int id)
        {
            var single = _context.Movies.Include(g => g.Gener).Single(m => m.Id == id);
            if (single == null)
            {
                return NotFound();
            }

            var movie = Mapper.Map<Movie, MovieDTo>(single);

            return Ok(movie);
        }

        [HttpDelete]
        [Authorize(Roles = Roles.CanManageMovies)]
        public IHttpActionResult Delete(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Ok(movie);
        }
        

    }
}
