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
        Debug.Log("�� ������������ � �������");

        PhotonNetwork.NickName = nickName.text;
        Debug.Log("��������� ��� ������: " + PlayerPrefs.GetString("nickName"));
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
