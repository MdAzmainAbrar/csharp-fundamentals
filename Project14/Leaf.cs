using System;
using System.Collections.Generic;
using System.Text;

namespace Project14
{
    internal class Leaf : ITurnable
    {
        public string Turn()
        {
            return "Leaf is being turned, it's fluttering in the wind!";
        }

    }
}
