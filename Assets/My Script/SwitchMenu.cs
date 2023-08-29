using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMenu : MonoBehaviour
{
    public GameObject BackgroundStart;
    public GameObject BackgroundSecondStart;
    public GameObject BackgroundSelect;
    public GameObject BackgroundSetting;
    public GameObject BackgroundScoreboard;
    void Start()
    {
        StartMenu();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Quit escape");
            Application.Quit();
        }
    }
    public void StartMenu()
    {
        BackgroundStart.SetActive(true);
        BackgroundSelect.SetActive(false);
        BackgroundSetting.SetActive(false);
        BackgroundSecondStart.SetActive(false);
        BackgroundScoreboard.SetActive(false);
    }

    public void selectlevel()
    {
        BackgroundStart.SetActive(false);
        BackgroundSelect.SetActive(true);
        BackgroundSetting.SetActive(false);
        BackgroundSecondStart.SetActive(false);
        BackgroundScoreboard.SetActive(false);
    }

    public void Back()
    {
        BackgroundStart.SetActive(true);
        BackgroundSelect.SetActive(false);
        BackgroundSetting.SetActive(false);
        BackgroundSecondStart.SetActive(false);
        BackgroundScoreboard.SetActive(false);
    }
    public void SettingGame()
    {
        BackgroundStart.SetActive(false);
        BackgroundSelect.SetActive(false);
        BackgroundSetting.SetActive(true);
        BackgroundSecondStart.SetActive(false);
        BackgroundScoreboard.SetActive(false);
    }
    public void secondStart()
    {
        BackgroundStart.SetActive(false);
        BackgroundSelect.SetActive(false);
        BackgroundSetting.SetActive(false);
        BackgroundSecondStart.SetActive(true);
        BackgroundScoreboard.SetActive(false);
    }
    public void Scoreboard()
    {
        
        BackgroundStart.SetActive(false);
        BackgroundSelect.SetActive(false);
        BackgroundSetting.SetActive(false);
        BackgroundSecondStart.SetActive(false);
        BackgroundScoreboard.SetActive(true);
    }
    

    public void ExitGame()
    {
        if (true)
        {   
            Debug.Log("Quit button");
            Application.Quit();
        }
    }
}
