using ApplicationCore.Entities.ContactAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options) 
        { 
            Database.EnsureCreated(); 
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
