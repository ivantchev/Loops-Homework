using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:

//n	randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.



    class RandomizeNumbers
    {
        static void Main()
        {
            int n, userMin, userMax, i;
            Random random = new Random();
            Console.WriteLine("This program is random");

            //This part validates the user input
            Console.Write("Set the max number value: ");
            while (!int.TryParse(Console.ReadLine(), out userMax) || userMax <= 1)
            {
                Console.Write("Please use numeric values!(the Max cannot be lower or equal then 1): ");
            }

            Console.WriteLine();
            Console.WriteLine("Here's some random numbers!");
            //This for loop will run the random gen for as many times as it takes for 1 to reach the user selected number
            for (i = 0; i < userMax; i++)
            {
                Console.Write("{0,-5}", random.Next(1, userMax + 1));
            }
            Console.WriteLine("Good Job :D");
        }
    }

