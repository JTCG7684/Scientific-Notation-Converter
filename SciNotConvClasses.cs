﻿using System;
using System.Threading;

namespace Program_Classes {
    class SciNot
    {
        private int power;
        private double number;

        public void SciNotCalculator()
        {
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

                        Console.WriteLine("Your number is {0} times 10 to the {1} power!", number, power);
                        Thread.Sleep(3000);
                        break;

                    }
                    else
                    {
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("\nThat's not a number!");
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
                    Console.WriteLine("Your number in standard form is {0}!", number);
                    Thread.Sleep(3000);
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