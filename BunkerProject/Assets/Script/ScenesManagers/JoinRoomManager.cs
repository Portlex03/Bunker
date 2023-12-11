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

<<<<<<< Updated upstream
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("CreateGameScene");
=======
    public void SendToLobbyScene()
    {
        PhotonNetwork.LoadLevel("LobbyScene");
>>>>>>> Stashed changes
    }
}
