using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Question
    {
        public int Id { get; set; }
       
        public int CorrectAnswer { get; set; }

        [Required]
        [StringLength(500)]
        public String Questions { get; set; }
        
        [Required]
        [StringLength(1000)]
        public Array Options { get; set; }

        [Required]
        public int NumOfOptions { get; set; }
       
        public Study Study { get; set; }



    }
}
