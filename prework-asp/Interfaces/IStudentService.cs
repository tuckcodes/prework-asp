using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prework_asp.Models;

namespace prework_asp.Interfaces
{
    interface IStudentService
    {
       void GetStudentId(Student student);
       void GetProgress();
       void GetCohorts();
    }
}
