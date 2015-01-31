using System;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) 
//is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	k	n! / (k! * (n-k)!)
//3	2	3
//4	2	6
//10	6	210
//52	5	2598960
class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter value of N > 1");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of K<n<100");
        double k = double.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;

        if (1 < k && n > k && n < 100)
        {
            for (double i = k + 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (double j = 1; j <= (n - k); j++)
            {
                factorialK *= j;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        double result = factorialN / factorialK;
        Console.WriteLine("N! / K!(N-K)! = {0}", result);
    }
}

