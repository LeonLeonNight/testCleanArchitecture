using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.ContactAggregate
{
    class Contact : BaseEntity
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}
