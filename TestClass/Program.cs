public class RecipeTests
{
    
    public void Calculate_Total_Calories_()
    {
        // Arrange
        RecipeDescription recipe = new RecipeDescription();
        recipe.Quantity_Of_Ingredient = new List<double> { 50, 100, 200 }; // original amounts
        double expectedTotalCalories = 450; // Expected total calories

        // Act
        double actualTotalCalories = recipe.Calculate_Total_Calories();

        // Assert
        Assert.AreEqual(expectedTotalCalories, actualTotalCalories);
    }
}
