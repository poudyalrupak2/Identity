using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Identityproject.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext():base("DefaultConnection")
            {

        }
        public DbSet<User> users { get; set; }
    }
}