namespace OldNorseDictionary;

using System.Collections.Generic;
using System.Text.Json;
using System.Reflection;


public class Dictionary
{

    private List<DictionaryEntry> Entries;

    public Dictionary()
    {
        Entries = CreareEntries();
    }

    private List<DictionaryEntry> CreareEntries()
    {
        string jsonResult = Utils.ResourceReader.ReadEntries();
        var entryResult = JsonSerializer.Deserialize<List<DictionaryEntry>>(jsonResult);

        if (entryResult == null)
        {
            throw new Exception("Could not read entries resource");
        }

        return entryResult;

    }

    public List<DictionaryEntry> GetEntries()
    {
        return Entries;
    }
}