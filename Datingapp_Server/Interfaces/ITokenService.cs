﻿using Datingapp_Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Interfaces
{
   public  interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
