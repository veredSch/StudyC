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
       
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public String UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Range(6, 8)]
        public int Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }

        [Range(0, 100)]
        public int Grade { get; set; }

    }
}
