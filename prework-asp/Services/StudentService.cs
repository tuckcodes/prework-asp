using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prework_asp.Interfaces;
using prework_asp.Data.Migrations;
using prework_asp.Models;

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

        public void GetProg()
        {
            //TODO: define when needed
        }

        public Student GetSId(Student sUser)
        {
            var result = _context.Student.Add(sUser);
            _context.SaveChanges();
            return result;
        }
    }


}
