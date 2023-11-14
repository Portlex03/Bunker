namespace GeneratePlayer;

public class Player
{
    // пол
    string sex = "Unknown";
    // возраст и его тип
    KeyValuePair<int, string> age;
    // телосложение и его описание
    KeyValuePair<string, string[]> body;
    // характер и его пояснение
    KeyValuePair<string, string> character;
    // рост и его тип
    KeyValuePair<int, string> height;
    // профессия и ее характеристика
    KeyValuePair<string, string> profession;
    // уровень скилла и стаж работы
    KeyValuePair<string, int[]> experience;

    public string Sex {get => sex; set => sex = value;}
    public KeyValuePair<int, string> Age { get => age; set => age = value; }
    public KeyValuePair<string, string[]> Body {get => body; set => body = value;}
    public KeyValuePair<string, string> Character {get => character; set => character = value;}
    public KeyValuePair<int, string> Height {get => height; set => height = value;}
    public KeyValuePair<string, string> Profession {get => profession; set => profession = value;}
    public KeyValuePair<string, int[]> Experience {get => experience; set => experience = value;}
}
