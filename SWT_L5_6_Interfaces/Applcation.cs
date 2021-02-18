using System;

namespace SWT_L5_6_Interfaces
{
    class Applcation
    {
        static void Main(string[] args)
        {
            var ecs = new Ecs(28);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
