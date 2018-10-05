using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    abstract class ITeacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TeacherCNMID { get; set; }



    }
}
