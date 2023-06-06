using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ST10086197_PROG2A_POE_PART1_Given
{
    public class Program
    {

        

        public static void inputRecipe(SortedList<string, Recipe> recipes)
        {

            // Get recipe input from the user.
            
            Console.WriteLine("Enter the name of the recipe: ");
            string name = Console.ReadLine();

            //prompt user to enter ingredients
            Console.WriteLine("Enter the number of ingredients: ");
            int numberOfIngredients = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < numberOfIngredients; i++)
            {
                Console.WriteLine("Ingredient name: ");
                string ingredientName = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Ingredient quantity: ");
                int ingredientQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                
                Console.WriteLine("Ingredient unit of measurement: ");
                string ingredientUnitOfMeasurement = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Ingredient calories: ");
                int ingredientCalories = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Ingredient food group: ");
                string ingredientFoodGroup = Console.ReadLine();
                Console.WriteLine("");

                if (recipes.ContainsKey(name))
                {
                    recipes[name].ingredients.Add(
                        new Ingredient
                        {
                            ingrName = ingredientName,
                            ingrQuantity = ingredientQuantity,
                            ingrUnitOfMeasurement = ingredientUnitOfMeasurement,
                            Calories = ingredientCalories,
                            FoodGroup = ingredientFoodGroup
                        });
                }
                else
                {
                    Recipe recipe = new Recipe()
                    {
                        recipeName = name,
                        ingredients = new List<Ingredient>()
                        {
                            new Ingredient
                            {
                                ingrName = ingredientName,
                                ingrQuantity = ingredientQuantity,
                                ingrUnitOfMeasurement = ingredientUnitOfMeasurement,
                                Calories = ingredientCalories,
                                FoodGroup = ingredientFoodGroup
                            }
                        }
                    };
                    recipes.Add(name, recipe);
                }
            }

            // Get instructions input from the user.
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter the number of Steps: ");
            Console.ForegroundColor = ConsoleColor.White;
            int numberOfSteps = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfSteps; i++)
            {
                Console.WriteLine("Step " + (i + 1) + ": ");
                string step = Console.ReadLine();
                recipes[name].Steps.Add(step);
            }

        }

        

        static void Main(String[] args)
        {

            // Create a sorted list of recipes.
            SortedList<string, Recipe> recipes = new SortedList<string, Recipe>();

            

            // display informational text
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------RECIPE_APP-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            //gets recipe input from user.
            inputRecipe(recipes);



 // display informational text
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------Recipe:---------------");
            Console.ForegroundColor = ConsoleColor.White;


            //Display the recipe

            
            // Display the list of recipe names
            Console.WriteLine("List of Recipe Names:");
            foreach (var list in recipes.Keys)
            {
                Console.WriteLine(list);
            }

            // Select a recipe to display.
            Console.WriteLine("Enter the name of the recipe to display: ");
            string recipeName = Console.ReadLine();
            Recipe recipe = recipes[recipeName];

            Console.WriteLine("-------------------------------------------");
            // Run the Display method.
            recipe.DisplayRecipe();

            Console.WriteLine("");

            Console.WriteLine("-------------------------------------------");

            

            // Scale the recipe
            Console.WriteLine("Do you want to scale the recipe? (Y/N) ");
            string response = Console.ReadLine();
            if (response == "Y")
            {
                Console.WriteLine("Enter the scale factor (0.5 (half), 2 (double), or 3 (triple)): ");
                double scaleFactor = Convert.ToDouble(Console.ReadLine());
                recipe.ScaleRecipe();
                recipe.DisplayRecipe();
            }


            // Reset the recipe.
            Console.WriteLine("Do you want to reset the recipe? (Y/N) ");
            response = Console.ReadLine();
            if (response == "Y")
            {
                recipe.ResetQuantities();
                recipe.DisplayRecipe();
            }
            /* Console.WriteLine("Enter scale factor (0.5 (half), 1 (original), 2 (double), or 3 (triple)):");
             double scaleFactor = double.Parse(Console.ReadLine());
             recipe.ScaleRecipe(scaleFactor);


             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine($"Recipe scaled by a factor of {scaleFactor}:");
             Console.ForegroundColor = ConsoleColor.White;
             recipe.DisplayRecipe();



             recipe.begin();

             */

        }

       

    }
   

}
