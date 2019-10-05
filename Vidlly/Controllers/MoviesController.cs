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
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ActionResult Index()
        {
            if (User.IsInRole(Roles.CanManageMovies))
            {
                return View("List");
            }

            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Gener).SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return new HttpNotFoundResult("not fund");
            }

            var moviedto = Mapper.Map<Movie, MovieDTo>(movie);

            return View(moviedto);
        }


        [Authorize(Roles = Roles.CanManageMovies)]
        public ActionResult New()
        {

            var model = new MovieViewModel
            {
                Geners = _context.Geners.ToList()
            };

            return View("MovieFormView",model);
        }


        [Authorize(Roles = Roles.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(m => m.Gener).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return new HttpNotFoundResult("not fund");
            }
            var model = new MovieViewModel
            {
                Id = movie.Id,
                NumberInStock = movie.NumberInStock,
                AvailInStock = movie.AvailInStock,
                Name = movie.Name,
                DayOfAdded = movie.DayOfAdded,
                PublishDate = movie.PublishDate,
                GenerId = movie.GenerId,
                Geners = _context.Geners.ToList()
            };

            return View("MovieFormView", model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.CanManageMovies)]
        public ActionResult Save(MovieDTo movieDTo)
        {

            if (!ModelState.IsValid)
            {
                var model = new MovieViewModel
                {
                    Id = movieDTo.Id,
                    DayOfAdded = movieDTo.DayOfAdded,
                    PublishDate = movieDTo.PublishDate,
                    NumberInStock = movieDTo.NumberInStock,
                    AvailInStock = movieDTo.AvailInStock,
                    Geners = _context.Geners.ToList()
                };

                return View("MovieFormView", model);
            }
            
            if (movieDTo.Id != 0)
            {
                var movieindb = _context.Movies.Single(m => m.Id == movieDTo.Id);

                movieindb.Name = movieDTo.Name;
                movieindb.GenerId = movieDTo.GenerId;
                movieindb.NumberInStock = movieDTo.NumberInStock;
                movieindb.PublishDate = movieDTo.PublishDate;

                _context.SaveChanges();
                return RedirectToAction("Index");
            }



            movieDTo.DayOfAdded = DateTime.Today;
            movieDTo.AvailInStock = movieDTo.NumberInStock;
            var movie = Mapper.Map<MovieDTo, Movie>(movieDTo);

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}