using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:

//a	b	GCD(a, b)
//3	2	1
//60	40	20
//5	-15	5
//Problem 18.* Trail
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("GCD: " + GCD(first, second));
        }

        static int GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }
    }

