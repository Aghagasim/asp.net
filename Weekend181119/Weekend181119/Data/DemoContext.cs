using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Weekend181119.Models;
using System.Data.Entity;

namespace Weekend181119.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("DemoContext")
        {
        }

        public DbSet<ContactForm> ContactForms {get; set;}
        public DbSet<SamplePost> SamplePosts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SosialLinks> SosialLinks { get; set; }
    }
}
