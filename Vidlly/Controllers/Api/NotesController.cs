using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidlly.Models;

namespace Vidlly.Controllers.Api
{
    public class NotesController : ApiController
    {
        public ApplicationDbContext _context { get; set; }

        public NotesController()
        {
            _context = new ApplicationDbContext();
        }


        [System.Web.Http.HttpGet]
        public IList<Note> GetNotes(string id)
        {
            var note = _context.Notes.Where(n => n.UserId == id).ToList();
            return note;
        }


        
        [HttpPost]
        public IHttpActionResult Add(Note note)
        {
            if (note == null)
            {
                return BadRequest();
            }
                _context.Notes.Add(note);
                _context.SaveChanges();
            
            return Ok(note);
        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {

            var note = _context.Notes.Single(n => n.Id == id);

            if (note == null)
            {
                return BadRequest();
            }
                _context.Notes.Remove(note);
                _context.SaveChanges();
            
            return Ok(note);
        }

        [HttpPut]
        public IHttpActionResult Update(int id,Note noteFromClient)
        {

            var note = _context.Notes.Single(n => n.Id == id);
            


            note.Description = noteFromClient.Description;
            note.Title = noteFromClient.Title;
            _context.SaveChanges();

            return Ok(note);
        }


    }
}
