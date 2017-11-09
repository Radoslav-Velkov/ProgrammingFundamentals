using System;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            int centure = int.Parse(Console.ReadLine());

            int intoYears = centure * 100;
            double intoDays = Math.Floor(intoYears * 365.2422);
            double intoHours = intoDays * 24;
            double intoMinutes = intoHours * 60;
            double intoSeconds = intoMinutes * 60;
            decimal intoMiliseconds = (decimal)intoSeconds * 1000;
            decimal intoMicroseconds = intoMiliseconds * 1000;
            decimal intoNanoseconds = intoMicroseconds * 1000;

            Console.WriteLine($"{centure} centuries = {intoYears} years = {intoDays} days = {intoHours} hours = {intoMinutes} minutes = {intoSeconds} seconds = {intoMiliseconds} milliseconds = {intoMicroseconds} microseconds = {intoNanoseconds} nanoseconds");
        }
    }
}