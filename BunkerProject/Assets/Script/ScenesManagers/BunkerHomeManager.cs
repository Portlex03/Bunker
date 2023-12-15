using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BunkerProject;
using Photon.Pun;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BunkerHomeManager : MonoBehaviourPun
{
    //ExitGames.Client.Photon.Hashtable roomProperties;
    //public BunkerHomeManager()
    //{
    //    roomProperties = PhotonNetwork.CurrentRoom.CustomProperties;
    //}

    public Text[] disasterInfoName;
    public Text[] disasterInfo;
    public Text[] bunkerInfoName;
    public Text[] bunkerInfo;
    void Start()
    {
        var disaster = new Generator(pathForData:"Assets/DataForGeneration/DisasterGeneration");
        disaster.WantToAddDescription(true);

        var disaster_info = disaster.GeneratePlayers(1)[0].Info;
        var info_keys = disaster_info.Keys.ToArray();
        var info_values = disaster_info.Values.ToArray();

        for(int i=0; i<disasterInfo.Length; i++)
        {
            disasterInfoName[i].text = info_keys[i];
            disasterInfo[i].text = string.Join(", ", info_values[i].Select(item => item.AttributeName + item.Description));
        }

        var bunker = new Generator(pathForData:"Assets/DataForGeneration/BunkerGeneration").GeneratePlayers(1)[0];
        info_keys = bunker.Info.Keys.ToArray();
        info_values = bunker.Info.Values.ToArray();

        for(int i=0; i<bunkerInfo.Length; i++)
        {
            bunkerInfoName[i].text = info_keys[i];
            bunkerInfo[i].text = string.Join(", ", info_values[i].Select(item => item.AttributeName)) + ";";
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
