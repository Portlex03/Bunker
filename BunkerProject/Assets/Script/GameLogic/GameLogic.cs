using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class GameLogic
{
    public float Timer { get; set; }
    public string Message { get; private set; }

    private Dictionary<int, Action> actionsDict;
    private Queue<Player> queue;
    private int index = -1;

    public GameLogic()
    {   
        actionsDict = new Dictionary<int, Action>()
        {
            { 0, StartGame },
            { 1, FillQueue },
            { 2, GetPlayerProperty },
            { 3, Voting }
        };
    }

    public void Manage()
    {
        if ((int)Timer == 0)
        {
            index += 1;
        }
        actionsDict[index]();
    }

    void FillQueue()
    {
        var playerList = PhotonNetwork.PlayerList;
        for (int i = 0; i < playerList.Length; i++)
        {
            queue.Enqueue(playerList[i]);
        }
        Timer = 1;
        Message = "Заполение данных";
    }

    void StartGame()
    {
        if ((int)Timer == 0)
        {
            Timer = 10;
            PlayerPrefs.SetFloat("timer", Timer);
        }
            
        Message = "Приветствую, дорогие игроки!\n" +
                  "У вас есть 45 секунд на обзор ваших игровых характеристик " +
                  "и бункера, в котором вы находитесь";
    }

    void GetPlayerProperty()
    {
        if ((int)Timer == 0 && queue.Count > 1)
        {
            Timer = 30;
            PlayerPrefs.SetFloat("timer", Timer);

            var player = queue.Dequeue();

            Message = $"Игрок {player.NickName} должен открыть свою характеристику.\n" +
                      "Иначе она откроется случайным образом";

            PlayerPrefs.SetString("Queue.Name", player.NickName);   
        }
        if (queue.Count > 1)
            index -= 1;

        Message = $"Игрок {PlayerPrefs.GetString("Queue.Name")} должен открыть свою характеристику.\n" +
                   "Иначе она откроется случайным образом";

    }

    void Voting()
    {
        
    }
}
