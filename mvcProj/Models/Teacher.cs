using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcProj.Models {
    public class Teacher
    {
        [Required]
        public int TeacherId { get; set;}
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string TeacherSub { get; set; }
    }

}

