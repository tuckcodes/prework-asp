using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Assignments
    {
        public int AssignmentID { get; set; }

        [Required]
        [Display(Name = "Project")]
        public string Project { get; set; }

        [Required]
        [Display(Name = "Starting Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Issues")]
        public string Issues { get; set; }
    }
}
