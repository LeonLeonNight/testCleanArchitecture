using ApplicationCore.Entities.ContactAggregate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.UserAggregate
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        //public IList<Contact> Contacts { get; set; }
    }
}
