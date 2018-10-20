using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Admin : Person
    {
        public int AdminID { get; set; }

        public bool isAdmin { get; set; }

        public List<Teacher> Teacher { get; set; }
    }
}
