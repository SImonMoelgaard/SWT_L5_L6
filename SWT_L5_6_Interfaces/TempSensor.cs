using System;
using System.Collections.Generic;
using System.Text;

namespace SWT_L5_6_Interfaces
{
   internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
            
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
