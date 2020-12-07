using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyC.Models
{
    public class UserStudy
    {
        public int UserId { get; set; }
       
        public User User { get; set; }

        public int StudyId { get; set; }

        public Study Study { get; set; }
    }
}
