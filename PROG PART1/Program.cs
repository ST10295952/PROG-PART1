using System;

namespace ConsoleRecipeApplication
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Add Recipe");
                Console.WriteLine("2. Display Recipe List");
                Console.WriteLine("3. Display Recipe Details");
                Console.WriteLine("4. Exit");

                Console.Write("\nChoose Your Option: ");
                int command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        Recipe recipe = EnterRecipeDetails();
                        recipeManager.AddRecipe(recipe);
                        break;
                    case 2:
                        recipeManager.DisplayRecipeList();
                        break;
                    case 3:
                        Console.Write("Enter Recipe Name: ");
                        string recipeName = Console.ReadLine();
                        recipeManager.DisplayRecipeDetails(recipeName);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nYou have entered an invalid input!");
                        break;
                }
            }
        }

        // Method to enter recipe details
        static Recipe EnterRecipeDetails()
        {
            Recipe recipe = new Recipe();

            Console.WriteLine("\nEnter Recipe Details:");
            Console.Write("Name: ");
            recipe.Name = Console.ReadLine();

            Console.Write("Enter Number of Ingredients: ");
            int numOfIngredients = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfIngredients; i++)
            {
                Ingredient ingredient = new Ingredient();
                Console.WriteLine($"\nIngredient {i + 1}:");
                Console.Write("Name: ");
                ingredient.Name = Console.ReadLine();
                Console.Write("Quantity: ");
                ingredient.Quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit: ");
                ingredient.Unit = Console.ReadLine();
                Console.Write("Calories: ");
                ingredient.Calories = int.Parse(Console.ReadLine());
                Console.Write("Food Group: ");
                ingredient.FoodGroup = Console.ReadLine();
                recipe.Ingredients.Add(ingredient);
            }

            Console.Write("\nEnter Number of Steps: ");
            int numOfSteps = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfSteps; i++)
            {
                Step step = new Step();
                Console.WriteLine($"\nStep {i + 1}:");
                Console.Write("Description: ");
                step.Description = Console.ReadLine();
                recipe.Steps.Add(step);
            }

            return recipe;
        }
    }