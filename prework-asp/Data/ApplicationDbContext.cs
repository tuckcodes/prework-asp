using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prework_asp.Models;

namespace prework_asp.Data
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
            builder.Entity<Admin>().ToTable(nameof(Admin));
            builder.Entity<Teacher>().ToTable(nameof(Teacher));
            builder.Entity<Student>().ToTable(nameof(Student));
            builder.Entity<Cohort>().ToTable(nameof(Cohort));
            builder.Entity<Progress>().ToTable(nameof(Progress));
            builder.Entity<Assignments>().ToTable(nameof(Assignments));
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Cohort> Cohort { get; set; }
        public DbSet<Progress> Progress { get; set; }
        public DbSet<Assignments> Assignments { get; set; }

    }
}
