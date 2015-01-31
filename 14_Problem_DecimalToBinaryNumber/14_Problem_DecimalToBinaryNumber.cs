﻿using System;
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	binary
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.WriteLine("Decimal To Binary Number");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter a number to convert");
            long input = long.Parse(Console.ReadLine());
            string number = null;
            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    number += "0";
                }
                else
                {
                    number += "1";
                }

                input = input / 2;
            }
            char[] rev = number.ToCharArray();
            Array.Reverse(rev);
            Console.WriteLine(rev);
        }
    }

