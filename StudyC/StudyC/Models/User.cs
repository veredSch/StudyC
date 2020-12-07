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

        [Required(ErrorMessage = "must input username")]
        [StringLength(30)]
        public String UserName { get; set; }

        [Required(ErrorMessage = "must input password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Range(6, 8)]
        public int Password { get; set; }

        [Required(ErrorMessage = "must input mail adress")]
        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }

        public List<UserStudy> UserStudy { get; set; }

    }
}
