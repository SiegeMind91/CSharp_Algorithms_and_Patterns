using System;
using Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar = new Navigation(theCar);
            theCar = new Sunroof(theCar);
            //theCar = new LeatherSeats(theCar);

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine($"{theCar.GetCarPrice():C2}");
            Console.ReadKey();
        }
    }
}
