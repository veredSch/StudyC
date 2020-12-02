using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Contact
    {
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public String userName { get; set; }
        [Required]
        [In('@')]
        public String mail { get; set; }
        [Required]
        [StringLength(50)]
        public String subject { get; set; }
        [Required]
        [StringLength(100)]
        public String message { get; set; }
    }
}
