using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string notCorrect = "How big field do you want to play? (3-9)";
            Console.WriteLine("TicTacToe Console Game");
            Console.Write(notCorrect);
            string value = Console.ReadLine();
            int result = Convert.ToInt32(value);
            if (value == null)
            {
                Console.WriteLine(notCorrect);
            }
            else
            {
                 if (result < 3) { Console.WriteLine(notCorrect); }
            }
            
        }
    }
}