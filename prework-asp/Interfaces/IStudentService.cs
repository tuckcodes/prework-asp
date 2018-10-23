using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prework_asp.Models;

namespace prework_asp.Interfaces
{
    interface IStudentService
    {
       void GetSId(Student student);
       void GetProg();
       void GetCohorts();
    }
}
