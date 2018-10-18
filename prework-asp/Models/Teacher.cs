using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Teacher : Person, IPerson
    {

        public int TeacherID { get; set; }

        public Boolean isTeacher { get; set; }

        public string GetAddress()
        {
            throw new NotImplementedException();
        }

        public string GetCity()
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateOfBirth()
        {
            throw new NotImplementedException();
        }

        public string GetEmailAddress()
        {
            throw new NotImplementedException();
        }

        public string GetFirstName()
        {
            throw new NotImplementedException();
        }

        public string GetLastName()
        {
            throw new NotImplementedException();
        }

        public string GetPhoneNumber()
        {
            throw new NotImplementedException();
        }

        public string GetState()
        {
            throw new NotImplementedException();
        }

        // Teacher will have many students
        // Teacher will have many progresses
        // Teacher will have 1 admin 
        public List<Student> Student { get; set; }
        public List<Progress> Progress { get; set; }
    }
}
