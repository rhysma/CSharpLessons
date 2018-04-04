using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    public sealed class Pen 
    {

        public Pen(string type)
        {
            Type = type;
        }

        public string Type
        {
            get;
            set;
        }
    }
}
