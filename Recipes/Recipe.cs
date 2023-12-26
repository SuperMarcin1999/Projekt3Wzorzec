using System.Text;
using Project3_Wzorzec.Recipes.Ingredients;

namespace Project3_Wzorzec.Recipes;

public class Recipe(IEnumerable<Ingredient> ingredients)
{
    public IEnumerable<Ingredient> Ingredients { get; } = ingredients;

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var ingredient in ingredients)
        {
            sb.Append($"{ingredient.Name}. {ingredient.PreparationInstructions}.{Environment.NewLine}");
        }

        return sb.ToString();
    }
}