using Photon.Pun;
using Photon.Realtime;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameCourseManager : MonoBehaviourPun
{
    public GameObject[] playerPositions;
    public Text[] playerNames;
    private int playerCount;
    private Player[] playerList;

    public GameCourseManager()
    {
        playerCount = PhotonNetwork.CurrentRoom.PlayerCount;
        playerList = PhotonNetwork.PlayerList;
    }

    private void Start()
    {
        Instantiate(playerPositions[playerCount - 1]);

        playerNames = FindObjectsOfType<Text>().Reverse().ToArray();

        FillTexts();
    }

    // для тестов
    //private void Start()
    //{
    //    Instantiate(playerPositions[0]);

    //    playerNames = FindObjectsOfType<Text>();
    //}

    private void FillTexts()
    {
        for (int i = 0; i < playerList.Length; i++)
        {
            playerNames[i].text = playerList[i].NickName;
        }
    }

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
