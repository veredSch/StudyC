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
        public int Id { get; set; }

        [Required(ErrorMessage = "דרוש לכתוב שם")]
        [StringLength(30)]
        [Display(Name = "שם")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "דרוש לכתוב מספר")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "מספר")]
        public String Mobile { get; set; }

        [Required(ErrorMessage = "דרוש לכתוב כתובת  אימייל")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "מייל")]
        public String Mail { get; set; }

        [Required(ErrorMessage = "דרוש להכניס נושא")]
        [StringLength(50)]
        [Display(Name = "נושא")]
        public String Subject { get; set; }

        [Required(ErrorMessage = "דרוש לכתוב הודעה")]
        [StringLength(500)]
        [Display(Name ="הודעה")]
        public String Message { get; set; }
    }
}
