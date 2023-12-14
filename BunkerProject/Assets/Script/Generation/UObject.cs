using System.Collections.Generic;
using System.Linq;

class UObject // бывший Player
{
    private Dictionary<string, Item[]> info = new();
    public Dictionary<string, Item[]> Info { get => info; }

    public void AddFeature(string feature, Item[] items)
    {
        info[feature] = items;
    }

    public void AddFeatures(string feature, Item[] items)
    {
        info[feature] = items;
    }

    public string PrintNameFeatures()
    {
        return string.Join("\n", info.Keys);
    }

    public string PrintFeatures()
    {
        return string.Join(";\n", info.Values.Select(arr => string.Join(", ", arr.Select(item => item.AttributeName))));
    }
}