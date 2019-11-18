using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weekend181119.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Navbar { get; set; }
        public string ContactText { get; set; }
        public ICollection<SosialLinks>  SosialLinks { get; set; }
    }
}