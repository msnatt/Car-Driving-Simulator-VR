using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using Unity.VisualScripting;
using UnityEngine;
using Newtonsoft.Json;
using Oculus.Platform.Samples.VrHoops;

public class CRUDToJsonManager : MonoBehaviour
{
    public TextAsset UserDataFile;

    [Serializable]
    public class PlayerList
    {
        public DataPlayer[] player;
    }

    public PlayerList playerList = new PlayerList();
    public PlayerList newPlayerList = new PlayerList();


    public void LoadDataFromFile()
    {
        Debug.Log("============ Loading... ============");
        playerList = JsonUtility.FromJson<PlayerList>(UserDataFile.text);
        Debug.Log("This is count form Json New Data : "+playerList.player.Length);
        Debug.Log("======== Load Json Complete ========");
    }
    public void SaveToJson(string unametext, int uscoretext)
    {
        DataPlayer newPlayer = new DataPlayer { uname=unametext, uscore=uscoretext};
        newPlayerList.player = new DataPlayer[playerList.player.Length + 1];
        Array.Copy(playerList.player, newPlayerList.player, playerList.player.Length);
        newPlayerList.player[newPlayerList.player.Length - 1] = newPlayer;

        string stringtext = JsonUtility.ToJson(newPlayerList);
        File.WriteAllText(Application.dataPath+"/My Script/UserDataFile.json", stringtext);
    }
}
