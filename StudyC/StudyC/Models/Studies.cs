using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Studies//משתנים מסוג פאבליק?
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public String subject { get; set; }
        [Required]
        [StringLength(100)]
        public String information { get; set; }
        [Required]
        [StringLength(100)]
        public String example { get; set; }
        public List<Exercise> exes { get; set; }
    }
}
