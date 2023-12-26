using Project3_Wzorzec.Recipes.Ingredients;

namespace Project3_Wzorzec.Recipes;

public class IngredientRegister : IIngredientRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>()
    {
        new Butter(),
        new Cardamom(),
        new Chocolate(),
        new Cinnamon(),
        new Sugar(),
        new CocoaPowder(),
        new SpeltFlour(),
        new WheatFlour()
    };

    public Ingredient? FindById(int id)
    {
        return All.FirstOrDefault(x => x.Id == id);
    }
}