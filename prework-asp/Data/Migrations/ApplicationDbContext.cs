using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prework_asp.Models;

namespace prework_asp.Data.Migrations
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Admin>().ToTable("Admin");
            builder.Entity<Teacher>().ToTable("Teacher");
            builder.Entity<Student>().ToTable("Student");
            builder.Entity<Cohort>().ToTable("Cohort");
            builder.Entity<Progress>().ToTable("Progress");
            builder.Entity<Assignments>().ToTable("Assignment");
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Cohort> Cohort { get; set; }
        public DbSet<Progress> Progress { get; set; }
        public DbSet<Assignments> Assignment { get; set; }

    }
}
