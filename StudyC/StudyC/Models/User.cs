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

        [Required(ErrorMessage = "דרש להכניס שם משתמש")]
        [StringLength(30)]
        [Display(Name = "שם משתמש")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "דרוש להכניס סיסמא")]
        [DataType(DataType.Password)]
        //[Range(6,8)]
        [Display(Name ="סיסמא")]
        public int Password { get; set; }

        [Required(ErrorMessage = "דרוש להכניס כתובת מייל")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "כתובת מייל")]
        public String Mail { get; set; }

        
        public bool RememberMe { get; set; }

        public List<UserStudy> UserStudy { get; set; }

    }
}
