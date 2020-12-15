using System;

namespace ExtraTask_001
{
    class Program
    {
        static void DefineRectangleSize(out int height, out int width)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please Set Rectangle height:");
                string heightString = Console.ReadLine();
                Console.WriteLine("Please select rectangle width:");
                string widthString = Console.ReadLine();

                if (!int.TryParse(heightString, out height) || (!int.TryParse(widthString, out width)) || height <= 0 || width <= 0)
                {
                    Console.WriteLine("Wrong input");
                }
                else break;

            }
            Console.Write("\n");
        }

        static void DrawRectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write("*");
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int height, width;
            DefineRectangleSize(out height, out width);
            DrawRectangle(height, width);

            //Delay
            Console.ReadKey();
        }
    }
}
