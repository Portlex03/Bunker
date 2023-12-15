using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Photon.Realtime;
using UnityEditor.SceneManagement;

namespace BunkerProject
{
    class Generator
    {
        public Generator(string pathForData)
        {
            d = new DirectoryInfo(pathForData);
        }

        public List<UObject> GeneratePlayers(int countPeople)
        {
            players = new UObject[countPeople];
            return players.Select(GenerateInfo).ToList();
        }

        public UObject GenerateInfo(UObject obj)
        {
            obj = new UObject();
            var directories = d.GetDirectories();
            foreach (var directory in directories)
            {
                string feature = directory.Name[3..];
                List<Item> items = new();
                var files = directory.GetFiles().Where(file => !file.Name.EndsWith(".meta"));
                foreach (var file in files)
                {
                    string[] fileData = File.ReadAllLines(file.FullName);
                    string attribute = fileData[new Random().Next(0, fileData.Length)];
                    items.Add(new Item(attribute.Split(";"), addDescription));
                }
                obj.AddFeature(feature, items.ToArray());
            }
            return obj;
        }
        public void WantToAddDescription(bool mark) => addDescription = mark;
        private bool addDescription = false;

        private readonly DirectoryInfo d;
        private UObject[] players;
    }
}