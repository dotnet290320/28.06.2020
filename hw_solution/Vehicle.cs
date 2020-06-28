using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280620_
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"{base.ToString()} model : {_model} number of wheels : {_numberOfWheels} " +
                $"Max speed : {GetMaxSpeed() } max passengers: {GetMaxNumOfPassengers()}";
        }
    }
}
