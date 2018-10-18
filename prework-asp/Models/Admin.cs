using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Admin : IPerson
    {
        public int AdminID { get; set; }

        public Boolean isAdmin { get; set; }

        string IPerson.GetFirstName()
        {
            string name = "";
            return name;
        }

        string IPerson.GetLastName()
        {
            return "Last Name";
        }

        string IPerson.GetAddress()
        {
            return "Address";
        }

        string IPerson.GetCity()
        {
            return "City";
        }

        string IPerson.GetState()
        {
            return "State";
        }

        string IPerson.GetPhoneNumber()
        {
            return "Phone Number";
        }

        string IPerson.GetEmailAddress()
        {
            return "Email Address";
        }

        DateTime IPerson.GetDateOfBirth()
        {
            DateTime dt = new DateTime();
            return dt;
        }

        // Admin will have many cohorts
        // Many teachers 
        // many students
        public List<Cohort> Cohort { get; set; }
        public List<Student> Student { get; set; }
        public List<Teacher> Teacher { get; set; }


    }
}
