using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstname;
            string age;

            //ask the user their name
            Console.WriteLine("What is your first name?");
            userFirstname = Console.ReadLine();

            //ask the user their age
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            string response = "Your name is: " + userFirstname + 
                              " and you are " + age + " years old";
            Console.WriteLine(response);
        }
    }
}
