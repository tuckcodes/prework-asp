using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Student : Person
    {

        public int StudentID { get; set; }
        // Student will have 1 teacher
        // Student will have 1 progress 
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Progress Progress { get; set; }

        public int CohortID { get; set; }
        public Cohort Cohort { get; set; }
    }
}
