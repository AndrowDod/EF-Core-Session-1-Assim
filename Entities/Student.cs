using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    class Student
    {
        // fluent API way
        public int St_Id { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String Address { get; set; }
        public int? Age { get; set; }
        public ICollection<Stud_Course> studentCourses { get; set; } = new HashSet<Stud_Course>(); // Foreign Key


    }
}
