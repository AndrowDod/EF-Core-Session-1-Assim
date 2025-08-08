using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    //convention way
    class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime HiringDate { get; set; }
        
        public ICollection<Student> DeptStudents { get; set; } = new HashSet<Student>();

        public int InstructorId { get; set; }
        public Instructor Manager { get; set; }
        public ICollection<Instructor> DeptInstructors { get; set; } = new HashSet<Instructor>();

    }
}
