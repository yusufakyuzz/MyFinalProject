﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utulities.Result
{
    public class SuccessResult:Result
    {
        public SuccessResult(bool success,string message):base(true,message)
        {

        }

        public SuccessResult(bool success):base(true)
        {

        }
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
