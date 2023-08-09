using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchMenu : MonoBehaviour
{
    public GameObject BackgroundStart;
    public GameObject BackgroundSecondStart;
    public GameObject BackgroundSelect;
    public GameObject BackgroundSetting;
    void Start()
    {
        //index = 0;
        BackgroundStart.gameObject.SetActive(true);
        BackgroundSelect.gameObject.SetActive(false);
        BackgroundSetting.gameObject.SetActive(false);
        BackgroundSecondStart.gameObject.SetActive(false);
        Debug.Log("Update Menu");
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Quit escape");
            Application.Quit();
        }
    }

    public void selectlevel()
    {
        BackgroundStart.gameObject.SetActive(false);
        BackgroundSelect.gameObject.SetActive(true);
        BackgroundSetting.gameObject.SetActive(false);
        BackgroundSecondStart.gameObject.SetActive(false);
    }

    public void Back()
    {
        BackgroundStart.gameObject.SetActive(true);
        BackgroundSelect.gameObject.SetActive(false);
        BackgroundSetting.gameObject.SetActive(false);
        BackgroundSecondStart.gameObject.SetActive(false);
    }
    public void SettingGame()
    {
        BackgroundStart.gameObject.SetActive(false);
        BackgroundSelect.gameObject.SetActive(false);
        BackgroundSetting.gameObject.SetActive(true);
        BackgroundSecondStart.gameObject.SetActive(false);
    }
    public void secondStart()
    {
        BackgroundStart.gameObject.SetActive(false);
        BackgroundSelect.gameObject.SetActive(false);
        BackgroundSetting.gameObject.SetActive(false);
        BackgroundSecondStart.gameObject.SetActive(true);
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
