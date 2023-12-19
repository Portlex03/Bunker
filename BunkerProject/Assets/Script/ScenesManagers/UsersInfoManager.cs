using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BunkerProject;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using Dict = System.Collections.Generic.Dictionary<string, Item[]>;

public class UsersInfoManager : MonoBehaviourPun
{
    private int index = 0;
    public Text[] characteristicName;
    public Text[] characteristic;
    public Text infoAboutPlayer;
    Player[] playersProperties;
    public UsersInfoManager()
    {
        playersProperties = PhotonNetwork.PlayerList;
    }

    private void PrintPlayer(int index)
    {
        var info_keys = ((Dict)playersProperties[index].CustomProperties["OpenedInfo"]).Keys.ToArray();
        var info_values = ((Dict)playersProperties[index].CustomProperties["OpenedInfo"]).Values.ToArray();

        for (int i = 0; i < characteristicName.Length; i++)
        {
            characteristicName[i].text = info_keys[i];
            characteristic[i].text = string.Join(", ", info_values[i].Select(
                item => item.AttributeName)) + ";";
        }

        infoAboutPlayer.text = playersProperties[index].NickName;
    }

    private void Start()
    {
        PrintPlayer(index);
    }

    public void OnRightClick()
    {
        index ++;

        PrintPlayer(index % playersProperties.Length);
    }

    public void OnLeftClick()
    {
        index--;

        PrintPlayer(index % playersProperties.Length);
    }
    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("1_BunkerHomeScene");
    }
    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("2_UserInfoScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("3_GameCourseScene");
    }
}
