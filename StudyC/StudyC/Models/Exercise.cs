﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public String Question { get; set; }

        [Required]
        [StringLength(1000)]
        public String Answer { get; set; }

        public Study St { get; set; }


    }
}
