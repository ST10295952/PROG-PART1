using System;

class Recipe
{
    private Ingredient[] ingredients; // store ingredients
    private Step[] steps;             // store steps

    // Constructor to initialize given number of ingredients and steps
    public Recipe(int NumIngredients, int NumSteps)
    {
        ingredients = new Ingredient[NumIngredients];
        steps = new Step[NumSteps];
    }

    // Method enter ingredients for the recipe
    public void EnterIngredients()
    {
        Console.WriteLine("Please Enter ingredients:");
        for (int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine($"Ingredient {i + 1}: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Unit: ");
            string unit = Console.ReadLine();

            ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }
    }
    // Method to display details of a recipe
    public void DisplayRecipeDetails(string recipeName)
    {
        Recipe recipe = recipes.FirstOrDefault(r => r.Name == recipeName);
        if (recipe != null)
        {
            Console.WriteLine($"\nRecipe: {recipe.Name}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}, Calories: {ingredient.Calories}, Food Group: {ingredient.FoodGroup}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipe.Steps[i].Description}");
            }
            int totalCalories = recipe.CalculateTotalCalories();
            Console.WriteLine($"Total Calories: {totalCalories}");
            if (totalCalories > 3000)
            {
                CaloriesExceeded?.Invoke(recipe.Name, totalCalories);
            }
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }
}

// Method to enter steps for the recipe
public void EnterSteps()
    {
        Console.WriteLine("\nEnter Recipe steps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"Step {i + 1}:");
            Console.Write("Description: ");
            string description = Console.ReadLine();

            steps[i] = new Step { Description = description };
        }
    }

    // Method to display the recipe
    public void DisplayRecipe()
    {
        Console.WriteLine("\nRecipe:");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }
        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
        }
    }

    // Method to ddouble scale 
    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    // Method to reset ingredient quantities
    public void ResetQuantities()
    {
         //Reset quantities to original values
        // (Assuming original quantities are stored elsewhere)
    }

    // Method to clear data in the recipe
    public void ClearRecipe()
    {
        // Clear all data
        ingredients = new Ingredient[ingredients.Length];
        steps = new Step[steps.Length];
    }
// Method to calculate total calories of the recipe
public int CalculateTotalCalories()
{
    return Ingredients.Sum(i => i.Calories);
}
}
}
public class RecipeManager
{
    // Method to get recipes from the user
    public static List<string> GetRecipes()
    {
        {
    private List<Recipe> recipes;       // List to store recipes

    // Delegate for notification
    public delegate void NotifyExceedCalories(string recipeName, int totalCalories);

    // Event to notify when total calories exceed a threshold
    public event NotifyExceedCalories CaloriesExceeded;

    // Constructor to initialize recipe manager
    public RecipeManager()
    {
        recipes = new List<Recipe>();
    }

    // Method to add a new recipe
    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }
    recipes.Add(recipe);
        }

        return recipes;
    }
}


