using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Genr
    {
 
        public int Id { get; set; }
        public string name { get; set; }
    }
}