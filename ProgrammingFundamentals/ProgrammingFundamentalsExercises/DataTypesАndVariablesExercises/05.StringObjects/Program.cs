using System;

namespace _06.StringObjects
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object obj = hello + " " + world;
            string result = (string)obj;
            Console.WriteLine(result);
        }
    }
}
