using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2806
{
    class Program
    {
        static void Foo(int x)
        {

        }

        // method overloading
        static void Foo(string y)
        {

        }

        static void PrintWithStars(int x)
        {
            Console.WriteLine($"**{x}**");
        }

        static void PrintWithStars(string s)
        {
            Console.WriteLine($"**{s}**");
        }

        static void Main(string[] args)
        {
            PrintWithStars(80);
            PrintWithStars("itay");

            Console.WriteLine(5);
            Console.WriteLine("hello");

            Console.WriteLine(5);
            Console.WriteLine("hello");

            // 1 where did i got the ctor(constructor) -- without parameters [default]

            //Car c = new Car()
            //{

            //};

            // 1 -- default ctor (parameterless)
            Airplane a1 = new Airplane()
            {
                _name = "Boing"
            };

            // 2 -- ctor with string
            Airplane a = new Airplane("F16");

            // 3
            Airplane a2 = new Airplane(90);


            // 2 why did this ctor (without parameter) dissapear when i wrote my own ctor ??

            // 3 can we add default ctor to a class

            //Car honda = new Car("Accord", "Honda", 180_000);
            // redundent
            //{
            //    _brand = "Honda",
            //    //_model = "Accord",
            //    _price = 180_000
            //};
            //Console.WriteLine(honda);

            //Car ferrari = new Car(_price: 100, _brand: "b", model: "ferrari");

            Person p1 = new Person(8.7f);
            Person p2 = new Person("din");

        }
    }
}
