using System;
using System.Collections.Generic;
using System.Text;

namespace Project13
{
    public interface IRecoverable //interfaces is all about forcing behavior onto a class,
                                  //so any class that implements this interface must provide
                                  //an implementation for the Recover method
    {
        string Recover();
    }
}
