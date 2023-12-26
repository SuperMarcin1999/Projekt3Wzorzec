using Project3_Wzorzec.DataAccess;

namespace Project3_Wzorzec.Recipes;

public class RecipesRepository(IStringsRepository _stringsRepository, IIngredientRegister _ingredientRegister) : IRecipesRepository
{
    public void Write(string filePath, IList<Recipe> allRecipes)
    {
        var recipesAsStrings = new List<string>();
        foreach (var recipe in allRecipes)
        {
            var ids = recipe.Ingredients.Select(x => x.Id);
            recipesAsStrings.Add(string.Join(",", ids));
        }
        
        _stringsRepository.Write(filePath, recipesAsStrings);
    }

    public IList<Recipe> Read(string filePath)
    {
        var recipes = new List<Recipe>();
        var recipesAsString = _stringsRepository.Read(filePath) ?? new List<string>();
        
        foreach (var recipeAsString in recipesAsString)
        {
            var recipe = RecipeFromString(recipeAsString);
            recipes.Add(recipe);
        }

        return recipes;
    }

    private Recipe RecipeFromString(string recipeFromString)
    {
        var igridients = recipeFromString
            .Split(",")
            .Select(id => _ingredientRegister.FindById(int.Parse(id)));
        return new Recipe(igridients!);
    }
}