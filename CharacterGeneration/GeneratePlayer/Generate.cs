using System.IO.Compression;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GeneratePlayer;

public class Generate
{
    private int count_people;
    private Dictionary<string, string[]> body_type = new Dictionary<string, string[]>();
    private Random rand = new Random();
    public Generate(int count_people)
    {
        this.count_people = count_people;
    }
    private void Body_Type_Info()
    {
        string filePath = "Bunker/Data/body_type.txt";
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            string attribute = parts[0].Trim();
            string[] value = parts[1].Trim().Split(new char[] { ',' });
            body_type.Add(attribute, value);
        }
    }

    public Player[] GeneratePlayers()
    {
        Player[] players = new Player[count_people];
        for (int i=0; i < count_people; i++)
        {
            players[i] = new Player() { Body = body_type.ElementAt(rand.Next(0, body_type.Count))};
        }
        return players;
    }

}