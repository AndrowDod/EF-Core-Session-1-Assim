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


            // primary key for Stud_Course
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.StudentID, sc.CourseId });

            // foreign key for Course_Inst
            modelBuilder.Entity<Course>()
                .HasMany(C => C.courseInstructors)
                .WithOne();

            //primary key for Course_Inst
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Inst_Id, ci.Course_Id });

            // foreign key for Instructor
            modelBuilder.Entity<Instructor>()
                .HasMany(I => I.InstructorCourses)
                .WithOne();

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.DeptInstructors)
                .HasForeignKey(i => i.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);







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
