using System;
using Iterator.Aggregate;
using Iterator.Iterator;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LAPaper();

            IIterator nypIterator = nyt.CreateIterator();
            IIterator latIterator = lat.CreateIterator();

            Console.WriteLine("--------    NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------    LAPaper");
            PrintReporters(latIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();

            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}