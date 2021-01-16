using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Question
    {
        public int Id { get; set; }
       
        

        [Required]
        [StringLength(500)]
        public string Text { get; set; }
        
        [Required]
        [StringLength(1000)]        
       public List<Option> Options { get; set; }

       
        public Study Study { get; set; } 



    }
}
