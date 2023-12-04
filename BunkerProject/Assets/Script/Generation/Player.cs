using System.Collections.Generic;

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
    public Dictionary<string, Item[]> Info { get => info; }
}