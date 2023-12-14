using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BunkerProject;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class BunkerHomeManager : MonoBehaviourPun
{
    //ExitGames.Client.Photon.Hashtable roomProperties;
    //public BunkerHomeManager()
    //{
    //    roomProperties = PhotonNetwork.CurrentRoom.CustomProperties;
    //}

    public Text[] DisasterInfoName;
    public Text[] DisasterInfo;
    public Text[] BunkerInfoName;
    public Text[] BunkerInfo;
    void Start()
    {
        var disaster = new Generator(pathForData:"Assets/DataForGeneration/DisasterGeneration").GeneratePlayers(1)[0];
        var info_keys = disaster.Info.Keys.ToArray();
        var info_values = disaster.Info.Values.ToArray();

        for(int i=0; i<DisasterInfo.Length; i++)
        {
            DisasterInfoName[i].text = info_keys[i];
            // как добавить описание к кактастрофе ...
        }
    }

    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("UserInfoScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("GameCourseScene");
    }

    public void SendToUsersInfoScene()
    {
        PhotonNetwork.LoadLevel("UsersInfoScene");
    }   
}
