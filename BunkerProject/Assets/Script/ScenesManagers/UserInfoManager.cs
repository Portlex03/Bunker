using Photon.Pun;
using UnityEngine.UI;
using System.Linq;
using Dict = System.Collections.Generic.Dictionary<string, Item[]>;

public class UserInfoManager : MonoBehaviourPun
{
    public Text[] characteristicName;
    public Text[] characteristic;
    public Text infoAboutText;
    ExitGames.Client.Photon.Hashtable playerProperties;
    public UserInfoManager()
    {
        playerProperties = PhotonNetwork.LocalPlayer.CustomProperties;
    }

    private void Start()
    {
        infoAboutText.text += "\n"+PhotonNetwork.LocalPlayer.NickName;

        var info_keys = ((Dict)playerProperties["ClosedInfo"]).Keys.ToArray();
        var info_values = ((Dict)playerProperties["ClosedInfo"]).Values.ToArray();

        for (int i = 0; i < characteristicName.Length; i++)
        {
            characteristicName[i].text = info_keys[i];
            characteristic[i].text = string.Join(", ", info_values[i].Select(
                item => item.AttributeName)) + ";";
        }
    }

    //void Start()
    //{
    //    var player = new Generator(pathForData:"Assets/DataForGeneration/PlayerGeneration").GeneratePlayers(1)[0];
    //    var info_keys = player.Info.Keys.ToArray();
    //    var info_values = player.Info.Values.ToArray();

    //    // 5 рандомных характеристик, которые нужно открыть
    //    var open_characteristics = player.Info.OrderBy(x => Guid.NewGuid()).Take(5)
    //                                .ToDictionary(x => x.Key, x => x.Value);

    //    for(int i=0; i<characteristicName.Length; i++)
    //    {
    //        characteristicName[i].text = info_keys[i];
    //        characteristic[i].text = string.Join(", ", info_values[i].Select(item => item.AttributeName)) + ";";

    //        Item[] found;
    //        if (open_characteristics.TryGetValue(info_keys[i], out found) && found == info_values[i]) 
    //        {
    //            characteristic[i].color = new Color(253/255.0f, 210/255.0f, 111/255.0f, 1);
    //        }
    //    }
    //}
    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("1_BunkerHomeScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("3_GameCourseScene");
    }

    public void SendToUsersInfoScene()
    {
        PhotonNetwork.LoadLevel("4_UsersInfoScene");
    }  
}
