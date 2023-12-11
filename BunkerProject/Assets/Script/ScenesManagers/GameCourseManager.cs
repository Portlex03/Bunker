using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class GameCourseManager : MonoBehaviourPun
{
    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("BunkerHomeScene");
    }
    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("UserInfoScene");
    }

    public void SendToUsersInfoScene()
    {
        PhotonNetwork.LoadLevel("UsersInfoScene");
    }   
}
