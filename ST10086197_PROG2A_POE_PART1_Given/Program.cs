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

    public void ClearRecipe()
    {
        numIngredients = 0;
        numSteps = 0;
    }



    static void Main(String[] args)
    {

    }


}