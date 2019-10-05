using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PagedList;
using Vidlly.Models;
using Vidlly.ViewModels;

namespace Vidlly.Controllers
{
    public class NotesController : Controller
    {

        private ApplicationDbContext _context;


        public NotesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Notes
        public ActionResult Index(int? page)
        {

            var userid = User.Identity.GetUserId();

            var model = new NoteViewModel
            {
                Notes = _context.Notes
                    .Where(n => n.UserId == userid)
                    .ToList().ToPagedList(page?? 1,5)
            };

            return View(model);
        }
    }
}