using System;

namespace Task_004
{
    class Program
    {
        static void FindCLients(out int clients) 
        {
            while (true)
            {
                Console.WriteLine("Eneter amount of clients");
                if (!int.TryParse(Console.ReadLine(), out clients))
                {
                    Console.WriteLine("Wrong input...");
                }
                else break;
            }
        }

        static int FindAllRoutes(int clientsAmount) 
        {
            int counter = 1;
            int result = 1;

            if (clientsAmount == 0) 
            {
                return result;
            }

            do
            {
                result *= counter;
                counter++;
                

            } while (counter <= clientsAmount);

            return result;
        }
        static void Main(string[] args)
        {
            int clientsAmount;
            FindCLients(out clientsAmount);
            Console.WriteLine(FindAllRoutes(clientsAmount).ToString());

            //Delay 
            Console.ReadKey();
        }
    }
}
