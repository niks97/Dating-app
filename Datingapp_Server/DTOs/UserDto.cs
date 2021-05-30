using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.DTOs
{
    public class UserDto
    {
        public String Username { get; set; }

        public String Token { get; set; }

        public String PhotoUrl { get; set; }

        public String KnownAs  { get; set; }

        public String Gender { get; set; }


    }
}
