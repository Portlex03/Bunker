using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BunkerProject
{
    class Generator
    {
        public Generator(string pathForData)
        {
            d = new DirectoryInfo(pathForData);
        }

        public List<Player> GeneratePlayers(int countPeople)
        {
            players = new Player[countPeople];
            return players.Select(GeneratePlayer).ToList();
        }

        private Player GeneratePlayer(Player player)
        {
            player = new Player();
            var directories = d.GetDirectories();
            foreach (var directory in directories)
            {
                string feature = directory.Name[3..];
                List<Item> items = new();
                foreach (var file in directory.GetFiles())
                {
                    string[] fileData = File.ReadAllLines(file.FullName);
                    string attribute = fileData[new Random().Next(0, fileData.Length)];
                    items.Add(new Item(attribute.Split(";")));
                }
                player.AddFeatures(feature, items.ToArray());
            }
            return player;
        }

        private readonly DirectoryInfo d;
        private Player[] players;
    }
}