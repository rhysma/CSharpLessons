using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    class MathHelper
    {
        public static int Square(int aValue)
        {
            return aValue * aValue;
        }

        public static int AddNumber(int number1 = 5, int number2 = 10)
        {
            return number1 + number2;
        }

        public static void NumbersOut(out int value)
        {
            value = 9;
        }

        public static void NumbersRef(ref int value)
        {
            value = 7;
        }
    }
}
