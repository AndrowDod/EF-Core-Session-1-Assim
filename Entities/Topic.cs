using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    // Convention way
    class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> TopicCourses { get; set; } = new HashSet<Course>();
    }
}
