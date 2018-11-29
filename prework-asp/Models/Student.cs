using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Progress Progress { get; set; }
        public int CohortID { get; set; }
        public Cohort Cohort { get; set; }
    }
}
