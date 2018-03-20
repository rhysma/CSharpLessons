using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue = "";
            while (inValue != "−99")
            {
                Console.Write("\nEnter value (−99 to exit): ");
                inValue = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
