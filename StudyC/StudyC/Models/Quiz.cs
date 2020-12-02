using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Quiz
    {
        public int id { get; set; }

        public int numcorrect { get; set; }

        [Range(0, 100)]
        public int grade { get; set; }
        [Required]
        public List<Question> q { get; set; }
        
    }
}
