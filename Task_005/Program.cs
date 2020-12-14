using System;

namespace Task_005
{
    class Program
    {
        static void DefineSymbols(out int height, out int width, out string symbol) 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter height Value");
                string userInputFirst = Console.ReadLine();
                Console.WriteLine("Enter width Value");
                string userInputSecond = Console.ReadLine();
                if ((!int.TryParse(userInputFirst, out height)) || (!int.TryParse(userInputSecond, out width)))
                {
                    Console.WriteLine("Wrong Input...");
                    Console.WriteLine("Hit Enter to type again");
                    Console.ReadKey();
                }
                else break;
            }

            Console.WriteLine("Please define symbol...");
            symbol = Console.ReadLine();
        }
        static void DrawFigure(int height, int width, string symbol) 
        {

        }

        static void Main(string[] args)
        {
            int height, width;
            string symbol;
            DefineSymbols(out height, out width, out symbol);
            DrawFigure(height, width, symbol);

            //Delay
            Console.ReadKey();
        }
    }
}
