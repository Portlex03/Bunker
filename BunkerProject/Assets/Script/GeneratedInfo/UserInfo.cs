using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using BunkerProject;

public class UserInfo : MonoBehaviour
{

    public Text characteristicName;
    public Text characteristic;

    void Start()
    {
        var player = new Generator(pathForData:"Assets/DataForGeneration/PlayerGeneration").GeneratePlayers(1)[0];

        characteristicName.text = player.PrintNameFeatures();
        characteristicName.color = new Color(0f, 0f, 0f, 1f);

        characteristic.text = player.PrintFeatures();
    }
}
