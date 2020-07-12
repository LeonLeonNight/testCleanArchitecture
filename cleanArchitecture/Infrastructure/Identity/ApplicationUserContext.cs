using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.UserAggregate;

namespace Infrastructure.Identity
{
    public class ApplicationUserContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserContext(DbContextOptions<ApplicationUserContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }   
    }
}
