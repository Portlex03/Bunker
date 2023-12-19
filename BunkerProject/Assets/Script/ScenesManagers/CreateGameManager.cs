using System.Collections.Generic;
using System.Linq;
using BunkerProject;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using Dict = System.Collections.Generic.Dictionary<string, Item[]>;


internal class CreateGameManager : MonoBehaviourPun
{
    public Text connectionCode;
    public Text countPlayers;
    public Text[] indexes;
    public Text[] playerNames;
    public Text[] readyOrNot;

    void Start()
    {
        connectionCode.text = PlayerPrefs.GetString("connectionCode");
        countPlayers.text = PhotonNetwork.PlayerList.Length.ToString();
        FillTable(PhotonNetwork.PlayerList.Length - 1, PhotonNetwork.PlayerList[^1]);
    }

    private void FillTable(int index, Player player)
    {
        indexes[index].text = (index + 1).ToString();
        playerNames[index].text = player.NickName;
        readyOrNot[index].text = "Готов";
    }

    public void CopyConnectionCode()
    {
        GUIUtility.systemCopyBuffer = connectionCode.text;
    }

    public void StartGame()
    {
        SetPlayerSettings();
        
        SetBunkerSettings();

        PhotonNetwork.LoadLevel("1_BunkerHomeScene");
    }

    private void SetBunkerSettings()
    {
        var generator = new Generator("Assets/DataForGeneration/BunkerGeneration");
        
        var bunker = generator.GenerateInfo(new UObject());

        //PhotonNetwork.CurrentRoom.CustomProperties.Merge(bunker.Info);
        PhotonNetwork.CurrentRoom.CustomProperties["BunkerInfo"] = bunker.Info;

        generator = new Generator(pathForData: "Assets/DataForGeneration/DisasterGeneration");
        generator.WantToAddDescription(true);
        
        var disaster = generator.GenerateInfo(new UObject());
        
        PhotonNetwork.CurrentRoom.CustomProperties["DisasterInfo"] = disaster.Info;
    }

    private void SetPlayerSettings()
    {
        var generator = new Generator("Assets/DataForGeneration/PlayerGeneration");
        
        var players =  generator.GeneratePlayers(PhotonNetwork.PlayerList.Length);

        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            // PhotonNetwork.PlayerList[i].CustomProperties.Merge(players[i].Info);
            PhotonNetwork.PlayerList[i].CustomProperties["ClosedInfo"] = players[i].Info;

            PhotonNetwork.PlayerList[i].CustomProperties["OpenedInfo"] = new Dictionary<string, Item[]>();
            var keys = players[i].Info.Keys.ToArray();
            for(int j=0; j<keys.Length; j++)
            {
                ((Dictionary<string, Item[]>)
                    PhotonNetwork.PlayerList[i].CustomProperties["OpenedInfo"])[keys[i]] = new Item[] {new Item("------")};
            }
        }
    }
}
