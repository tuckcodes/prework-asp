using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Cohort
    {
        public string CohortName { get; set; }

        public string Schedule { get; set; }

        public bool InProgres { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CohortID { get; set; }

    }
}
