using System;

namespace ConsoleRecipeApplication
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the details for the recipe:");//Ask user to enter new recipe

            Console.Write("Enter Number of ingredients: ");//enter amount of ingrediants
            int NumOfIngredients = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of steps: ");//enter number of step
            int NumOfSteps = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(NumOfIngredients, NumOfSteps);

            recipe.EnterIngredients();
            recipe.EnterSteps();

            bool exit = false;
            while (!exit)
            {
                //Display menu options
                Console.WriteLine("\nMenu Option:");
                Console.WriteLine("1. Display recipe");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Reset quantities");
                Console.WriteLine("4. Clear all data");
                Console.WriteLine("5. Exit");

                Console.Write("\nChoose Your Option: "); //Ask user to choose option do do an actiom
                int command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        recipe.DisplayRecipe();
                        break;
                    case 2:
                        Console.Write("\nEnter Desired scaling Amount : ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        Console.WriteLine("\nRecipe scaled successfully!");
                        break;
                    case 3:
                        recipe.ResetQuantities();
                        Console.WriteLine("\nQuantities reset successfully!");
                        break;
                    case 4:
                        recipe.ClearRecipe();
                        Console.WriteLine("\n Your Recipe was cleared!");
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nYou have entered an invalid input!");
                        break;



                }
            }
        }
    }
}