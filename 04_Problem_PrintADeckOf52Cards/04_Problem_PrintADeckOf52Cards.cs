using System;
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds
//Note: You may use the suit symbols instead of text.
class PrintADeckOf52Cards
{
    static void Main()
    {
        char heart = '\u2665';
        char diamond = '\u2666';
        char spades = '\u2660';
        char clubs = '\u2663';
        for (int i = 2; i <= 14; i++)
        {
            Console.WriteLine();
            for (int k = 1; k <= 4; k++)
            {
                switch (i)
                {
                    case 2: Console.Write("2"); break;
                    case 3: Console.Write("3"); break;
                    case 4: Console.Write("4"); break;
                    case 5: Console.Write("5"); break;
                    case 6: Console.Write("6"); break;
                    case 7: Console.Write("7"); break;
                    case 8: Console.Write("8"); break;
                    case 9: Console.Write("9"); break;
                    case 10: Console.Write("T"); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;

                    default: Console.WriteLine("Error!"); break;

                }
                switch (k)
                {
                    case 1: Console.Write("{0} ", heart); break;
                    case 2: Console.Write("{0} ", diamond); break;
                    case 3: Console.Write("{0} ", spades); break;
                    case 4: Console.Write("{0} ", clubs); break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
        }

    }
}

//This is how it will look If we use Arrays.


//using System;

//    class PrintADeckOf52Cards
//    {
//        static void Main()
//        {
//            string[] suits = new string[] { "hearts", "spades", "diamonds", "clubs" };
//            string[] ranks = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

//            for (int card = 0; card < 13; card++)
//            {
//                for (int suit = 0; suit < 4; suit++)
//                {
//                    Console.Write("{0} of {1}, ",ranks[card],suits[suit]);
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}