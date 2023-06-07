using Microsoft.VisualStudio.TestTools.UnitTesting;
using ST10086197_PROG2A_POE_PART2_Given;


namespace CaloriesTest
{
    [TestClass]
    public class TotalCaloriesTest
    {
       //tests to see if the calories total calculation outputs the expected result.
        [TestMethod]
        public void TestGetTotalCalories()
        {
         
            //Arrange
            var recipe = new Recipe();
            recipe.ingredients.Add(new Ingredient { Calories = 100, ingrQuantity = 2 });
            recipe.ingredients.Add(new Ingredient { Calories = 200, ingrQuantity = 1 });

            //Act
            double totalCalories = recipe.GetTotalCalories();

            //Assert
            Assert.AreEqual(300, totalCalories);
        }

       //tests to see if the calories total calculation outputs the expected result when only one ingredient is added.
        [TestMethod]
        public void TestGetTotalCaloriesWithOneIngredient()
        {
            //Arrange
            var recipe = new Recipe();
            recipe.ingredients.Add(new Ingredient { Calories = 100, ingrQuantity = 1 });

            //Act
            double totalCalories = recipe.GetTotalCalories();

            //Assert
            Assert.AreEqual(100, totalCalories);
        }
    }
}


