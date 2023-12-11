using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class UsersInfoManager : MonoBehaviourPun
{
    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("BunkerHomeScene");
    }
    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("UserInfoScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("GameCourseScene");
    }
}
