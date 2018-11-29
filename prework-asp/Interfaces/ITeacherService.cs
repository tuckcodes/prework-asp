using prework_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Interfaces
{
    interface ITeacherService
    {
        void GetSId(Teacher teacher);
        void GetsStudents();
        void GetsTclID();
    }
}
