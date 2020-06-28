using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280620_
{
    class Carrier
    {
        public Vehicle[] _vehicles;

        public override string ToString()
        {
            string st = "a";
            st = st + "b"; // "ab"
            st = st + "cd"; // "abcd"

            string result = "Carrier class. vehicls on carrier: \n";
            for (int i = 0; i < _vehicles.Length; i++)
            {
                result = result + _vehicles[i].ToString() + "\n";
            }
            return result;
        }
    }
}
