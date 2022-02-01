using System;

namespace Singleton
{
    public class Policy
    {
        private static readonly object _lock = new object();
        private static Policy _instance;
        public static Policy Instance 
        {
            get 
            { 
                lock(_lock) 
                {
                    if (_instance==null)
                    {
                        _instance = new Policy();
                    }
                    return _instance;
                }
            }
        }
        public Policy()
        {
            
        }
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John McCarthy";

        public string GetInsuredName() => Insured;
    }
}