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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello User! This is a scientific notation converter!");
            Thread.Sleep(3000);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nWould you like to convert a number into scientific notation?\nOr would you like to convert scientific notation into a number?\n\nSay 'Sci' for Scientific Notation, and 'Num' for number.\nYou can also say 'quit' to quit the program!");
                string decision = Console.ReadLine();
                if (decision == "Sci" || decision == "sci")
                {
                    SciNot s = new SciNot();
                    s.SciNotCalculator();
                }
                else if (decision == "Num" || decision == "num")
                {
                    Number n = new Number();
                    n.NumberCalculator();
                }
                else if (decision == "Quit" || decision == "quit")
                {
                    Console.ResetColor();
                    Console.WriteLine("\n============================================================");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nThank you for using this application!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPress any button to exit...");
                    Console.ReadLine();
                    break;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nI'm sorry, but that is not a valid choice...");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }

            }

        }
    }
}
