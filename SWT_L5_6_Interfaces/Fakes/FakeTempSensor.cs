using System;
using System.Collections.Generic;
using System.Text;

namespace SWT_L5_6_Interfaces
{
    public class FakeTempSensor : ITempSensor
    {
        public int Value { get; set; }
        //private Random gen = new Random();
        public FakeTempSensor(int value)
        {
            Value = value;
        }
        public int GetTemp()
        {
            //return gen.Next(1);
            return Value;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
