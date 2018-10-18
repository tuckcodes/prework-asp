using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
     interface IPerson
    {
        string GetFirstName();

        string GetLastName();

        string GetAddress();

        string GetCity();

        string GetState();

        string GetPhoneNumber();

        string GetEmailAddress();
   
        DateTime GetDateOfBirth();

    }
}
