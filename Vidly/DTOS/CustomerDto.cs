using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOS
{
    public class CustomerDto
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "enter customer name")]
        [StringLength(255)]
        public string name { get; set; }
        public bool IssusbscribedtoNewsletter { get; set; }
       
        public byte MembershipTypeId { get; set; }
        [Min18YofOld]
        public DateTime? birthdate { get; set; }
    }
}