using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    class AudiA3 : Car
    {
        public AudiA3(string numPlate) : base("Audi", "A3", numPlate)
        {

        }

        public override void Accelerate(int sec)
        {
            Velocity = Velocity = (int)(sec * 5 * 3.6);
        }
    }
}