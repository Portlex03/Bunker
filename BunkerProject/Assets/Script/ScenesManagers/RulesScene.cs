using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

internal class RulesScene : MonoBehaviour
{
    public void SendToLobbyScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
