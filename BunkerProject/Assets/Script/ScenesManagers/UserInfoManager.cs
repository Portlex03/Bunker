using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Dict = System.Collections.Generic.Dictionary<string, Item[]>;
using System.Collections.Generic;
using BunkerProject;

public class UserInfoManager : MonoBehaviourPun
{
    public Sprite newImage;
    public Button buttonToChange;
    public string textNameInfo;
    public string textValueInfo;
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

    // void Start()
    // {
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
    // }

    public void EditButtonZero()
    {
        buttonToChange = GameObject.Find("Button (0)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (0)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (0)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonOne()
    {
        buttonToChange = GameObject.Find("Button (1)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (1)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (1)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonTwo()
    {
        buttonToChange = GameObject.Find("Button (2)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (2)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (2)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonThree()
    {
        buttonToChange = GameObject.Find("Button (3)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (3)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (3)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonFour()
    {
        buttonToChange = GameObject.Find("Button (4)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (4)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (4)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonFive()
    {
        buttonToChange = GameObject.Find("Button (5)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (5)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (5)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonSix()
    {
        buttonToChange = GameObject.Find("Button (6)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (6)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (6)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonSeven()
    {
        buttonToChange = GameObject.Find("Button (7)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (7)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (7)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

        public void EditButtonEight()
    {
        buttonToChange = GameObject.Find("Button (8)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (8)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (8)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };
        
        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void EditButtonNine()
    {
        buttonToChange = GameObject.Find("Button (9)").GetComponent<Button>();
        newImage = Resources.Load<Sprite>("OpenLock");
        textNameInfo = GameObject.Find("Canvas/PlayerInformation/NameFeaturesList/NameFeatures (9)").GetComponent<Text>().text;
        textValueInfo = GameObject.Find("Canvas/PlayerInformation/FeaturesList/Features (9)").GetComponent<Text>().text;
        var dictionary = new Dictionary<string, string>() { {textNameInfo, textValueInfo} };

        // Изменение картинки кнопки
        buttonToChange.GetComponent<Image>().sprite = newImage;

        // Передача словаря в другую сцену
		PlayerPrefs.SetString("dictionary", JsonUtility.ToJson(dictionary));

        SendToUserInfoScene();
    }

    public void SendToBunkerHomeScene()
    {
        PhotonNetwork.LoadLevel("1_BunkerHomeScene");
    }

    public void SendToGameCourseScene()
    {
        PhotonNetwork.LoadLevel("3_GameCourseScene");
    }

    public void SendToUserInfoScene()
    {
        PhotonNetwork.LoadLevel("2_UserInfoScene");
    }

    public void SendToUsersInfoScene()
    {
        PhotonNetwork.LoadLevel("4_UsersInfoScene");
    }  
}
