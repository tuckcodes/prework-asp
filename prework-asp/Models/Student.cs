using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Student : Person
    {

        public int StudentID { get; set; }

        public int ProgressID { get; set; }

        public string Cohort { get; set; }

        

        // Student will have 1 teacher
        // Student will have 1 progress 
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int ProgressId { get; set; }
        public Progress Progress { get; set; }
    }
}
