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

        [Required(ErrorMessage = "must input username")]
        [StringLength(30)]
        public String UserName { get; set; }

        [Required(ErrorMessage = "must input Number Required")]
        [DataType(DataType.PhoneNumber)]
        public String Mobile { get; set; }

        [Required(ErrorMessage = "must input mail adress")]
        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }

        [Required(ErrorMessage = "must input subject adress")]
        [StringLength(50)]
        public String Subject { get; set; }

        [Required(ErrorMessage = "must input Message adress")]
        [StringLength(400)]
        public String Message { get; set; }
    }
}
