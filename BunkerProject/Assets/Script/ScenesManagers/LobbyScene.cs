using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

internal class LobbyScene : MonoBehaviour
{
    public Text lobbyText;

    private void Start()
    {
        lobbyText.text = GameKeeper.NickName;
    }

    public void SendToCreateGameScene()
    {
        SceneManager.LoadScene("CreateGameScene");
    }

    public void SendToJoinGameScene()
    {
        SceneManager.LoadScene("RegistrationScene");
    }

    public void SendToRulesScene()
    {
        SceneManager.LoadScene("RulesScene");
    }
}

