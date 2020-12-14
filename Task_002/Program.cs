using System;
using System.Threading;

namespace Task_002
{
    class Program
    {
        static void SetValues(out int firstValue, out int secondValue)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter First Value");
                string userInputFirst = Console.ReadLine();
                Console.WriteLine("Enter Second Value");
                string userInputSecond = Console.ReadLine();
                if ((!int.TryParse(userInputFirst, out firstValue)) || (!int.TryParse(userInputSecond, out secondValue)) || (secondValue < firstValue))
                {
                    Console.WriteLine("Wrong Input. You typed incorrect numbers or second value is smaller than first value...");
                    Console.WriteLine("Hit Enter to type again");
                    Console.ReadKey();
                }
                else break;
            }
        }

        public static void ShowSumAndOddValues(int firstValue, int secondValue)
        {
            int summOfValues = default;

            for (int i = firstValue + 1; i < secondValue; i++)
            {
                summOfValues += i;
            }

            Console.WriteLine($"Summ of values is {summOfValues}");
            Console.WriteLine($"odd values between {firstValue} and {secondValue} are ...");

            for (int i = firstValue + 1; i < secondValue; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            int firstValue, secondValue;
            SetValues(out firstValue, out secondValue);
            ShowSumAndOddValues(firstValue, secondValue);

            //delay
            Console.ReadLine();
        }
    }
}
