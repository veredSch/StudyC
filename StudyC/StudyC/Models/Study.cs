using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Study
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public String Subject { get; set; }

        [Required]
        [StringLength(1500)]
        public String Information { get; set; }

        public List<Exercise> Exercises { get; set; }
    }
}
