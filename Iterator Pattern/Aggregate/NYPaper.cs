using System;

namespace Iterator.Aggregate
{
    //ConcreteAggregate
    public class NYPaper : INewspaper
    {
        private string[] _reporters;
        public NYPaper()
        {
            _reporters = new[] { "Michael Scott - NY",
                                 "Jim Beasley - NY",
                                 "Toland the Wise - NY",
                                 "Bowie Nathaniel - NY",
                                 "Sam Elliot - NY",            
            };
        }

        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}