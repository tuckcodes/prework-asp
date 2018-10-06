using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Progress
    {
        public DateTime StartedOn { get; set; }
        public int PreworkTask1 { get; set; }
        public int PreworkTask2 { get; set; }
        public int PreworkTask3 { get; set; }
        public int PreworkTask4 { get; set; }
        public int PreworkTask5 { get; set; }
        public int CompletedAmount { get; set; }
        public Boolean Alert { get; set; }
        public Boolean Finished { get; set; }
    }
}
