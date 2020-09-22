using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string Genre { get; set; }
        public DateTime Date_Added { get; set; }
        public int stock { get; set; }
    }
}