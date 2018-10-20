using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Admin : Person
    {
        public int AdminID { get; set; }

        public Boolean isAdmin { get; set; }

       
        // Admin will have many cohorts
        // Many teachers 
        // many students
        public List<Cohort> Cohort { get; set; }
        public List<Student> Student { get; set; }
        public List<Teacher> Teacher { get; set; }


    }
}
