﻿using System;
using System.Text;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            StringBuilder solution = new StringBuilder();
            foreach (char c in word)
            {
                solution.AppendFormat("\\u{0:x4}", (int)c);
            }

            Console.WriteLine(solution);
        }
    }
}