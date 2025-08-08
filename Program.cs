using EF_Core_Session_1_Assim.Entities;
using EF_Core_Session_1_Assim.itiDbContext;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Session_1_Assim
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using itiDbcontext dbContext  = new itiDbcontext();

            // use the database ( CRUD )
            #region Student table

            // insert 
            ///Student st01 = new Student() { FName = "Androw" , LName = "Safowat" , Address = "30 street form 45 street" , Age = 22 , Dept_Id = 0 };
            ///dbContext.Add(st01);
            ///dbContext.SaveChanges();

            //select
            ///Student student =  (dbContext.Students.Where(S => S.St_Id == 5)).AsNoTracking().FirstOrDefault();
            ///Console.WriteLine(student is null ? "NA" : $"{student.FName} {student.LName}");

            //Update
            ///Student student = dbContext.Students.Where(S => S.St_Id == 4).FirstOrDefault();
            ///student.FName = "arsany";
            ///student.LName = "refat";
            ///dbContext.SaveChanges();

            //Delete
            ///Student student = dbContext.Students.Where(S => S.St_Id == 3).FirstOrDefault();
            ///dbContext.Remove(student);
            ///dbContext.SaveChanges();

            #endregion

            #region Department table
            // insert 
           // DateTime hiringDate = new DateTime(2023, 10, 1 , 00 ,00 ,00);
            //Department dept01 = new Department() { Name = "Computer Science", HiringDate = hiringDate, Isn_Id = 1 };
            //Department dept02 = new Department() { Name = "sciences", HiringDate = hiringDate , Isn_Id = 2 };
            //Department dept03 = new Department() { Name = "Development", HiringDate = hiringDate, Isn_Id = 3 };
            //Department dept04 = new Department() { Name = "Test", HiringDate = hiringDate, Isn_Id = 4 };

            //dbContext.Departments.Add(dept04);
            //dbContext.SaveChanges();


            //select
            //Department dept = (dbContext.Students.Where(D => D.Id == 2)).AsNoTracking().FirstOrDefault();
            //Console.WriteLine(dept is null ? "NA" : $"{dept.Name} ::: {dept.HiringDate}");

            //Update
            //Department dept = dbContext.Students.Where(D => D.Id == 4).FirstOrDefault();
            //dept.Name = "Math";
            //dbContext.SaveChanges();

            //Delete
            //Department dept = dbContext.Departments.Where(D => D.Id == 4).FirstOrDefault();
            //dbContext.Remove(dept);
            //dbContext.SaveChanges();
            #endregion

        }
    }
}
