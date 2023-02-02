using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    internal class DublicatedItemException:Exception
    {
        public DublicatedItemException():base("Eyni telebe daxil edirsiniz")
        {

        }
    }
}
