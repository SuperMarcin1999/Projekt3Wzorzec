using Project3_Wzorzec.Recipes;
using Project3_Wzorzec.Recipes.Ingredients;

namespace Project3_Wzorzec.App;

public interface IRecipesUserInteraction
{
    void Exit();
    void ShowMessage(string message);
    void PrintExistingRecipes(IEnumerable<Recipe>? allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}