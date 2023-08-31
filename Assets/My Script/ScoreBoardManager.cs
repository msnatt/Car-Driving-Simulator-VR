using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoardManager : MonoBehaviour
{
    CRUDToJsonManager crudtojsonmanager;
    [SerializeField] private Transform ListscoreboardItem_prefab;
    [SerializeField] private Transform header_itemlist;
    [SerializeField] List<PlayerUI> templist = new List<PlayerUI>();

    DataPlayer[] tempdataload;
    public void Start()
    {
        crudtojsonmanager = FindObjectOfType<CRUDToJsonManager>();
        crudtojsonmanager.LoadDataFromFile();
        CreateitemListFromJson();
    }

    public void CreateitemListFromJson()
    {
        Deleteitem();
        int count = 0;
        if (crudtojsonmanager.newPlayerList.player.Count() == 0)
        {
            tempdataload = crudtojsonmanager.playerList.player; 
        }
        else
        {
            tempdataload = crudtojsonmanager.newPlayerList.player; 
        }

        List<DataPlayer> sort = ChangeArraystoList(tempdataload);

        foreach (DataPlayer playeritem in sort)
        {
            Debug.Log("Create item is "+playeritem.uname+" is "+playeritem.uscore);
            count += 1;
            Transform playeritemtranform = Instantiate(ListscoreboardItem_prefab,header_itemlist);
            PlayerUI player = playeritemtranform.GetComponent<PlayerUI>();
            templist.Add(player);
            player.uno.text = count.ToString();
            player.uname.text = playeritem.uname;
            player.uscore.text = playeritem.uscore.ToString();
        }
    }
    List<DataPlayer> ChangeArraystoList(DataPlayer[] dataPlayers)
    {
        List<DataPlayer> PlayerList = dataPlayers.ToList();
        List<DataPlayer> sort = SortArrays(PlayerList);
        return sort;
    }

    void Deleteitem()
    {
        foreach (PlayerUI temp in templist)
        {
            Destroy(temp.gameObject);
        }
        templist.Clear();
    }

    List<DataPlayer> SortArrays(List<DataPlayer> NotSort)
    {
        List<DataPlayer> newSort = new List<DataPlayer>();
        DataPlayer scorecheck = new DataPlayer("",0);


        for (int i=0;i<NotSort.Count;i++)
        {
            scorecheck = NotSort[i];
            for (int j=0;j<NotSort.Count;j++)
            {
                if (NotSort[j].uscore > scorecheck.uscore)
                {
                    scorecheck = NotSort[j];
                }
            }
            newSort.Add(scorecheck);
            NotSort.Remove(scorecheck);
            i=-1;
            
        }
        return newSort;
    }
}
