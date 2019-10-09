using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    class Bmwm3 : Car
    {
        public Bmwm3(string numPlate) : base("BMW", "M3", numPlate)
        {

        }
        public override void Accelerate(int sec)
        {
            Velocity = Velocity = (int)(sec * 6 * 3.6);
        }
    }
}
