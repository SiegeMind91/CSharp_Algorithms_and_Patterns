using System;

namespace Decorator.ConcreteComponent
{
    //Concrete Component
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 10000.00;
    }
}