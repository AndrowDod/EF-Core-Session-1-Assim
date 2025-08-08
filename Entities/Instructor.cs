using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session_1_Assim.Entities
{
    // annotation way
    [Table("Instructor" , Schema = "dbo")]
    class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        
        public decimal? Bouns { get; set; }

        public decimal Salary { get; set; }

        
        public String? Address { get; set; }

       
        public decimal? HourRate { get; set; }


   

    }
}
