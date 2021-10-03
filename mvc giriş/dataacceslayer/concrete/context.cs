using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacceslayer.concrete
{
     public class context : DbContext
    {
        public DbSet<about> Abouts { get; set; }
        public DbSet<category> Categories { get; set; }
        public DbSet<contact> Contacts { get; set; }
        public DbSet<content> Contents { get; set; }
        public DbSet<heading> Headings { get; set; }
        public DbSet<writer> Writers { get; set; }

    }
}
