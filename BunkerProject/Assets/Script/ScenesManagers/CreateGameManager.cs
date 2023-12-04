using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;


internal class CreateGameManager : MonoBehaviourPun
{
    public Text connectionCode;

    void Start()
    {
        connectionCode.text = PlayerPrefs.GetString("connectionCode");
    }

    public void SendToLobbyScene()
    {
        PhotonNetwork.LoadLevel("LobbyScene");
    }

    public void CopyConnectionCode()
    {
        GUIUtility.systemCopyBuffer = connectionCode.text;
    }
}
