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
        public PlayerList(DataPlayer[] datas)
        {
            this.player = datas;
        }
        public DataPlayer[] player;
    }
    public PlayerList playerList;

    public PlayerList newPlayerList;

    string path ;
    void Awake()
    {
        this.path = Application.persistentDataPath +"/UserDataFile.json";
    }
    public void LoadDataFromFile()
    {   
        if (File.Exists(this.path))
        {
            var jsonstring = File.ReadAllText(this.path);
            playerList = JsonUtility.FromJson<PlayerList>(jsonstring);
        }
        else
        {
            playerList = new PlayerList(
                new DataPlayer[1]{new DataPlayer("Nattawat",5943)}
            );
        }

    }
    public void SaveToJson(string unametext, int uscoretext)
    {
        DataPlayer newPlayer = new DataPlayer(unametext, uscoretext);
        newPlayerList.player = new DataPlayer[playerList.player.Length + 1];
        Array.Copy(playerList.player, newPlayerList.player, playerList.player.Length);
        newPlayerList.player[newPlayerList.player.Length - 1] = newPlayer;

        string stringtext = JsonUtility.ToJson(newPlayerList);
        File.WriteAllText(this.path, stringtext);
    }
}
