using prework_asp.Data.Migrations;
using prework_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Data.Seed
{
    public class Seeder
    {
        private readonly ApplicationDbContext _context;

        public Seeder(ApplicationDbContext context)
        {
            _context = context;
        }

        // TODO: Test and see if context needs to be passed in
        public void Seed()
        {
            AdminInitialize("Andrea", "Wichman", "55555555", "msisneroswichm@cnm.edu", true);
            TeacherInitialize("Brian", "Jones", "55555555", "brianjones@solution", true);
            StudentInitialize("Dustin", "Fleming", "5555555", "dustin@cnm.edu");
            CohortInitialize("Cohort 1", true, DateTime.ParseExact("15/06/2015 13:45:00", "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact("15/06/2015 13:45:00", "dd/MM/yyyy HH:mm:ss", null));
        }
        // Seed Admin
        private void AdminInitialize(string fname, string lname,string phoneNum,string email ,bool admin)
        {
            var ad = new Admin
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email,
                isAdmin = admin
            };
        }

        // Seed Teacher 
        private void TeacherInitialize(string fname, string lname, string phoneNum, string email, bool teacher)
        {
            var teach = new Teacher
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email,
                isTeacher = teacher
            };
        }

        // Seed Student 
        private void StudentInitialize(string fname, string lname, string phoneNum, string email)
        {
            var student = new Student
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email
            };
        }

        // Seed Cohort
        private void CohortInitialize(string cName, bool progress, DateTime startDate, DateTime endDate)
        {
            var student = new Cohort
            {
                CohortName = cName,
                InProgress = progress,
                StartDate = startDate,
                EndDate = endDate
            };
        }

    }

}
