using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcProj.Models
{
public class Student {
    [Key]
    public int StudentId { get; set; }
    [Required]
    public string StudentName { get; set;  }
    [Required]
    public int Age { get; set;  }
}
}