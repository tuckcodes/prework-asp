using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Admin
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int AdminID { get; set; }

        public bool isAdmin { get; set; }

        public List<Teacher> Teacher { get; set; }
    }
}
