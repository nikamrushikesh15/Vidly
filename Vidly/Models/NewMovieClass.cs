﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NewMovieClass
    {
        public IEnumerable<Genr> genrs { get; set; }
        public Movie Movie { get; set; }
    }
}