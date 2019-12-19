using Identityproject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identityproject.Controllers
{
    public class CreateRole
    {
        public void Createrole()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if(!rolemanager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                rolemanager.Create(role);
            }
        }
    }
}