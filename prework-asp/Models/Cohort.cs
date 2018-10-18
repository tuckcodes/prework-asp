using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Cohort 
    {
        public int CohortID { get; set; }
        [Required]
        [Display(Name = "Chohort Name")]
        public string CohortName { get; set; }
        [Required]
        [Display(Name = "Schedule")]
        public string Schedule { get; set; }
        public bool InProgress { get; set; }
        [Required]
        [Display(Name = "Started Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "Ending Date")]
        public DateTime EndDate { get; set; }

        // Cohort will have many teacher
        // Cohort will have many students
        public List<Teacher> Teacher { get; set; }
        public List<Student> Student { get; set; }
    }
}
