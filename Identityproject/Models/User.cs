using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identityproject.Models
{
    public class User
    {
        public Guid id { get; set; }

        public string UniversityName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string StreetAddress { get; set; }

        public string Country { get; set; }
    }
}