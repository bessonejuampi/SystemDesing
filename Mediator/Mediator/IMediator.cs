﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal interface IMediator
    {
        void Notify(User destiny, string message);

    }
}
