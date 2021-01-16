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

        [Required(ErrorMessage ="must input a subject")]
        [StringLength(300)]
        [Display(Name = "נושא")]
        public String Subject { get; set; }

        [Required(ErrorMessage = "must input information")]
        [StringLength(20000)]
        [Display(Name = "מידע")]
        public String Information { get; set; }

        public List<Question> Question { get; set; }

        public List<UserStudy> UserStudy { get; set; }
    }
}
