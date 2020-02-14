using System;
using System.Threading;

namespace Program_Classes {
    class SciNot
    {
        private int power;
        private double number;

        public void SciNotCalculator()
        {
            Console.ResetColor();
            while (true)
            {
                Console.WriteLine("\nEnter your number, and I will put it in Scientific Notation for you!");
                try
                {
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
                        else if (number > -1 && number < 0)
                        {
                            while (number > -1)
                            {
                                number *= 10;
                                power += 1;

                            }
                            if (number <= -10)
                            {
                                number /= 10;
                                power -= 1;
                            }
                        }


                        
                        Console.ResetColor();
                        Console.Write("\nYour number is ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{0} ", number);
                        Console.ResetColor();
                        Console.Write("times 10 to the ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{0} ", power);
                        Console.ResetColor();
                        Console.Write("power!");
                        Thread.Sleep(3000);
                        Console.WriteLine("\n============================================================");
                        break;

                    }
                    else
                    {
                        continue;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError! If you didn't answer with a number, make sure you do!");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    continue;
                }
            }

        }
    }

    class Number
    {
        
        private double number;
        private int power;

        public void NumberCalculator()
        {
            Console.ResetColor();
            while (true) {
                Console.WriteLine("\nWhat is your number? Decimals are allowed, and will calculate normally");
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("\nThat's not a number!");
                    Thread.Sleep(1000);
                    continue;
                }
                Console.WriteLine("\nWhat power is it to? (Note: If you input a decimal, I will round it.)");
                try
                {
                    power = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("That's not a number!");
                    Thread.Sleep(1000);
                    continue;
                }
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
                    Console.ResetColor();
                    Console.Write("\nYour number in standard form is ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0}", number);
                    Console.ResetColor();
                    Console.Write("!");
                    Thread.Sleep(3000);
                    Console.WriteLine("\n============================================================");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

    }
}