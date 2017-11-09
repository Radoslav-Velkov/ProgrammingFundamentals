using System;

namespace _03.PracticeCharsAndStrings
{
    class Program
    {
        static void Main()
        {
            string one = Console.ReadLine();
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            char four = char.Parse(Console.ReadLine());
            string fifth = Console.ReadLine();

            Console.WriteLine($"{one}");
            Console.WriteLine($"{second}");
            Console.WriteLine($"{third}");
            Console.WriteLine($"{four}");
            Console.WriteLine($"{fifth}");
        }
    }
}
