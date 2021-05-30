using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.DTOs
{
    public class RegisterDto
    {

        [Required] public String Username { get; set; }

      [Required]  public String KnownAs { get; set; }

        [Required] public String Gender { get; set; }

        [Required] public DateTime DateOfBirth { get; set; }

        [Required] public String City { get; set; }

        [Required] public String Country { get; set; }

        [Required]
        [StringLength(8,MinimumLength =4)]
        public String Password { get; set; }
    }


}
