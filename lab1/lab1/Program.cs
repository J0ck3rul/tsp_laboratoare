u using System;

namespace lab1
{
    class Program
    {
        public class Prime
        {
            public static int x;
            public bool checkPrime(int number)
            {
                int divisor = 2;
                while (divisor < number)
                {
                    if (number % divisor == 0)
                    {
                        return false;
                    }
                    divisor++;
                }

                return false;
            }

            public void Method1()
            {
                int number = 2;
                int last = 0;
                while (number < x)
                {
                    if (checkPrime(number) == true)
                    {
                        last = number;
                    }

                    number++;
                }

                Console.WriteLine(last);
            }

            public void Method2()
            {
                int number = x - 1;
                while (number > 1)
                {
                    if (checkPrime(number) == true)
                    {
                        Console.WriteLine(number);
                        break;
                    }
                    number++;
                }
            }
        }
    }
}
