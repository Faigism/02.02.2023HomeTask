using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    internal class OutOfLimitException:Exception
    {
        public OutOfLimitException(string error):base(error)
        {

        }
    }
}
