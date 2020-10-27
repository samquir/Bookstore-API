﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_API.Contracts
{
    public interface IloggerService
    {
        void LogInfo(string message);
        void LogWarn(string message); 
        void LogDebug(string message); 
        void LogError(string message);

    }
}
