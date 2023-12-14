using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class BunkerHomeManager : MonoBehaviourPun
{
    //ExitGames.Client.Photon.Hashtable roomProperties;
    //public BunkerHomeManager()
    //{
    //    roomProperties = PhotonNetwork.CurrentRoom.CustomProperties;
    //}

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
