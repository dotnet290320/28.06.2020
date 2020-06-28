using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280620_
{
    class Motorcycle : Vehicle
    {

        public int _numberOfHandBreakes;

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 240;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_numberOfHandBreakes}";
        }
    }
}
