using System;
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//binary	decimal
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Binary to decimal");
            Console.WriteLine("-----------------");
            Console.Write("Enter a number to convert n = ");
            long num = 0;
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[input.Length - i - 1] == '0')
                {
                    continue;
                }
                num += (long)Math.Pow(2, i);

            }
            Console.WriteLine(num);
        }
    }

