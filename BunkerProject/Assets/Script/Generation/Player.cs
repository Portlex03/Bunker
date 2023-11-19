using System.Collections.Generic;

class Player
{
    public Player() { }
    public Player(string nickName)
    {
        this.nickName = nickName;
    }

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

    private Dictionary<string,Item[]> info = new();
    private string nickName;
    public Dictionary<string,Item[]> Info { get => info; }
    public string NickName { get => nickName; }
}