using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegistrationScene : MonoBehaviour
{
    [SerializeField] private InputField inputCharacterName;
    [SerializeField] private Text characterName;
    [SerializeField] private GameObject panelName;

    public void SendToLobbyScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    public void SetName()
    {
        characterName.text = inputCharacterName.text;
    }
}
