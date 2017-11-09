using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main()
        {
            int numOfIngredients = 0;

            for (int i = 0; i < 1;)
            {
                string ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numOfIngredients} ingredients.");
                    break;
                }
                else
                {
                    numOfIngredients++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
        }
    }
}