﻿using System;
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, 
//separated by a space.
//Examples:

//n	output
//3	1 2
//10	1 2 4 5 8 10

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int counter = int.Parse(Console.ReadLine());
        for (int i = 0; i <= counter; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }

        }
    }
}

