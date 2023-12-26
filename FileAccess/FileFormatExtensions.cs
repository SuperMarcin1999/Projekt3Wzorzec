namespace Project3_Wzorzec.FileAccess;

public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat fileFormat)
    {
        switch (fileFormat)
        {
            case FileFormat.Json:
                return "json";
            case FileFormat.Txt:
                return "txt";
            default:
                throw new ArgumentOutOfRangeException("Out of fileformat");
        }
    }
}