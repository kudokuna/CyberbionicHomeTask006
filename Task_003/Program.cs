using System;

namespace Task_003
{
    class Program
    {
        public static void DrawFigures()
        {
            Console.WriteLine("Draw figure 1 -- rectangle");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
            }

            Console.WriteLine("\n Draw figure 2 -- right triangle\n");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                    Console.Write('*');
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n Draw figure 3 -- right triangle\n");
            {
                int i = 1;
                while (i <= 5)
                {
                    int k = 5;
                    int h = 1;

                    Console.Write("\n");
                    while (k > i)
                    {
                        Console.Write(" ");
                        k--;
                    }
                    while (h <= i)
                    {
                        Console.Write("*");
                        Console.Write("*");
                        h++;
                    }
                    i++;
                }
            }
        }

            static void Main(string[] args)
        {
            DrawFigures();

            // Delay
            Console.ReadKey();
        }
    }
}
