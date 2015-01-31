using System;
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:

//n	trailing zeroes of n!	explaination
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why


    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.Write("Please, enter integer number N: ");
            int n = int.Parse(Console.ReadLine());

            int trailingZero = 0;

            for (int power5 = 5; power5 <= n; power5 *= 5)
            {
                trailingZero += n / power5;
            }

            Console.WriteLine("{0}! has {1} trailing zeros"
                                , n, trailingZero);
        }
    }

