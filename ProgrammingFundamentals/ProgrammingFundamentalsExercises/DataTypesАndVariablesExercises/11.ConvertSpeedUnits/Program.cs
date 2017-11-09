using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalseconds = ((((hours * 60) + minutes) * 60) + seconds);

            Console.WriteLine(distanceInMeters / totalseconds);

            float totalHours = hours + (minutes / 60 + ((seconds / 60) / 60));
            float distanceInKm = distanceInMeters / 1000;

            Console.WriteLine(distanceInKm / totalHours);

            float distanceInMiles = distanceInMeters / 1609;

            Console.WriteLine(distanceInMiles / totalHours);
        }
    }
}
