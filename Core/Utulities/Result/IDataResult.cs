﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utulities.Result
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
