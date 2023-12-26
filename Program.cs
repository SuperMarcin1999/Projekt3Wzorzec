using Project3_Wzorzec;
using Project3_Wzorzec.App;
using Project3_Wzorzec.DataAccess;
using Project3_Wzorzec.FileAccess;
using Project3_Wzorzec.Recipes;

// ReSharper disable All

var fileFormat = FileFormat.Txt;
IStringsRepository stringRepository = fileFormat == FileFormat.Json ?
    new StringsJsonRepository() : new StringsTextualRepository(); 

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(stringRepository, new IngredientRegister()),
    new RecipesConsoleUserInteraction(new IngredientRegister()));

cookiesRecipesApp.Run(new FileMetadata("recipes", fileFormat).GetFormat());

Console.ReadKey();