using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    abstract class IStudent
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Cohort { get; set; }
    }
}
