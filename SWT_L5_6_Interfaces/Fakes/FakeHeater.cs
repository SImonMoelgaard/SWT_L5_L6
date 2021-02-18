using System;
using System.Collections.Generic;
using System.Text;

namespace SWT_L5_6_Interfaces
{
    public class FakeHeater : IHeater
    {
        public bool Answer { get; set; }
        public FakeHeater(bool answer)
        {
            Answer = answer;
        }
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            Answer = true;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            Answer = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
