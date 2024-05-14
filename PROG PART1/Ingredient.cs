
// Class to represent an ingredient
class Ingredient
{
    public string Name { get; set; }       // Name of the ingredient
    public double Quantity { get; set; }   // Quantity of the ingredient
    public string Unit { get; set; }       // Unit of the ingredient
    public int Calories { get; set; }      // Calories of the ingredient
    public string FoodGroup { get; set; }  // Food group of the ingredient
}
class Recipe
{
    public string Name { get; set; }                        // Name of the recipe
    public List<Ingredient> Ingredients { get; set; }       // Ingredients of the recipe
    public List<Step> Steps { get; set; }                   // Steps of the recipe

    // Constructor to initialize a recipe
    public Recipe()
    {
        Ingredients = new List<Ingredient>();
        Steps = new List<Step>();
    }
}
