using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Helpers
{
    public class MessageParams:PaginationParams
    {
        public  String Username { get; set; }

        public string Container { get; set; } = "Unread";
    }
}
