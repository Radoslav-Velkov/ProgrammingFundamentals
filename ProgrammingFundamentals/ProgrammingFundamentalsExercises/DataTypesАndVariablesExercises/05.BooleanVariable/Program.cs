using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            bool convert = (Convert.ToBoolean(text));

            if (convert)
            {
                Console.WriteLine($"Yes");
            }
            else
            {
                Console.WriteLine($"No");
            }
        }
    }
}
