namespace Project3_Wzorzec.Recipes;

public interface IRecipesRepository
{
    void Write(string filePath, IList<Recipe> allRecipes);
    IList<Recipe>? Read(string filePath);
}