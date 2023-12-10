using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class JoinRoomManager : MonoBehaviourPunCallbacks
{
    public InputField connectionCode;

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(connectionCode.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("CreateGameScene");
    }
}
