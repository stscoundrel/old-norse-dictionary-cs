namespace OldNorseDictionary.Utils;

using System.Reflection;

internal class ResourceReader
{

    private const string DictionaryPath = "OldNorseDictionary.Resources.dictionary.json";

    public static string ReadEntries()
    {
        var assembly = Assembly.GetExecutingAssembly();

        using (Stream stream = assembly.GetManifestResourceStream(DictionaryPath) ?? throw new Exception("Could not access manifest resource stream"))
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }

    }
}