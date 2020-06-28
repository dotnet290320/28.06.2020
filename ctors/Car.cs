using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2806
{
    class Car
    {
        public string _model;
        public string _brand;
        public int _price;
        public string _parking_location;

        /// <summary>
        /// Constructor
        /// must be in the EXACT name of the class!
        /// 
        /// constructor is a method which creates a new instance for the current class
        /// the constructor method will never have a return type defined
        /// 
        /// you can have many constructors
        /// each constructor has its own set of parameters
        /// </summary>
        /// <param name="model"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        public Car(string model, string _brand, int _price)
        {
            _model = model;
            this._brand = _brand;
            this._price = _price;
        }

        public void Drive()
        {
            Console.WriteLine($"Driving my {_model} car!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_model} {_brand} {_price} {_parking_location}";
        }
    }
}
