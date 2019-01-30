using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Progress
    {
        public int ProgressID { get; set; }

        [Required]
        [Display(Name = "Starting Date")]
        public DateTime StartedOn { get; set; }
        [Required]
        [Display(Name = "Task 1")]
        public int PreworkTask1 { get; set; }
        [Required]
        [Display(Name = "Task 2")]
        public int PreworkTask2 { get; set; }
        [Required]
        [Display(Name = "Task 3")]
        public int PreworkTask3 { get; set; }
        [Required]
        [Display(Name = "Task 4")]
        public int PreworkTask4 { get; set; }
        [Required]
        [Display(Name = "Task 5")]
        public int PreworkTask5 { get; set; }
        [Required]
        [Display(Name = "Completed Total")]
        public int CompletedAmount { get; set; }
        public bool Alert { get; set; }
        [Required]
        [Display(Name = "Finished")]
        public bool Finished { get; set; }

        // Progress will have many students
        public int StudentID { get; set; }
        public Student Student { get; set; }

        public List<Assignments> Assignment { get; set; }
    }
}
