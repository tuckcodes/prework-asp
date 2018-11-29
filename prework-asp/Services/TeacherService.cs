using prework_asp.Data.Migrations;
using prework_asp.Interfaces;
using prework_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ApplicationDbContext _context;

        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetsStudents()
        {
            var students = _context.Student.SingleOrDefault();
        }

        public void GetsTclID()
        {
            throw new NotImplementedException();
        }

        public void  GetSId(Teacher tuser)
        {
            var result = _context.Teacher
                .Add(tuser);
            _context.SaveChanges();
        }

        
    }
}
