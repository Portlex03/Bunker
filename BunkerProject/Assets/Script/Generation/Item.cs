using BunkerProject;
using System;

class Item
{
    public Item(string attributeName)
    {
        this.attributeName = attributeName;
    }

    public Item(string[] args, bool addDescription = false)
    {
        switch(args.Length)
        {
            case 1:
                attributeName = args[0];
                break;
            case 2:
                attributeName = args[0];
                if (addDescription) description = args[1];
                break;
            default:
                throw new Exception($"Недопустимый размер данных: {args.Length}");
        }
    }
    private string attributeName;
    private string description = "";
    public string AttributeName {get => attributeName; }
    public string Description {get => description; }
}