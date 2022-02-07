using System;

namespace ObserverPattern
{
    //Observer 
    public interface IFan
    {
        void Update(ICelebrity celebrity);
    }
}