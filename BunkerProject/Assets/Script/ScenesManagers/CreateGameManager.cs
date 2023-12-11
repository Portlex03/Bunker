using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;


internal class CreateGameManager : MonoBehaviourPun
{
    public Text connectionCode;
    public Text countPlayers;
    public Text[] indexes;
    public Text[] playerNames;
    public Text[] readyOrNot;

    void Start()
    {
        connectionCode.text = PlayerPrefs.GetString("connectionCode");
        countPlayers.text = PhotonNetwork.PlayerList.Length.ToString();
        FillTable(PhotonNetwork.PlayerList.Length - 1, PhotonNetwork.PlayerList[^1]);
    }

    private void FillTable(int index, Photon.Realtime.Player player)
    {
        indexes[index].text = (index + 1).ToString();
        playerNames[index].text = player.NickName;
        readyOrNot[index].text = "Готов";
    }

    public void SendToLobbyScene()
    {
        PhotonNetwork.LoadLevel("LobbyScene");
    }

    public void CopyConnectionCode()
    {
        GUIUtility.systemCopyBuffer = connectionCode.text;
    }

    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("BunkerHomeScene");
    }
}
