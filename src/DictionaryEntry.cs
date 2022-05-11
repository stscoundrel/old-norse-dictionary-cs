namespace OldNorseDictionary;

using System.Collections.Generic;

public readonly struct DictionaryEntry
{
    public string Headword { get; init; }
    public List<string> Definitions { get; init; }

    public override string ToString() => $"{Headword} - {String.Join(' ', Definitions)}";

    public DictionaryEntry(string headword, List<string> definitions)
    {
        Headword = headword;
        Definitions = definitions;
    }
}