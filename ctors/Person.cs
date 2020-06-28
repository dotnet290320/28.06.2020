using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2806
{
    class Person
    {
        public string _name;
        public int _age;
        public float _height;

        // ctor ( ) 
        // default, parameterless
        public Person()
        {

        }

        // ctor ( string )
        public Person(string name)
        {
            _name = name;
        }

        // ctor ( int )
        public Person(int age)
        {
            _age = age;
        }

        // ctor ( float )
        public Person(float height)
        {
            _height = height;
        }

        // ctor ( string, float )
        public Person(string name, float height)
        {
            _name = name;
            _height = height;
        }

        // ctor ( string, int )
        public Person(string name, int age = 18)
        {
            _name = name;
            _age = age;
        }

        public bool AreYouHigh()
        {
            // return _height > 2.0f;

            if (_height > 2.00)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_name} {_age} {_height}";
        }
    }
}
