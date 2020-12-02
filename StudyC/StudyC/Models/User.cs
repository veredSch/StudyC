using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public String userName { get; set; }
        [Required]
        [Range(6, 8)]
        public int password { get; set; }
        [Required]
        [In('@')]
        public String mail { get; set; }
        [Range(0, 100)]
        public int grade { get; set; }

        public String diploma { get; set; }
    }
}
