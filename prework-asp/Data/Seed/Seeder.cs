using prework_asp.Data;
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
            AdminInitialize("Andrea", "Wichman", "55555555", "msisneroswichm@cnm.edu", true, context);
            //TeacherInitialize("Brian", "Jones", "55555555", "brianjones@solution", true, context);
            //StudentInitialize("Dustin", "Fleming", "5555555", "dustin@cnm.edu", context);
            //CohortInitialize("Cohort 1", true, DateTime.ParseExact("15/06/2015 13:45:00", "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact("15/06/2015 13:45:00", "dd/MM/yyyy HH:mm:ss", null), context);
        }
        // Seed Admin
        private static void AdminInitialize( string fname, string lname,string phoneNum,string email ,bool admin, ApplicationDbContext context)
        {
            var ad = new Admin
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email,
                isAdmin = admin
            };
            context.Add(ad);
            context.SaveChanges();
        }

        // Seed Teacher 
        private static void TeacherInitialize(string fname, string lname, string phoneNum, string email, bool teacher, ApplicationDbContext context)
        {
            var teach = new Teacher
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email,
                isTeacher = teacher
            };
            context.Add(teach);
            context.SaveChanges();
        }

        // Seed Student 
        private static void StudentInitialize(string fname, string lname, string phoneNum, string email, ApplicationDbContext context)
        {
            var student = new Student
            {
                FirstName = fname,
                LastName = lname,
                PhoneNumber = phoneNum,
                Email = email
            };
            context.Add(student);
            context.SaveChanges();
        }

        // Seed Cohort
        private static void CohortInitialize(string cName, bool progress, DateTime startDate, DateTime endDate, ApplicationDbContext context)
        {
            var cohort = new Cohort
            {
                CohortName = cName,
                InProgress = progress,
                StartDate = startDate,
                EndDate = endDate
            };
            context.Add(cohort);
            context.SaveChanges();
        }

        // Seed progress

        // Seed assignment

    }

}
