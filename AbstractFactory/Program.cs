using System;
using CitiCreditUnion;
using NationalCreditUnion;
using Interfaces;
using Providers;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> acctNumbers = new List<string> { "CITI-456", "NATIONAL-987", "CHASE-222"};

            for (int i = 0; i < acctNumbers.Count; i++)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(acctNumbers[i]);

                if (anAbstractFactory == null)
                {
                    Console.WriteLine("Sorry, this credit union w/ account number" + $" '{acctNumbers[i]}' is invalid");
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }
    }
}