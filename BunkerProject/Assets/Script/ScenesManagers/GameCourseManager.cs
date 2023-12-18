using Photon.Pun;
using Photon.Realtime;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameCourseManager : MonoBehaviourPun
{
    public GameObject[] playerPositions;
    public Text[] playerNames;
    public GameObject notification;
    public Text notificationText;
    private int playerCount;
    private Player[] playerList;
    private static GameLogic gameLogic;


    public GameCourseManager()
    {
        playerCount = PhotonNetwork.CurrentRoom.PlayerCount;
        playerList = PhotonNetwork.PlayerList;
    }

    static GameCourseManager()
    {
        gameLogic = new GameLogic();
    }

    private void Start()
    {
        Instantiate(playerPositions[playerCount - 1]);

        playerNames = FindObjectsOfType<Text>()[..playerCount].Reverse().ToArray();

        FillPlayerNames();

        if (!gameLogic.HasPlayers)
            gameLogic.GetPlayers(PhotonNetwork.PlayerList);
    }

    private void Update()
    {
        gameLogic.Manage();

        gameLogic.Timer = PlayerPrefs.GetFloat("timer") - Time.deltaTime;

        notificationText.text = gameLogic.Message + "\nВремя: " + GetNormalTime(gameLogic.Timer);

        PlayerPrefs.SetFloat("timer", gameLogic.Timer);
    }

    // для тестов
    //private void Start()
    //{       
    //    playerCount = 5;

    //    Instantiate(playerPositions[playerCount - 1]);

    //    playerNames = FindObjectsOfType<Text>()[..playerCount].Reverse().ToArray();
    //}

    private void FillPlayerNames()
    {
        for (int i = 0; i < playerList.Length; i++)
        {
            playerNames[i].text = playerList[i].NickName;
        }
    }

    private string GetNormalTime(float seconds)
    {
        TimeSpan t = TimeSpan.FromSeconds(seconds);
        return string.Format("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);
    }

    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("1_BunkerHomeScene");
    }

    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("2_UserInfoScene");
    }

    public void SendToUsersInfoScene()
    {
        PhotonNetwork.LoadLevel("4_UsersInfoScene");
    }   
}
