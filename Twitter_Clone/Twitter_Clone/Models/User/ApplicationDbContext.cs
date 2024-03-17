using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twitter_Clone.Models.User
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false) { }
    }
}