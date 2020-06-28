using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280620_
{
    class Car : Vehicle
    {

        public int _numberOfDoors;

        public override int GetMaxNumOfPassengers()
        {
            return 4;
        }

        public override int GetMaxSpeed()
        {
            return 180;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_numberOfDoors}";
        }
    }
}
