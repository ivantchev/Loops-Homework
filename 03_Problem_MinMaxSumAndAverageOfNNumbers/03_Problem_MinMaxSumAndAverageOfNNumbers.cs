using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:

//input	output
//3	min = 1
//2	max = 5
//5	sum = 8
//1	avg = 2.67
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter how many numbers will be the sequence");
            double count = double.Parse(Console.ReadLine());

            double input;
            double sum = 0;
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;

            for (double i = 1; i <= count; i++)
        {
            Console.WriteLine("Enter the {0} number", i);
            input = double.Parse(Console.ReadLine());

            sum += input;
            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
        }
        double average = (double)sum / (double)count;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3 :F2}"
                            , minValue, maxValue, sum, average);
            }
            


        }
    