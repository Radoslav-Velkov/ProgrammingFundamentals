﻿using System;
using System.Linq;

namespace _11.EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            bool indexIsFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    indexIsFound = true;
                    break;
                }
            }

            if (!indexIsFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
