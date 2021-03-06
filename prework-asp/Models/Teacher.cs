﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Teacher
    {

        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string LastName { get; set; }
        public Boolean isTeacher { get; set; }
        // Nav
        public List<Student> Student { get; set; }
        public int AdminID { get; set; }
        public Admin Admin;
    }
}
