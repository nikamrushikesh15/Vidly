using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class newcustomerviewmodel
    {

        public IEnumerable<MembershipType> membershipTypes { get; set; }
        public Customer customer { get; set;}

    }
}