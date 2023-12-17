﻿using BunkerProject;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;


internal class CreateGameManager : MonoBehaviourPun
{
    public Text connectionCode;
    public Text countPlayers;
    public Text[] indexes;
    public Text[] playerNames;
    public Text[] readyOrNot;

    void Start()
    {
        connectionCode.text = PlayerPrefs.GetString("connectionCode");
        countPlayers.text = PhotonNetwork.PlayerList.Length.ToString();
        FillTable(PhotonNetwork.PlayerList.Length - 1, PhotonNetwork.PlayerList[^1]);
    }

    private void FillTable(int index, Player player)
    {
        indexes[index].text = (index + 1).ToString();
        playerNames[index].text = player.NickName;
        readyOrNot[index].text = "Готов";
    }

    public void CopyConnectionCode()
    {
        GUIUtility.systemCopyBuffer = connectionCode.text;
    }

    public void StartGame()
    {
        SetPlayerSettings();
        
        SetBunkerSettings();

        PhotonNetwork.LoadLevel("BunkerHomeScene");
    }

    private void SetBunkerSettings()
    {
        var generator = new Generator("Assets/DataForGeneration/BunkerGeneration");
        
        var bunker = generator.GenerateInfo(new UObject());

        PhotonNetwork.CurrentRoom.CustomProperties.Merge(bunker.Info);
    }

    private void SetPlayerSettings()
    {
        var generator = new Generator("Assets/DataForGeneration/PlayerGeneration");
        
        var players =  generator.GeneratePlayers(PhotonNetwork.PlayerList.Length);

        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            PhotonNetwork.PlayerList[i].CustomProperties.Merge(players[i].Info);
        }
    }
}
