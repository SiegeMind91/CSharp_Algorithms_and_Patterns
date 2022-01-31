using System;

namespace Interfaces
{
    //Abstract Factory
    public abstract class ICreditUnionFactory
    {
        public abstract ILoanAccount CreateLoanAccount();
        public abstract ISavingsAccount CreateSavingsAccount();
    }

    //Abstract Product A
    public interface ILoanAccount { }

    //Abstract Product B
    public interface ISavingsAccount { }


}
