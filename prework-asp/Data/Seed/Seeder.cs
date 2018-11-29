using prework_asp.Data.Migrations;
using prework_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prework_asp.Data.Seed
{
    public static class Seeder
    {
       
        public static void Seed(ApplicationDbContext context)
        {
            StudentInitialize("Dustin", "Fleming", "5555555", "dustin@cnm.edu");
            TeacherInitialize("Brian", "Jones", "55555555", "brianjones@solution", true);
            CohortInitialize("Cohort 1", true, DateTime.ParseExact("15/06/2015 13:45:00", "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact("15/06/2015 13:45:00", "dd/MM/yyyy HH:mm:ss", null));
            AdminInitialize("Andrea", "Wichman", "55555555", "msisneroswichm@cnm.edu", true);
        }
        // Seed Admin
        private static void AdminInitialize( string fname, string lname,string phoneNum,string email ,bool admin)
        {
            var ad = new Admin
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email,
                isAdmin = admin,
            };
        }

        // Seed Teacher 
        private static void TeacherInitialize(string fname, string lname, string phoneNum, string email, bool teacher)
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
        private static void StudentInitialize(string fname, string lname, string phoneNum, string email)
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
        private static void CohortInitialize(string cName, bool progress, DateTime startDate, DateTime endDate)
        {
            var student = new Cohort
            {
                CohortName = cName,
                InProgress = progress,
                StartDate = startDate,
                EndDate = endDate
            };
        }

        // Seed progress

        // Seed assignment

    }

}
