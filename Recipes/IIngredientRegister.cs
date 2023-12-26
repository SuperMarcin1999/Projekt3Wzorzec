using Project3_Wzorzec.Recipes.Ingredients;

namespace Project3_Wzorzec.Recipes;

public interface IIngredientRegister
{
    IEnumerable<Ingredient> All { get; }
    Ingredient? FindById(int id);
}