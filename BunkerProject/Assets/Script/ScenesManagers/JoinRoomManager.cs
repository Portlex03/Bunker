using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class JoinRoomManager : MonoBehaviourPunCallbacks
{
    public Text connectionCode;

    public void JoinToRoom()
    {
        PhotonNetwork.JoinRoom(connectionCode.text);
    }
}
