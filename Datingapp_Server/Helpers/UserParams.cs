using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Helpers
{
    public class UserParams : PaginationParams
    {
      
        public String CurrentUsername { get; set; }

        public String Gender { get; set; }

        public int MinAge { get; set; } = 18;

        public int MaxAge { get; set; } = 150;

        public String OrderBy { get; set; } = "lastActive";
    }
}
