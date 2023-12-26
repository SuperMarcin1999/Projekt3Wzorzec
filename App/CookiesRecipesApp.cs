using Project3_Wzorzec.Recipes;

namespace Project3_Wzorzec.App;

class CookiesRecipesApp(IRecipesRepository _recipeRepository, IRecipesUserInteraction _recipesUserInteraction)
{
    public void Run(string filePath)
    {
        var allRecipes = _recipeRepository.Read(filePath) ?? new List<Recipe>();
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Any())
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipeRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected. Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
    }
    
}