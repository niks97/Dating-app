using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.DTOs
{
    public class CreateMessageDto
    {
        public String RecipientUsername { get; set; }

        public String Content { get; set; }
    }
}
