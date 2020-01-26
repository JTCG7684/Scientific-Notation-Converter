using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scientific_Notation_Converter
{
    class SciNot
    {
        private int power;
        private double number;
        public SciNot()
        {
            Console.WriteLine("\nEnter your number, and I will put it in Scientific Notation for you!");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nYour number was {0}. Is that correct?", number);
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "Yes" || yesOrNo == "yes")
            {
                if (number >= 10)
                {
                    while (number >= 10)
                    {
                        number /= 10;
                        power += 1;
                    }

                }
                else if (number <= -10)
                {
                    while (number <= -10)
                    {
                        number /= 10;
                        power += 1;
                    }
                }


                if (number < 1 && number > 0)
                {
                    while (number < 1)
                    {
                        number *= 10;
                        power -= 1;
                    }

                    if (number >= 10)
                    {
                        number /= 10;
                        power += 1;
                    }



                }
                else if (number > -1 && number < 0) {
                    while (number > -1) {
                        number *= 10;
                        power += 1;
                        
                    }
                    if (number <= -10) {
                        number /= 10;
                        power -= 1;
                    }
                }

                Console.WriteLine("Your number is {0} times 10 to the {1} power!", number, power);
                Thread.Sleep(3000);

            }
            else {
                SciNot no = new SciNot();
            }
        }
    }

    class Number
    {
        private double number;
        private int power;

        public Number()
        {
            Console.WriteLine("\nWhat is your number? Decimals are allowed, and will calculate normally");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWhat power is it to?");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour number is {0} times 10 to the {1} power. Is this correct?", number, power);
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "Yes" || yesOrNo == "yes")
            {
                if (number <= 10 || number >= -10)
                {
                    if (power > 1)
                    {
                        while (power >= 1)
                        {
                            number *= 10;
                            power -= 1;
                        }
                    }
                    else if (power < 0)
                    {
                        while (power < 0)
                        {
                            number /= 10;
                            power += 1;
                        }

                    }




                }
                Console.WriteLine("Your number in standard form is {0}!", number);
                Thread.Sleep(3000);
            }
            else
            {
                Number no = new Number();
            }
        }

    }

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
