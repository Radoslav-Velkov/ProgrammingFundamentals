using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        public static void Main(string[] args)
        {
            char s = char.Parse(Console.ReadLine());

            if ((s == 'a') || (s == 'e') || (s == 'i') || (s == 'o') || (s == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else if ((s >= '0') && (s <= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}