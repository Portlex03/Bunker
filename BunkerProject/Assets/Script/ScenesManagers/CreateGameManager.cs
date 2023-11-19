using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

internal class CreateGameManager : MonoBehaviour
{
    public Text connectionCode;

    private void Start()
    {
        connectionCode.text = new System.Random().Next(1001,10000).ToString();
    }

    public void SendToLobbyScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    public void CopyConnectionCode()
    {
        GUIUtility.systemCopyBuffer = connectionCode.text;
    }
}
