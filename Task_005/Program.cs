using System;

namespace Task_005
{
    class Program
    {

        static void DefineRectangleSize(out int height, out int width, out char symbol)
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
                } else break;
                
            }
            
            Console.WriteLine("Please type symbol for paint rectangle:");
            symbol = Console.ReadKey().KeyChar;
        }

        static void DrawRectangle(int coordX, int coordY, int height, int width, char symbol)
        {
            Console.Clear();
            for (int i = 0; i < width + coordY; i++)
            {
                for (int j = 0; j < height + coordX; j++)
                {
                    if (i < coordY || j < coordX)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(symbol);
                    }
                }

                Console.Write("\n");
            }
        }

        static void MoveRectangleViaSpider(int coordinateX, int coordinateY, int height, int width, char symbol) 
        {

            for (; ; )
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.Escape)
                {
                    break;
                }

                switch (keyPressed)
                {
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        coordinateX += 1;
                        DrawRectangle(coordinateX, coordinateY, height, width, symbol);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        coordinateX = coordinateX - 1 < 0 ? 0 : coordinateX - 1;
                        DrawRectangle(coordinateX, coordinateY, height, width, symbol);
                        break;
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        coordinateY = coordinateY - 1 < 0 ? 0 : coordinateY - 1;
                        DrawRectangle(coordinateX, coordinateY, height, width, symbol);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        coordinateY += 1;
                        DrawRectangle(coordinateX, coordinateY, height, width, symbol);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }



        static void Main(string[] args)
        {
            int coordinateX = default;
            int coordinateY = default;
            int height;
            int width;
            char symbol;

            DefineRectangleSize(out height, out width, out symbol);
            DrawRectangle(coordinateX, coordinateY, height, width, symbol);
            MoveRectangleViaSpider(coordinateX, coordinateY, height, width, symbol);

        }

    }
}