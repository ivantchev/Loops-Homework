using System;
//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter a positivei integer number N [1:20]: ");
        double n = double.Parse(Console.ReadLine());

        if (n > 0 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("{0,2} ", column + row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number must be bigger than 0 and lesser than 21");
        }
    }
}

