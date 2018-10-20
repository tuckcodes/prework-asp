using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class TeacherCohortLookup
    {
        //Junction table for teacher and cohort
        public List<Teacher> TeacherID { get; set; }
        public List<Cohort> CohortID { get; set; }
        public DateTime TeacherCohort { get; set; }
    }
}
