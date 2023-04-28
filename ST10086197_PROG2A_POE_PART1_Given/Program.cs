﻿using System;

public class Recipe
{

    private int numIngredients;
    private string[] ingredientNames;
    private double[] ingredientQuantities;
    private string[] ingredientUnits;
    private int numSteps;
    private string[] steps;


    public Recipe()
    {
        // sets a value for the varibles, that the program will start with.
        numIngredients = 0;
        numSteps = 0;
    }

    public void SetRecipe(int numIngredients)
    {
        this.numIngredients = numIngredients;
        ingredientNames = new string[numIngredients];
        ingredientQuantities = new double[numIngredients];
        ingredientUnits = new string[numIngredients];

        // loop that takes in user inut for the number of ingredients and prompts this as many times as it appears.
       /* for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("-------INGREDIENTS-------");

            Console.WriteLine("Enter ingredient name:");
            ingredientNames[i] = Console.ReadLine();

            try
            {
                Console.WriteLine("Enter ingredient quantity:");
                ingredientQuantities[i] = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(" ⬆️ ,not an integer/double");
                
            }

            // Console.WriteLine("Enter ingredient unit of measurement:");
            // ingredientUnits[i] = Console.ReadLine();

            Console.WriteLine("-------_______________-------");
        }
       */
        // Use a while loop to prompt the user to enter information for each ingredient
        int r = 0;
        while (r < numIngredients)

        {

            // Ask the user to enter the ingredient name

            Console.WriteLine("Please enter the ingredient name: ");

            ingredientNames[r] = Console.ReadLine();



            // Ask the user to enter the quantity of the ingredient
           
            try
            {
                Console.WriteLine("Enter the quantity of the ingredient: ");

                ingredientQuantities[r] = double.Parse(Console.ReadLine());

                
            }
           

            catch (FormatException)
            {
                Console.WriteLine(" ⬆ ,not an integer/double");

            }


            // prompts user for unit of measurment as well as checks if the unit is correct or not.

            bool correctUnit = false; // boolean to check whether the units are correct or not.

            do

            {

                Console.WriteLine("Please enter the number for the unit of measurement :\r\n 1. teaspoon\r\n 2. tablespoon\r\n 3. cup\r\n 4. quart \r\n 5. units");

                string choice = Console.ReadLine();



                // Use a switch statement to set the unit of measurement based on the user's choice

                if (choice.Equals("1"))

                {
                    ingredientUnits[r] = "teaspoon";

                    correctUnit = true;
                }

                else if (choice.Equals("2"))

                {
                    ingredientUnits[r] = "tablespoon";

                    correctUnit = true;
                }

                else if (choice.Equals("3"))

                {
                    ingredientUnits[r] = "cup";

                    correctUnit = true;
                }

                else if (choice.Equals("4"))

                {
                    ingredientUnits[r] = "quart";

                    correctUnit = true;
                }

                else if (choice.Equals("5"))

                {
                    ingredientUnits[r] = "units";

                    correctUnit = true;
                }

                else {

                    Console.WriteLine("Incorrect selection, try again.");
                }

            } while (correctUnit != true);

            r++;

        }

    }


        public void SetSteps(int numSteps)
    {
        this.numSteps = numSteps;
        steps = new string[numSteps];

        // for loop that goes over the amount of steps you have specified.
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Enter step {i + 1}:");
            steps[i] = Console.ReadLine();
        }
    }


    // method to display the recipe.
    public void DisplayRecipe()
    {
        Console.WriteLine("");
        Console.WriteLine("----------Recipe:---------------");
        Console.WriteLine("");
        Console.WriteLine("--------Ingredients:--------");
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"{ingredientNames[i]} - {ingredientQuantities[i]} {ingredientUnits[i]}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
    }

    // scales the recipe depending on the users preference
    public void ScaleRecipe(double factor)
    {
        for (int i = 0; i < numIngredients; i++)
         {
             ingredientQuantities[i] *= factor;

         }
        

        
            string[] unitOfMeasurement = { "teaspoon", "tablespoon", "cup", "quart" };

            for (int i = 0; i < numIngredients; i++)
            {
                double quantity = ingredientQuantities[i] * factor;
                string unit = ingredientUnits[i];

                if (unit == unitOfMeasurement[0] && quantity <= 3)
                {
                    double tablespoons = quantity / 3;
                    double teaspoonsRemaining = quantity % 3;


                    if (tablespoons >= 16)
                    {
                        double cups = tablespoons / 16;
                        double tablespoonsRemaining = tablespoons % 16;

                        if (cups >= 4)
                        {
                            double quarts = cups / 4;
                            double cupsRemaining = cups % 4;

                            if (cupsRemaining > 0)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}", Math.Floor(quarts), "quart", Math.Floor(cupsRemaining), "cup", Math.Floor(tablespoonsRemaining), "tablespoon");
                            }
                            else
                            {
                                Console.WriteLine("{0} {1}", Math.Floor(quarts), "quart");
                            }
                        }
                        else if (tablespoonsRemaining > 0)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", Math.Floor(cups), "cup", Math.Floor(tablespoonsRemaining), "tablespoon");
                        }
                        else
                        {
                            Console.WriteLine("{0} {1}", Math.Floor(cups), "cup");
                        }
                    }
                    else if (teaspoonsRemaining > 0)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", Math.Floor(tablespoons), "tablespoon", Math.Floor(teaspoonsRemaining), "teaspoon");
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", Math.Floor(tablespoons), "tablespoon");
                    }
                }


            if (unit == unitOfMeasurement[1] && quantity >= 16)
                {
                    double cups = quantity / 16;
                    double tablespoonsRemaining = quantity % 16;

                    if (cups >= 4)
                    {
                        double quarts = cups / 4;
                        double cupsRemaining = cups % 4;

                        if (cupsRemaining > 0)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", Math.Floor(quarts), "quart", Math.Floor(cupsRemaining), "cup");
                        }
                        else
                        {
                            Console.WriteLine("{0} {1}", Math.Floor(quarts), "quart");
                        }
                    }


                     if (tablespoonsRemaining > 0)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", Math.Floor(cups), "cup", Math.Floor(tablespoonsRemaining), "tablespoon");
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", Math.Floor(cups), "cup");
                    }
                }

            }


        


    }




     public void ResetQuantities()
    {
        // sets all of the following to their default values.
        numIngredients = 0;
        ingredientNames = new string[0];
        ingredientQuantities = new double[0];
        ingredientUnits = new string[0];
        numSteps = 0;
        steps = new string[0];
    }

    // clears all of the variables in Recipe.
    public void ClearRecipe()
    {
        numIngredients = 0;
        numSteps = 0;
    }



    static void Main(String[] args)
    {
        Recipe recipe = new Recipe();


        Console.WriteLine("-------RECIPE_APP-------");

        Console.WriteLine("Enter the number of ingredients:");
        int numIngredients = int.Parse(Console.ReadLine());
        recipe.SetRecipe(numIngredients);

        Console.WriteLine("");

        Console.WriteLine("Enter the number of steps:");
        int numSteps = int.Parse(Console.ReadLine());
        recipe.SetSteps(numSteps);

        Console.WriteLine("----------Recipe:---------------");
        recipe.DisplayRecipe();

        Console.WriteLine("");

        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("Enter scale factor (0.5 (half), 1 (original), 2 (double), or 3 (triple)):");
        double scaleFactor = double.Parse(Console.ReadLine());
        recipe.ScaleRecipe(scaleFactor);
        Console.WriteLine($"Recipe scaled by a factor of {scaleFactor}:");
        recipe.DisplayRecipe();
    }


}