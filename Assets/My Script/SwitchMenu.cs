using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchMenu : MonoBehaviour
{
    public GameObject BackgroundStart;
    public GameObject BackgroundSelect;
    //public GameObject Backgroundxxx;

    public int index;
    void Start()
    {
        //index = 0;
        BackgroundStart.gameObject.SetActive(true);
        BackgroundSelect.gameObject.SetActive(false);
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
        //index = 1;
        //if(index == 1)
        //{
        BackgroundStart.gameObject.SetActive(false);
        BackgroundSelect.gameObject.SetActive(true);
        //}

    }

    public void Back()
    {
        //index = 0;
        BackgroundStart.gameObject.SetActive(true);
        BackgroundSelect.gameObject.SetActive(false);
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
