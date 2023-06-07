using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgPOE2
{
    internal class Recipe
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        List<steps> steps = new List<steps>();
        int calorie;
        string foodgroup;
        int name;
        int Count;
        int recipeName;

        public void EnterDetails() // creation of the different objects and population of necessary data

        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numIngredients; i++)
            {
                Console.Write($"Enter the name of the ingredient {i}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for {name}: ");
                string unit = Console.ReadLine();

                Console.Write($"Enter the amount of calories for this food{name}: ");
                double Calorie = double.Parse(Console.ReadLine());

                Console.Write($"Enter the group of food the ingredient belongs to {name}: ");
                string foodGroup = Console.ReadLine();

                ingredients.Add(new Ingredient { Name1 = name, OriginalQuantity = quantity, Unit1 = unit, Calorie1 = calorie, FoodGroup = foodgroup });

            }


            Console.Write("Enter the number of steps required: ");
            int numSteps = int.Parse(Console.ReadLine());


            string stepdescription = null;
            steps.Add(new steps { StepDescription = stepdescription });

            for (int i = 1; i <= numSteps; i++)
            {
                Console.Write($"Enter step {i}: ");
                string step = Console.ReadLine();

            }

            string Recipename = null;
            RecipeDescription description = new RecipeDescription { Name = Recipename, Ingredients = ingredients, Steps = steps };
        }

        public void Display()
        {
            Console.WriteLine("Recipe: {0}", name);
            Console.WriteLine("Ingredients: ");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine("{0} {1} {2} - Total Calories: {3} - Food Group: {4}", ingredient.OriginalQuantity, ingredient.Unit1, ingredient.Name1, ingredient.Calorie1, ingredient.FoodGroup);
            }
            RecipeDescription.sort((x, y) => string.Compare(x.Name, y.Name));
            for (int i = 0; i < RecipeDescription.Count; i++)
            {
                Console.WriteLine("Recipe " + (i + 1) + ". " + RecipeDescription[i].Name);

                Console.WriteLine("Ingredients: "); // displays message to user
                for (int j = 0; j < RecipeDescription[i].Ingredients.Count; j++)
                {
                    Console.WriteLine((j + 1) + ". " + RecipeDescription[i].Ingredients[j].ToString()); // displays ingredients captured 
                }

                Console.WriteLine("\nsteps: ");
                for (int j = 0; j < RecipeDescription[i].Steps.Count; j++)
                {
                    Console.WriteLine("Step " + (j + 1) + ". " + RecipeDescription[i].Steps[j].ToString());
                }
            }
        }

        public void Scale()
        {
            Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());

            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.OriginalQuantity *= factor;
            }

            Console.WriteLine("Your recipe has been scaled successfully.");
        }

        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }

            Console.WriteLine("Quantities have been set to original.");
        }

        public double TotalCalories()
        {
            double calories = ingredients.Sum(Ingredient => Ingredient.Calorie1);

            if (calories > 300)
            { Console.WriteLine("calories exceed 300!"); }

            return calories;
        }

        static Recipe CreateRecipe()
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();

            Recipe recipe = new Recipe { name = recipeName };

            Console.WriteLine("Enter the details for the recipe:");

            while (true)
            {
                Console.WriteLine("\nIngredient:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity:");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.Write("Unit of Measurement: ");
                string unit = Console.ReadLine();

                Console.Write("Calories: ");
                int calories = Convert.ToInt32(Console.ReadLine());

                Console.Write("Food Group: ");
                string foodGroup = Console.ReadLine();


            }
            while (true)
            {
                Console.WriteLine("\nStep:");
                Console.Write("Description: ");
                string description = Console.ReadLine();

                recipe.steps(description);

                Console.Write("Add another step? (Y/N): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y")
                    break;
            }

            return recipe;
        }

        
    }
}
