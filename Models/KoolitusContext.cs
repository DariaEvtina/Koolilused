using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Koolilused.Models
{
    public class KoolitusContext:DbContext
    {
        public DbSet<Koolitus> Koolituss { get; set; }
        public DbSet<Laps> Lapss { get; set; }
        public DbSet<Opetaja> Opetajas { get; set; }
    }
}