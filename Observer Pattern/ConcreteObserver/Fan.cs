using System;

namespace ObserverPattern
{
    //Concrete Observer 
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: {celebrity.Tweet}");
        }
    }
}