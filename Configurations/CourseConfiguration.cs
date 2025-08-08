using EF_Core_Session_1_Assim.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Configurations
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
           
            course.HasKey(c => c.ID);
            course.Property(c => c.ID)
                .IsRequired()
                .UseIdentityColumn(1, 1);

            course.Property(c => c.Duration)
                .IsRequired()
                .HasDefaultValue(0);

            course.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            course.Property(c => c.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            


            // relationships for Course and Stud_Course

            course.HasMany(C => C.courseStudents)
               .WithOne();

        }
    }
}
