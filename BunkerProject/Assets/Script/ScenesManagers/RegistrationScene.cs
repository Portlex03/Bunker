using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class RegistrationScene : MonoBehaviourPunCallbacks
{
    public InputField nickName;

    public void RegisterUser()
    {
        PlayerPrefs.SetString("nickName", nickName.text);
    }
    
    public void ConnectToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Вы подключились к серверу");

        PhotonNetwork.NickName = nickName.text;
        Debug.Log("Сохранено имя игрока: " + PlayerPrefs.GetString("nickName"));
    }

<<<<<<< Updated upstream
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("LobbyScene");
=======
    public void SendToCreateGameScene()
    {
        PhotonNetwork.LoadLevel("CreateGameScene");
>>>>>>> Stashed changes
    }
}
