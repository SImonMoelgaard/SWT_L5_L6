using System;
using System.Collections.Generic;
using System.Text;

namespace SWT_L5_6_Interfaces
{
    public interface ITempSensor
    {
        public int GetTemp();
        public bool RunSelfTest();

    }
}
