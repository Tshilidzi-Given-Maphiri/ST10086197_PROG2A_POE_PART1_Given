using System;

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

    public void SetIngredients(int numIngredients)
    {
        this.numIngredients = numIngredients;
        ingredientNames = new string[numIngredients];
        ingredientQuantities = new double[numIngredients];
        ingredientUnits = new string[numIngredients];

        // loop that takes in user inut for the number of ingredients and prompts this as many times as it appears.
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("-------INGREDIENTS-------");

            Console.WriteLine("Enter ingredient name:");
            ingredientNames[i] = Console.ReadLine();

            Console.WriteLine("Enter ingredient quantity:");
            ingredientQuantities[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter ingredient unit of measurement:");
            ingredientUnits[i] = Console.ReadLine();

            Console.WriteLine("-------_______________-------");
        }
    }

    public void SetSteps(int numSteps)
    {
        this.numSteps = numSteps;
        steps = new string[numSteps];

        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Enter step {i + 1}:");
            steps[i] = Console.ReadLine();
        }
    }

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
        recipe.SetIngredients(numIngredients);
    }


}