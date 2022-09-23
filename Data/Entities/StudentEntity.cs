using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Entities
{
    public class StudentEntity
    {
        [Key]
        public int studentId { get; set; }
        [StringLength(30)]
        public string studentName { get; set; }
    }
}
