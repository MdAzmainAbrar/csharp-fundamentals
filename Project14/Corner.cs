using System;
using System.Collections.Generic;
using System.Text;

namespace Project14
{
    internal class Corner : ITurnable
    {
        public string Turn()
        {
            return "Corner is being turned, watch out for sharp edges!";
        }
    }
}
