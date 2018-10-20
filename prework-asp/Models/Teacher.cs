﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Models
{
    public class Teacher : Person
    {

        public int TeacherID { get; set; }

        public Boolean isTeacher { get; set; }



        // Teacher will have many students
        // Teacher will have many progresses
        // Teacher will have 1 admin 
        public List<Student> Student { get; set; }
        public List<Progress> Progress { get; set; }
    }
}
