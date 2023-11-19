using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegistrationScene : MonoBehaviour
{
    public InputField nickName;

    public void RegisterUser()
    {
        GameKeeper.RegisterUser(nickName.text);
    }

    public void SendToLobbyScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
