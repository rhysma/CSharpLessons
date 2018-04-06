using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13
{
    class CustomException : Exception
    {
        public CustomException(string message)
            :base(message)
        {

        }
    }
}
