using Project3_Wzorzec.Recipes;
using Project3_Wzorzec.Recipes.Ingredients;

namespace Project3_Wzorzec.App;

public class RecipesConsoleUserInteraction(IIngredientRegister _ingredientRegister) : IRecipesUserInteraction
{
    public void Exit() => Console.WriteLine("Aplication closed.");
    public void ShowMessage(string message) => Console.WriteLine(message);
    public void PrintExistingRecipes(IEnumerable<Recipe>? allRecipes)
    {
        if (allRecipes is null)
            return;
        
        if (allRecipes.Any())
        {
            Console.WriteLine("Existing recipes are: " + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                counter++;
            }
        }
    }
    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

        foreach (var ingredient in _ingredientRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }
    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        var ingredients = new List<Ingredient>();
        var shallStop = false;

        while (!shallStop)
        {
            Console.WriteLine("Add an ingriedient by its ID, or type anything else if finished.");
            var userInput = Console.ReadLine();
            
            if (int.TryParse(userInput, out var id))
            {
                var selectedIgredient = _ingredientRegister.FindById(id);
                if (selectedIgredient is not null)
                {
                    ingredients.Add(selectedIgredient);
                }
            }
            else
            {
                shallStop = true;
            }
        } 

        return ingredients;
    }
}