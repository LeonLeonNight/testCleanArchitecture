using ApplicationCore.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.ContactAggregate
{
    public class Contact : BaseEntity
    {        
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public IList<ApplicationUser> Users { get; set; }
    }
}
