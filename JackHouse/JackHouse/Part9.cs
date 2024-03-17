using System.Collections.Immutable;

namespace JackHouse;

public class Part9
{
    public List<string> Poem { get; set; } = new();

    public Part9(List<string> strings)
    {
        Poem.AddRange(strings);
    }

    public void AddPart(List<string> lines)
    {
        var c1 = lines.ToImmutableList();
        c1.InsertRange(0, Poem);
        Poem.InsertRange(0, c1);
    }
}