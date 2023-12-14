using System.Collections.Generic;

class UObject // бывший Player
{
    private Dictionary<string, Item[]> info = new();
    public Dictionary<string, Item[]> Info { get => info; }

    public void AddFeature(string feature, Item[] items)
    {
        info[feature] = items;
    }
}