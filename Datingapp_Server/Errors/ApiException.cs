﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datingapp_Server.Errors
{

   
    public class ApiException
    {

        public ApiException(int statusCode,string message=null,string details=null)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;

        }

        public int StatusCode { get; set; }

        public String Message { get; set; }

        public String Details { get; set; }
    }
}
