using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    // fluent API way
    class Course
    {
        public int ID { get; set; }    
        public int Duration { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }


        public int? Top_ID  { get; set; }
        public Topic Topics { get; set; }
        public ICollection<Stud_Course> courseStudents { get; set; } = new HashSet<Stud_Course>(); // Foreign Key to course

        public ICollection<Course_Inst> courseInstructors { get; set; } = new HashSet<Course_Inst>(); // Foreign Key to instructor

    }
}
