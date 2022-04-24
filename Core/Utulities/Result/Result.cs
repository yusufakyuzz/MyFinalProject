﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utulities.Result
{
    public class Result:IResult
    {
      

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            success = success;
        }

        public bool Success { get; }

        public string Message { get; }


    }
}
