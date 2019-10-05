using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PagedList;
using Vidlly.Models;

namespace Vidlly.ViewModels
{
    public class NoteViewModel
    {
        public IPagedList<Note> Notes { get; set; }
        public readonly int Pagesize = 5;
    }
}