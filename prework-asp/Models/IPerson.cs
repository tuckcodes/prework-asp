using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public interface IPerson
    {
        [Display(Name = "First Name")]
        string GetFirstName();

        [Display(Name = "Last Name")]
        string GetLastName();

        string GetAddress();

        string GetCity();

        string GetState();

        [Display(Name = "Phone Number")]
        string GetPhoneNumber();

        string GetEmailAddress();

        [Display(Name = "Date of birth")]
        DateTime GetDateOfBirth();

    }
}
