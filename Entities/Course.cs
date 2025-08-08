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



    }
}
