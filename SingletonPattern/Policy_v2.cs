using System;

namespace Singleton
{
    public class Policy
    {
        private static readonly Policy _instance = new Policy();
        public static Policy Instance 
        {
            get 
            { 
                return _instance;
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