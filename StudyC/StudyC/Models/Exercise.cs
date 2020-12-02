using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Exercise//id לכול מחלקה?
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public String question { get; set; }
        public Studies st { get; set; }
    }
}
