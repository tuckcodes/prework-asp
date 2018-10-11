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
            return "First Name";
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
            throw new NotImplementedException();
        }
    }
}
