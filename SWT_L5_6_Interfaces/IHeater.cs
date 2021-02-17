using System;
using System.Collections.Generic;
using System.Text;

namespace SWT_L5_6_Interfaces
{
    public interface IHeater
    {
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();


    }
}
