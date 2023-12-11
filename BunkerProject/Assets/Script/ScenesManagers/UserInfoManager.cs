using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class UserInfoManager : MonoBehaviourPun
{
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
