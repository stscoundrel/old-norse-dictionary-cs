using Xunit;
using OldNorseDictionary;
using System.Collections.Generic;

namespace OldNorseDictionaryTest;

public class DictionaryEntryTest
{
    [Fact]
    public void CanCreateInstance()
    {
        var entry = new DictionaryEntry("Skilja", new List<string> { "To separate", "To divide" });

        Assert.Equal("Skilja", entry.Headword);
        Assert.Equal("To separate", entry.Definitions[0]);
        Assert.Equal("To divide", entry.Definitions[1]);
        Assert.Equal(typeof(DictionaryEntry), entry.GetType());
    }

    [Fact]
    public void StringOutputWorks()
    {
        var entry1 = new DictionaryEntry("Skilja", new List<string> { "To separate.", "To divide." });
        var entry2 = new DictionaryEntry("Telja", new List<string> { "To tell.", "To count." });

        Assert.Equal("Skilja - To separate. To divide.", entry1.ToString());
        Assert.Equal("Telja - To tell. To count.", entry2.ToString());
    }
}