﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prework_asp.Interfaces;
using prework_asp.Models;
using prework_asp.Data;

namespace prework_asp.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetCohorts()
        {
            var isCohort = _context.Cohort.SingleOrDefault();
        }

      
        public void GetProgress()
        {
            throw new NotImplementedException();
        }

        public void GetSId(Student sUser)
        {
            var result = _context.Student
                .Add(sUser);
            _context.SaveChanges();
        }

        public void GetStudentId(Student student)
        {
            throw new NotImplementedException();
        }
    }


}
