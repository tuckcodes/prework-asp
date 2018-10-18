using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Student : Person, IPerson
    {

        public int StudentID { get; set; }

        public int ProgressID { get; set; }

        public string Cohort { get; set; }

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

        // Student will have 1 teacher
        // Student will have 1 progress 
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int ProgressId { get; set; }
        public Progress Progress { get; set; }
    }
}
