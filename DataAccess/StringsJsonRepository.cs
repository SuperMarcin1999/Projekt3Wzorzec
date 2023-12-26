using System.Text.Json;

namespace Project3_Wzorzec.DataAccess;

public class StringsJsonRepository : StringsRepository
{
    protected override List<string> FileContextToModel(string fileContext)
        => JsonSerializer.Deserialize<List<string>>(fileContext) ?? new List<string>();
    protected override string ModelToFileContext(List<string> models)
        => JsonSerializer.Serialize(models);
}