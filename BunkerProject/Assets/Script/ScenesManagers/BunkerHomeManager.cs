using System.Linq;
using BunkerProject;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using Dict = System.Collections.Generic.Dictionary<string, Item[]>;

public class BunkerHomeManager : MonoBehaviourPun
{
    public Text[] disasterInfoName;
    public Text[] disasterInfo;
    public Text[] bunkerInfoName;
    public Text[] bunkerInfo;

    ExitGames.Client.Photon.Hashtable roomProperties;
    public BunkerHomeManager()
    {
        roomProperties = PhotonNetwork.CurrentRoom.CustomProperties;
    }

    void Start()
    {
        var info_keys = ((Dict)roomProperties["DisasterInfo"]).Keys.ToArray();
        var info_values = ((Dict)roomProperties["DisasterInfo"]).Values.ToArray();

        for (int i = 0; i < disasterInfo.Length; i++)
        {
            disasterInfoName[i].text = info_keys[i];
            disasterInfo[i].text = string.Join(", ", info_values[i].Select(
                item => item.AttributeName + ". " + item.Description)
            );
        }
        // UpdateFontSize(disasterInfo[0]);

        info_keys = ((Dict)roomProperties["BunkerInfo"]).Keys.ToArray();
        info_values = ((Dict)roomProperties["BunkerInfo"]).Values.ToArray();

        for (int i = 0; i < bunkerInfo.Length; i++)
        {
            bunkerInfoName[i].text = info_keys[i];
            bunkerInfo[i].text = string.Join(", ", info_values[i].Select(
                item => item.AttributeName)) + ";";
        }
    }

    //void Start()
    //{
    //    var disaster = new Generator(pathForData:"Assets/DataForGeneration/DisasterGeneration");
    //    disaster.WantToAddDescription(true);

    //    var disaster_info = disaster.GeneratePlayers(1)[0].Info;
    //    var info_keys = disaster_info.Keys.ToArray();
    //    var info_values = disaster_info.Values.ToArray();

    //    for(int i=0; i<disasterInfo.Length; i++)
    //    {
    //        disasterInfoName[i].text = info_keys[i];
    //        disasterInfo[i].text = string.Join(", ", info_values[i].Select(item => item.AttributeName + item.Description));
    //    }

    //    var bunker = new Generator(pathForData:"Assets/DataForGeneration/BunkerGeneration").GeneratePlayers(1)[0];
    //    info_keys = bunker.Info.Keys.ToArray();
    //    info_values = bunker.Info.Values.ToArray();

    //    for(int i=0; i<bunkerInfo.Length; i++)
    //    {
    //        bunkerInfoName[i].text = info_keys[i];
    //        bunkerInfo[i].text = string.Join(", ", info_values[i].Select(item => item.AttributeName)) + ";";
    //    }
    //}

    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("2_UserInfoScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("3_GameCourseScene");
    }

    public void SendToUsersInfoScene()
    {
        PhotonNetwork.LoadLevel("4_UsersInfoScene");
    }   
    public float minFontSize = 10f;
    public float maxFontSize = 100f;

    // Метод, который будет вызываться при изменении размера экрана
    void UpdateFontSize(Text text)
    {
        float screenHeight = Screen.height;
        float textHeight = LayoutUtility.GetPreferredHeight(text.rectTransform);
        
        float scaleFactor = screenHeight / textHeight;

        if (scaleFactor < 1)
        {
            text.fontSize = (int)Mathf.Max(minFontSize, text.fontSize * scaleFactor);
        }
        else
        {
            text.fontSize = (int)Mathf.Min(maxFontSize, text.fontSize * scaleFactor);
        }
    }
}
