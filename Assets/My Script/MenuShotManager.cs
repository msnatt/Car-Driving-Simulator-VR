using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuShotManager : MonoBehaviour
{
    [SerializeField] GameObject questUI;
    [SerializeField] private TextMeshProUGUI LevelText;
    [SerializeField] private TextMeshProUGUI QuestText;
    [SerializeField] private TextMeshProUGUI DetailText;
    [SerializeField] private GameObject tutorialsUI;
    private bool isquestactive;
    private bool istutorialsactive;
    private int currentlevel;
    private int currentimage = 1;
    

    [SerializeField] private List<string> LevelTextList = new List<string>(){
        "Level 1",
        "Level 2",
        "Level 3",
        "Level 4",
        "Level 5"
    };
    [SerializeField] private List<string> QuestTextList = new List<string>(){
        "Quest : Go to Destination.",
        "Quest : Control Steering and go to Destination.",
        "Quest : Go to the destination and backwards to the destination.",
        "Quest : Follow the path to reach the destination.",
        "Quest : Find a route to reach your destination."
    };
    [SerializeField] private List<GameObject> imagesList = new List<GameObject>();


    void Start()
    {
        isquestactive = false;
        istutorialsactive = true;
        currentlevel = SceneManager.GetActiveScene().buildIndex;
        QuestUI();
    }

    public void QuestUI()
    {
        if (!isquestactive)
        {
            LevelText.text = LevelTextList[currentlevel-1];
            QuestText.text = QuestTextList[currentlevel-1];
            isquestactive = true;
            questUI.SetActive(isquestactive);
        }
        else{
            isquestactive = false;
            questUI.SetActive(isquestactive);
        }
    }
    public void TutorialsUI()
    {
        if (!istutorialsactive)
        {
            istutorialsactive = true;
            tutorialsUI.SetActive(istutorialsactive);
        }
        else{
            istutorialsactive = false;
            tutorialsUI.SetActive(istutorialsactive);
        }
    }

    public void NextImage()
    {
        if (currentimage >= 1 & currentimage < imagesList.Count)
        {
            currentimage += 1;
        } 
    }
    public void PreviousImage()
    {
        if (currentimage > 1 & currentimage <= imagesList.Count+1)
        {
            currentimage -= 1;
        }   
        
    }

    void Update()
    {
        SwitchImage();
    }

    private void SwitchImage()
    {
        switch (currentimage)
        {
            case 1:
                imagesList[0].SetActive(true);
                imagesList[1].SetActive(false);
            break;
            case 2:
                imagesList[0].SetActive(false);
                imagesList[1].SetActive(true);
            break;
        }
    }
}
