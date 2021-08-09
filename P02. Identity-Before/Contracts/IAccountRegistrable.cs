﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P02._Identity_Before.Contracts
{
    public interface IAccountRegistrable
    {
        bool RequireUniqueEmail { get; }

        int MinRequiredPasswordLength { get; }

        int MaxRequiredPasswordLength { get; }
    }
}
