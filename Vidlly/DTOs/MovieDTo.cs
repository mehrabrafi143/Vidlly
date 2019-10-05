using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.DTOs
{
    public class MovieDTo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GenerId { get; set; }
        public DateTime DayOfAdded { get; set; }
        public DateTime PublishDate { get; set; }
        public GenerDTO Gener { get; set; }
        public byte NumberInStock { get; set; }
        public byte AvailInStock { get; set; }
    }
}