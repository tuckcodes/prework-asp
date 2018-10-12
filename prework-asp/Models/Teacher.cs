using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Teacher : IPerson
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
    }
}
