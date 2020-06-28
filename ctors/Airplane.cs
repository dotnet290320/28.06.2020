using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2806
{
    class Airplane
    {
        public string _name;

        // topic of making few ctors
        // with different parameters
        // is called:
        // ctor overloading
        // method overloading - 
        // same method name, 
        //  different parameters

        public Airplane()
        {

        }

        /// <summary>
        /// This ctor
        /// deletes the default ctor!!!
        /// (given by C#)
        /// </summary>
        /// <param name="name"></param>
        public Airplane(string name)
        {
           _name = name;
        }

        /// <summary>
        /// This ctor
        /// deletes the default ctor!!!
        /// (given by C#)
        /// </summary>
        /// <param name="name"></param>
        public Airplane(int x)
        {
            _name = x.ToString();
        }


        public override string ToString()
        {
            return $"{base.ToString()} {_name}";
        }
    }
}
