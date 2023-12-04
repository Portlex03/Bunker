using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class RegistrationScene : MonoBehaviourPunCallbacks
{
    public InputField nickName;

    public void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        nickName.text = PlayerPrefs.GetString("nickName");
        PhotonNetwork.NickName = nickName.text;
    }

    public void RegisterUser()
    {
        PlayerPrefs.SetString("nickName", nickName.text);
        PhotonNetwork.NickName = nickName.text;
    }

    public void SendToLobbyScene()
    {
        PhotonNetwork.LoadLevel("LobbyScene");
    }
}
