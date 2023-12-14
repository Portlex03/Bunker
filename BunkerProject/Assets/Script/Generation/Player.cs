using System.Collections.Generic;
using System.Linq;

class Player
{
    private Dictionary<string, Item[]> info = new();

    public void AddFeatures(string feature, Item[] items)
    {
        info[feature] = items;
    }

    public override string ToString()
    {
        string result = "";
        foreach (var feature in info)
        {
            string attributes = "";
            foreach(var item in feature.Value)
            {
                attributes += item.AttributeName + "; ";
            }
            result += $"{feature.Key}: {attributes}\n";
        }
        return result;
    }
    public string PrintNameFeatures()
    {
        return string.Join("\n", info.Keys);
    }

    public string PrintFeatures()
    {
        return string.Join(";\n", info.Values.Select(arr => string.Join(", ", arr.Select(item => item.AttributeName))));
    }
    public Dictionary<string, Item[]> Info { get => info; }
}