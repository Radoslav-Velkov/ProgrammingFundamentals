using System;

namespace _09.Count_the_Integ
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            try
            {
                for (int i = 0; i < 102; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(count);
            }
        }
    }
}