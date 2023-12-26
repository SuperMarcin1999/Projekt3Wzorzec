namespace Project3_Wzorzec.DataAccess;

public class StringsTextualRepository : StringsRepository
{
    private static readonly string _separator = Environment.NewLine;
    
    protected override List<string>? FileContextToModel(string fileContext)
        => fileContext.Split(_separator).ToList();
    protected override string ModelToFileContext(List<string> models)
        => string.Join(_separator, models);
}