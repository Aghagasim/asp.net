using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weekend181119.Models
{
    public class SosialLinks
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
    }
}
