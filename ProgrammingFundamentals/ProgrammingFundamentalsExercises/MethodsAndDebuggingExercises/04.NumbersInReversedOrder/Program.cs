using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }
    }
}
