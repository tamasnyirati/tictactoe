using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string notCorrect = "How big field do you want to play? (3-9) ";
            Console.WriteLine("TicTacToe Console Game");
            Console.Write(notCorrect);
            string value = Console.ReadLine();
            int result = Convert.ToInt32(value);
            int[] fieldArr = new int[result];

            if (value == null) { Console.WriteLine(notCorrect); }
            else if (result < 3) { Console.WriteLine(notCorrect); }
            else if (result > 9) { Console.WriteLine(notCorrect); }
            else
            {
                for (int i = 0; i < result; i++)
                {
                    Console.WriteLine('*');
                    for (int j = 0; j < result; j++)
                    {
                        Console.WriteLine(' ');
                    }

                }
            }
        }
    }

}
