using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280620_
{
    class Program
    {
        static void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v._model);
            Console.WriteLine(v);
        }

        static void PrintVehicleArray(Vehicle[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            Motorcycle harley = new Motorcycle()
            {
                _model = "harley davidson",
                _numberOfHandBreakes = 2,
                _numberOfWheels = 2
            };
            Car honda = new Car()
            {
                _model = "Honda CX",
                _numberOfWheels = 4,
                _numberOfDoors = 4
            };

            Motorcycle suzuki = new Motorcycle()
            {
                _model = "suzuki 500",
                _numberOfHandBreakes = 2,
                _numberOfWheels = 2
            };
            Car mazda = new Car()
            {
                _model = "Mazda CX",
                _numberOfWheels = 4,
                _numberOfDoors = 4
            };

            int[] arr = new int[10];
            arr[0] = 1;

            int[] arr2 = new int[3] { 1, 2, 3 };

            // first way
            Vehicle[] vehicls = new Vehicle[] { harley, honda, mazda };

            // second way
            Vehicle[] vehicls2 = new Vehicle[3];
            vehicls2[0] = harley;
            vehicls2[1] = honda;
            vehicls2[2] = mazda;

            // 1
            Carrier carrier1 = new Carrier()
            {
                _vehicles = vehicls
            };

            // 2
            Carrier carrier2 = new Carrier()
            {
                _vehicles = new Vehicle[] {honda, harley}
            };

            Console.WriteLine(carrier2);
        }
    }
}
