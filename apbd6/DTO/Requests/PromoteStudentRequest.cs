using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_tut6.DTO.Requests
{
    public class PromoteStudentRequest
    {
      [Required]
      public string Studies { get; set; }

      [Required]
      public int Semester { get; set; }
    }
}
