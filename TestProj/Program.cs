﻿using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int n = numbers.Length;
            int k = n / 2;
            int temp = default;

            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[i - 1] = temp;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // delay
            Console.ReadLine();
        }
    }
}
