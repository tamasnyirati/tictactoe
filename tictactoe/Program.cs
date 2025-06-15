using System;
using System.Drawing;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string notCorrect = "How big field do you want to play? (3-9) ";
            Console.WriteLine("TicTacToe Console Game");
            Console.Write(notCorrect);
           
            int size = Convert.ToInt32(Console.ReadLine());

            if (size < 3 || size > 9)
            {
                Console.WriteLine(notCorrect);
            }
            
            else
            {
                char [,] field = new char[size, size];
                
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        field[i, j] = ' ';
                    }
                }

                //draw field
                for (int i = 0;i < size; i++)
                {
                    for(int j = 0;j < size; j++)
                    {
                        Console.Write($"| {field[i, j]} ");
                    }
                    Console.WriteLine('|');
                }
            }
        }
    }

}


