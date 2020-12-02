using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Question
    {
        public int id { get; set; }
        public int correctAnswer { get; set; }
        public bool IScorrectAnswer { get; set; }
        [Required]
        [StringLength(50)]
        public String question { get; set; }
        [Required]
        [StringLength(100)]

        public String option1 { get; set; }
        [Required]
        [StringLength(100)]
        public String option2 { get; set; }
        [Required]
        [StringLength(100)]
        public String option3 { get; set; }
        [Required]
        [StringLength(100)]
        public String option4 { get; set; }
        public Quiz q { get; set; }

    }
}
