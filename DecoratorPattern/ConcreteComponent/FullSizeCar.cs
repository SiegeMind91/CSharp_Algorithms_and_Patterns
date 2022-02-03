using System;

namespace Decorator.ConcreteComponent
{
    //Concrete Component
    public class FullSizeCar : Car
    {
        public CompactCar()
        {
            Description = "Full Size Car";
        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 30000.00;
    }
}