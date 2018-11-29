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


        public void Seed()
        {
            AdminInitialize(true);
        }

        // Seed Admin
        private void AdminInitialize(bool admin)
        {
            var ad = new Admin
            {
                isAdmin = admin
            };
        }

        // Seed Teacher 

        // Seed Student 

        // Seed Cohort


    }

}
