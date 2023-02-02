using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorktask
{
    internal class SameProductName:Exception
    {
        public SameProductName(string error):base(error)
        {

        }
    }
}
