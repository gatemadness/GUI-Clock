﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockLogic
{
    interface IHour
    {
        int HourValue { get; set; }

        void Tick();
    }
}
