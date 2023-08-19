using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Week4_codefirst.Models
{
    public class MvcUniContext : DbContext
    {
        public DbSet<Uni> Unis {get; set;}
    }
}