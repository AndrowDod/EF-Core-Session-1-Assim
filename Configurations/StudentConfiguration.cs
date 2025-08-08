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
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasKey(S => S.St_Id);
            
            student.Property(S => S.St_Id)
                .IsRequired()
                .UseIdentityColumn(1, 1);

            student.Property(S => S.FName)
                .IsRequired()
                .HasMaxLength(50);


            student.Property(S => S.LName)
                .IsRequired()
                .HasMaxLength(50);

            student.Property(S => S.Address)
                .IsRequired(false)
                .HasMaxLength(100);

            student.Property(S => S.Age)
                .IsRequired(false);

         


        }
    }
}
