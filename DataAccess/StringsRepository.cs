namespace Project3_Wzorzec.DataAccess;

public abstract class StringsRepository : IStringsRepository
{
    public List<string>? Read(string filePath)
    {
        if (!File.Exists(filePath))
            return default;
        
        var fileContents = File.ReadAllText(filePath);
        return FileContextToModel(fileContents);
    }
    public void Write(string filePath, List<string> strings)
        => File.WriteAllText(filePath, ModelToFileContext(strings));
    
    protected abstract List<string>? FileContextToModel(string fileContext);
    protected abstract string ModelToFileContext(List<string> models);
}