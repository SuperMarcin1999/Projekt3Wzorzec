namespace Project3_Wzorzec.FileAccess;

public class FileMetadata (string _name, FileFormat _fileFormat)
{
    public string GetFormat() => $"{_name}.{_fileFormat.AsFileExtension()}";
}