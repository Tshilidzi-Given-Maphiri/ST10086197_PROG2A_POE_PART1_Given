using System;
using System.Xml.Linq;

namespace ST10086197_PROG2A_POE_PART1_Given
{
    public class Recipe
    {
        // 
        public string recipeName { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<string> steps { get; set; }
        public double ScaleFactor { get; set; }




        public Recipe()
        {
            ingredients = new List<Ingredient>();
            steps = new List<string>();
            // sets a value for the varibles, that the program will start with.
            ScaleFactor = 1.0;
            
            
        }

        public void addIngredients(string name, int quantity, string unitOfMeasurement, int calories, string foodGroup)
        {
            // adds a recipe to the list
            ingredients.Add(new Ingredient()
            {
                // adds the ingredients taking in the variables from the ingredients class.
                ingrName = name,
                ingrQuantity = quantity,
                ingrUnitOfMeasurement = unitOfMeasurement,
                Calories = calories,
                FoodGroup = foodGroup

            });


        }


        public void SetSteps(string step)
        {
            // adds the string step to the list when method is run.
            steps.Add(step);
        }


        // scales the recipe depending on the users preference
        public void ScaleRecipe()
        {
          
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredients[i].ingrQuantity *= Convert.ToInt32(ScaleFactor);
            }

        }


        public void ResetQuantities()
        {
            // sets all of the following to their default values.
            // Reset the quantities to their original values

            ScaleFactor = 1.0;
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredients[i].ingrQuantity = 1;
            }
        }



        // method to display the recipe.
        public void DisplayRecipe()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------Recipe:---------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Recipe Name: " + recipeName);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------Ingredients:--------");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine("- " + ingredient.ingrName + " " + ingredient.ingrQuantity + " " + ingredient.ingrUnitOfMeasurement + " (" + ingredient.Calories + " calories)");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--Instructions:--");
            Console.ForegroundColor = ConsoleColor.White;


            foreach (var instruction in steps)
            {
                Console.WriteLine("- " + instruction);
            }


            Console.WriteLine("");
            Console.WriteLine("Total calories: " + GetTotalCalories());

            Console.WriteLine("-------------------------------------------");


        }


        public double GetTotalCalories()
        {
            double totalCalories = 0;
            foreach (var ingredient in ingredients)
            {
                totalCalories += ingredient.Calories * ingredient.ingrQuantity;
            }
            return totalCalories;
        }


        // clears all of the variables in Recipe.
        public void ClearRecipe()
        {
            // find a way to delete recipe based ontheir name.

           /* numIngredients = 0;
            ingredientNames = new string[0];
            ingredientQuantities = new double[0];
            ingredientUnits = new string[0];
            numSteps = 0;
            steps = new string[0];

            begin();
           */
        }

        public void begin()
        {
            // prompts user and shows example of value type to enter
            Console.WriteLine("Enter an appropraite number below: \r\n 1. New Recipe\r\n 2. Display Recipe\r\n 3. Clear Recipe\r\n 4.Exit");
            string choiceEntry = Console.ReadLine();


            while (choiceEntry != "4")
            {

                if (choiceEntry == "1")
                {
                    //Main();
                    break;
                }
                else if (choiceEntry == "2")
                {
                    DisplayRecipe();
                    break;
                }
                else if (choiceEntry == "3") //  quits the application.
                {
                    ClearRecipe();
                    break;
                }

            }

            if (choiceEntry != "4")
            {
                Console.WriteLine("See you Soon! ✋");
                Environment.Exit(-1);

            }
        }




    }
}

