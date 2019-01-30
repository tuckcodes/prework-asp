using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Interfaces
{
    interface IProgressRepository
    {
         bool IsCompleted(string studentId);
         double calculateProgress(); 
    }
}
