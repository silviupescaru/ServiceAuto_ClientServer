﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Domain
{
    internal interface IUserRepository
    {
        bool LoginUser(string username, string password);
    }
}