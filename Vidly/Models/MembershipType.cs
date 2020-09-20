using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        public short signupfee { get; set; }
        public byte DurationInmonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}