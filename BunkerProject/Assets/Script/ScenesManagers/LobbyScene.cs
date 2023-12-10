using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

internal class LobbyScene : MonoBehaviourPunCallbacks
{
    public void CreateRoom()
    {
        string connectionCode = new System.Random().Next(1001, 10000).ToString();
        PlayerPrefs.SetString("connectionCode", connectionCode);
        RoomOptions roomOptions = new RoomOptions();
        PhotonNetwork.CreateRoom(connectionCode, roomOptions);
    }

    public override void OnCreatedRoom()
    {
        PhotonNetwork.LoadLevel("CreateGameScene");
    }

    public void SendToJoinGameScene()
    {
        SceneManager.LoadScene("JoinRoomScene");
    }

    public void SendToRulesScene()
    {
        SceneManager.LoadScene("RulesScene");
    }
}

