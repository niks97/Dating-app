using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Helpers
{
    public class LikesParams:PaginationParams
    {
        public int UserId { get; set; }

        public String Predicate { get; set; }

    }
}
