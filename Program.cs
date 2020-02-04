using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Program_Classes;

namespace Scientific_Notation_Converter
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! This is a scientific notation converter!");
            Thread.Sleep(3000);
            while (true)
            {
                Console.WriteLine("\nWould you like to convert a number into scientific notation?\nOr would you like to convert scientific notation into a number?\n\nSay 'Sci' for Scientific Notation, and 'Num' for number.\nYou can also say 'quit' to quit the program!");
                string decision = Console.ReadLine();
                if (decision == "Sci" || decision == "sci")
                {
                    SciNot s = new SciNot();
                }
                else if (decision == "Num" || decision == "num")
                {
                    Number n = new Number();
                }
                else if (decision == "Quit" || decision == "quit")
                {
                    break;
                }

            }

        }
    }
}
