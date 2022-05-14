# Old Norse Dictionary

Old Norse to English Dictionary for C# / .NET. The dictionary consists of 35 000+ Old Norse words with English translations.

Based on the classic dictionary by Richard Cleasby and Gudbrand Vigfusson. If you find this one too abbreviated, academic or hard to read, you might want to check out [A Concise Dictionary of Old Icelandic](https://github.com/stscoundrel/old-icelandic-dictionary-cs)

### Install

```
dotnet add package OldNorseDictionary
```


### Usage


```csharp
using OldNorseDictionary;

// Get all dictionary entries.
var dictionary = new Dictionary();
var result = dictionary.GetEntries();
Console.WriteLine(dictionary.Count); // 35 207 entries.

// Individual entry contains headword and definitions list.
DictionaryEntry entry = result[1000];
Console.WriteLine(entry.Headword); // ARINN
Console.WriteLine(entry.Definitions[0]);
// s, m., dat. aarni = árni, Fs. 42, Rm. 2, [a word still freq. in Denmark and in Norway; Dan. arne, arnested; Norse aarstad, Ivar Aasen: in Icel. it is very rare]

DictionaryEntry entry2 = result[10000]
Console.WriteLine(entry2.Headword); // gull-reyfi
Console.WriteLine(entry2.Definitions[0]); // n. a golden fleece, Hb. 732. 17.

// ToString is overwritten for generic presentation.
Console.WriteLine(entry2.ToString()); // gull-reyfi - n. a golden fleece, Hb. 732. 17.

```

### About Cleasby & Vigfusson Dictionary

"Icelandic-English" dictionary was started by Richard Cleasby and finished by Gudbrand Vigfusson. It was published in 1874, which leads to there being many public domain versions of the book available.
