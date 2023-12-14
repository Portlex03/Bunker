using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class UserInfoManager : MonoBehaviourPun
{
    //ExitGames.Client.Photon.Hashtable playerProperties;
    //public UserInfoManager()
    //{
    //    playerProperties = PhotonNetwork.LocalPlayer.CustomProperties;
    //}

    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("BunkerHomeScene");
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
