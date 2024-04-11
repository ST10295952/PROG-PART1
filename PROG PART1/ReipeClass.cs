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
}


