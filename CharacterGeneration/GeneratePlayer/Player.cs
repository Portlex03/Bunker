namespace GeneratePlayer;

public class Player
{
    string sex;
    Dictionary<int, string> age;
    Dictionary<string, string[]> body;
    Dictionary<string, string> character;

    public string Sex {get => sex; set => sex = value;}
    public Dictionary<int, string> Age { get => age; set => age = value; }
    public Dictionary<string, string[]> Body {get => body; set => body = value;}
    public Dictionary<string, string> Character {get => character; set => character = value;}
}
