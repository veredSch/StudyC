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

        [Required]
        [StringLength(30)]
        public String UserName { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Mail { get; set; }

        [Required]
        [StringLength(50)]
        public String Subject { get; set; }

        [Required]
        [StringLength(300)]
        public String Message { get; set; }
    }
}
