using EF_Core_Session_1_Assim.Configurations;
using EF_Core_Session_1_Assim.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.itiDbContext
{
    class itiDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = ANDROW\\SQLEXPRESS ; Database=ITI ; Trusted_Connection=True ; ");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // student configuration
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            // Course configuration
            modelBuilder.ApplyConfiguration(new CourseConfiguration());





            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Topic> Topics { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Stud_Course> Stud_Courses { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Course_Inst> Course_Inst { get; set; }

        public DbSet<Department> Departments { get; set; }



    }
}
