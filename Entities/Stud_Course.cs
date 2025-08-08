using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    // fluent API way
    class Stud_Course
    {

        public int StudentID { get; set; }  // Foreign Key to Student
        public int CourseId { get; set; }  // Foreign Key to Course
        public int Grade { get; set; }
    }
}
