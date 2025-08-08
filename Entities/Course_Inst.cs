using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    class Course_Inst
    {
        // fluent API way
        public int Inst_Id { get; set; } // Foreign Key
        public int Course_Id { get; set; } // Foreign Key
        public decimal Evaluate { get; set; }
    }
}
