using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class UsersInfoManager : MonoBehaviourPun
{
    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("1_BunkerHomeScene");
    }
    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("2_UserInfoScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("3_GameCourseScene");
    }
}
