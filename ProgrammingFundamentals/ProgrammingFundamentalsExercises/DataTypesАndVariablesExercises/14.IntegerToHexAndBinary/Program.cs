using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Convert.ToString(n, 16).ToUpper()}");
            Console.WriteLine($"{Convert.ToString(n, 2)}");
        }
    }
}
