using System;

namespace ST10086197_PROG2A_POE_PART1_Given
{
    public class Program
    {
        static void Main(String[] args)
        {
            Recipe recipe = new Recipe();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------RECIPE_APP-------");
            Console.ForegroundColor = ConsoleColor.White;





            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------Recipe:---------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());
            recipe.SetRecipe(numIngredients);

            Console.WriteLine("");

            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());
            recipe.SetSteps(numSteps);



            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------Recipe:---------------");
            Console.ForegroundColor = ConsoleColor.White;
            recipe.DisplayRecipe();


            Console.WriteLine("");

            Console.WriteLine("-------------------------------------------");



            Console.WriteLine("Enter scale factor (0.5 (half), 1 (original), 2 (double), or 3 (triple)):");
            double scaleFactor = double.Parse(Console.ReadLine());
            recipe.ScaleRecipe(scaleFactor);


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Recipe scaled by a factor of {scaleFactor}:");
            Console.ForegroundColor = ConsoleColor.White;
            recipe.DisplayRecipe();



            recipe.begin();

        }
    }
   

}
